using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MemoryAlert
{
    public partial class MemoryAlert : Form
    {
        public string version = "0.0.1";

        static string saveDirectory = "MemoryAlert";
        static string fileName = "Settings.json";

        SettingsForm settingsForm;

        public MemoryAlert()
        {
            InitializeComponent();
            SetupForm();
        }

        public void SetupForm()
        {
            LoadSettings();
            SetMemoryProc("", EventArgs.Empty); // Run it once so it doesnt show the default that doesnt have a value.
            Text += " " + version;
            System.Windows.Forms.Timer getDataTimer = new System.Windows.Forms.Timer();
            getDataTimer.Interval = Settings.settings.updateInterval;
            getDataTimer.Tick += new EventHandler(SetMemoryProc);
            getDataTimer.Enabled = true;
        }

        public static void SaveSettings()
        {
            string rawJSON = JsonConvert.SerializeObject(Settings.settings);
            string savePath;
            string finalPath = "";

            if (!Settings.settings.saveSettingsLocally)
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\";
            else
                savePath = AppDomain.CurrentDomain.BaseDirectory.ToString();

            finalPath = savePath + saveDirectory;
            if (!Directory.Exists(finalPath))
                Directory.CreateDirectory(finalPath);

            string debugMessage = string.Format("Savepath: {0},\n saveDirectory: {1},\n fileName: {2},\n fullPath: {3}", savePath, saveDirectory, fileName, finalPath);
            MessageBox.Show(debugMessage);
            File.WriteAllText(finalPath + "\\" + fileName, rawJSON);
            MessageBox.Show(fileName + " file written to:\n" + finalPath + "\\" + fileName);
        }

        public void LoadSettings()
        {
            string loadPath;
            string[] allPaths = { Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\", AppDomain.CurrentDomain.BaseDirectory.ToString() };

            if (!File.Exists(allPaths[1] + saveDirectory + "\\" + fileName))
                loadPath = allPaths[0];

            if (!File.Exists(allPaths[0] + saveDirectory + "\\" + fileName))
                loadPath = allPaths[1];

            if (!File.Exists(allPaths[1] + saveDirectory + "\\" + fileName) && !File.Exists(allPaths[0] + saveDirectory + "\\" + fileName))
                return;

            if (File.GetLastWriteTime(allPaths[1] + saveDirectory + "\\" + fileName) > File.GetLastWriteTime(allPaths[0] + saveDirectory + "\\" + fileName))
                loadPath = allPaths[1];
            else
                loadPath = allPaths[0];

            loadPath += saveDirectory + "\\" + fileName;

            if (!File.Exists(loadPath))
            {
                MessageBox.Show("failed to loaded from:\n" + loadPath);
                return;
            }

            Settings.settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(loadPath));
            MessageBox.Show("Loaded from:\n" + loadPath);
        }

        private void MemoryAlert_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(settingsForm == null)
                settingsForm = new SettingsForm();

            settingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Settings.settings != new Settings()) // Check if user has unsaved settings.
            {
                DialogResult mBAnswer =  MessageBox.Show("There are unsaved settings, Do you want to save?","Caption", MessageBoxButtons.YesNo);
                if (mBAnswer == DialogResult.Yes) // save
                    SaveSettings();
            }
            Application.Exit();
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        private void memoryUsageLabel_Click(object sender, EventArgs e)
        {

        }

        public void SetMemoryProc(object sender, EventArgs e)
        {
            PerformanceCounter performanceCounterUsed = new PerformanceCounter();
            performanceCounterUsed.CategoryName = "Memory";
            performanceCounterUsed.CounterName = "Available MBytes";

            long totalMemory;
            GetPhysicallyInstalledSystemMemory(out totalMemory);
            totalMemory = totalMemory / 1024;

            float memProc = 100 - ((performanceCounterUsed.NextValue()) / (totalMemory) * (100));
            memProc = (float)Math.Ceiling(memProc); // The default task manager seems to ceil the value... for some reason.

            //performanceCounter.InstanceName = "_Total";
            memoryUsageLabel.Text = "Memory usage: " + memProc.ToString() + "%";
        }
    }
}
