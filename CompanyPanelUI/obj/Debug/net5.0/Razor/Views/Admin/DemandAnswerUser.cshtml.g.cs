#pragma checksum "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "943490a3f6d48e87a56a70dd021f70321a8a02da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DemandAnswerUser), @"mvc.1.0.view", @"/Views/Admin/DemandAnswerUser.cshtml")]
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
#line 1 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
using CompanyPanelUI.Models.DemandReplyViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
using CompanyPanelUI.Models.UserListViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943490a3f6d48e87a56a70dd021f70321a8a02da", @"/Views/Admin/DemandAnswerUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b964cc9676e9dd9414a58e3cd42d993044ca2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DemandAnswerUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemandReplyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DemandAnswerNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DemandAnswerNew"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Cevap yaz.."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DemandIdNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DemandAnswerUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
  
    ViewData["Title"] = "DemandAnswer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n                <div class=\"card direct-chat direct-chat-warning\">\r\n                  <div class=\"card-header\">\r\n");
#nullable restore
#line 18 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                       foreach(var item in Model.DemandAndAnswerWmList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"card-title\">Talep No: ");
#nullable restore
#line 20 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                                                Write(item.DemandId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 20 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                                                                 Write(item.DemandTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </div>\r\n                  <!-- /.card-header -->\r\n");
#nullable restore
#line 24 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                           foreach(var item in Model.DemandAndAnswerWmList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  <div class=""card-body"">
                    <!-- Conversations are loaded here -->
                    <div class=""direct-chat-messages"">
                      <!-- Message. Default to the left -->
                      <div class=""direct-chat-msg"">
                        <div class=""direct-chat-infos clearfix"">
                          <span class=""direct-chat-name float-left"">");
#nullable restore
#line 32 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                                                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          <span class=\"direct-chat-timestamp float-right\">");
#nullable restore
#line 33 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                                                                     Write(item.DemantCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        \r\n                        <div class=\"direct-chat-text\">\r\n                          ");
#nullable restore
#line 37 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                     Write(item.DemandContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <!-- /.direct-chat-text -->\r\n                      </div>\r\n                    </div>\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"

            if(item.DemandAnswer!=null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""direct-chat-msg right"">
                    <div class=""direct-chat-infos clearfix"">
                      <span class=""direct-chat-name float-right"">Sistem Yöneticisi</span>
                      <span class=""direct-chat-timestamp float-left"">");
#nullable restore
#line 49 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                                                                Write(item.DemandAnswerDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"direct-chat-text\">\r\n                      ");
#nullable restore
#line 52 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                 Write(item.DemandAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <!-- /.direct-chat-text -->\r\n                  </div>\r\n");
#nullable restore
#line 56 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
            }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- /.card-body -->\r\n");
#nullable restore
#line 59 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                     foreach (var item in Model.DemandAndAnswerWmList)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--/.direct-chat-messages-->\r\n");
#nullable restore
#line 64 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"card-footer\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "943490a3f6d48e87a56a70dd021f70321a8a02da13821", async() => {
                WriteLiteral("\r\n                      <div class=\"input-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "943490a3f6d48e87a56a70dd021f70321a8a02da14153", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 68 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DemandAnswerNew);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "943490a3f6d48e87a56a70dd021f70321a8a02da16367", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 69 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DemandIdNew);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                                                                             WriteLiteral(ViewBag.id);

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
                WriteLiteral("\r\n                        <span class=\"input-group-append\">\r\n                          <button type=\"submit\" class=\"btn btn-warning\">Talep Yanıtla</button>\r\n                        </span>\r\n                      </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                  </div>

                  <!-- /.card-footer-->
                </div>
                <!--/.direct-chat -->
              </div>
              
               <br />

<div class=""card-body"">
    <div class=""card-header"">
                     
                    <h3 class=""card-title"">Dosyalar</h3>
                   
                  </div>
                <table class=""table table-bordered"">
                  <thead>
                    <tr>
                      <th>Dosya Adı</th>
                      <th>Dosyayı İndir</th>
                    </tr>
                  </thead>
                  <tbody>
                    
");
#nullable restore
#line 99 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                         foreach(var item in Model.DemandAndAnswerWmList)
                    {
                    foreach(var itemL in item.DemandFilePath)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                        <td>");
#nullable restore
#line 104 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                       Write(itemL.DemandFilePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "943490a3f6d48e87a56a70dd021f70321a8a02da22351", async() => {
                WriteLiteral("<span class=\"badge bg-danger\">Dosyayı İndir</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4293, "~/DemandFiles/", 4293, 14, true);
#nullable restore
#line 107 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
AddHtmlAttributeValue("", 4307, itemL.DemandFilePath, 4307, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                              \r\n                        </td>\r\n                        </tr>\r\n");
#nullable restore
#line 111 "D:\cp-identity\cp-18subat-now\CompanyPanel\CompanyPanelUI\Views\Admin\DemandAnswerUser.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </tbody>\r\n                </table>\r\n              </div>\r\n             ");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemandReplyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
