#pragma checksum "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d62940c71b40dc259378fc11318fce81bf63045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__PizzaMessage), @"mvc.1.0.view", @"/Views/Shared/Partials/_PizzaMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/_PizzaMessage.cshtml", typeof(AspNetCore.Views_Shared_Partials__PizzaMessage))]
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
#line 1 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#line 2 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#line 3 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models.Domain;

#line default
#line hidden
#line 4 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d62940c71b40dc259378fc11318fce81bf63045", @"/Views/Shared/Partials/_PizzaMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626ca6f8bfa464c7bf0f0ba0abd9c2a7733d49e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__PizzaMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 9, true);
            WriteLiteral("\n\n<p>Id: ");
            EndContext();
            BeginContext(39, 8, false);
#line 4 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml"
  Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(47, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
            BeginContext(168, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(171, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9113dd3460534cac9b9cacc376751701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 7 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PizzaName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(209, 33, false);
#line 7 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml"
                                   Write(Html.DisplayFor(x => x.PizzaName));

#line default
#line hidden
            EndContext();
            BeginContext(242, 24, true);
            WriteLiteral("</p>\n<p>Payment Method: ");
            EndContext();
            BeginContext(267, 19, false);
#line 8 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml"
              Write(Model.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(286, 14, true);
            WriteLiteral("</p>\n<p>User: ");
            EndContext();
            BeginContext(302, 31, false);
#line 9 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml"
     Write($"Mr/Mrs: {Model.UserFullName}");

#line default
#line hidden
            EndContext();
            BeginContext(334, 26, true);
            WriteLiteral("</p>\n<p>Price + Delivery: ");
            EndContext();
            BeginContext(362, 38, false);
#line 10 "E:\Seavus\8.MVC\HomeWork (5)\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_PizzaMessage.cshtml"
                 Write(Model.Price + Model.Price*(decimal)0.1);

#line default
#line hidden
            EndContext();
            BeginContext(401, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591