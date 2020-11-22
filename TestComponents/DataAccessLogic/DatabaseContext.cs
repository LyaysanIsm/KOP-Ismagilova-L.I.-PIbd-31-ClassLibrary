using DataAccessLogic.DatabaseModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLogic
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = @"(LocalDB)\MSSQLLocalDB",
                    AttachDBFilename = @"C:\Users\Cheevandos\Documents\KOP_Database.mdf",
                    IntegratedSecurity = true,
                    ConnectTimeout = 30
                };
                optionsBuilder.UseSqlServer(stringBuilder.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
