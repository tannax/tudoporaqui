#pragma checksum "/home/krux/Documents/SENAC PDFs/ModuloII/UC08/atvIII/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e60d401f4877a6d4a2d4eb083b3730e1380e5fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/krux/Documents/SENAC PDFs/ModuloII/UC08/atvIII/Views/_ViewImports.cshtml"
using atvIII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/krux/Documents/SENAC PDFs/ModuloII/UC08/atvIII/Views/_ViewImports.cshtml"
using atvIII.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60d401f4877a6d4a2d4eb083b3730e1380e5fba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be331e7b6257c089efe8ac02413b1d95be677f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Views/React/Navbar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/react.production.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/react-dom.production.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/krux/Documents/SENAC PDFs/ModuloII/UC08/atvIII/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Tudo Por Aqui";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/krux/Documents/SENAC PDFs/ModuloII/UC08/atvIII/Views/Home/Index.cshtml"
Write(ViewData["Home"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/home/krux/Documents/SENAC PDFs/ModuloII/UC08/atvIII/Views/Home/Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"navbar\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60d401f4877a6d4a2d4eb083b3730e1380e5fba4751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60d401f4877a6d4a2d4eb083b3730e1380e5fba5776", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60d401f4877a6d4a2d4eb083b3730e1380e5fba6801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60d401f4877a6d4a2d4eb083b3730e1380e5fba7826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
  ReactDOM.render(
    React.createElement(Navbar),
    document.getElementById('navbar')
  );
</script>

    <style>
        img {
            max-width: 100%;
        }
    </style>
       <style>
        /*Base do background */
        div {
            background-color: #eefdfceb;
        }
       
    </style>
        <div style=""width: 100%; display: table;"">
            <center>
      <div class=""container"">
  <div class=""row"">
    <div class=""col-md-6"">
      <div class=""card mb-4"">
        <img src=""IMG/bkr.jpg"" class=""card-img-top, lileffect"" alt=""João Massas"">
        <div class=""card-body"">
          <h3 class=""card-title"">João Massas</h3>
          <p class=""card-text"">Delivery à partir das 18h</p>
          <p class=""card-text"">Agora em novo horário de atendimento:</p>
          <ul class=""list-unstyled"">
            <li>Seg-Sáb</li>
          </ul>
          <p class=""card-text"">Rua Apripo 13.</p>
        </div>
      </div>

      <div class=""car");
            WriteLiteral(@"d mb-4"">
        <img src=""IMG/bkry.jpg"" class=""card-img-top, lileffect"" alt=""Padaria Gourmetrix"">
        <div class=""card-body"">
          <h3 class=""card-title"">Padaria Gourmetrix</h3>
          <p class=""card-text"">Funcionamos todos os dias</p>
          <p class=""card-text"">A melhor qualidade a mais de 30 anos</p>
          <ul class=""list-unstyled"">
            <li>8 - 18h</li>
          </ul>
          <p class=""card-text"">Rua Alamador 523</p>
        </div>
      </div>

      <div class=""card mb-4"">
        <img src=""IMG/grdn.jpg"" class=""card-img-top, lileffect"" alt=""Jardinagem"">
        <div class=""card-body"">
          <h3 class=""card-title"">Edson Jardinagem</h3>
          <p class=""card-text"">Serviços de Jardinagem</p>
          <p class=""card-text""> Contato : <a href=""tel:+5521999999999"">(21)99999-9999</a></p>
        </div>
      </div>

      <div class=""card mb-4"">
        <img src=""IMG/grmt.jpg"" class=""card-img-top, lileffect"" alt=""Café"">
        <div class=""card-body""");
            WriteLiteral(@">
          <h3 class=""card-title"">Café</h3>
          <p class=""card-text"">Para todos os amantes de café</p>
          <p class=""card-text"">Qualidade e atendimento profissional</p>
          <ul class=""list-unstyled"">
            <li>6 - 19h</li>
          </ul>
          <p class=""card-text"">Rua Cajiru 19</p>
        </div>
      </div>
    </div>

    <div class=""col-md-6"">
      <div class=""card mb-4"">
        <img src=""IMG/mcdoleg.jpg"" class=""card-img-top, lileffect"" alt=""Hortifruti"">
        <div class=""card-body"">
          <h3 class=""card-title"">Hortifruti</h3>
          <p class=""card-text"">Nós vendemos os melhores produtos da lavoura.</p>
          <p class=""card-text"">Produtos frescos livres de agrotóxicos</p>
          <ul class=""list-unstyled"">
            <li>6 - 19h</li>
          </ul>
          <p class=""card-text"">Rua Cajiru 19</p>
        </div>
      </div>

 <div class=""card mb-4"">
        <img src=""IMG/mrcd.jpg"" class=""card-img-top, lileffect"" alt=""Mercado"">
 ");
            WriteLiteral(@"       <div class=""card-body"">
          <h3 class=""card-title"">Mercado</h3>
          <p class=""card-text"">Melhor preço e atendimento</p>
          <p class=""card-text"">Entregamos em domicílio em todas as compras acima de 100R$</p>
          <ul class=""list-unstyled"">
            <li>8 - 22h</li>
          </ul>
          <p class=""card-text"">Av. Ruddufo Chimara 239</p>
        </div>
      </div>

 <div class=""card mb-4"">
        <img src=""IMG/mcnc.jpg"" class=""card-img-top, lileffect"" alt=""Mecanico"">
        <div class=""card-body"">
          <h3 class=""card-title"">Jorge Mecânico</h3>
          <p class=""card-text"">Contato : <a href>(21)93499-0456 </a></p>
          <p class=""card-text"">Atendimento de segunda à sexta</p>
          <ul class=""list-unstyled"">
            <li>8 - 18h</li>
          </ul>
          <p class=""card-text"">Av. Ruddufo Chimara 278</p>
        </div>
      </div>

      <div class=""card mb-4"">
        <img src=""IMG/pntr.jpg"" class=""card-img-top, lileffect"" alt");
            WriteLiteral(@"=""Pintura"">
        <div class=""card-body"">
         <h3 class=""card-title"">Marcos Pintor</h3>
          <p class=""card-text"">Contato : <a href>(21)91111-0003 </a></p>
          <p class=""card-text"">Atendimento de segunda à sexta</p>
          <ul class=""list-unstyled"">
            <li>6 - 19h</li>
          </ul>
        </div>
      </div>
            </center>
        

");
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
