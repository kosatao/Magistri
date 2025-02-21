using Magistri.DTO;
using Magistri.Services;
using Microsoft.AspNetCore.Mvc;

namespace Magistri.Controllers
{
    public class StudentsController : Controller
    {
        private StudentService studentService;

        public StudentsController(StudentService service)
        {
            studentService = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var allStudents = studentService.GetAllStudents();
            return View(allStudents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync (StudentDto studentDto)
        {
            await studentService.CreateStudentAsync(studentDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> EditAsync(int id)
        {
            var studentToEdit = await studentService.GetByIdAsync(id);
            if (studentToEdit == null)
            {
                return View("NotFound");
            }
                return View(studentToEdit);
        }
        [HttpPost]

        public async Task<IActionResult> EditAsync (int id, StudentDto student)
        {
            await studentService.UpdateAsync(id, student);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var studentToDelete = await studentService.GetByIdAsync(id);
            if (studentToDelete == null)
            {
                return View("NotFound");
            }
            await studentService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
