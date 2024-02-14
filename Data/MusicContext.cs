using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data;

public class MusicContext : DbContext
{
    public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Song> Songs { get; set; }    
}