#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "685a442b5321cdaff22e7bdb3664ecb7fb10e266"
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
#line 1 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685a442b5321cdaff22e7bdb3664ecb7fb10e266", @"/Views/Invoice/DetailInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_DetailInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.InvoiceDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
  
    ViewData["Title"] = "DetailInvoice";

#line default
#line hidden
            BeginContext(92, 666, true);
            WriteLiteral(@"<div class=""all-content-wrapper"">
    <div class=""container-fluid"">
        <div class=row>
            <!-- Single pro tab End-->
            <!-- Single pro tab review Start-->
            <div class=""single-pro-review-area mt-t-30 mg-b-15"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                            <div class=""sparkline12-list mg-t-15"">
                                <div class=""sparkline12-hd"">
                                    <div class=""main-sparkline12-hd"">
                                        <h1>Date: ");
            EndContext();
            BeginContext(759, 19, false);
#line 18 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                             Write(Model.Invoices.Date);

#line default
#line hidden
            EndContext();
            BeginContext(778, 57, true);
            WriteLiteral("</h1>\r\n                                        <h1>Type: ");
            EndContext();
            BeginContext(836, 39, false);
#line 19 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                             Write(Model.Invoices.InvoiceType.InvoiceTypes);

#line default
#line hidden
            EndContext();
            BeginContext(875, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(978, 57, true);
            WriteLiteral("                                        <h1>Description: ");
            EndContext();
            BeginContext(1036, 26, false);
#line 21 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                    Write(Model.Invoices.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 710, true);
            WriteLiteral(@"</h1>
                                    </div>
                                </div>
                                <div class=""sparkline12-graph"">
                                    <div class=""static-table-list"">
                                        <table class=""table hover-table"">
                                            <thead>
                                                <tr>
                                                    <th>Product</th>
                                                    <th>Quantity</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 34 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                 foreach (var productList in Model.productList)
                                                {

#line default
#line hidden
            BeginContext(1920, 120, true);
            WriteLiteral("                                                    <tr>\r\n\r\n                                                        <td>");
            EndContext();
            BeginContext(2041, 23, false);
#line 38 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                       Write(productList.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2064, 67, true);
            WriteLiteral("</td>\r\n                                                        <td>");
            EndContext();
            BeginContext(2132, 20, false);
#line 39 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                       Write(productList.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2152, 66, true);
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 41 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\DetailInvoice.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2269, 362, true);
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