#pragma checksum "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a30c0609d93e849e00f227844e70df61fb4109c68dcb6c4ae761c841bd7ac5db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CadastroPessoas.Pages.Relatorio.Views_Relatorio_Modelo2), @"mvc.1.0.view", @"/Views/Relatorio/Modelo2.cshtml")]
namespace CadastroPessoas.Pages.Relatorio
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Teste Sae Vitor\CadastroPessoas\Views\_ViewImports.cshtml"
using CadastroPessoas.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a30c0609d93e849e00f227844e70df61fb4109c68dcb6c4ae761c841bd7ac5db", @"/Views/Relatorio/Modelo2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1949f41b5e4870e5415b031e69fadfe12080d68234254cdefb6194699533932b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Relatorio_Modelo2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PessoaViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Relatório de Clientes: Modelo 2: Todos os dados do cadastro.</h1>

<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Tipo Pessoa</th>
            <th>Cpf/Cnpj</th>
            <th>Cep</th>
            <th>Endereço</th>
            <th>Número</th>
            <th>Complemento</th>
            <th>Bairro</th>
            <th>Data Nascimento Fundação</th>
            <th>Data Cadastro</th>
            <th>Email</th>
            <th>Celular</th>
            <th>SituacaoCadastral </th>
            <th>Cidade </th>
            <th>Estado </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 32 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
         foreach (var pessoa in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 35 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.TipoPessoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.CpfCnpj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.DataNascimentoFundacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.DataCadastro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.SituacaoCadastral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Cidade.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
               Write(pessoa.Cidade.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "E:\Teste Sae Vitor\CadastroPessoas\Views\Relatorio\Modelo2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<style>
    /* CSS para a tabela */
    table {
        width: 100%;
        border-collapse: collapse;
        border-spacing: 0;
        border: 1px solid #ddd; /* Borda da tabela */
    }

    /* CSS para o cabeçalho da tabela */
    th {
        background-color: #f2f2f2; /* Cor de fundo do cabeçalho */
        border: 1px solid #ddd; /* Borda das células do cabeçalho */
        padding: 8px;
        text-align: left;
    }

    /* CSS para as células da tabela */
    td {
        border: 1px solid #ddd; /* Borda das células */
        padding: 8px;
        text-align: left;
    }

    /* CSS para as células alternadas (linhas ímpares) */
    tbody tr:nth-child(odd) {
        background-color: #f9f9f9; /* Cor de fundo das linhas ímpares */
    }
</style>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PessoaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
