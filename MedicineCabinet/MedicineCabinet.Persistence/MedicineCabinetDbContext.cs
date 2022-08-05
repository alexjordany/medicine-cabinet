using MedicineCabinet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicineCabinet.Persistence;

public class MedicineCabinetDbContext: DbContext
{
    public MedicineCabinetDbContext(DbContextOptions options) : base (options)
    {

    }

    public DbSet<Medicine> Medicines { get; set; }
}

