namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine
{
    public class UpdateMedicineCommandValidator : AbstractValidator<UpdateMedicineCommand>
    {
        public UpdateMedicineCommandValidator()
        {
            RuleFor(p => p.MedicineName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(35).WithMessage("{PropertyName} must not exceed 35 characters");
            RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be greater or equal to 0");
        }
    }
}

