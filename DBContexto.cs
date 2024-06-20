using IPG_MediaBrands.Models;
using Microsoft.EntityFrameworkCore;

namespace IPG_MediaBrands;

public class DBContext: DbContext
{
    public DbSet<Persona> Personas {get;set;}

    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {     
        CreatePersona(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private void CreatePersona(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(blogPost => 
        {
            blogPost.ToTable("Persona");
            blogPost.HasKey(p=> p.Id);
            blogPost.Property(p=> p.Nombre).IsRequired();
            blogPost.Property(p=> p.Edad).IsRequired();
            blogPost.Property(p=> p.Genero).IsRequired();
            blogPost.Property(p=> p.FechaIngreso).IsRequired(false);

            blogPost.HasData(PersonasInit());
        });
    }

    private List<Persona> PersonasInit()
    {
        List<Persona> personasInit = new List<Persona>();
        personasInit.Add(new Persona() { Id = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), Nombre = "Sebastian Londoño", Edad = 36, Genero = Genero.Masculino, FechaIngreso = DateTime.Now});
        personasInit.Add(new Persona() { Id = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb402"), Nombre = "Humberto", Edad = 30, Genero = Genero.Masculino, FechaIngreso = DateTime.Now});

        return personasInit;
    }

}