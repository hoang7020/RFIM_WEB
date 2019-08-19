#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd3b9515cc4b9818a3ea316717122d2d6cfe1f38"
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
#line 1 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3b9515cc4b9818a3ea316717122d2d6cfe1f38", @"/Views/Stocktake/ListAllStocktake.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a69760db975471d19d631bed21f74b4dabb7b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Stocktake_ListAllStocktake : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.ModelView.FullStockTakeHistory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditStocktake", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stocktake", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
  
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
                                            <th>Product ID</th>
                                            <th>Product Name</th>
                                            <th>StocktakeQuantity</th>
                                            <th>AvailableQuantity</th>
                                            <th>Taken by</th>
                                            <th>Status</th>
                                            <th>Date</th>
                                            <th>Option</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 36 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                         foreach (var stocktakeHistory in Model)
                                        {

#line default
#line hidden
            BeginContext(1962, 96, true);
            WriteLiteral("                                        <tr>\r\n\r\n                                            <td>");
            EndContext();
            BeginContext(2059, 35, false);
#line 40 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                           Write(stocktakeHistory.StocktakeHistoryId);

#line default
#line hidden
            EndContext();
            BeginContext(2094, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2150, 26, false);
#line 41 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                           Write(stocktakeHistory.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2176, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2232, 28, false);
#line 42 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                           Write(stocktakeHistory.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2260, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 43 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                             if (stocktakeHistory.AvailableQuantity == stocktakeHistory.StocktakeQuantity)
                                            {

#line default
#line hidden
            BeginContext(2438, 72, true);
            WriteLiteral("                                                <td style=\"color:green\">");
            EndContext();
            BeginContext(2511, 34, false);
#line 45 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                                   Write(stocktakeHistory.StocktakeQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 46 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2696, 70, true);
            WriteLiteral("                                                <td style=\"color:red\">");
            EndContext();
            BeginContext(2767, 34, false);
#line 49 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                                 Write(stocktakeHistory.StocktakeQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2801, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 50 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2855, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(2904, 34, false);
#line 51 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                           Write(stocktakeHistory.AvailableQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2938, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2994, 25, false);
#line 52 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                           Write(stocktakeHistory.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3019, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 53 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                             if (stocktakeHistory.Status == true)
                                            {

#line default
#line hidden
            BeginContext(3156, 66, true);
            WriteLiteral("                                                <td>Pending</td>\r\n");
            EndContext();
#line 56 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3366, 63, true);
            WriteLiteral("                                                <td>Done</td>\r\n");
            EndContext();
#line 60 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3476, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(3525, 21, false);
#line 61 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                           Write(stocktakeHistory.Date);

#line default
#line hidden
            EndContext();
            BeginContext(3546, 57, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n");
            EndContext();
#line 63 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                 if (stocktakeHistory.Status == true)
                                                {

#line default
#line hidden
            BeginContext(3741, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(3793, 352, false);
<<<<<<< HEAD
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1dc0b9d4dfc4ff996e7e1ee5a678c77", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb2bb471aa54f558cfa59598e89008d", async() => {
>>>>>>> dev_test5
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d94099ae37455291d5214c10aff5d9", async() => {
>>>>>>> dev_test5
                BeginContext(3982, 159, true);
                WriteLiteral("\r\n                                                        <i class=\"fas fa-check\" aria-hidden=\"true\"></i>\r\n                                                    ");
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
#line 65 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
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
            BeginContext(4145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 68 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4198, 98, true);
            WriteLiteral("                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 71 "E:\Source\RFIM_WEB\RFIM_Web\Views\Stocktake\ListAllStocktake.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4339, 711, true);
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
                BeginContext(5067, 173, true);
                WriteLiteral("\r\n    <script>\r\n $(function () {\r\n     $(\"modal-stocktake-edit\").on(\'hidden.bs.modal\', function () {\r\n       $(this).removeData(\'bs.modal\');\r\n     });\r\n });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(5243, 2, true);
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
