#pragma checksum "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7ea7be7164f8727ecb20b7b200055ee93e2e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admins_Views_Categories_GetAllCategories), @"mvc.1.0.view", @"/Areas/Admins/Views/Categories/GetAllCategories.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using TouristProject.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using TouristProject.WebMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using TouristProject.WebMVC.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using TouristProject.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using TouristProject.WebMVC.Models.Categories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7ea7be7164f8727ecb20b7b200055ee93e2e2b", @"/Areas/Admins/Views/Categories/GetAllCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e8471cbd34d05cd9183de466fbb11dee96c058", @"/Areas/Admins/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admins_Views_Categories_GetAllCategories : TouristProject.WebMVC.Helpers.BaseViewPage<CategoryListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("categoryAddButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
  
    ViewData["Title"] = "GetAllCategories";
    Layout = "~/Areas/Admins/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div id=\"addButtonTable\">\r\n        <table>\r\n            <tr>\r\n                <td>Kategori eklemek için ekle butonuna tıklayınız</td>\r\n                <td>:</td>\r\n                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e7ea7be7164f8727ecb20b7b200055ee93e2e2b6054", async() => {
                WriteLiteral("Kategori Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
     if (Model !=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>
            <table class=""table"" id=""categoryListTable"">
                <thead>
                    <tr>
                        <td>Id</td>
                        <td>Kategori Adı</td>
                        <td>Oluşturulma Tarihi</td>
                        <td>Güncellenme Tarihi</td>
                        <td>Güncelle</td>
                        <td>Sil</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 35 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                     foreach (var category in Model.Category.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                           Write(category.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                           Write(category.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1415, "\"", 1460, 2);
            WriteAttributeValue("", 1422, "/Admins/Categories/Update/", 1422, 26, true);
#nullable restore
#line 42 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 1448, category.Id, 1448, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"categoryListTableButton\">Güncelle</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1544, "\"", 1589, 2);
            WriteAttributeValue("", 1551, "/Admins/Categories/Delete/", 1551, 26, true);
#nullable restore
#line 43 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 1577, category.Id, 1577, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"categoryListTableButton\">Sil</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Hiç Kategori Bulunamadı</p>\r\n");
#nullable restore
#line 54 "C:\Users\semih\Desktop\Semih Özcan Tourist_Project\TouristProject_MVC\TouristProject.WebMVC\Areas\Admins\Views\Categories\GetAllCategories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591