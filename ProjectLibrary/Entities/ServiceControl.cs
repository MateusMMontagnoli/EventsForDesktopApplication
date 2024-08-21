namespace ProjectLibrary.Entities;

public class ServiceControl
{
    public Guid Id { get; set; }

    public string Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime FinishedAt { get; set; }
}
