#pragma checksum "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e850632fc3329dc431b4a1c82336d568db2832e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\_ViewImports.cshtml"
using MovieApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\_ViewImports.cshtml"
using MovieApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\_ViewImports.cshtml"
using MovieApi.HtmlHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\_ViewImports.cshtml"
using MovieApi.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e850632fc3329dc431b4a1c82336d568db2832e", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770eeec0080a693693d02b7ad789c5e80d2358ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MovieCardPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
 if (@Model.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Search results by title : ");
#nullable restore
#line 9 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <small>Total results :  ");
#nullable restore
#line 10 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                       Write(Model.TotalResults);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </small>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e850632fc3329dc431b4a1c82336d568db2832e6800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 18 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <nav aria-label=\"Page navigation example\" class=\"d-flex align-content-center justify-content-sm-center\">\r\n        <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 23 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
             if (Model.CurrentPage > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e850632fc3329dc431b4a1c82336d568db2832e9245", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieTitle", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                 WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                            WriteLiteral(Model.CurrentPage-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 32 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
            }


            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 63 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
             for (var i = Model.CurrentPage - 4; i <= Model.CurrentPage + 4; i++)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                 if (i > 0 && i < Model.TotalPages)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                     if (Model.CurrentPage == i)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e850632fc3329dc431b4a1c82336d568db2832e13905", async() => {
#nullable restore
#line 75 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                              Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieTitle", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                         WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 77 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e850632fc3329dc431b4a1c82336d568db2832e17859", async() => {
#nullable restore
#line 86 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                              Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieTitle", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                         WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 88 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 93 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
             if (Model.CurrentPage < Model.TotalPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e850632fc3329dc431b4a1c82336d568db2832e22584", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieTitle", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                                 WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
                            WriteLiteral(Model.CurrentPage+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 102 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 107 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Not results!</h1>\r\n");
#nullable restore
#line 112 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\Movie Api Pagination\Movie-Api-Pagination\MovieApi\Views\Home\Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
