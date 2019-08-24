#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "639f2383bb35f1ea5eb7fb45fb8f190db0edc9f2"
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
#line 1 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web;

#line default
#line hidden
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\_ViewImports.cshtml"
using RFIM_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639f2383bb35f1ea5eb7fb45fb8f190db0edc9f2", @"/Views/Shared/PackageView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PackageView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Package>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
  
    var ctx = new MyDbContext();
    int quantityBox(string id)
    {
        return ctx.Boxes.Count(p => p.PackageRFID == id);
    }
    int quantityMissingBox(string id)
    {
        return ctx.Boxes.Count(p => p.PackageRFID == id && p.Status == false);
    }

#line default
#line hidden
            BeginContext(308, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
 foreach (var item in Model)
{
    if ((quantityBox(item.PackageRFID) - quantityMissingBox(item.PackageRFID)) > 0)
    {

#line default
#line hidden
            BeginContext(435, 278, true);
            WriteLiteral(@"        <tr>
            <th width=""350"">
                <div class=""admin-pro-accordion-wrap responsive-mg-b-30"">
                    <div class=""panel-group adminpro-custon-design"" id=""accordion"">
                        <a data-toggle=""collapse"" data-parent=""#accordion""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 713, "\"", 738, 2);
            WriteAttributeValue("", 720, "#", 720, 1, true);
#line 22 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
WriteAttributeValue("", 721, item.PackageRFID, 721, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(739, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(771, 16, false);
#line 23 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
                       Write(item.PackageRFID);

#line default
#line hidden
            EndContext();
            BeginContext(787, 84, true);
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 871, "\"", 893, 1);
#line 26 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
WriteAttributeValue("", 876, item.PackageRFID, 876, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(894, 106, true);
            WriteLiteral(" class=\"panel-collapse panel-ic collapse in\">\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(1001, 84, false);
#line 28 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
                       Write(await Component.InvokeAsync("BoxDetailList", new { packageRFID = item.PackageRFID }));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 121, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </th>\r\n            <th>");
            EndContext();
            BeginContext(1207, 11, false);
#line 33 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
           Write(item.CellId);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1242, 9, false);
#line 34 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 19, true);
            WriteLiteral("</th>\r\n            ");
            EndContext();
            BeginContext(1271, 91, false);
#line 35 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
       Write(await Component.InvokeAsync("QuantityBoxInPackage", new { packageRFID = item.PackageRFID }));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 17, true);
            WriteLiteral("\r\n        </tr>\r\n");
            EndContext();
#line 37 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\PackageView.cshtml"
    } else
    {

    }
}

#line default
#line hidden
            BeginContext(1410, 2, true);
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
