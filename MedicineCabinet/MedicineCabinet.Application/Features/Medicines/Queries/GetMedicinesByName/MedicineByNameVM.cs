namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesByName;

public record class MedicineByNameVM(int MedicineId, string MedicineName, int Quantity, DateTime Expiration);

