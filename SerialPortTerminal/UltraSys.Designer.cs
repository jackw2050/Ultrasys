namespace UltraSys
{
  partial class UltraSysMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UltraSysMainForm));
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkClearWithDTR = new System.Windows.Forms.CheckBox();
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCalibrationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCalibrationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewCalibrationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useDefaultConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyroPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fOGPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravityChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravityDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossCouplingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossCouplingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.gbPortSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.BackColor = System.Drawing.Color.LightGray;
            this.rtfTerminal.Location = new System.Drawing.Point(0, 25);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(364, 37);
            this.rtfTerminal.TabIndex = 0;
            this.rtfTerminal.Text = "";
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSendData.Location = new System.Drawing.Point(76, 350);
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
            this.lblSend.Location = new System.Drawing.Point(9, 353);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(61, 13);
            this.lblSend.TabIndex = 1;
            this.lblSend.Text = "Send &Data:";
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(415, 319);
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
            this.btnOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenPort.Location = new System.Drawing.Point(415, 283);
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
            this.gbPortSettings.Location = new System.Drawing.Point(12, 269);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(147, 64);
            this.gbPortSettings.TabIndex = 4;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "COM Serial Port Settings";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Location = new System.Drawing.Point(415, 348);
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
            this.chkClearOnOpen.Location = new System.Drawing.Point(311, 330);
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
            this.chkClearWithDTR.Location = new System.Drawing.Point(311, 353);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurationFileToolStripMenuItem,
            this.openCalibrationFileToolStripMenuItem,
            this.saveConfigurationFileToolStripMenuItem,
            this.saveCalibrationFileToolStripMenuItem,
            this.printConfigurationFileToolStripMenuItem,
            this.makeNewCalibrationFileToolStripMenuItem,
            this.useDefaultConfigurationFileToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openConfigurationFileToolStripMenuItem.Text = "Open Configuration file";
            // 
            // openCalibrationFileToolStripMenuItem
            // 
            this.openCalibrationFileToolStripMenuItem.Name = "openCalibrationFileToolStripMenuItem";
            this.openCalibrationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openCalibrationFileToolStripMenuItem.Text = "Open calibration file";
            // 
            // saveConfigurationFileToolStripMenuItem
            // 
            this.saveConfigurationFileToolStripMenuItem.Name = "saveConfigurationFileToolStripMenuItem";
            this.saveConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveConfigurationFileToolStripMenuItem.Text = "Save configuration file";
            // 
            // saveCalibrationFileToolStripMenuItem
            // 
            this.saveCalibrationFileToolStripMenuItem.Name = "saveCalibrationFileToolStripMenuItem";
            this.saveCalibrationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveCalibrationFileToolStripMenuItem.Text = "Save calibration file";
            // 
            // printConfigurationFileToolStripMenuItem
            // 
            this.printConfigurationFileToolStripMenuItem.Name = "printConfigurationFileToolStripMenuItem";
            this.printConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.printConfigurationFileToolStripMenuItem.Text = "Print configuration file";
            // 
            // makeNewCalibrationFileToolStripMenuItem
            // 
            this.makeNewCalibrationFileToolStripMenuItem.Name = "makeNewCalibrationFileToolStripMenuItem";
            this.makeNewCalibrationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.makeNewCalibrationFileToolStripMenuItem.Text = "Make new calibration file";
            // 
            // useDefaultConfigurationFileToolStripMenuItem
            // 
            this.useDefaultConfigurationFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gyroPackToolStripMenuItem,
            this.fOGPackToolStripMenuItem});
            this.useDefaultConfigurationFileToolStripMenuItem.Name = "useDefaultConfigurationFileToolStripMenuItem";
            this.useDefaultConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.useDefaultConfigurationFileToolStripMenuItem.Text = "Use default configuration file";
            // 
            // gyroPackToolStripMenuItem
            // 
            this.gyroPackToolStripMenuItem.Name = "gyroPackToolStripMenuItem";
            this.gyroPackToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gyroPackToolStripMenuItem.Text = "Gyro pack";
            // 
            // fOGPackToolStripMenuItem
            // 
            this.fOGPackToolStripMenuItem.Name = "fOGPackToolStripMenuItem";
            this.fOGPackToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fOGPackToolStripMenuItem.Text = "FOG pack";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gravityChartToolStripMenuItem,
            this.gravityDataToolStripMenuItem,
            this.crossCouplingChartToolStripMenuItem,
            this.crossCouplingDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gravityChartToolStripMenuItem
            // 
            this.gravityChartToolStripMenuItem.Name = "gravityChartToolStripMenuItem";
            this.gravityChartToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gravityChartToolStripMenuItem.Text = "Gravity chart";
            this.gravityChartToolStripMenuItem.Click += new System.EventHandler(this.gravityChartToolStripMenuItem_Click);
            // 
            // gravityDataToolStripMenuItem
            // 
            this.gravityDataToolStripMenuItem.Name = "gravityDataToolStripMenuItem";
            this.gravityDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gravityDataToolStripMenuItem.Text = "Gravity data";
            this.gravityDataToolStripMenuItem.Click += new System.EventHandler(this.gravityDataToolStripMenuItem_Click);
            // 
            // crossCouplingChartToolStripMenuItem
            // 
            this.crossCouplingChartToolStripMenuItem.Name = "crossCouplingChartToolStripMenuItem";
            this.crossCouplingChartToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.crossCouplingChartToolStripMenuItem.Text = "Cross coupling chart";
            this.crossCouplingChartToolStripMenuItem.Click += new System.EventHandler(this.crossCouplingChartToolStripMenuItem_Click);
            // 
            // crossCouplingDataToolStripMenuItem
            // 
            this.crossCouplingDataToolStripMenuItem.Name = "crossCouplingDataToolStripMenuItem";
            this.crossCouplingDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.crossCouplingDataToolStripMenuItem.Text = "Cross coupling data";
            this.crossCouplingDataToolStripMenuItem.Click += new System.EventHandler(this.crossCouplingDataToolStripMenuItem_Click);
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
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(405, 27);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(73, 17);
            this.autoStartCheckBox.TabIndex = 50;
            this.autoStartCheckBox.Text = "Auto Start";
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Azure;
            this.exitButton.Location = new System.Drawing.Point(415, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 51;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UltraSysMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(490, 374);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.autoStartCheckBox);
            this.Controls.Add(this.chkClearWithDTR);
            this.Controls.Add(this.chkClearOnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.rtfTerminal);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(505, 250);
            this.Name = "UltraSysMainForm";
            this.Text = "UltraSys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTerminal_FormClosing);
            this.Load += new System.EventHandler(this.frmTerminal_Load);
            this.Shown += new System.EventHandler(this.frmTerminal_Shown);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
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
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.GroupBox gbPortSettings;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.CheckBox chkClearOnOpen;
		private System.Windows.Forms.CheckBox chkClearWithDTR;
		private System.Windows.Forms.Timer tmrCheckComPorts;
        private System.Windows.Forms.ToolTip toolTip;
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
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.CheckBox autoStartCheckBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCalibrationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCalibrationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewCalibrationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useDefaultConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyroPackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fOGPackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravityChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravityDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossCouplingChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossCouplingDataToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
  }
}

