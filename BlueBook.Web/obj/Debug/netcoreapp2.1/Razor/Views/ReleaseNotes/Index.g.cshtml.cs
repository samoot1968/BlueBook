#pragma checksum "C:\Users\Toomas Unt\source\repos\BlueBook\BlueBook.Web\Views\ReleaseNotes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9037edf726e45af6adce36b2a341567a33e16176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReleaseNotes_Index), @"mvc.1.0.view", @"/Views/ReleaseNotes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReleaseNotes/Index.cshtml", typeof(AspNetCore.Views_ReleaseNotes_Index))]
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
#line 1 "C:\Users\Toomas Unt\source\repos\BlueBook\BlueBook.Web\Views\_ViewImports.cshtml"
using BlueBook.Web;

#line default
#line hidden
#line 2 "C:\Users\Toomas Unt\source\repos\BlueBook\BlueBook.Web\Views\_ViewImports.cshtml"
using BlueBook.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9037edf726e45af6adce36b2a341567a33e16176", @"/Views/ReleaseNotes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e197071f7d88d0c3bd3fe28a65e7d00aed79f5b", @"/Views/_ViewImports.cshtml")]
    public class Views_ReleaseNotes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlueBook.Web.Models.ReleaseNotes.ListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Toomas Unt\source\repos\BlueBook\BlueBook.Web\Views\ReleaseNotes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 22, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Toomas Unt\source\repos\BlueBook\BlueBook.Web\Views\ReleaseNotes\Index.cshtml"
 foreach (var item in Model.ReleaseNotes)
{

#line default
#line hidden
            BeginContext(213, 42, true);
            WriteLiteral("    <p>item.id</p>\r\n    <p>item.Name</p>\r\n");
            EndContext();
#line 15 "C:\Users\Toomas Unt\source\repos\BlueBook\BlueBook.Web\Views\ReleaseNotes\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlueBook.Web.Models.ReleaseNotes.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
