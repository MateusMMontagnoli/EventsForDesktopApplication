using Microsoft.AspNetCore.SignalR;
using ProjectLibrary.DTOs;
using ProjectLibrary.Entities;

namespace EventConsumerLocalAPI.Hubs;

public class ServiceSender
{
    private readonly IHubContext<ServiceMainHub> _hubContext;

    public ServiceSender(IHubContext<ServiceMainHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task SendDashboardUpdate(List<ServiceOutput> services)
    {
        await _hubContext.Clients.All.SendAsync("UpdateDashboard", services, CancellationToken.None);
    }
}
