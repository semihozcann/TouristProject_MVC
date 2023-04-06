using Microsoft.AspNetCore.Mvc;
using TouristProject.Entities.Concrete;
using TouristProject.WebMVC.Abstract;

namespace TouristProject.WebMVC.Controllers
{
    public class BaseController : Controller
    {
        public User CurrentUser
        {
            get
            {
                if (User != null)
                    return _userAccessor.GetUser();
                else
                    return null;
            }
        }

        IUserAccessor _userAccessor;
        public BaseController(IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }
    }
}
