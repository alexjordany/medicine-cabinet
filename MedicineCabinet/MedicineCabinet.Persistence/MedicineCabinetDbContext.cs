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
                MedicineQuantity = 20,
                MedicineExpiration = DateTime.Now.AddMonths(2),
                CreatedDate = DateTime.Now,
                MedicineDescription= "paracetamol pills"},

            new Medicine
            {
                MedicineId = 2,
                MedicineName = "Cardioaspirina",
                Active = true,
                MedicineQuantity = 60,
                MedicineExpiration = DateTime.Now.AddMonths(5),
                CreatedDate = DateTime.Now,
                MedicineDescription = "Cardioaspirina 86"
            },

            new Medicine
            {
                MedicineId = 3,
                MedicineName = "Carvedilol",
                Active = true,
                MedicineQuantity = 68,
                MedicineExpiration = DateTime.Now.AddMonths(7),
                CreatedDate = DateTime.Now,
                MedicineDescription = "Carvedilol 6.25"
            },

            new Medicine
            {
                MedicineId = 4,
                MedicineName = "Espaven",
                Active = true,
                MedicineQuantity = 15,
                MedicineExpiration = DateTime.Now.AddMonths(1),
                CreatedDate = DateTime.Now,
                MedicineDescription = "Espaven azul"
            },

            new Medicine
            {
                MedicineId = 5,
                MedicineName = "Multiflora",
                Active = true,
                MedicineQuantity = 15,
                MedicineExpiration = DateTime.Now.AddMonths(16),
                CreatedDate = DateTime.Now,
                MedicineDescription = "Multiflora plus"
            }
        );
    }
}

