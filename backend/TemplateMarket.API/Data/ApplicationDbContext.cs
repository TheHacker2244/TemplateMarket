using Microsoft.EntityFrameworkCore;
using TemplateMarket.API.Models;

namespace TemplateMarket.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Category> Categories => Set<Category>();
}