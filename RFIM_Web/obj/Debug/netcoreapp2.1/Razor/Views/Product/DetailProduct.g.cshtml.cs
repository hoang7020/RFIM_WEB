#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5adb88812d81ea0089a958ba06c05896953fc7e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DetailProduct), @"mvc.1.0.view", @"/Views/Product/DetailProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/DetailProduct.cshtml", typeof(AspNetCore.Views_Product_DetailProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5adb88812d81ea0089a958ba06c05896953fc7e1", @"/Views/Product/DetailProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DetailProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
  
    ViewData["Title"] = "DetailProduct";

#line default
#line hidden
            BeginContext(83, 554, true);
            WriteLiteral(@"
<div class=""all-content-wrapper"">
    <div class=""container-fluid"">
        <div class=row>
            <div class=""col-md-3 col-md-3 col-sm-3 col-xs-12 mg-t-15"">
                <div class=""hpanel responsive-mg-b-30"">
                    <div class=""panel-body"">
                        <input type=""text"" placeholder=""Search..."" class=""form-control"" id=""myInput"" onkeyup=""myFunction()"" />
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6"">
                                ");
            EndContext();
            BeginContext(637, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78818c871fda464ca4e1e2fbe31cde84", async() => {
                BeginContext(725, 142, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-plus\"></i>\r\n                                    Create\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(871, 164, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <ul class=\"h-list m-t\" id=\"list_detail\">\r\n                            ");
            EndContext();
            BeginContext(1036, 48, false);
#line 23 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                       Write(await Component.InvokeAsync("ProductDetailList"));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 642, true);
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
            </div>

            <div class=""col-xs-8 col-sm-8 col-md-8 col-lg-8"">
                <div class=""single-product-tab-area mg-t-15 mg-b-30"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-lg-5 col-md-5 col-sm-5 col-xs-12"">
                                <div id=""myTabContent1"" class=""tab-content"">
                                    <div class=""product-tab-list tab-pane fade active in"" id=""single-tab1"">
                                        ");
            EndContext();
            BeginContext(1726, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3672e7dc1a548e7bf11e8e1b53239f6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1736, "~/Hinh/product/", 1736, 15, true);
#line 36 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
AddHtmlAttributeValue("", 1751, Model.Image, 1751, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1774, 325, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                            <div class=""col-lg-7 col-md-7 col-sm-7 col-xs-12"">
                                <div class=""single-product-details res-pro-tb"">
                                    <h1>");
            EndContext();
            BeginContext(2100, 17, false);
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                   Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2117, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2118, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a9bf5d2515e4c8fab55f1bbe8e6a595", async() => {
                BeginContext(2203, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                                                                                  WriteLiteral(Model.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2234, 220, true);
            WriteLiteral("</h1>\r\n                                    <div class=\"single-pro-cn\">\r\n                                        <h3>OVERVIEW</h3>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(2455, 17, false);
#line 47 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2472, 500, true);
            WriteLiteral(@"
                                        </p>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Weight</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(2973, 12, false);
#line 55 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(2985, 516, true);
            WriteLiteral(@" g</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Height</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(3502, 12, false);
#line 63 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Height);

#line default
#line hidden
            EndContext();
            BeginContext(3514, 516, true);
            WriteLiteral(@" cm</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Width</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(4031, 11, false);
#line 71 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Width);

#line default
#line hidden
            EndContext();
            BeginContext(4042, 517, true);
            WriteLiteral(@" cm</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Length</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(4560, 12, false);
#line 79 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Lenght);

#line default
#line hidden
            EndContext();
            BeginContext(4572, 519, true);
            WriteLiteral(@" cm</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Category</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(5092, 27, false);
#line 87 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(5119, 514, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Vendor</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(5634, 23, false);
#line 95 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Vendor.VendorName);

#line default
#line hidden
            EndContext();
            BeginContext(5657, 1959, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Single pro tab End-->
                <!-- Single pro tab review Start-->

                <div class=""single-pro-review-area mt-t-30 mg-b-15"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                <ul class=""tab-review-design"" id=""myTab"">
                                    <li class=""active""><a data-toggle=""tab"" href=""#home"">Package<span><i class=""fa fa-star""></i></span></a></li>
                                    <li><a data-toggle=""tab"" href=""#menu3"">Description</a></li>
                                </ul>
                                <div class=""tab-content");
            WriteLiteral(@""">
                                    <div id=""home"" class=""tab-pane fade in active review-content-section"">
                                        <div class=""sparkline8-graph"">
                                            <div class=""static-table-list"">
                                                <table class=""table"">
                                                    <thead>
                                                        <tr>
                                                            <th>Package ID</th>
                                                            <th>Cell ID</th>
                                                            <th>Quantity</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        ");
            EndContext();
            BeginContext(7617, 87, false);
#line 127 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                   Write(await Html.PartialAsync("PackageView", (List<Package>)ViewBag.PackageSelectFromProduct));

#line default
#line hidden
            EndContext();
            BeginContext(7704, 1369, true);
            WriteLiteral(@";
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div id=""menu3"" class=""tab-pane fade review-content-section"">
                                        <h3>Description</h3>
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

<script>
    function myFunction() {
        var input, filter, ul, li, a, i, txtValue;
        input = document.getElementById(""myInput"");
        filter = input.value.toUpperCase();
        ul = document.getElementById(""list_detail"");
        li = ul.getElementsByTagName(""li"");
        for (i = 0; i < li.length; i++) {
   ");
            WriteLiteral(@"         a = li[i].getElementsByTagName(""a"")[0];
            txtValue = a.textContent || a.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                li[i].style.display = """";
            } else {
                li[i].style.display = ""none"";
            }
        }
    }
</script>
<script>

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
