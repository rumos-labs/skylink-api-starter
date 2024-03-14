using Skylink.Api.Models;

namespace Skylink.Api.Repositories;

public class FlightsRepository : IRepository<Flight>
{
    private readonly SkylinkDbContext context;

    public FlightsRepository(SkylinkDbContext context)
    {
        this.context = context;
    }

    public Flight Add(Flight entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Flight? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Flight> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Flight entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
