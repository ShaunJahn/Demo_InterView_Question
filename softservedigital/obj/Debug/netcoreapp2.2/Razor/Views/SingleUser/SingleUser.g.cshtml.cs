#pragma checksum "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa5a0413532a7813f31499d5a7c2ca0856c97ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SingleUser_SingleUser), @"mvc.1.0.view", @"/Views/SingleUser/SingleUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SingleUser/SingleUser.cshtml", typeof(AspNetCore.Views_SingleUser_SingleUser))]
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
#line 1 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\_ViewImports.cshtml"
using softservedigital.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5a0413532a7813f31499d5a7c2ca0856c97ecc", @"/Views/SingleUser/SingleUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ef07af3538a4e5aeb673bf1adc552ee5a97a04", @"/Views/_ViewImports.cshtml")]
    public class Views_SingleUser_SingleUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SingleUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 90, true);
            WriteLiteral("\r\n<div style=\"border-style:solid; width:auto; text-align:center\">\r\n    <p>\r\n        Name: ");
            EndContext();
            BeginContext(119, 26, false);
#line 5 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
         Write(Model.SingleUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(145, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(147, 24, false);
#line 5 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
                                     Write(Model.SingleUser.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(171, 22, true);
            WriteLiteral(" <br />\r\n        Age: ");
            EndContext();
            BeginContext(194, 24, false);
#line 6 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
        Write(Model.SingleUser.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(218, 22, true);
            WriteLiteral(" <br />\r\n        Born:");
            EndContext();
            BeginContext(241, 30, false);
#line 7 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
        Write(Model.SingleUser.BirthDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(271, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(273, 32, false);
#line 7 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
                                        Write(Model.SingleUser.BirthDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(305, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(307, 31, false);
#line 7 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
                                                                          Write(Model.SingleUser.BirthDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(338, 25, true);
            WriteLiteral(" <br />\r\n        Salary: ");
            EndContext();
            BeginContext(364, 23, false);
#line 8 "C:\Users\mrjsh\Desktop\softservedigital\softservedigital.co.za\softservedigital\softservedigital\Views\SingleUser\SingleUser.cshtml"
           Write(Model.SingleUser.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(387, 31, true);
            WriteLiteral(" <br />\r\n    </p>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(418, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa5a0413532a7813f31499d5a7c2ca0856c97ecc7234", async() => {
                BeginContext(485, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SingleUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
