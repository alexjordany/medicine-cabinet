namespace MedicineCabinet.Application.Features.Medicines.Commands.DeleteMedicine;

public class DeleteMedicineCommandHandler : IRequestHandler<DeleteMedicineCommand>
{
    private readonly IAsyncRepository<Medicine> _medicineRepository;

    public DeleteMedicineCommandHandler(IAsyncRepository<Medicine> medicineRepository)
    {
        _medicineRepository = medicineRepository;
    }

    public async Task<Unit> Handle(DeleteMedicineCommand request, CancellationToken cancellationToken)
    {
        var medicineToDelete = await _medicineRepository.GetByIdAsync(request.MedicineId);

        await _medicineRepository.DeleteAsync(medicineToDelete);
        return Unit.Value;
    }
}

