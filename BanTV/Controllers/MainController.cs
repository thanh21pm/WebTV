using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanTV.Data;
using BanTV.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Data;
using ClosedXML.Excel;
using System.IO;

namespace BanTV.Controllers
{
    public class MainController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainController(ApplicationDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            GetInfo();
            return View();
        }

        // Thống kê theo ngày
        public IActionResult ThongKeTheoNgay()
        {
            GetInfo();
            return View();
        }

        [HttpPost]
        public IActionResult XemThongKeTheoNgay(DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            var lstHD = _context.HoaDon.Include(m => m.MakhNavigation).Where(d => d.Ngay >= Ngaybatdau && d.Ngay <= Ngayketthuc && d.Trangthai == 3);
            int tongtien = 0;
            foreach (HoaDon hd in lstHD)
            {
                tongtien += hd.Tongtien;
            }
            ViewData["ngaybatdau"] = Ngaybatdau.Day.ToString() + "/" + Ngaybatdau.Month.ToString() + "/" + Ngaybatdau.Year.ToString();
            ViewData["ngayketthuc"] = Ngayketthuc.Day.ToString() + "/" + Ngayketthuc.Month.ToString() + "/" + Ngayketthuc.Year.ToString();
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHD);
        }

        public IActionResult ThongKeMatHangTheoNgay()
        {
            GetInfo();
            return View();
        }
        public IActionResult XemThongKeMatHangTheoNgay(DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            var lstHD = _context.CthoaDon.Include(m => m.MamhNavigation).Include(n =>n.MahdNavigation).Where(d => d.MahdNavigation.Ngay >= Ngaybatdau && d.MahdNavigation.Ngay <= Ngayketthuc && d.MahdNavigation.Trangthai == 3);
         
            ViewData["ngaybatdau"] = Ngaybatdau.Day.ToString() + "/" + Ngaybatdau.Month.ToString() + "/" + Ngaybatdau.Year.ToString();
            ViewData["ngayketthuc"] = Ngayketthuc.Day.ToString() + "/" + Ngayketthuc.Month.ToString() + "/" + Ngayketthuc.Year.ToString();
         
            GetInfo();
            return View(lstHD);
        }
     
       

        public IActionResult ThongKeKhachHang()
        {
            GetInfo();
            return View();
        }

        public IActionResult XemThongKeKhachHang(string emailkhachhang)
        {
            var lstHoaDon = _context.HoaDon.Include(m => m.MakhNavigation)
                            .Where(h => h.MakhNavigation.Email == emailkhachhang && h.MakhNavigation.Matkhau != null && h.Trangthai == 3);
            int tongtien = 0;
            foreach (HoaDon hd in lstHoaDon)
            {
                tongtien += hd.Tongtien;
            }
            ViewBag.ttkhachhang = _context.KhachHang.FirstOrDefault(k => k.Email == emailkhachhang && k.Matkhau != null);
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHoaDon);
        }


        public void GetInfo()
        {
            string email = HttpContext.Session.GetString("nhanvien");
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Email == email);
            ViewBag.mathang = _context.MatHang.ToList();
        }

        // Thống kê theo mặt hàng
        public IActionResult ThongKeTheoMatHang()
        {
            GetInfo();
            return View();
        }

        [HttpPost]
        public IActionResult XemThongKeTheoMatHang(int id)
        {
            var lstctHD = _context.CthoaDon.Include(m => m.MamhNavigation).Where(n=>n.MahdNavigation.Trangthai==3).Where(j => j.Mamh == id);
            int tongtien = 0;
            foreach (CthoaDon cthd in lstctHD)
            {
                tongtien += cthd.Thanhtien;
            }
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstctHD);
        }


        public async Task<IActionResult> Details(int id)
        {
            var hd = _context.CthoaDon.Include(k => k.MamhNavigation).Where(m => m.Mahd == id);
            GetInfo();
            return View(await hd.ToListAsync());
        }

        public IActionResult HoaDonChuaDuyet()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 0);

            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult HoaDonDaDuyet()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 1);

            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult HoaDonDaHuy()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 2);

            GetInfo();
            return View(lstHoaDon);
        }
   



        public IActionResult ChiTietHoaDonChuaDuyet(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonDaDuyet(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonDaHuy(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public async Task<IActionResult> DuyetDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 1;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }

        public async Task<IActionResult> HuyDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 2;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }
        public async Task<IActionResult> VanChuyen(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 6;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }

        public IActionResult HoaDonDagiao()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 3);

            GetInfo();
            return View(lstHoaDon);
        }
        public IActionResult ChiTietHoaDonGiao(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }
    

        public IActionResult HangHoanTra()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 4);

            GetInfo();
            return View(lstHoaDon);
        }
        public IActionResult ChiTietHangHoanTra(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }


        public IActionResult HoaDonCanGiao()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 6);

            GetInfo();
            return View(lstHoaDon);
        }
        public IActionResult ChiTietHoaDonCanGiao(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }
        public async Task<IActionResult> KhachDaNhan(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 5;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }













        public IActionResult Tongdoanhthu(string emailkhachhang)
        {
            var applicationDbContext = _context.HoaDon.Include(m => m.MakhNavigation)
             .Where(h => h.Trangthai == 3);

            int tongtien = 0;
            foreach (HoaDon cthd in applicationDbContext)
            {
                tongtien += cthd.Tongtien;
            }
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(applicationDbContext);
        }
        public IActionResult ChiTietHoaDonTongDoanhThu(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }
        public IActionResult ChiTietHoaDonTheoNgay(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }
        public IActionResult Prints(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }
        public IActionResult ChiTietHoaDonTheoKhachHang(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonTheoMatHang(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }
        public IActionResult Quanlyhangton()
        {
            GetInfo();
            var applicationDbContext = _context.MatHang
                .Include(m => m.MadmNavigation)
                .Where(t => t.Daxoa == 0);
            return View(applicationDbContext);
        }
        public async Task<IActionResult> khong()
        {
             GetInfo();
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation).Where(t => t.Daxoa == 0);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpGet]
        public async Task<FileResult> excel()
        {

            List<HoaDon> hd = await _context.HoaDon.Include(m => m.MakhNavigation).Where(n => n.Trangthai == 3).ToListAsync();
            var fil = "Hoadon.xlsx";
            return Excel(fil, hd);
        }

        private FileResult Excel(string fil, IEnumerable<HoaDon> hd)
        {
            DataTable data = new DataTable("hd");
            data.Columns.AddRange(new DataColumn[]
            {
              new DataColumn("Mã hóa đơn"),
              new DataColumn("Mã khách hàng"),
              new DataColumn("Tên khách hàng"),
              new DataColumn("Email"),
              new DataColumn("Số điện thoại"),
              new DataColumn("Ngày lập"),
              new DataColumn("Tổng tền")
              
            });
           
            foreach (var p in hd)
            {
                data.Rows.Add(p.Mahd, p.Makh,p.MakhNavigation.Ten,p.MakhNavigation.Email,p.MakhNavigation.Dienthoai, p.Ngay, p.Tongtien);
               

            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(data);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fil);
                }
            }
        }



        [HttpGet]
        public async Task<FileResult> excelkhong()
        {

            List<MatHang> hd = await _context.MatHang.Include(m => m.MadmNavigation).Where(n => n.luotmua == 0).ToListAsync();
            var fil = "Mathang.xlsx";
            return Excelkhong(fil, hd);
        }

        private FileResult Excelkhong(string fil, IEnumerable<MatHang> hd)
        {
            DataTable data = new DataTable("hd");
            data.Columns.AddRange(new DataColumn[]
            {
              new DataColumn("Mã mặt hàng"),
              new DataColumn("Tên mặt hàng"),
              new DataColumn("Danh mục hàng"),
              new DataColumn("Số lượng"),
              new DataColumn("Lượt mua")
            

            });

            foreach (var p in hd)
            {
                data.Rows.Add(p.Mamh, p.Ten, p.MadmNavigation.Ten, p.Soluong, p.luotmua);


            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(data);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fil);
                }
            }





        }


        [HttpPost]
        public List<object> Get()
        {
            List<object> data = new List<object>();
            List<DateTime> labels = _context.HoaDon.Where(h => h.Trangthai == 3).Select(m => m.Ngay).ToList();
            List<int> total = _context.HoaDon.Where(h => h.Trangthai == 3).Select(m => m.Tongtien).ToList();
            data.Add(labels);
            data.Add(total);
            return data;
        }


        [HttpPost]
        public List<object> Gets()
        {
            List<object> data = new List<object>();
            List<string> labels = _context.MatHang.Select(m => m.Ten).ToList();
            List<int> total = _context.MatHang.Select(m => m.luotmua).ToList();
            List<int> totals = _context.MatHang.Select(m => m.Soluong).ToList();

            data.Add(labels);
            data.Add(total);
            data.Add(totals);
            return data;
        }
    }
}