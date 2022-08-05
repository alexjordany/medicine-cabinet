namespace MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

public class CreateMedicineCommandResponse : BaseResponse
{
    public CreateMedicineCommandResponse(): base()
    {
    }

    public CreateMedicineDto Medicine { get; set; }
}
