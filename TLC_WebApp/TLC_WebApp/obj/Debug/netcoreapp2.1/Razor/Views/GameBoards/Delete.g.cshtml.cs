#pragma checksum "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e60e5dc216355b710626032dea73ff8348b51ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameBoards_Delete), @"mvc.1.0.view", @"/Views/GameBoards/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GameBoards/Delete.cshtml", typeof(AspNetCore.Views_GameBoards_Delete))]
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
#line 1 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\_ViewImports.cshtml"
using TLC_WebApp;

#line default
#line hidden
#line 2 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\_ViewImports.cshtml"
using TLC_WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e60e5dc216355b710626032dea73ff8348b51ef", @"/Views/GameBoards/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec9096a1e2d91caa01f545cb2c7aa07b10dfeed", @"/Views/_ViewImports.cshtml")]
    public class Views_GameBoards_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLC_WebApp.Models.GameBoard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(80, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>GameBoard</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(251, 43, false);
#line 15 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TopLeft));

#line default
#line hidden
            EndContext();
            BeginContext(294, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(338, 39, false);
#line 18 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TopLeft));

#line default
#line hidden
            EndContext();
            BeginContext(377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(421, 45, false);
#line 21 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TopMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(510, 41, false);
#line 24 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TopMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(595, 44, false);
#line 27 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TopRight));

#line default
#line hidden
            EndContext();
            BeginContext(639, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(683, 40, false);
#line 30 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TopRight));

#line default
#line hidden
            EndContext();
            BeginContext(723, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(767, 46, false);
#line 33 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleLeft));

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(857, 42, false);
#line 36 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MiddleLeft));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(943, 48, false);
#line 39 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1035, 44, false);
#line 42 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MiddleMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1123, 47, false);
#line 45 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleRight));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1214, 43, false);
#line 48 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MiddleRight));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1301, 46, false);
#line 51 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BottomLeft));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1391, 42, false);
#line 54 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BottomLeft));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1477, 48, false);
#line 57 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BottomMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1569, 44, false);
#line 60 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BottomMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1657, 47, false);
#line 63 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BottomRight));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1748, 43, false);
#line 66 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BottomRight));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1829, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c2d466db2b4098b538ecf83db03e9b", async() => {
                BeginContext(1855, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1865, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0256e6d93884b63b62e280a90a0188f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1901, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1985, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c461d416a38a41778288049606914dd4", async() => {
                    BeginContext(2007, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2023, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2036, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TLC_WebApp.Models.GameBoard> Html { get; private set; }
    }
}
#pragma warning restore 1591
