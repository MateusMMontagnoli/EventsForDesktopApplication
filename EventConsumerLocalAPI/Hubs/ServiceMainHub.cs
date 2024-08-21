using Microsoft.AspNetCore.SignalR;

namespace EventConsumerLocalAPI.Hubs;

public class ServiceMainHub : Hub
{
    public async Task HandShakeServiceDashboard()
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, "ServiceDashboard", CancellationToken.None);
    }
}
