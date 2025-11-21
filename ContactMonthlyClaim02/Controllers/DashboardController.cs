using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace ContactMonthlyClaim02.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult LecturerDashboard()
        {
            return View();
        }

        public IActionResult CoordinatorDashboard()
        {
            return View();
        }

        public IActionResult AcademicManagerDashboard()
        {
            return View();
        }

        public IActionResult HR_Dashboard()
        {
            return View();
        }


    }
}

