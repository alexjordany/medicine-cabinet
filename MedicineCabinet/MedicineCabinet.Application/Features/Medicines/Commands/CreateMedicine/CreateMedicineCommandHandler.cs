namespace MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

public class CreateMedicineCommandHandler : IRequestHandler<CreateMedicineCommand, CreateMedicineCommandResponse>
{
    private readonly IAsyncRepository<Medicine> _medicineRepository;
    private readonly IMapper _mapper;

    public CreateMedicineCommandHandler(IAsyncRepository<Medicine> medicineRepository, IMapper mapper)
    {
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }

    public async Task<CreateMedicineCommandResponse> Handle(CreateMedicineCommand request, CancellationToken cancellationToken)
    {

        var createMedicineCommandResponse = new CreateMedicineCommandResponse();

        var validator = new CreateMedicineCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            createMedicineCommandResponse.Success = false;
            createMedicineCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                createMedicineCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }

        if (createMedicineCommandResponse.Success)
        {
            var medicine = new Medicine()
            {
                MedicineName = request.MedicineName,
                Quantity = request.Quantity,
                Active = true,
                Expiration = request.Expiration,
                CreatedDate = DateTime.Now
            };

            medicine = await _medicineRepository.AddAsync(medicine);
            createMedicineCommandResponse.Medicine = _mapper.Map<CreateMedicineDto>(medicine);
        }

        return createMedicineCommandResponse;
    }
}

