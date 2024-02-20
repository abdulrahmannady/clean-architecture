using CleanArchitecture.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}