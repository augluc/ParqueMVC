#pragma checksum "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794f0abc1a49d580c07d4111b063d4286e667ff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brinquedo_Atividade), @"mvc.1.0.view", @"/Views/Brinquedo/Atividade.cshtml")]
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
#line 1 "C:\Users\lassis\Documents\csharp\Exp3\Views\_ViewImports.cshtml"
using Exp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lassis\Documents\csharp\Exp3\Views\_ViewImports.cshtml"
using Exp3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794f0abc1a49d580c07d4111b063d4286e667ff5", @"/Views/Brinquedo/Atividade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4418fcd6095b4f154948008b9275e0f303cc840", @"/Views/_ViewImports.cshtml")]
    public class Views_Brinquedo_Atividade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Brinquedo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "colaboradorId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Adicionar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Exp3.TagHelpers.MsgTagHelper __Exp3_TagHelpers_MsgTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
  
    ViewData["Title"] = "Atividade";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge  badge-primary rounded-pill\">");
#nullable restore
#line 6 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
                                                           Write(Model.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("msg", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f0abc1a49d580c07d4111b063d4286e667ff55599", async() => {
            }
            );
            __Exp3_TagHelpers_MsgTagHelper = CreateTagHelper<global::Exp3.TagHelpers.MsgTagHelper>();
            __tagHelperExecutionContext.Add(__Exp3_TagHelpers_MsgTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
WriteLiteral(TempData["msg"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Exp3_TagHelpers_MsgTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", __Exp3_TagHelpers_MsgTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Valor</th>\r\n        <th>Data de Fabricação</th>\r\n        <th>Tipo</th>\r\n        <th>Precisa de Acompanhante</th>\r\n        <th>Manutenção</th>\r\n    </tr>\r\n    <tr>\r\n        <th>");
#nullable restore
#line 18 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
       Write(Model.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 19 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
       Write(Model.DataFabricacao.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 20 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
       Write(Model.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 21 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
        Write(Model.PrecisaAcompanhante?"Sim":"Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 22 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
       Write(Model.Manutencao?.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n</table>\r\n\r\n<hr />\r\n\r\n<h2>Colaborador</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f0abc1a49d580c07d4111b063d4286e667ff58559", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"brinquedoId\"");
                BeginWriteAttribute("value", " value=\"", 794, "\"", 820, 1);
#nullable restore
#line 30 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
WriteAttributeValue("", 802, Model.BrinquedoId, 802, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f0abc1a49d580c07d4111b063d4286e667ff59245", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794f0abc1a49d580c07d4111b063d4286e667ff59521", async() => {
                        WriteLiteral("\r\n            Selecione\r\n        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 31 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.colaboradoresSelectList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <input type=\"datetime-local\" name=\"data\" class=\"form-control mr-2\" />\r\n    <input type=\"submit\" value=\"Adicionar\" class=\"btn btn-outline-secondary\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<ul class=\"list-group mt-2\">\r\n");
#nullable restore
#line 41 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
     foreach (BrinquedoColaborador bc in ViewBag.colaborador)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">");
#nullable restore
#line 43 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
                               Write(bc.Colaborador.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 43 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
                                                      Write(bc.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 44 "C:\Users\lassis\Documents\csharp\Exp3\Views\Brinquedo\Atividade.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Brinquedo> Html { get; private set; }
    }
}
#pragma warning restore 1591
