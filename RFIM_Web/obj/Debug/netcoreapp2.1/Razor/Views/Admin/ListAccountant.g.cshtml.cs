<<<<<<< HEAD
#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c9b2f71fe062a09947dd8dedc58080a51c94ae7"
=======
#pragma checksum "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66a1e4a1cf96feb47d71f2fb26c446ec7c7f040c"
>>>>>>> dev_thinh3
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListAccountant), @"mvc.1.0.view", @"/Views/Admin/ListAccountant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ListAccountant.cshtml", typeof(AspNetCore.Views_Admin_ListAccountant))]
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
#line 1 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9b2f71fe062a09947dd8dedc58080a51c94ae7", @"/Views/Admin/ListAccountant.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66a1e4a1cf96feb47d71f2fb26c446ec7c7f040c", @"/Views/Admin/ListAccountant.cshtml")]
>>>>>>> dev_thinh3
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListAccountant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-user-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActiveUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-user-active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
  
    ViewData["Title"] = "ListAccountant";

#line default
#line hidden
            BeginContext(94, 1624, true);
            WriteLiteral(@"<div class=""all-content-wrapper"">
    <div class=""data-table-area mg-tb-15"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""sparkline13-list"">
                        <div class=""sparkline13-hd"">
                            <div class=""main-sparkline13-hd"">
                                <h1>Accountant List</h1>
                            </div>
                        </div>
                        <div class=""sparkline13-graph"">
                            <div class=""datatable-dashv1-list custom-datatable-overright"">

                                <table id=""table"" data-toggle=""table"" data-pagination=""true"" data-search=""true"" data-show-columns=""true"" data-show-pagination-switch=""true""
                                       data-show-toggle=""true"">
                                    <thead>
                                        <tr>
                             ");
            WriteLiteral(@"               <th>Fullname</th>
                                            <th>Username</th>
                                            <th>Password</th>
                                            <th>Email</th>
                                            <th>Phone</th>
                                            <th>Role</th>
                                            <th>Status</th>
                                            <th>Setting</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 35 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                         foreach (var user in Model)
                                        {

#line default
#line hidden
            BeginContext(1831, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1926, 13, false);
#line 38 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                           Write(user.Fullname);
=======
            BeginContext(1934, 13, false);
#line 38 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                               Write(user.Fullname);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(1939, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(1995, 13, false);
#line 39 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                           Write(user.Username);
=======
            BeginContext(2007, 13, false);
#line 39 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                               Write(user.Username);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(2008, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(2064, 13, false);
#line 40 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                           Write(user.Password);
=======
            BeginContext(2080, 13, false);
#line 40 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                               Write(user.Password);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(2077, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(2133, 10, false);
#line 41 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                           Write(user.Email);
=======
            BeginContext(2153, 10, false);
#line 41 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                               Write(user.Email);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(2143, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(2199, 10, false);
#line 42 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                           Write(user.Phone);
=======
            BeginContext(2223, 10, false);
#line 42 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                               Write(user.Phone);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(2209, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(2265, 18, false);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                           Write(user.Role.RoleName);
=======
            BeginContext(2293, 18, false);
#line 43 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                               Write(user.Role.RoleName);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(2283, 57, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n");
            EndContext();
<<<<<<< HEAD
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                 if (user.Status)
                                                {

#line default
#line hidden
            BeginContext(2458, 67, true);
            WriteLiteral("                                                    <p>Active</p>\r\n");
            EndContext();
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(2681, 69, true);
            WriteLiteral("                                                    <p>Deactive</p>\r\n");
            EndContext();
#line 52 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2801, 149, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2950, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83edceec69714ec4b1ef5dab0d5fd397", async() => {
                BeginContext(3050, 46, true);
                WriteLiteral("<i class=\"fas fa-edit\" aria-hidden=\"true\"></i>");
=======
#line 45 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                     if (user.Status)
                                                    {

#line default
#line hidden
            BeginContext(2498, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(2550, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc43b4e23954767a196ef969b7fd7f9", async() => {
                BeginContext(2704, 8, true);
                WriteLiteral("Activate");
>>>>>>> dev_thinh3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
<<<<<<< HEAD
#line 55 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                                                                  WriteLiteral(user.UserId);
=======
#line 47 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                                                                        WriteLiteral(user.UserId);
>>>>>>> dev_thinh3

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
<<<<<<< HEAD
            BeginContext(3100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                 if (user.Status)
                                                {

#line default
#line hidden
            BeginContext(3220, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(3272, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c630956ac5c44c55b895669baeb109f8", async() => {
                BeginContext(3426, 157, true);
                WriteLiteral("\r\n                                                        <i class=\"fas fa-ban\" aria-hidden=\"true\"></i>\r\n                                                    ");
=======
            BeginContext(2716, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(2886, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(2942, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af33a502715e4c7aa02ae70fa9696bf5", async() => {
                BeginContext(3097, 8, true);
                WriteLiteral("Deactive");
>>>>>>> dev_thinh3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
<<<<<<< HEAD
#line 58 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                                                                        WriteLiteral(user.UserId);
=======
#line 51 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                                                                            WriteLiteral(user.UserId);
>>>>>>> dev_thinh3

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
<<<<<<< HEAD
            BeginContext(3587, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 61 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3745, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(3797, 318, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcffce378924427b9c57ec8b69fb69e5", async() => {
                BeginContext(3952, 159, true);
                WriteLiteral("\r\n                                                        <i class=\"fas fa-check\" aria-hidden=\"true\"></i>\r\n                                                    ");
=======
            BeginContext(3109, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(3166, 161, true);
            WriteLiteral("                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3327, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d48c9704bb2147af9716ab94746c0886", async() => {
                BeginContext(3425, 46, true);
                WriteLiteral("<i class=\"fas fa-edit\" aria-hidden=\"true\"></i>");
>>>>>>> dev_thinh3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
<<<<<<< HEAD
#line 64 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                                                                        WriteLiteral(user.UserId);
=======
#line 55 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                                                                      WriteLiteral(user.UserId);
>>>>>>> dev_thinh3

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
<<<<<<< HEAD
            BeginContext(4115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 67 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4168, 98, true);
            WriteLiteral("                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
=======
            BeginContext(3475, 108, true);
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\ListAccountant.cshtml"
>>>>>>> dev_thinh3
                                        }

#line default
#line hidden
<<<<<<< HEAD
            BeginContext(4309, 1152, true);
=======
            BeginContext(3626, 1152, true);
>>>>>>> dev_thinh3
            WriteLiteral(@"                                    </tbody>
                                </table>
                                <div id=""modal-user-delete"" aria-hidden=""true"" class=""modal fade"" role=""dialog"">
                                    <div class=""modal-dialog"">
                                        <!-- Modal content-->
                                        <div class=""modal-content"">

                                        </div>
                                    </div>
                                </div>
                                <div id=""modal-user-active"" aria-hidden=""true"" class=""modal fade"" role=""dialog"">
                                    <div class=""modal-dialog"">
                                        <!-- Modal content-->
                                        <div class=""modal-content"">

                                        </div>
                                    </div>
                                </div>
                            </div>
            ");
            WriteLiteral("            </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
<<<<<<< HEAD
                BeginContext(5478, 288, true);
=======
                BeginContext(4795, 288, true);
>>>>>>> dev_thinh3
                WriteLiteral(@"
    <script>
 $(function () {
    $(""#modal-user-delete"").on('hidden.bs.modal', function () {
       $(this).removeData('bs.modal');
     });
     $(""#modal-user-active"").on('hidden.bs.modal', function () {
         $(this).removeData('bs.modal');
     });
 });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RFIM_Web.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
