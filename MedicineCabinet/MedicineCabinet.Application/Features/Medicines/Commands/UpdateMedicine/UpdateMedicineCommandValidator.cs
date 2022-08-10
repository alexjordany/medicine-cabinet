namespace MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine
{
    public class UpdateMedicineCommandValidator : AbstractValidator<UpdateMedicineCommand>
    {
        public UpdateMedicineCommandValidator()
        {
            RuleFor(p => p.MedicineName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(35).WithMessage("{PropertyName} must not exceed 35 characters");
            RuleFor(p => p.MedicineQuantity).GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be greater or equal to 0");
            RuleFor(p => p.MedicineExpiration).NotEmpty().WithMessage("{PropertyName} is required").Must(CheckExpirationDate).WithMessage("the Expiration date cannot be today or before");
            RuleFor(p => p.MedicineDescription).MaximumLength(150).WithMessage("{PropertyName} must not exceed 150 characters");
        }

        public bool CheckExpirationDate(DateTime arg)
        {
            var dateNow = DateTime.Now;
            if (arg <= dateNow)
                return false;
            return true;
        }
    }
}

