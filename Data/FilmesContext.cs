using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;
public class FilmesContext : DbContext
{
    public FilmesContext(DbContextOptions<FilmesContext> options)
        : base(options)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
}
