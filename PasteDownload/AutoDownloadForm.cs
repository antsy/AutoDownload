using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace AutoDownload
{
    public sealed partial class AutoDownloadForm : Form
    {
        public AutoDownloadForm()
        {
            NativeMethods.AddClipboardFormatListener(Handle);
            ClipboardUpdate = HandleClipboardUpdate;

            InitializeComponent();

            string name = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            logTextBox1.Text = $"Welcome using {name} {version}";
            SetSavePath(Directory.GetCurrentDirectory());
            ToggleDownloading(true, false);
        }

        private void ToggleDownloading(bool newValue, bool log = true)
        {
            IsDownloadingEnabled = newValue;

            if (IsDownloadingEnabled)
            {
                enableToggleButton.Text = "✓ enabled";
                enableToggleButton.ForeColor = Color.Green;
            }
            else
            {
                enableToggleButton.Text = "X disabled";
                enableToggleButton.ForeColor = Color.Red;
            }

            if (log)
            {
                LogMessage("Downloading " + (newValue ? "enabled" : "disabled"));
            }
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            aboutWindow.Show();
        }

        private void OpenLocationButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SaveLocation))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = SaveLocation,
                        UseShellExecute = true,
                        Verb = "open"
                    });
                }
                catch (Exception ex)
                {
                    LogMessage(ex.Message);
                }
            }
        }
        private void SetSavePathButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                SetSavePath(folderBrowserDialog1.SelectedPath);
            }
        }

        private void EnableToggleButton_Click(object sender, EventArgs e)
        {
            ToggleDownloading(!IsDownloadingEnabled);
        }
    }

}
