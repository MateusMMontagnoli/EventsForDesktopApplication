using System.Diagnostics;

namespace LocalServerMonitor;

internal static class Program
{
    private static Process? localServerProcess;
    private static ToolStripMenuItem? startService;
    private static ToolStripMenuItem? stopService;
    private static ToolStripMenuItem? closeProgram;

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        var icon = CriarIcon();

        MataropenProcess();

        IniciarProcesso();

        Application.Run();
    }

    private static NotifyIcon CriarIcon()
    {
        NotifyIcon icon = new NotifyIcon
        {
            Icon = new Icon("docker-icon.ico"),
            Visible = true
        };

        ContextMenuStrip menu = new();
        startService = new("Start Local Server");
        stopService = new("Stop Local Server");
        closeProgram = new("Close");
        menu.Items.Add(startService);
        menu.Items.Add(stopService);
        menu.Items.Add(closeProgram);

        icon.ContextMenuStrip = menu;

        startService.Click += StartLocalService_Click;
        stopService.Click += StopLocalService_Click;
        closeProgram.Click += Close_Click;
        menu.Closed += Menu_Closed;

        startService.Enabled = false;
        stopService.Enabled = true;

        return icon;
    }

    private static void Menu_Closed(object? sender, ToolStripDropDownClosedEventArgs e)
    {
        localServerProcess?.Kill();
    }

    private static void IniciarProcesso()
    {
        try
        {
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "EventConsumerLocalAPI.exe";
            startInfo.Verb = "runas";
            startInfo.CreateNoWindow = true;

#if DEBUG

            startInfo.UseShellExecute = false;
            startInfo.EnvironmentVariables["ASPNETCORE_ENVIRONMENT"] = "Development";

#else
            startInfo.UseShellExecute = false;
            startInfo.EnvironmentVariables["ASPNETCORE_ENVIRONMENT"] = "Production";
#endif
            localServerProcess = new Process
            {
                StartInfo = startInfo
            };

            localServerProcess.Start();
        }
        catch (Exception ex)
        {

        }
    }

    private static void Close_Click(object? sender, EventArgs e)
    {
        localServerProcess?.Kill();

        Application.Exit();
    }

    private static void StopLocalService_Click(object? sender, EventArgs e)
    {
        localServerProcess?.Kill();
        localServerProcess = null;
        startService!.Enabled = true;
        stopService!.Enabled = false;
    }

    private static void StartLocalService_Click(object? sender, EventArgs e)
    {
        IniciarProcesso();
        startService!.Enabled = false;
        stopService!.Enabled = true;
    }

    private static void MataropenProcess()
    {
        var localServeExeName = "EventConsumerLocalAPI.exe";
        // Get all processes with the specified name
        Process[] openProcess = Process.GetProcessesByName(localServeExeName);

        // Kill each process
        foreach (Process processo in openProcess)
        {
            try
            {
                processo.Kill();
            }
            catch (Exception)
            {

            }
        }
    }
}