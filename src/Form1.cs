using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SambaFileDetection
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool FlashWindow(IntPtr hwnd, bool FlashStatus);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += (s, eargs) => DrivesFSW.ForEach(d => d.Dispose());
        }

        void watcher_Error(object sender, ErrorEventArgs e)
        {
            Debug.WriteLine("error : " + e.GetException().Message);

            Log($"Error: {e.GetException().Message}");
        }

        void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Debug.WriteLine($"rename success: {e.OldFullPath} {e.OldName} : {e.FullPath} : {e.Name}");
            Log($"Rename: {e.OldFullPath} -> \"file:\\\\{e.FullPath}\"");
        }

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Debug.WriteLine($"change success: {e.FullPath} : {e.ChangeType} : {e.Name}");

            Log($"Change: \"file:\\\\{e.FullPath}\" | {e.ChangeType}");
        }

        System.Media.SoundPlayer receiveFile = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Unlock.wav");
        public void Log(string log)
        {
            this.Invoke((MethodInvoker) delegate 
            { 
                LoggerTxt.Text += "\r\n" + DateTime.Now.ToString("dd/MM/yy - HH:mm:ss") + " --- " + log;
                LoggerTxt.SelectionStart = LoggerTxt.Text.Length;
                LoggerTxt.ScrollToCaret();
            });
            
            if (!MuteCB.Checked)
            {
                receiveFile.Play();
            }

            this.Invoke((MethodInvoker) delegate { FlashWindow(this.Handle, true); });
        }




        public void BalloonClosed(object sender, EventArgs e)
        {
            Debug.WriteLine("Balloon Closed");
            DisposeNotification((NotifyIcon)sender);
        }

        public void DisposeNotification(NotifyIcon ni)
        {
            FileNotifications.Remove(ni);
            FileDict.Remove(ni);
            ni.Dispose();
            
        }

        public void BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("explorer.exe", $"/select,\"\"{FileDict[(NotifyIcon)sender]}\"\"");
            Process.Start("explorer.exe", $"/select,\"{FileDict[(NotifyIcon)sender]}\"");
        }

        List<FileSystemWatcher> DrivesFSW = new List<FileSystemWatcher>();
        string[] drivePaths;

        List<NotifyIcon> FileNotifications = new List<NotifyIcon>();

        Dictionary<NotifyIcon, string> FileDict = new Dictionary<NotifyIcon, string>();

        private void drivesChangeApplyBtn_Click(object sender, EventArgs e)
        {
            UnregisterWatchers();

            drivePaths = drivesTxt.Text.Split(",");

            RegisterNewWatchers(drivePaths);
        }

        public void RegisterNewWatchers(string[] drivePaths)
        {
            foreach (var drive in drivePaths)
            {
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.IncludeSubdirectories = true;
                watcher.Path = drive;

                watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

                watcher.Changed += watcher_Changed;
                watcher.Created += watcher_Changed;
                watcher.Deleted += watcher_Changed;
                watcher.Renamed += watcher_Renamed;
                watcher.Error += watcher_Error;

                watcher.EnableRaisingEvents = true;
                DrivesFSW.Add(watcher);
            }
        }

        public void UnregisterWatchers()
        {
            Debug.WriteLine("Drives: " + DrivesFSW.Count);
            foreach (var drive in DrivesFSW.ToList())
            {
                drive.Dispose();
                DrivesFSW.Remove(drive);
            }
            Debug.WriteLine("Drives: " + DrivesFSW.Count);
        }

        private void LoggerTxt_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            OpenInExplorer(e.LinkText);
        }

        public void OpenInExplorer(string link)
        {
            Process.Start("explorer.exe", $"/select,\"{link}\"");
        }
    }
}
