namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesList;

public record class MedicineListVM (int MedicineId, string MedicineName, int MedicineQuantity, DateTime MedicineExpiration);

