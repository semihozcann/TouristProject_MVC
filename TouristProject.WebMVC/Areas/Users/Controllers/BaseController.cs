using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TouristProject.Entities.Concrete;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Helpers;

namespace TouristProject.WebMVC.Areas.Users.Controllers
{
    [Authorize(Roles = "User")]
    [Area("Users")]
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
