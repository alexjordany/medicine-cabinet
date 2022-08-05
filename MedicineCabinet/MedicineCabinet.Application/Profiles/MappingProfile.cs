using MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;

namespace MedicineCabinet.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Medicine, CreateMedicineDto>().ReverseMap();
    }
}

