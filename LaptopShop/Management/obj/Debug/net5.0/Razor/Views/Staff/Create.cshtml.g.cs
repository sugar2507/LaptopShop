#pragma checksum "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78589c57c6a4b385b19574bdb1c7aac419ebf2ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Create), @"mvc.1.0.view", @"/Views/Staff/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78589c57c6a4b385b19574bdb1c7aac419ebf2ae", @"/Views/Staff/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Staff.CreateStaffInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
     using (Html.BeginForm("Create", "Staff", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 9 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 10 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group \">\r\n                ");
#nullable restore
#line 14 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.EditorFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>          \r\n\r\n            <div class=\"form-group \">\r\n                ");
#nullable restore
#line 25 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.LabelFor(m => m.RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.DropDownList("RoleId", (IEnumerable<SelectListItem>)ViewBag.Roles, "Phan quyen", new { @class = "form -control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.RoleId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <input type=\"submit\" value=\"Create\" />\r\n                <span class=\"btn btn-link\">");
#nullable restore
#line 31 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"
                                      Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Create.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Staff.CreateStaffInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
