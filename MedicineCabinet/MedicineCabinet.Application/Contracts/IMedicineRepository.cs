namespace MedicineCabinet.Application.Contracts;

public interface IMedicineRepository
{
    Task<IEnumerable<Medicine>> GetMedicinesByName(string name);
}

