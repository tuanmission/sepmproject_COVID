#pragma checksum "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1671c9775d41e5e554391f426861f3ec2d166350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestSite_CheckIn), @"mvc.1.0.view", @"/Views/TestSite/CheckIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1671c9775d41e5e554391f426861f3ec2d166350", @"/Views/TestSite/CheckIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf17ed8497d753c7a4604f84c8ac4a2ebff4f042", @"/Views/_ViewImports.cshtml")]
    public class Views_TestSite_CheckIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COVIDtestSite.ViewModels.CheckInViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
  
    ViewData["Title"] = "CheckIn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Check In Now</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
 using (Html.BeginForm("checkinsave", "TestSite", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Name</label>\r\n        ");
#nullable restore
#line 13 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
   Write(Html.TextBoxFor(m => m.name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Medicare Number</label>\r\n        ");
#nullable restore
#line 19 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
   Write(Html.TextBoxFor(m => m.medicareNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Phone Number</label>\r\n        ");
#nullable restore
#line 24 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
   Write(Html.TextBoxFor(m => m.phoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label>Address</label>\r\n        ");
#nullable restore
#line 29 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
   Write(Html.TextBoxFor(m => m.address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 31 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
Write(Html.HiddenFor(m => m.TestingSiteId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"
                                         ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-primary\" type=\"submit\">Check In</button>\r\n");
#nullable restore
#line 33 "C:\Users\tuanm\Documents\Software Engineering Project Management\COVIDtestSite\COVIDtestSite\Views\TestSite\CheckIn.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COVIDtestSite.ViewModels.CheckInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
