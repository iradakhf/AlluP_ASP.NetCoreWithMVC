#pragma checksum "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afe78ef04e14c922fa1979840319483d6c46b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketCartPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketCartPartial.cshtml")]
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
#line 2 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.ShopVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels.ProductVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\_ViewImports.cshtml"
using Allup.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afe78ef04e14c922fa1979840319483d6c46b61", @"/Views/Shared/_BasketCartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7feae6ceb5ecf80e38d7f66fa03fd3eab7b008d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketCartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("closeIconforCartProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"cart-btn\">\r\n    <a href=\"#\">\r\n        <i class=\"icon ion-bag\"></i>\r\n        <span class=\"text\">Cart :</span>\r\n        <span class=\"total\">$");
#nullable restore
#line 7 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                         Write(Model.Sum(p=>p.Price)+ Model.Sum(p => p.ExTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"count\">");
#nullable restore
#line 8 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n</div>\r\n<div class=\"mini-cart\">\r\n    <ul class=\"cart-items\">\r\n");
#nullable restore
#line 13 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
         foreach (BasketVM item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <div class=\"single-cart-item d-flex\">\r\n                <div class=\"cart-item-thumb\">\r\n                    <a href=\"single-product.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2afe78ef04e14c922fa1979840319483d6c46b617525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 590, "~/assets/images/product/", 590, 24, true);
#nullable restore
#line 18 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
AddHtmlAttributeValue("", 614, item.Image, 614, 11, false);

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
            WriteLiteral("</a>\r\n                    <span class=\"product-quantity\">");
#nullable restore
#line 19 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("x</span>\r\n                </div>\r\n                <div class=\"cart-item-content media-body\">\r\n                    <h5 class=\"product-name\"><a href=\"single-product.html\">");
#nullable restore
#line 22 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                    <span class=\"product-price\">€");
#nullable restore
#line 23 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afe78ef04e14c922fa1979840319483d6c46b6110349", async() => {
                WriteLiteral("<i class=\"fal fa-times\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 29 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n    <div class=\"price_content\">\r\n        <div class=\"cart-subtotals\">\r\n            <div class=\"products price_inline\">\r\n                <span class=\"label\">Subtotal</span>\r\n                <span class=\"value\">€");
#nullable restore
#line 37 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                Write(Model.Sum(p=>p.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"tax price_inline\">\r\n                <span class=\"label\">Taxes</span>\r\n                <span class=\"value\">€");
#nullable restore
#line 45 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                Write(Model.Sum(b=>b.ExTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"cart-total price_inline\">\r\n            <span class=\"label\">Total</span>\r\n            <span class=\"value\">€");
#nullable restore
#line 50 "C:\Users\irade\source\repos\new\AlluP_ASP.NetCoreWithMVC\Allup\Views\Shared\_BasketCartPartial.cshtml"
                             Write(Model.Sum(b => b.ExTax)+ Model.Sum(b => b.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div> <!-- price content -->\r\n    <div class=\"checkout text-center\">\r\n        <a href=\"checkout.html\" class=\"main-btn\">Checkout</a>\r\n    </div>\r\n</div> <!-- mini cart -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
