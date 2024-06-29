using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanTV.Data;
using BanTV.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BanTV.Controllers
{
    public class NhanViensController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<NhanVien> _nvpasswordHasher;
        public NhanViensController(ApplicationDbContext context, IPasswordHasher<NhanVien> nvpasswordHasher)
        {
            _context = context;
            _nvpasswordHasher = nvpasswordHasher;
        }
        public void GetInfo()
        {
            string email = HttpContext.Session.GetString("nhanvien");
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Email == email);
        }
        // GET: NhanViens
        public async Task<IActionResult> Index()
        {
            GetInfo();
            return View(await _context.NhanVien.ToListAsync());
        }

        // GET: NhanViens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .FirstOrDefaultAsync(m => m.Manv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public IActionResult Create()
        {
            GetInfo();
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Manv,Ten,Dienthoai,Email,Matkhau,Quyen")] NhanVien nhanVien, int quyen)
        {
            if (ModelState.IsValid)
            {
                if (quyen == 1)
                {
                    nhanVien.Quyen = 1;
                }
                else
                {
                    if (quyen == 0)
                    {
                        nhanVien.Quyen = 0;
                    }
                    else
                    {
                        nhanVien.Quyen = 2;
                    }
                   
                }
                nhanVien.Matkhau = _nvpasswordHasher.HashPassword(nhanVien, nhanVien.Matkhau);
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            GetInfo();
            return View(nhanVien);
        }

        // GET: NhanViens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int manv, string hoten, string email, string matkhau, int quyen)
        {
            NhanVien nv = _context.NhanVien.FirstOrDefault(n => n.Manv == manv);
            if (nv != null)
            {
                if (matkhau != null)
                {
                    nv.Matkhau = _nvpasswordHasher.HashPassword(nv, matkhau);
                }
                nv.Ten = hoten;

                nv.Email = email;
                nv.Quyen = quyen;
                _context.Update(nv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            GetInfo();
            return RedirectToAction(nameof(Edit));
        }

        // GET: NhanViens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .FirstOrDefaultAsync(m => m.Manv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhanVien = await _context.NhanVien.FindAsync(id);
            _context.NhanVien.Remove(nhanVien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienExists(int id)
        {
            return _context.NhanVien.Any(e => e.Manv == id);
        }
      

    }
}
