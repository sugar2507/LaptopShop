#pragma checksum "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9fb91cf7f87a3700e1d8de774dfe26deaec81a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9fb91cf7f87a3700e1d8de774dfe26deaec81a", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Management.ViewModel.Staff.StaffDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-6 text-danger text-uppercase"">
                    <strong>List product </strong>
                </div>
                <div class=""col-6 text-right"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 361, "\"", 401, 1);
#nullable restore
#line 10 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
WriteAttributeValue("", 368, Url.ActionLink("Create","Staff"), 368, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-success\">Create product</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
    if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-block p-3\">\r\n            <table class=\"table table-bordered table-hover table-striped\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n               \r\n                    \r\n\r\n                </tr>\r\n");
#nullable restore
#line 36 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 40 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 43 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                                             \r\n                        <td>                            \r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1997, "\"", 2058, 1);
#nullable restore
#line 53 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
WriteAttributeValue("", 2004, Url.ActionLink("Delete","Staff",new { id = item.Id }), 2004, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">Delete</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2132, "\"", 2193, 1);
#nullable restore
#line 54 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
WriteAttributeValue("", 2139, Url.ActionLink("Detail","Staff",new { id = item.Id }), 2139, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-info\">Detail</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 60 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No data</p>\r\n");
#nullable restore
#line 64 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Staff\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Management.ViewModel.Staff.StaffDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
