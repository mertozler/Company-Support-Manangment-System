#pragma checksum "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "039a5cd9db2a46a37578226b5f8e2a6ab92ae7c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DepartmentRegisterForEmployee), @"mvc.1.0.view", @"/Views/Admin/DepartmentRegisterForEmployee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"039a5cd9db2a46a37578226b5f8e2a6ab92ae7c1", @"/Views/Admin/DepartmentRegisterForEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b964cc9676e9dd9414a58e3cd42d993044ca2d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_DepartmentRegisterForEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyPanelUI.Models.DepartmentRegisterForEmployeeViewModel.DepartmentRegisterForEmployeeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FirmId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "UserId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("make_checkbox_select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DepartmentRegisterForEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card card-primary"">
              <div class=""card-header"">
                <h3 class=""card-title"">Personel Kaydı</h3>
              </div>

              <div class=""card"">
                  <div class=""card-header"">
                        <h3 class=""card-title"">Firma Seçin</h3>
                        </div>
                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "039a5cd9db2a46a37578226b5f8e2a6ab92ae7c16597", async() => {
                WriteLiteral("\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "039a5cd9db2a46a37578226b5f8e2a6ab92ae7c16877", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                           foreach (var item in Model.allFirms)
                          {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                              ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "039a5cd9db2a46a37578226b5f8e2a6ab92ae7c17469", async() => {
#nullable restore
#line 24 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                                      Write(item.FirmName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                 WriteLiteral(item.FirmId);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 25 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"

                          }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirmId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                      \r\n                      <div>\r\n                          <div class=\"card-header\">\r\n                              <h3 class=\"card-title\">Bölüm Seçin</h3>\r\n                          </div>\r\n");
#nullable restore
#line 33 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                            foreach (var item in Model.allDepartment)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <input id=\"DepartmentId\" type=\"checkbox\" name=\"DepartmentId\"");
                BeginWriteAttribute("value", " value=\"", 1428, "\"", 1454, 1);
#nullable restore
#line 35 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 1436, item.DepartmentId, 1436, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                                    <label>");
#nullable restore
#line 36 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                                                      Write(item.DepartmentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 37 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                      </div>
                      
                      <div id=""serviceVisibility"">
                          <div class=""card-header"">
                              <h3 class=""card-title"">Servis Seçin</h3>
                          </div>
                          
                          <div>
");
#nullable restore
#line 46 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                               foreach (var item in Model.getServicesForSelectedDepartment)
                                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                          <input id=\"ServiceId\" type=\"checkbox\" name=\"ServiceId\"");
                BeginWriteAttribute("value", " value=\"", 2188, "\"", 2211, 1);
#nullable restore
#line 48 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 2196, item.ServiceId, 2196, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                          <label>");
#nullable restore
#line 49 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                            Write(item.ServiceName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 50 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                          </div>
                      </div>
                          
                          
                      
                      
                      
                      <div class=""card"">
                              <div class=""card-header"">
                                  <h3 class=""card-title"">Personel Bilgisi</h3>
                              </div>

                              <div class=""card-body"">
                                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "039a5cd9db2a46a37578226b5f8e2a6ab92ae7c115114", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 64 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                                                                     WriteLiteral(Model.User.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                      <div class=""form-group"">
                                          <label for=""exampleInputEmail1"">Kullanıcı Adı Soyadı</label>
                                          <input type=""text"" class=""form-control"" id=""UserNameSurname"" name=""FirmName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3205, "\"", 3242, 1);
#nullable restore
#line 68 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 3219, Model.User.NameSurname, 3219, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                      </div>
                                      <div class=""form-group"">
                                          <label for=""exampleInputPassword1"">Kullanıcı Mail</label>
                                          <input type=""number"" class=""form-control"" id=""UserMail"" name=""UserMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3570, "\"", 3601, 1);
#nullable restore
#line 72 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 3584, Model.User.Email, 3584, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                      </div>
                                      <div class=""form-group"">
                                          <label for=""exampleInputEmail1"">Kullanıcı Telefonu</label>
                                          <input type=""number"" class=""form-control"" id=""UserMail"" name=""UserMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3930, "\"", 3967, 1);
#nullable restore
#line 76 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 3944, Model.User.PhoneNumber, 3944, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                      </div>
                                     
                                  
                              </div>
                              <!-- /.card-body -->

                              <div class=""card-footer"">
                                  <button type=""submit"" onclick=""updatemark()""class=""btn btn-primary"">Personel Şirket ve Hizmet Kaydı Yap</button>
                              </div>
                          </div>
                      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js\"></script>\r\n\r\n<script>\r\n /*$(\"#departmentId\").change(function () {\r\n        var selectedDepartment = this.value;\r\n        if (selectedDepartment == ");
#nullable restore
#line 98 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                             Write(Model.defaultDepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
            {
                document.getElementById(""serviceVisibility"").style.display = ""block""
            }
        else {
            document.getElementById(""serviceVisibility"").style.display = ""none""
            }
    });
 if($(""#departmentId"").val() == ");
#nullable restore
#line 106 "D:\CompanyPanel\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                           Write(Model.defaultDepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"){
     {
                     document.getElementById(""serviceVisibility"").style.display = ""block""
               
 }
   }
              else {
                  document.getElementById(""serviceVisibility"").style.display = ""none""
                  }   */
                   function updatemark(arg)  
                        {  
                         
                              
                        }  
                  
                  
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyPanelUI.Models.DepartmentRegisterForEmployeeViewModel.DepartmentRegisterForEmployeeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
