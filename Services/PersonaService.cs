
using IPG_MediaBrands.Models;

namespace IPG_MediaBrands.Services;

public class PersonaService : IPersonaService
{
    DBContext context;

    public PersonaService(DBContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Persona> Get()
    {
        return context.Personas;
    }

    public bool Save(Persona personaCreate)
    {
        context.Add(personaCreate);
        context.SaveChanges();
        return true;
    }

    public bool Update(Persona personaCreate)
    {
        throw new NotImplementedException();
    }

    
    public bool Delete(Guid guid)
    {
        throw new NotImplementedException();
    }
}