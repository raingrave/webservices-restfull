using System.Reflection.PortableExecutable;

namespace WebServiceRestfull.Models
{
    public class Aluno
    {
        public int IdAluno { get; set; } 
        public string NomeAluno { get; set; }
        public int IdadeAluno { get; set; } 
        public double AlturaAluno { get; set; } 
        public double PesoAluno { get; set; }   
        public string GeneroAluno { get; set; }
        
        public void CadastrarAluno(string nome, int idade, double altura, double peso,string genero )
        {
        this.NomeAluno = nome;
        this.IdadeAluno = idade;
        this.AlturaAluno = altura;
        this.PesoAluno = peso;
        this.GeneroAluno = genero;
        }
    }
}
