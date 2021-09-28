using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RepositoryEFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People {  get; set; }
        public DbSet<Phone> Phones {  get; set; }
    }

    //Esta clase la agregamos para ejecutar las migraciones de Entity Framework Core
    /// <summary>
    /// 1. Instalar Microsoft.EntityFrameworkCore.Tools
    /// 2. Add-Migration InitialCreate -s InfraStructure\RepositoryEFCore -p InfraStructure\RepositoryEFCore -c ApplicationDbContext -o Data\Migrations
    /// 3. Update-Database -s InfraStructure\RepositoryEFCore -p InfraStructure\RepositoryEFCore
    /// </summary>
    public class AplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            OptionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = MyDbTest; Integrated Security = True;");

            return new ApplicationDbContext(OptionsBuilder.Options);
        }
    }
}
