using Microsoft.EntityFrameworkCore;
using Dotnet_AZURE.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Category> Categories {get; set;}
}
