using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Http;
using System.IO;
using BanTV.Data;
using BanTV.Models;
using System.Data;
using ClosedXML.Excel;

namespace BanTV.Controllers
{
    public class MatHangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatHangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetInfo()
        {
            string email = HttpContext.Session.GetString("nhanvien");
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Email == email);
        }

        // GET: MatHangs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation).OrderByDescending(H => H.Mamh);
            GetInfo();
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MatHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang
                .Include(m => m.MadmNavigation)
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (matHang == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(matHang);
        }

        // GET: MatHangs/Create
        public IActionResult Create()
        {
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten");
            GetInfo();
            return View();
        }

        // POST: MatHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mamh,Ten,Giagoc,Giaban,Soluong,Mota,Hinhanh,Madm,hot")] MatHang matHang, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //upload ảnh
                matHang.Hinhanh = Upload(file);
                matHang.Daxoa = 0;
                
                _context.Add(matHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", matHang.Madm);
            GetInfo();
            return View(matHang);
        }

        // GET: MatHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang.FindAsync(id);
            if (matHang == null)
            {
                return NotFound();
            }
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", matHang.Madm);
            GetInfo();
            return View(matHang);
        }

        // POST: MatHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int mamh,int daxoa, string ten, int giaban, int giagoc, int soluong,string mota, string hinhanh,int luotxem,int luotmua,int madm,int hot, IFormFile file)
        {
            MatHang nv = _context.MatHang.FirstOrDefault(n => n.Mamh == mamh);
            if (nv != null)
            {
                nv.Mamh = mamh;
                nv.Ten = ten;
                nv.Giagoc = giagoc;
                nv.Giaban = giaban;
                nv.Soluong = soluong;
                nv.Mota = mota;
                nv.Madm = madm;
                nv.luotxem = luotxem;
                nv.luotmua = luotmua;
                nv.Daxoa = daxoa;
                nv.hot = hot;
                if (file != null)
                {
                    nv.Hinhanh = hinhanh;
                        hinhanh =Upload(file);
                }
                _context.Update(nv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Edit));
        }

        // GET: MatHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang
                .Include(m => m.MadmNavigation)
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (matHang == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(matHang);
        }

        // POST: MatHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matHang = await _context.MatHang.FindAsync(id);
            matHang.Daxoa = 1;
            _context.MatHang.Update(matHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatHangExists(int id)
        {
            return _context.MatHang.Any(e => e.Mamh == id);
        }
        public string Upload(IFormFile file)
        {
            string uploadFileName = null;
            if (file != null)
            {
                // phát sinh tên file mới: chuỗi ngẫu nhiên_tên ảnh
                uploadFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // chép file về thư mục lưu trữ ảnh
                var path = $"wwwroot\\images\\images\\{uploadFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            }
            return uploadFileName; // trả về tên file
        }
        public async Task<IActionResult> Search(string SearchKey)
        {
            var lstHang = await _context.MatHang.Include(m => m.MadmNavigation)
                            .Where(k => k.Ten.Contains(SearchKey) && k.Daxoa == 0).ToListAsync();
            GetInfo();
            return View(lstHang);
        }


        [HttpGet]
        public async Task<FileResult> ex()
        {
            var mathang = await _context.MatHang.ToListAsync();
            var fil = "mathang.xlsx";
            return Excel(fil, mathang);
        }

        private FileResult Excel(string fil, IEnumerable<MatHang> mathang)
        {
            DataTable data = new DataTable("mathang");
            data.Columns.AddRange(new DataColumn[]
            {
              new DataColumn("Mã mặt hàng"),
              new DataColumn("Tên măth hàng"),
              new DataColumn("Giá gốc"),
              new DataColumn("Giá Bán"),
              new DataColumn("Số lượng"),
              new DataColumn("Mô tả"),
              new DataColumn("Lượt mua"),
              new DataColumn("Lượt xem")
            });

            foreach (var p in mathang)
            {
                data.Rows.Add(p.Mamh, p.Ten, p.Giagoc, p.Giaban, p.Soluong, p.Mota,p.luotmua,p.luotxem);
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

       

    }
}
