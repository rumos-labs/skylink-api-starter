using Skylink.Api.Models;

namespace Skylink.Api.Repositories;

public class PlanesRepository : IRepository<Passenger>
{
    private readonly SkylinkDbContext context;

    public PlanesRepository(SkylinkDbContext context)
    {
        this.context = context;
    }

    public Passenger Add(Passenger entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Passenger? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Passenger> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Passenger entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
