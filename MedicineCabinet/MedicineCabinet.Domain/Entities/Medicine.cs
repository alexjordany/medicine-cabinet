using MedicineCabinet.Domain.Shared;

namespace MedicineCabinet.Domain.Entities;

public class Medicine : AuditableEntity
{
    public int MedicineId { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public int? MedicineQuantity { get; set; }
    public DateTime MedicineExpiration { get; set; }
    public string? MedicineDescription { get; set; }
}

