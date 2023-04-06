using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor;
using TouristProject.Entities.Concrete;
using TouristProject.WebMVC.Abstract;

namespace TouristProject.WebMVC.Helpers
{
    public abstract class BaseViewPage<TModel> : RazorPage<TModel>
    {
        [RazorInject]
        public IUserAccessor _userAccessor { get; set; }

        public User CurrentUser
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
