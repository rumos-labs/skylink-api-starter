using Skylink.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace Skylink.Api.Controllers;

[ApiController]
[Route("api/v1/flights")]
public class FlightsController : ControllerBase
{
    // TODO: Inject the repositories
    public FlightsController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Flight>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Flight> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Flight> Post(Flight flight)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Flight> Put(int id, Flight flight)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPatch("{id}")]
    public ActionResult<Flight> Patch(int id, int planeId)
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

    [HttpPost("{id}/passengers")]
    public ActionResult<Flight> AddPassenger(int id, Passenger passenger)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
