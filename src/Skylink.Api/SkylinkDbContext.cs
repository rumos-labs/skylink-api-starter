using Microsoft.EntityFrameworkCore;

namespace Skylink.Api;

public class SkylinkDbContext : DbContext
{
    public SkylinkDbContext(DbContextOptions<SkylinkDbContext> options) : base(options) { }

    // TODO: Add DbSet properties here
}
