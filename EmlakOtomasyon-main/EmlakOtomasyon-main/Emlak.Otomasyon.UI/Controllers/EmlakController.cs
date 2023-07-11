using Emlak.Otomasyon.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Emlak.Otomasyon.UI.Controllers
{
    public class EmlakController : Controller
    {
        private EmlakDbContext _context;
        public EmlakController(EmlakDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Emlak.ToList();
            return View(data);
        }

        public IActionResult Detail(int id)
        {
            var data = _context.Emlak.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Detail(Model.Entity.Emlak emlak)
        {
            
            if (emlak.Id > 0)
            {
                _context.Update(emlak);
            }
            else
            {
                _context.Add(emlak);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var entity = _context.Emlak.Find(id);
            _context.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
