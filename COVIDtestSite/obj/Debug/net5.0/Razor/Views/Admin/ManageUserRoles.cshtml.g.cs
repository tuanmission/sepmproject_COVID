#pragma checksum "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ea609bf422b360f594990c35f42f8a10eb9b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageUserRoles), @"mvc.1.0.view", @"/Views/Admin/ManageUserRoles.cshtml")]
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
#line 1 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\_ViewImports.cshtml"
using COVIDtestSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\_ViewImports.cshtml"
using COVIDtestSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ea609bf422b360f594990c35f42f8a10eb9b9a", @"/Views/Admin/ManageUserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf17ed8497d753c7a4604f84c8ac4a2ebff4f042", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageUserRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COVIDtestSite.ViewModels.ManageUserRoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
  
    ViewData["Title"] = "ManageUserRoles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Current Admin Users</h1>

<br />


<div class=""table-responsive"">
    <table class=""table-hover table table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">UserName</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Phone Number</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
             foreach(IdentityUser usr in Model.currentUsers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
               Write(usr.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
               Write(usr.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
               Write(usr.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
               Write(Html.ActionLink("Remove From Admin", "RemoveUserfromAdmin", "Admin", new { userId=usr.Id }, new { @class="btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\Admin\ManageUserRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COVIDtestSite.ViewModels.ManageUserRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
