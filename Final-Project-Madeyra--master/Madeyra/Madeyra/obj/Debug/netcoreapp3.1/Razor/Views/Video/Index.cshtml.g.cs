#pragma checksum "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Video\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266cd2015c96c163cd94ea4ab9e538791945ebc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_Index), @"mvc.1.0.view", @"/Views/Video/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"266cd2015c96c163cd94ea4ab9e538791945ebc5", @"/Views/Video/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc0ea38c2fbf656db6134b9cff8708f444fbeca", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Video>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Video\Index.cshtml"
  
    ViewData["Title"] = "Videolar";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <main>\r\n        <div class=\"missiya komekci-class\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xl-2 col-lg-3 col-md-3 col-sm-3 col-3\">\r\n                        ");
#nullable restore
#line 11 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Video\Index.cshtml"
                   Write(await Html.PartialAsync("_HelpermenuPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-xl-10 col-lg-9 col-md-12 col-sm-12 col-12\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Video\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12 pl-4 pr-4\">\r\n                                    ");
#nullable restore
#line 18 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Video\Index.cshtml"
                               Write(Html.Raw(item.VideoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 20 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Video\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n    </main>\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Video>> Html { get; private set; }
    }
}
#pragma warning restore 1591