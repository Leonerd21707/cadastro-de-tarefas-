#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Projeto.Tarefas\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9184770f87ae601d8507525766e33ce20725e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9184770f87ae601d8507525766e33ce20725e1", @"/Views/Usuario/Cadastrar.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
            BeginContext(4, 16, false);
#line 2 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Projeto.Tarefas\Views\Usuario\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(20, 354, true);
            WriteLiteral(@"

<h1>Formulario de Cadastro</h1>

<form action=""/Usuario/Cadastrar"" method=""POST"">

<label>
    Nome
    <input type=""text"" name=""Nome"">
</label>

<label>
    Email
    <input type=""email"" name=""Email"">
</label>

<label>
    Senha
    <input type=""password"" name=""Senha"">
</label>

<input type=""Submit"" value=""Confirmar"">

</form>");
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
