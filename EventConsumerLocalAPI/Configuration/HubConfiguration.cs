using EventConsumerLocalAPI.Events;
using EventConsumerLocalAPI.Hubs;

namespace EventConsumerLocalAPI.Configuration;

public static class HubConfiguration
{
    public static IServiceCollection AddHubs(this IServiceCollection services)
    {
        services.AddSingleton<ServiceSender>();
        services.AddSignalR();

        return services;
    }
}
   
