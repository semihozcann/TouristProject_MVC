using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;

namespace TouristProject.Business.Abstract
{
    public interface IAuthenticationService
    {
        bool CreateUser(User user, string password);
        Task<bool> SignOut();
        User AuthenticateUser(string userName, string password);
        User GetUser(string username);


    }
}
