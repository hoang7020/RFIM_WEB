#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "776e927de8ce03fcee9ba485864f1c9e03e489c2"
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
#line 1 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"776e927de8ce03fcee9ba485864f1c9e03e489c2", @"/Views/Product/DetailProduct.cshtml")]
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
#line 3 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
  
    ViewData["Title"] = "DetailProduct";

#line default
#line hidden
            BeginContext(83, 740, true);
            WriteLiteral(@"
<div class=""all-content-wrapper"">
    <div class=""container-fluid"">
        <div class=row>
            <div class=""col-md-3 col-md-3 col-sm-3 col-xs-12 mg-t-15"">
                <div class=""hpanel responsive-mg-b-30"">
                    <div class=""panel-body"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fas fa-search""></i></span>
                            <input  type=""text"" placeholder=""Search..."" class=""form-control"" id=""myInput"" onkeyup=""myFunction()"" />
                        </div>
                        <div class=""row"">
                            <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6"">
                                ");
            EndContext();
            BeginContext(823, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff3440ae0bc47978ae17994a716176e", async() => {
                BeginContext(912, 142, true);
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
            BeginContext(1058, 218, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"scroll\">\r\n                            <ul class=\"h-list m-t\" id=\"list_detail\">\r\n                                ");
            EndContext();
            BeginContext(1277, 48, false);
#line 27 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                           Write(await Component.InvokeAsync("ProductDetailList"));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 676, true);
            WriteLiteral(@"
                            </ul>
                        </div>
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
            BeginContext(2001, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a59d831590b349caa8c87acedd011b07", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2011, "~/Hinh/product/", 2011, 15, true);
#line 40 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
AddHtmlAttributeValue("", 2026, Model.Image, 2026, 12, false);

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
            BeginContext(2067, 325, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                            <div class=""col-lg-7 col-md-7 col-sm-7 col-xs-12"">
                                <div class=""single-product-details res-pro-tb"">
                                    <h1>");
            EndContext();
            BeginContext(2393, 17, false);
#line 47 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                   Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2410, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2411, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c70b3f3cef44e1084b2afa5d637743d", async() => {
                BeginContext(2496, 27, true);
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
#line 47 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
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
            BeginContext(2527, 220, true);
            WriteLiteral("</h1>\r\n                                    <div class=\"single-pro-cn\">\r\n                                        <h3>OVERVIEW</h3>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(2748, 17, false);
#line 51 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2765, 504, true);
            WriteLiteral(@"
                                        </p>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Weight(g):</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(3270, 12, false);
#line 59 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(3282, 519, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Height(cm):</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(3802, 12, false);
#line 67 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Height);

#line default
#line hidden
            EndContext();
            BeginContext(3814, 518, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Width(cm):</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(4333, 11, false);
#line 75 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Width);

#line default
#line hidden
            EndContext();
            BeginContext(4344, 519, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Length(cm):</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(4864, 12, false);
#line 83 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(4876, 512, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Status:</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label>");
            EndContext();
#line 91 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                    if (Model.Status)
                                            {

#line default
#line hidden
            BeginContext(5455, 63, true);
            WriteLiteral("                                                <b>Active</b>\r\n");
            EndContext();
#line 94 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(5662, 65, true);
            WriteLiteral("                                                <b>Deactive</b>\r\n");
            EndContext();
#line 98 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5772, 513, true);
            WriteLiteral(@"</label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Category:</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(6286, 27, false);
#line 106 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(6313, 515, true);
            WriteLiteral(@"</b></label>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                                            <label>Vendor:</label>
                                        </div>
                                        <div class=""col-lg-8 col-md-8 col-sm-8 col-xs-12"">
                                            <label><b>");
            EndContext();
            BeginContext(6829, 23, false);
#line 114 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                 Write(Model.Vendor.VendorName);

#line default
#line hidden
            EndContext();
            BeginContext(6852, 2034, true);
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
                                                            <th>Date</th>
                                                            <th>Quantity</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        ");
            EndContext();
            BeginContext(8887, 87, false);
#line 147 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                                   Write(await Html.PartialAsync("PackageView", (List<Package>)ViewBag.PackageSelectFromProduct));

#line default
#line hidden
            EndContext();
            BeginContext(8974, 413, true);
            WriteLiteral(@";
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div id=""menu3"" class=""tab-pane fade review-content-section"">
                                        <h6>   ");
            EndContext();
            BeginContext(9388, 17, false);
#line 154 "E:\Source\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(9405, 948, true);
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
