
using Microsoft.EntityFrameworkCore;
using WebServiceRestfull.Entities;

namespace WebServiceRestfull.Data
{
    public class ExercicioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = oracle.fiap.com.br)(PORT = 1521)))(CONNECT_DATA = (SID = ORCL)));Persist Security Info=True;User ID=RM92493;Password=240400;Pooling=True;Connection Timeout=60;");
        }

        public DbSet<Exercicio> Exercicios { get; set; }
    }
}

//Eu fiquei com dúvida nessa etapa da conexão com o banco, para todas entidades eu preciso criar um arquivo context ou tem a possibilidade de trabalhar com um arquivo para conectar todas as entidades
