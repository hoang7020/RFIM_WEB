#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92646d06df2c10b4e567535f2f20d40f2be7358b"
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
#line 1 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
#line 30 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92646d06df2c10b4e567535f2f20d40f2be7358b", @"/Views/Invoice/InvoiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ba8e66119a44d4aea275d6f0179514", async() => {
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
#line 5 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
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
#line 15 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                     Write(Model.Invoices.Date);

#line default
#line hidden
            EndContext();
            BeginContext(727, 49, true);
            WriteLiteral("</h4>\r\n                                <h4>Type: ");
            EndContext();
            BeginContext(777, 39, false);
#line 16 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                     Write(Model.Invoices.InvoiceType.InvoiceTypes);

#line default
#line hidden
            EndContext();
            BeginContext(816, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 17 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                 if (Model.Invoices.InvoiceStatus.Status == "Pending")
                                {

#line default
#line hidden
            BeginContext(946, 66, true);
            WriteLiteral("                                    <h4 style=\"color:red\">Status: ");
            EndContext();
            BeginContext(1013, 35, false);
#line 19 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                             Write(Model.Invoices.InvoiceStatus.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 20 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                }
                                else if (Model.Invoices.InvoiceStatus.Status == "Processing")
                                {

#line default
#line hidden
            BeginContext(1220, 69, true);
            WriteLiteral("                                    <h4 style=\"color:orange\">Status: ");
            EndContext();
            BeginContext(1290, 35, false);
#line 23 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                                Write(Model.Invoices.InvoiceStatus.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 24 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1440, 68, true);
            WriteLiteral("                                    <h4 style=\"color:green\">Status: ");
            EndContext();
            BeginContext(1509, 35, false);
#line 27 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                               Write(Model.Invoices.InvoiceStatus.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1544, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 28 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                }

#line default
#line hidden
            BeginContext(1586, 49, true);
            WriteLiteral("                                <h4>Description: ");
            EndContext();
            BeginContext(1636, 26, false);
#line 29 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                            Write(Model.Invoices.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(1735, 49, true);
            WriteLiteral("                                <h4>User create: ");
            EndContext();
            BeginContext(1785, 33, false);
#line 31 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                            Write(Context.Session.GetString("User"));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 1002, true);
            WriteLiteral(@"</h4>
                            </div>
                        </div>
                        <br />
                        <div class=""sparkline13-graph"">
                            <div class=""sparkline8-graph"">
                                <div class=""static-table-list"">
                                    <h4>Product List</h4>
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>Product Id</th>
                                                <th>Product Name</th>
                                                <th>Category</th>
                                                <th>Vendor</th>
                                                <th>Quantity(Boxes)</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
            EndContext();
#line 50 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                             foreach (var productList in Model.productList)
                                            {

#line default
#line hidden
            BeginContext(2960, 110, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
            EndContext();
            BeginContext(3071, 21, false);
#line 53 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                   Write(productList.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3092, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3156, 23, false);
#line 54 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                   Write(productList.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3179, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3243, 20, false);
#line 55 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                   Write(productList.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3263, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3327, 18, false);
#line 56 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                   Write(productList.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(3345, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3409, 20, false);
#line 57 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                                   Write(productList.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3429, 62, true);
            WriteLiteral("</td>\r\n                                                </tr>\r\n");
            EndContext();
#line 59 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\InvoiceDetail.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3538, 314, true);
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
