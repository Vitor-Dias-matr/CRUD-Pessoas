using System;
using System.ComponentModel.DataAnnotations.Schema;
using static CadastroPessoas.Models.Enum.Enum;

namespace CadastroPessoas.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string Nome { get; set; }
        public TipoPessoaEnum TipoPessoa { get; set; } 
        [Column(TypeName = "varchar(14)")]
        public string CpfCnpj { get; set; }
        [Column(TypeName = "varchar(8)")]
        public string Cep { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Endereco { get; set; }
        public int? Numero { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Complemento { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Bairro { get; set; }
        public DateTime? DataNascimentoFundacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Celular { get; set; } 
        public SitCadastral SituacaoCadastral { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; } 
    }
}
