using Skylink.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace Skylink.Api.Controllers;

[ApiController]
[Route("api/v1/planes")]
public class PlanesController : ControllerBase
{
    // TODO: Inject the repositories
    public PlanesController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Plane>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Plane> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Plane> Post(Plane plane)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Plane> Put(int id, Plane plane)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
