﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using TouristProject.Entities.Concrete;

namespace TouristProject.WebMVC.Helpers
{

    public class CustomAuthorize : Attribute, IAuthorizationFilter
    {
        public string Roles { get; set; }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Authentication
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (!context.HttpContext.User.IsInRole(Roles))
                {
                    context.Result = new RedirectToActionResult("Unauthorize", "Account", new { area = "" });
                    
                }
            }
            else
            {

                if (Roles.Contains("Admin"))
                {
                    context.Result = new RedirectToActionResult("Index", "Dashboard", new { area = "" });

                }
                else if(Roles.Contains("User"))
                {
                    context.Result = new RedirectToPageResult("Index", "Dashboard", new { area = "Users" });
                }
                else
                {
                    context.Result = new RedirectToActionResult("Login", "Account", new { area = "" });
                }
            }
            
        }

    }


}
