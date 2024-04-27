using Asp.intro.Models;
using Asp.intro.Models.ViewModels;
using Asp.intro.Models.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

namespace Asp.intro.Controllers
{
    public class HomeController : Controller
    {

        //public IActionResult Index()
        //{
        //    List<string> students = new List<string> { "Haci", "Ali", "Elnur" };
        //    return View(students);
        //}


        public IActionResult Index()
        {
            var datas = GetAllStudents();

            List<StudentVM> students = new List<StudentVM>();

            foreach (var item in datas)
            {
                students.Add(new StudentVM
                {
                    FullName = item.FullName,
                });
            }


            Book book = new Book()
            {
                Id = 1,
                Name = "1984"
            };


            HomeVM model = new HomeVM()
            {
                Students = students,
                Book = book
            };




            return View(model);
        }



        private List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student {
                    Id = 1,
                    FullName = "Ceyhun",
                    Age = 46
                },
                new Student {
                    Id = 2,
                    FullName = "Yaqub",
                    Age = 54
                },
                new Student {
                    Id = 3,
                    FullName = "Vusal",
                    Age = 43
                },
            };
        }
    }
}
