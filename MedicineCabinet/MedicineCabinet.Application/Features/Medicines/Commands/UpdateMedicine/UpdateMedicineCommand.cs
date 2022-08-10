namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;

public class UpdateMedicineCommand : IRequest<UpdateMedicineCommandResponse>
{
    public int MedicineId { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public int? MedicineQuantity { get; set; }
    public DateTime MedicineExpiration { get; set; }
    public string? MedicineDescription { get; set; }
}

