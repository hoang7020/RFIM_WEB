#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba1c05415bcc88cf5527aa73d48ee71dc6beeb8f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba1c05415bcc88cf5527aa73d48ee71dc6beeb8f", @"/Views/Invoice/AddProductList.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f331c5212ff648609ffa715099195fb7", async() => {
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
            BeginContext(320, 418, true);
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
#line 19 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
             using (Html.BeginForm("AddProductListFinished", "Invoice", FormMethod.Post))
            {

#line default
#line hidden
            BeginContext(844, 472, true);
            WriteLiteral(@"            <div class=""table-wrapper-scroll-y my-custom-scrollbar"">
                <table class=""table hover-table"">
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
#line 31 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                             if (Context.Session.GetInt32("invoiceType") == 2)
                            {

#line default
#line hidden
            BeginContext(1427, 69, true);
            WriteLiteral("                                <th>Available Quantity (Boxes)</th>\r\n");
            EndContext();
#line 34 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                            }

#line default
#line hidden
            BeginContext(1527, 103, true);
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody id=\"myTable\">\r\n");
            EndContext();
#line 38 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                          
                            if (Context.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                            {
                                foreach (var product in Model)
                                {

#line default
#line hidden
            BeginContext(1890, 108, true);
            WriteLiteral("                                    <tr>\r\n                                        <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1998, "\"", 2024, 1);
#line 44 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 2006, product.ProductId, 2006, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2025, 81, true);
            WriteLiteral(" id=\"checkList\" name=\"checkList\" />\r\n                                        <td>");
            EndContext();
            BeginContext(2107, 17, false);
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2124, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2176, 19, false);
#line 46 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2195, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2247, 22, false);
#line 47 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(2269, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2321, 16, false);
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2337, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2389, 14, false);
#line 49 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(2403, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 50 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                         if (Context.Session.GetInt32("invoiceType") == 2)
                                        {

#line default
#line hidden
            BeginContext(2545, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(2594, 23, false);
#line 52 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2617, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 53 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2667, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }
                            }
                            else
                            {
                                List<ProductExtendAttr> ssListProduct = Context.Session.Get<List<ProductExtendAttr>>("listProduct");
                                foreach (var product in ssListProduct)
                                {

#line default
#line hidden
            BeginContext(3082, 108, true);
            WriteLiteral("                                    <tr>\r\n                                        <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3190, "\"", 3216, 1);
#line 63 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 3198, product.ProductId, 3198, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3217, 89, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" checked />\r\n                                        <td>");
            EndContext();
            BeginContext(3307, 17, false);
#line 64 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3324, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3376, 19, false);
#line 65 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3395, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3447, 22, false);
#line 66 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(3469, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3521, 16, false);
#line 67 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3537, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3589, 14, false);
#line 68 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(3603, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 69 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                         if (Context.Session.GetInt32("invoiceType") == 2)
                                        {

#line default
#line hidden
            BeginContext(3745, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(3794, 23, false);
#line 71 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3817, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 72 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3867, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 74 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }
                                foreach (var product in Model)
                                {

#line default
#line hidden
            BeginContext(4044, 108, true);
            WriteLiteral("                                    <tr>\r\n                                        <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4152, "\"", 4178, 1);
#line 78 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 4160, product.ProductId, 4160, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4179, 81, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" />\r\n                                        <td>");
            EndContext();
            BeginContext(4261, 17, false);
#line 79 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(4278, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4330, 19, false);
#line 80 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(4349, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4401, 22, false);
#line 81 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(4423, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4475, 16, false);
#line 82 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(4491, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4543, 14, false);
#line 83 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                       Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(4557, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 84 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                         if (Context.Session.GetInt32("invoiceType") == 2)
                                        {

#line default
#line hidden
            BeginContext(4699, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(4748, 23, false);
#line 86 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(4771, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 87 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4821, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 89 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }
                            }
                        

#line default
#line hidden
            BeginContext(4957, 240, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"submit\" class=\"btn btn-success\">Confirm</button>\r\n                    </div>\r\n");
            EndContext();
#line 98 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                    }

#line default
#line hidden
            BeginContext(5220, 393, true);
            WriteLiteral(@"                </div>
            
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
