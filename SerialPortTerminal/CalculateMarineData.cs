using System;
using System.Globalization;

namespace SerialPortTerminal
{
    /*Data Structures

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    IPORT(1)

    BIT
    0	200 HZ RELAY
    1	TORQUE RELAY
    2	ALARM
    3	STEPPING MOTOR DIRECTION
    4	TTL OR SLEW
    5	TTL OR SLEW
    6	TRIGGER 5M
    7	SM ENABLE

    IPORT(2)	INPUT DATA FROM PORT C

    IPORT(3)

    BIT
    0	NO ACTION
    1	INITILIZE PRINTER FOR GRAPHICS
    2	INITILIZE PRINTER FOR LINE PRINTING
    3	WRITE TIME TAG AND GRAPHIC RECORD
    4	PRINT NUMERICAL DATA
    5	PRINT GRAPHICAL DATA
    6	RELEASE PRINTER

    */

    // add structure for data from meter
    // add structure for calculated date
    // add structure for calibration data
    // add structure for settings
    // add structure for send data???????

    public class CalculateMarineData
    {
        // Take serial data from meter and separate into various variables and commands
        public byte[] meterBytes;

        public int dataCounter = 0;
        public byte[] PubmeterBytes;

        // public DateTime
        public float ST;

        public float Beam;
        public float VCC;
        public float AL;
        public float AX;
        public float VE;
        public float AX2;
        public float XACC2;
        public float LACC2;
        public float XACC;
        public float LACC;
        public float AUX1;
        public float AUX2;
        public float AUX3;
        public float AUX4;
        public double p28V;
        public double n28V;
        public double p24V;
        public double p15V;
        public double n15V;
        public double p5V;
        public int MeterSTATUS;
        public int REMOTEREBOOTED;
        public int TimeSetSuccess;
        public int G2000Bias0;
        public int year;
        public int day;
        public int Hour, Min, Sec;
        public bool validData = false;
        public byte sum = 0;

        //////////////////////////////////////////////////////////////////////////////////////
        //                  variables from old program
        //////////////////////////////////////////////////////////////////////////////////////
        private double VERS = 3.55;

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
        private int IDSKFLG, ICOMFLG;

        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////

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

        private InputData1Second InputData = new InputData1Second();

        // Sets a DateTime to April 3, 2002 of the Gregorian calendar.
        public DateTime myDT = new DateTime(2015, 1, 1, new GregorianCalendar());

        // Creates an instance of the JulianCalendar.
        public JulianCalendar myCal = new JulianCalendar();

        //     MeterData[] LiveMeterData;

        public void initializeDataCounter(int newval)
        {
            dataCounter = newval;
        }

        public void GetMeterData(byte[] meterBytes)
        {


            //  Control words
            //  0   ONE SEC  DATA RECORD
            //  1   REMOTE REBOOTED
            //  2   TIME RESET SUCCESFUL 
            //  3   TIME RESET FAILED 
            //  4   G2000 BIAS



            validData = false;  // ASSUME DATA IS GARBAGE
            PubmeterBytes = meterBytes;
            //GET SPRING TENSION
            byte[] tempByte = { 0, 0, 0, 0 };
            byte[] tempByte2 = { 0, 0 };
            InputData1Second InputData = new InputData1Second();
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

                    ST = BitConverter.ToSingle(tempByte, 0);
                    data1[3] = ST;

                    //GET RAW BEAM  ------------------------------------------------------------
                    tempByte[0] = meterBytes[13];
                    tempByte[1] = meterBytes[14];
                    tempByte[2] = meterBytes[15];
                    tempByte[3] = meterBytes[16];
                    Beam = BitConverter.ToSingle(tempByte, 0);
                    data1[5] = Beam;

                    //GET VCC  ------------------------------------------------------------
                    tempByte[0] = meterBytes[17];
                    tempByte[1] = meterBytes[18];
                    tempByte[2] = meterBytes[19];
                    tempByte[3] = meterBytes[20];
                    VCC = BitConverter.ToSingle(tempByte, 0);
                    data1[6] = VCC;

                    //GET AL  ------------------------------------------------------------
                    tempByte[0] = meterBytes[21];
                    tempByte[1] = meterBytes[22];
                    tempByte[2] = meterBytes[23];
                    tempByte[3] = meterBytes[24];
                    AL = BitConverter.ToSingle(tempByte, 0);
                    data1[7] = AL;

                    //GET AX  ------------------------------------------------------------
                    tempByte[0] = meterBytes[25];
                    tempByte[1] = meterBytes[26];
                    tempByte[2] = meterBytes[27];
                    tempByte[3] = meterBytes[28];
                    AX = BitConverter.ToSingle(tempByte, 0);
                    data1[8] = AX;

                    //GET VE  ------------------------------------------------------------
                    tempByte[0] = meterBytes[29];
                    tempByte[1] = meterBytes[30];
                    tempByte[2] = meterBytes[31];
                    tempByte[3] = meterBytes[32];
                    VE = BitConverter.ToSingle(tempByte, 0);
                    data1[9] = VE;

                    //GET AX2  ------------------------------------------------------------
                    tempByte[0] = meterBytes[33];
                    tempByte[1] = meterBytes[34];
                    tempByte[2] = meterBytes[35];
                    tempByte[3] = meterBytes[36];
                    AX2 = BitConverter.ToSingle(tempByte, 0);
                    data1[10] = AX2;

                    //GET XACC2  ------------------------------------------------------------
                    tempByte[0] = meterBytes[37];
                    tempByte[1] = meterBytes[38];
                    tempByte[2] = meterBytes[39];
                    tempByte[3] = meterBytes[40];
                    XACC2 = BitConverter.ToSingle(tempByte, 0);
                    data1[11] = XACC2;

                    //GET LACC2  ------------------------------------------------------------

                    tempByte[0] = meterBytes[41];
                    tempByte[1] = meterBytes[42];
                    tempByte[2] = meterBytes[43];
                    tempByte[3] = meterBytes[44];
                    LACC2 = BitConverter.ToSingle(tempByte, 0);
                    data1[12] = LACC2;

                    //GET XACC  ------------------------------------------------------------
                    tempByte[0] = meterBytes[45];
                    tempByte[1] = meterBytes[46];
                    tempByte[2] = meterBytes[47];
                    tempByte[3] = meterBytes[48];
                    XACC = BitConverter.ToSingle(tempByte, 0);
                    data1[13] = XACC;

                    //GET LACC  ------------------------------------------------------------
                    tempByte[0] = meterBytes[49];
                    tempByte[1] = meterBytes[50];
                    tempByte[2] = meterBytes[51];
                    tempByte[3] = meterBytes[52];
                    LACC = BitConverter.ToSingle(tempByte, 0);
                    data1[14] = LACC;

                    //GET AUX1  ------------------------------------------------------------
                    tempByte[0] = meterBytes[53];
                    tempByte[1] = meterBytes[54];
                    AUX1 = BitConverter.ToSingle(tempByte, 0);
                    data1[15] = AUX1;

                    //GET AUX2  ------------------------------------------------------------
                    tempByte[0] = meterBytes[55];
                    tempByte[1] = meterBytes[56];
                    AUX2 = BitConverter.ToSingle(tempByte, 0);
                    data1[16] = AUX2;

                    //GET AUX3  ------------------------------------------------------------
                    tempByte[0] = meterBytes[57];
                    tempByte[1] = meterBytes[58];
                    AUX3 = BitConverter.ToSingle(tempByte, 0);
                    data1[17] = AUX3;

                    //GET AUX4  ------------------------------------------------------------
                    tempByte[0] = meterBytes[59];
                    tempByte[1] = meterBytes[60];
                    AUX4 = BitConverter.ToSingle(tempByte, 0);
                    data1[18] = AUX4;

                    //GET +28V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[64];
                    tempByte[1] = meterBytes[65];
                    int p28Vi = BitConverter.ToInt32(tempByte, 0);
                    p28V = Convert.ToDouble(p28Vi * 2 / 3276.7);
                    //     IVOLTS[1] = p28V;

                    //GET -28V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[66];
                    tempByte[1] = meterBytes[67];
                    int n28Vi = BitConverter.ToInt32(tempByte, 0);
                    n28V = Convert.ToDouble(n28Vi * -5 / 3276.7);   //  check this conversion
                    //     IVOLTS[1] = n28V;

                    //GET +24V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[68];
                    tempByte[1] = meterBytes[69];
                    int p24Vi = BitConverter.ToInt32(tempByte, 0);
                    p24V = Convert.ToDouble(p24Vi * 2 / 3276.7);
                    //     IVOLTS[1] = p24V;

                    //GET+15V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[70];
                    tempByte[1] = meterBytes[71];
                    int p15Vi = BitConverter.ToInt32(tempByte, 0);
                    p15V = Convert.ToDouble(p15Vi / 3276.7);   //  check this conversion
                    //     IVOLTS[1] = p15V;

                    //GET -15V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[72];
                    tempByte[1] = meterBytes[73];
                    int n15Vi = BitConverter.ToInt32(tempByte, 0);
                    n15V = Convert.ToDouble(n15Vi * -3 / 3276.7);   //  check this conversion
                    //    IVOLTS[1] = n15V;

                    //GET +5V  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[74];
                    tempByte[1] = meterBytes[75];
                    int p5Vi = BitConverter.ToInt32(tempByte, 0);
                    p5V = Convert.ToDouble(p5Vi / 3 / 3276.7);   //  check this conversion
                    //        IVOLTS[1] = p5V;

                    //GET STATUS  ------------------------------------------------------------
                    tempByte[0] = meterBytes[76];
                    ISTAT = tempByte[0];

                    //GET PORT C INPUT  ------------------------------------------------------------
                    for (int i = 0; i < 4; i++) { tempByte[i] = 0x00; }
                    tempByte[0] = meterBytes[77];
                    // IPORT[2] = tempByte[0];
                    if (ISCSW == -99)
                    {
                        // exit gracefully???????
                    }
                    // CHECK FOR REMOTE EMBEDDED COMPUTER REBOOT  ------------------------------------------------------------
                    //       else if(IBUF[1] == 1) // remote rebooted
                    //       {
                    IERR = -4;
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

                    //                   return (InputData);
                }
            }
        }


// ******************************************************************************************************************************





        //************** UPLOOK *****************************************
        // CONVERTS GRAVITY VALUES ACCORDING TO THE CALIBRATION TABLE
        // FOR METERS WITH A CONSTANT CALIBRATION FACTOR, A DUMMY
        // CALIBRATION TABLE MUST BE CREATED USING MKTABLE.
        private double GravCalAdjust(double gVal)
        {
            double uplook = 0;
            double ind;
            ind = gVal / 100;
            if (ind > 120) { ind = 120; }
            //             uplook = GravCalTable[1, ind] + (gVal - ind * 100) * GravCalTable[2, ind];
            return (uplook);
        }

        //   REAL FUNCTION UPLOOK (gVal)
        //    INCLUDE 'PROLOGUE.INC'
        //    ind = INT(gVal/100.)
        //    IF (ind > 120) ind = 120
        //    UPLOOK = TABLE(1,ind) + (gVal-REAL(ind*100))*TABLE(2,ind)
        //   RETURN

        //******************************************************************************************
        //                                  DO ONE SECOND STUFF
        //                          COMPUTE AND STORE CROSS-COUPLING
        //******************************************************************************************

        //  ****************** filter320 *******************************
        //  3 * 20 sec RC filter from 1 sec samples

        private void  filter320(double VIN, double F1, double F2, double F3)
          {

              F1 = F1 + (VIN - F1) * .05;//  (.05 = 1/20)
              F2 = F2 + (F1 - F2)  * .05;//  (.05 = 1/20)
              F3 = F3 + (F2 - F3)  * .05;//  (.05 = 1/20)
           // return VIN F1  F2 F3;
          }

        private void oneSecStuff()// change to array    double[] data1, double[] data2, double[] data3, double ccFact
        {
            DATA[1, 4] = 0.0;       //crossCoupling
            //sprintTension200Sum = 0;
            for (int i = 6; i < 12; i++)
            {
                DATA[1, 4] = DATA[1, 4] + DATA[1, i] * CCFACT[i];
                // InputData1Second.avgB = InputData1Second.avgB + CrossCouplingFactor.[i](6-11)
                for (int ii = 3; ii < 18; ii++)
                {
                    filter320(DATA[1, ii], DATA[2, ii], DATA[3, ii], DATA[4, ii]);
                    //file320(data1[i], data2[i], data3[i], data4[i]);

                    //filter320(InputData1Second.avgB, IntermediateFilterStage2.avgB , IntermediateFilterStage3.avgB, dataOutputBuffer.avgB
                    // .......
                    //filter320(InputData1Second.aux3, IntermediateFilterStage2.aux3 , IntermediateFilterStage3.aux3, dataOutputBuffer.aux3
                }
                if (MODESW == 1)          // HI RES I/O
                {
                    if (IDSKSW > 0 || JDSKSW > 0) IDSKFLG = 2;// need to check AND/ OR function here
                    if (ICOMSW == -1) ICOMFLG = 2;
                }
            }
        }

        //            if (IAND(ISTAT,#E0) == 0)
        //            { JERR = 0}; //LEAR ERROR COUNT IF OK;
        //                }

        // CrossCoupl = CrossCoupl +  (6,12) * CCFACT// where does this go??????

        // -----------------------------------------------------------------------------------------------
        //                                  compute gravity in mGAL
        //-----------------------------------------------------------------------------------------------
        private void computGravity()
        {
            double beam = 0;
            double delB = 0;
            double oldB = 0;
            double tc = 0;
            double rawg = 0;

            //BEAM = BSCALE * DATA[4, 5];//   avgBDataOutputBuffer data is lower case here but init it is upper case
            //           beam = beamScale * avgBOut;
            // BSCALE = 1.6;
            //DELB = BEAM - OLDB;
            delB = beam - oldB;
            // OLDB = BEAM;
            oldB = beam;
            //TC = DELB * 3 + DATA[4, 4];
            //            tc = delB * 3 + crossCouplingOut;
            //RAWG = DATA[4, 3] + TC;
            //            rawg = springTensionOut + tc;
            //DATA[4, 2] = DFILT(RAWG);
            //            digitalGravity = dift[rawg];
            //             GRAV = UPLOOK(DATA[4,2] + 0.05;
            DATA[1, 23] = tc;
            // data[1,x] only goes to 21
        }

        // ****************** DFILT *******************************
        // -----------------------------------------------------------------------------------------------
        //              PERFORMS 60 POINT DIGITAL FILTER ON GRAVITY
        // -----------------------------------------------------------------------------------------------

        private double dFilt(double g)
        {
            //        IMPLICIT INTEGER*2 (I-N)  // 2 byte int
            double[] fw = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] gt = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int nPoint = 0;
            int k = 0;

            //        DATA GT,NPOINT/60*0.,0/
            // FILTER WEIGHTS

            double[,] fData = new double[10, 6] {
            { -.00034,-.00038,-.00041,-.00044,-.00046,-.00046},
            { -.00044,-.00039,-.00030,-.00015,.00007,.00037},
            {  .00079,.00133,.00202,.00289,.00396,.00526},
            {  .00679,.00859,.01066,.01299,.01558,.01841},
            {  .02143,.02460,.02785,.03110,.03426,.03723},
            {  .03992,.04223,.04408,.04539,.04613,.04626},
            {  .04579,.04474,.04315,.04109,.03864,.03589},
            {  .03292,.02984,.02671,.02362,.02063,.01780},
            {  .01516,.01274,.01056,.00863,.00694,.00548},
            {  .00424,.00321,.00235,.00166,.00111,.00068}};

            //            SAVE
            nPoint = nPoint + 1;
            if (nPoint > 60) nPoint = 1;
            gt[nPoint] = g;
            k = nPoint;
            //        DFILT = 0.0;
            //       DO 100 I=1,
            for (int i = 0; i < 160; i++)
            {
                k = k + 1;
                if (k > 60) k = 1;

                //   DFILT = DFILT + FW[I]*(GT[K]-GT[1]);// 100
            }

            //        DFILT = DFILT + GT[1];
            //           dFilt = dFilt + gt[1];
            return k;
        }

        //-----------------------------------------------------------------------------------------------
        //  COMPUTE AND STORE CROSS COUPLING
        //-----------------------------------------------------------------------------------------------
        //DATA[1,3] = 0
        //


        







    }
}