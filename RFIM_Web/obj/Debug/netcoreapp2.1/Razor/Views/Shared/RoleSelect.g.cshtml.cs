<<<<<<< HEAD
#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ee2d26adb945f605ad1a164b0599431df36b82"
=======
#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ee2d26adb945f605ad1a164b0599431df36b82"
>>>>>>> dev_test_3
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RoleSelect), @"mvc.1.0.view", @"/Views/Shared/RoleSelect.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/RoleSelect.cshtml", typeof(AspNetCore.Views_Shared_RoleSelect))]
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
<<<<<<< HEAD
#line 1 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
>>>>>>> dev_test_3
using RFIM_Web;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
>>>>>>> dev_test_3
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ee2d26adb945f605ad1a164b0599431df36b82", @"/Views/Shared/RoleSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RoleSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.RoleSelectModel>
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
<<<<<<< HEAD
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
  
    int roleSelect = Model.Select.HasValue ? Model.Select.Value : 0;

#line default
#line hidden
            BeginContext(120, 49, true);
            WriteLiteral("<select name=\"RoleID\" class=\"form-control\">\r\n    ");
            EndContext();
            BeginContext(169, 35, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7a2331cfaed41efb2aeafa2b350bb53", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3adf6dcba1e449ea5a49b59e2436fb1", async() => {
>>>>>>> dev_test_3
                BeginContext(187, 8, true);
                WriteLiteral("--------");
                EndContext();
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
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
<<<<<<< HEAD
#line 7 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 7 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
      
        var dsRole = Model.Data;
    

#line default
#line hidden
            BeginContext(255, 4, true);
            WriteLiteral("    ");
            EndContext();
<<<<<<< HEAD
#line 10 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 10 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
     foreach (var role in dsRole)
    {

#line default
#line hidden
            BeginContext(297, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(305, 76, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96d951cc193741d89839f0f27fd34a9b", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41621681eae442cb9f799085c82453d8", async() => {
>>>>>>> dev_test_3
                BeginContext(334, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(349, 13, false);
<<<<<<< HEAD
#line 13 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 13 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
       Write(role.RoleName);

#line default
#line hidden
                EndContext();
                BeginContext(362, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
<<<<<<< HEAD
#line 12 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 12 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
           WriteLiteral(role.RoleId);

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
            BeginContext(381, 2, true);
            WriteLiteral("\r\n");
            EndContext();
<<<<<<< HEAD
#line 15 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 15 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
    }

#line default
#line hidden
            BeginContext(390, 81, true);
            WriteLiteral("</select>\r\n<script>\r\n    $(function () {\r\n        $(\"select[name=\'RoleID\']\").val(");
            EndContext();
            BeginContext(472, 21, false);
<<<<<<< HEAD
#line 19 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
=======
#line 19 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\RoleSelect.cshtml"
>>>>>>> dev_test_3
                                  Write(roleSelect.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(493, 22, true);
            WriteLiteral(");\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.RoleSelectModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
