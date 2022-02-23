#pragma checksum "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb7d368434d37ead1b3159cac36aafbf0a32b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/SidebarPartial.cshtml")]
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
#line 1 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\_ViewImports.cshtml"
using CompanyPanelUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\_ViewImports.cshtml"
using CompanyPanelUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb7d368434d37ead1b3159cac36aafbf0a32b8b", @"/Views/Shared/SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b964cc9676e9dd9414a58e3cd42d993044ca2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    \r\n");
#nullable restore
#line 8 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
  
    var girisYapanKullanici = await UserManager.GetUserAsync(User);
    IList<string> kullaniciRolleri = null;
    if(girisYapanKullanici!=null)
    {
        kullaniciRolleri = await UserManager.GetRolesAsync(girisYapanKullanici);
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
 if (kullaniciRolleri == null)
{
    
}

else if (kullaniciRolleri[0] == "musteri")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
    <!-- Brand Logo -->
    <a href=""/Admin/Index"" class=""brand-link"">

        <span class=""brand-text font-weight-light"">Company Panel</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"">
        <!-- Sidebar user panel (optional) -->
        <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">

            <div class=""info"">
");
#nullable restore
#line 38 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"d-block\">Hoşgeldin ");
#nullable restore
#line 40 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                                                     Write(girisYapanKullanici.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 41 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"d-block\"></a>\r\n");
#nullable restore
#line 45 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
<!-- Main Sidebar Container -->


        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                    
           <li class=""nav-item"">
                    <a href=""/User/DemandListUser"" class=""nav-link"">
                        <i class=""nav-icon fas fa-th""></i>
                        <p>
                            Talepler

                        </p>
                    </a>
                </li>

                
            </ul>
        </nav>
        <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
</aside>
");
#nullable restore
#line 72 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
}
else if (kullaniciRolleri[0] == "admin")
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<aside class=""main-sidebar sidebar-dark-primary elevation-4"">
    <!-- Brand Logo -->
    <a href=""/Admin/Index"" class=""brand-link"">

        <span class=""brand-text font-weight-light"">Company Panel</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"">
        <!-- Sidebar user panel (optional) -->
        <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">

            <div class=""info"">
");
#nullable restore
#line 89 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"d-block\">Hoşgeldin ");
#nullable restore
#line 91 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                                                     Write(girisYapanKullanici.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 92 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"d-block\"></a>\r\n");
#nullable restore
#line 96 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
<!-- Main Sidebar Container -->


        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">

                
                <li class=""nav-item menu-is-opening menu-open"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-copy""></i>
                        <p>
                            Firmalar
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">
                            <a href=""/Admin/Firms"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Firma Kaydet</p>
                            </a>
                        </li>");
            WriteLiteral(@"

                    </ul>

                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">
                            <a href=""/Admin/FirmList"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Firma Listesi</p>
                            </a>
                        </li>

                    </ul>
                </li>

                <li class=""nav-item menu-is-opening menu-open"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-tree""></i>
                        <p>
                            Kullanıcılar
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">
                            <a href=""/Admin/UserApplica");
            WriteLiteral(@"tionConfirm"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Kullanıcı Kayıt Onayla</p>
                            </a>
                        </li>

                    </ul>

                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">
                            <a href=""/Admin/UserList"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Kullanıcı Listesi</p>
                            </a>
                        </li>

                    </ul>
                </li>



                <li class=""nav-item menu-is-opening menu-open"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-tree""></i>
                        <p>
                            Hizmetler
                            <i class=""fas fa-angle-left right""></i>");
            WriteLiteral(@"
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">
                            <a href=""/Admin/CreateService"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Hizmet Oluştur</p>
                            </a>
                        </li>

                    </ul>

                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">
                            <a href=""/Admin/ServiceDefine"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Hizmet Tanımla</p>
                            </a>
                        </li>

                    </ul>

                    <ul class=""nav nav-treeview"" style=""display: block;"">
                        <li class=""nav-item"">");
            WriteLiteral(@"
                            <a href=""/Admin/ServiceList"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Hizmet Listesi</p>
                            </a>
                        </li>

                    </ul>
                </li>

                <li class=""nav-item"">
                    <a href=""/Admin/DemandList"" class=""nav-link"">
                        <i class=""nav-icon fas fa-th""></i>
                        <p>
                            Talepler

                        </p>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
</aside>
");
#nullable restore
#line 221 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Shared\SidebarPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CustomUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CustomUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
