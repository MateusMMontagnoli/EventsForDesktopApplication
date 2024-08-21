namespace LocalDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PoolsTablePanel = new TableLayoutPanel();
            FinishedPoolPanel = new Panel();
            FinishedPoolFlowPanel = new FlowLayoutPanel();
            FinishedPoolHeaderPanel = new Panel();
            FinishedHeaderLabel = new Label();
            InProgressPoolPanel = new Panel();
            InProgressPoolFlowPanel = new FlowLayoutPanel();
            InProgressPoolHeaderPanel = new Panel();
            InProgressPoolHeaderLabel = new Label();
            ApprovedPoolPanel = new Panel();
            ApprovedPoolFlowPanel = new FlowLayoutPanel();
            ApprovedPoolHeaderPanel = new Panel();
            ApprovedPoolHeaderLabel = new Label();
            ReconnectHubPanel = new Panel();
            button1 = new Button();
            PoolsTablePanel.SuspendLayout();
            FinishedPoolPanel.SuspendLayout();
            FinishedPoolHeaderPanel.SuspendLayout();
            InProgressPoolPanel.SuspendLayout();
            InProgressPoolHeaderPanel.SuspendLayout();
            ApprovedPoolPanel.SuspendLayout();
            ApprovedPoolHeaderPanel.SuspendLayout();
            ReconnectHubPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PoolsTablePanel
            // 
            PoolsTablePanel.ColumnCount = 3;
            PoolsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            PoolsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            PoolsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            PoolsTablePanel.Controls.Add(FinishedPoolPanel, 2, 0);
            PoolsTablePanel.Controls.Add(InProgressPoolPanel, 1, 0);
            PoolsTablePanel.Controls.Add(ApprovedPoolPanel, 0, 0);
            PoolsTablePanel.Dock = DockStyle.Fill;
            PoolsTablePanel.Location = new Point(0, 0);
            PoolsTablePanel.Name = "PoolsTablePanel";
            PoolsTablePanel.RowCount = 1;
            PoolsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PoolsTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PoolsTablePanel.Size = new Size(800, 418);
            PoolsTablePanel.TabIndex = 0;
            // 
            // FinishedPoolPanel
            // 
            FinishedPoolPanel.Controls.Add(FinishedPoolFlowPanel);
            FinishedPoolPanel.Controls.Add(FinishedPoolHeaderPanel);
            FinishedPoolPanel.Dock = DockStyle.Fill;
            FinishedPoolPanel.Location = new Point(535, 3);
            FinishedPoolPanel.Name = "FinishedPoolPanel";
            FinishedPoolPanel.Size = new Size(262, 412);
            FinishedPoolPanel.TabIndex = 1;
            // 
            // FinishedPoolFlowPanel
            // 
            FinishedPoolFlowPanel.Dock = DockStyle.Fill;
            FinishedPoolFlowPanel.Location = new Point(0, 32);
            FinishedPoolFlowPanel.Name = "FinishedPoolFlowPanel";
            FinishedPoolFlowPanel.Size = new Size(262, 380);
            FinishedPoolFlowPanel.TabIndex = 3;
            // 
            // FinishedPoolHeaderPanel
            // 
            FinishedPoolHeaderPanel.Controls.Add(FinishedHeaderLabel);
            FinishedPoolHeaderPanel.Dock = DockStyle.Top;
            FinishedPoolHeaderPanel.Location = new Point(0, 0);
            FinishedPoolHeaderPanel.Name = "FinishedPoolHeaderPanel";
            FinishedPoolHeaderPanel.Size = new Size(262, 32);
            FinishedPoolHeaderPanel.TabIndex = 2;
            // 
            // FinishedHeaderLabel
            // 
            FinishedHeaderLabel.Dock = DockStyle.Fill;
            FinishedHeaderLabel.Location = new Point(0, 0);
            FinishedHeaderLabel.Name = "FinishedHeaderLabel";
            FinishedHeaderLabel.Size = new Size(262, 32);
            FinishedHeaderLabel.TabIndex = 0;
            FinishedHeaderLabel.Text = "Finished";
            FinishedHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InProgressPoolPanel
            // 
            InProgressPoolPanel.Controls.Add(InProgressPoolFlowPanel);
            InProgressPoolPanel.Controls.Add(InProgressPoolHeaderPanel);
            InProgressPoolPanel.Dock = DockStyle.Fill;
            InProgressPoolPanel.Location = new Point(269, 3);
            InProgressPoolPanel.Name = "InProgressPoolPanel";
            InProgressPoolPanel.Size = new Size(260, 412);
            InProgressPoolPanel.TabIndex = 1;
            // 
            // InProgressPoolFlowPanel
            // 
            InProgressPoolFlowPanel.Dock = DockStyle.Fill;
            InProgressPoolFlowPanel.FlowDirection = FlowDirection.TopDown;
            InProgressPoolFlowPanel.Location = new Point(0, 32);
            InProgressPoolFlowPanel.Name = "InProgressPoolFlowPanel";
            InProgressPoolFlowPanel.Size = new Size(260, 380);
            InProgressPoolFlowPanel.TabIndex = 2;
            // 
            // InProgressPoolHeaderPanel
            // 
            InProgressPoolHeaderPanel.Controls.Add(InProgressPoolHeaderLabel);
            InProgressPoolHeaderPanel.Dock = DockStyle.Top;
            InProgressPoolHeaderPanel.Location = new Point(0, 0);
            InProgressPoolHeaderPanel.Name = "InProgressPoolHeaderPanel";
            InProgressPoolHeaderPanel.Size = new Size(260, 32);
            InProgressPoolHeaderPanel.TabIndex = 1;
            // 
            // InProgressPoolHeaderLabel
            // 
            InProgressPoolHeaderLabel.Dock = DockStyle.Fill;
            InProgressPoolHeaderLabel.Location = new Point(0, 0);
            InProgressPoolHeaderLabel.Name = "InProgressPoolHeaderLabel";
            InProgressPoolHeaderLabel.Size = new Size(260, 32);
            InProgressPoolHeaderLabel.TabIndex = 0;
            InProgressPoolHeaderLabel.Text = "In Progress";
            InProgressPoolHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ApprovedPoolPanel
            // 
            ApprovedPoolPanel.Controls.Add(ApprovedPoolFlowPanel);
            ApprovedPoolPanel.Controls.Add(ApprovedPoolHeaderPanel);
            ApprovedPoolPanel.Dock = DockStyle.Fill;
            ApprovedPoolPanel.Location = new Point(3, 3);
            ApprovedPoolPanel.Name = "ApprovedPoolPanel";
            ApprovedPoolPanel.Size = new Size(260, 412);
            ApprovedPoolPanel.TabIndex = 1;
            // 
            // ApprovedPoolFlowPanel
            // 
            ApprovedPoolFlowPanel.Dock = DockStyle.Fill;
            ApprovedPoolFlowPanel.Location = new Point(0, 32);
            ApprovedPoolFlowPanel.Name = "ApprovedPoolFlowPanel";
            ApprovedPoolFlowPanel.Size = new Size(260, 380);
            ApprovedPoolFlowPanel.TabIndex = 1;
            // 
            // ApprovedPoolHeaderPanel
            // 
            ApprovedPoolHeaderPanel.Controls.Add(ApprovedPoolHeaderLabel);
            ApprovedPoolHeaderPanel.Dock = DockStyle.Top;
            ApprovedPoolHeaderPanel.Location = new Point(0, 0);
            ApprovedPoolHeaderPanel.Name = "ApprovedPoolHeaderPanel";
            ApprovedPoolHeaderPanel.Size = new Size(260, 32);
            ApprovedPoolHeaderPanel.TabIndex = 0;
            // 
            // ApprovedPoolHeaderLabel
            // 
            ApprovedPoolHeaderLabel.Dock = DockStyle.Fill;
            ApprovedPoolHeaderLabel.Location = new Point(0, 0);
            ApprovedPoolHeaderLabel.Name = "ApprovedPoolHeaderLabel";
            ApprovedPoolHeaderLabel.Size = new Size(260, 32);
            ApprovedPoolHeaderLabel.TabIndex = 0;
            ApprovedPoolHeaderLabel.Text = "Approved";
            ApprovedPoolHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReconnectHubPanel
            // 
            ReconnectHubPanel.Controls.Add(button1);
            ReconnectHubPanel.Dock = DockStyle.Bottom;
            ReconnectHubPanel.Location = new Point(0, 418);
            ReconnectHubPanel.Name = "ReconnectHubPanel";
            ReconnectHubPanel.Size = new Size(800, 32);
            ReconnectHubPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(800, 32);
            button1.TabIndex = 0;
            button1.Text = "Reconnect Hub";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PoolsTablePanel);
            Controls.Add(ReconnectHubPanel);
            Name = "MainForm";
            Text = "Service Dashboard";
            PoolsTablePanel.ResumeLayout(false);
            FinishedPoolPanel.ResumeLayout(false);
            FinishedPoolHeaderPanel.ResumeLayout(false);
            InProgressPoolPanel.ResumeLayout(false);
            InProgressPoolHeaderPanel.ResumeLayout(false);
            ApprovedPoolPanel.ResumeLayout(false);
            ApprovedPoolHeaderPanel.ResumeLayout(false);
            ReconnectHubPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PoolsTablePanel;
        private Panel ApprovedPoolHeaderPanel;
        private Panel InProgressPoolHeaderPanel;
        private Panel FinishedPoolPanel;
        private FlowLayoutPanel FinishedPoolFlowPanel;
        private Panel FinishedPoolHeaderPanel;
        private Panel InProgressPoolPanel;
        private FlowLayoutPanel InProgressPoolFlowPanel;
        private Panel ApprovedPoolPanel;
        private FlowLayoutPanel ApprovedPoolFlowPanel;
        private Label ApprovedPoolHeaderLabel;
        private Label FinishedHeaderLabel;
        private Label InProgressPoolHeaderLabel;
        private Panel ReconnectHubPanel;
        private Button button1;
    }
}
