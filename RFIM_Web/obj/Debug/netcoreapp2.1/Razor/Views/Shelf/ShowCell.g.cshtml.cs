<<<<<<< HEAD
#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88ca529e5f10b447241bb805649f1e2371d0058"
=======
#pragma checksum "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718f33676fa90b01dd5909e03d70986d123689e3"
>>>>>>> dev_thinh3
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shelf_ShowCell), @"mvc.1.0.view", @"/Views/Shelf/ShowCell.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shelf/ShowCell.cshtml", typeof(AspNetCore.Views_Shelf_ShowCell))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88ca529e5f10b447241bb805649f1e2371d0058", @"/Views/Shelf/ShowCell.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shelf_ShowCell : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RFIM_Web.Models.Cell>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("datadismiss", new global::Microsoft.AspNetCore.Html.HtmlString("modal-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BackToShelfList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shelf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 34, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    ");
            EndContext();
            BeginContext(76, 105, false);
<<<<<<< HEAD
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0006054ae0a4f20a325becde085379a", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e84b1d547f94c209eece58b57304517", async() => {
>>>>>>> dev_thinh3
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b459bc9b4304b4cb50beebcb71d987b", async() => {
>>>>>>> dev_test_4
                BeginContext(170, 7, true);
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
            BeginContext(181, 517, true);
            WriteLiteral(@"
    <h4 class=""modal-title"">List Cell</h4>
</div>
<div class=""modal-body form-horizontal"">
    <div class=""sparkline12-graph"">
        <div class=""static-table-list"">
            <table class=""table hover-table"">
                <thead>
                    <tr>
                        <th>FloorId</th>
                        <th>CellId</th>
                        <th>CellRFID</th>
                        <th>Status</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
<<<<<<< HEAD
#line 20 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
=======
#line 19 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
>>>>>>> dev_thinh3
                     foreach (var cell in Model)
                    {

#line default
#line hidden
            BeginContext(771, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(826, 18, false);
#line 23 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                       Write(cell.Floor.FloorId);
=======
            BeginContext(793, 18, false);
#line 22 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                           Write(cell.Floor.FloorId);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(844, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(880, 11, false);
#line 24 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                       Write(cell.CellId);
=======
            BeginContext(851, 11, false);
#line 23 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                           Write(cell.CellId);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(891, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
<<<<<<< HEAD
            BeginContext(927, 13, false);
#line 25 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                       Write(cell.CellRFID);
=======
            BeginContext(902, 13, false);
#line 24 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                           Write(cell.CellRFID);
>>>>>>> dev_thinh3

#line default
#line hidden
            EndContext();
            BeginContext(940, 31, true);
            WriteLiteral("</td>\r\n                        ");
            EndContext();
<<<<<<< HEAD
            BeginContext(972, 71, false);
#line 26 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
                   Write(await Component.InvokeAsync("StatusCell", new { cellId = cell.CellId }));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 29, true);
            WriteLiteral("\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
=======
#line 26 "C:\Users\KIROV\Documents\RFIM_WEB\RFIM_Web\Views\Shelf\ShowCell.cshtml"
>>>>>>> dev_thinh3
                    }

#line default
#line hidden
            BeginContext(1095, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RFIM_Web.Models.Cell>> Html { get; private set; }
    }
}
#pragma warning restore 1591
