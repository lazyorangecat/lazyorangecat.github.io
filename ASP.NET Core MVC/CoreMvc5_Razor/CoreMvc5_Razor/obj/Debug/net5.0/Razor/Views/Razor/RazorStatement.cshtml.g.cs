#pragma checksum "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\Razor\RazorStatement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa01fdf38dd74a237fb305b9b5974c5fe8b0577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Razor_RazorStatement), @"mvc.1.0.view", @"/Views/Razor/RazorStatement.cshtml")]
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
#line 1 "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\_ViewImports.cshtml"
using CoreMvc5_Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\_ViewImports.cshtml"
using CoreMvc5_Razor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa01fdf38dd74a237fb305b9b5974c5fe8b0577", @"/Views/Razor/RazorStatement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5ff644d7928cdeaf6dbc9300610059fd5beee6", @"/Views/_ViewImports.cshtml")]
    public class Views_Razor_RazorStatement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\Razor\RazorStatement.cshtml"
  
    ViewData["Title"] = "RazorStatement";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RazorStatement</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\Razor\RazorStatement.cshtml"
  
    var score = 79;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 31 "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\Razor\RazorStatement.cshtml"
  
    string ScoreComment(int score)
    {
        string comment = "";

        switch (score)
        {
            case int s when s <= 60:
                comment = $"{s}?????????????????????!";
                break;
            case int s when s >= 60 && s < 85:
                comment = $"{score}?????????????????????????????????.";
                break;
            case int s when s >= 85 && s < 95:
                comment = $"{score}?????????????????????????????????.";
                break;
            default:
                comment = $"{score}????????????????????????????????????";
                break;
        }

        return comment;
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 55 "C:\SourceCodeLab\BuildSchool202203NCU\CoreMvc5\CoreMvc5_Razor\CoreMvc5_Razor\Views\Razor\RazorStatement.cshtml"
Write(ScoreComment(score));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
