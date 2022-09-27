using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;
using WebServiceRestfull.Enums;

namespace WebServiceRestfull.Entities
{
    [Table("EXERCICIO")]
    public class Exercicio
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Valor nome é obrigatório")]
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }
        [Column("REGISTRO")]
        public DateTime Registro { get; set; }
        public Exercicio(string nome,string descricao, DateTime registro)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Registro = registro;
        }
    }
}
