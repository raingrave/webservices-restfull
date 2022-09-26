using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebServiceRestfull.Entities;

namespace WebServiceRestfull.Data
{
    public class AlunoContext : System.Data.Entity.DbContext
    {
        public AlunoContext() : base("name=OracleConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Fiap");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
