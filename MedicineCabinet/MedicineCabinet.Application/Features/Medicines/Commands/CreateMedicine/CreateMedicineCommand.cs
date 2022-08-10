namespace MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

public class CreateMedicineCommand : IRequest<CreateMedicineCommandResponse>
{
    public string MedicineName { get; set; } = string.Empty;
    public int? MedicineQuantity { get; set; }
    public DateTime MedicineExpiration { get; set; }
    public string? MedicineDescription { get; set; }
}

