#pragma checksum "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd44b8c6d031f2b5aa3f1c2841ac4a67435f5c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
#nullable restore
#line 1 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\_ViewImports.cshtml"
using ProiectEC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\_ViewImports.cshtml"
using ProiectEC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\_ViewImports.cshtml"
using ProiectMaster.Models.DTO.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd44b8c6d031f2b5aa3f1c2841ac4a67435f5c1e", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7280d03bcd0220e7896360f2eadbc68c1dfb8d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\Product\Edit.cshtml"
  
    ViewData["Title"] = "Editeaza produs";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\Product\Edit.cshtml"
  
    ViewBag.IsNew = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\Product\Edit.cshtml"
Write(await Html.PartialAsync(@"../Shared/Components/_Product.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("; ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
