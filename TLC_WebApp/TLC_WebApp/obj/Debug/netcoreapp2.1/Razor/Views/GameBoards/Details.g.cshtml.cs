#pragma checksum "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3b5344c513e9a82850da830b2079225c3318c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameBoards_Details), @"mvc.1.0.view", @"/Views/GameBoards/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GameBoards/Details.cshtml", typeof(AspNetCore.Views_GameBoards_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3b5344c513e9a82850da830b2079225c3318c7", @"/Views/GameBoards/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec9096a1e2d91caa01f545cb2c7aa07b10dfeed", @"/Views/_ViewImports.cshtml")]
    public class Views_GameBoards_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TLC_WebApp.Models.GameBoard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>GameBoard</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 43, false);
#line 14 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TopLeft));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 39, false);
#line 17 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.TopLeft));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 45, false);
#line 20 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TopMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 41, false);
#line 23 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.TopMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(549, 44, false);
#line 26 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TopRight));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(637, 40, false);
#line 29 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.TopRight));

#line default
#line hidden
            EndContext();
            BeginContext(677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(721, 46, false);
#line 32 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleLeft));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(811, 42, false);
#line 35 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleLeft));

#line default
#line hidden
            EndContext();
            BeginContext(853, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(897, 48, false);
#line 38 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(945, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(989, 44, false);
#line 41 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1077, 47, false);
#line 44 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleRight));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1168, 43, false);
#line 47 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleRight));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1255, 46, false);
#line 50 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BottomLeft));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1345, 42, false);
#line 53 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.BottomLeft));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1431, 48, false);
#line 56 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BottomMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1523, 44, false);
#line 59 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.BottomMiddle));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1611, 47, false);
#line 62 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BottomRight));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1702, 43, false);
#line 65 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
       Write(Html.DisplayFor(model => model.BottomRight));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1792, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcbe064d84b640fcb339809c5a60d8c4", async() => {
                BeginContext(1838, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Inspiron 15 5000\Desktop\Assignments\ASP.NET\TLC-Assignment\TLC_WebApp\TLC_WebApp\Views\GameBoards\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1846, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1854, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0d165df94a6450abbd394db1c5c0cd4", async() => {
                BeginContext(1876, 12, true);
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
            BeginContext(1892, 10, true);
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
