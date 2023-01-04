using API.Entties;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions options) : base()
    {
        
    }
    public DbSet<Products> Products { get; set; }
}