namespace UltraSys
{
    partial class SwitchesForm
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
            this.switchesGyroCheckBox = new System.Windows.Forms.CheckBox();
            this.SwitchesTorqueMotorsCheckBox = new System.Windows.Forms.CheckBox();
            this.SwitchesSpringTensionCheckBox = new System.Windows.Forms.CheckBox();
            this.SwitchesAlarmsCheckBox = new System.Windows.Forms.CheckBox();
            this.switchesCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // switchesGyroCheckBox
            // 
            this.switchesGyroCheckBox.AutoSize = true;
            this.switchesGyroCheckBox.Location = new System.Drawing.Point(51, 52);
            this.switchesGyroCheckBox.Name = "switchesGyroCheckBox";
            this.switchesGyroCheckBox.Size = new System.Drawing.Size(111, 17);
            this.switchesGyroCheckBox.TabIndex = 1;
            this.switchesGyroCheckBox.Text = "Gyro (200Hz) OFF";
            this.switchesGyroCheckBox.UseVisualStyleBackColor = true;
            this.switchesGyroCheckBox.CheckedChanged += new System.EventHandler(this.switchesGyroCheckBox_CheckedChanged);
            // 
            // SwitchesTorqueMotorsCheckBox
            // 
            this.SwitchesTorqueMotorsCheckBox.AutoSize = true;
            this.SwitchesTorqueMotorsCheckBox.Enabled = false;
            this.SwitchesTorqueMotorsCheckBox.Location = new System.Drawing.Point(51, 75);
            this.SwitchesTorqueMotorsCheckBox.Name = "SwitchesTorqueMotorsCheckBox";
            this.SwitchesTorqueMotorsCheckBox.Size = new System.Drawing.Size(118, 17);
            this.SwitchesTorqueMotorsCheckBox.TabIndex = 2;
            this.SwitchesTorqueMotorsCheckBox.Text = "Torque Motors OFF";
            this.SwitchesTorqueMotorsCheckBox.UseVisualStyleBackColor = true;
            this.SwitchesTorqueMotorsCheckBox.CheckedChanged += new System.EventHandler(this.SwitchesTorqueMotorsCheckBox_CheckedChanged);
            // 
            // SwitchesSpringTensionCheckBox
            // 
            this.SwitchesSpringTensionCheckBox.AutoSize = true;
            this.SwitchesSpringTensionCheckBox.Enabled = false;
            this.SwitchesSpringTensionCheckBox.Location = new System.Drawing.Point(51, 98);
            this.SwitchesSpringTensionCheckBox.Name = "SwitchesSpringTensionCheckBox";
            this.SwitchesSpringTensionCheckBox.Size = new System.Drawing.Size(120, 17);
            this.SwitchesSpringTensionCheckBox.TabIndex = 3;
            this.SwitchesSpringTensionCheckBox.Text = "Spring Tension OFF";
            this.SwitchesSpringTensionCheckBox.UseVisualStyleBackColor = true;
            this.SwitchesSpringTensionCheckBox.CheckedChanged += new System.EventHandler(this.SwitchesSpringTensionCheckBox_CheckedChanged);
            // 
            // SwitchesAlarmsCheckBox
            // 
            this.SwitchesAlarmsCheckBox.AutoSize = true;
            this.SwitchesAlarmsCheckBox.Location = new System.Drawing.Point(51, 121);
            this.SwitchesAlarmsCheckBox.Name = "SwitchesAlarmsCheckBox";
            this.SwitchesAlarmsCheckBox.Size = new System.Drawing.Size(80, 17);
            this.SwitchesAlarmsCheckBox.TabIndex = 4;
            this.SwitchesAlarmsCheckBox.Text = "Alarms OFF";
            this.SwitchesAlarmsCheckBox.UseVisualStyleBackColor = true;
            this.SwitchesAlarmsCheckBox.CheckedChanged += new System.EventHandler(this.SwitchesAlarmsCheckBox_CheckedChanged);
            // 
            // switchesCloseButton
            // 
            this.switchesCloseButton.Location = new System.Drawing.Point(84, 163);
            this.switchesCloseButton.Name = "switchesCloseButton";
            this.switchesCloseButton.Size = new System.Drawing.Size(75, 23);
            this.switchesCloseButton.TabIndex = 5;
            this.switchesCloseButton.Text = "Close";
            this.switchesCloseButton.UseVisualStyleBackColor = true;
            this.switchesCloseButton.Click += new System.EventHandler(this.switchesCloseButton_Click);
            // 
            // SwitchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(263, 218);
            this.Controls.Add(this.switchesCloseButton);
            this.Controls.Add(this.SwitchesAlarmsCheckBox);
            this.Controls.Add(this.SwitchesSpringTensionCheckBox);
            this.Controls.Add(this.SwitchesTorqueMotorsCheckBox);
            this.Controls.Add(this.switchesGyroCheckBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwitchesForm";
            this.Text = "Switches";
            this.Load += new System.EventHandler(this.SwitchesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox switchesGyroCheckBox;
        private System.Windows.Forms.CheckBox SwitchesTorqueMotorsCheckBox;
        private System.Windows.Forms.CheckBox SwitchesSpringTensionCheckBox;
        private System.Windows.Forms.CheckBox SwitchesAlarmsCheckBox;
        private System.Windows.Forms.Button switchesCloseButton;

    }
}