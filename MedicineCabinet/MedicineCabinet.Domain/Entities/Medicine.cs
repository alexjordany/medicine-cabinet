namespace MedicineCabinet.Domain.Entities;

public class Medicine
{
    public int MedicineId { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public int? Quantity { get; set; }
}

