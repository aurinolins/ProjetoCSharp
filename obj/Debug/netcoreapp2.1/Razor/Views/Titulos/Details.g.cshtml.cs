#pragma checksum "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c0bb9f834278434c547718784f46fa52384ec0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Titulos_Details), @"mvc.1.0.view", @"/Views/Titulos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Titulos/Details.cshtml", typeof(AspNetCore.Views_Titulos_Details))]
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
#line 1 "C:\projetos\project02\app02\app02\Views\_ViewImports.cshtml"
using app02;

#line default
#line hidden
#line 2 "C:\projetos\project02\app02\app02\Views\_ViewImports.cshtml"
using app02.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0bb9f834278434c547718784f46fa52384ec0e", @"/Views/Titulos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7b7a9cf7ea5950de256fbe3032b1de3465624f", @"/Views/_ViewImports.cshtml")]
    public class Views_Titulos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<app02.Models.Entidades.Titulo>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 102, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Titulo</h4>\r\n    <hr />\r\n\t<dl class=\"dl-horizontal\">\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(186, 45, false);
#line 14 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(231, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(254, 41, false);
#line 17 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(295, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(318, 43, false);
#line 20 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(361, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(384, 44, false);
#line 23 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(428, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(451, 41, false);
#line 26 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(492, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(515, 37, false);
#line 29 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(552, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(575, 43, false);
#line 32 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emissao));

#line default
#line hidden
            EndContext();
            BeginContext(618, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(641, 39, false);
#line 35 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emissao));

#line default
#line hidden
            EndContext();
            BeginContext(680, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(703, 46, false);
#line 38 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(749, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(772, 42, false);
#line 41 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(814, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(837, 45, false);
#line 44 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pagamento));

#line default
#line hidden
            EndContext();
            BeginContext(882, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(905, 41, false);
#line 47 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pagamento));

#line default
#line hidden
            EndContext();
            BeginContext(946, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(969, 41, false);
#line 50 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Juros));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(1033, 37, false);
#line 53 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Juros));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(1093, 41, false);
#line 56 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Multa));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(1157, 37, false);
#line 59 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Multa));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(1217, 45, false);
#line 62 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Totalpago));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(1285, 41, false);
#line 65 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Totalpago));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt>\r\n\t\t\t");
            EndContext();
            BeginContext(1349, 42, false);
#line 68 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 22, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd>\r\n\t\t\t");
            EndContext();
            BeginContext(1414, 38, false);
#line 71 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 38, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1490, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f31860d28844f218fc89bdddff4b11b", async() => {
                BeginContext(1536, 4, true);
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
#line 76 "C:\projetos\project02\app02\app02\Views\Titulos\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1544, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1552, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f543af9292437e990237b247de6a83", async() => {
                BeginContext(1574, 12, true);
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
            BeginContext(1590, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<app02.Models.Entidades.Titulo> Html { get; private set; }
    }
}
#pragma warning restore 1591
