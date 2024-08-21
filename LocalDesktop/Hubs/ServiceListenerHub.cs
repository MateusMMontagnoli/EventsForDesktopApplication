using Microsoft.AspNetCore.SignalR.Client;
using ProjectLibrary.DTOs;
using ProjectLibrary.Entities;

namespace LocalDesktop.Hubs;

public class ServiceListenerHub
{
    HubConnection HubConnection;
    int Port = 8090;
    string ServerIp;
    IProgress<List<ServiceOutput>> FormDashboardProgressHandler;

    public ServiceListenerHub(string serverIp, IProgress<List<ServiceOutput>> formDashboardProgress) 
    {
        this.ServerIp = serverIp;
        FormDashboardProgressHandler = formDashboardProgress;

        StartConnectionWithHub();
    }

    private async void StartConnectionWithHub()
    {
        var serverUri = new Uri($"http://{this.ServerIp}:{this.Port}/ServiceMainHub");

        HubConnection = new HubConnectionBuilder()
            .WithUrl(serverUri, options =>
                {}
            )
            .WithAutomaticReconnect()
            .Build();
        EnsureStartConnection();
        ReadConnection();

        HubConnection.Closed += async (error) =>
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await HubConnection.StartAsync();
        };
    }

    private async void EnsureStartConnection()
    {
        try 
        {
            await HubConnection.StartAsync();

            await HubConnection.InvokeAsync("HandShakeServiceDashboard", CancellationToken.None);
        }
        catch (Exception ex)
        {

        }
    }

    private void ReadConnection()
    {
        try
        {
            HubConnection.On<List<ServiceOutput>>("UpdateDashboard", (response) =>
            {
                if (response != null)
                {
                    FormDashboardProgressHandler.Report(response);
                }
            });

        }
        catch (Exception)
        {
            MessageBox.Show("Error", "An Error Ocurred");
        }
    }
}
