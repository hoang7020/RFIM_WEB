#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c2e5d5f723cd795461dc3131f114afe15baf574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListStockkeeper), @"mvc.1.0.view", @"/Views/Admin/ListStockkeeper.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ListStockkeeper.cshtml", typeof(AspNetCore.Views_Admin_ListStockkeeper))]
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
#line 1 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c2e5d5f723cd795461dc3131f114afe15baf574", @"/Views/Admin/ListStockkeeper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListStockkeeper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.ModelView.ListUserView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
  
    ViewData["Title"] = "ListStockkeeper";

#line default
#line hidden
            BeginContext(106, 1709, true);
            WriteLiteral(@"
<div class=""all-content-wrapper"">
    <div class=""data-table-area mg-tb-15"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""sparkline13-list"">
                        <div class=""sparkline13-hd"">
                            <div class=""main-sparkline13-hd"">
                                <h1>Stock keeper List</h1>
                            </div>
                        </div>
                        <div class=""sparkline13-graph"">
                            <div class=""datatable-dashv1-list custom-datatable-overright"">

                                <table id=""table"" data-toggle=""table"" data-pagination=""true"" data-search=""true"" data-show-columns=""true"" data-show-pagination-switch=""true""
                                       data-show-toggle=""true"" data-show-export=""true"">
                                    <thead>
                                        <tr>
 ");
            WriteLiteral(@"                                           <th>ID</th>
                                            <th>Fullname</th>
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
#line 37 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                         foreach (var user in Model)
                                        {

#line default
#line hidden
            BeginContext(1928, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(2031, 11, false);
#line 40 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(2042, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2102, 13, false);
#line 41 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2115, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2175, 13, false);
#line 42 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2188, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2248, 13, false);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.Password);

#line default
#line hidden
            EndContext();
            BeginContext(2261, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2321, 10, false);
#line 44 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2331, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2391, 10, false);
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2401, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2461, 9, false);
#line 46 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                               Write(user.Role);

#line default
#line hidden
            EndContext();
            BeginContext(2470, 61, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n");
            EndContext();
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                                     if (user.Status)
                                                    {

#line default
#line hidden
            BeginContext(2657, 105, true);
            WriteLiteral("                                                        <button class=\"btn btn-success\">Active</button>\r\n");
            EndContext();
#line 51 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(2930, 107, true);
            WriteLiteral("                                                        <button class=\"btn btn-warning\">Disabled</button>\r\n");
            EndContext();
#line 55 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(3092, 565, true);
            WriteLiteral(@"                                                </td>
                                                <td>
                                                    <button data-toggle=""tooltip"" title=""Edit"" class=""pd-setting-ed""><i class=""fas fa-edit"" aria-hidden=""true""></i></button>
                                                    <button data-toggle=""tooltip"" title=""Trash"" class=""pd-setting-ed""><i class=""fas fa-trash"" aria-hidden=""true""></i></button>
                                                </td>
                                            </tr>
");
            EndContext();
#line 62 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\ListStockkeeper.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3700, 262, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RFIM_Web.ModelView.ListUserView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
