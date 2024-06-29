using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanTV.Data;
using BanTV.Models;
using Microsoft.AspNetCore.Http;

namespace BanTV.Controllers
{
    public class DanhMucsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DanhMucsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public void GetInfo()
        {
            string email = HttpContext.Session.GetString("nhanvien");
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Email == email);
            ViewBag.mathang = _context.MatHang.ToList();

        }
        // GET: DanhMucs
        public async Task<IActionResult> Index()
        {
            GetInfo();
            return View(await _context.DanhMuc.ToListAsync());
        }

        // GET: DanhMucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhMuc = await _context.DanhMuc
                .FirstOrDefaultAsync(m => m.Madm == id);
            if (danhMuc == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(danhMuc);
        }

        // GET: DanhMucs/Create
        public IActionResult Create()
        {
            GetInfo();
            return View();
        }

        // POST: DanhMucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Madm,Ten")] DanhMuc danhMuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(danhMuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            GetInfo();
            return View(danhMuc);
        }

        // GET: DanhMucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhMuc = await _context.DanhMuc.FindAsync(id);
            if (danhMuc == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(danhMuc);
        }

        // POST: DanhMucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Madm,Ten")] DanhMuc danhMuc)
        {
            if (id != danhMuc.Madm)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(danhMuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DanhMucExists(danhMuc.Madm))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            GetInfo();
            return View(danhMuc);
        }

        // GET: DanhMucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhMuc = await _context.DanhMuc
                .FirstOrDefaultAsync(m => m.Madm == id);
            if (danhMuc == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(danhMuc);
        }

        // POST: DanhMucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var danhMuc = await _context.DanhMuc.FindAsync(id);
            _context.DanhMuc.Remove(danhMuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DanhMucExists(int id)
        {
            return _context.DanhMuc.Any(e => e.Madm == id);
        }
        public async Task<IActionResult> Search(string SearchKey)
        {
            var lstHang = await _context.DanhMuc.Include(m => m.MatHang)
                            .Where(k => k.Ten.Contains(SearchKey)).ToListAsync();
            GetInfo();
            return View(lstHang);
        }
    }
}
