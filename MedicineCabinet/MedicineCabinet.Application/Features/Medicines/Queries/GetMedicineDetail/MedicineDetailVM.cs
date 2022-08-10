namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicineDetail;

public record class MedicineDetailVM (int MedicineId, string MedicineName, int MedicineQuantity, DateTime MedicineExpiration, string MedicineDescription);

