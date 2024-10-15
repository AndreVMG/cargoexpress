using ACME.CargoExpress.API.Registration.Domain.Model.Entities;
using ACME.CargoExpress.API.Registration.Domain.Repositories;
using ACME.CargoExpress.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using ACME.CargoExpress.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ACME.CargoExpress.API.Registration.Infrastructure.Persistence.EFC.Repositories;

public class DriverRepository : BaseRepository<Driver>, IDriverRepository
{
    private readonly AppDbContext _context;
    public DriverRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Driver>> FindByEntrepreneurIdAsync(int entrepreneurId)
    {
        return await _context.Drivers.Where(d => d.EntrepreneurId == entrepreneurId).ToListAsync();
    }
}