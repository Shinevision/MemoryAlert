using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAlert
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            memoryLimitToolTip.SetToolTip(memoryLimitLabel, "If your memory exceedes this amount (in %) it will warn you.");
            memoryLimitTextbox.Text = Settings.settings.maxMemory.ToString();
            updateIntervalTextbox.Text = Settings.settings.updateInterval.ToString();
            saveSettingsLocallyCheckbox.Checked = Settings.settings.saveSettingsLocally;
        }

        private void memoryLimitToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void memoryLimitLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void memoryLimitTextbox_TextChanged(object sender, EventArgs e)
        {
            float value;
            if (float.TryParse(memoryLimitTextbox.Text, out value))
                Settings.settings.maxMemory = value;
            else if (memoryLimitTextbox.Text.Trim().Length > 0)
            {
                memoryLimitTextbox.Text = memoryLimitTextbox.Text.Remove(memoryLimitTextbox.Text.Trim().Length - 1);
                memoryLimitTextbox.SelectionStart = memoryLimitTextbox.Text.Trim().Length;
            }
        }

        private void saveSettingsLocallyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.settings.saveSettingsLocally = saveSettingsLocallyCheckbox.Checked;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            MemoryAlert.SaveSettings();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateIntervalTextbox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(updateIntervalTextbox.Text, out value))
                Settings.settings.updateInterval = value;
            else if (updateIntervalTextbox.Text.Trim().Length > 0)
            {
                updateIntervalTextbox.Text = updateIntervalTextbox.Text.Remove(updateIntervalTextbox.Text.Trim().Length - 1);
                updateIntervalTextbox.SelectionStart = updateIntervalTextbox.Text.Trim().Length;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) //Override standard X Closing button to hide instead of destroying the object.
        {
            Visible = false;
            Hide();
            e.Cancel = true;
        }
    }

    public class Settings
    {
        public float maxMemory = 90.0f;
        public bool saveSettingsLocally = false;
        public int updateInterval = 1000;

        public static Settings settings = new Settings(); // initializing class
    }
}
