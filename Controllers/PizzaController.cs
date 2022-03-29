using dotnet_6_webapi.Models;
using dotnet_6_webapi.Services;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_6_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();
        
        return pizza;   
    }

    // POST action

    // PUT action

    // DELETE action

}
