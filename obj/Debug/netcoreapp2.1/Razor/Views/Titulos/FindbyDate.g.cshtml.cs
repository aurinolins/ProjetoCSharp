#pragma checksum "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3095e5bfa959d8d0164164dcfce6ff4298b342ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Titulos_FindbyDate), @"mvc.1.0.view", @"/Views/Titulos/FindbyDate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Titulos/FindbyDate.cshtml", typeof(AspNetCore.Views_Titulos_FindbyDate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3095e5bfa959d8d0164164dcfce6ff4298b342ff", @"/Views/Titulos/FindbyDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7b7a9cf7ea5950de256fbe3032b1de3465624f", @"/Views/_ViewImports.cshtml")]
    public class Views_Titulos_FindbyDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<app02.Models.Entidades.Titulo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
  
	ViewData["Title"] = "BuscabyDate";
	ViewData["dataini"] = DateTime.Now;
	ViewData["datafim"] = DateTime.Now;

#line default
#line hidden
            BeginContext(171, 97, true);
            WriteLiteral("\r\n<h2>BuscabyDate</h2>\r\n\r\n<nav class=\"navbar navbar-inversa\">\r\n\t<div class=\"container.fluid\">\r\n\t\t");
            EndContext();
            BeginContext(268, 530, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667cadc741514a47bc262e865c3421b7", async() => {
                BeginContext(320, 168, true);
                WriteLiteral("\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"dataini\">Data Inicial</label>\r\n\t\t\t\t\t<input type=\"date\" class=\"form-control\" name=\"dataini\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 488, "", 515, 1);
#line 16 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
WriteAttributeValue("", 495, ViewData["dataini"], 495, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(515, 152, true);
                WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<label for=\"datafim\">Data Final</label>\r\n\t\t\t\t\t<input type=\"date\" class=\"form-control\" name=\"datafim\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 667, "", 694, 1);
#line 20 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
WriteAttributeValue("", 674, ViewData["datafim"], 674, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(694, 97, true);
                WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\t\t\t\t<button type=\"submit\" class=\"btn btn-primary\">Filtro</button>\r\n\t\t\t</div>\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(798, 75, true);
            WriteLiteral("\r\n\t</div>\r\n</nav>\r\n\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(874, 45, false);
#line 32 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
           Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(919, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(945, 41, false);
#line 35 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(986, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1012, 43, false);
#line 38 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
           Write(Html.DisplayNameFor(model => model.Emissao));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1081, 46, false);
#line 41 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
           Write(Html.DisplayNameFor(model => model.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1153, 43, false);
#line 44 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
           Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1222, 42, false);
#line 47 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 56, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 53 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(1357, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1382, 44, false);
#line 57 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1455, 40, false);
#line 60 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1524, 42, false);
#line 63 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Emissao));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1595, 45, false);
#line 66 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1669, 47, false);
#line 69 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1745, 41, false);
#line 72 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 23, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 75 "C:\projetos\project02\app02\app02\Views\Titulos\FindbyDate.cshtml"
		}

#line default
#line hidden
            BeginContext(1814, 20, true);
            WriteLiteral("\t</tbody>\r\n\t<tr>\r\n\t\t");
            EndContext();
            BeginContext(1834, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cea5162da4f84243bf4be6de4dfbc946", async() => {
                BeginContext(1856, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1872, 20, true);
            WriteLiteral(" |\r\n\t</tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<app02.Models.Entidades.Titulo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
