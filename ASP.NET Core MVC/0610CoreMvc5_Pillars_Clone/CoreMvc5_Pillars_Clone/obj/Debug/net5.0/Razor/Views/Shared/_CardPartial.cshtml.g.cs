#pragma checksum "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "733594fdff45012f3e8bb9d1ee5e7d3334058f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CardPartial), @"mvc.1.0.view", @"/Views/Shared/_CardPartial.cshtml")]
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
#line 1 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\_ViewImports.cshtml"
using CoreMvc5_Pillars_Clone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\_ViewImports.cshtml"
using CoreMvc5_Pillars_Clone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
using CoreMvc5_Pillars_Clone.ViewsModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733594fdff45012f3e8bb9d1ee5e7d3334058f85", @"/Views/Shared/_CardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8115cd87e383de36cf1f46bd57d854ead2742cb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClothingViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
  
    var cloth = (ClothingViewModel)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 147, "\"", 172, 1);
#nullable restore
#line 7 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
WriteAttributeValue("", 153, Model.ProductPhoto, 153, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 194, "\"", 219, 1);
#nullable restore
#line 7 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
WriteAttributeValue("", 200, Model.ProductPhoto, 200, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733594fdff45012f3e8bb9d1ee5e7d3334058f854952", async() => {
                WriteLiteral("\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
                              Write(Model.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 269, "~/Clothing/Details/", 269, 19, true);
#nullable restore
#line 9 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
AddHtmlAttributeValue("", 288, Model.Id, 288, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\User\Desktop\BuildSchool\git\lazyorangecat.github.io\ASP.NET Core MVC\0610CoreMvc5_Pillars_Clone\CoreMvc5_Pillars_Clone\Views\Shared\_CardPartial.cshtml"
                        Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClothingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
