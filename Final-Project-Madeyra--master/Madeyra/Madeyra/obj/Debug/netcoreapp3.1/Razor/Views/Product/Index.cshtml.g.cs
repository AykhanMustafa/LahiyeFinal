#pragma checksum "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f336dbc75f964f195b7c65a4681b42b30fab08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f336dbc75f964f195b7c65a4681b42b30fab08", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc0ea38c2fbf656db6134b9cff8708f444fbeca", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddtoWish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/range/plugins.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
  
    if(Model!=null &&Model.Count>0)
    {
        string name = Model.First().SubCategory.Name;
        ViewData["Title"] = name;
    }
            else
            {
                ViewData["Title"] = "Nəticə tapılmadı";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section>
        <div id=""down-search"" class=""down-search"">
            <div class=""search"">
                <div class=""search-form"">
                    <div class=""row"">
                        <div class=""col-xl-10 col-lg-10 col-md-10 col-sm-10 col-10"">
                            <input style=""width: 1rem;"" type=""search"" placeholder=""Axtarış..."">
                        </div>
                        <div class=""col-xl-2 col-lg-2 col-md-2 col-sm-2 col-2"">
                            <i class=""fa-solid fa-magnifying-glass""></i>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </section>
    <section>
        <div class=""mehsul siyahi"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-2 col-lg-3 col-md-12 col-sm-12 col-12"">
                        <div class=""mehsul-filter"">
                            <div class=""container"">
           ");
            WriteLiteral(@"                     <div class=""row"">
                                    <div id=""filter-icon"" class=""filter"">
                                        <h4>Filter</h4>
                                        <i class=""fa-solid fa-chevron-down""></i>
                                    </div>
                                    <div class=""qiymet"">
                                        <h3>Qiymət</h3>
                                        <i id=""qiymet-icon"" class=""fa-solid fa-caret-up""></i>
                                    </div>
                                    <div class=""qiymet-range"">

                                        <div style=""width:100%"" class=""single-block"">
                                            <div class=""range-slider pt--10"">
                                                <div  class=""sb-range-slider""></div>
                                                <div class=""slider-price"">
                                                    <p>
                     ");
            WriteLiteral("                                   <input  type=\"text\" id=\"amount\"");
            BeginWriteAttribute("readonly", " readonly=\"", 2389, "\"", 2400, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-10 col-lg-9 col-md-12 col-sm-12 col-12"">
                        <div class=""mehsul-sekil"">
                            <img src=""https://madeyra.com/image/cache/catalog/catagory%20foto/yataq-1920x400.webp""");
            BeginWriteAttribute("alt", " alt=\"", 3047, "\"", 3053, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 69 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                             if (Model != null &&Model.Count>0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5>");
#nullable restore
#line 71 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                               Write(Model.First().SubCategory.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 72 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"siyahi-top\">\r\n");
#nullable restore
#line 75 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                             if (Model != null && Model.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                           Write(Model.First().SubCategory.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                               
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                          \r\n                            \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f336dbc75f964f195b7c65a4681b42b30fab0811823", async() => {
                WriteLiteral("<i class=\"fa-solid fa-house-chimney\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</i> <i class=\"fa-solid fa-angle-right\"></i> <a> <span>");
#nullable restore
#line 81 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                                                                                             if (Model.Count > 0 && Model != null)
                            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                        Write(Model.First().SubCategory.Category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                     }
                            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Nəticə tapılmadı</span>");
#nullable restore
#line 83 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a> <i class=\"fa-solid fa-angle-right\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 4004, "\"", 4011, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span>\r\n");
#nullable restore
#line 85 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                     if (Model != null && Model.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                   Write(Model.First().SubCategory.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                       
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </a>
                        </div>
                        <div class=""still"">
                            <span>Sütun stili:</span><i id=""grid2"" class=""fa-solid fa-border-all""></i><i id=""grid3"" class=""fa-solid fa-table-cells""></i>
                        </div>
                        <div class=""row"">
                            <div class=""favorite"">
                                <div class=""row"">
");
#nullable restore
#line 99 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                     foreach (var item in Model)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-xl-4 col-lg-6 col-md-6 col-sm-12 col-12"">
                                            <div class=""item"">

                                                <div class=""card"">
                                                    <div class=""favorite-image"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f336dbc75f964f195b7c65a4681b42b30fab0816711", async() => {
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3f336dbc75f964f195b7c65a4681b42b30fab0817027", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5390, "~/uploads/product/", 5390, 18, true);
#nullable restore
#line 108 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 5408, item.ProductImages.FirstOrDefault(x=>x.IsPoster==true)?.Image, 5408, 62, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </div>\r\n");
#nullable restore
#line 112 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                     if (item.IsInterestFree == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""credit-tag"">
                                                            <div class=""price"">
                                                                <span>Ayda <br> 64</span>
                                                            </div>
                                                            <div class=""tag"">
                                                                <span>24 Ay Faizsiz</span>
                                                            </div>
                                                        </div>
");
#nullable restore
#line 122 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f336dbc75f964f195b7c65a4681b42b30fab0822323", async() => {
                WriteLiteral("<i class=\"fa-solid fa-heart\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    <div class=""card-body"">
                                                        <div class=""row"">
                                                            <div class=""col-xl-9 col-lg-9 col-md-9 col-sm-9 col-9"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f336dbc75f964f195b7c65a4681b42b30fab0825207", async() => {
                WriteLiteral(" <span>");
#nullable restore
#line 127 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                <div class=""row"">
                                                                    <div class=""favorite-price"">
                                                                        <div class=""price"">
                                                                            <span class=""oldprice"">");
#nullable restore
#line 131 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                    if (item.DiscountPrice > 0) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                                              Write((item.SalePrice).ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>₼</span>");
#nullable restore
#line 131 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"newprice\">");
#nullable restore
#line 131 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                                                                                                                                                                                 Write((item.SalePrice*(1-(item.DiscountPrice/100))).ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₼</span>
                                                                        </div>

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-3 col-3"">

                                                                <div class=""kompaniya"">
                                                                    <img src=""https://madeyra.com/catalog/view/theme/madeyra/images/icons/pay-later.png.pagespeed.ce._ncBfaI94O.png""");
            BeginWriteAttribute("alt", "\r\n                                                                         alt=\"", 8404, "\"", 8484, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                    <div class=""img-txt"">
                                                                        <span>indi al</span>
                                                                        <span>2 ay</span>
                                                                        <span>sonra ödə</span>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 155 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
   <script>
       var $calc = $('#calculator');
       var $button = $('#calculate-total');
       var $treatmentCost = $('#cost');
       var $downPayment = $('#down-payment');
       var $insuranceCoverage = $('#insurance-coverage');
       var $rangeSlider = $('#financing-term');
       var $expectedPayment = $('#expected-payment');
       var $estimated = $('#estimate');

       var $ft = $(""#financing-term"");

       $ft.ionRangeSlider({
           min: 6,
           max: 32,
           grid: true,
           grid_snap: true,
           hide_min_max: true,
           from: 6,
           step: 2,
           skin: ""round"",
       });

       $ftInstance = $ft.data(""ionRangeSlider"");

       $expectedPayment.on(""propertychange input"", function (e) {
           var val = parseFloat($expectedPayment.val());

           if (val > 0) {
               $ftInstance.update({
                   disable: true
               });
           } else {
               $ftInstance.update(");
                WriteLiteral(@"{
                   disable: false
               });
           }
       });

       function calculate() {

           var cost = parseFloat($treatmentCost.val());
           if (isNaN(cost) || (cost === """") || (cost < 0)) {
               cost = 0;
               $treatmentCost.val(0);
           }

           var down = parseFloat($downPayment.val());
           if (isNaN(down) || (down === """") || (down < 0)) {
               down = 0;
               $downPayment.val(0);
           }

           var insurance = parseFloat($insuranceCoverage.val());
           if (isNaN(insurance) || (insurance === """") || (insurance < 0)) {
               insurance = 0;
               $insuranceCoverage.val(0);
           }

           var expected = parseFloat($expectedPayment.val());
           if (isNaN(expected) || (expected === """") || (expected < 0)) {
               expected = 0;
               $expectedPayment.val(0);
           }

           var total = """";
           var from = $f");
                WriteLiteral(@"t.prop(""value"");
           var from2 = $ft.data(""from"");

           if (expected > 0) {
               total = (cost - down - insurance) / expected;
               $ftInstance.update({
                   from: total
               });
               var result = """";

               if (total > 32) {
                   result = ""It will take more than 32 months to pay off."";
                   $estimated.addClass(""over"");
               } else {
                   result = ""It will take "" + Math.round(total) + ' months to pay off.';
                   $estimated.removeClass(""over"");
               }

               $estimated.html(result);
           } else {
               total = (cost - down - insurance) / from2;
               if (total < 0) {
                   total = 0;
               }
               var result = 'Your estimated payment is: $' + Math.round(total) + ' / month.';
               $estimated.html(result);

               if ($estimated.hasClass('over')) {
     ");
                WriteLiteral(@"              $estimated.removeClass('over');
               }
           }
       }

       $button.click(function (e) {
           e.preventDefault();
           calculate();
           $button.val(""Recalculate Total"");
       });


   </script>
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f336dbc75f964f195b7c65a4681b42b30fab0835843", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script>\r\n                    $(function () {\r\n                        $(\".sb-range-slider\").slider({\r\n                            range: true,\r\n                            min: ");
#nullable restore
#line 283 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                            Write(ViewBag.Min);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                            max: ");
#nullable restore
#line 284 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                            Write(ViewBag.Max);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                            values: [");
#nullable restore
#line 285 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                Write(ViewBag.SelectMin);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 285 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Views\Product\Index.cshtml"
                                                    Write(ViewBag.SelectMax);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                            slide: function (event, ui) {
                                $(""#amount"").val(""₼"" + ui.values[0] + "" -₼"" + ui.values[1]);
                            },
                            
                            change: function (event, ui) {
                                console.log(ui.values[0] + ' - ' + ui.values[1])

                                let url = new URL(window.location.href);
                                let params = new URLSearchParams(url.search);

                                params.set(""min"", ui.values[0]);
                                params.set(""max"", ui.values[1]);
                                url.search = params;

                                window.location = url.href;
                            }
                        });
                        $(""#amount"").val(""₼"" + $("".sb-range-slider"").slider(""values"", 0) +
                            "" - ₼"" + $("".sb-range-slider"").slider(""values"", 1));
                    });");
                WriteLiteral("\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591