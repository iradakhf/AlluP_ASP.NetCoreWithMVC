#pragma checksum "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a9a5003fadb281a5368b81173d0b20db4280439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalPartialView), @"mvc.1.0.view", @"/Views/Shared/_ModalPartialView.cshtml")]
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
#line 2 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.ShopVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a9a5003fadb281a5368b81173d0b20db4280439", @"/Views/Shared/_ModalPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d82e76cde01dfdc74f461a119e749af3eb11740", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModalPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"product-quick-view-image mt-30\">\r\n                <div class=\"quick-view-image\">\r\n");
#nullable restore
#line 10 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
                     foreach(ProductImage item in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-view-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a9a5003fadb281a5368b81173d0b20db42804396503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 367, "~/assets/images/product-quick/", 367, 30, true);
#nullable restore
#line 13 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
AddHtmlAttributeValue("", 397, item.Name, 397, 10, false);

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
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 15 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 \r\n                </div>\r\n                <ul class=\"quick-view-thumb\">\r\n");
#nullable restore
#line 20 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <div class=\"single-thumb\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a9a5003fadb281a5368b81173d0b20db42804398887", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 788, "~/assets/images/product-quick/", 788, 30, true);
#nullable restore
#line 24 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
AddHtmlAttributeValue("", 818, productImage.Name, 818, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 27 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </ul>
            </div> <!-- Modal Quick View Image -->
        </div>
        <div class=""col-md-6"">
            <div class=""product-quick-view-content mt-30"">
                <h3 class=""product-title"">Trans-Weight Hooded Wind and Water Resistant Shell</h3>
                <p class=""reference"">Reference: demo_12</p>
                <ul class=""rating"">
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                </ul>
                <div class=""product-prices"">
");
#nullable restore
#line 45 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
                     if ( Model.DiscountedPrice>0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"regular-price\">");
#nullable restore
#line 47 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
                                           Write(Model.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"sale-price\">");
#nullable restore
#line 48 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
                                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 49 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"save\">Save 12%</span>\r\n                </div>\r\n                <p class=\"product-description\">");
#nullable restore
#line 53 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ModalPartialView.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"product-size-color flex-wrap\">\r\n                    <div class=\"product-size\">\r\n                        <h5 class=\"title\">Size</h5>\r\n                        <select>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9a5003fadb281a5368b81173d0b20db428043913520", async() => {
                WriteLiteral("S");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9a5003fadb281a5368b81173d0b20db428043914703", async() => {
                WriteLiteral("M");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9a5003fadb281a5368b81173d0b20db428043915886", async() => {
                WriteLiteral("L");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9a5003fadb281a5368b81173d0b20db428043917069", async() => {
                WriteLiteral("XL");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""product-color"">
                        <h5 class=""title"">Color</h5>
                        <div class=""color-input"">
                            <div class=""single-color color-1"">
                                <input type=""radio"" id=""radio-1"" name=""color"">
                                <label for=""radio-1""></label>
                            </div>
                            <div class=""single-color color-2"">
                                <input type=""radio"" id=""radio-2"" name=""color"">
                                <label for=""radio-2""></label>
                            </div>
                            <div class=""single-color color-3"">
                                <input type=""radio"" id=""radio-3"" name=""color"">
                                <label for=""radio-3""></label>
                            </div>
                        </div>
                    </div>
                ");
            WriteLiteral(@"    <div class=""product-quantity"">
                        <h5 class=""title"">Quantity</h5>
                        <div class=""quantity d-flex"">
                            <button type=""button"" id=""sub"" class=""sub""><i class=""fal fa-minus""></i></button>
                            <input type=""text"" value=""1"" />
                            <button type=""button"" id=""add"" class=""add""><i class=""fal fa-plus""></i></button>
                        </div>
                    </div>
                </div>
                <div class=""product-add-cart"">
                    <button><i class=""icon ion-bag""></i> Add to cart</button>
                </div>
                <div class=""product-wishlist-compare"">
                    <ul class=""d-flex flex-wrap"">
                        <li><a href=""#""><i class=""fal fa-heart""></i> Add to wishlist</a></li>
                        <li><a href=""#""><i class=""fal fa-repeat""></i> Add to compare</a></li>
                    </ul>
                </div>
             ");
            WriteLiteral(@"   <div class=""product-share d-flex"">
                    <p>Share</p>
                    <ul class=""social media-body"">
                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-google""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-pinterest-p""></i></a></li>
                    </ul>
                </div>
            </div> <!-- Modal Quick View Content -->
        </div>
    </div> <!-- row -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
