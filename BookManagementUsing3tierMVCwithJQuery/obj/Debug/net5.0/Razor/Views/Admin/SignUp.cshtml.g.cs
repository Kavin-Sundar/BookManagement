#pragma checksum "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca4c97107d84f6128ec8ee7a927e516360bbe27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SignUp), @"mvc.1.0.view", @"/Views/Admin/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca4c97107d84f6128ec8ee7a927e516360bbe27", @"/Views/Admin/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484792d50bf88d9332ce3f3ffbcfa07920db3a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookManagementUsing3tierMVCwithJQuery.Core.Model.AdminLoginModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SignUp.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Flowers in Chania"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
  
    ViewBag.Title = "SignUp";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca4c97107d84f6128ec8ee7a927e516360bbe275081", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <title>Document</title>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxS");
                WriteLiteral(@"fFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""path/to/font-awesome/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css""
          integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""anonymous"" />
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/duotone.css""
          integrity=""sha384-R3QzTxyukP03CMqKFe0ssp5wUvBPEyy9ZspCB+Y01fEjhMwcXixTyeot+S40+AjZ"" crossorigin=""anonymous"" />
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/fontawesome.css""
          integrity=""sha384-eHoocPgXsiuZh+Yy6+7DsKAerLXyJmu2Hadh4QYyt+8v86geixVYwFqUvMU8X90l"" crossorigin=""anonymous"" />
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jquery-validation@1.17.0/dist/jquery.validate.js""></script>
    <scrip");
                WriteLiteral(@"t src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.inputmask/3.3.4/jquery.inputmask.bundle.min.js""></script>
    <script src=""https://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js""></script>
    <style>
        a.two:link {
            color: #ff0000;
        }

        a.two:visited {
            color: #30A3F1;
        }

        #password-error, #AdminId-error, #RetypePassword-error {
            position: absolute;
            
          
        }

        .error {
            color: red;
            font-style: normal;
            white-space: pre-line;
        }

        #k1{
            margin-top:150px;
            margin-left:-100px;
        }
        #k2 {
            margin-left: 180px;
            margin-top: 140px;
            color: grey;
        }

        #k8 {
            width: 50%;
            padding: 12px;
            border: 1px solid #ccc;
         ");
                WriteLiteral(@"   border-radius: 30px;
            resize: vertical;
        }

        input.form-control {
            width: 50%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 30px;
            resize: vertical;
            padding-left: 60px;
            box-shadow: 5px 5px 5px grey;
            margin-top:35px;
            margin-bottom:5px;
        }

        #k4 {
            margin-top: 5px;
            margin-left: 565px;
            background-color: #30A3F1;
            color: white;
            text-align: center;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            padding: 12px 100px;
            border-radius: 30px;
        }

        #k9 {
            margin-top: 30px;
            margin-left: 90px;
        }

        .form-check {
            margin-left: 10px;
        }

        #k5 {
            margin-left: 80px;
        }

        #k6 {
");
                WriteLiteral(@"            color: black;
            text-align: center;
            margin-left: -420px;
            margin-bottom: 30px;
        }

        #k7 {
            color: #0000ff;
            text-decoration-line: underline;
        }

        .Icon-inside {
            position: relative;
        }

            .Icon-inside i {
                position: absolute;
                left: 0;
                top: 1px;
                padding: 15px 15px;
                color: #30A3F1;
            }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca4c97107d84f6128ec8ee7a927e516360bbe2710897", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-7\">\r\n            <div class=\"container\" id=\"k2\">\r\n");
#nullable restore
#line 153 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                 using (Html.BeginForm("SignUp", "Admin", FormMethod.Post, new { @id = "form4", autocomplete = "off" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div id=\"k6\">\r\n                        <h2 style=\"font-family: Lucida Console\" , Courier New, monospace>Sign Up</h2>\r\n                    </div>\r\n");
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <div class=\"Icon-inside\">\r\n                            ");
#nullable restore
#line 168 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                       Write(Html.TextBoxFor(model => model.AdminId, htmlAttributes: new { @class = "form-control", name = "AdminId", id = "AdminId" , placeholder = "AdminId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            <i class=\"fa fa-user fa-lg fa-fw\" aria-hidden=\"true\"></i>\r\n                        </div>\r\n                        ");
#nullable restore
#line 172 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                   Write(Html.ValidationMessageFor(model => model.AdminId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"Icon-inside\">\r\n                            ");
#nullable restore
#line 176 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                       Write(Html.PasswordFor(model => model.Password, htmlAttributes: new { @class = "form-control", name = "Password", id = "password" ,placeholder="Password"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            <i class=\"fas fa-lock\" aria-hidden=\"true\"></i>\r\n                        </div>\r\n                        ");
#nullable restore
#line 180 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"Icon-inside\">\r\n                            ");
#nullable restore
#line 184 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                       Write(Html.PasswordFor(model => model.RetypePassword, htmlAttributes: new { @class = "form-control", name = "RetypePassword", id = "RetypePassword", placeholder = "Re-type Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            <i class=\"fas fa-check\" aria-hidden=\"true\"></i>\r\n                        </div>\r\n                        ");
#nullable restore
#line 188 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RetypePassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
                WriteLiteral("                    <div id=\"k9\">\r\n                       \r\n                        <input type=\"submit\" value=\"Sign In\"  aria-pressed=\"false\" class=\"btn btn-primary\" id=\"k4\" />\r\n                    </div>\r\n");
                WriteLiteral(@"                    <br>
                    <div id=""k5"">
                        <p>
                            Already have an account? <a onclick=""Login()"" id=""k7"" class=""two""
                                                        style=""text-align: center;"">
                                LogIn
                            </a>
                        </p>

                    </div>
");
#nullable restore
#line 208 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n        <div class=\"col-5\">\r\n            <div class=\"container\" id=\"k1\" style=\"background-color: #fff;\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ca4c97107d84f6128ec8ee7a927e516360bbe2717042", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                

            </div>

        </div>
    </div>

    <script>

        jQuery.validator.addMethod(""noSpace"", function (value, element) {
            return value == '' || value.trim().length != 0;
        }, ""No space please and don't leave it empty"");


        $.validator.addMethod('strongPassword', function (value, element) {
            return this.optional(element)
                || value.length >= 6
                && /\d/.test(value)
                && /[a-z]/i.test(value);
        }, 'Your password must be at least 6 characters long and contain at least one number and one char\'.');

        var $AdminSignUp = $('#form4');


        if ($AdminSignUp.length) {
            $AdminSignUp.validate({


                rules: {
                    AdminId: {
                        required: true,
                        noSpace: true
                    },
                    Password: {
                        required: true
                    },
    ");
                WriteLiteral(@"                RetypePassword: {
                        required: true,
                        equalTo: '#password'
                    }

                },
                messages:
                {
                    AdminId: {

                        required: 'Please enter AdminId!'
                    },
                    Password: {

                        required: 'Please enter password!'

                    },
                    RetypePassword: {
                        required: 'Please enter retypepassword!'
                    }

                }
            });
        }

          function Login() {
            window.location.href = """);
#nullable restore
#line 278 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\SignUp.cshtml"
                               Write(Url.Action("LoginView", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?Id=\" ;\r\n           }\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookManagementUsing3tierMVCwithJQuery.Core.Model.AdminLoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
