#pragma checksum "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0f83cce7dcd98c3282cd777dde9b4333377a80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CategorySelect), @"mvc.1.0.view", @"/Views/Shared/CategorySelect.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/CategorySelect.cshtml", typeof(AspNetCore.Views_Shared_CategorySelect))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0f83cce7dcd98c3282cd777dde9b4333377a80", @"/Views/Shared/CategorySelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CategorySelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.CategorySelect>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
  
    int categorySelect = Model.Select.HasValue ? Model.Select.Value : 0;

#line default
#line hidden
            BeginContext(125, 53, true);
            WriteLiteral("<select name=\"CategoryId\" class=\"form-control\">\r\n    ");
            EndContext();
            BeginContext(178, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a64c80026d4ba6a03e19ae2f471d31", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
      
        var dsCategory = Model.Data;
    

#line default
#line hidden
            BeginContext(260, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 11 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
     foreach (var category in dsCategory)
    {

#line default
#line hidden
            BeginContext(310, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(318, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf27cf0e2760489583e736a802bf5ad0", async() => {
                BeginContext(355, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(370, 21, false);
#line 14 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
       Write(category.CategoryName);

#line default
#line hidden
                EndContext();
                BeginContext(391, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
           WriteLiteral(category.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
    }

#line default
#line hidden
            BeginContext(419, 85, true);
            WriteLiteral("</select>\r\n<script>\r\n    $(function () {\r\n        $(\"select[name=\'CategoryId\']\").val(");
            EndContext();
            BeginContext(505, 25, false);
#line 20 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shared\CategorySelect.cshtml"
                                      Write(categorySelect.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(530, 26, true);
            WriteLiteral(");\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.CategorySelect> Html { get; private set; }
    }
}
#pragma warning restore 1591
