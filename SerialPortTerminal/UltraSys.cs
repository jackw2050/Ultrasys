/*
 * Project:    SerialPort Terminal
           Search for "comport" to see how I'm using the SerialPort control.
 * port parameters  9600, N,1,8, block mode
 */

#region Namespace Inclusions
using FileHelpers;
using UltraSys.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;






#endregion Namespace Inclusions

namespace UltraSys
{
    #region Public Enumerations

    public enum DataMode { Text, Hex }

    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };

    #endregion Public Enumerations

    public partial class UltraSysMainForm : Form
    {
        public CalculateMarineData mdt = new CalculateMarineData();
        
        private delegate void SetTextCallback(string text, DateTime time, double Yval);

        #region Local Variables

        // The main control for communicating through the RS-232 port
        private SerialPort comport = new SerialPort();

        // Various colors for logging info
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };

        // Temp holder for whether a key was pressed
        private bool KeyHandled = false;

        private Settings settings = Settings.Default;
        public static Boolean engineerMode = false;
        // from ultrasys program  used in K-check  Not sure I need them
        private double[] SUM = { 0, 0 };

        private double[] SUMSQ = { 0, 0 };
        private double[] SMEAN = { 0, 0 };
        private double[] SD = { 0, 0 };

        private double[,] STORE =  {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};

        private char[] STAT; // size of 10 in ultrasys
        private int ITAG = 0;
        private int LPTFLG = 0;
        private int ISCFLG = 0;
        private int IDSKFLG = 0;
        private int ICOMFLG = 0;
        private double VERS = 1.08;
        private int NN1 = 999999;
        private int NN2 = 999999;
        //////////////////////////////////////////////////////////////////////////////////////
        //                  variables from old program
        //////////////////////////////////////////////////////////////////////////////////////
    //    private double VERS = 3.55;

        private bool IMBUSY = false;
        private bool TIMEBUSY = false;
        private bool SEABUSY = false;
        private int ISTOP = 0;     //STARTUP INACTIVE
        private int IGYROSW = 2;
        private int IYR = 1995;
        private int IDAY = 111;
        private int IHR = 1;
        private int MIN = 1;
        private int ISEC = 1;
        private int IERR = 0;
        private int NTRY = 0;
        private int MSTAT = 0;
        private double CPER = 18;
        private int LPTSEL = 1;      //SELECT BEAM AS DEFAULT
        private int MULATE = 1;
        private int ISTAT = 14;     //SET HEATER FLAGS HIGH

        //    int IPORT[1] = 128;  //ST ENABLE ON;
        //    int IPORT[3] = 255;  //IPORT(3) IS NOT USED

        private int ICNTLSW = 8;    //DATA ON
        private double[] IVOLTS;
        private double PERX = .000075;
        private double DAMPX = .82;
        private double ALEADX = .10;
        private double GAINX = 0;
        private double AGAINX = 6.5;
        private double APERX = 0.000075;// = PERX;
        private double ADAMPX = 0.82; //DAMPX;
        private double PERL = .000075;
        private double DAMPL = .82;
        private double ALEADL = .10;
        private double GAINL = 0.0;
        private double AGAINL = 6.5;
        private double APERL = .000075;//PERL;
        private double ADAMPL = .82;//DAMPL;
        private string MAGIC = "z";

        private double[] data1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private double[] data2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private double[] data3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public double[,] DATA =
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        private double[] AFILT = { 0.0, 0.2, 0.2, 0.2, 0.2, 1.0, 1.0, 1.0, 1.0 };// added 0.0 for AFILT[0] when done start from 0 not 1
        private double[] CCFACT = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int CCFACT13 = 0;
        private int CCFACT14 = 0;
        private double BSCALE = 1.6;
        private double STMAX = 20000.0;
        private int MODESW = 0;
        private int LPTSW = 0;
        private int NAMESW = 1;
        private int IDSKSW = 1;
        private int JDSKSW = 0;             //DON'T WRITE BEFORE Hz200 SW IS ON
        private int ISCSW = 0;
        private int JSCSW = 0;              //TURN SCREEN OFF UNTIL AFTER STARTUP
        private int ICOMSW = 0;
        private int IFORM = 2;
        private int I1FLAG = 0;
        private int IFIL = 4;
        private string KYDAT = "          ";
        private string LINEID = "MY_LINE # ";
        private int NAUX = 0;
        private string METERNO = "?????";
        private string NAME = "NONAME.DAT";
        private int LARMSW = 0;
        private int GRAV = 0;
     //   private int IDSKFLG, ICOMFLG;
        private int[] iPort = { 0, 128, 0, 255 };
        public int[] transmitCommand = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        public struct GetMeterData
        {
            // public DateTime
            public float st;
            public float beam;
            public float vcc;
            public float al;
            public float ax;
            public float ve;
            public float ax2;
            public float xacc2;
            public float lacc2;
            public float xacc;
            public float lacc;
            public float aux1;
            public float aux2;
            public float aux3;
            public float aux4;
            public double systemVoltageP28V;
            public double systemVoltageN28V;
            public double systemVoltageP24V;
            public double systemVoltageP15V;
            public double systemVoltageN15V;
            public double systemVoltageP5V;
            public int meterStatus;
            public int remoteRebooted;
            public int timeSetSuccess;
            public int g2000Bias0;
            public int year;
            public int day;
            public int Hour, Min, Sec;
            public bool validData;// = false;
            public byte sum;// = 0;

            public double[,] DATA; /* DATA =
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };*/

        }

        public struct configData
        {
            public float BSCALE;
            public float NAUX;
            public float METERNO;
            public float LPTSW;
            public float NAMESW;
            public float IDSKSW;
            public float MAGIC;
            public float ISCSW;
            public float PERX;
            public float PERL;
            public float DAMPX;
            public float DAMPL;
            public float AGAINX;
            public float AGAINL;
            public float IFORM;
            public float ISTSW;
            public float MULATE;
            public float ICOMSW;
            public float LARMSW;
            public float ALEADX;
            public float ALEADL;
            public float MODESW;
            public float IAUXGAIN;
            public float GXBIAS;
            public float GLBIAS;
            public float[] CCFACT;
            public float[] AFILT;
        }

        private struct IrawInputBuffer
        {
            public float crossGyro;
            public float longGyro;
            public float crossAccelerometer;
            public float longAccelerometer;
            public float beam;
            public float zeroVoltsReference;
            public float plus15VoltReference;
            public float minus15VoltReference;
            public float plus12VoltReference;
            public float aux1;
            public float aux2;
            public float aux3;
            public float aux4;

            public int crossGyroGain;
            public int longGyroGain;
            public int crossAccelerometerGain;
            public int longAccelerometerGain;
            public int beamGain;
            public int zeroVoltsReferenceGain;
            public int plus15VoltReferenceGain;
            public int minus15VoltReferenceGain;
            public int plus12VoltReferenceGain;

            public bool aux1Selected;
            public bool aux2Selected;
            public bool aux3Selected;
            public bool aux4Selected;
        }
        private struct Idac  // Output buffer
        {
            public float crossGyro;
            public float longGyro;
            public float crossAccelerometer;
            public float longAccelerometer;
        }
        private struct InputData200Hz   //Data0
        {
            public float crossGyro;
            public float longGyro;
            public float beam;
        }
        private struct InputData25Hz   // sum of 8 Input data updated at 25 hz
        {
            public float crossGyro;
            public float longGyro;
            public float beam;
        }
        private struct DataCrossCouplingFiltered  // Filtered with 1/25 sec for Cross Coupling phase
        {
            public float crossGyro;
            public float longGyro;
            public float beam;
            public float laCrossCoupling3;
            public float dBdt;
            public float vccVml;
            public float al;
            public float ax;
            public float ve;
            public float ax2Cmx;
            public float xaCrossCoupling2;
            public float laCrossCoupling2;
            public float xcomp;
            public float lcomp;
            public float xaCrossCoupling1;
        }
        public class InputData1Second  //Data1 sum of 200 data updated at 1 second rate
        {
            public float zeroVolts;
            public float springTension;
            public float crossCoupling;
            public float avgB;
            public float vCrossCoupling;
            public float al;
            public float ax;
            public float ve;
            public float ax2Cmx;
            public float xaCrossCoupling2;
            public float laCrossCoupling;
            public float xComp;
            public float lComp;
            public float xaCrossCoupling1;
            public float aux1;
            public float aux2;
            public float aux3;
            public float aux4;
        }
        private struct IntermediateFilterStage2  //Data2
        {
            public float springTension;
            public float crossCoupling;
            public float avgB;
            public float vCrossCoupling;
            public float al;
            public float ax;
            public float ve;
            public float ax2Cmx;
            public float xaCrossCoupling2;
            public float laCrossCoupling;
            public float xComp;
            public float lComp;
            public float xaCrossCoupling1;
            public float aux1;
            public float aux2;
            public float aux3;
            public float aux4;
        }
        private struct IntermediateFilterStage3  //Data3
        {
            public float springTension;
            public float crossCoupling;
            public float avgB;
            public float vCrossCoupling;
            public float al;
            public float ax;
            public float ve;
            public float ax2Cmx;
            public float xaCrossCoupling2;
            public float laCrossCoupling;
            public float xComp;
            public float lComp;
            public float xaCrossCoupling1;
            public float aux1;
            public float aux2;
            public float aux3;
            public float aux4;
        }


        public class data
        {
            double[] data1;
            double[] data2;
            double[] data3;
            double[] data4;

            public void Filter320()//  3 * 20 sec RC filter from 1 sec samples
            {
                
                //  SUBROUTINE FIL320 (VIN,F1,F2,F3)
                for (int i = 3; i <= 18; i++)
                {
                    data2[i] = data2[i] + (data1[i] - data2[i]) * .05;//  (.05 = 1/20)
                    data3[i] = data3[i] + (data2[i] - data3[i]) * .05;//  (.05 = 1/20)
                    data4[i] = data4[i] + (data3[i] - data4[i]) * .05;//  (.05 = 1/20)
                }

            }

        }



      

        //----------------------------------------------------------------------------------------------------------------

        #endregion Local Variables

        private GravityDataForm myGravityDataForm = new GravityDataForm();
        private GravityChartForm myGravityChartForm = new GravityChartForm();
        private CrossCouplingChartForm myCrossCouplingChartFrom = new CrossCouplingChartForm();
        private CrossCouplingDataForm myCrossCouplingDataForm = new CrossCouplingDataForm();

        #region Constructor

        public UltraSysMainForm()
        {
            //      chart1.Series.Add("Series1");

            // Load user settings
            //    settings.Reload();

            // Build the form
            InitializeComponent();

            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();

      //      data dataStruct = new data(new double[23], double[23], double[23], double[23]);


            GetMeterData newMeterData;
            newMeterData = new GetMeterData();
            configData configData = new configData();
            // When data is recieved through the port, call this method
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //			comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);

            // txtSendData.Text = INT2[1];// this is the text in the TEXTBOX txtSendData
            //SendData(); INT2[1]
        }

        private void comport_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            // Show the state of the pins
            UpdatePinState();
        }

        private void UpdatePinState()
        {
            this.Invoke(new ThreadStart(() =>
            {
                // Show the state of the pins
                //				chkCD.Checked = comport.CDHolding;
                //				chkCTS.Checked = comport.CtsHolding;
                //				chkDSR.Checked = comport.DsrHolding;
            }));
        }

        #endregion Constructor

        #region Local Methods

        meterMode SetMode(meterMode mode)
        {
           // sendCommand(2);     // Parameters
           // sendCommand(8);     // and cross coupling phases
            int test;
            test = iPort[2] & 6;
            if (test > 1)
            {
               mode.MAXSTEP = 2900;
               mode.STSCALE = 0.1041666;
               mode.FMPM = 2340.0;
            }
            else
            {
                mode.MAXSTEP = 2200;
                mode.STSCALE = 0.0347222;
                mode.FMPM = 525.0;
            }
            return mode;

        }
        void Init()
        {

//  Initialize variables
/*
        IYR = 1995
        IDAY = 111
        IHR = 1
        MIN = 1
        ISE//  = 1
        KERR = 0
        NTRY = 0
        CPER = 18.
        MULATE = 1
        LPTSEL = 0
        ISTAT = 14      !SET HEATER FLAGS HIGH
        IPORT(3) = 255  !IPORT(3) IS NOT USED
        PERX = .000075
        DAMPX = .82
        ALEADX = .10
        GAINX = 0.
        AGAINX = 6.5
        APERX = PERX
        ADAMPX = DAMPX
        PERL = .000075
        DAMPL = .82
        ALEADL = .10
        GAINL = 0.
        AGAINL = 6.5
        APERL = PERL
        ADAMPL = DAMPL
        DO 5 J=1,20
5         DATA(1,J) = 0.
        DO 8 J=1,20
8         DATA(2,J) = 0.
        DO 9 J=1,20
9         DATA(3,J) = 0.
        DO 10 J=1,23
10        DATA(4,J) = 0.
        AFILT(1) = 0.2
        AFILT(2) = 0.2
        AFILT(3) = 0.2
        AFILT(4) = 0.2
        AFILT(5) = 1.
        AFILT(6) = 1.
        AFILT5 = 1.
        AFILT6 = 1.
        NAUX = 0
        DO 11 J=6,14
11         CCFACT(J) = 0.
        CCFACT13=0
        CCFACT14=0
        BSCALE = 1.6
        STMAX = 20000.
        LPTSW = 0
        NAMESW =1
        IDSKSW = 1
        ISCSW = 2
        JSCSW = 1               !TURN SCREEN OFF UNTIL AFTER STARTUP
        ICOMSW = 0
        IFORM = 2
        I1FLAG = 0
        IFIL = 4
        KYDAT = '          '
        LINEID = 'MY_LINE # '
//        LINEID = '    $HEGRO'     ! SPECIAL DEFAULT FOR SSI
        METERNO = '?????'
        NAME = 'NONAME.DAT'
        LARMSW = 0
        GRAV = 0
*/
        }

        /*
                void CalculateCrossCoupling(data dataStructure, double[] CCFACT)
                {
                    data1[4] = 0;
                    for (int i = 6; i <= 12; i++)
                    {
                        data1[i] = data1[4] + data1[i] * CCFACT[i];
                        dataStructure.data1
                    }
                    for (int i = 3; i <= 18; i++)
                    {
                        data.Filter320(data1,data2, data3, data4);
                     //   Filter320(data1[i], data2[i], data3[i], data4[i]);
                    }
                    if (MODESW == 1)
                    {
                        if (IDSKSW > 0 || JDSKSW> 0)
                        {
                            IDSKFLG = 2;
                        }
                        if (ICOMSW == -1)
                        {
                            ICOMSW = 2;
                        }
                    }
                }

       
        */

        /// <summary> Save the user's settings. </summary>
        /*       private void SaveSettings()
               {
                   settings.BaudRate = int.Parse(cmbBaudRate.Text);
                   settings.DataBits = int.Parse(cmbDataBits.Text);
                   settings.DataMode = CurrentDataMode;
                   settings.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                   settings.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                   settings.PortName = cmbPortName.Text;//  this  will be the only variable
                   settings.ClearOnOpen = chkClearOnOpen.Checked;
                   settings.ClearWithDTR = chkClearWithDTR.Checked;

                   settings.BaudRate = 9600;

                   settings.Save();
               }
       */

        /// <summary> Populate the form's controls with default settings. </summary>
        private void InitializeControlValues()
        {
            // remove these and make static
            /*    cmbParity.Items.Clear(); cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
                cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
                cmbParity.Text = settings.Parity.ToString();
                cmbStopBits.Text = settings.StopBits.ToString();
                cmbDataBits.Text = settings.DataBits.ToString();
                cmbParity.Text = settings.Parity.ToString();
                cmbBaudRate.Text = settings.BaudRate.ToString();
            */
            //CurrentDataMode = settings.DataMode;
            // CurrentDataMode = DataMode.Text; 
            CurrentDataMode = DataMode.Hex; 
            ///////////////////////////////////////////////////////
            RefreshComPortList();

            chkClearOnOpen.Checked = settings.ClearOnOpen;
            chkClearWithDTR.Checked = settings.ClearWithDTR;

            // If it is still avalible, select the last com port used
            if (cmbPortName.Items.Contains(settings.PortName)) cmbPortName.Text = settings.PortName;
            else if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = cmbPortName.Items.Count - 1;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary> Enable/disable controls based on the app's current state. </summary>
        private void EnableControls()
        {
            // Enable/disable controls based on whether the port is open or not
            gbPortSettings.Enabled = !comport.IsOpen;
            txtSendData.Enabled = btnSend.Enabled = comport.IsOpen;
            //chkDTR.Enabled = chkRTS.Enabled = comport.IsOpen;

            if (comport.IsOpen) btnOpenPort.Text = "&Close Port";
            else btnOpenPort.Text = "&Open Port";
        }

        /// <summary> Send the user's data currently entered in the 'send' box.</summary>
        private void SendData()
        {
            if (CurrentDataMode == DataMode.Text)
            {
                // Send the user's text straight out the port
                comport.Write(txtSendData.Text);

                // Show in the terminal window the user's text
                Log(LogMsgType.Outgoing, txtSendData.Text + "\n");
            }
            else
            {
                try
                {
                    // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
                    byte[] data = HexStringToByteArray(txtSendData.Text);

                    // Send the binary data out the port
                    comport.Write(data, 0, data.Length);

                    // Show the hex digits on in the terminal window
                    Log(LogMsgType.Outgoing, ByteArrayToHexString(data) + "\n");
                }
                catch (FormatException)
                {
                    // Inform the user if the hex string was not properly formatted
                    Log(LogMsgType.Error, "Not properly formatted hex string: " + txtSendData.Text + "\n");
                }
            }
            txtSendData.SelectAll();
        }

        /// <summary> Log data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        private void Log(LogMsgType msgtype, string msg)
        {
            if(engineerMode)
            { 
            rtfTerminal.Invoke(new EventHandler(delegate
            {
                rtfTerminal.SelectedText = string.Empty;
                rtfTerminal.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
                rtfTerminal.SelectionColor = LogMsgTypeColor[(int)msgtype];
                rtfTerminal.AppendText(msg);
                rtfTerminal.ScrollToCaret();
            }));
                }
        }

        /// <summary> Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>
        /// <param name="s"> The string containing the hex digits (with or without spaces). </param>
        /// <returns> Returns an array of bytes. </returns>
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
        /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
        /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        #endregion Local Methods

        #region Local Properties

        private DataMode CurrentDataMode
        {
            get
            {
               // if (rbHex.Checked) return DataMode.Hex;
                 return DataMode.Hex;
            }
            set
            {
               // if (value == DataMode.Text) rbText.Checked = true;
              //  else rbHex.Checked = true;
            }
        }

        #endregion Local Properties

        #region Event Handlers

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show the user the about dialog
            (new frmAbout()).ShowDialog(this);
        }

        private void frmTerminal_Shown(object sender, EventArgs e)
        {
            Log(LogMsgType.Normal, String.Format("Application Started at {0}\n", DateTime.Now));
        }

        private void frmTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // The form is closing, save the user's preferences
                //SaveSettings();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            bool error = false;
            //           if (this.f2.GravityRichTextBox1.InvokeRequired)

            // If the port is open, close it.
            if (comport.IsOpen) comport.Close();
            else
            {
                // Set the port's settings
                comport.BaudRate = 9600;                                            // int.Parse(cmbBaudRate.Text);
                comport.DataBits = 8;                                               // int.Parse(cmbDataBits.Text);
                comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");   // (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                comport.Parity = (Parity)Enum.Parse(typeof(Parity), "None"); ;      // (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                comport.PortName = cmbPortName.Text;

                try
                {
                    // Open the port
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    // Show the initial pin states
                    UpdatePinState();
                }
            }

            // Change the state of the form's controls
            EnableControls();

            // If the port is open, send focus to the send data box
            if (comport.IsOpen)
            {
                txtSendData.Focus();
                if (chkClearOnOpen.Checked) ClearTerminal();
            }
        }





        /// <summary>
        /// SEND DATA COMMAND
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        { SendData(); }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!comport.IsOpen) return;
            Thread.Sleep(100);
            // This method will be called when there is data waiting in the port's buffer

            // Determain which mode (string or binary) the user is in
            if (CurrentDataMode == DataMode.Text)
            {
                // Read all the data waiting in the buffer
                string data = comport.ReadExisting();

                // Display the text to the user in the terminal
                Log(LogMsgType.Incoming, data);
            }
            else
            {

                int bytes = comport.BytesToRead;            // Obtain the number of bytes waiting in the port's buffer

                byte[] buffer = new byte[bytes];            // Create a byte array buffer to hold the incoming data
                //        byte[] buffer = new byte[];


                comport.Read(buffer, 0, bytes);             // Read the data from the port and store it in our buffer


                Log(LogMsgType.Incoming, ByteArrayToHexString(buffer)); // Show the user the incoming data in hex format

                InputData1Second InputInputBuffer = new InputData1Second();
                mdt.GetMeterData(buffer);// send buffer for parsing

                using (StreamWriter w = File.AppendText("testLog.txt"))
                {
                    //         Log("Buffer      " + ByteArrayToHexString( buffer), w);
                    Log("meterBytes  " + ByteArrayToHexString(mdt.PubmeterBytes), w);
                }

                ThreadProcSafe();

                //          UpdateTextBox(DateTime newDT, double ST, double Beam);

                //           f2.GravityRichTextBox1.Text = Convert.ToString(mdt.myDT ) +  "         " + Convert.ToString(mdt.ST ) + "             " + Convert.ToString(mdt.Beam) + "/n/n";
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.WriteLine("  {0}", logMessage);
        }

        private void SetupGravityChart()
        {
         
        }

        private void ThreadProcSafe()
        {
            // Wait two seconds to simulate some background work
            // being done.
            //       Thread.Sleep(2000);

            SetupGravityChart();

            DateTime tempDate = new DateTime(2015, 1, 1, 0, 0, 0); ;

            tempDate = tempDate.AddDays(mdt.day - 1);
            tempDate = tempDate.AddYears(mdt.year - 2015);
            tempDate = tempDate.AddHours(mdt.Hour);
            tempDate = tempDate.AddMinutes(mdt.Min);
            tempDate = tempDate.AddSeconds(mdt.Sec);

            //        string text = Convert.ToString(mdt.myDT) + "\t\t" + Convert.ToString(mdt.ST) + "\t\t" + Convert.ToString(mdt.Beam);
            string text = Convert.ToString(mdt.year) + "    " + Convert.ToString(mdt.day) + "    " + Convert.ToString(mdt.Hour) + ":" + Convert.ToString(mdt.Min) + ":" + Convert.ToString(mdt.Sec) + "\t\t" + Convert.ToString(mdt.ST) + "\t\t\t" + Convert.ToString(mdt.Beam);

            if (mdt.validData == true)
            {
                // Check if this method is running on a different thread
                // than the thread that created the control.
                if (myGravityDataForm.gravityDataGridView.InvokeRequired)

                {
                    // It's on a different thread, so use Invoke.
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text, tempDate, mdt.Beam });
                    //                Thread.Sleep(10000);
                }
                else
                {
                    // It's on the same thread, no need for Invoke
                    myGravityDataForm.gravityDataGridView.Text = text + " (No Invoke)";
                }
            }

            //        this.Invoke(d, new object[] { text });
        }

        // This method is passed in to the SetTextCallBack delegate
        // to set the Text property of textBox1.
        private void SetText(string text, DateTime time, double Yval)
        {
            GravityDataForm GravityForm = new GravityDataForm();
            GravityChartForm myGravityChart = new GravityChartForm();

         //   GravityForm.gravityDataGridView.AppendText(text + "\n");   //  Convert.ToString(mdt.myDT) + "\t\t" + Convert.ToString(mdt.ST) + "\t\t" + Convert.ToString(mdt.Beam) + "\n"; ;
            myGravityChart.GravityChart.Series["Series1"].Points.AddXY(time, Yval);
        }

        private void txtSendData_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses [ENTER], send the data now
            if (KeyHandled = e.KeyCode == Keys.Enter) { e.Handled = true; SendData(); }
        }

        private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = KeyHandled; }

        #endregion Event Handlers

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTerminal();
        }

        private void ClearTerminal()
        {
            rtfTerminal.Clear();
        }

        private void tmrCheckComPorts_Tick(object sender, EventArgs e)
        {
            // checks to see if COM ports have been added or removed
            // since it is quite common now with USB-to-Serial adapters
            RefreshComPortList();
        }

        private void RefreshComPortList()
        {
            // Determain if the list of com port names has changed since last checked
            string selected = RefreshComPortList(cmbPortName.Items.Cast<string>(), cmbPortName.SelectedItem as string, comport.IsOpen);

            // If there was an update, then update the control showing the user the list of port names
            if (!String.IsNullOrEmpty(selected))
            {
                cmbPortName.Items.Clear();
                cmbPortName.Items.AddRange(OrderedPortNames());
                cmbPortName.SelectedItem = selected;
            }
        }

        private string[] OrderedPortNames()
        {
            // Just a placeholder for a successful parsing of a string to an integer
            int num;

            // Order the serial port names in numberic order (if possible)
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray();
        }

        private string RefreshComPortList(IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
        {

            string selected = null;// Create a new return report to populate
            string[] ports = SerialPort.GetPortNames();// Retrieve the list of ports currently mounted by the operating system (sorted by name)
            bool updated = PreviousPortNames.Except(ports).Count() > 0 || ports.Except(PreviousPortNames).Count() > 0;// First determain if there was a change (any additions or removals)


            if (updated)    // If there was a change, then select an appropriate default port
            {

                ports = OrderedPortNames(); // Use the correctly ordered set of port names

                // Find newest port if one or more were added
                string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

                if (PortOpen)// If the port was already open... (see logic notes and reasoning in Notes.txt)
                {
                    if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                    else if (!String.IsNullOrEmpty(newest)) selected = newest;
                    else selected = ports.LastOrDefault();
                }
                else
                {
                    if (!String.IsNullOrEmpty(newest)) selected = newest;
                    else if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                    else selected = ports.LastOrDefault();
                }
            }

            return selected;// If there was a change to the port list, return the recommended default selection
        }

       

     

        private void engineerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerConfigurationForm myEngineeringConfigurationForm = new EngineerConfigurationForm();

            myEngineeringConfigurationForm.Show();
        }

        private void switchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchesForm mySwitchesForm = new SwitchesForm();
            mySwitchesForm.Show();
        }

        private void serialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialForm mySerialForm = new SerialForm();
            mySerialForm.Show();
        }


        private void setDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDateTimeForm mySetDateTimeForm = new SetDateTimeForm();
            mySetDateTimeForm.Show();
        }

        private void setSpringTensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpringTensionForm mySpringTensionForm = new SpringTensionForm();
            mySpringTensionForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the user the about dialog
            (new frmAbout()).ShowDialog(this);
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileConfigurationForm myFileConfigurationForm = new FileConfigurationForm();
            myFileConfigurationForm.Show();
        }

        private void frmTerminal_Load(object sender, EventArgs e)
        {
            if (engineerMode)
            {
                rtfTerminal.Visible = true;
            }
            else
            {
                rtfTerminal.Visible = false;
            }
        }

      //  private int iPort(int x)
      //  {
      //      return x;
      //  }


        private void sendCommand(int id, configData configData)
        {
           /* int[] transmitCommand = new int[25];
               for (int i = 0; i < 25; i++)
			{
			 transmitCommand[i] = 0;
			}
               */
            int nBytes;
/*
        switch(id)
        {
            case 0:// SEND RELAY SWITCHES
                {
                    int[] transmitCommand;
                    transmitCommand[1] = id;
                    transmitCommand[2] = iPort[1];
                nBytes = 1;
                     XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
                break;
                }

        case 1: //SEND CONTROL SWITCHES
            {
            int[] transmitCommand;
                    transmitCommand[1] = id;
                    transmitCommand[2] = (ICNTLSW & 0xFF);
            nBytes = 1;
 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
       	 	break;
        }
        case 2: //UPDATE TIME AND DATE
            {
                int[] transmitCommand;
                    transmitCommand[1] = id;
            transmitCommand[2] = IYR & 0xFF;
            transmitCommand[3] = IYR << 8 & 0xFF;     //ISHFT(IYR,-8) & 0xFF;
            transmitCommand[4] = IDAY & 0xFF;
            transmitCommand[5] = IDAY<< 8  & 0xFF; //ISHFT(idAY,-8) && 0xFF;
            transmitCommand[6] = IHR & 0xFF;
            transmitCommand[7] = MIN & 0xFF;
            transmitCommand[8] = ISEC & 0xFF;
            nBytes = 7;
                 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
         break;
        }
        case 3: //SLEW ST
            {
                int[] transmitCommand;
                    transmitCommand[1] = id;
            transmitCommand[2] = (ISTEP && 0xFF);
            transmitCommand[3] = (ISTEP<<8 && 0xFF);
            nBytes = 2;
                 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
            break;
        }
        case 4: //SET CROSS AXIS PARAMETERS
            {
                int[] transmitCommand;
                    transmitCommand[1] = id;
            dice(configData.APERX,transmitCommand[5],transmitCommand[4],transmitCommand[3],transmitCommand[2]);
            dice(configData.ADAMPX,transmitCommand[9],transmitCommand[8],transmitCommand[7],transmitCommand[6]);
            dice(configData.AGAINX,transmitCommand[13],transmitCommand[12],transmitCommand[11],transmitCommand[10]);
            dice(configData.ALEADX,transmitCommand[17],transmitCommand[16],transmitCommand[15],transmitCommand[14]);
            dice(configData.CCFACT13,transmitCommand[21],transmitCommand[20],transmitCommand[19],transmitCommand[18]);
            dice(configData.AFILT5,transmitCommand[25],transmitCommand[24],transmitCommand[23],transmitCommand[22]);
           nBytes = 24;
                 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
        break;
        }
        case 5://SET LONG AXIS PARAMETERS
            {
                configData configData = new configData();
                int[] transmitCommand;
                transmitCommand[1] = id;
                dice(configData.APERL,transmitCommand[5],transmitCommand[4],transmitCommand[3],transmitCommand[2]);
                dice(configData.ADAMPL,transmitCommand[9],transmitCommand[8],transmitCommand[7],transmitCommand[6]);
                dice(configData.AGAINL,transmitCommand[13],transmitCommand[12],transmitCommand[11],transmitCommand[10]);
                dice(configData.ALEADL,transmitCommand[17],transmitCommand[16],transmitCommand[15],transmitCommand[14]);
                dice(configData.CCFACT14,transmitCommand[21],transmitCommand[20],transmitCommand[19],transmitCommand[18]);
                dice(configData.AFILT6,transmitCommand[25],transmitCommand[24],transmitCommand[23],transmitCommand[22]);
                nBytes = 24;
                 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
            break;
        }
        case 6://SET GAIN FOR AUX A/D CHANNELS
            {
                int[] transmitCommand;
                    transmitCommand[1] = id;
                            transmitCommand[2] = IAUXGAIN[1];
            transmitCommand[3] = IAUXGAIN[2];
            transmitCommand[4] = IAUXGAIN[3];
            transmitCommand[5] = IAUXGAIN[4];
            nBytes = 4;
                 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
            break;
            }
        case 7://UPDATE SPRING TENSION VALUE
            {
                int[] transmitCommand;
                transmitCommand[1] = id;
                dice(ST,transmitCommand[5],transmitCommand[4],transmitCommand[3],transmitCommand[2]);
                nBytes = 4;
                XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
                break;
            }
       
        case 8: //UPDATE C//  VALUES
            {
                int[] transmitCommand;
                transmitCommand[1] = id;
                dice(AFILT[1],transmitCommand[5],transmitCommand[4],transmitCommand[3],transmitCommand[2]);
                dice(AFILT[2],transmitCommand[9],transmitCommand[8],transmitCommand[7], transmitCommand[6]);
                dice(AFILT[4],transmitCommand[13],transmitCommand[12],transmitCommand[11],transmitCommand[10]);
                dice(AFILT[3],transmitCommand[17],transmitCommand[16],transmitCommand[15],transmitCommand[14]);
                dice(BSCALE,transmitCommand[21],transmitCommand[20],transmitCommand[19],transmitCommand[18]);
                dice(STMAX,transmitCommand[25],transmitCommand[24],transmitCommand[23],transmitCommand[22]);
                nBytes = 24;
                XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
                break;
            }
        case 9:
            {
                int[] transmitCommand;
                    transmitCommand[1] = id;
                 XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
        break;
            }
            case 10:
                {
                    int[] transmitCommand;
                    transmitCommand[1] = id;
                    dice(   configData.GXBIAS,transmitCommand[5],transmitCommand[4],transmitCommand[3],transmitCommand[2));
                    dice(GLBIAS,transmitCommand[9],transmitCommand[8],transmitCommand[7],transmitCommand[6));
                    nBytes = 8;
                    XMIT (transmitCommand,nBytes); // NUMBER OF DATA BYTES TO SEND
                     break;
                }
            
               
        }*/
        }

        private void dice(double a, int b, int c, int d, int e)
        {
        }
        private void XMIT(int[] cmd, int nbytes)
        {

        }


        private void ReadConfigData()
        {
        //    configData  configData = new configData();
        //    return configData[];
        }
        private void VerifyData()
        {

        }

        private void gravityChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myGravityChartForm != null)
            {
                myGravityChartForm.Show();
            }
            else
            {
                myGravityChartForm.Hide();
            }
       
        }

        private void gravityDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myGravityDataForm != null)
            {
                myGravityDataForm.Show();
            }
            else
            {
                myGravityDataForm.Hide();
            }
        }

        private void crossCouplingChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myCrossCouplingChartFrom != null)
            {
                myCrossCouplingChartFrom.Show();
            }
            else
            {
                myCrossCouplingChartFrom.Hide();
            }
        }

        private void crossCouplingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myCrossCouplingDataForm != null)
            {
                myCrossCouplingDataForm.Show();
            }
            else
            {
                myCrossCouplingDataForm.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }




 /*      public void NewMeterData(byte[] meterBytes)
        {

            GetMeterData getMeterData = new GetMeterData();
             byte[] PubmeterBytes;
            validData = false;  // ASSUME DATA IS GARBAGE
            PubmeterBytes = meterBytes;
            //GET SPRING TENSION
            byte[] tempByte = { 0, 0, 0, 0 };
            byte[] tempByte2 = { 0, 0 };

            // check for correct checksum & number of bytes

            //Add switch statement for various commands

            if (meterBytes.Length >= 0x4E)
            {
                int dataLen;

                tempByte[0] = meterBytes[0];
                tempByte[1] = 0;
                tempByte[2] = 0;
                tempByte[3] = 0;
                dataLen = BitConverter.ToInt32(tempByte, 0);

                unchecked
                {
                    for (int i = 0; i < dataLen - 1; i++)
                    {
                        sum += meterBytes[i];
                    }
                }

                int Rcmd = 99;

                tempByte[0] = meterBytes[1];
                tempByte[1] = 0;
                tempByte[2] = 0;
                tempByte[3] = 0;
                Rcmd = BitConverter.ToInt32(tempByte, 0);

                if (Rcmd == 0 || dataLen == 0x4E)
                {
                    validData = true;

                    tempByte[0] = meterBytes[6];
                    tempByte[1] = 0;
                    tempByte[2] = 0;
                    tempByte[3] = 0;
                    Hour = BitConverter.ToInt32(tempByte, 0);

                    tempByte[0] = meterBytes[7];
                    tempByte[1] = 0;
                    tempByte[2] = 0;
                    tempByte[3] = 0;
                    Min = BitConverter.ToInt32(tempByte, 0);

                    tempByte[0] = meterBytes[8];
                    tempByte[1] = 0;
                    tempByte[2] = 0;
                    tempByte[3] = 0;
                    Sec = BitConverter.ToInt32(tempByte, 0);

                    //   myDT = myDT.AddHours(Hour);
                    //   myDT = myDT.AddMinutes(Min);
                    //   myDT = myDT.AddSeconds(Sec);

                    tempByte[0] = meterBytes[4];
                    tempByte[1] = meterBytes[5];
                    day = BitConverter.ToInt32(tempByte, 0);
                    //  day = day - 1;
                    //  myDT = myDT.AddDays(day);

                    //            LiveMeterData[dataCounter].myDT = myDT;

                    tempByte[0] = meterBytes[2];
                    tempByte[1] = meterBytes[3];
                    year = BitConverter.ToInt32(tempByte, 0);
                    //  if (year > 2015) year = 2015;
                    // year = year - 2015;
                    //   myDT = myDT.AddYears(year);

                    tempByte[0] = meterBytes[9];
                    tempByte[1] = meterBytes[10];
                    tempByte[2] = meterBytes[11];
                    tempByte[3] = meterBytes[12];
                    //   Array.Reverse(tempByte);

                    st = BitConverter.ToSingle(tempByte, 0);
                    //   DATA[1, 3] = ST;

                    //GET RAW BEAM  ------------------------------------------------------------
                    tempByte[0] = meterBytes[13];
                    tempByte[1] = meterBytes[14];
                    tempByte[2] = meterBytes[15];
                    tempByte[3] = meterBytes[16];
                    beam = BitConverter.ToSingle(tempByte, 0);
                    //       DATA[1, 5] = Beam;

                    //GET VCC  ------------------------------------------------------------
                    tempByte[0] = meterBytes[17];
                    tempByte[1] = meterBytes[18];
                    tempByte[2] = meterBytes[19];
                    tempByte[3] = meterBytes[20];
                    vcc = BitConverter.ToSingle(tempByte, 0);
                    // DATA[1, 6] = VCC;

                    //GET AL  ------------------------------------------------------------
                    tempByte[0] = meterBytes[21];
                    tempByte[1] = meterBytes[22];
                    tempByte[2] = meterBytes[23];
                    tempByte[3] = meterBytes[24];
                    al = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 7] = AL;

                    //GET AX  ------------------------------------------------------------
                    tempByte[0] = meterBytes[25];
                    tempByte[1] = meterBytes[26];
                    tempByte[2] = meterBytes[27];
                    tempByte[3] = meterBytes[28];
                    ax = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 8] = AX;

                    //GET VE  ------------------------------------------------------------
                    tempByte[0] = meterBytes[29];
                    tempByte[1] = meterBytes[30];
                    tempByte[2] = meterBytes[31];
                    tempByte[3] = meterBytes[32];
                    ve = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 9] = VE;

                    //GET AX2  ------------------------------------------------------------
                    tempByte[0] = meterBytes[33];
                    tempByte[1] = meterBytes[34];
                    tempByte[2] = meterBytes[35];
                    tempByte[3] = meterBytes[36];
                    ax2 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 10] = AX2;

                    //GET XACC2  ------------------------------------------------------------
                    tempByte[0] = meterBytes[37];
                    tempByte[1] = meterBytes[38];
                    tempByte[2] = meterBytes[39];
                    tempByte[3] = meterBytes[40];
                    xacc2 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 11] = XACC2;

                    //GET LACC2  ------------------------------------------------------------

                    tempByte[0] = meterBytes[41];
                    tempByte[1] = meterBytes[42];
                    tempByte[2] = meterBytes[43];
                    tempByte[3] = meterBytes[44];
                    lacc2 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 12] = LACC2;

                    //GET XACC  ------------------------------------------------------------
                    tempByte[0] = meterBytes[45];
                    tempByte[1] = meterBytes[46];
                    tempByte[2] = meterBytes[47];
                    tempByte[3] = meterBytes[48];
                    xacc = BitConverter.ToSingle(tempByte, 0);
                    // DATA[1, 13] = XACC;

                    //GET LACC  ------------------------------------------------------------
                    tempByte[0] = meterBytes[49];
                    tempByte[1] = meterBytes[50];
                    tempByte[2] = meterBytes[51];
                    tempByte[3] = meterBytes[52];
                    lacc = BitConverter.ToSingle(tempByte, 0);
                    // DATA[1, 14] = LACC;

                    //GET AUX1  ------------------------------------------------------------
                    tempByte[0] = meterBytes[53];
                    tempByte[1] = meterBytes[54];
                    aux1 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 15] = AUX1;

                    //GET AUX2  ------------------------------------------------------------
                    tempByte[0] = meterBytes[55];
                    tempByte[1] = meterBytes[56];
                    aux2 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 16] = AUX2;

                    //GET AUX3  ------------------------------------------------------------
                    tempByte[0] = meterBytes[57];
                    tempByte[1] = meterBytes[58];
                    aux3 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 17] = AUX3;

                    //GET AUX4  ------------------------------------------------------------
                    tempByte[0] = meterBytes[59];
                    tempByte[1] = meterBytes[60];
                    aux4 = BitConverter.ToSingle(tempByte, 0);
                    //DATA[1, 18] = AUX4;

                    //GET +28V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[64];
                    tempByte[1] = meterBytes[65];
                    int p28Vi = BitConverter.ToInt32(tempByte, 0);
                    systemVoltageP28V = Convert.ToDouble(p28Vi * 2 / 3276.7);
                    //     IVOLTS[1] = p28V;

                    //GET -28V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[66];
                    tempByte[1] = meterBytes[67];
                    int n28Vi = BitConverter.ToInt32(tempByte, 0);
                    systemVoltageN28V = Convert.ToDouble(n28Vi * -5 / 3276.7);   //  check this conversion
                    //     IVOLTS[1] = n28V;

                    //GET +24V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[68];
                    tempByte[1] = meterBytes[69];
                    int p24Vi = BitConverter.ToInt32(tempByte, 0);
                    systemVoltageP24V = Convert.ToDouble(p24Vi * 2 / 3276.7);
                    //     IVOLTS[1] = p24V;

                    //GET+15V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[70];
                    tempByte[1] = meterBytes[71];
                    int p15Vi = BitConverter.ToInt32(tempByte, 0);
                    systemVoltageP15V = Convert.ToDouble(p15Vi / 3276.7);   //  check this conversion
                    //     IVOLTS[1] = p15V;

                    //GET -15V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[72];
                    tempByte[1] = meterBytes[73];
                    int n15Vi = BitConverter.ToInt32(tempByte, 0);
                    systemVoltageN15V = Convert.ToDouble(n15Vi * -3 / 3276.7);   //  check this conversion
                    //    IVOLTS[1] = n15V;

                    //GET +5V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[74];
                    tempByte[1] = meterBytes[75];
                    int p5Vi = BitConverter.ToInt32(tempByte, 0);
                    systemVoltageP5V = Convert.ToDouble(p5Vi / 3 / 3276.7);   //  check this conversion
                    //        IVOLTS[1] = p5V;

                    //GET STATUS  ------------------------------------------------------------
                    tempByte[0] = meterBytes[76];
                    //ISTAT = tempByte[0];

                    //GET PORT C INPUT  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[77];

                    // iPort[2] = tempByte[0];
                    //if (ISCSW == -99)
                    //{
                    // exit gracefully???????
                    //}
                    // CHECK FOR REMOTE EMBEDDED COMPUTER REBOOT  ------------------------------------------------------------
                    //       else if(IBUF[1] == 1) // remote rebooted
                    //       {
                    //IERR = -4;
                    //       }
                    // CHECK FOR TIME SET SUCCESSFULL/ FAIL  ------------------------------------------------------------
                    //       else if(IBUF[1] == 2) // Time set successfull
                    //       {
                    //           IERR = -10;
                    //       }
                    //       else if(IBUF[1] == 3) // Time set fail
                    //       {
                    //           IERR = -11;
                    //       }
                    //CHECK G2000 BIAS  ------------------------------------------------------------
                    //       else if(IBUF[1] == 4)//
                    //       {
                    // tempByte[0] = IBUF[2];
                    //tempByte[1] = IBUF[3];
                    //tempByte[2] = IBUF[4];
                    //tempByte[3] = IBUF[5];
                    //G2000 = BitConverter.ToSingle(tempByte, 0);
                    //          GXTEMP = G2000
                    //       }
                }
            }
        }*/

    }
}
        