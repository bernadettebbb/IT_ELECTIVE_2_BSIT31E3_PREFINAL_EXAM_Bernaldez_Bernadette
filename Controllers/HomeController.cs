using IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Bernaldez_Bernadette.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Bernaldez_Bernadette.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
