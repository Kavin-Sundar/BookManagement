#pragma checksum "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64d647e793c70928dcb55d3480ebe7f470497f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\_ViewImports.cshtml"
using BookManagementUsing3tierMVCwithJQuery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\_ViewImports.cshtml"
using BookManagementUsing3tierMVCwithJQuery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64d647e793c70928dcb55d3480ebe7f470497f9", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484792d50bf88d9332ce3f3ffbcfa07920db3a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Index";
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ul class=""nav nav-tabs"">
  <li class=""active""><a data-toggle=""tab"" href=""#firstTab"">View All</a></li>
    <li ><a a data-toggle=""tab"" href=""#secondTab"">Add New</a></li>

</ul>
<div class=""tab-content"">
    <div id=""firstTab"" href=""javascript: void(0)"" class=""tab-pane fade in active""> ");
#nullable restore
#line 13 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\Index.cshtml"
                                                                              Write(Html.ActionLink("Login","Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("></div>\r\n    <div id=\"secondTab\" class=\"tab-pane fade in  \"> ");
#nullable restore
#line 14 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\Index.cshtml"
                                               Write(Html.ActionLink("SignUp", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591