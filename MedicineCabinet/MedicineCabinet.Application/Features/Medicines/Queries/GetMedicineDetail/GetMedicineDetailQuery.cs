namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicineDetail;

public class GetMedicineDetailQuery : IRequest<MedicineDetailVM>
{
    public int Id { get; set; }
}

