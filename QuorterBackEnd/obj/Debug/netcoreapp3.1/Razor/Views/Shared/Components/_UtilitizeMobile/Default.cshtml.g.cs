#pragma checksum "/Users/babayev_/Desktop/Quorter/QuorterBackEnd/Views/Shared/Components/_UtilitizeMobile/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9265abc7a2434dd7fffee682c0368773acde3bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__UtilitizeMobile_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_UtilitizeMobile/Default.cshtml")]
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
#line 1 "/Users/babayev_/Desktop/Quorter/QuorterBackEnd/Views/_ViewImports.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/babayev_/Desktop/Quorter/QuorterBackEnd/Views/_ViewImports.cshtml"
using QuorterBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/babayev_/Desktop/Quorter/QuorterBackEnd/Views/_ViewImports.cshtml"
using QuorterBackEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9265abc7a2434dd7fffee682c0368773acde3bf1", @"/Views/Shared/Components/_UtilitizeMobile/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406e341eedf17b8298e0c20fed11e68805e0d2e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__UtilitizeMobile_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""ltn__utilize-mobile-menu"" class=""ltn__utilize ltn__utilize-mobile-menu"">
    <div class=""ltn__utilize-menu-inner ltn__scrollbar"">
        <div class=""ltn__utilize-menu-head"">
            <div class=""site-logo"">
                <a href=""index.html""><img src=""img/logo.png"" alt=""Logo""></a>
            </div>
            <button class=""ltn__utilize-close"">×</button>
        </div>
        <div class=""ltn__utilize-menu-search-form"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9265abc7a2434dd7fffee682c0368773acde3bf14331", async() => {
                WriteLiteral("\n                <input type=\"text\" placeholder=\"Search...\">\n                <button><i class=\"fas fa-search\"></i></button>\n            ");
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
        <div class=""ltn__utilize-menu"">
            <ul>
                <li>
                    <a href=""#"">Home</a>
                    <ul class=""sub-menu"">
                        <li><a href=""index.html"">Home Style 01</a></li>
                        <li><a href=""index-2.html"">Home Style 02</a></li>
                        <li><a href=""index-3.html"">Home Style 03</a></li>
                        <li><a href=""index-4.html"">Home Style 04</a></li>
                        <li><a href=""index-5.html"">Home Style 05  <span class=""menu-item-badge"">video</span></a></li>
                        <li><a href=""index-6.html"">Home Style 06</a></li>
                        <li><a href=""index-7.html"">Home Style 07</a></li>
                        <li><a href=""index-8.html"">Home Style 08</a></li>
                        <li><a href=""index-9.html"">Home Style 09</a></li>
                        <li><a href=""index-10.html"">Home Style 10 <span class=""menu-item-badge"">Map</span></a></li>
                       ");
            WriteLiteral(@" <li><a href=""index-11.html"">Home Style 11</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#"">About</a>
                    <ul class=""sub-menu"">
                        <li><a href=""about.html"">About</a></li>
                        <li><a href=""service.html"">Services</a></li>
                        <li><a href=""service-details.html"">Service Details</a></li>
                        <li><a href=""portfolio.html"">Portfolio</a></li>
                        <li><a href=""portfolio-2.html"">Portfolio - 02</a></li>
                        <li><a href=""portfolio-details.html"">Portfolio Details</a></li>
                        <li><a href=""team.html"">Team</a></li>
                        <li><a href=""team-details.html"">Team Details</a></li>
                        <li><a href=""faq.html"">FAQ</a></li>
                        <li><a href=""locations.html"">Google Map Locations</a></li>
                    </ul>
                </li>
                <li>
           ");
            WriteLiteral(@"         <a href=""#"">Shop</a>
                    <ul class=""sub-menu"">
                        <li><a href=""shop.html"">Shop</a></li>
                        <li><a href=""shop-grid.html"">Shop Grid</a></li>
                        <li><a href=""shop-left-sidebar.html"">Shop Left sidebar</a></li>
                        <li><a href=""shop-right-sidebar.html"">Shop right sidebar</a></li>
                        <li><a href=""product-details.html"">Shop details </a></li>
                        <li><a href=""cart.html"">Cart</a></li>
                        <li><a href=""wishlist.html"">Wishlist</a></li>
                        <li><a href=""checkout.html"">Checkout</a></li>
                        <li><a href=""order-tracking.html"">Order Tracking</a></li>
                        <li><a href=""account.html"">My Account</a></li>
                        <li><a href=""login.html"">Sign in</a></li>
                        <li><a href=""register.html"">Register</a></li>
                    </ul>
                </li>
                <li");
            WriteLiteral(@">
                    <a href=""#"">News</a>
                    <ul class=""sub-menu"">
                        <li><a href=""blog.html"">News</a></li>
                        <li><a href=""blog-grid.html"">News Grid</a></li>
                        <li><a href=""blog-left-sidebar.html"">News Left sidebar</a></li>
                        <li><a href=""blog-right-sidebar.html"">News Right sidebar</a></li>
                        <li><a href=""blog-details.html"">News details</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#"">Pages</a>
                    <ul class=""sub-menu"">
                        <li><a href=""about.html"">About</a></li>
                        <li><a href=""service.html"">Services</a></li>
                        <li><a href=""service-details.html"">Service Details</a></li>
                        <li><a href=""portfolio.html"">Portfolio</a></li>
                        <li><a href=""portfolio-2.html"">Portfolio - 02</a></li>
                        <li>");
            WriteLiteral(@"<a href=""portfolio-details.html"">Portfolio Details</a></li>
                        <li><a href=""team.html"">Team</a></li>
                        <li><a href=""team-details.html"">Team Details</a></li>
                        <li><a href=""faq.html"">FAQ</a></li>
                        <li><a href=""history.html"">History</a></li>
                        <li><a href=""add-listing.html"">Add Listing</a></li>
                        <li><a href=""locations.html"">Google Map Locations</a></li>
                        <li><a href=""404.html"">404</a></li>
                        <li><a href=""contact.html"">Contact</a></li>
                        <li><a href=""coming-soon.html"">Coming Soon</a></li>
                    </ul>
                </li>
                <li><a href=""contact.html"">Contact</a></li>
            </ul>
        </div>
        <div class=""ltn__utilize-buttons ltn__utilize-buttons-2"">
            <ul>
                <li>
                    <a href=""account.html"" title=""My Account"">
                        <");
            WriteLiteral(@"span class=""utilize-btn-icon"">
                            <i class=""far fa-user""></i>
                        </span>
                        My Account
                    </a>
                </li>
                <li>
                    <a href=""wishlist.html"" title=""Wishlist"">
                        <span class=""utilize-btn-icon"">
                            <i class=""far fa-heart""></i>
                            <sup>3</sup>
                        </span>
                        Wishlist
                    </a>
                </li>
                <li>
                    <a href=""cart.html"" title=""Shoping Cart"">
                        <span class=""utilize-btn-icon"">
                            <i class=""fas fa-shopping-cart""></i>
                            <sup>5</sup>
                        </span>
                        Shoping Cart
                    </a>
                </li>
            </ul>
        </div>
        <div class=""ltn__social-media-2"">
            <ul>
                <li><");
            WriteLiteral(@"a href=""#"" title=""Facebook""><i class=""fab fa-facebook-f""></i></a></li>
                <li><a href=""#"" title=""Twitter""><i class=""fab fa-twitter""></i></a></li>
                <li><a href=""#"" title=""Linkedin""><i class=""fab fa-linkedin""></i></a></li>
                <li><a href=""#"" title=""Instagram""><i class=""fab fa-instagram""></i></a></li>
            </ul>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
