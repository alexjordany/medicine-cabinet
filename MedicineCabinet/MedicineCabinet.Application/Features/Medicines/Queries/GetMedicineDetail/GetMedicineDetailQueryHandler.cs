namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicineDetail;

public class GetMedicineDetailQueryHandler : IRequestHandler<GetMedicineDetailQuery, MedicineDetailVM>
{
    private readonly IAsyncRepository<Medicine> _medicineRepository;
    private readonly IMapper _mapper;

    public GetMedicineDetailQueryHandler(IAsyncRepository<Medicine> medicineRepository, IMapper mapper)
    {
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }

    public async Task<MedicineDetailVM> Handle(GetMedicineDetailQuery request, CancellationToken cancellationToken)
    {
        var medicineDetail = await _medicineRepository.GetByIdAsync(request.Id);
        return _mapper.Map<MedicineDetailVM>(medicineDetail);
    }
}

