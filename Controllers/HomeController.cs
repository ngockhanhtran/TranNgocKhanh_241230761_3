using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TranNgocKhanh_241230761_3.Models;

namespace TranNgocKhanh_241230761_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly QltaiSanContext _context;
        public HomeController(QltaiSanContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.TaiSans.Where(ts => ts.NguyenGia != null && ts.NguyenGia >= 20).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult LocTheoLoai(int id)
        {
            var loc = _context.TaiSans.Where(ts => ts.MaLoai == id && ts.NguyenGia != null && ts.NguyenGia >= 20).ToList();
            return PartialView("TranNgocKhanh_MainContent", loc);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
