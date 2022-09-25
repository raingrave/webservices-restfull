namespace WebServiceRestfull.Entities
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
