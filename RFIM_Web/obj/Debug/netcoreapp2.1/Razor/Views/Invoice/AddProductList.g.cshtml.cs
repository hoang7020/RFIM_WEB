#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae1549428534dba1bd33503a7868ff269556eb1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae1549428534dba1bd33503a7868ff269556eb1", @"/Views/Invoice/AddProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a69760db975471d19d631bed21f74b4dabb7b6", @"/Views/_ViewImports.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "382a164c7e2e4a928c2bea5a682f6918", async() => {
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
            BeginContext(320, 486, true);
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
#line 19 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                 using (Html.BeginForm("AddProductListFinished", "Invoice", FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(920, 438, true);
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
#line 30 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                 if (Context.Session.GetInt32("invoiceType") == 2)
                                {

#line default
#line hidden
            BeginContext(1477, 73, true);
            WriteLiteral("                                    <th>Available Quantity (Boxes)</th>\r\n");
            EndContext();
#line 33 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                }

#line default
#line hidden
            BeginContext(1585, 115, true);
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody id=\"myTable\">\r\n");
            EndContext();
#line 37 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                              
                                if (Context.Session.Get<List<ProductExtendAttr>>("listProduct") == null)
                                {
                                    foreach (var product in Model)
                                    {

#line default
#line hidden
            BeginContext(1980, 116, true);
            WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2096, "\"", 2122, 1);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 2104, product.ProductId, 2104, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2123, 85, true);
            WriteLiteral(" id=\"checkList\" name=\"checkList\" />\r\n                                            <td>");
            EndContext();
            BeginContext(2209, 17, false);
#line 44 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2226, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2282, 19, false);
#line 45 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2357, 22, false);
#line 46 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(2379, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2435, 16, false);
#line 47 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2451, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2507, 14, false);
#line 48 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(2521, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 49 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                             if (Context.Session.GetInt32("invoiceType") == 2)
                                            {

#line default
#line hidden
            BeginContext(2671, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(2724, 23, false);
#line 51 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                               Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2747, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 52 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2801, 47, true);
            WriteLiteral("                                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                    }
                                }
                                else
                                {
                                    List<ProductExtendAttr> ssListProduct = Context.Session.Get<List<ProductExtendAttr>>("listProduct");
                                    foreach (var product in ssListProduct)
                                    {

#line default
#line hidden
            BeginContext(3248, 116, true);
            WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3364, "\"", 3390, 1);
#line 62 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 3372, product.ProductId, 3372, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3391, 93, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" checked />\r\n                                            <td>");
            EndContext();
            BeginContext(3485, 17, false);
#line 63 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3502, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3558, 19, false);
#line 64 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3577, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3633, 22, false);
#line 65 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(3655, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3711, 16, false);
#line 66 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(3727, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(3783, 14, false);
#line 67 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(3797, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 68 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                             if (Context.Session.GetInt32("invoiceType") == 2)
                                            {

#line default
#line hidden
            BeginContext(3947, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(4000, 23, false);
#line 70 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                               Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(4023, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 71 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4077, 47, true);
            WriteLiteral("                                        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                    }
                                    foreach (var product in Model)
                                    {

#line default
#line hidden
            BeginContext(4270, 116, true);
            WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4386, "\"", 4412, 1);
#line 77 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
WriteAttributeValue("", 4394, product.ProductId, 4394, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4413, 85, true);
            WriteLiteral(" name=\"checkList\" id=\"checkList\" />\r\n                                            <td>");
            EndContext();
            BeginContext(4499, 17, false);
#line 78 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(4516, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4572, 19, false);
#line 79 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(4591, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4647, 22, false);
#line 80 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.QuantityPerBox);

#line default
#line hidden
            EndContext();
            BeginContext(4669, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4725, 16, false);
#line 81 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(4741, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4797, 14, false);
#line 82 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                           Write(product.Vendor);

#line default
#line hidden
            EndContext();
            BeginContext(4811, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 83 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                             if (Context.Session.GetInt32("invoiceType") == 2)
                                            {

#line default
#line hidden
            BeginContext(4961, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(5014, 23, false);
#line 85 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                               Write(product.InstockQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(5037, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 86 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5091, 47, true);
            WriteLiteral("                                        </tr>\r\n");
            EndContext();
#line 88 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                                    }
                                }
                            

#line default
#line hidden
            BeginContext(5243, 246, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"submit\" onclick=\"Check()\" class=\"btn btn-success\">Confirm</button>\r\n                    </div>\r\n");
            EndContext();
#line 96 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Invoice\AddProductList.cshtml"
                }

#line default
#line hidden
            BeginContext(5508, 423, true);
            WriteLiteral(@"            </div>
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
