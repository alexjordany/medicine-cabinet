using FluentValidation;

namespace MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

public class CreateMedicineCommandValidator : AbstractValidator<CreateMedicineCommand>
{
    public CreateMedicineCommandValidator()
    {
        RuleFor(p => p.MedicineName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(35).WithMessage("{PropertyName} must not exceed 35 characters");
        RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be greater or equal to 0");
        RuleFor(p => p.Expiration).NotEmpty().WithMessage("{PropertyName} is required").Must(CheckExpirationDate).WithMessage("the Expiration date cannot be today or before");
    }

    public bool CheckExpirationDate(DateTime arg)
    {
        var dateNow = DateTime.Now;
        if (arg <= dateNow)
            return false;
        return true;
    }
}