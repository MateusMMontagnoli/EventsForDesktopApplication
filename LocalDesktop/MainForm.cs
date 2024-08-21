using LocalDesktop.Hubs;
using ProjectLibrary.DTOs;

namespace LocalDesktop
{
    public partial class MainForm : Form
    {
        private ServiceListenerHub serviceListenerHub;
        private IProgress<List<ServiceOutput>> updateDashboardProgress;

        public MainForm()
        {
            InitializeComponent();
            LoadEvents();
        }

        public void LoadEvents()
        {
            this.Load += MainForm_Load;
            this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            ConnectHub();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            updateDashboardProgress = new Progress<List<ServiceOutput>>(updatedData =>
            {
                LoadServices(updatedData);
            });
            
            ConnectHub();
        }

        private void LoadServices(List<ServiceOutput> updatedData)
        {
            var servicesInProgress = updatedData.Where(x => x.Status == "in-progress");
            var servicesInitiated = updatedData.Where(x => x.Status == "initiated");
            var servicesFinished = updatedData.Where(x => x.Status == "finished");

            var buttons1 = servicesInitiated.Select(x =>
                new Button
                {
                    Dock = DockStyle.Left,
                    Text = x.Id.ToString()
                }
            ).ToArray();

            var buttons2 = servicesInProgress.Select(x =>
                new Button
                {
                    Dock = DockStyle.Left,
                    Text = x.Id.ToString()
                }
            ).ToArray();

            var buttons3 = servicesFinished.Select(x =>
                new Button
                {
                    Dock = DockStyle.Left,
                    Text = x.Id.ToString()
                }
            ).ToArray();

            ApprovedPoolFlowPanel.Controls.AddRange(buttons1);
            InProgressPoolFlowPanel.Controls.AddRange(buttons2);
            FinishedPoolFlowPanel.Controls.AddRange(buttons3);
        }

        private void ConnectHub()
        {
            try
            {
                serviceListenerHub = new ServiceListenerHub("192.168.0.181", updateDashboardProgress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "An error ocurred when trying to connect with server hub");
            }
        }
    }
}
