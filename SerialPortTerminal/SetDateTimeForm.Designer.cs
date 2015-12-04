namespace SerialPortTerminal
{
    partial class SetDateTimeForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.setDateTimeButton = new System.Windows.Forms.Button();
            this.dayOfYearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // setDateTimeButton
            // 
            this.setDateTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setDateTimeButton.Location = new System.Drawing.Point(88, 112);
            this.setDateTimeButton.Name = "setDateTimeButton";
            this.setDateTimeButton.Size = new System.Drawing.Size(106, 23);
            this.setDateTimeButton.TabIndex = 2;
            this.setDateTimeButton.Text = "Set Date / Time";
            this.setDateTimeButton.UseVisualStyleBackColor = true;
            this.setDateTimeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayOfYearLabel
            // 
            this.dayOfYearLabel.AutoSize = true;
            this.dayOfYearLabel.Location = new System.Drawing.Point(85, 74);
            this.dayOfYearLabel.Name = "dayOfYearLabel";
            this.dayOfYearLabel.Size = new System.Drawing.Size(29, 13);
            this.dayOfYearLabel.TabIndex = 3;
            this.dayOfYearLabel.Text = "Day ";
            // 
            // SetDateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(340, 180);
            this.Controls.Add(this.dayOfYearLabel);
            this.Controls.Add(this.setDateTimeButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "SetDateTimeForm";
            this.Text = "Set Date and Time";
            this.Load += new System.EventHandler(this.SetDateTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button setDateTimeButton;
        private System.Windows.Forms.Label dayOfYearLabel;
    }
}