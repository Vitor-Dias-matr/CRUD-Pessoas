using System.ComponentModel;

namespace CadastroPessoas.Models.Enum
{ 
    public class Enum
    {
        public enum TipoPessoaEnum
        {
            [Description("Física")]
            CPF = 0,
            [Description("Jurídica")]
            CNPJ = 1
        }
         
        public enum SitCadastral
        {
            [Description("Inativo")]
            Inativo = 0,
            [Description("Ativo")]
            Ativo = 1
        }

    }
}