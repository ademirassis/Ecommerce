#pragma checksum "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1eab366934a78d529d339c59f3e2aa8846bf57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarrinhoCompras.cshtml", typeof(AspNetCore.Views_Home_CarrinhoCompras))]
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
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1eab366934a78d529d339c59f3e2aa8846bf57", @"/Views/Home/CarrinhoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370b33f587ad063fe86f9aa348ad99eaf4d9b1d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.ItemVenda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DiminuirQuantidade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AumentarQuantidade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverDoCarrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
  
    ViewData["Title"] = "Carrinho de Compras";

#line default
#line hidden
            BeginContext(95, 437, true);
            WriteLiteral(@"
<h2>Carrinho de Compras</h2>

<table style=""margin-top:30px;margin-bottom:30px;text-align:center;"" class=""table table-hover table-stripedS"">
    <thead>
        <tr>
            <th>Imagem</th>
            <th>Produto</th>
            <th></th>
            <th>Quantidade</th>
            <th></th>
            <th>Preço</th>
            <th>Subtotal</th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 24 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(581, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(641, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f3383d92cd24d0a97e7b8e47da71412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 651, "~/images/", 651, 9, true);
#line 28 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
AddHtmlAttributeValue("", 660, item.Produto.Imagem, 660, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
AddHtmlAttributeValue("", 713, item.Produto.Descricao, 713, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(799, 97, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
            EndContext();
            BeginContext(897, 17, false);
#line 33 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
               Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(914, 97, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
            EndContext();
            BeginContext(1011, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831ac06c69a5431c911fd114bd1eda76", async() => {
                BeginContext(1194, 49, true);
                WriteLiteral("\r\n                        -\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
                         WriteLiteral(item.ItemVendaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1247, 97, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
            EndContext();
            BeginContext(1345, 15, false);
#line 44 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
               Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 97, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
            EndContext();
            BeginContext(1457, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28790d48b129452e94986ed7f07a467f", async() => {
                BeginContext(1640, 49, true);
                WriteLiteral("\r\n                        +\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
                         WriteLiteral(item.ItemVendaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1693, 97, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
            EndContext();
            BeginContext(1791, 25, false);
#line 55 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
               Write(item.Preco.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 77, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n");
            EndContext();
#line 58 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
                      
                        double subtotal = item.Preco * item.Quantidade;
                    

#line default
#line hidden
            BeginContext(2013, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2034, 23, false);
#line 61 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
               Write(subtotal.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 97, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
            EndContext();
            BeginContext(2154, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c2e39f67c74d3daf95b9877dde29e6", async() => {
                BeginContext(2339, 55, true);
                WriteLiteral("\r\n                        Remover\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
                         WriteLiteral(item.ItemVendaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2398, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 72 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
        }

#line default
#line hidden
            BeginContext(2453, 136, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"card border-success mb-3\" style=\"max-width: 20rem;\">\r\n    <div class=\"card-header\"><b>Total: </b> ");
            EndContext();
            BeginContext(2590, 36, false);
#line 77 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\Ecommerce\Ecommerce\Views\Home\CarrinhoCompras.cshtml"
                                       Write(ViewBag.TotalCarrinho.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(2626, 14, true);
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.ItemVenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
