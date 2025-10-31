using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        
        public DbSet<Client> Clients {  get; set; }
        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Office> Offices {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<Receipt> Receipts {  get; set; }
        public DbSet<Receipt_Product> Receipt_Products {  get; set; }
       

    }
}
