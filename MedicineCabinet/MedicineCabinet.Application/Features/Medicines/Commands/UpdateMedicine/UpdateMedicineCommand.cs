namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;

public class UpdateMedicineCommand : IRequest<UpdateMedicineCommandResponse>
{
    public int MedicineId { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public int? Quantity { get; set; }
    public DateTime Expiration { get; set; }
    public string? Description { get; set; }
}

