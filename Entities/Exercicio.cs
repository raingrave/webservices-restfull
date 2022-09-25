namespace WebServiceRestfull.Entities

{
    public class Exercicio
    {
        public int IdExercicio { get; set; }
        public string NomeExercicio { set; get; }   
        public string DescricaoExercicio { set; get; }
        public DateTime RegistroExercicio { set; get; }
        
        public  Exercicio (string nome,string descricao, DateTime registro)
        {
            this.NomeExercicio = nome; 
            this.DescricaoExercicio = descricao;
            this.RegistroExercicio= registro;
        }
    }
}
