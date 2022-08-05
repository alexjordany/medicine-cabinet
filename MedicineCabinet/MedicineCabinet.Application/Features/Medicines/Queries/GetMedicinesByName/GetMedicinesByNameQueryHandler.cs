namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesByName;

public class GetMedicinesByNameQueryHandler : IRequestHandler<GetMedicineByNameQuery, List<MedicineByNameVM>>
{
    private readonly IMedicineRepository _medicineRepository;
    private readonly IMapper _mapper;

    public GetMedicinesByNameQueryHandler(IMedicineRepository medicineRepository, IMapper mapper)
    {
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }

    public async Task<List<MedicineByNameVM>> Handle(GetMedicineByNameQuery request, CancellationToken cancellationToken)
    {
        var getByName = await _medicineRepository.GetMedicinesByName(request.Name);
        return _mapper.Map<List<MedicineByNameVM>>(getByName);
    }
}

