#pragma checksum "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c59b3a491bf2b1adc4e31fb87b7ffa0fc897d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductsOnHomePartialView), @"mvc.1.0.view", @"/Views/Shared/_ProductsOnHomePartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c59b3a491bf2b1adc4e31fb87b7ffa0fc897d8f", @"/Views/Shared/_ProductsOnHomePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1a5262dc792db5fa654d0d9a7fa48729bb2c5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductsOnHomePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("second-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modalIcon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#productQuickModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProductModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-items\">\r\n    <div class=\"row product-active\">\r\n");
#nullable restore
#line 5 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
         for (int i = 0; i < (int)Math.Ceiling((double)(Model.Count() / 2)); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 8 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                 foreach (Product product in Model.Skip(i * 2).Take(2))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-product mt-30\">\r\n                        <div class=\"product-image\">\r\n                            <a href=\"single-product.html\">\r\n");
#nullable restore
#line 14 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                 if (product.HoverImage != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c59b3a491bf2b1adc4e31fb87b7ffa0fc897d8f7941", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 658, "~/assets/images/product/", 658, 24, true);
#nullable restore
#line 16 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
AddHtmlAttributeValue("", 682, product.MainImage, 682, 18, false);

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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c59b3a491bf2b1adc4e31fb87b7ffa0fc897d8f9668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 785, "~/assets/images/product/", 785, 24, true);
#nullable restore
#line 17 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
AddHtmlAttributeValue("", 809, product.HoverImage, 809, 19, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c59b3a491bf2b1adc4e31fb87b7ffa0fc897d8f11724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1022, "~/assets/images/product/", 1022, 24, true);
#nullable restore
#line 22 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
AddHtmlAttributeValue("", 1046, product.MainImage, 1046, 18, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                 if (product.DiscountedPrice > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"discount-product\">-");
#nullable restore
#line 27 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                                                Write(((product.Price*100)/product.DiscountedPrice)-100);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 28 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                            <ul class=""product-meta"">
                                <li><a href=""#""><i class=""icon ion-bag""></i></a></li>
                                <li><a href=""#""><i class=""icon ion-android-favorite-outline""></i></a></li>
                                <li><a href=""#""><i class=""icon ion-android-options""></i></a></li>
                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c59b3a491bf2b1adc4e31fb87b7ffa0fc897d8f15078", async() => {
                WriteLiteral("<i class=\"icon ion-android-open\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                                                                                                                                                   WriteLiteral(product.Id);

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
            WriteLiteral(@"</li>

                            </ul>
                        </div>
                        <div class=""product-content"">
                            <ul class=""product-rating"">
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                            </ul>
                            <h4 class=""product-title""><a href=""single-product.html"">");
#nullable restore
#line 48 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                                                               Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <div class=\"product-price\">\r\n");
#nullable restore
#line 50 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                 if (product.DiscountedPrice > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"regular-price\">");
#nullable restore
#line 52 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                                           Write(product.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"price-sale\">");
#nullable restore
#line 53 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 54 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"


                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"price-sale\">");
#nullable restore
#line 59 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 60 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div> <!-- single product -->\r\n");
#nullable restore
#line 65 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 69 "C:\Users\irade\source\repos\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_ProductsOnHomePartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div> <!-- row -->\r\n</div> <!-- product items -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
