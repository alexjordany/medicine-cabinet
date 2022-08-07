namespace MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

public class CreateMedicineCommand : IRequest<CreateMedicineCommandResponse>
{
    public string MedicineName { get; set; } = string.Empty;
    public int? Quantity { get; set; }
    public DateTime Expiration { get; set; }
    public string? Description { get; set; }
}

