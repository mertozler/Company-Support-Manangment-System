#pragma checksum "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d96dea98359778f9c502f47f91b057409674f1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserApplicationConfirm), @"mvc.1.0.view", @"/Views/Admin/UserApplicationConfirm.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\_ViewImports.cshtml"
using CompanyPanelUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\_ViewImports.cshtml"
using CompanyPanelUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d96dea98359778f9c502f47f91b057409674f1a", @"/Views/Admin/UserApplicationConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615f8c5c6cc6182552191e89c5aef8975cba7f07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_UserApplicationConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
  
    ViewData["Title"] = "UserApplicationConfirm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
 if(Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card card-primary"">
              <div class=""card-header"">
                <h3 class=""card-title"">Kayıt Bekleyen Kullanıcı Listesi</h3>
              </div>
              
              <br/>
              <div class=""card"">
                        <div class=""card-header"">
                        <h3 class=""card-title"">Kullanıcılar</h3>
                        </div>
 
                        <div class=""card-body"">
                        <table class=""table table-bordered"">
                        <thead>
                        <tr>
                        <th style=""width: 10px"">#</th>
                        <th>Kullanıcı Adı Soyadı</th>
                        <th>Kullanıcının Başvurduğu Şirket</th>
                        <th>Kullanıcının Rolü</th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 33 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
                             foreach(var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                           \n                        <td>");
#nullable restore
#line 37 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
                       Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 38 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
                       Write(item.UserNameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
                       Write(item.UserApplicationFirm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1405, "\"", 1444, 2);
            WriteAttributeValue("", 1412, "/Admin/UserRegister/", 1412, 20, true);
#nullable restore
#line 41 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
WriteAttributeValue("", 1432, item.UserId, 1432, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"badge bg-danger\">Kullanıcı Şirket Kaydı Yap</span></a>\n                              \n                        </td>\n                       \n                        </tr>\n");
#nullable restore
#line 46 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                        </table>\n                        </div>\n\n\n                        </div>\n                        </div>\n");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\UserApplicationConfirm.cshtml"

                      
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
