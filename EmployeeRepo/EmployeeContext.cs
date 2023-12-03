using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EmployeeRepo
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmployeeContext>
    {
        public EmployeeContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../EmployeeApi/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<EmployeeContext>();
            var connectionString = configuration.GetConnectionString("EmpContextConnectionString");
            builder.UseSqlServer(connectionString);
            return new EmployeeContext(builder.Options);
        }
    }
}