#pragma checksum "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69407b6acb555256cc661b938b6eac1fc9d8baa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\_ViewImports.cshtml"
using Madeyra;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\_ViewImports.cshtml"
using Madeyra.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\_ViewImports.cshtml"
using Madeyra.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\_ViewImports.cshtml"
using Madeyra.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69407b6acb555256cc661b938b6eac1fc9d8baa9", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc0ea38c2fbf656db6134b9cff8708f444fbeca", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Campagain>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Kampaniyalar";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <main>\r\n        <section>\r\n            <div class=\"kampaniyalar\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12\">\r\n                                <div class=\"kampaniya\">\r\n                                    <div class=\"kampaniya-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69407b6acb555256cc661b938b6eac1fc9d8baa94683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 565, "~/uploads/campagain/", 565, 20, true);
#nullable restore
#line 16 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
AddHtmlAttributeValue("", 585, item.Image, 585, 11, false);

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
            WriteLiteral("\r\n                                        <div class=\"kampaniya-time\">\r\n                                            <span>\r\n");
#nullable restore
#line 19 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                                 if (item.StartTime.Hour < item.EndTime.Hour)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                                Write((item.EndTime.Day-item.StartTime.Day).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>gün</span> ");
#nullable restore
#line 21 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                                                                                                    Write((item.EndTime.Hour - item.StartTime.Hour));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>saat</span> \r\n");
#nullable restore
#line 22 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                                                                                    }
                                                                    else
                                                                    {
                                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                                                    Write((item.EndTime.Day-item.StartTime.Day-1).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>gün</span> ");
#nullable restore
#line 25 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                                                                                                                          Write((item.EndTime.Hour - item.StartTime.Hour)*(-1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>saat</span>\r\n");
#nullable restore
#line 26 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"

                                                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"kampaniya-name\">\r\n                                        <p>");
#nullable restore
#line 32 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 36 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Company\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Campagain>> Html { get; private set; }
    }
}
#pragma warning restore 1591