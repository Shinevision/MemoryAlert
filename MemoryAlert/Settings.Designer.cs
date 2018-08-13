namespace MemoryAlert
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.memoryLimitLabel = new System.Windows.Forms.Label();
            this.memoryLimitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.memoryLimitTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveSettingsLocallyCheckbox = new System.Windows.Forms.CheckBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateIntervalTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // memoryLimitLabel
            // 
            this.memoryLimitLabel.AutoSize = true;
            this.memoryLimitLabel.Location = new System.Drawing.Point(13, 13);
            this.memoryLimitLabel.Name = "memoryLimitLabel";
            this.memoryLimitLabel.Size = new System.Drawing.Size(68, 13);
            this.memoryLimitLabel.TabIndex = 0;
            this.memoryLimitLabel.Text = "Memory Limit";
            this.memoryLimitLabel.Click += new System.EventHandler(this.memoryLimitLabel_Click);
            // 
            // memoryLimitToolTip
            // 
            this.memoryLimitToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.memoryLimitToolTip_Popup);
            // 
            // memoryLimitTextbox
            // 
            this.memoryLimitTextbox.Location = new System.Drawing.Point(16, 29);
            this.memoryLimitTextbox.Name = "memoryLimitTextbox";
            this.memoryLimitTextbox.Size = new System.Drawing.Size(51, 20);
            this.memoryLimitTextbox.TabIndex = 1;
            this.memoryLimitTextbox.TextChanged += new System.EventHandler(this.memoryLimitTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveSettingsLocallyCheckbox
            // 
            this.saveSettingsLocallyCheckbox.AutoSize = true;
            this.saveSettingsLocallyCheckbox.Location = new System.Drawing.Point(16, 94);
            this.saveSettingsLocallyCheckbox.Name = "saveSettingsLocallyCheckbox";
            this.saveSettingsLocallyCheckbox.Size = new System.Drawing.Size(122, 17);
            this.saveSettingsLocallyCheckbox.TabIndex = 4;
            this.saveSettingsLocallyCheckbox.Text = "Save settings locally";
            this.saveSettingsLocallyCheckbox.UseVisualStyleBackColor = true;
            this.saveSettingsLocallyCheckbox.CheckedChanged += new System.EventHandler(this.saveSettingsLocallyCheckbox_CheckedChanged);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(282, 169);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 25);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Update interval (in milliseconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ms";
            // 
            // updateIntervalTextbox
            // 
            this.updateIntervalTextbox.Location = new System.Drawing.Point(16, 68);
            this.updateIntervalTextbox.Name = "updateIntervalTextbox";
            this.updateIntervalTextbox.Size = new System.Drawing.Size(51, 20);
            this.updateIntervalTextbox.TabIndex = 8;
            this.updateIntervalTextbox.TextChanged += new System.EventHandler(this.updateIntervalTextbox_TextChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateIntervalTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.saveSettingsLocallyCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memoryLimitTextbox);
            this.Controls.Add(this.memoryLimitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memoryLimitLabel;
        private System.Windows.Forms.ToolTip memoryLimitToolTip;
        private System.Windows.Forms.TextBox memoryLimitTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox saveSettingsLocallyCheckbox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateIntervalTextbox;
    }
}