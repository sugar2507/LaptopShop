#pragma checksum "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Role\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4743e7a14cfca991c13e8aacb8ffbf09d2137bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Create), @"mvc.1.0.view", @"/Views/Role/Create.cshtml")]
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
#line 1 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4743e7a14cfca991c13e8aacb8ffbf09d2137bce", @"/Views/Role/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Role.CreateRoleInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Role\Create.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Create</p>\r\n            <p>");
#nullable restore
#line 6 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Role\Create.cshtml"
          Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 7 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Role\Create.cshtml"
          Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <input type=\"submit\" value=\"create\"/>\r\n");
#nullable restore
#line 9 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Role\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Role.CreateRoleInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
