#pragma checksum "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\Components\QuantityBoxInPackage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f419d91b3c81993d8a33c07b2c5e3916152f2b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_QuantityBoxInPackage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/QuantityBoxInPackage/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/QuantityBoxInPackage/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_QuantityBoxInPackage_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f419d91b3c81993d8a33c07b2c5e3916152f2b49", @"/Views/Shared/Components/QuantityBoxInPackage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a69760db975471d19d631bed21f74b4dabb7b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_QuantityBoxInPackage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.QuantityBox>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 6, true);
            WriteLiteral("\r\n<th>");
            EndContext();
            BeginContext(46, 14, false);
#line 3 "E:\Source\RFIM_WEB\RFIM_Web\Views\Shared\Components\QuantityBoxInPackage\Default.cshtml"
Write(Model.BoxCount);

#line default
#line hidden
            EndContext();
            BeginContext(60, 9, true);
            WriteLiteral("</th>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.QuantityBox> Html { get; private set; }
    }
}
#pragma warning restore 1591
