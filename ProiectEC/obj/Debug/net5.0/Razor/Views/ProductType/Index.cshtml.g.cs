#pragma checksum "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ecb90caff472262575f5fa6e8c948b54d71bb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductType_Index), @"mvc.1.0.view", @"/Views/ProductType/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ecb90caff472262575f5fa6e8c948b54d71bb6", @"/Views/ProductType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7280d03bcd0220e7896360f2eadbc68c1dfb8d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductTypeVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml"
  
    ViewData["Title"] = "Product Type";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-2 mt-2 operationsButtons"">
    <div class=""col-md-12"">
        <a href=""/ProductType/New"" class=""btn btn-new btn-outline-new font-weight-bold mr-2"" data-toggle=""tooltip"" title=""New"" data-placement=""top"">
            <span class=""fa fa-plus-circle""></span>
        </a>

        <button class=""btn btn-outline-dark font-weight-bold mr-2"" data-toggle=""tooltip"" title=""Edit"" data-placement=""top"" onclick=""ProductType.onEditBtnPress()"">
            <span class=""fa fa-edit""></span>
        </button>

        <button type=""button"" class=""btn btn-delete btn-outline-delete font-weight-bold mr-2"" id=""btnDelete"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""ProductType.onDelete()"">
            <span class=""fa fa-trash""></span>
        </button>
    </div>
</div>

<table id=""table"" class=""table table-hover table-striped table-dark"">
    <thead>
        <tr>
            <th hidden>Id</th>
            <th>Tip</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 33 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1170, "\"", 1183, 1);
#nullable restore
#line 35 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml"
WriteAttributeValue("", 1175, item.Id, 1175, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td hidden>");
#nullable restore
#line 36 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml"
                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\neacs\source\repos\Afaceri electronice\Backup\ProiectEC\Views\ProductType\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductTypeVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
