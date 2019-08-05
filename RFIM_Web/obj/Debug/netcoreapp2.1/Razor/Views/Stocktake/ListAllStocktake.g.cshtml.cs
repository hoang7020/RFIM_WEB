#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b07c32985bff910e0ccc5bf42f207b7c6b8b6642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stocktake_ListAllStocktake), @"mvc.1.0.view", @"/Views/Stocktake/ListAllStocktake.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stocktake/ListAllStocktake.cshtml", typeof(AspNetCore.Views_Stocktake_ListAllStocktake))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07c32985bff910e0ccc5bf42f207b7c6b8b6642", @"/Views/Stocktake/ListAllStocktake.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Stocktake_ListAllStocktake : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.ModelView.FullStockTakeHistory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditStocktake", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stocktake", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pd-setting-ed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-stocktake-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
  
    ViewData["Title"] = "ListAllStocktake";

#line default
#line hidden
            BeginContext(113, 1724, true);
            WriteLiteral(@"
<div class=""all-content-wrapper"">
    <div class=""data-table-area mg-tb-15"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""sparkline13-list"">
                        <div class=""sparkline13-hd"">
                            <div class=""main-sparkline13-hd"">
                                <h1>Stocktake History</h1>
                            </div>
                        </div>

                        <div class=""sparkline13-graph"">
                            <div class=""datatable-dashv1-list custom-datatable-overright"">
                                <table id=""table"" data-toggle=""table"" data-pagination=""true"" data-search=""true"" data-show-columns=""true"" data-show-pagination-switch=""true""
                                       data-show-toggle=""true"">
                                    <thead>
                                        <tr>
                         ");
            WriteLiteral(@"                   <th>Stocktake ID</th>
                                            <th>Date</th>
                                            <th>Product ID</th>
                                            <th>Product Name</th>
                                            <th>Taken by</th>
                                            <th>Status</th>
                                            <th>StocktakeQuantity</th>
                                            <th>AvailableQuantity</th>
                                            <th>Option</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 36 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                         foreach (var stocktakeHistory in Model)
                                        {

#line default
#line hidden
            BeginContext(1962, 104, true);
            WriteLiteral("                                            <tr>\r\n\r\n                                                <td>");
            EndContext();
            BeginContext(2067, 35, false);
#line 40 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                               Write(stocktakeHistory.StocktakeHistoryId);

#line default
#line hidden
            EndContext();
            BeginContext(2102, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2162, 21, false);
#line 41 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                               Write(stocktakeHistory.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2183, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2243, 26, false);
#line 42 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                               Write(stocktakeHistory.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2269, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2329, 28, false);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                               Write(stocktakeHistory.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2357, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2417, 25, false);
#line 44 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                               Write(stocktakeHistory.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2442, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                 if (stocktakeHistory.Status == true)
                                                {

#line default
#line hidden
            BeginContext(2587, 70, true);
            WriteLiteral("                                                    <td>Pending</td>\r\n");
            EndContext();
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(2813, 67, true);
            WriteLiteral("                                                    <td>Done</td>\r\n");
            EndContext();
#line 52 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2931, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 53 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                 if (stocktakeHistory.AvailableQuantity == stocktakeHistory.StocktakeQuantity)
                                                {

#line default
#line hidden
            BeginContext(3110, 76, true);
            WriteLiteral("                                                    <td style=\"color:green\">");
            EndContext();
            BeginContext(3187, 34, false);
#line 55 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                                       Write(stocktakeHistory.StocktakeQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3221, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 56 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3384, 74, true);
            WriteLiteral("                                                    <td style=\"color:red\">");
            EndContext();
            BeginContext(3459, 34, false);
#line 59 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                                     Write(stocktakeHistory.StocktakeQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3493, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 60 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3551, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(3604, 34, false);
#line 61 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                               Write(stocktakeHistory.AvailableQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3638, 61, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n");
            EndContext();
#line 63 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                     if (stocktakeHistory.Status == true)
                                                    {

#line default
#line hidden
            BeginContext(3845, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(3897, 330, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f39ab74dc354bd5acda618de1c29d62", async() => {
                BeginContext(4084, 139, true);
                WriteLiteral("\r\n                                                        <i class=\"fas fa-edit\"></i>\r\n                                                    ");
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
#line 65 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                                                                               WriteLiteral(stocktakeHistory.StocktakeHistoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            EndContext();
            BeginContext(4227, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 68 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(4284, 106, true);
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4433, 711, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                                <div id=""modal-stocktake-edit"" aria-hidden=""true"" class=""modal fade"" role=""dialog"">
                                    <div class=""modal-dialog"">
                                        <!-- Modal content-->
                                        <div class=""modal-content"">

                                        </div>
                                    </div>
                                </div>
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
            DefineSection("Scripts", async() => {
                BeginContext(5161, 173, true);
                WriteLiteral("\r\n    <script>\r\n $(function () {\r\n     $(\"modal-stocktake-edit\").on(\'hidden.bs.modal\', function () {\r\n       $(this).removeData(\'bs.modal\');\r\n     });\r\n });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(5337, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RFIM_Web.ModelView.FullStockTakeHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
