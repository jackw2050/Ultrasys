namespace SerialPortTerminal
{
    partial class FileConfigurationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileDataSizeLabel = new System.Windows.Forms.Label();
            this.fileDataSizeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(19, 72);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameTextBox.TabIndex = 1;
            this.fileNameTextBox.TextChanged += new System.EventHandler(this.fileNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date will be appended to file name";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(16, 174);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(171, 16);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = "What else can we put here?";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(19, 123);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Open FIle";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // fileExtensionComboBox
            // 
            this.fileExtensionComboBox.FormattingEnabled = true;
            this.fileExtensionComboBox.Items.AddRange(new object[] {
            "Comma",
            "Tab",
            "Space"});
            this.fileExtensionComboBox.Location = new System.Drawing.Point(168, 71);
            this.fileExtensionComboBox.Name = "fileExtensionComboBox";
            this.fileExtensionComboBox.Size = new System.Drawing.Size(121, 21);
            this.fileExtensionComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data delimiter";
            // 
            // fileDataSizeLabel
            // 
            this.fileDataSizeLabel.AutoSize = true;
            this.fileDataSizeLabel.Location = new System.Drawing.Point(165, 107);
            this.fileDataSizeLabel.Name = "fileDataSizeLabel";
            this.fileDataSizeLabel.Size = new System.Drawing.Size(72, 13);
            this.fileDataSizeLabel.TabIndex = 7;
            this.fileDataSizeLabel.Text = "File Data Size";
            // 
            // fileDataSizeComboBox
            // 
            this.fileDataSizeComboBox.FormattingEnabled = true;
            this.fileDataSizeComboBox.Items.AddRange(new object[] {
            "1 hour",
            "1 day",
            "Manual"});
            this.fileDataSizeComboBox.Location = new System.Drawing.Point(168, 123);
            this.fileDataSizeComboBox.Name = "fileDataSizeComboBox";
            this.fileDataSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fileDataSizeComboBox.TabIndex = 8;
            // 
            // FileConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.fileDataSizeComboBox);
            this.Controls.Add(this.fileDataSizeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileExtensionComboBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileConfigurationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Configuration";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ComboBox fileExtensionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileDataSizeLabel;
        private System.Windows.Forms.ComboBox fileDataSizeComboBox;
    }
}