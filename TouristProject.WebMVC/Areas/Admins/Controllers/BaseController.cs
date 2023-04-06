using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Helpers;

namespace TouristProject.WebMVC.Areas.Admins.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admins")]
    public class BaseController : Controller
    {
        IUserAccessor _userAccessor;
        public BaseController(IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }

        public Entities.Concrete.User CurrentUser
        {
            get
            {
                if (User != null)
                {
                    return _userAccessor.GetUser();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
