#pragma checksum "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49f879b9a6f0a21ff0a3549329dce6b1a2a2f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_DashBoard_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/DashBoard/Index.cshtml")]
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
#line 1 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Madeyra.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Madeyra.Areas.AdminPanel.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
using Madeyra.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49f879b9a6f0a21ff0a3549329dce6b1a2a2f33", @"/Areas/AdminPanel/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27eeaa7fad42f9ca7bf99868e6a3bae847a7e6e5", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/undraw_profile_1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-profile rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/undraw_profile.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:rebeccapurple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
  
    //task
    int umumi = Model.Orders.Count();
    int finish = Model.Finish.Count();
    int task = 0;
    decimal monthly = 0;
    decimal yearly = 0;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
     if (Model.Orders != null || Model.Orders.Count != 0)
    {
        if (finish > 0 && umumi > 0)
        {
            task = finish * 100 / umumi;
        }
        foreach (var order in Model.Finish)
        {
            if (DateTime.UtcNow.AddMonths(-1) < order.CreatedAt && order.CreatedAt < DateTime.UtcNow.AddMonths(1))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                 foreach (var item in order.OrderItems)
                {
                    monthly += item.SalePrice - item.CostPrice;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                 
            }
            if (DateTime.UtcNow.AddYears(-1) < order.CreatedAt && order.CreatedAt < DateTime.UtcNow.AddYears(1))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                 foreach (var item in order.OrderItems)
                {
                    yearly += item.SalePrice - item.CostPrice;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                 
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Main Content -->
<div id=""content"">

    <!-- Topbar -->
    <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

        <!-- Sidebar Toggle (Topbar) -->
        <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
            <i class=""fa fa-bars""></i>
        </button>



        <!-- Topbar Navbar -->
        <ul class=""navbar-nav ml-auto"">

            <!-- Nav Item - Search Dropdown (Visible Only XS) -->
            <li class=""nav-item dropdown no-arrow d-sm-none"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                   data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-search fa-fw""></i>
                </a>
                <!-- Dropdown - Messages -->
                <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                     aria-labelledby=""searchDropdown"">
    ");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49f879b9a6f0a21ff0a3549329dce6b1a2a2f3310246", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control bg-light border-0 small""
                                   placeholder=""Search for..."" aria-label=""Search""
                                   aria-describedby=""basic-addon2"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-warning"" type=""button"">
                                    <i class=""fas fa-search fa-sm""></i>
                                </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </li>

            <!-- Nav Item - Alerts -->
            <li class=""nav-item dropdown no-arrow mx-1"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button""
                   data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-bell fa-fw""></i>
                    <!-- Counter - Alerts -->
                    <span class=""badge badge-danger badge-counter"">3+</span>
                </a>
                <!-- Dropdown - Alerts -->
                <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                     aria-labelledby=""alertsDropdown"">
                    <h6 class=""dropdown-header"">
                        Alerts Center
                    </h6>
                    <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                        <div class=""mr-3"">
                            <div class=""icon-circ");
            WriteLiteral(@"le bg-warning"">
                                <i class=""fas fa-file-alt text-white""></i>
                            </div>
                        </div>
                        <div>
                            <div class=""small text-gray-500"">December 12, 2019</div>
                            <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                        </div>
                    </a>

                    <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
                </div>
            </li>

            <!-- Nav Item - Messages -->
            <li class=""nav-item dropdown no-arrow mx-1"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button""
                   data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-envelope fa-fw""></i>
                    <!-- Counter - Messages -->
                    <span class");
            WriteLiteral("=\"badge badge-danger badge-counter\">");
#nullable restore
#line 112 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                              Write(Model.ProductComments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </a>
                <!-- Dropdown - Messages -->
                <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                     aria-labelledby=""messagesDropdown"">
                    <h6 class=""dropdown-header"">
                      Şərhlər
                    </h6>
");
#nullable restore
#line 120 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                     foreach (var item in Model.ProductComments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"dropdown-item d-flex align-items-center\" href=\"#\">\r\n                            <div class=\"dropdown-list-image mr-3\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a49f879b9a6f0a21ff0a3549329dce6b1a2a2f3315576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <div class=""status-indicator bg-success""></div>
                            </div>
                            <div class=""font-weight-bold"">
                                <div class=""text-truncate"">
                                    ");
#nullable restore
#line 130 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 130 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                          Write(item.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" · ");
#nullable restore
#line 130 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                          Write(item.SendTime.ToString("dd:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"small text-gray-500\">");
#nullable restore
#line 132 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                            Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </a>\r\n");
#nullable restore
#line 135 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
                </div>
            </li>

            <div class=""topbar-divider d-none d-sm-block""></div>

            <!-- Nav Item - User Information -->
            <li class=""nav-item dropdown no-arrow"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                   data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 147 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                                         Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a49f879b9a6f0a21ff0a3549329dce6b1a2a2f3319527", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </a>
                <!-- Dropdown - User Information -->
                <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                     aria-labelledby=""userDropdown"">
                    <a class=""dropdown-item"" href=""#"">
                        <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                        Profile
                    </a>
                    <a class=""dropdown-item"" href=""#"">
                        <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                        Settings
                    </a>
                    <a class=""dropdown-item"" href=""#"">
                        <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                        Activity Log
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                        <i class=""fas f");
            WriteLiteral(@"a-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                        Logout
                    </a>
                </div>
            </li>

        </ul>

    </nav>
    <!-- End of Topbar -->
    <!-- Begin Page Content -->
    <div class=""container-fluid"">

        <!-- Page Heading -->
        <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
            <h1 class=""h3 mb-0 text-gray-800"">Madeyra Mebel </h1>

        </div>

        <!-- Content Row -->
        <div class=""row"">

            <!-- Earnings (Monthly) Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-danger shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                               ");
            WriteLiteral("     Qazanc (aylıq)\r\n                                </div>\r\n                                <div class=\"h5 mb-0 font-weight-bold text-gray-800\">");
#nullable restore
#line 199 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                                               Write(monthly.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₼</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Earnings (Monthly) Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-success shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-success  mb-1"">
                                   QAZANC (İLLİK)
                                </div>
                                <div class=""h5 mb-0 font-weight-bold text-gray-800"">$");
#nullable restore
#line 218 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                                                Write(yearly.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Earnings (Monthly) Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-info shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-info  mb-1"">
                                    SİFARİŞLƏR
                                </div>
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col-auto"">
                                    ");
            WriteLiteral("    <div class=\"h5 mb-0 mr-3 font-weight-bold text-gray-800\">");
#nullable restore
#line 239 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                                                            Write(task.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</div>
                                    </div>
                                    <div class=""col"">
                                        <div class=""progress progress-sm mr-2"">
                                            <div class=""progress-bar bg-info"" role=""progressbar""");
            BeginWriteAttribute("style", "\r\n                                                 style=\"", 11520, "\"", 11602, 3);
            WriteAttributeValue("", 11578, "width:", 11578, 6, true);
#nullable restore
#line 244 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
WriteAttributeValue(" ", 11584, task.ToString(), 11585, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11601, "%", 11601, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 11603, "\"", 11624, 1);
#nullable restore
#line 244 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
WriteAttributeValue("", 11619, task, 11619, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0""
                                                 aria-valuemax=""100""></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Pending Requests Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-warning shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                       ");
            WriteLiteral("             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49f879b9a6f0a21ff0a3549329dce6b1a2a2f3328318", async() => {
                WriteLiteral("Şərhlər");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"h5 mb-0 font-weight-bold text-gray-800\">");
#nullable restore
#line 267 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                                                                               Write(Model.ProductComments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-comments fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Content Row -->


        <div class=""row"">

            <!-- Area Chart -->
            <div class=""col-xl-12 col-lg-12"">
                <div id=""Piechart_div""></div>
            </div>

            <!-- Pie Chart -->

        </div>


    </div>
    <!-- /.container-fluid -->

</div>
<!-- End of Main Content -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"" src=""https://www.google.com/jsapi""></script>
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
    <script>
        $(document).ready(function () {
            $.ajax({
                type: ""POST"",
                dataType: ""json"",
                contentType: ""application/json"",
                url: '");
#nullable restore
#line 310 "C:\Users\heyde\source\repos\Madeyra\Madeyra\Areas\AdminPanel\Views\DashBoard\Index.cshtml"
                 Write(Url.Action("Jesonforchart", "Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                success: function (result) {
                    google.charts.load('current', {
                        'packages': ['corechart']
                    });
                    google.charts.setOnLoadCallback(function () {
                        drawChart(result);
                    });
                }
            });
        });
        function drawChart(result) {
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Name');
            data.addColumn('number', 'Stoklar');
            var dataArray = [];
            $.each(result, function (i, obj) {
                dataArray.push([obj.name, obj.totalAmount]);
            });
            data.addRows(dataArray);
            var columnChartOptions = {
                width: 850,
                height: 400,
                bar: { groupWidth: ""20%"" },
            };
            var columnChart = new google.visualization.PieChart(document
                .getElementById");
                WriteLiteral("(\'Piechart_div\'));\r\n            columnChart.draw(data, columnChartOptions);\r\n        }\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
