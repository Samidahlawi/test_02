using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aa.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aa.Controllers
{
    public class StudentsController : Controller
    {

        private List<StudentModel>  Students = new List<StudentModel>()
            {
                new StudentModel { Id = 1, Name = "Ghada"},
                new StudentModel { Id = 2, Name = "Hatem"},
                new StudentModel { Id = 3, Name = "Sami"}
            };

        // GET: /students/
        public IActionResult Index()
        {
            //string[] names = { "Ghada","hatem","Sami"};

            //ViewData["AllNames"] = names;
            //Console.WriteLine(names.GetType());
            //Console.WriteLine(ViewData["AllNames"].GetType());

            ViewData["Students"] = Students;

            return View(); 
        }

        // GET: /Students/Detials/id
        // GET: /Students/Detials/3
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return Content("Please, make sure you insert the Id.Thanks ^_^");
            }
            else
            {
                    StudentModel Student = Students.Find(student => student.Id == id);
                    ViewData["Student"] = Student;
            }
            return View(); 
        }

    }
}
