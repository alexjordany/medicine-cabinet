using FluentValidation;

namespace MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

public class CreateMedicineCommandValidator : AbstractValidator<CreateMedicineCommand>
{
    public CreateMedicineCommandValidator()
    {
        RuleFor(p => p.MedicineName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(35).WithMessage("{PropertyName} must not exceed 35 characters");
        RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be greater or equal to 0");
    }
}

