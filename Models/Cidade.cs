using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoas.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Estado { get; set; }
    }
}
