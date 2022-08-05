namespace MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesList;

public class GetMedicinesListQueryHandler : IRequestHandler<GetMedicinesListQuery, List<MedicineListVM>>
{
    private readonly IAsyncRepository<Medicine> _medicineRepository;
    private readonly IMapper _mapper;

    public GetMedicinesListQueryHandler(IAsyncRepository<Medicine> medicineRepository, IMapper mapper)
    {
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }

    public async Task<List<MedicineListVM>> Handle(GetMedicinesListQuery request, CancellationToken cancellationToken)
    {
        var allMedicines = (await _medicineRepository.ListAllAsync()).OrderBy(x => x.MedicineName);
        return _mapper.Map<List<MedicineListVM>>(allMedicines);
    }
}

