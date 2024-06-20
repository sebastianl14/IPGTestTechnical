
using IPG_MediaBrands.Models;
using IPG_MediaBrands.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonaController : ControllerBase
{
    private readonly IPersonaService personaService;

    public PersonaController(IPersonaService personaService)
    {
        this.personaService = personaService;
    }


    [HttpGet]
    public IEnumerable<Persona> Get()
    {
        return personaService.Get();
    }

    [HttpPost]
    public bool Post([FromBody] Persona persona)
    {
        return personaService.Save(persona);
    }

}
