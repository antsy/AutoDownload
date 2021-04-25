namespace AutoDownload
{
    partial class AutoDownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoDownloadForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.logTextBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.enableToggleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setSavePathButton = new System.Windows.Forms.ToolStripButton();
            this.openLocationButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.logTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(622, 406);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(622, 433);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // logTextBox1
            // 
            this.logTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox1.Location = new System.Drawing.Point(0, 0);
            this.logTextBox1.Multiline = true;
            this.logTextBox1.Name = "logTextBox1";
            this.logTextBox1.ReadOnly = true;
            this.logTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox1.Size = new System.Drawing.Size(622, 406);
            this.logTextBox1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToggleButton,
            this.toolStripSeparator1,
            this.setSavePathButton,
            this.openLocationButton,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(390, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // enableToggleButton
            // 
            this.enableToggleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enableToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("enableToggleButton.Image")));
            this.enableToggleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enableToggleButton.Name = "enableToggleButton";
            this.enableToggleButton.Size = new System.Drawing.Size(59, 24);
            this.enableToggleButton.Text = "Toggle";
            this.enableToggleButton.Click += new System.EventHandler(this.EnableToggleButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // setSavePathButton
            // 
            this.setSavePathButton.Image = ((System.Drawing.Image)(resources.GetObject("setSavePathButton.Image")));
            this.setSavePathButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setSavePathButton.Name = "setSavePathButton";
            this.setSavePathButton.Size = new System.Drawing.Size(121, 24);
            this.setSavePathButton.Text = "&Set save path";
            this.setSavePathButton.Click += new System.EventHandler(this.SetSavePathButton_Click);
            // 
            // openLocationButton
            // 
            this.openLocationButton.Image = ((System.Drawing.Image)(resources.GetObject("openLocationButton.Image")));
            this.openLocationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openLocationButton.Name = "openLocationButton";
            this.openLocationButton.Size = new System.Drawing.Size(127, 24);
            this.openLocationButton.Text = "&Open location";
            this.openLocationButton.Click += new System.EventHandler(this.OpenLocationButton_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(74, 24);
            this.helpToolStripButton.Text = "&About";
            this.helpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // AutoDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoDownloadForm";
            this.Text = "AutoDownload";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TextBox logTextBox1;
        private System.Windows.Forms.ToolStripButton openLocationButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton setSavePathButton;
        private System.Windows.Forms.ToolStripButton enableToggleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

