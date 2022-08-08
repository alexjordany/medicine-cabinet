namespace MedicineCabinet.Application.Features.Medicines.Commands.DeleteMedicine;

public class DeleteMedicineCommand : IRequest
{
    public int MedicineId { get; set; }
}

