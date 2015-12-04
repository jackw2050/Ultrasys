namespace SerialPortTerminal
{
  partial class frmTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminal));
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkClearWithDTR = new System.Windows.Forms.CheckBox();
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.plus28vLabel = new System.Windows.Forms.Label();
            this.minus28vLabel = new System.Windows.Forms.Label();
            this.plus24vLabel = new System.Windows.Forms.Label();
            this.minus15vLabel = new System.Windows.Forms.Label();
            this.plus15vLabel = new System.Windows.Forms.Label();
            this.plus5vLabel = new System.Windows.Forms.Label();
            this.plus28vTextBox = new System.Windows.Forms.TextBox();
            this.minus28vTextBox = new System.Windows.Forms.TextBox();
            this.plus24vTextBox = new System.Windows.Forms.TextBox();
            this.plus15vTextBox = new System.Windows.Forms.TextBox();
            this.minus15vTextBox = new System.Windows.Forms.TextBox();
            this.plus5vTextBox = new System.Windows.Forms.TextBox();
            this.GravityChartCheckBox = new System.Windows.Forms.CheckBox();
            this.CrossCouplingCheckBox = new System.Windows.Forms.CheckBox();
            this.GravityDataViewCheckBox = new System.Windows.Forms.CheckBox();
            this.CrossCouplingDataViewCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSpringTensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPlatformPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogLabel = new System.Windows.Forms.Label();
            this.digitalLabel = new System.Windows.Forms.Label();
            this.aux4TextBox = new System.Windows.Forms.TextBox();
            this.aux3TextBox = new System.Windows.Forms.TextBox();
            this.aux2TextBox = new System.Windows.Forms.TextBox();
            this.aux1TextBox = new System.Windows.Forms.TextBox();
            this.digitalTextBox = new System.Windows.Forms.TextBox();
            this.aux1Label = new System.Windows.Forms.Label();
            this.aux2Label = new System.Windows.Forms.Label();
            this.aux3Label = new System.Windows.Forms.Label();
            this.aux4Label = new System.Windows.Forms.Label();
            this.AuxDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.systemVoltageDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.gbMode.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfTerminal.BackColor = System.Drawing.Color.LightGray;
            this.rtfTerminal.Location = new System.Drawing.Point(7, 42);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(328, 37);
            this.rtfTerminal.TabIndex = 0;
            this.rtfTerminal.Text = "";
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSendData.Location = new System.Drawing.Point(271, 329);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(176, 20);
            this.txtSendData.TabIndex = 2;
            this.txtSendData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_KeyDown);
            this.txtSendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
            // 
            // lblSend
            // 
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(204, 332);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(61, 13);
            this.lblSend.TabIndex = 1;
            this.lblSend.Text = "Send &Data:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(552, 327);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(6, 37);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 21);
            this.cmbPortName.TabIndex = 1;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(12, 39);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 17);
            this.rbHex.TabIndex = 1;
            this.rbHex.Text = "Hex";
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(12, 19);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // gbMode
            // 
            this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Location = new System.Drawing.Point(12, 286);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(89, 64);
            this.gbMode.TabIndex = 5;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(12, 19);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenPort.Location = new System.Drawing.Point(289, 103);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 6;
            this.btnOpenPort.Text = "&Open Port";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Location = new System.Drawing.Point(12, 203);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(147, 64);
            this.gbPortSettings.TabIndex = 4;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "COM Serial Port Settings";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Location = new System.Drawing.Point(637, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkClearOnOpen
            // 
            this.chkClearOnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClearOnOpen.AutoSize = true;
            this.chkClearOnOpen.Location = new System.Drawing.Point(512, 293);
            this.chkClearOnOpen.Name = "chkClearOnOpen";
            this.chkClearOnOpen.Size = new System.Drawing.Size(94, 17);
            this.chkClearOnOpen.TabIndex = 10;
            this.chkClearOnOpen.Text = "Clear on Open";
            this.chkClearOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkClearWithDTR
            // 
            this.chkClearWithDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClearWithDTR.AutoSize = true;
            this.chkClearWithDTR.Location = new System.Drawing.Point(614, 293);
            this.chkClearWithDTR.Name = "chkClearWithDTR";
            this.chkClearWithDTR.Size = new System.Drawing.Size(98, 17);
            this.chkClearWithDTR.TabIndex = 11;
            this.chkClearWithDTR.Text = "Clear with DTR";
            this.chkClearWithDTR.UseVisualStyleBackColor = true;
            // 
            // tmrCheckComPorts
            // 
            this.tmrCheckComPorts.Enabled = true;
            this.tmrCheckComPorts.Interval = 500;
            this.tmrCheckComPorts.Tick += new System.EventHandler(this.tmrCheckComPorts_Tick);
            // 
            // plus28vLabel
            // 
            this.plus28vLabel.AutoSize = true;
            this.plus28vLabel.Location = new System.Drawing.Point(592, 49);
            this.plus28vLabel.Name = "plus28vLabel";
            this.plus28vLabel.Size = new System.Drawing.Size(35, 13);
            this.plus28vLabel.TabIndex = 17;
            this.plus28vLabel.Text = "+ 28V";
            this.plus28vLabel.Visible = false;
            // 
            // minus28vLabel
            // 
            this.minus28vLabel.AutoSize = true;
            this.minus28vLabel.Location = new System.Drawing.Point(595, 76);
            this.minus28vLabel.Name = "minus28vLabel";
            this.minus28vLabel.Size = new System.Drawing.Size(32, 13);
            this.minus28vLabel.TabIndex = 18;
            this.minus28vLabel.Text = "- 28V";
            this.minus28vLabel.Visible = false;
            // 
            // plus24vLabel
            // 
            this.plus24vLabel.AutoSize = true;
            this.plus24vLabel.Location = new System.Drawing.Point(592, 103);
            this.plus24vLabel.Name = "plus24vLabel";
            this.plus24vLabel.Size = new System.Drawing.Size(35, 13);
            this.plus24vLabel.TabIndex = 19;
            this.plus24vLabel.Text = "+ 24V";
            this.plus24vLabel.Visible = false;
            // 
            // minus15vLabel
            // 
            this.minus15vLabel.AutoSize = true;
            this.minus15vLabel.Location = new System.Drawing.Point(595, 157);
            this.minus15vLabel.Name = "minus15vLabel";
            this.minus15vLabel.Size = new System.Drawing.Size(32, 13);
            this.minus15vLabel.TabIndex = 20;
            this.minus15vLabel.Text = "- 15V";
            this.minus15vLabel.Visible = false;
            // 
            // plus15vLabel
            // 
            this.plus15vLabel.AutoSize = true;
            this.plus15vLabel.Location = new System.Drawing.Point(592, 130);
            this.plus15vLabel.Name = "plus15vLabel";
            this.plus15vLabel.Size = new System.Drawing.Size(35, 13);
            this.plus15vLabel.TabIndex = 21;
            this.plus15vLabel.Text = "+ 15V";
            this.plus15vLabel.Visible = false;
            // 
            // plus5vLabel
            // 
            this.plus5vLabel.AutoSize = true;
            this.plus5vLabel.Location = new System.Drawing.Point(598, 184);
            this.plus5vLabel.Name = "plus5vLabel";
            this.plus5vLabel.Size = new System.Drawing.Size(29, 13);
            this.plus5vLabel.TabIndex = 22;
            this.plus5vLabel.Text = "+ 5V";
            this.plus5vLabel.Visible = false;
            // 
            // plus28vTextBox
            // 
            this.plus28vTextBox.Location = new System.Drawing.Point(654, 46);
            this.plus28vTextBox.Name = "plus28vTextBox";
            this.plus28vTextBox.Size = new System.Drawing.Size(48, 20);
            this.plus28vTextBox.TabIndex = 23;
            this.plus28vTextBox.Text = "28.00";
            this.plus28vTextBox.Visible = false;
            // 
            // minus28vTextBox
            // 
            this.minus28vTextBox.Location = new System.Drawing.Point(654, 73);
            this.minus28vTextBox.Name = "minus28vTextBox";
            this.minus28vTextBox.Size = new System.Drawing.Size(48, 20);
            this.minus28vTextBox.TabIndex = 24;
            this.minus28vTextBox.Text = "-28.00";
            this.minus28vTextBox.Visible = false;
            // 
            // plus24vTextBox
            // 
            this.plus24vTextBox.Location = new System.Drawing.Point(654, 100);
            this.plus24vTextBox.Name = "plus24vTextBox";
            this.plus24vTextBox.Size = new System.Drawing.Size(48, 20);
            this.plus24vTextBox.TabIndex = 25;
            this.plus24vTextBox.Text = "24.00";
            this.plus24vTextBox.Visible = false;
            // 
            // plus15vTextBox
            // 
            this.plus15vTextBox.Location = new System.Drawing.Point(654, 127);
            this.plus15vTextBox.Name = "plus15vTextBox";
            this.plus15vTextBox.Size = new System.Drawing.Size(48, 20);
            this.plus15vTextBox.TabIndex = 26;
            this.plus15vTextBox.Text = "15.00";
            this.plus15vTextBox.Visible = false;
            // 
            // minus15vTextBox
            // 
            this.minus15vTextBox.Location = new System.Drawing.Point(654, 154);
            this.minus15vTextBox.Name = "minus15vTextBox";
            this.minus15vTextBox.Size = new System.Drawing.Size(48, 20);
            this.minus15vTextBox.TabIndex = 27;
            this.minus15vTextBox.Text = "-15.00";
            this.minus15vTextBox.Visible = false;
            // 
            // plus5vTextBox
            // 
            this.plus5vTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.plus5vTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plus5vTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus5vTextBox.ForeColor = System.Drawing.Color.White;
            this.plus5vTextBox.HideSelection = false;
            this.plus5vTextBox.Location = new System.Drawing.Point(654, 185);
            this.plus5vTextBox.Name = "plus5vTextBox";
            this.plus5vTextBox.Size = new System.Drawing.Size(48, 20);
            this.plus5vTextBox.TabIndex = 28;
            this.plus5vTextBox.Text = "5.00";
            this.plus5vTextBox.Visible = false;
            // 
            // GravityChartCheckBox
            // 
            this.GravityChartCheckBox.AutoSize = true;
            this.GravityChartCheckBox.Location = new System.Drawing.Point(20, 20);
            this.GravityChartCheckBox.Name = "GravityChartCheckBox";
            this.GravityChartCheckBox.Size = new System.Drawing.Size(87, 17);
            this.GravityChartCheckBox.TabIndex = 29;
            this.GravityChartCheckBox.Text = "Gravity Chart";
            this.GravityChartCheckBox.UseVisualStyleBackColor = true;
            this.GravityChartCheckBox.CheckedChanged += new System.EventHandler(this.GravityChartCheckBox_CheckedChanged);
            // 
            // CrossCouplingCheckBox
            // 
            this.CrossCouplingCheckBox.AutoSize = true;
            this.CrossCouplingCheckBox.Location = new System.Drawing.Point(20, 54);
            this.CrossCouplingCheckBox.Name = "CrossCouplingCheckBox";
            this.CrossCouplingCheckBox.Size = new System.Drawing.Size(124, 17);
            this.CrossCouplingCheckBox.TabIndex = 30;
            this.CrossCouplingCheckBox.Text = "Cross Coupling Chart";
            this.CrossCouplingCheckBox.UseVisualStyleBackColor = true;
            this.CrossCouplingCheckBox.CheckedChanged += new System.EventHandler(this.CrossCouplingCheckBox_CheckedChanged);
            // 
            // GravityDataViewCheckBox
            // 
            this.GravityDataViewCheckBox.AutoSize = true;
            this.GravityDataViewCheckBox.Location = new System.Drawing.Point(20, 37);
            this.GravityDataViewCheckBox.Name = "GravityDataViewCheckBox";
            this.GravityDataViewCheckBox.Size = new System.Drawing.Size(111, 17);
            this.GravityDataViewCheckBox.TabIndex = 31;
            this.GravityDataViewCheckBox.Text = "Gravity Data View";
            this.GravityDataViewCheckBox.UseVisualStyleBackColor = true;
            this.GravityDataViewCheckBox.CheckedChanged += new System.EventHandler(this.GravityDataViewCheckBox_CheckedChanged);
            // 
            // CrossCouplingDataViewCheckBox
            // 
            this.CrossCouplingDataViewCheckBox.AutoSize = true;
            this.CrossCouplingDataViewCheckBox.Location = new System.Drawing.Point(20, 71);
            this.CrossCouplingDataViewCheckBox.Name = "CrossCouplingDataViewCheckBox";
            this.CrossCouplingDataViewCheckBox.Size = new System.Drawing.Size(148, 17);
            this.CrossCouplingDataViewCheckBox.TabIndex = 32;
            this.CrossCouplingDataViewCheckBox.Text = "Cross Coupling Data View";
            this.CrossCouplingDataViewCheckBox.UseVisualStyleBackColor = true;
            this.CrossCouplingDataViewCheckBox.CheckedChanged += new System.EventHandler(this.CrossCouplingDataViewCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GravityChartCheckBox);
            this.groupBox1.Controls.Add(this.CrossCouplingCheckBox);
            this.groupBox1.Controls.Add(this.CrossCouplingDataViewCheckBox);
            this.groupBox1.Controls.Add(this.GravityDataViewCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Selector";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.switchesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortToolStripMenuItem,
            this.screenDisplayToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.serialPortToolStripMenuItem.Text = "Serial Port / Data";
            this.serialPortToolStripMenuItem.Click += new System.EventHandler(this.serialPortToolStripMenuItem_Click);
            // 
            // screenDisplayToolStripMenuItem
            // 
            this.screenDisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelToolStripMenuItem,
            this.channelsToolStripMenuItem,
            this.channelsToolStripMenuItem1,
            this.channelsToolStripMenuItem2});
            this.screenDisplayToolStripMenuItem.Name = "screenDisplayToolStripMenuItem";
            this.screenDisplayToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.screenDisplayToolStripMenuItem.Text = "Analog Inputs";
            // 
            // channelToolStripMenuItem
            // 
            this.channelToolStripMenuItem.Name = "channelToolStripMenuItem";
            this.channelToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.channelToolStripMenuItem.Text = "1 Channel";
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.channelsToolStripMenuItem.Text = "2 Channels";
            // 
            // channelsToolStripMenuItem1
            // 
            this.channelsToolStripMenuItem1.Name = "channelsToolStripMenuItem1";
            this.channelsToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.channelsToolStripMenuItem1.Text = "3 Channels";
            // 
            // channelsToolStripMenuItem2
            // 
            this.channelsToolStripMenuItem2.Name = "channelsToolStripMenuItem2";
            this.channelsToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.channelsToolStripMenuItem2.Text = "4 Channels";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.engineerToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleModeToolStripMenuItem,
            this.setDateTimeToolStripMenuItem,
            this.setSpringTensionToolStripMenuItem,
            this.saveConfigurationDataToolStripMenuItem,
            this.setPlatformPeriodToolStripMenuItem});
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // toggleModeToolStripMenuItem
            // 
            this.toggleModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiresToolStripMenuItem,
            this.marineToolStripMenuItem});
            this.toggleModeToolStripMenuItem.Name = "toggleModeToolStripMenuItem";
            this.toggleModeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.toggleModeToolStripMenuItem.Text = "Toggle mode";
            // 
            // hiresToolStripMenuItem
            // 
            this.hiresToolStripMenuItem.Name = "hiresToolStripMenuItem";
            this.hiresToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.hiresToolStripMenuItem.Text = "Hi-res";
            // 
            // marineToolStripMenuItem
            // 
            this.marineToolStripMenuItem.Name = "marineToolStripMenuItem";
            this.marineToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.marineToolStripMenuItem.Text = "Marine";
            // 
            // setDateTimeToolStripMenuItem
            // 
            this.setDateTimeToolStripMenuItem.Name = "setDateTimeToolStripMenuItem";
            this.setDateTimeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setDateTimeToolStripMenuItem.Text = "Set Date/ Time";
            this.setDateTimeToolStripMenuItem.Click += new System.EventHandler(this.setDateTimeToolStripMenuItem_Click);
            // 
            // setSpringTensionToolStripMenuItem
            // 
            this.setSpringTensionToolStripMenuItem.Name = "setSpringTensionToolStripMenuItem";
            this.setSpringTensionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setSpringTensionToolStripMenuItem.Text = "Spring Tension";
            this.setSpringTensionToolStripMenuItem.Click += new System.EventHandler(this.setSpringTensionToolStripMenuItem_Click);
            // 
            // saveConfigurationDataToolStripMenuItem
            // 
            this.saveConfigurationDataToolStripMenuItem.Name = "saveConfigurationDataToolStripMenuItem";
            this.saveConfigurationDataToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveConfigurationDataToolStripMenuItem.Text = "Save Configuration Data";
            // 
            // setPlatformPeriodToolStripMenuItem
            // 
            this.setPlatformPeriodToolStripMenuItem.Name = "setPlatformPeriodToolStripMenuItem";
            this.setPlatformPeriodToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setPlatformPeriodToolStripMenuItem.Text = "Set Platform Period";
            // 
            // engineerToolStripMenuItem
            // 
            this.engineerToolStripMenuItem.Name = "engineerToolStripMenuItem";
            this.engineerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.engineerToolStripMenuItem.Text = "Engineer";
            this.engineerToolStripMenuItem.Click += new System.EventHandler(this.engineerToolStripMenuItem_Click);
            // 
            // switchesToolStripMenuItem
            // 
            this.switchesToolStripMenuItem.Name = "switchesToolStripMenuItem";
            this.switchesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.switchesToolStripMenuItem.Text = "Switches";
            this.switchesToolStripMenuItem.Click += new System.EventHandler(this.switchesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // analogLabel
            // 
            this.analogLabel.AutoSize = true;
            this.analogLabel.Location = new System.Drawing.Point(418, 53);
            this.analogLabel.Name = "analogLabel";
            this.analogLabel.Size = new System.Drawing.Size(40, 13);
            this.analogLabel.TabIndex = 36;
            this.analogLabel.Text = "Analog";
            this.analogLabel.Visible = false;
            // 
            // digitalLabel
            // 
            this.digitalLabel.AutoSize = true;
            this.digitalLabel.Location = new System.Drawing.Point(520, 53);
            this.digitalLabel.Name = "digitalLabel";
            this.digitalLabel.Size = new System.Drawing.Size(36, 13);
            this.digitalLabel.TabIndex = 38;
            this.digitalLabel.Text = "Digital";
            this.digitalLabel.Visible = false;
            // 
            // aux4TextBox
            // 
            this.aux4TextBox.BackColor = System.Drawing.Color.LightGray;
            this.aux4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aux4TextBox.Location = new System.Drawing.Point(438, 139);
            this.aux4TextBox.Name = "aux4TextBox";
            this.aux4TextBox.Size = new System.Drawing.Size(48, 20);
            this.aux4TextBox.TabIndex = 39;
            this.aux4TextBox.Text = "28.00";
            this.aux4TextBox.Visible = false;
            // 
            // aux3TextBox
            // 
            this.aux3TextBox.Location = new System.Drawing.Point(438, 116);
            this.aux3TextBox.Name = "aux3TextBox";
            this.aux3TextBox.Size = new System.Drawing.Size(48, 20);
            this.aux3TextBox.TabIndex = 40;
            this.aux3TextBox.Text = "28.00";
            this.aux3TextBox.Visible = false;
            // 
            // aux2TextBox
            // 
            this.aux2TextBox.Location = new System.Drawing.Point(438, 93);
            this.aux2TextBox.Name = "aux2TextBox";
            this.aux2TextBox.Size = new System.Drawing.Size(48, 20);
            this.aux2TextBox.TabIndex = 41;
            this.aux2TextBox.Text = "28.00";
            this.aux2TextBox.Visible = false;
            // 
            // aux1TextBox
            // 
            this.aux1TextBox.Location = new System.Drawing.Point(438, 70);
            this.aux1TextBox.Name = "aux1TextBox";
            this.aux1TextBox.Size = new System.Drawing.Size(48, 20);
            this.aux1TextBox.TabIndex = 42;
            this.aux1TextBox.Text = "28.00";
            this.aux1TextBox.Visible = false;
            // 
            // digitalTextBox
            // 
            this.digitalTextBox.Location = new System.Drawing.Point(512, 70);
            this.digitalTextBox.Name = "digitalTextBox";
            this.digitalTextBox.Size = new System.Drawing.Size(63, 20);
            this.digitalTextBox.TabIndex = 43;
            this.digitalTextBox.Text = "FFFFFF";
            this.digitalTextBox.Visible = false;
            // 
            // aux1Label
            // 
            this.aux1Label.AutoSize = true;
            this.aux1Label.Location = new System.Drawing.Point(398, 77);
            this.aux1Label.Name = "aux1Label";
            this.aux1Label.Size = new System.Drawing.Size(34, 13);
            this.aux1Label.TabIndex = 44;
            this.aux1Label.Text = "Aux 1";
            this.aux1Label.Visible = false;
            // 
            // aux2Label
            // 
            this.aux2Label.AutoSize = true;
            this.aux2Label.Location = new System.Drawing.Point(398, 100);
            this.aux2Label.Name = "aux2Label";
            this.aux2Label.Size = new System.Drawing.Size(34, 13);
            this.aux2Label.TabIndex = 45;
            this.aux2Label.Text = "Aux 2";
            this.aux2Label.Visible = false;
            // 
            // aux3Label
            // 
            this.aux3Label.AutoSize = true;
            this.aux3Label.Location = new System.Drawing.Point(398, 123);
            this.aux3Label.Name = "aux3Label";
            this.aux3Label.Size = new System.Drawing.Size(34, 13);
            this.aux3Label.TabIndex = 46;
            this.aux3Label.Text = "Aux 3";
            this.aux3Label.Visible = false;
            // 
            // aux4Label
            // 
            this.aux4Label.AutoSize = true;
            this.aux4Label.Location = new System.Drawing.Point(398, 146);
            this.aux4Label.Name = "aux4Label";
            this.aux4Label.Size = new System.Drawing.Size(34, 13);
            this.aux4Label.TabIndex = 47;
            this.aux4Label.Text = "Aux 4";
            this.aux4Label.Visible = false;
            // 
            // AuxDisplayCheckBox
            // 
            this.AuxDisplayCheckBox.AutoSize = true;
            this.AuxDisplayCheckBox.Location = new System.Drawing.Point(438, 27);
            this.AuxDisplayCheckBox.Name = "AuxDisplayCheckBox";
            this.AuxDisplayCheckBox.Size = new System.Drawing.Size(101, 17);
            this.AuxDisplayCheckBox.TabIndex = 48;
            this.AuxDisplayCheckBox.Text = "Auxillary Display";
            this.AuxDisplayCheckBox.UseVisualStyleBackColor = true;
            this.AuxDisplayCheckBox.CheckedChanged += new System.EventHandler(this.AuxDisplayCheckBox_CheckedChanged);
            // 
            // systemVoltageDisplayCheckBox
            // 
            this.systemVoltageDisplayCheckBox.AutoSize = true;
            this.systemVoltageDisplayCheckBox.Location = new System.Drawing.Point(566, 27);
            this.systemVoltageDisplayCheckBox.Name = "systemVoltageDisplayCheckBox";
            this.systemVoltageDisplayCheckBox.Size = new System.Drawing.Size(136, 17);
            this.systemVoltageDisplayCheckBox.TabIndex = 49;
            this.systemVoltageDisplayCheckBox.Text = "System Voltage Display";
            this.systemVoltageDisplayCheckBox.UseVisualStyleBackColor = true;
            this.systemVoltageDisplayCheckBox.CheckedChanged += new System.EventHandler(this.systemVoltageDisplayCheckBox_CheckedChanged);
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(651, 4);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(73, 17);
            this.autoStartCheckBox.TabIndex = 50;
            this.autoStartCheckBox.Text = "Auto Start";
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(724, 366);
            this.Controls.Add(this.autoStartCheckBox);
            this.Controls.Add(this.systemVoltageDisplayCheckBox);
            this.Controls.Add(this.AuxDisplayCheckBox);
            this.Controls.Add(this.aux4Label);
            this.Controls.Add(this.aux3Label);
            this.Controls.Add(this.aux2Label);
            this.Controls.Add(this.aux1Label);
            this.Controls.Add(this.digitalTextBox);
            this.Controls.Add(this.aux1TextBox);
            this.Controls.Add(this.aux2TextBox);
            this.Controls.Add(this.aux3TextBox);
            this.Controls.Add(this.aux4TextBox);
            this.Controls.Add(this.digitalLabel);
            this.Controls.Add(this.analogLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plus5vTextBox);
            this.Controls.Add(this.minus15vTextBox);
            this.Controls.Add(this.plus15vTextBox);
            this.Controls.Add(this.plus24vTextBox);
            this.Controls.Add(this.minus28vTextBox);
            this.Controls.Add(this.plus28vTextBox);
            this.Controls.Add(this.plus5vLabel);
            this.Controls.Add(this.plus15vLabel);
            this.Controls.Add(this.minus15vLabel);
            this.Controls.Add(this.plus24vLabel);
            this.Controls.Add(this.minus28vLabel);
            this.Controls.Add(this.plus28vLabel);
            this.Controls.Add(this.chkClearWithDTR);
            this.Controls.Add(this.chkClearOnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.rtfTerminal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(505, 250);
            this.Name = "frmTerminal";
            this.Text = "SerialPort Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTerminal_FormClosing);
            this.Load += new System.EventHandler(this.frmTerminal_Load);
            this.Shown += new System.EventHandler(this.frmTerminal_Shown);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtfTerminal;
    private System.Windows.Forms.TextBox txtSendData;
    private System.Windows.Forms.Label lblSend;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ComboBox cmbPortName;
    private System.Windows.Forms.RadioButton rbHex;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.GroupBox gbMode;
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.GroupBox gbPortSettings;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.CheckBox chkClearOnOpen;
		private System.Windows.Forms.CheckBox chkClearWithDTR;
		private System.Windows.Forms.Timer tmrCheckComPorts;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label plus28vLabel;
        private System.Windows.Forms.Label minus28vLabel;
        private System.Windows.Forms.Label plus24vLabel;
        private System.Windows.Forms.Label minus15vLabel;
        private System.Windows.Forms.Label plus15vLabel;
        private System.Windows.Forms.Label plus5vLabel;
        private System.Windows.Forms.TextBox plus28vTextBox;
        private System.Windows.Forms.TextBox minus28vTextBox;
        private System.Windows.Forms.TextBox plus24vTextBox;
        private System.Windows.Forms.TextBox plus15vTextBox;
        private System.Windows.Forms.TextBox minus15vTextBox;
        private System.Windows.Forms.TextBox plus5vTextBox;
        private System.Windows.Forms.CheckBox GravityChartCheckBox;
        private System.Windows.Forms.CheckBox CrossCouplingCheckBox;
        private System.Windows.Forms.CheckBox GravityDataViewCheckBox;
        private System.Windows.Forms.CheckBox CrossCouplingDataViewCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engineerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSpringTensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPlatformPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchesToolStripMenuItem;
        private System.Windows.Forms.Label analogLabel;
        private System.Windows.Forms.Label digitalLabel;
        private System.Windows.Forms.TextBox aux4TextBox;
        private System.Windows.Forms.TextBox aux3TextBox;
        private System.Windows.Forms.TextBox aux2TextBox;
        private System.Windows.Forms.TextBox aux1TextBox;
        private System.Windows.Forms.TextBox digitalTextBox;
        private System.Windows.Forms.Label aux1Label;
        private System.Windows.Forms.Label aux2Label;
        private System.Windows.Forms.Label aux3Label;
        private System.Windows.Forms.Label aux4Label;
        private System.Windows.Forms.CheckBox AuxDisplayCheckBox;
        private System.Windows.Forms.CheckBox systemVoltageDisplayCheckBox;
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.CheckBox autoStartCheckBox;
  }
}

