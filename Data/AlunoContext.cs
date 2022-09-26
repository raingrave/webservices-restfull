
using Microsoft.EntityFrameworkCore;
using WebServiceRestfull.Entities;

namespace WebServiceRestfull.Data
{
    public class AlunoContext : DbContext
    {
     
        /*public AlunoContext(DbContextOptions<AlunoContext> options) : base(options)
        {

        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = oracle.fiap.com.br)(PORT = 1521)))(CONNECT_DATA = (SID = ORCL)));Persist Security Info=True;User ID=RM92763;Password=080882;Pooling=True;Connection Timeout=60;");
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
