#pragma checksum "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\User\login_register.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "531eae78e79aa371514bb4a985b7eeeb279497a711f2c7d1bd8aef21ab657f2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_login_register), @"mvc.1.0.view", @"/Views/User/login_register.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\_ViewImports.cshtml"
using UOMO

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\_ViewImports.cshtml"
using UOMO.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"531eae78e79aa371514bb4a985b7eeeb279497a711f2c7d1bd8aef21ab657f2b", @"/Views/User/login_register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ee863b9f5af7bce24381cfd4950e85cf0e6b0c9ff7fb4657dc3555894d4b147d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_login_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/login_register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <div class=""mb-4 pb-4""></div>
    <section class=""login-register container"">
        <h2 class=""d-none"">Login & Register</h2>
        <ul class=""nav nav-tabs mb-5"" id=""login_register"" role=""tablist"">
            <li class=""nav-item"" role=""presentation"">
                <a class=""nav-link nav-link_underscore active"" id=""login-tab"" data-bs-toggle=""tab"" href=""#tab-item-login"" role=""tab"" aria-controls=""tab-item-login"" aria-selected=""true"">Login</a>
            </li>

        </ul>
        <div class=""tab-content pt-2"" id=""login_register_tab_content"">
            <div class=""tab-pane fade show active"" id=""tab-item-login"" role=""tabpanel"" aria-labelledby=""login-tab"">
                <div class=""login-form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "531eae78e79aa371514bb4a985b7eeeb279497a711f2c7d1bd8aef21ab657f2b5520", async() => {
                WriteLiteral(@"
                        <div class=""form-floating mb-3"">
                            <input name=""UserNickName"" type=""text"" class=""form-control form-control_gray"" id=""customerNameEmailInput1"" placeholder=""Nick Name *"" required>
                            <label for=""customerNameEmailInput1"">Nick Name *</label>
                        </div>

                        <div class=""pb-3""></div>

                        <div class=""form-floating mb-3"">
                            <input name=""UserPassword"" type=""password"" class=""form-control form-control_gray"" id=""customerPasswodInput"" placeholder=""Password *"" required>
                            <label for=""customerPasswodInput"">Password *</label>
                        </div>

                        <div class=""d-flex align-items-center mb-3 pb-2"">
                            <div class=""form-check mb-0"">
                                <input name=""remember"" class=""form-check-input form-check-input_fill"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1841, "\"", 1849, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""flexCheckDefault1"">
                                <label class=""form-check-label text-secondary"" for=""flexCheckDefault1"">Remember me</label>
                            </div>
                            <a href=""/User/reset_password"" class=""btn-text ms-auto"">Lost password?</a>
                        </div>

                        <button class=""btn btn-primary w-100 text-uppercase"" type=""submit"">Log In</button>

                        <div class=""customer-option mt-4 text-center"">
                            <span class=""text-secondary"">No account yet?</span>
                            <a href=""/User/Choose"" class=""btn-text js-show-register"">Create Account</a>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"tab-pane fade\" id=\"tab-item-register\" role=\"tabpanel\" aria-labelledby=\"register-tab\">\r\n                <div class=\"register-form\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "531eae78e79aa371514bb4a985b7eeeb279497a711f2c7d1bd8aef21ab657f2b9651", async() => {
                WriteLiteral(@"
                        <div class=""form-floating mb-3"">
                            <input name=""register_username"" type=""text"" class=""form-control form-control_gray"" id=""customerNameRegisterInput"" placeholder=""Username"" required>
                            <label for=""customerNameRegisterInput"">Username</label>
                        </div>

                        <div class=""pb-3""></div>

                        <div class=""form-floating mb-3"">
                            <input name=""register_email"" type=""email"" class=""form-control form-control_gray"" id=""customerEmailRegisterInput"" placeholder=""Email address *"" required>
                            <label for=""customerEmailRegisterInput"">Email address *</label>
                        </div>

                        <div class=""pb-3""></div>

                        <div class=""form-floating mb-3"">
                            <input name=""register_password"" type=""password"" class=""form-control form-control_gray"" id=""customerPasswodRegist");
                WriteLiteral(@"erInput"" placeholder=""Password *"" required>
                            <label for=""customerPasswodRegisterInput"">Password *</label>
                        </div>

                        <div class=""d-flex align-items-center mb-3 pb-2"">
                            <p class=""m-0"">Your personal data will be used to support your experience throughout this website, to manage access to your account, and for other purposes described in our privacy policy.</p>
                        </div>

                        <button class=""btn btn-primary w-100 text-uppercase"" type=""submit"">Register</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n<div class=\"mb-5 pb-xl-5\"></div>");
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