#pragma checksum "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecfdbc7bef47757315e784abad9163a660d7c7b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecfdbc7bef47757315e784abad9163a660d7c7b6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a60ba13e568d43047a9d946e3145a5fb7b4162", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopItemViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("validationCustom01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "89", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<p class=""text-center display-5 fw-bold "">Выбрать тип стекла</p>

<div class=""card-group row mt-5"">
    <div class=""card shadow-lg p-3 mb-5 bg-body rounded"">
        <h5 class=""text-center card-title"">Лобовое стекло</h5>
        <a href=""/ShopItem/Index/1""><img src=""/img/TitelGlass.jpg"" class=""card-img-top"" alt=""...""></a>
        <div class=""card-body"">
            <a href=""/ShopItem/Index/1"" type=""button"" class=""btn btn-primary btn-lg"">Смотреть лобовые стекла</a>
        </div>
    </div>
    <div class=""card shadow-lg p-3 mb-5 bg-body rounded ms-1"">
        <h5 class=""text-center card-title"">Боковое стекло</h5>
        <a href=""/ShopItem/Index/2""><img src=""/img/Side.jpg"" class=""card-img-top"" alt=""...""></a>
        <div class=""card-body"">
            <a href=""/ShopItem/Index/2"" type=""button"" class=""btn btn-primary btn-lg"">Смотреть боковые стекла</a>
        </div>
    </div>
    <div class=""card shadow-lg p-3 mb-5 bg-body rounded ms-1"">
        <h5 class=""text-center card-title"">Заднее ст");
            WriteLiteral(@"екло</h5>
        <a href=""/ShopItem/Index/3""><img src=""/img/back.jpg"" class=""card-img-top"" alt=""...""></a>
        <div class=""card-body"">
            <a href=""/ShopItem/Index/3"" type=""button"" class=""btn btn-primary btn-lg"">Смотреть заднии стекла</a>
        </div>
    </div>
</div>


<div class=""shadow-sm p-3 mb-5 bg-body rounded"">
    <div class=""row featurette"">
        <div class=""col-md-7"">
            <h2 class=""featurette-heading fw-semibold lh-2""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Быстрая замена стекла,</font></font><span class=""text-muted""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;""> </font>на любом виде транспорта.</font></span></h2>
            <p class=""lead""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">✓ Мы тщательно зачищаем рамку авто и используем только качественные материалы, благодаря этому машиной можно пользоваться сразу после установки. </font><font style=""vertical-al");
            WriteLiteral(@"ign: inherit;""></font></font></p>
            <p class=""lead""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">✓ Мы даем гарантию на установку и принимаем все необходимые меры вплоть до полной переустановки стекла.</font><font style=""vertical-align: inherit;""></font></font></p>
            <p class=""lead""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">✓ Имеем тысячи довольных клиентов</font><font style=""vertical-align: inherit;""></font></font></p>
        </div>

        <div class=""col-md-5"">
            <img src=""img/zamena2.png"" class=""bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
        </div>
    </div>

    <hr class=""featurette-divider"">

    <div class=""row featurette"">
        <div class=""col-md-5 order-md-2"">
            <h2 class=""featurette-heading fw-semibol lh-2""><font style=""vertical-align: inherit;""><font style=""vertical-align: inheri");
            WriteLiteral(@"t;"">Широкий ассортимент, </font></font><span class=""text-muted""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">на все модели</font></font></span></h2>
            <p class=""lead""><font style=""vertical-align: inherit;"">✓Стекла всех видов на любой автомобиль (от трактора до легкового авто), по лучшей цене<font style=""vertical-align: inherit;""></font><font style=""vertical-align: inherit;""></font></font></p>
            <p class=""lead""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">✓Большой выбор производителей стекла</font><font style=""vertical-align: inherit;""></font></font></p>
            <p class=""lead""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">✓В налиичии стекла практически на каждый автомобиль</font><font style=""vertical-align: inherit;""></font></font></p>
        </div>

        <div class=""col-md-5 order-md-1"">
            <img src=""/img/Vibor1.png"" class=""bd-placeholder-img bd-placeholder-img-lg feat");
            WriteLiteral(@"urette-image img-fluid mx-auto"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
        </div>
    </div>

    <hr class=""featurette-divider"">
    <h2 class=""featurette-heading fw-semibol lh-3 text-center""><span class=""text-muted""><font style=""vertical-align: inherit;"">Для покупки продукции или замены стекла</font></span></h2>


    <p class=""lead"">
        <font style=""vertical-align: inherit;"">
            Вы можете оформить заказ через сайт и получить подтверждение заказа.
            <br> Или оформить заказ позвонив по телефону <strong>+7(903)-644-44-40</strong>. Вы можете оставить заявку на подбор стекла - менеджер вам перезвонит и поможет зафиксировать детали заказа.
        </font>
    </p>
</div>


<img class=""img-fluid"" src=""/img/downV.png"">
<div class=""container py-4"">

    <div class=""p-2 mb-4 bg-light rounded-3 shadow-lg p-3 mb-5"">
        <div class=""container-fluid"">
            <h1 class=""display-5 fw-bold""><font style=""vertical-align: inherit;""><font style=""vertic");
            WriteLiteral(@"al-align: inherit;"">Замена лобового стекла</font></font></h1>
             <hr class=""featurette-divider"">
            <p class=""col-md-8 fs-4"">
                <font style=""vertical-align: inherit;"">
                    <font style=""vertical-align: inherit;"">
                        Процедура замены:<br>↶ Снятие дворников, молдингов и резинок, демонтаж отдельных элементов обшивки, чтобы избежать повреждений и загрязнений клеем.<br>⤹Снятие стекла при помощи спец инструмента.
                        <br>⤿После срезки стекла, полное удалени старого клея и зачистка рамки.<br>⮍Обезжириваем в месте установки и само стекло по периметру, нанесение праймера.<br>⥀ Нанесение клея и далее само вклеивание стекла
                    </font>
                </font>
            </p>
            <hr class=""featurette-divider"">
            <h1 class=""display-8 ""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">от 1500руб</font></font></h1>
            <hr class=""featurette-divider"">
 ");
            WriteLiteral(@"           <button class=""btn btn-primary btn-lg"" type=""button"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdropLabel1""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Заказать услугу</font></font></button>
        </div>
    </div>

    <div class=""row align-items-md-stretch "">
        <div class=""col-md-6"">
            <div class=""h-100 p-5 text-white bg-dark rounded-3 shadow-lg p-3 mb-5"">
                <h2><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Замена заднего стекла</font></font></h2>
                 <hr class=""featurette-divider"">
                <p>
                    <font style=""vertical-align: inherit;"">
                        <font style=""vertical-align: inherit;"">
                            Процедура замены:<br>Снятие дворников, молдингов и резинок, демонтаж отдельных элементов обшивки, чтобы избежать повреждений и загрязнений клеем.<br>Удаление осколков разбитого стекла, если стекло цело, то демонтаж путем ");
            WriteLiteral(@"среза .
                            <br> После срезки стекла, полное удалени старого клея и зачистка рамки. Обезжириваем в месте установки и само стекло по периметру, нанесение праймера.<br>Нанесение клея и далее само вклеивание стекла
                        </font>
                    </font>
                </p>
                <hr class=""featurette-divider"">
                <h1 class=""display-8 ""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">от 1500руб</font></font></h1>
                <hr class=""featurette-divider"">
                <button class=""btn btn-outline-light"" type=""button"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdropLabel1""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Заказать услугу</font></font></button>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""h-100 p-5 bg-light border rounded-3 shadow-lg p-3 mb-5"">
                <h2><font style=""vertical-align: inherit;""");
            WriteLiteral(@"><font style=""vertical-align: inherit;"">Замена боковых стекол</font></font></h2>
                 <hr class=""featurette-divider"">
                <p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Или сделайте его легким и добавьте границу для дополнительного определения границ вашего контента. </font><font style=""vertical-align: inherit;"">Не забудьте заглянуть под капот исходного HTML здесь, так как мы отрегулировали выравнивание и размер содержимого обоих столбцов для одинаковой высоты.</font></font></p>
                <hr class=""featurette-divider"">
                <h1 class=""display-8 ""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">от 500руб</font></font></h1>
                <hr class=""featurette-divider"">
                <button class=""btn btn-outline-secondary"" type=""button"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdropLabel1""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Заказать услугу</font>");
            WriteLiteral(@"</font></button>     
            </div>
        </div>
    </div>
</div>

<img class=""img-fluid"" src=""/img/downV1.png"">

<div class=""card-group row mt-5 "">
    <div class=""card shadow-lg p-3 mb-5 bg-body rounded"">
        <h5 class=""text-center card-title"">Лобовое стекло</h5>
        <a href=""/ShopItem/Index/1""><img src=""/img/TitelGlass.jpg"" class=""card-img-top"" alt=""...""></a>
        <div class=""card-body"">
            <a href=""/ShopItem/Index/1"" type=""button"" class=""btn btn-primary btn-lg"">Смотреть лобовые стекла</a>
        </div>
    </div>
    <div class=""card shadow-lg p-3 mb-5 bg-body rounded ms-1"">
        <h5 class=""text-center card-title"">Боковое стекло</h5>
        <a href=""/ShopItem/Index/2""><img src=""/img/Side.jpg"" class=""card-img-top"" alt=""...""></a>
        <div class=""card-body"">
            <a href=""/ShopItem/Index/2"" type=""button"" class=""btn btn-primary btn-lg"">Смотреть боковые стекла</a>
        </div>
    </div>
    <div class=""card shadow-lg p-3 mb-5 bg-body rounded");
            WriteLiteral(@" ms-1"">
        <h5 class=""text-center card-title"">Заднее стекло</h5>
        <a href=""/ShopItem/Index/3""><img src=""/img/back.jpg"" class=""card-img-top"" alt=""...""></a>
        <div class=""card-body"">
            <a href=""/ShopItem/Index/3"" type=""button"" class=""btn btn-primary btn-lg"">Смотреть заднии стекла</a>
        </div>
    </div>
</div>
  
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b617660", async() => {
                WriteLiteral(@"
    <div class=""modal fade"" tabindex=""-1"" id=""staticBackdropLabel1"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" aria-labelledby=""staticBackdropLabe1l"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""staticBackdropLabel1"">Modal title</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b618540", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 162 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <label for=\"validationCustom01\" class=\"control-label\">Как к вам обращаться?</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecfdbc7bef47757315e784abad9163a660d7c7b620402", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 165 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b622416", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 166 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"invalid-feedback\">\r\n                        Введите имя\r\n                    </div>\r\n                    <div class=\"modal-body\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b624301", async() => {
                    WriteLiteral("Номер телефона");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 172 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecfdbc7bef47757315e784abad9163a660d7c7b625966", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 173 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b627780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 174 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"modal-body\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b629546", async() => {
                    WriteLiteral("Комментарий");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 178 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductInformation);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecfdbc7bef47757315e784abad9163a660d7c7b631216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 179 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductInformation);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfdbc7bef47757315e784abad9163a660d7c7b632830", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 180 "C:\Users\Павел\source\repos\AutoGlassMarket\AutoGlassMarket\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductInformation);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        <div class=\"form-check\">\r\n                            <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 12714, "\"", 12722, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""invalidCheck"" required>
                            <label class=""form-check-label"" for=""invalidCheck"">
                                Согласен на обработку данных
                            </label>
                            <div class=""invalid-feedback"">
                                You must agree before submitting.
                            </div>
                        </div>

                        <div class=""mt-3"">Наш номер телефона +7 (903)-644-44-40</div>

                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Закрыть</button>
                            <button type=""submit"" class=""btn btn-primary"">Заказать звонок</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
