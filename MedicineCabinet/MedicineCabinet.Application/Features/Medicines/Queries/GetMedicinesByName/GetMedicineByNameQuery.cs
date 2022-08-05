namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesByName;

public class GetMedicineByNameQuery : IRequest<List<MedicineByNameVM>>
{
    public string? Name { get; set; }
}

