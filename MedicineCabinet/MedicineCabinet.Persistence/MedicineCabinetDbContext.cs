using MedicineCabinet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicineCabinet.Persistence;

public class MedicineCabinetDbContext: DbContext
{
    public MedicineCabinetDbContext(DbContextOptions options) : base (options)
    {

    }

    public DbSet<Medicine> Medicines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medicine>().HasData(
            new Medicine {
                MedicineId = 1,
                MedicineName = "Paracetamol",
                Active = true,
                Quantity = 20,
                Expiration = DateTime.Now.AddMonths(2),
                CreatedDate = DateTime.Now,
                Description= "paracetamol pills"},

            new Medicine
            {
                MedicineId = 2,
                MedicineName = "Cardioaspirina",
                Active = true,
                Quantity = 60,
                Expiration = DateTime.Now.AddMonths(5),
                CreatedDate = DateTime.Now,
                Description = "Cardioaspirina 86"
            },

            new Medicine
            {
                MedicineId = 3,
                MedicineName = "Carvedilol",
                Active = true,
                Quantity = 68,
                Expiration = DateTime.Now.AddMonths(7),
                CreatedDate = DateTime.Now,
                Description = "Carvedilol 6.25"
            },

            new Medicine
            {
                MedicineId = 4,
                MedicineName = "Espaven",
                Active = true,
                Quantity = 15,
                Expiration = DateTime.Now.AddMonths(1),
                CreatedDate = DateTime.Now,
                Description = "Espaven azul"
            },

            new Medicine
            {
                MedicineId = 5,
                MedicineName = "Multiflora",
                Active = true,
                Quantity = 15,
                Expiration = DateTime.Now.AddMonths(16),
                CreatedDate = DateTime.Now,
                Description = "Multiflora plus"
            }
        );
    }
}

