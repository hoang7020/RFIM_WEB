<<<<<<< HEAD
#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae79860354a74b904c0eed3ad03dda12ff7c116a"
=======
#pragma checksum "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c767df45a173d40586c00f177aac82525b6d32"
>>>>>>> dev_thinh3
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae79860354a74b904c0eed3ad03dda12ff7c116a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    if (User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(125, 897, true);
            WriteLiteral(@"        <div class=""all-content-wrapper"">
            <div class=""widgets-programs-area mg-t-15"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Users</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-users"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-success"">");
            EndContext();
            BeginContext(1023, 23, false);
#line 24 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                            Write(ViewBag.UserCount.Users);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 873, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Active Users</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fa fa-street-view"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-info"">");
            EndContext();
            BeginContext(1920, 29, false);
#line 39 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                         Write(ViewBag.UserCount.ActiveUsers);

#line default
#line hidden
            EndContext();
            BeginContext(1949, 880, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Accountant</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-calculator"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-warning"">");
            EndContext();
            BeginContext(2830, 29, false);
#line 54 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                            Write(ViewBag.UserCount.Accountants);

#line default
#line hidden
            EndContext();
            BeginContext(2859, 860, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Stockkeeper</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-warehouse"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-danger"">");
            EndContext();
            BeginContext(3720, 30, false);
#line 69 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                           Write(ViewBag.UserCount.Stockkeepers);

#line default
#line hidden
            EndContext();
            BeginContext(3750, 247, true);
            WriteLiteral("</h1>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 78 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
    }
    else if (User.IsInRole("Stockkeeper"))
    {

    }
    else
    {

#line default
#line hidden
            BeginContext(4081, 901, true);
            WriteLiteral(@"        <div class=""all-content-wrapper"">
            <div class=""widgets-programs-area mg-t-15"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Categories</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-cube"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-success"">");
            EndContext();
<<<<<<< HEAD
            BeginContext(4983, 33, false);
#line 99 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(4982, 33, false);
#line 99 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                            Write(ViewBag.AccountantInfo.Categories);

#line default
#line hidden
            EndContext();
            BeginContext(5016, 870, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Products</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-boxes"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-info"">");
            EndContext();
<<<<<<< HEAD
            BeginContext(5887, 31, false);
#line 114 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(5886, 31, false);
#line 114 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                         Write(ViewBag.AccountantInfo.Products);

#line default
#line hidden
            EndContext();
            BeginContext(5918, 872, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Shelfs</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-pallet"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-warning"">");
            EndContext();
<<<<<<< HEAD
            BeginContext(6791, 29, false);
#line 129 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(6790, 29, false);
#line 129 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                            Write(ViewBag.AccountantInfo.Shelfs);

#line default
#line hidden
            EndContext();
            BeginContext(6820, 855, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel"">
                                <div class=""panel-body"">
                                    <div class=""stats-title pull-left"">
                                        <h4>Total Vendors</h4>
                                    </div>
                                    <div class=""stats-icon pull-right"">
                                        <i class=""fas fa-industry"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""m-t-xl"">
                                        <h1 class=""text-danger"">");
            EndContext();
<<<<<<< HEAD
            BeginContext(7676, 30, false);
#line 144 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(7675, 30, false);
#line 144 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                           Write(ViewBag.AccountantInfo.Vendors);

#line default
#line hidden
            EndContext();
            BeginContext(7706, 842, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""widget-program-bg mg-tb-30"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel hbggreen responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""text-center content-bg-pro"">
                                        <h3>Good Receives</h3>
                                        <p class=""text-big font-light"">
                                            ");
            EndContext();
<<<<<<< HEAD
            BeginContext(8549, 42, false);
#line 161 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(8548, 42, false);
#line 161 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                       Write(ViewBag.AccountantInfo.ReceivePendingCount);

#line default
#line hidden
            EndContext();
            BeginContext(8591, 850, true);
            WriteLiteral(@"
                                        </p>
                                        <small>
                                            Good receipts still be pending, please check and stock in
                                        </small>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel hbgred"">
                                <div class=""panel-body"">
                                    <div class=""text-center content-bg-pro"">
                                        <h3>Good Issues</h3>
                                        <p class=""text-big font-light"">
                                            ");
            EndContext();
<<<<<<< HEAD
            BeginContext(9442, 40, false);
#line 176 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(9441, 40, false);
#line 176 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                       Write(ViewBag.AccountantInfo.IssuePendingCount);

#line default
#line hidden
            EndContext();
            BeginContext(9482, 1377, true);
            WriteLiteral(@"
                                        </p>
                                        <small>
                                            Good issues still be pending, please check and stock out
                                        </small>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""program-widget-bc mt-t-30 mg-b-15"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel responsive-mg-b-30"">
                                <div class=""panel-body"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-striped"">
                                            <thead>
   ");
            WriteLiteral(@"                                             <tr>
                                                    <th>Invoice Id</th>
                                                    <th>Date</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 203 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                 foreach (var receive in ViewBag.AccountantInfo.Receives)
                                                {

#line default
#line hidden
            BeginContext(11017, 217, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            <span class=\"text-success font-bold\">");
            EndContext();
<<<<<<< HEAD
            BeginContext(11235, 17, false);
#line 207 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(11234, 17, false);
#line 207 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                                                            Write(receive.InvoiceId);

#line default
#line hidden
            EndContext();
            BeginContext(11252, 132, true);
            WriteLiteral("</span>\r\n                                                        </td>\r\n                                                        <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(11385, 12, false);
#line 209 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(11384, 12, false);
#line 209 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                       Write(receive.Date);

#line default
#line hidden
            EndContext();
            BeginContext(11397, 66, true);
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 211 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(11514, 994, true);
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                            <div class=""hpanel"">
                                <div class=""panel-body"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-striped"">
                                            <thead>
                                                <tr>
                                                    <th>Invoice Id</th>
                                                    <th>Date</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 230 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                 foreach (var issue in ViewBag.AccountantInfo.Issues)
                                                {

#line default
#line hidden
            BeginContext(12662, 217, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            <span class=\"text-success font-bold\">");
            EndContext();
<<<<<<< HEAD
            BeginContext(12880, 15, false);
#line 234 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(12879, 15, false);
#line 234 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                                                            Write(issue.InvoiceId);

#line default
#line hidden
            EndContext();
            BeginContext(12895, 132, true);
            WriteLiteral("</span>\r\n                                                        </td>\r\n                                                        <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(13028, 10, false);
#line 236 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
=======
            BeginContext(13027, 10, false);
#line 236 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
>>>>>>> dev_thinh3
                                                       Write(issue.Date);

#line default
#line hidden
            EndContext();
            BeginContext(13038, 66, true);
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 238 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(13155, 344, true);
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 249 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Admin\Index.cshtml"
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
