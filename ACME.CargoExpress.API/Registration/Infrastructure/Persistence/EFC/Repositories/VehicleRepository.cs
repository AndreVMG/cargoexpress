using ACME.CargoExpress.API.Registration.Domain.Model.Entities;
using ACME.CargoExpress.API.Registration.Domain.Repositories;
using ACME.CargoExpress.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using ACME.CargoExpress.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ACME.CargoExpress.API.Registration.Infrastructure.Persistence.EFC.Repositories;

public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
{
    private readonly AppDbContext _context;
    public VehicleRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Vehicle>> FindByEntrepreneurIdAsync(int entrepreneurId)
    {
        return await _context.Vehicles.Where(v => v.EntrepreneurId == entrepreneurId).ToListAsync();
    }
}