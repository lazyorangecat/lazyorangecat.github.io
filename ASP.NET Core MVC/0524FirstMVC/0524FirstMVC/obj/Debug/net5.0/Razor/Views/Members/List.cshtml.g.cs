#pragma checksum "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4550dee86fd1771c14eafcb352ca80f7217ef0b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_List), @"mvc.1.0.view", @"/Views/Members/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4550dee86fd1771c14eafcb352ca80f7217ef0b4", @"/Views/Members/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec6d5b361b7f608b20dabaf9aa1c82dd3399263", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\List.cshtml"
  
    string teamName = "第一組";

    //C#
    string jsonMembers = (string)ViewData["jsonMembers"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Member List成員列表 : ");
#nullable restore
#line 7 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\List.cshtml"
                 Write(teamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>");
#nullable restore
#line 9 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\List.cshtml"
Write(jsonMembers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\'row\'>\r\n</div>\r\n\r\n<template id=\"cardTemplate\">\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 288, "\"", 294, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"" alt=""..."">
        <div class=""card-body"">
            <h5 class=""card-title""></h5>
            <p class=""card-text""></p>
            <a href=""#"" class=""btn btn-primary"">詳細內容</a>
        </div>
    </div>
</template>


<script>
    var membersArray = ");
#nullable restore
#line 27 "C:\Users\User\OneDrive\桌面\BuildSchool\git\lazyorangecat.github.io\XiJiangHua ASP.NET Core MVC\0524FirstMVC\0524FirstMVC\Views\Members\List.cshtml"
                  Write(Html.Raw(jsonMembers));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    let row, cardTemplate ;

    window.onload=function(){
        row = document.querySelector("".row"");
        cardTemplate  = document.querySelector(""#cardTemplate"");

        membersArray.forEach((member, index)=>{
            row.append(getCard(member.Name, member.Photo));
        });
    }

    function getCard(title, imgurl) {
        let cloneCard = cardTemplate.content.cloneNode(true);

        cloneCard.querySelector(""img"").src = imgurl;
        cloneCard.querySelector(""h5"").innerHTML = title;

        cloneCard.querySelector("".btn"").addEventListener(""click"",function(){
            alert(title);
        });

        return cloneCard;
    }

    function getCardString(title, imgurl, price) {
        let card = `<div class=""card"" style=""width: 18rem;"">`;
        card += `<img src=""${imgurl}"" class=""card-img-top"" alt=""..."">`;
        card += `<div class=""card-body"">`;
        card += `<h5 class=""card-title"">${title}</h5>`;
        card += `<h5 class=""card-title"">NT ${p");
            WriteLiteral("rice}</h5>`;\r\n        card += `</div>`;\r\n        card += `</div>`;\r\n\r\n        return card;\r\n    }\r\n</script>\r\n");
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
