namespace WebServiceRestfull.Entities

{
    public class Recompensa
    {
        public string ExercicioRealizado { get; set; }
        public int IdRecompensa { get; set; }
        public string TipoRecompensa { get; set; }
        public double ValorRecompensa { get; set; }
        public DateTime RegistroRecompensa { get; set; }

        public void RegistrarRecompensa (string exercicio, DateTime registro)
        {
            this.ExercicioRealizado = exercicio;
            this.RegistroRecompensa = registro;
        }
    }
}
