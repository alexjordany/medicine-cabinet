namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;

public record class UpdateMedicineDto (int MedicineId, string MedicineName, int Quantity);