using MedicineCabinet.Application.Features.Medicines.Commands.CreateMedicine;
using MedicineCabinet.Application.Features.Medicines.Commands.UpdateMedicine;
using MedicineCabinet.Application.Features.Medicines.Queries.GetMedicineDetail;
using MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesByName;
using MedicineCabinet.Application.Features.Medicines.Queries.GetMedicinesList;

namespace MedicineCabinet.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Medicine, CreateMedicineDto>().ReverseMap();
        CreateMap<Medicine, UpdateMedicineDto>().ReverseMap();
        CreateMap<Medicine, MedicineDetailVM>().ReverseMap();
        CreateMap<Medicine, MedicineByNameVM>().ReverseMap();
        CreateMap<Medicine, MedicineListVM>().ReverseMap();
    }
}

