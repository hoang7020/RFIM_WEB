#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f2e65393f82fabcb73914142073088c9837e902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_InvoiceDetail), @"mvc.1.0.view", @"/Views/Invoice/InvoiceDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/InvoiceDetail.cshtml", typeof(AspNetCore.Views_Invoice_InvoiceDetail))]
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
#line 31 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f2e65393f82fabcb73914142073088c9837e902", @"/Views/Invoice/InvoiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a69760db975471d19d631bed21f74b4dabb7b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_InvoiceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.InvoiceDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("datadismiss", new global::Microsoft.AspNetCore.Html.HtmlString("modal-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BackToInvoiceList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 34, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    ");
            EndContext();
            BeginContext(75, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d54a46e468414f25b4b9c63865da124e", async() => {
                BeginContext(173, 7, true);
                WriteLiteral("&times;");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(184, 45, true);
            WriteLiteral("\r\n    <h4 class=\"modal-title\">Detail Invoice ");
            EndContext();
            BeginContext(230, 24, false);
#line 5 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                      Write(Model.Invoices.InvoiceId);

#line default
#line hidden
            EndContext();
            BeginContext(254, 453, true);
            WriteLiteral(@"</h4>
</div>
<div class=""modal-body form-horizontal"">
    <div class=""data-table-area mg-tb-15"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""sparkline13-list"">
                        <div class=""sparkline13-hd"">
                            <div class=""main-sparkline13-hd"">
                                <h4>Date: ");
            EndContext();
            BeginContext(708, 19, false);
#line 15 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                     Write(Model.Invoices.Date);

#line default
#line hidden
            EndContext();
            BeginContext(727, 49, true);
            WriteLiteral("</h4>\r\n                                <h4>Type: ");
            EndContext();
            BeginContext(777, 39, false);
#line 16 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                     Write(Model.Invoices.InvoiceType.InvoiceTypes);

#line default
#line hidden
            EndContext();
            BeginContext(816, 49, true);
            WriteLiteral("</h4>\r\n                                <h4>User: ");
            EndContext();
            BeginContext(866, 28, false);
#line 17 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                     Write(Model.Invoices.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(894, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 18 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                 if (Model.Invoices.InvoiceStatus.Status == "Pending")
                                {

#line default
#line hidden
            BeginContext(1024, 66, true);
            WriteLiteral("                                    <h4 style=\"color:red\">Status: ");
            EndContext();
            BeginContext(1091, 35, false);
#line 20 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                             Write(Model.Invoices.InvoiceStatus.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 21 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                }
                                else if (Model.Invoices.InvoiceStatus.Status == "Processing")
                                {

#line default
#line hidden
            BeginContext(1298, 69, true);
            WriteLiteral("                                    <h4 style=\"color:orange\">Status: ");
            EndContext();
            BeginContext(1368, 35, false);
#line 24 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                                Write(Model.Invoices.InvoiceStatus.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 25 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1518, 68, true);
            WriteLiteral("                                    <h4 style=\"color:green\">Status: ");
            EndContext();
            BeginContext(1587, 35, false);
#line 28 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                               Write(Model.Invoices.InvoiceStatus.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 29 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                }

#line default
#line hidden
            BeginContext(1664, 49, true);
            WriteLiteral("                                <h4>Description: ");
            EndContext();
            BeginContext(1714, 26, false);
#line 30 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                            Write(Model.Invoices.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1740, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(1813, 1069, true);
            WriteLiteral(@"                            </div>
                        </div>
                        <br />
                        <div class=""sparkline13-graph"">
                            <div class=""sparkline8-graph"">
                                <div class=""static-table-list"">
                                    <h4>Product List</h4>
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>ProductID</th>
                                                <th>Product Name</th>
                                                <th>Category</th>
                                                <th>Vendor</th>
                                                <th>Quantity Per Box</th>
                                                <th>Quantity(Boxes)</th>
                                            </tr>
                                        </thead>
    ");
            WriteLiteral("                                    <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                             foreach (var productList in Model.productList)
                                            {

#line default
#line hidden
            BeginContext(3022, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(3125, 21, false);
#line 54 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                               Write(productList.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3146, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3206, 23, false);
#line 55 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                               Write(productList.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3229, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3289, 20, false);
#line 56 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                               Write(productList.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3309, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3369, 18, false);
#line 57 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                               Write(productList.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(3387, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3447, 26, false);
#line 58 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                               Write(productList.QuantityperBox);

#line default
#line hidden
            EndContext();
            BeginContext(3473, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3533, 20, false);
#line 59 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                               Write(productList.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3553, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 61 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3658, 314, true);
            WriteLiteral(@"                                        </tbody>
                                    </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.InvoiceDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
