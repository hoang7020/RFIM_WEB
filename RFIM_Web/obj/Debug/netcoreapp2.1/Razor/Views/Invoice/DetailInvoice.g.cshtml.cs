#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0067063b25b70b079a82aff76cb75119c7ec896d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_DetailInvoice), @"mvc.1.0.view", @"/Views/Invoice/DetailInvoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/DetailInvoice.cshtml", typeof(AspNetCore.Views_Invoice_DetailInvoice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0067063b25b70b079a82aff76cb75119c7ec896d", @"/Views/Invoice/DetailInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_DetailInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.InvoiceDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
  
    ViewData["Title"] = "DetailInvoice";

#line default
#line hidden
            BeginContext(92, 850, true);
            WriteLiteral(@"<div class=""all-content-wrapper"">
    <div class=""container-fluid"">
        <div class=row>
            <!-- Single pro tab End-->
            <!-- Single pro tab review Start-->
            <div class=""single-pro-review-area mt-t-30 mg-b-15"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                            <div class=""tab-content"">
                                <div id=""home"" class=""tab-pane fade in active review-content-section"">
                                    <div class=""sparkline13-graph"">
                                        <div class=""sparkline13-hd"">
                                            <div class=""main-sparkline13-hd"">
                                                <h1>Date: ");
            EndContext();
            BeginContext(943, 19, false);
#line 20 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                     Write(Model.Invoices.Date);

#line default
#line hidden
            EndContext();
            BeginContext(962, 65, true);
            WriteLiteral("</h1>\r\n                                                <h1>Type: ");
            EndContext();
            BeginContext(1028, 39, false);
#line 21 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                     Write(Model.Invoices.InvoiceType.InvoiceTypes);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(1178, 65, true);
            WriteLiteral("                                                <h1>Description: ");
            EndContext();
            BeginContext(1244, 26, false);
#line 23 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                            Write(Model.Invoices.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 935, true);
            WriteLiteral(@"</h1>
                                            </div>
                                        </div>
                                        <div class=""datatable-dashv1-list custom-datatable-overright"">
                                            <table id=""table"" data-toggle=""table"" data-pagination=""true"" data-search=""true"" data-show-columns=""true"" data-show-pagination-switch=""true""
                                                   data-show-toggle=""true"" data-show-export=""true"">
                                                <thead>
                                                    <tr>
                                                        <th>Product</th>
                                                        <th>Quantity</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
            EndContext();
#line 36 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                     foreach (var productList in Model.productList)
                                                    {

#line default
#line hidden
            BeginContext(2361, 128, true);
            WriteLiteral("                                                        <tr>\r\n\r\n                                                            <td>");
            EndContext();
            BeginContext(2490, 23, false);
#line 40 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                           Write(productList.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2513, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2585, 20, false);
#line 41 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                           Write(productList.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2605, 70, true);
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 43 "E:\Source\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(2730, 942, true);
            WriteLiteral(@"                                                </tbody>
                                            </table>
                                            <div id=""modal-invoice"" aria-hidden=""true"" class=""modal fade"" role=""dialog"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.InvoiceDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
