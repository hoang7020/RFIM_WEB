#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48265613c94400850b3e305020fa30f3084d85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PackageView), @"mvc.1.0.view", @"/Views/Shared/PackageView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PackageView.cshtml", typeof(AspNetCore.Views_Shared_PackageView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48265613c94400850b3e305020fa30f3084d85b", @"/Views/Shared/PackageView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PackageView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Package>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(64, 238, true);
            WriteLiteral("<tr>\r\n    <th width=\"350\">\r\n        <div class=\"admin-pro-accordion-wrap responsive-mg-b-30\">\r\n            <div class=\"panel-group adminpro-custon-design\" id=\"accordion\">\r\n                <a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 302, "\"", 327, 2);
            WriteAttributeValue("", 309, "#", 309, 1, true);
#line 9 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
WriteAttributeValue("", 310, item.PackageRFID, 310, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(328, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(352, 16, false);
#line 10 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
               Write(item.PackageRFID);

#line default
#line hidden
            EndContext();
            BeginContext(368, 60, true);
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 428, "\"", 450, 1);
#line 13 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
WriteAttributeValue("", 433, item.PackageRFID, 433, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(451, 90, true);
            WriteLiteral(" class=\"panel-collapse panel-ic collapse in\">\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(542, 84, false);
#line 15 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
               Write(await Component.InvokeAsync("BoxDetailList", new { packageRFID = item.PackageRFID }));

#line default
#line hidden
            EndContext();
            BeginContext(626, 81, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </th>\r\n    <th>");
            EndContext();
            BeginContext(708, 11, false);
#line 20 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
   Write(item.CellId);

#line default
#line hidden
            EndContext();
            BeginContext(719, 15, true);
            WriteLiteral("</th>\r\n    <th>");
            EndContext();
            BeginContext(735, 9, false);
#line 21 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
   Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(744, 11, true);
            WriteLiteral("</th>\r\n    ");
            EndContext();
            BeginContext(756, 91, false);
#line 22 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
Write(await Component.InvokeAsync("QuantityBoxInPackage", new { packageRFID = item.PackageRFID }));

#line default
#line hidden
            EndContext();
            BeginContext(847, 9, true);
            WriteLiteral("\r\n</tr>\r\n");
            EndContext();
#line 24 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
}

#line default
#line hidden
            BeginContext(859, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Package>> Html { get; private set; }
    }
}
#pragma warning restore 1591