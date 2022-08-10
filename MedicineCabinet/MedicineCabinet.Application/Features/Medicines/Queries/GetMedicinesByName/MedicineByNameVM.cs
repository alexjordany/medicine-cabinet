namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesByName;

public record class MedicineByNameVM(int MedicineId, string MedicineName, int MedicineQuantity, DateTime MedicineExpiration);

