using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;
using WebServiceRestfull.Enums;

namespace WebServiceRestfull.Entities
{
    [Table("ALUNO")]
    public class Aluno
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Valor nome é obrigatório")]
        public string Nome { get; set; }
        [Column("IDADE")]
        public int Idade { get; set; }
        [Column("ALTURA")]
        public double Altura { get; set; }
        [Column("PESO")]
        public double Peso { get; set; }
        [Column("GENERO")]
        public Genero Genero { get; set; }
        
        public Aluno(string nome, int idade, double altura, double peso, Genero genero)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
            this.Genero = genero;
        }
    }
}
