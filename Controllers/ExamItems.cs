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
                new ExamItem { Id = 2, Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?", Answer = "B. Database-First" },
                new ExamItem { Id = 3, Question = "What is the primary purpose of Entity Framework Core?", Answer = "C. To map objects in code to relational database data" },
                new ExamItem { Id = 4, Question = "Which EF Core component is primarily responsible for communicating with the database?", Answer = "A. DbContext" },
            };

            return View(questions);
        }
    }
}