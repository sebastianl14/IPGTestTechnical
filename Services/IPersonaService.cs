
using IPG_MediaBrands.Models;

namespace IPG_MediaBrands.Services;

public interface IPersonaService
{
    IEnumerable<Persona> Get();

    bool Save(Persona personaCreate);

    bool Update(Persona personaCreate);

    bool Delete(Guid guid);
}