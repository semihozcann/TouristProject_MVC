#pragma checksum "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947706c51a86577005228c02f856f52ee9a280cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Users/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\_ViewImports.cshtml"
using TouristProject.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\_ViewImports.cshtml"
using TouristProject.WebMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\_ViewImports.cshtml"
using TouristProject.WebMVC.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\_ViewImports.cshtml"
using TouristProject.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"947706c51a86577005228c02f856f52ee9a280cf", @"/Areas/Users/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac3d094c3017421e6a485fdb788ffed3da00d18", @"/Areas/Users/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Users_Views_Dashboard_Index : TouristProject.WebMVC.Helpers.BaseViewPage<TouristProject.WebMVC.Models.Nutrients.NutrientListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "/Index";
    Layout = "~/Areas/Users/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"cartDiv\">\n");
#nullable restore
#line 10 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
         foreach (var nutrient in Model.Nutrients.Nutrients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 15rem;\">\n                <img src=\"/img/yemek.jpg\" class=\"card-img-top\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
                                      Write(nutrient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
                                    Write(nutrient.SmallDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                    <div class=""ratings"">
                        <div class=""row"">
                            <div class=""col-sm-7"">
                                <i class=""fa fa-star rating-color""></i>
                                <i class=""fa fa-star rating-color""></i>
                                <i class=""fa fa-star rating-color""></i>
                                <i class=""fa fa-star rating-color""></i>
                                <i class=""fa fa-star""></i>
                                <h5 class=""review-count"">12 Yorum</h5>
                            </div>
                            <div class=""col-sm-5"">
                                <a href=""#"" class=""btn btn-primary"" id=""cardCommentButton"">Yorumları Oku</a>
                            </div>
                        </div>

                    </div>
                    <br>
                    <a href=""#"" class=""btn btn-primary"" id=""cardButton"">Detaylı Bilgi</a>
                </div>
            </div>
");
#nullable restore
#line 40 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Bir kayıt bulunamadı</p>\n");
#nullable restore
#line 45 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Users\Views\Dashboard\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TouristProject.WebMVC.Models.Nutrients.NutrientListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
