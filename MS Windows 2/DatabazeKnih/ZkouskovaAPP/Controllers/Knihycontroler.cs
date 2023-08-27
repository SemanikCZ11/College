using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZkouskovaAPP.Models;

namespace ZkouskovaAPP.Controllers
{
    public class KnihyController : Controller
    {
        private readonly BookContext _context;

        public KnihyController(BookContext context)
        {
            _context = context;
        }

        // Zobrazit všechny knihy
        public async Task<IActionResult> Index()
        {
            return View(await _context.Knihy.ToListAsync());
        }

        // Detail knihy
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kniha = await _context.Knihy.FindAsync(id);
            if (kniha == null)
            {
                return NotFound();
            }

            return View(kniha);
        }

        // Vytvořit novou knihu
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Books kniha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kniha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kniha);
        }

        // Upravit knihu
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kniha = await _context.Knihy.FindAsync(id);
            if (kniha == null)
            {
                return NotFound();
            }
            return View(kniha);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Books kniha)
        {
            if (id != kniha.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(kniha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kniha);
        }

        // Smazat knihu
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kniha = await _context.Knihy.FindAsync(id);
            if (kniha == null)
            {
                return NotFound();
            }

            return View(kniha);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kniha = await _context.Knihy.FindAsync(id);
            _ = _context.Knihy.Remove(kniha);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
