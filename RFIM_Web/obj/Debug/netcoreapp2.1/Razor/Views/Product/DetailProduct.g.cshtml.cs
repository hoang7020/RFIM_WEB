#pragma checksum "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680e1a91b276ff48b74fbd79ed6e33b8df4d2ea2"
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
#line 1 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680e1a91b276ff48b74fbd79ed6e33b8df4d2ea2", @"/Views/Product/DetailProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DetailProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
  
    ViewData["Title"] = "DetailProduct";

#line default
#line hidden
            BeginContext(83, 630, true);
            WriteLiteral(@"<div class=""all-content-wrapper"">
    <div class=""container-fluid"">
        <div class=row>
            <div class=""col-xs-8 col-sm-8 col-md-8 col-lg-8"">
                <div class=""single-product-tab-area mg-t-15 mg-b-30"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-lg-5 col-md-5 col-sm-5 col-xs-12"">
                                <div id=""myTabContent1"" class=""tab-content"">
                                    <div class=""product-tab-list tab-pane fade active in"" id=""single-tab1"">
                                        ");
            EndContext();
            BeginContext(713, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38887579325c421c9c45edf8d2de6b02", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 723, "~/Hinh/product/", 723, 15, true);
#line 16 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
AddHtmlAttributeValue("", 738, Model.Image, 738, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(761, 325, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                            <div class=""col-lg-7 col-md-7 col-sm-7 col-xs-12"">
                                <div class=""single-product-details res-pro-tb"">
                                    <h1>");
            EndContext();
            BeginContext(1087, 17, false);
#line 23 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                   Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1105, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a3696f46c6340b580b93b79061242cd", async() => {
                BeginContext(1190, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
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
            BeginContext(1221, 220, true);
            WriteLiteral("</h1>\r\n                                    <div class=\"single-pro-cn\">\r\n                                        <h3>OVERVIEW</h3>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(1442, 17, false);
#line 27 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Product\DetailProduct.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 2432, true);
            WriteLiteral(@"
                                        </p>
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
                                    <li class=""active""><a data-toggle=""tab"" href=""#home"">Description<span><i class=""fa fa-star""></i></span></a></li>
                                    <li><a data-toggle=""tab"" href=""#menu3"">Information</a></li>
                                </ul>
                                <div class=""tab-content"">
      ");
            WriteLiteral(@"                              <div id=""home"" class=""tab-pane fade in active review-content-section"">
                                        <h3>Description</h3>
                                        <p>Descriptionnnnnnn</p>
                                    </div>
                                    <div id=""menu3"" class=""tab-pane fade review-content-section"">
                                        <h3>Information</h3>
                                        <p>Informationnn</p>
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
        ul = document.getElementById(""myUL"");
        li = ul.getElementsBy");
            WriteLiteral(@"TagName(""li"");
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
