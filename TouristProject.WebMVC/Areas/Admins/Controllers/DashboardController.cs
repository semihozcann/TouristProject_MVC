using Microsoft.AspNetCore.Mvc;
using TouristProject.WebMVC.Abstract;

namespace TouristProject.WebMVC.Areas.Admins.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(IUserAccessor userAccessor) : base(userAccessor)
        {
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
