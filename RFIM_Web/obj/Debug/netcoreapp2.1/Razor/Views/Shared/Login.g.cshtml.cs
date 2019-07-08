#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bbaec1098ea58684737a89310148e97d5e33310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Login), @"mvc.1.0.view", @"/Views/Shared/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Login.cshtml", typeof(AspNetCore.Views_Shared_Login))]
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
#line 1 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbaec1098ea58684737a89310148e97d5e33310", @"/Views/Shared/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.LoginView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 509, true);
            WriteLiteral(@"
<div class=""color-line""></div>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12""></div>
        <div class=""col-md-4 col-md-4 col-sm-4 col-xs-12"">
            <div class=""text-center m-b-md custom-login"">
                <h3>PLEASE LOGIN TO APP</h3>
                <p>Motorbike Accessories Inventory Management System</p>
            </div>
            <div class=""hpanel"">
                <div class=""panel-body"">
                    ");
            EndContext();
            BeginContext(546, 1205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c389ae21fca9435b85b0144f45ced916", async() => {
                BeginContext(608, 921, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label class=""control-label"" for=""username"">Username</label>
                            <input type=""text"" placeholder=""username"" title=""Please enter you username"" required="""" value=""""
                                   name=""username"" id=""username"" class=""form-control"">
                            <span class=""help-block small"">Your unique username to app</span>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label"" for=""password"">Password</label>
                            <input type=""password"" title=""Please enter your password"" placeholder=""******"" required="""" value=""""
                                   name=""password"" id=""password"" class=""form-control"">
                        </div>
                        <div class=""text-danger"">");
                EndContext();
                BeginContext(1530, 19, false);
#line 26 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\Login.cshtml"
                                            Write(ViewBag.LoiDangNhap);

#line default
#line hidden
                EndContext();
                BeginContext(1549, 57, true);
                WriteLiteral("</div>\r\n                        <div class=\"text-danger\">");
                EndContext();
                BeginContext(1607, 18, false);
#line 27 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\Login.cshtml"
                                            Write(ViewBag.HetHieuLuc);

#line default
#line hidden
                EndContext();
                BeginContext(1625, 119, true);
                WriteLiteral("</div>\r\n                        <button class=\"btn btn-success btn-block loginbtn\">Login</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1751, 148, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-4 col-md-4 col-sm-4 col-xs-12\"></div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.LoginView> Html { get; private set; }
    }
}
#pragma warning restore 1591
