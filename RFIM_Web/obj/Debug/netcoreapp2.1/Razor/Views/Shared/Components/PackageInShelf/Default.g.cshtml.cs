#pragma checksum "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f48097ec390df0760f370ace740981525fc852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PackageInShelf_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PackageInShelf/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PackageInShelf/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PackageInShelf_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f48097ec390df0760f370ace740981525fc852", @"/Views/Shared/Components/PackageInShelf/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06c4ae16641bb2ecd4d4ada5240b635e967153e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PackageInShelf_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RFIM_Web.ModelView.ShelfStatus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
  
    ViewData["Title"] = "Default";
    int countEmptyCell = Model.CellNumber - Model.PackageCountInShelf;

#line default
#line hidden
            BeginContext(154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
 if (Model.CellNumber - Model.PackageCountInShelf == 0)
{

#line default
#line hidden
            BeginContext(216, 23, true);
            WriteLiteral("    <td>No empty</td>\r\n");
            EndContext();
#line 10 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
}
else if (Model.CellNumber - Model.PackageCountInShelf == Model.CellNumber)
{

#line default
#line hidden
            BeginContext(321, 8, true);
            WriteLiteral("    <td>");
            EndContext();
            BeginContext(330, 16, false);
#line 13 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
   Write(Model.CellNumber);

#line default
#line hidden
            EndContext();
            BeginContext(346, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 14 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(365, 8, true);
            WriteLiteral("    <td>");
            EndContext();
            BeginContext(374, 14, false);
#line 17 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
   Write(countEmptyCell);

#line default
#line hidden
            EndContext();
            BeginContext(388, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 18 "C:\Users\HieuDT\Documents\Visual Studio 2017\Projects\Capstone\RFIM_WEB\RFIM_Web\Views\Shared\Components\PackageInShelf\Default.cshtml"
}

#line default
#line hidden
            BeginContext(398, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RFIM_Web.ModelView.ShelfStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591
