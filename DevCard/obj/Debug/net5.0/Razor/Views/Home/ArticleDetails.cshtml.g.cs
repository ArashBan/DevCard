#pragma checksum "C:\Users\Arash\source\repos\DevCard\DevCard\Views\Home\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a2344f57815ea9959a32bbc40a39fb09acb707e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ArticleDetails), @"mvc.1.0.view", @"/Views/Home/ArticleDetails.cshtml")]
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
#line 1 "C:\Users\Arash\source\repos\DevCard\DevCard\Views\_ViewImports.cshtml"
using DevCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arash\source\repos\DevCard\DevCard\Views\_ViewImports.cshtml"
using DevCard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a2344f57815ea9959a32bbc40a39fb09acb707e", @"/Views/Home/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b75dc465b0faba9ae06d8c6ded052dbd26de23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ArticleDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("600px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Arash\source\repos\DevCard\DevCard\Views\Home\ArticleDetails.cshtml"
  
    ViewData["Title"] = "جزئیات مقاله";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Seo", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"Contact, Contact Us, Contact Me, Contact Page\"/>\r\n    <meta name=\"description\" content=\"Contacting me for working\"/>\r\n");
            }
            );
            WriteLiteral("\r\n<section class=\"cta-section theme-bg-light py-5\">\r\n    <div class=\"container text-center single-col-max-width\">\r\n        <h2 class=\"heading\">آخرین مقالات</h2>\r\n        <div class=\"intro\">\r\n            <p>مقاله ");
#nullable restore
#line 17 "C:\Users\Arash\source\repos\DevCard\DevCard\Views\Home\ArticleDetails.cshtml"
                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ..!</p>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n<section class=\"contact-section px-3 py-5 p-md-5\">\r\n    <div class=\"container\">\r\n\r\n        <p style=\"text-align:center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a2344f57815ea9959a32bbc40a39fb09acb707e4641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 647, "~/assets/images/blog/", 647, 21, true);
#nullable restore
#line 25 "C:\Users\Arash\source\repos\DevCard\DevCard\Views\Home\ArticleDetails.cshtml"
AddHtmlAttributeValue("", 668, Model.Image, 668, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        <p style=\"text-align:center\">");
#nullable restore
#line 26 "C:\Users\Arash\source\repos\DevCard\DevCard\Views\Home\ArticleDetails.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591