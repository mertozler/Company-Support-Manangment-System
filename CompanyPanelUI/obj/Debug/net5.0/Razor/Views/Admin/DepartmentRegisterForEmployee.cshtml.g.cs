#pragma checksum "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43e32e262c2b1dc55554c6be17b4857ab16a75f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43e32e262c2b1dc55554c6be17b4857ab16a75f", @"/Views/Admin/DepartmentRegisterForEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615f8c5c6cc6182552191e89c5aef8975cba7f07", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43e32e262c2b1dc55554c6be17b4857ab16a75f6758", async() => {
                WriteLiteral("\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43e32e262c2b1dc55554c6be17b4857ab16a75f7036", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 22 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                           foreach (var item in Model.allFirms)
                          {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                              ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43e32e262c2b1dc55554c6be17b4857ab16a75f7669", async() => {
#nullable restore
#line 24 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
#line 24 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
                    WriteLiteral("\n");
#nullable restore
#line 25 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"

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
#line 21 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
                WriteLiteral("\n                      \n                      <div>\n                          <div class=\"card-header\">\n                              <h3 class=\"card-title\">Bölüm Seçin</h3>\n                          </div>\n");
#nullable restore
#line 33 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                            foreach (var item in Model.allDepartment)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <input id=\"DepartmentId\" type=\"checkbox\" name=\"DepartmentId\"");
                BeginWriteAttribute("value", " value=\"", 1394, "\"", 1420, 1);
#nullable restore
#line 35 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 1402, item.DepartmentId, 1402, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                                    <label>");
#nullable restore
#line 36 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                                                      Write(item.DepartmentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 37 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
#line 46 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                               foreach (var item in Model.getServicesForSelectedDepartment)
                                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                          <input id=\"ServiceId\" type=\"checkbox\" name=\"ServiceId\"");
                BeginWriteAttribute("value", " value=\"", 2141, "\"", 2164, 1);
#nullable restore
#line 48 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 2149, item.ServiceId, 2149, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                          <label>");
#nullable restore
#line 49 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
                                            Write(item.ServiceName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 50 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a43e32e262c2b1dc55554c6be17b4857ab16a75f15803", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 64 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
                BeginWriteAttribute("placeholder", " placeholder=\"", 3138, "\"", 3175, 1);
#nullable restore
#line 68 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 3152, Model.User.NameSurname, 3152, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                      </div>
                                      <div class=""form-group"">
                                          <label for=""exampleInputPassword1"">Kullanıcı Mail</label>
                                          <input type=""number"" class=""form-control"" id=""UserMail"" name=""UserMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3499, "\"", 3530, 1);
#nullable restore
#line 72 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 3513, Model.User.Email, 3513, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                      </div>
                                      <div class=""form-group"">
                                          <label for=""exampleInputEmail1"">Kullanıcı Telefonu</label>
                                          <input type=""number"" class=""form-control"" id=""UserMail"" name=""UserMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3855, "\"", 3892, 1);
#nullable restore
#line 76 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
WriteAttributeValue("", 3869, Model.User.PhoneNumber, 3869, 23, false);

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
            WriteLiteral("\n\n</div>\n\n\n</div>\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js\"></script>\n\n<script>\n /*$(\"#departmentId\").change(function () {\n        var selectedDepartment = this.value;\n        if (selectedDepartment == ");
#nullable restore
#line 98 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
#line 106 "C:\Users\Acer\Desktop\Company-Support-Manangment-System-main\CompanyPanelUI\Views\Admin\DepartmentRegisterForEmployee.cshtml"
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
