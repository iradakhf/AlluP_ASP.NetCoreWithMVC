#pragma checksum "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f406180bedbb2979c6fcffb10533c56265cee1a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Manage/Views/Shared/_Layout.cshtml")]
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
#line 2 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.ViewModels.ShopVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.ProductVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\_ViewImports.cshtml"
using Allup.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f406180bedbb2979c6fcffb10533c56265cee1a9", @"/Areas/Manage/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7feae6ceb5ecf80e38d7f66fa03fd3eab7b008d9", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f406180bedbb2979c6fcffb10533c56265cee1a96085", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 246, "\"", 256, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 282, "\"", 292, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>SB Admin 2 - Dashboard</title>

    <!-- Custom fonts for this template-->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""css/sb-admin-2.min.css"" rel=""stylesheet"">

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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f406180bedbb2979c6fcffb10533c56265cee1a98064", async() => {
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
                <div class=""sidebar-brand-icon rotate-n-15"">
                    <i class=""fas fa-laugh-wink""></i>
                </div>
                <div class=""sidebar-brand-text mx-3"">SB Admin <sup>2</sup></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""index.html"">
                    <i class=""fas fa-fw fa-tachometer-alt""></i>
                    <span>Dashboard</span>
                </a>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
 ");
                WriteLiteral(@"           <div class=""sidebar-heading"">
                Interface
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo""
                   aria-expanded=""true"" aria-controls=""collapseTwo"">
                    <i class=""fas fa-fw fa-cog""></i>
                    <span>Components</span>
                </a>
                <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""buttons.html"">Buttons</a>
                        <a class=""collapse-item"" href=""cards.html"">Cards</a>
                    </div>
                </div>
            </li>

            <!-- Nav Item - Utilities Collapse Menu -->
            ");
                WriteLiteral(@"<li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities""
                   aria-expanded=""true"" aria-controls=""collapseUtilities"">
                    <i class=""fas fa-fw fa-wrench""></i>
                    <span>Utilities</span>
                </a>
                <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities""
                     data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Utilities:</h6>
                        <a class=""collapse-item"" href=""utilities-color.html"">Colors</a>
                        <a class=""collapse-item"" href=""utilities-border.html"">Borders</a>
                        <a class=""collapse-item"" href=""utilities-animation.html"">Animations</a>
                        <a class=""collapse-item"" href=""utilities-other.html"">Other</a>
                    </div>
            ");
                WriteLiteral(@"    </div>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <div class=""sidebar-heading"">
                Addons
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages""
                   aria-expanded=""true"" aria-controls=""collapsePages"">
                    <i class=""fas fa-fw fa-folder""></i>
                    <span>Pages</span>
                </a>
                <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Login Screens:</h6>
                        <a class=""collapse-item"" href=""login.html"">Login</a>
                        <a class=""collapse-item"" href=""register.html"">Register</a>
     ");
                WriteLiteral(@"                   <a class=""collapse-item"" href=""forgot-password.html"">Forgot Password</a>
                        <div class=""collapse-divider""></div>
                        <h6 class=""collapse-header"">Other Pages:</h6>
                        <a class=""collapse-item"" href=""404.html"">404 Page</a>
                        <a class=""collapse-item"" href=""blank.html"">Blank Page</a>
                    </div>
                </div>
            </li>

            <!-- Nav Item - Charts -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""charts.html"">
                    <i class=""fas fa-fw fa-chart-area""></i>
                    <span>Charts</span>
                </a>
            </li>

            <!-- Nav Item - Tables -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""tables.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>Tables</span>
                </a>
            </li>

            <!-- Divider -->
          ");
                WriteLiteral(@"  <hr class=""sidebar-divider d-none d-md-block"">

            <!-- Sidebar Toggler (Sidebar) -->
            <div class=""text-center d-none d-md-inline"">
                <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
            </div>

            <!-- Sidebar Message -->
            <div class=""sidebar-card d-none d-lg-flex"">
                <img class=""sidebar-card-illustration mb-2"" src=""img/undraw_rocket.svg"" alt=""..."">
                <p class=""text-center mb-2""><strong>SB Admin Pro</strong> is packed with premium features, components, and more!</p>
                <a class=""btn btn-success btn-sm"" href=""https://startbootstrap.com/theme/sb-admin-pro"">Upgrade to Pro!</a>
            </div>

        </ul>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-l");
                WriteLiteral(@"ight bg-white topbar mb-4 static-top shadow"">

                    <!-- Sidebar Toggle (Topbar) -->
                    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                        <i class=""fa fa-bars""></i>
                    </button>

                    <!-- Topbar Search -->
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f406180bedbb2979c6fcffb10533c56265cee1a915244", async() => {
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                                   aria-label=""Search"" aria-describedby=""basic-addon2"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-primary"" type=""button"">
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f406180bedbb2979c6fcffb10533c56265cee1a918080", async() => {
                    WriteLiteral(@"
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control bg-light border-0 small""
                                               placeholder=""Search for..."" aria-label=""Search""
                                               aria-describedby=""basic-addon2"">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-primary"" type=""button"">
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
 ");
                WriteLiteral(@"                               <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-primary"">
                                            <i class=""fas fa-file-alt text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 12, 2019</div>
                                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-success"">
                                            <i class=""fas ");
                WriteLiteral(@"fa-donate text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 7, 2019</div>
                                        $290.29 has been deposited into your account!
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-warning"">
                                            <i class=""fas fa-exclamation-triangle text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 2, 2019</div>
                                        Spending Al");
                WriteLiteral(@"ert: We've noticed unusually high spending for your account.
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
                                <span class=""badge badge-danger badge-counter"">7</span>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class=""dropdown-list dropdown");
                WriteLiteral(@"-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""messagesDropdown"">
                                <h6 class=""dropdown-header"">
                                    Message Center
                                </h6>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""img/undraw_profile_1.svg""
                                             alt=""..."">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div class=""font-weight-bold"">
                                        <div class=""text-truncate"">
                                            Hi there! I am wondering if you can help me with a
                                            problem I've been having.");
                WriteLiteral(@"
                                        </div>
                                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""img/undraw_profile_2.svg""
                                             alt=""..."">
                                        <div class=""status-indicator""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            I have the photos that you ordered last month, how
                                            would you like them sent to you?
                                        </div>
                          ");
                WriteLiteral(@"              <div class=""small text-gray-500"">Jae Chun · 1d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""img/undraw_profile_3.svg""
                                             alt=""..."">
                                        <div class=""status-indicator bg-warning""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Last month's report looks great, I am very happy with
                                            the progress so far, keep up the good work!
                                        </div>
                                        <div class=""small text-gray-500"">Morgan ");
                WriteLiteral(@"Alvarez · 2d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""
                                             alt=""..."">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Am I a good boy? The reason I ask is because someone
                                            told me that people say this to all dogs, even if they aren't good...
                                        </div>
                                        <div class=""small text-gray-500"">Chicken t");
                WriteLiteral(@"he Dog · 2w</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
                            </div>
                        </li>

                        <div class=""topbar-divider d-none d-sm-block""></div>

                        <!-- Nav Item - User Information -->
                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Douglas McGee</span>
                                <img class=""img-profile rounded-circle""
                                     src=""img/undraw_profile.svg"">
                            </a>
                            <!-- Dropdown - User I");
                WriteLiteral(@"nformation -->
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
                                <a class");
                WriteLiteral(@"=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Logout
                                </a>
                            </div>
                        </li>

                    </ul>

                </nav>
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">

                    ");
#nullable restore
#line 375 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Areas\Manage\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <footer class=""sticky-footer bg-white"">
                        <div class=""container my-auto"">
                            <div class=""copyright text-center my-auto"">
                                <span>Copyright &copy; Your Website 2021</span>
                            </div>
                        </div>
                    </footer>
                    <!-- End of Footer -->

                </div>
                <!-- End of Content Wrapper -->

            </div>
            <!-- End of Page Wrapper -->
            <!-- Scroll to Top Button-->
            <a class=""scroll-to-top rounded"" href=""#page-top"">
                <i class=""fas fa-angle-up""></i>
            </a>

            <!-- Logout Modal-->
            <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
                 aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                   ");
                WriteLiteral(@"     <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                            <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">×</span>
                            </button>
                        </div>
                        <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                        <div class=""modal-footer"">
                            <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                            <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Bootstrap core JavaScript-->
            <script src=""vendor/jquery/jquery.min.js""></script>
            <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></scr");
                WriteLiteral(@"ipt>

            <!-- Core plugin JavaScript-->
            <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

            <!-- Custom scripts for all pages-->
            <script src=""js/sb-admin-2.min.js""></script>

            <!-- Page level plugins -->
            <script src=""vendor/chart.js/Chart.min.js""></script>

            <!-- Page level custom scripts -->
            <script src=""js/demo/chart-area-demo.js""></script>
            <script src=""js/demo/chart-pie-demo.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
