#pragma checksum "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1b4c565dcea14b42683e17c6b1ab06a978407ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ServiceDefine), @"mvc.1.0.view", @"/Views/Admin/ServiceDefine.cshtml")]
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
#line 1 "D:\CompanyPanel\CompanyPanelUI\Views\_ViewImports.cshtml"
using CompanyPanelUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CompanyPanel\CompanyPanelUI\Views\_ViewImports.cshtml"
using CompanyPanelUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b4c565dcea14b42683e17c6b1ab06a978407ff", @"/Views/Admin/ServiceDefine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b964cc9676e9dd9414a58e3cd42d993044ca2d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ServiceDefine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Firm>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
  
    ViewData["Title"] = "ServiceDefine";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<br />
 
 
                        <div class=""card-body"">
                        <table class=""table table-bordered"">
                        <thead>
                        <tr>
                        <th style=""width: 10px"">#</th>
                        <th>Şirket Adı</th>
                        <th>Şirket Vergi Numarası</th>
                        <th>Şirket Telefon Numarası</th>
                        <th>Şirket Mail</th>
                        <th style=""width: 40px"">Şirket Seç</th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                             foreach(var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                           \r\n                        <td>");
#nullable restore
#line 30 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                       Write(item.FirmId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                       Write(item.FirmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                       Write(item.FirmTaxNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                       Write(item.FirmTelNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                       Write(item.FirmMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1210, "\"", 1257, 2);
            WriteAttributeValue("", 1217, "/Admin/ServiceDefineForFirm/", 1217, 28, true);
#nullable restore
#line 36 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
WriteAttributeValue("", 1245, item.FirmId, 1245, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"badge bg-danger\">Şirket Hizmet Tanımlaması Yap</span></a>\r\n                              \r\n                        </td>\r\n                       \r\n                        </tr>\r\n");
#nullable restore
#line 41 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\ServiceDefine.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                        </table>\r\n                        </div>\r\n\r\n             \r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Firm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
