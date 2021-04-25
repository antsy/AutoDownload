using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoDownload
{
    public sealed partial class AutoDownloadForm : Form
    {
        private static event EventHandler ClipboardUpdate;
        private string ClipText = "";
        private string SaveLocation = "";
        private bool IsDownloadingEnabled = false;

        private void HandleClipboardUpdate(object sender, EventArgs e)
        {
            var clipboardContents = Clipboard.GetText();
            if (ClipText != clipboardContents)
            {
                if (TextIsUrl(clipboardContents))
                {
                    Uri url = new Uri(clipboardContents);
                    if (IsDownloadingEnabled)
                    {
                        Download(url);
                    }
                }
                else
                {
                    LogMessage("Cliboard content changed but not an url.");
                }
                ClipText = clipboardContents;
            }
        }

        private void Download(Uri url)
        {
            string file = Path.GetFileName(url.AbsolutePath);
            file = SanitizeFilename(file);
            if (string.IsNullOrEmpty(file))
            {
                LogMessage("Error! - Can't determine file name");
            }
            else
            {
                DownloadEventHandler(url, file);
            }
        }

        private void DownloadEventHandler(Uri url, string file)
        {
            WebClient webClient = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
            LogMessage("Downloading: " + url);
            file = $"{SaveLocation}{Path.DirectorySeparatorChar}{file}";

            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += delegate
            {
                try
                {
                    webClient.DownloadFile(url, file);
                }
                catch (Exception ex)
                {
                    webClient.CancelAsync();
                    webClient.Dispose();
                    Invoke(new MethodInvoker(delegate ()
                    {
                        LogMessage("EXCEPTION! - " + ex.Message);
                    }));
                }
            };
            backgroundWorker.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e)
            {
                if (e.Error != null)
                {
                    LogMessage($"ERROR! - {e.Error.Message}");
                }
                else if (e.Cancelled)
                {
                    LogMessage($"CANCELLED! - {file} was not downloaded");
                }
                else
                {
                    LogMessage($"** Saved file: {file} **");
                }

            };
            backgroundWorker.RunWorkerAsync();
        }

        private string SanitizeFilename(string filename)
        {
            var invalids = Path.GetInvalidFileNameChars();
            return invalids.Aggregate(filename, (current, c) => current.Replace(c, '_'));
        }

        private void LogMessage(string m)
        {
            logTextBox1.AppendText(Environment.NewLine + m);
            NativeMethods.HideCaret(logTextBox1);
        }

        private bool TextIsUrl(string text)
        {
            return Uri.TryCreate(text, UriKind.Absolute, out Uri uriResult) && uriResult != null;
        }

        private void SetSavePath(string path)
        {
            SaveLocation = path;
            LogMessage("Download path set to " + path);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_CLIPBOARDUPDATE)
            {
                OnClipboardUpdate(null, this);
            }
            base.WndProc(ref m);
        }

        private static void OnClipboardUpdate(EventArgs e, AutoDownloadForm parent)
        {
            ClipboardUpdate?.Invoke(null, e);
        }

        internal static class NativeMethods
        {
            public const int WM_CLIPBOARDUPDATE = 0x031D;
            public static IntPtr HWND_MESSAGE = new IntPtr(-3);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener(IntPtr hwnd);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

            [DllImport("user32.dll")]
            public static extern bool HideCaret(IntPtr hWnd);
            internal static void HideCaret(TextBox textBox)
            {
                HideCaret(textBox.Handle);
            }
        }
    }
}
