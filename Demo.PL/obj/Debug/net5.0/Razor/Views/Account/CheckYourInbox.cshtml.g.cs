#pragma checksum "F:\Aml_webDevelopment\BackEnd\MVC\MvcProject\Demo.PL\Views\Account\CheckYourInbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92cf31602c3f9dfaf64677ded08ec680ac592a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CheckYourInbox), @"mvc.1.0.view", @"/Views/Account/CheckYourInbox.cshtml")]
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
#line 1 "F:\Aml_webDevelopment\BackEnd\MVC\MvcProject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Aml_webDevelopment\BackEnd\MVC\MvcProject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Aml_webDevelopment\BackEnd\MVC\MvcProject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Aml_webDevelopment\BackEnd\MVC\MvcProject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92cf31602c3f9dfaf64677ded08ec680ac592a0d", @"/Views/Account/CheckYourInbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c5f6b15cea04d9aa9e33a9185788aec2cb51e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_CheckYourInbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Aml_webDevelopment\BackEnd\MVC\MvcProject\Demo.PL\Views\Account\CheckYourInbox.cshtml"
  
    ViewData["Title"] = "CheckYourInbox";
    Layout = "~/Views/Shared/_AccountLayout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <p>Password has sent check your inbox</p>\r\n    <a href=\"https://mail.google.com/mail/u/0/?ogbl#inbox\" target=\"_blank\">Go To Inbox</a>\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
