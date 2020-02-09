﻿using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelectACourse.WebApp.ViewModels;
using SelectACourse.WebApp.Services;
using SelectACourse.WebApp.Models;

namespace SelectACourse.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ThirdPartyService _thirdPartyService;
        private readonly StudentInfo _studentInfo;

        public HomeController(ILogger<HomeController> logger,
            ThirdPartyService thirdPartyService, StudentInfo studentInfo)
        {
            _logger = logger;
            _thirdPartyService = thirdPartyService;
            _studentInfo = studentInfo;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel()
            {
                Courses = await _thirdPartyService.GetCourses(),
                StudentId = _studentInfo.StudentId
            };

            return View(viewModel);
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

        [HttpPost]
        public async Task<IActionResult> Enrol(HomeViewModel homeViewModel, string courseId)
        {
            await _thirdPartyService.Enrol(homeViewModel.StudentId, courseId);

            return Ok();
        }
    }
}
