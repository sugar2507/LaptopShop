#pragma checksum "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "515a4c0ac928846da284b0034ccd53a4c5b52b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Detail), @"mvc.1.0.view", @"/Views/Category/Detail.cshtml")]
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
#line 1 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515a4c0ac928846da284b0034ccd53a4c5b52b6a", @"/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Categories.DetailCategoryDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
  
    if(Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl>\r\n        <dt>\r\n            ");
#nullable restore
#line 7 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
       Write(Html.DisplayNameFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 10 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
       Write(Html.DisplayFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 13 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 16 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
       Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <span class=\"btn btn-link\">");
#nullable restore
#line 18 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
                              Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n    </dl>\r\n");
#nullable restore
#line 20 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No data</p>\r\n");
#nullable restore
#line 25 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Categories.DetailCategoryDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591