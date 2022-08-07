using MedicineCabinet.Domain.Shared;

namespace MedicineCabinet.Domain.Entities;

public class Medicine : AuditableEntity
{
    public int MedicineId { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public int? Quantity { get; set; }
    public DateTime Expiration { get; set; }
}

