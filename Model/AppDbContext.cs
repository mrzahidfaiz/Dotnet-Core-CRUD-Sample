using Microsoft.EntityFrameworkCore;

namespace Web_Api_CRUD_Dotnet_Core_8.Model
{
    public class AppDbContext : DbContext
    {
        // base(options) keyword calls Parent Constructure which is DbContext
        // DbContext is class of  using Microsoft.EntityFrameworkCore;
        // DBContext class is an integral part of Entity Framework you cannot intreact with database without it
        // DbContext class that manages the database connction and is used to retrieve and save data in DB
        // DBContext is a combination of the Unit of work and Repository Patterns
        // DBContext co-ordianates with Entity Framework and allows you to query and save the data in db
        // DbContext class to be able to do ant useful work, it needs an instance of the DbContextOptions class
        // DbContextOptions instance carries configuration info such as the connection string, db provider to use
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        // Represent DataBase Table as Students in SqlServer
        // DbSet<> is class of Microsoft.EntityFrameworkCore;
        // DbContext Uses the DbSet<T> type to define one or more Properties, T represents the type of an object that needs to be stored in db 
        public DbSet<Student> Students { get; set; }
    }

}
