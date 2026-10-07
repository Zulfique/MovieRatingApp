using Microsoft.EntityFrameworkCore;
using MovieRatingApp.Models;

namespace MovieRatingApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = null!;
}
