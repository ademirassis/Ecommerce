#pragma checksum "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa867db7af6c7bc15783d9a0f5fda7fa2d959ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Alterar), @"mvc.1.0.view", @"/Views/Produto/Alterar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Alterar.cshtml", typeof(AspNetCore.Views_Produto_Alterar))]
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
#line 1 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa867db7af6c7bc15783d9a0f5fda7fa2d959ee", @"/Views/Produto/Alterar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Alterar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml"
  
    Produto produto  = ViewBag.Produto;

#line default
#line hidden
            BeginContext(48, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(77, 449, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca97dfb03ba4ae8814e724782de5e00", async() => {
                BeginContext(83, 436, true);
                WriteLiteral(@"
    <!-- Meta tags Obrigatórias -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">

    <title>Alterar</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(526, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(528, 1797, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88cddcc2f4584484b8e89b5f0a0d14f1", async() => {
                BeginContext(534, 70, true);
                WriteLiteral("\r\n    <h1>Alterar Produto</h1>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(604, 988, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78383447660546979ec4bd193b11924e", async() => {
                    BeginContext(645, 123, true);
                    WriteLiteral("\r\n            <!-- se necessário, pesquisar por \"Tag helper\" -->\r\n            <input type=\"hidden\" name=\"txtId\" readonly=\"\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 768, "\"", 794, 1);
#line 23 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 776, produto.ProdutoId, 776, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(795, 139, true);
                    WriteLiteral(" />\r\n\r\n            <label class=\"col-sm-2 col-form-label\">Nome:</label>\r\n            <input class=\"form-control\" type=\"text\" name=\"txtNome\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 934, "\"", 955, 1);
#line 26 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 942, produto.Nome, 942, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(956, 149, true);
                    WriteLiteral(" />\r\n\r\n            <label class=\"col-sm-2 col-form-label\">Descrição:</label>\r\n            <input class=\"form-control\" type=\"text\" name=\"txtDescricao\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1105, "\"", 1131, 1);
#line 29 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 1113, produto.Descricao, 1113, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1132, 141, true);
                    WriteLiteral(" />\r\n\r\n            <label class=\"col-sm-2 col-form-label\">Preço:</label>\r\n            <input class=\"form-control\" type=\"text\" name=\"txtPreco\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1273, "\"", 1295, 1);
#line 32 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 1281, produto.Preco, 1281, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1296, 151, true);
                    WriteLiteral(" />\r\n\r\n            <label class=\"col-sm-2 col-form-label\">Quantidade:</label>\r\n            <input class=\"form-control\" type=\"text\" name=\"txtQuantidade\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1447, "\"", 1474, 1);
#line 35 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 1455, produto.Quantidade, 1455, 19, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1475, 110, true);
                    WriteLiteral(" />\r\n\r\n            <button type=\"submit\" value=\"Salvar\" class=\"btn btn-primary mb-2\">Salvar</button>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1592, 726, true);
                WriteLiteral(@"
    </div>

    <!-- JavaScript (Opcional) -->
    <!-- jQuery primeiro, depois Popper.js, depois Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2325, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
