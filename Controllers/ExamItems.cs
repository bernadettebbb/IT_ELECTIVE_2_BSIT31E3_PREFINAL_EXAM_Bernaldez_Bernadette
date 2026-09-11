using Microsoft.AspNetCore.Mvc;
using PREFINAL_EXAM.Models;

namespace PREFINAL_EXAM.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<ExamItem>
            {
                new ExamItem { Id = 1, Question = "What is the main problem solved by using a database instead of an in-memory collection?", Answer = "C. It allows data to persist after the application stops" },
            };

            return View(questions);
        }
    }
}