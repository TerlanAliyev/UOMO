#pragma checksum "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\_ViewImports.cshtml"
using UOMO

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\_ViewImports.cshtml"
using UOMO.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa0", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ee863b9f5af7bce24381cfd4950e85cf0e6b0c9ff7fb4657dc3555894d4b147d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main>
    <section class=""full-width_padding"">
        <div class=""full-width_border border-2"" style=""border-color: #eeeeee;"">
            <div class=""shop-banner position-relative "">
                <div class=""background-img"" style=""background-color: #eeeeee;"">
                    <img loading=""lazy"" src=""../images/shop/shop_banner_character1.png"" width=""1759"" height=""420"" alt=""Pattern"" class=""slideshow-bg__img object-fit-cover"">
                </div>

                <div class=""shop-banner__content container position-absolute start-50 top-50 translate-middle"">
                    <h2 class=""stroke-text h1 smooth-16 text-uppercase fw-bold mb-3 mb-xl-4 mb-xl-5"">Jackets & Coats</h2>
                    <ul class=""d-flex flex-wrap list-unstyled text-uppercase h6"">
                        <li class=""me-3 me-xl-4 pe-1""><a href=""#"" class=""menu-link menu-link_us-s menu-link_active"">StayHome</a></li>
                        <li class=""me-3 me-xl-4 pe-1""><a href=""#"" class=""menu-link menu-link_us-s"">");
            WriteLiteral("New In</a></li>\r\n");
#nullable restore
#line 16 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                         foreach (var item in ViewBag.Categories)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <li class=\"me-3 me-xl-4 pe-1\"><a href=\"#\" class=\"menu-link menu-link_us-s\">");
            Write(
#nullable restore
#line 18 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                                                                        item.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 19 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                    </ul>
                </div><!-- /.shop-banner__content -->
            </div><!-- /.shop-banner position-relative -->
        </div><!-- /.full-width_border -->
    </section><!-- /.full-width_padding-->

    <div class=""mb-4 pb-lg-3""></div>

    <div class=""d-flex justify-content-between mb-4 pb-md-2"">
        <div class=""breadcrumb mb-0 d-none d-md-block flex-grow-1"">
            <a href=""#"" class=""menu-link menu-link_us-s text-uppercase fw-medium"">Home</a>
            <span class=""breadcrumb-separator menu-link fw-medium ps-1 pe-1"">/</span>
            <a href=""#"" class=""menu-link menu-link_us-s text-uppercase fw-medium"">The Shop</a>
        </div><!-- /.breadcrumb -->

        <div class=""shop-acs d-flex align-items-center justify-content-between justify-content-md-end flex-grow-1"">
            <select class=""shop-acs__select form-select w-auto border-0 py-0 order-1 order-md-0"" aria-label=""Sort Items"" name=""total-number"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa07100", async() => {
                WriteLiteral("Default Sorting");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa08418", async() => {
                WriteLiteral("Featured");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa09619", async() => {
                WriteLiteral("Best selling");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa010824", async() => {
                WriteLiteral("Alphabetically, A-Z");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa012037", async() => {
                WriteLiteral("Alphabetically, Z-A");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa013250", async() => {
                WriteLiteral("Price, low to high");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa014462", async() => {
                WriteLiteral("Price, high to low");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa015674", async() => {
                WriteLiteral("Date, old to new");
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6baf2e454c11a65125f90b3bc0ed66acd8f3f9bdc14ef91e6dbe09acc8d84fa016884", async() => {
                WriteLiteral("Date, new to old");
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
            WriteLiteral(@"
            </select>

            <div class=""shop-asc__seprator mx-3 bg-light d-none d-md-block order-md-0""></div>

            <div class=""col-size align-items-center order-1 d-none d-lg-flex"">
                <span class=""text-uppercase fw-medium me-2"">View</span>
                <button class=""btn-link fw-medium me-2 js-cols-size"" data-target=""products-grid"" data-cols=""2"">2</button>
                <button class=""btn-link fw-medium me-2 js-cols-size"" data-target=""products-grid"" data-cols=""3"">3</button>
                <button class=""btn-link fw-medium js-cols-size"" data-target=""products-grid"" data-cols=""4"">4</button>
            </div><!-- /.col-size -->

            <div class=""shop-asc__seprator mx-3 bg-light d-none d-lg-block order-md-1""></div>

            <div class=""shop-filter d-flex align-items-center order-0 order-md-3"">
                <button class=""btn-link btn-link_f d-flex align-items-center ps-0 js-open-aside"" data-aside=""shopFilter"">
                    <svg class=""d-inli");
            WriteLiteral(@"ne-block align-middle me-2"" width=""14"" height=""10"" viewBox=""0 0 14 10"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_filter"" /></svg>
                    <span class=""text-uppercase fw-medium d-inline-block align-middle"">Filter</span>
                </button>
            </div><!-- /.col-size d-flex align-items-center ms-auto ms-md-3 -->
        </div><!-- /.shop-acs -->
    </div><!-- /.d-flex justify-content-between -->

    <div class=""products-grid row row-cols-2 row-cols-md-3 row-cols-lg-4"" id=""products-grid"">
");
#nullable restore
#line 69 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"            <div class=""product-card-wrapper"">
                <div class=""product-card mb-3 mb-md-4 mb-xxl-5"">
                    <div class=""pc__img-wrapper"">
                        <div class=""swiper-container background-img js-swiper-slider"" data-settings='{""resizeObserver"": true}'>
                            <div class=""swiper-wrapper"">
                                <div class=""swiper-slide"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 4908, "\"", 4953, 2);
            WriteAttributeValue("", 4915, "/Home/product_variable/", 4915, 23, true);
            WriteAttributeValue("", 4938, 
#nullable restore
#line 77 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                                     item.ProductId

#line default
#line hidden
#nullable disable
            , 4938, 15, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img loading=\"lazy\"");
            BeginWriteAttribute("src", " src=\"", 5016, "\"", 5074, 2);
            WriteAttributeValue("", 5022, "../images/products/", 5022, 19, true);
            WriteAttributeValue("", 5041, 
#nullable restore
#line 78 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                                                     item.Photos.ToList()[1].PhotoUrl

#line default
#line hidden
#nullable disable
            , 5041, 33, false);
            EndWriteAttribute();
            WriteLiteral(@" width=""330"" height=""400"" alt=""Cropped Faux leather Jacket"" class=""pc__img"">
                                    </a>
                                </div><!-- /.pc__img-wrapper -->
                                <div class=""swiper-slide"">
                                    <a href=""product1_simple.html""><img loading=""lazy""");
            BeginWriteAttribute("src", " src=\"", 5407, "\"", 5465, 2);
            WriteAttributeValue("", 5413, "../images/products/", 5413, 19, true);
            WriteAttributeValue("", 5432, 
#nullable restore
#line 82 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                                                                                item.Photos.ToList()[0].PhotoUrl

#line default
#line hidden
#nullable disable
            , 5432, 33, false);
            EndWriteAttribute();
            WriteLiteral(@" width=""330"" height=""400"" alt=""Cropped Faux leather Jacket"" class=""pc__img""></a>
                                </div><!-- /.pc__img-wrapper -->
                            </div>
                            <span class=""pc__img-prev""><svg width=""7"" height=""11"" viewBox=""0 0 7 11"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_prev_sm"" /></svg></span>
                            <span class=""pc__img-next""><svg width=""7"" height=""11"" viewBox=""0 0 7 11"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_next_sm"" /></svg></span>
                        </div>
                        <a");
            BeginWriteAttribute("href", " href=\"", 6066, "\"", 6111, 2);
            WriteAttributeValue("", 6073, "/Home/product_variable/", 6073, 23, true);
            WriteAttributeValue("", 6096, 
#nullable restore
#line 88 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                         item.ProductId

#line default
#line hidden
#nullable disable
            , 6096, 15, false);
            EndWriteAttribute();
            WriteLiteral(@" class=""pc__atc btn anim_appear-bottom btn position-absolute border-0 text-uppercase fw-medium js-add-cart js-open-aside""
                           data-aside=""cartDrawer"">
                            Quick View
                        </a>
                    </div>

                    <div class=""pc__info position-relative"">
                        <p class=""pc__category"">Dresses</p>
                        <h6 class=""pc__title"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 6589, "\"", 6634, 2);
            WriteAttributeValue("", 6596, "/Home/product_variable/", 6596, 23, true);
            WriteAttributeValue("", 6619, 
#nullable restore
#line 97 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                             item.ProductId

#line default
#line hidden
#nullable disable
            , 6619, 15, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            Write(
#nullable restore
#line 98 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                 item.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                            </a>\r\n                        </h6>\r\n                        <div class=\"product-card__price d-flex\">\r\n                            <span class=\"money price\">$ ");
            Write(
#nullable restore
#line 102 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                         item.ProductPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</span>
                        </div>
                        <div class=""product-card__review d-flex align-items-center"">
                            <div class=""reviews-group d-flex"">
                                <svg class=""review-star"" viewBox=""0 0 9 9"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_star"" /></svg>
                                <svg class=""review-star"" viewBox=""0 0 9 9"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_star"" /></svg>
                                <svg class=""review-star"" viewBox=""0 0 9 9"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_star"" /></svg>
                                <svg class=""review-star"" viewBox=""0 0 9 9"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_star"" /></svg>
                                <svg class=""review-star"" viewBox=""0 0 9 9"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_star"" /></svg>
                            </div>
                            <span class=""reviews-note text-lowercase text-secondar");
            WriteLiteral("y ms-1\">8k+ reviews</span>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 115 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 8098, "\"", 8139, 2);
            WriteAttributeValue("", 8105, "/User/add_wishlist/", 8105, 19, true);
            WriteAttributeValue("", 8124, 
#nullable restore
#line 117 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                                                         item.ProductId

#line default
#line hidden
#nullable disable
            , 8124, 15, false);
            EndWriteAttribute();
            WriteLiteral(@" class=""pc__btn-wl position-absolute top-0 end-0 bg-transparent border-0 js-add-wishlist"" title=""Add To Wishlist"">
                                <svg width=""16"" height=""16"" viewBox=""0 0 20 20"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><use href=""#icon_heart"" /></svg>
                            </a>
");
#nullable restore
#line 120 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 124 "C:\Users\Terlan\source\repos\UOMO\UOMO\Views\Home\Shop.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"

    </div><!-- /.products-grid row -->

    <p class=""mb-1 text-center fw-medium"">SHOWING 36 of 497 items</p>
    <div class=""progress progress_uomo mb-3 ms-auto me-auto"" style=""width: 300px;"">
        <div class=""progress-bar"" role=""progressbar"" style=""width: 39%;"" aria-valuenow=""39"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>

    <div class=""text-center"">
        <a class=""btn-link btn-link_lg text-uppercase fw-medium"" href=""#"">Show More</a>
    </div>
    </section><!-- /.shop-main container -->
</main>

<div class=""mb-5 pb-xl-5""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
