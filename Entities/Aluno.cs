using System.Reflection.PortableExecutable;
using WebServiceRestfull.Enums;

namespace WebServiceRestfull.Entities
{
    public class Aluno
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public int Idade { get; set; } 
        public double Altura { get; set; } 
        public double Peso { get; set; }   
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
