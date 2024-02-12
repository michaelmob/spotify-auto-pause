using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using CSCore.CoreAudioAPI;
using System.Linq;
using System.Security.Policy;

namespace spotify_auto_pause
{
    public partial class Form1 : Form
    {
        private static readonly MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        private readonly MMDevice device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        private AudioSessionManager2 sessionManager = null;

        private List<string> checkProcessNames = new List<string>();

        private DateTime? unpauseTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void cbAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            gbAdvanced.Visible = cbAdvanced.Checked;
        }

        private void tTimer_Tick(object sender, EventArgs e)
        {
            if (!bwAudioDetect.IsBusy)
                bwAudioDetect.RunWorkerAsync();
        }

        private void bwAudioDetect_DoWork(object sender, DoWorkEventArgs e)
        {
            if (sessionManager == null)
                sessionManager = AudioSessionManager2.FromMMDevice(device);

            var sessionEnumerator = sessionManager.GetSessionEnumerator();

            foreach (var session in sessionEnumerator)
            {
                using (var session2 = session.QueryInterface<AudioSessionControl2>())
                using (var audioMeterInfo = session.QueryInterface<AudioMeterInformation>())
                {
                    if (session2.Process == null)
                        continue;

                    bwAudioDetect.ReportProgress(0,
                        new Tuple<Process, double>(session2.Process, audioMeterInfo.GetPeakValue() * 100)
                    );
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var t = (Tuple<Process, double>)e.UserState;
            var name = t.Item1.ProcessName;
            var hwnd = t.Item1.MainWindowHandle.ToString();
            var peak = t.Item2;

            // Update ListView
            var existingItem = listView1.FindItemWithText(name);
            if (existingItem != null)
            {
                // Update existing row
                existingItem.SubItems[1].Text = hwnd;
                existingItem.SubItems[2].Text = peak.ToString();
                existingItem.SubItems[3].Text = (Convert.ToDouble(existingItem.SubItems[3].Text) + peak).ToString();
            }
            else
            {
                // Add new row
                ListViewItem newItem = new ListViewItem(name);
                newItem.SubItems.Add(hwnd);
                newItem.SubItems.Add(peak.ToString());
                newItem.SubItems.Add("0");

                if (checkProcessNames.Contains(name))
                    newItem.Checked = true;

                listView1.Items.Add(newItem);

            }

            // Resume playback by changing cbStatus to true and unpauseTime so this block isn't run again
            if (!cbStatus.Checked && unpauseTime < DateTime.Now)
            {
                cbStatus.Checked = true;
                unpauseTime = null;
            }

            // Pause playback when audio peaks from an unchecked application in the listview
            else if (peak > 0 && !checkProcessNames.Contains(name))
            {
                unpauseTime = DateTime.Now.AddMilliseconds(Convert.ToDouble(nSilenceDuration.Value));
                cbStatus.Checked = false;
            }
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                if (item.Checked)
                    Class1.SendP(Convert.ToInt32(item.SubItems[1].Text), cbStatus.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            tTimer.Enabled = checkBox3.Checked;
            checkBox3.Text = tTimer.Enabled ? "Enabled" : "Disabled";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nDetectInterval_ValueChanged(object sender, EventArgs e)
        {
            tTimer.Interval = (int)nDetectInterval.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkProcessNames = textBox1.Text.Split(',').ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // https://github.com/michaelmob/spotify-auto-pause
            Process.Start("https://github.com/michaelmob/spotify-auto-pause");
        }
    }
}
