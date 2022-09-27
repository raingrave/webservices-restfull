using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebServiceRestfull.Entities
{
    [Table("RECOMPENSA")]
    public class Recompensa
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Valor nome é obrigatório")]
        [Column("EXERCICIOREALIZADO")]
        public string ExercicioRealizado { get; set; }
        [Column("VALOR")]
        public int Valor { get; set; }
        [Column("TIPO")]
        public string Tipo { get; set; }
        [Column("REGISTRO")]
        public DateTime Registro { get; set; }

        public Recompensa(string exercicioRealizado, int valor, string tipo, DateTime registro)
        {
            ExercicioRealizado = exercicioRealizado;
            Valor = valor;  
            Tipo = tipo;    
            Registro = registro;    

        }
    }
}
