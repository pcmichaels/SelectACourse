using Microsoft.AspNetCore.Mvc;
using SelectACourse.WebApp.Models;
using SelectACourse.WebApp.ViewModels;

namespace SelectACourse.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly StudentInfo _studentInfo;

        public LoginController(StudentInfo studentInfo)
        {
            _studentInfo = studentInfo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel loginViewModel)
        {
            _studentInfo.StudentId = loginViewModel.StudentId;

            return RedirectToAction("Index", "Home");
        }
    }
}