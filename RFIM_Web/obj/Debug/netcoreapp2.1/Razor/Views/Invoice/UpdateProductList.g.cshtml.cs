#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d560f1f3233db447ab8a71585e8524c704289be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_UpdateProductList), @"mvc.1.0.view", @"/Views/Invoice/UpdateProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/UpdateProductList.cshtml", typeof(AspNetCore.Views_Invoice_UpdateProductList))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 5 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
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
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 3 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
using RFIM_Web.Utils;

#line default
#line hidden
#line 4 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
using RFIM_Web.ModelView;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d560f1f3233db447ab8a71585e8524c704289be", @"/Views/Invoice/UpdateProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_UpdateProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.ModelView.ProductExtendAttr>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("datadismiss", new global::Microsoft.AspNetCore.Html.HtmlString("modal-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RenderEditProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(211, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fda44117a068466b8be379ca052267fe", async() => {
                BeginContext(313, 7, true);
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
            BeginContext(324, 486, true);
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
            <div class=""table-wrapper-scroll-y my-custom-scrollbar"">
");
            EndContext();
#line 19 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                 using (Html.BeginForm("UpdateProductListFinished", "Invoice", FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(927, 438, true);
            WriteLiteral(@"                    <table class=""table hover-table"">
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
#line 30 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                 if (Context.Session.GetInt32("invoiceType") == 2)
                                {

#line default
#line hidden
            BeginContext(1484, 71, true);
            WriteLiteral("                                    <th>On-hand Quantity (Boxes)</th>\r\n");
            EndContext();
#line 33 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                }

#line default
#line hidden
            BeginContext(1590, 115, true);
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody id=\"myTable\">\r\n");
            EndContext();
#line 37 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                              
                                if (Context.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                                {
                                    foreach (var product in Model)
                                    {

#line default
#line hidden
            BeginContext(1985, 116, true);
            WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2101, "\"", 2127, 1);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
WriteAttributeValue("", 2109, product.ProductId, 2109, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2128, 85, true);
            WriteLiteral(" id=\"checkList\" name=\"checkList\" />\r\n                                            <td>");
            EndContext();
            BeginContext(2214, 17, false);
#line 44 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2231, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2287, 19, false);
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2306, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2362, 22, false);
#line 46 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(2384, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2440, 16, false);
#line 47 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2456, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2512, 14, false);
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(2526, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 49 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                             if (Context.Session.GetInt32("invoiceType") == 2)
                                            {

#line default
#line hidden
            BeginContext(2676, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(2729, 23, false);
#line 51 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                               Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2752, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 52 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2806, 47, true);
            WriteLiteral("                                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                    }
                                }
                                else
                                {
                                    List<ProductExtendAttr> ssListProduct = Context.Session.Get<List<ProductExtendAttr>>("listProduct");
                                    foreach (var product in ssListProduct)
                                    {

#line default
#line hidden
            BeginContext(3253, 116, true);
            WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3369, "\"", 3395, 1);
#line 62 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
WriteAttributeValue("", 3377, product.ProductId, 3377, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3396, 93, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" checked />\r\n                                            <td>");
            EndContext();
            BeginContext(3490, 17, false);
#line 63 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3507, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3563, 19, false);
#line 64 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3582, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3638, 22, false);
#line 65 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(3660, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3716, 16, false);
#line 66 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3732, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3788, 14, false);
#line 67 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(3802, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 68 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                             if (Context.Session.GetInt32("invoiceType") == 2)
                                            {

#line default
#line hidden
            BeginContext(3952, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(4005, 23, false);
#line 70 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                               Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(4028, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 71 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4082, 47, true);
            WriteLiteral("                                        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                    }
                                    foreach (var product in Model)
                                    {

#line default
#line hidden
            BeginContext(4275, 116, true);
            WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4391, "\"", 4417, 1);
#line 77 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
WriteAttributeValue("", 4399, product.ProductId, 4399, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4418, 85, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" />\r\n                                            <td>");
            EndContext();
            BeginContext(4504, 17, false);
#line 78 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(4521, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4577, 19, false);
#line 79 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(4596, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4652, 22, false);
#line 80 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(4674, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4730, 16, false);
#line 81 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(4746, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4802, 14, false);
#line 82 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                           Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(4816, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 83 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                             if (Context.Session.GetInt32("invoiceType") == 2)
                                            {

#line default
#line hidden
            BeginContext(4966, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(5019, 23, false);
#line 85 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                               Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(5042, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 86 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5096, 47, true);
            WriteLiteral("                                        </tr>\r\n");
            EndContext();
#line 88 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                                    }
                                }
                            

#line default
#line hidden
            BeginContext(5248, 246, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"submit\" onclick=\"Check()\" class=\"btn btn-success\">Confirm</button>\r\n                    </div>\r\n");
            EndContext();
#line 96 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\UpdateProductList.cshtml"
                }

#line default
#line hidden
            BeginContext(5513, 415, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
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
