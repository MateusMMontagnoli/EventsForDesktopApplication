using EventConsumerAPI.Events;

namespace EventConsumerAPI.Configuration;

public static class EventsConfiguration
{
    public static IServiceCollection AddEvents(this IServiceCollection services)
    {
        services.AddHostedService<ServiceControllEventConsumer>();

        return services;
    }
}
