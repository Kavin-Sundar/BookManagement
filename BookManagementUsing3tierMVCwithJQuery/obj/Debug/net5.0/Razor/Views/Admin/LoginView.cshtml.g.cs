#pragma checksum "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bce913cf7a24a6e75511c9d411b138c4210eab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LoginView), @"mvc.1.0.view", @"/Views/Admin/LoginView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bce913cf7a24a6e75511c9d411b138c4210eab7", @"/Views/Admin/LoginView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484792d50bf88d9332ce3f3ffbcfa07920db3a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_LoginView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookManagementUsing3tierMVCwithJQuery.Core.Model.AdminLoginModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Login.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
  
    ViewBag.Title = "LoginView";
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bce913cf7a24a6e75511c9d411b138c4210eab75225", async() => {
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
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfF");
                WriteLiteral(@"Wpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/jquery-validation@1.17.0/dist/jquery.validate.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.inputmask/3.3.4/jquery.inputmask.bundle.min.js""></script>
    <script src=""https://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js""></script>
  

    <style>
        #AdminId-error, #Password-error, #successMessage {
            color: red;
        }

        #k1 {
            margin-top: 170px;
            margin-left: -100px;
        }

        #k2 {
            margin-top: 150px;
            color: grey;
        }

        input.form-control {
            width: 70%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius:");
                WriteLiteral(@" 30px;
            resize: vertical;
            margin-bottom: 10px;
        }

        #k4 {
            margin-top: 5px;
            color: white;
            text-align: center;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            padding: 12px 155px;
            border-radius: 30px;
        }

        .form-check {
            margin-left: -10px;
        }

        #k5 {
            margin-top: 10px;
        }

        #k6 {
            color: black;
            text-decoration-line: underline;
            text-decoration-style: solid;
            text-decoration-color: #2E67F8;
            text-decoration-thickness: 5px;
            margin-bottom: 30px;
            text-underline-offset: 3px;
        }

        #k7 {
            color: #0000ff;
            text-decoration-line: underline;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bce913cf7a24a6e75511c9d411b138c4210eab79310", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <div class=\"container\" id=\"k1\" style=\"background-color: #fff;\">\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bce913cf7a24a6e75511c9d411b138c4210eab79786", async() => {
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
                    <!-- <div style=""text-align: center;"">
                          <a href=""https://www.w3schools.com"" class=""two"" style=""text-align: center;"" >Visit W3Schools.com!</a>
                        </div> -->

                </div>

            </div>
            <div class=""col-6"">
                <div class=""container"" id=""k2"">
                    <div id=""k6"">
                        <h3>LOGIN</h3>
                    </div>
");
#nullable restore
#line 116 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
                     using (Html.BeginForm("Login", "Admin", FormMethod.Post, new { @id = "form1" }))
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
                         if (ViewBag.message !=null)                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"alert alert-success\">");
#nullable restore
#line 122 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
                                                      Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 123 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bce913cf7a24a6e75511c9d411b138c4210eab713016", async() => {
                    WriteLiteral("Admin Id");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 127 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AdminId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                            ");
#nullable restore
#line 130 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
                       Write(Html.TextBoxFor(model => model.AdminId, htmlAttributes: new { @class = "form-control", name = "AdminId", @id = "AdminId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"form-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bce913cf7a24a6e75511c9d411b138c4210eab715231", async() => {
                    WriteLiteral("Password ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 135 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            ");
#nullable restore
#line 137 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
                       Write(Html.PasswordFor(model => model.Password, htmlAttributes: new { @class = "form-control", name = "Password", @id = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                           
                        </div>
                        <div class=""form-check"">
                            <label class=""checkbox"">
                                <input type=""checkbox"" value=""remember-me"" id=""remember_me""> Remember me
                            </label>
                        </div>
                        <br>
");
                WriteLiteral(@"                        <input type=""submit"" id=""k4"" value=""Submit"" class=""btn btn-primary"" aria-pressed=""false""
                               autocomplete=""off"" />
                        <br>
                        <div id=""k5"">
                            <p>
                                Don't have an account? <a id=""k7"" onclick=""Sign()"" class=""two"">
                                    SignUp
                                </a>
                            </p>

                        </div>
");
#nullable restore
#line 159 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>

            </div>
        </div>

    </div>
  
    <script>

         jQuery.validator.addMethod(""noSpace"", function (value, element) {
            return value == '' || value.trim().length != 0;
        }, ""No space please and don't leave it empty"");

        var $AdminLogin = $('#form1');


        if ($AdminLogin.length) {
            $AdminLogin.validate({


                rules: {
                    AdminId: {
                        required: true,
                        noSpace: true
                    },
                    Password: {
                        required: true
                    }

                },
                messages:
                {
                    AdminId: {

                        required: 'Please enter AdminId!'
                    },
                    Password: {

                        required: 'Please enter password!'

                    }

                }
            });
        }
                WriteLiteral("\n\r\n\r\n           function Sign() {\r\n            window.location.href = \"");
#nullable restore
#line 210 "C:\Users\STS586-KAVIN AS\source\repos\BookManagementUsing3tierMVCwithJQuery\BookManagementUsing3tierMVCwithJQuery\Views\Admin\LoginView.cshtml"
                               Write(Url.Action("SignUp", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?Id="" ;
        }


        $(function () {

            debugger;

            var person = {};
             person.AdminId = $(""#AdminId"").val();
             person.Password = $(""#Password"").val();

            if (localStorage.chkbx && localStorage.chkbx != '') {
                $('#remember_me').attr('checked', 'checked');
              
                $('#AdminId').val(localStorage.usrname);
                $('#Password').val(localStorage.pass);

            } else {
                $('#remember_me').removeAttr('checked');
                $('#AdminId').val('');
                $('#Password').val('');
            }


            $('#remember_me').click(function () {

                if ($('#remember_me').is(':checked')) {
                    // save username and password
                    localStorage.usrname = $('#AdminId').val();
                    localStorage.pass = $('#Password').val();
                    localStorage.chkbx = $('#remember_me').val();
            ");
                WriteLiteral(@"    } else {
                    localStorage.usrname = '';
                    localStorage.pass = '';
                    localStorage.chkbx = '';
                }
            });
        });







//$(""#btn-Get"").click(function () {


//    debugger;

//    //var $AdminLogin1 = $('#Pass');
//    //var tr = { Password: $AdminLogin1 };
//    var person = {};
//    person.AdminId = $(""#AdminId"").val();
//    person.Password = $(""#Password"").val();
//    var AdminId = $(""#AdminId"").val();
//    var Passcode = $(""#Password"").val();
//    $.ajax({

//        type: ""POST"",
//        url: ""/Admin/Login"",
//        data: { AdminId: AdminId, Password: Passcode},
//       // data: JSON.stringify(person),
//       // data: $(""#form1"").serialize(),
//        contentType: ""application/json; charset=utf-8"",

//       // content = JsonConvert.SerializeObject(person),
//        dataType: ""json"",

//        success: function (response) {
//            debugger;


//            Win");
                WriteLiteral("dow.location.href = \"/Admin/Index\";\r\n\r\n\r\n//        }\r\n//        ,\r\n//        error: function (response) {\r\n\r\n\r\n//        }\r\n\r\n//    });\r\n//});\r\n\r\n    </script>\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n<\r\n\r\n       ");
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