#pragma checksum "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5690889f2e97c829d04e8ac4974e310f8f8e9cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopItem_Index), @"mvc.1.0.view", @"/Views/ShopItem/Index.cshtml")]
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
#line 1 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\_ViewImports.cshtml"
using AutoGlassMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\_ViewImports.cshtml"
using AutoGlassMarket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\_ViewImports.cshtml"
using AutoGlassMarket.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5690889f2e97c829d04e8ac4974e310f8f8e9cf6", @"/Views/ShopItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a60ba13e568d43047a9d946e3145a5fb7b4162", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ShopItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopItemViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5690889f2e97c829d04e8ac4974e310f8f8e9cf64906", async() => {
                WriteLiteral("\r\n   \r\n    <div class=\"row mt-3\">\r\n        <h5>Модель:</h5>\r\n        <select class=\"form-select form-select-sm\" aria-label=\".form-select-sm example\" id=\"Brand\" name=\"Brand\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
             foreach (var item2 in Model.GetBrands)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5690889f2e97c829d04e8ac4974e310f8f8e9cf65647", async() => {
#nullable restore
#line 14 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                       Write(item2.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                   WriteLiteral(item2.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </select>\r\n    </div>\r\n\r\n    <div class=\"row mt-3\">\r\n        <h5>Марка:</h5>\r\n        <select class=\"form-select form-select-sm \" aria-label=\".form-select-sm example\" id=\"Model\" name=\"Model\" ");
#nullable restore
#line 22 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                                                                                            Write(Model.openModel);

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
             foreach (var item2 in Model.GetModels)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5690889f2e97c829d04e8ac4974e310f8f8e9cf68593", async() => {
#nullable restore
#line 26 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                           Write(item2.carModel);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                   WriteLiteral(item2.carModel);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n\r\n    <div class=\"row mt-3\">\r\n        <h5>Номер кузова или рестайлинг:</h5>\r\n        <select class=\"form-select form-select-sm\" aria-label=\".form-select-sm example\" id=\"Cartype\" name=\"Cartype\" ");
#nullable restore
#line 33 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                                                                                               Write(Model.openType);

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
             foreach (var item2 in Model.GetcarType)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5690889f2e97c829d04e8ac4974e310f8f8e9cf611575", async() => {
#nullable restore
#line 37 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                          Write(item2.cartype);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                   WriteLiteral(item2.cartype);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row mt-5  mb-2\" id=\"cars\">\r\n");
#nullable restore
#line 46 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
     foreach (var car in Model.AllCars)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 shadow-sm p-3 mb-5 bg-body rounded\">\r\n            <h2 class=\"text-center\">");
#nullable restore
#line 50 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                               Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                         Write(car.carModel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                                                       Write(car.cartype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1537, "\"", 1559, 1);
#nullable restore
#line 51 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
WriteAttributeValue("", 1543, car.Glasses.img, 1543, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1560, "\"", 1579, 1);
#nullable restore
#line 51 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
WriteAttributeValue("", 1566, car.fullinfo, 1566, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <p>Размер:");
#nullable restore
#line 52 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                 Write(car.size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>Тип кузова: ");
#nullable restore
#line 53 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                      Write(car.bodytype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Cтекло: ");
#nullable restore
#line 54 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                  Write(car.Glasses.typeGlass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Информация: ");
#nullable restore
#line 55 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                      Write(car.fullinfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Цена: ");
#nullable restore
#line 56 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"
                Write(car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#staticBackdropLabel\">Купить</button>\r\n        </div>\r\n");
#nullable restore
#line 60 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\ShopItem\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>




<script src=""https://snipp.ru/cdn/jquery/2.1.1/jquery.min.js""></script>
<script>

    $(document).ready(function() {
        $(""#Brand"").change(function() {

            $("".form1"").submit();
        });
        $(""#Model"").change(function() {

            $("".form1"").submit();
        });
        $(""#Cartype"").change(function() {

            $("".form1"").submit();
        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopItemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
