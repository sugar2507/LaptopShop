
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Create), @"mvc.1.0.view", @"/Views/Category/Create.cshtml")]
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

using Management;

#line default
#line hidden
#nullable disable
#nullable restore
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62601cb5b398e17e03b7383d46e884bf9a8a5b51", @"/Views/Category/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Categories.CreateCategoryInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Category\Create.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore

      Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore

      Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore

      Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>   \r\n        <input type=\"submit\" value=\"create\" />\r\n        <span class=\"btn btn-link\">");
#nullable restore

                              Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Categories.CreateCategoryInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
