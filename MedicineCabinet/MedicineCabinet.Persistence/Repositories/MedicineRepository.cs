using MedicineCabinet.Application.Contracts;
using MedicineCabinet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicineCabinet.Persistence.Repositories;

public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
{
    public MedicineRepository(MedicineCabinetDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<IEnumerable<Medicine>> GetMedicinesByName(string name)
    {
        var medicinesByName = await _dbContext.Medicines
            .Where(x => x.MedicineName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
            string.IsNullOrWhiteSpace(name)).ToListAsync();
        return medicinesByName;
    }
}

