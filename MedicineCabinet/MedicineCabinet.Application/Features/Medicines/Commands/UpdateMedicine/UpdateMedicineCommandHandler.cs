using MedicineCabinet.Application.Exceptions;

namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;

public class UpdateMedicineCommandHandler : IRequestHandler<UpdateMedicineCommand, UpdateMedicineCommandResponse>
{
    private readonly IAsyncRepository<Medicine> _medicineRepository;
    private readonly IMapper _mapper;

    public UpdateMedicineCommandHandler(IAsyncRepository<Medicine> medicineRepository, IMapper mapper)
    {
        _medicineRepository = medicineRepository;
        _mapper = mapper;
    }

    public async Task<UpdateMedicineCommandResponse> Handle(UpdateMedicineCommand request, CancellationToken cancellationToken)
    {
        var updateMedicineCommandResponse = new UpdateMedicineCommandResponse();
        var validator = new UpdateMedicineCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        var medicineToUpdate = await _medicineRepository.GetByIdAsync(request.MedicineId);

        if (medicineToUpdate is null)
            throw new NotFoundException(nameof(Medicine), request.MedicineId);

        if(validationResult.Errors.Count > 0)
        {
            updateMedicineCommandResponse.Success = false;
            updateMedicineCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                updateMedicineCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }

        if (updateMedicineCommandResponse.Success)
        {
            var medicine = _mapper.Map(request, medicineToUpdate, typeof(UpdateMedicineCommand), typeof(Medicine));

            await _medicineRepository.UpdateAsync(medicineToUpdate);
            updateMedicineCommandResponse.Medicine = _mapper.Map<UpdateMedicineDto>(medicine);
        }

        return updateMedicineCommandResponse;

    }
}

