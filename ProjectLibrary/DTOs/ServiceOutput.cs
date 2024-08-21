using ProjectLibrary.Entities;

namespace ProjectLibrary.DTOs;

public class ServiceOutput
{
    public Guid Id { get; set; }

    public string Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime FinishedAt { get; set; }

    public ServiceOutput(Guid id, string status, DateTime createdAt, DateTime updatedAt, DateTime finishedAt)
    {
        Id = id;
        Status = status;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        FinishedAt = finishedAt;
    }

    public ServiceOutput CreateFromService(ServiceControl serviceControl)
    {
        return new(serviceControl.Id, serviceControl.Status, serviceControl.CreatedAt, serviceControl.UpdatedAt, serviceControl.FinishedAt);
    }
}
