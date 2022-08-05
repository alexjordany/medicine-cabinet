namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;

public class UpdateMedicineCommandResponse : BaseResponse
{
    public UpdateMedicineCommandResponse(): base()
    {

    }

    public UpdateMedicineDto Medicine { get; set; }
}
