#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d974e26867f277087b2e35807d96f10a716c79"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d974e26867f277087b2e35807d96f10a716c79", @"/Views/Product/DetailProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DetailProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("280"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("280"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(637, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6bd50866f7542029ff4b8b4d33d837a", async() => {
                BeginContext(726, 142, true);
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
            BeginContext(872, 164, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <ul class=\"h-list m-t\" id=\"list_detail\">\r\n                            ");
            EndContext();
            BeginContext(1037, 48, false);
#line 23 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                       Write(await Component.InvokeAsync("ProductDetailList"));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 640, true);
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
            BeginContext(1725, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0493b57edb354191a63113ed226a0df2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1735, "~/Hinh/product/", 1735, 15, true);
#line 35 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
AddHtmlAttributeValue("", 1750, Model.Image, 1750, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1791, 325, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                            <div class=""col-lg-7 col-md-7 col-sm-7 col-xs-12"">
                                <div class=""single-product-details res-pro-tb"">
                                    <h1>");
            EndContext();
            BeginContext(2117, 17, false);
#line 42 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                   Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2134, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2135, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d952ec616a65432cac94ff392ef7bc17", async() => {
                BeginContext(2220, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
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
            BeginContext(2251, 220, true);
            WriteLiteral("</h1>\r\n                                    <div class=\"single-pro-cn\">\r\n                                        <h3>OVERVIEW</h3>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(2472, 17, false);
#line 46 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2489, 500, true);
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
            BeginContext(2990, 12, false);
#line 54 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(3002, 516, true);
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
            BeginContext(3519, 12, false);
#line 62 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Height);

#line default
#line hidden
            EndContext();
            BeginContext(3531, 516, true);
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
            BeginContext(4048, 11, false);
#line 70 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Width);

#line default
#line hidden
            EndContext();
            BeginContext(4059, 517, true);
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
            BeginContext(4577, 12, false);
#line 78 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(4589, 514, true);
            WriteLiteral(@" cm</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Status</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label>");
            EndContext();
#line 86 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                    if (Model.Status)
                                            {

#line default
#line hidden
            BeginContext(5170, 63, true);
            WriteLiteral("                                                <b>Active</b>\r\n");
            EndContext();
#line 89 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(5377, 65, true);
            WriteLiteral("                                                <b>Deactive</b>\r\n");
            EndContext();
#line 93 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5487, 512, true);
            WriteLiteral(@"</label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Category</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(6000, 27, false);
#line 101 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(6027, 514, true);
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
            BeginContext(6542, 23, false);
#line 109 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Vendor.VendorName);

#line default
#line hidden
            EndContext();
            BeginContext(6565, 521, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Total quantity of boxes</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            ");
            EndContext();
            BeginContext(7087, 88, false);
#line 117 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                       Write(await Component.InvokeAsync("QuantityBoxInProduct", new { productId = Model.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(7175, 2022, true);
            WriteLiteral(@"
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
                                <div class=""tab-content"">
        ");
            WriteLiteral(@"                            <div id=""home"" class=""tab-pane fade in active review-content-section"">
                                        <div class=""sparkline8-graph"">
                                            <div class=""static-table-list"">
                                                <table class=""table"">
                                                    <thead>
                                                        <tr>
                                                            <th>Package ID</th>
                                                            <th>Cell ID</th>
                                                            <th>Date</th>
                                                            <th>Quantity</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        ");
            EndContext();
            BeginContext(9198, 87, false);
#line 150 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                   Write(await Html.PartialAsync("PackageView", (List<Package>)ViewBag.PackageSelectFromProduct));

#line default
#line hidden
            EndContext();
            BeginContext(9285, 413, true);
            WriteLiteral(@";
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div id=""menu3"" class=""tab-pane fade review-content-section"">
                                        <h6>   ");
            EndContext();
            BeginContext(9699, 17, false);
#line 157 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(9716, 948, true);
            WriteLiteral(@"</h6>
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
            a = li[i].getElementsByTagName(""a"")[0];
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
