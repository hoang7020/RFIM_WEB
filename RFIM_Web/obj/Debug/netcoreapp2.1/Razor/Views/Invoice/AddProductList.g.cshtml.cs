#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93261d9caea5e92165ee01f3e6b0bcec187c1a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_AddProductList), @"mvc.1.0.view", @"/Views/Invoice/AddProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/AddProductList.cshtml", typeof(AspNetCore.Views_Invoice_AddProductList))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 5 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
using System.Collections.Generic;

#line default
#line hidden
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
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 3 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
using RFIM_Web.Utils;

#line default
#line hidden
#line 4 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
using RFIM_Web.ModelView;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93261d9caea5e92165ee01f3e6b0bcec187c1a6a", @"/Views/Invoice/AddProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_AddProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.ModelView.ProductExtendAttr>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("datadismiss", new global::Microsoft.AspNetCore.Html.HtmlString("modal-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RenderProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(177, 34, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    ");
            EndContext();
            BeginContext(211, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "857823d29b1148b982e751cd456b8309", async() => {
                BeginContext(309, 7, true);
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
            BeginContext(320, 416, true);
            WriteLiteral(@"
    <h4 class=""modal-title"">Product List</h4>
</div>
<div class=""modal-body form-horizontal"">
    <div class=""sparkline12-graph"">
        <div class=""static-table-list"">
            <div class=""input-group"">
                <span class=""input-group-addon""><i class=""fas fa-search""></i></span>
                <input class=""form-control"" id=""myInput"" type=""text"" placeholder=""Search.."">
            </div>
");
            EndContext();
#line 18 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
             using (Html.BeginForm("AddProductListFinished", "Invoice", FormMethod.Post))
            {

#line default
#line hidden
            BeginContext(842, 402, true);
            WriteLiteral(@"                <table class=""table hover-table"">
                    <thead>
                        <tr>
                            <th>Select</th>
                            <th>Product Id</th>
                            <th>Product Name</th>
                            <th>Quantity Per Box</th>
                            <th>Category</th>
                            <th>Vendor</th>
");
            EndContext();
#line 29 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                             if (Context.Session.GetInt32("invoiceType") == 2)
                            {

#line default
#line hidden
            BeginContext(1355, 65, true);
            WriteLiteral("                            <th>Available Quantity (Boxes)</th>\r\n");
            EndContext();
#line 32 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                            }

#line default
#line hidden
            BeginContext(1451, 103, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody id=\"myTable\">\r\n");
            EndContext();
#line 36 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                          
                            if (Context.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                            {
                                foreach (var product in Model)
                                {

#line default
#line hidden
            BeginContext(1814, 108, true);
            WriteLiteral("                                    <tr>\r\n                                        <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1922, "\"", 1948, 1);
#line 42 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 1930, product.ProductId, 1930, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1949, 81, true);
            WriteLiteral(" id=\"checkList\" name=\"checkList\" />\r\n                                        <td>");
            EndContext();
            BeginContext(2031, 17, false);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2100, 19, false);
#line 44 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2119, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2171, 22, false);
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(2193, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2245, 16, false);
#line 46 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2261, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2313, 14, false);
#line 47 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(2327, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                         if (Context.Session.GetInt32("invoiceType") == 2)
                                        {

#line default
#line hidden
            BeginContext(2469, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(2518, 23, false);
#line 50 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2541, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 51 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2591, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 53 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }
                            }
                            else
                            {
                                List<ProductExtendAttr> ssListProduct = Context.Session.Get<List<ProductExtendAttr>>("listProduct");
                                foreach (var product in ssListProduct)
                                {

#line default
#line hidden
            BeginContext(3006, 108, true);
            WriteLiteral("                                    <tr>\r\n                                        <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3114, "\"", 3140, 1);
#line 61 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 3122, product.ProductId, 3122, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3141, 89, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" checked />\r\n                                        <td>");
            EndContext();
            BeginContext(3231, 17, false);
#line 62 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3248, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3300, 19, false);
#line 63 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3319, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3371, 22, false);
#line 64 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(3393, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3445, 16, false);
#line 65 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3461, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3513, 14, false);
#line 66 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(3527, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 67 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                         if (Context.Session.GetInt32("invoiceType") == 2)
                                        {

#line default
#line hidden
            BeginContext(3669, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(3718, 23, false);
#line 69 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3741, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 70 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3791, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 72 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }
                                foreach (var product in Model)
                                {

#line default
#line hidden
            BeginContext(3968, 108, true);
            WriteLiteral("                                    <tr>\r\n                                        <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4076, "\"", 4102, 1);
#line 76 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 4084, product.ProductId, 4084, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4103, 81, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" />\r\n                                        <td>");
            EndContext();
            BeginContext(4185, 17, false);
#line 77 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(4202, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4254, 19, false);
#line 78 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(4273, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4325, 22, false);
#line 79 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(4347, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4399, 16, false);
#line 80 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(4415, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4467, 14, false);
#line 81 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(4481, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 82 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                         if (Context.Session.GetInt32("invoiceType") == 2)
                                        {

#line default
#line hidden
            BeginContext(4623, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(4672, 23, false);
#line 84 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(4695, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 85 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4745, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 87 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }
                            }
                        

#line default
#line hidden
            BeginContext(4881, 226, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"submit\" onclick=\"Check()\" class=\"btn btn-success\">Confirm</button>\r\n                </div>\r\n");
            EndContext();
#line 95 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
            }

#line default
#line hidden
            BeginContext(5122, 371, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $(""#myInput"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#myTable tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RFIM_Web.ModelView.ProductExtendAttr>> Html { get; private set; }
    }
}
#pragma warning restore 1591
