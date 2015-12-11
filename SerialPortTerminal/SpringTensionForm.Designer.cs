namespace UltraSys
{
    partial class SpringTensionForm
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
            this.springTensionLabel = new System.Windows.Forms.Label();
            this.springTensionTextBox = new System.Windows.Forms.TextBox();
            this.slewSpringTensionTextBox = new System.Windows.Forms.TextBox();
            this.slewSpringTensionLabel = new System.Windows.Forms.Label();
            this.springTensionButton = new System.Windows.Forms.Button();
            this.slewSpringTensionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // springTensionLabel
            // 
            this.springTensionLabel.AutoSize = true;
            this.springTensionLabel.Location = new System.Drawing.Point(34, 38);
            this.springTensionLabel.Name = "springTensionLabel";
            this.springTensionLabel.Size = new System.Drawing.Size(78, 13);
            this.springTensionLabel.TabIndex = 0;
            this.springTensionLabel.Text = "Spring Tension";
            // 
            // springTensionTextBox
            // 
            this.springTensionTextBox.Location = new System.Drawing.Point(138, 31);
            this.springTensionTextBox.Name = "springTensionTextBox";
            this.springTensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.springTensionTextBox.TabIndex = 1;
            this.springTensionTextBox.Text = "0.0";
            // 
            // slewSpringTensionTextBox
            // 
            this.slewSpringTensionTextBox.Location = new System.Drawing.Point(138, 92);
            this.slewSpringTensionTextBox.Name = "slewSpringTensionTextBox";
            this.slewSpringTensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.slewSpringTensionTextBox.TabIndex = 3;
            this.slewSpringTensionTextBox.Text = "0.0";
            // 
            // slewSpringTensionLabel
            // 
            this.slewSpringTensionLabel.AutoSize = true;
            this.slewSpringTensionLabel.Location = new System.Drawing.Point(8, 95);
            this.slewSpringTensionLabel.Name = "slewSpringTensionLabel";
            this.slewSpringTensionLabel.Size = new System.Drawing.Size(104, 13);
            this.slewSpringTensionLabel.TabIndex = 2;
            this.slewSpringTensionLabel.Text = "Slew Spring Tension";
            // 
            // springTensionButton
            // 
            this.springTensionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.springTensionButton.Location = new System.Drawing.Point(254, 28);
            this.springTensionButton.Name = "springTensionButton";
            this.springTensionButton.Size = new System.Drawing.Size(75, 23);
            this.springTensionButton.TabIndex = 4;
            this.springTensionButton.Text = "Accept";
            this.springTensionButton.UseVisualStyleBackColor = true;
            // 
            // slewSpringTensionButton
            // 
            this.slewSpringTensionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slewSpringTensionButton.Location = new System.Drawing.Point(254, 90);
            this.slewSpringTensionButton.Name = "slewSpringTensionButton";
            this.slewSpringTensionButton.Size = new System.Drawing.Size(75, 23);
            this.slewSpringTensionButton.TabIndex = 5;
            this.slewSpringTensionButton.Text = "Accept";
            this.slewSpringTensionButton.UseVisualStyleBackColor = true;
            // 
            // SpringTensionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(365, 164);
            this.Controls.Add(this.slewSpringTensionButton);
            this.Controls.Add(this.springTensionButton);
            this.Controls.Add(this.slewSpringTensionTextBox);
            this.Controls.Add(this.slewSpringTensionLabel);
            this.Controls.Add(this.springTensionTextBox);
            this.Controls.Add(this.springTensionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SpringTensionForm";
            this.Text = "Spring Tension";
            this.Load += new System.EventHandler(this.SpringTensionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label springTensionLabel;
        private System.Windows.Forms.TextBox springTensionTextBox;
        private System.Windows.Forms.TextBox slewSpringTensionTextBox;
        private System.Windows.Forms.Label slewSpringTensionLabel;
        private System.Windows.Forms.Button springTensionButton;
        private System.Windows.Forms.Button slewSpringTensionButton;
    }
}