#pragma checksum "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f0292abd47776773cd050fe4696adb78f1cbb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_ListTable), @"mvc.1.0.view", @"/Views/Members/ListTable.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\_ViewImports.cshtml"
using _0524FirstMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\_ViewImports.cshtml"
using _0524FirstMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f0292abd47776773cd050fe4696adb78f1cbb2", @"/Views/Members/ListTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec6d5b361b7f608b20dabaf9aa1c82dd3399263", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_ListTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_0524FirstMVC.Models.Member>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
  
    ViewData["Title"] = "ListTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListTable</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f0292abd47776773cd050fe4696adb78f1cbb24881", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Brief));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.FuturePlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Brief));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1812, "\"", 1830, 1);
#nullable restore
#line 64 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
WriteAttributeValue("", 1819, item.Photo, 1819, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-lightbox=\"gallery\" data-title=\"");
#nullable restore
#line 64 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 64 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
                                                                                      Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1929, "\"", 1946, 1);
#nullable restore
#line 65 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
WriteAttributeValue("", 1935, item.Photo, 1935, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.FuturePlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f0292abd47776773cd050fe4696adb78f1cbb215843", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
                                           WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f0292abd47776773cd050fe4696adb78f1cbb218088", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f0292abd47776773cd050fe4696adb78f1cbb220339", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 92 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\ListTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("topCSS", async() => {
                WriteLiteral("\r\n<style>\r\n    img {\r\n        width: 100px;\r\n        height: 100px;\r\n    }\r\n</style>\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/lightbox2/2.11.3/js/lightbox.min.js"" integrity=""sha512-k2GFCTbp9rQU412BStrcD/rlwv1PYec9SNrkbQlo6RZCf75l6KcC3UwDY8H5n5hl4v77IDtIPwOk9Dqjs/mMBQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_0524FirstMVC.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
