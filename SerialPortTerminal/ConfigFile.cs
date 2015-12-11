using FileHelpers;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UltraSys
{
    class ConfigFile
    {

        private Boolean engineerDebug = false;
        private void ReadConfigFile()

        {


            
            //  NEED TO ADD ERROR CHECKING FOR END OF FILE
            //  NEED TO ADD OPEN FILE DIALOG ONLY IF FILE IS (MISSING OR MANUAL BOX IS CHECKED - ENGINEERING ONLY)
            ConfigData ConfigData = new ConfigData();
            FileStream myStream;
            double[] CCFACT = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] AFILT = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] tempByte = { 0, 0, 0, 0 };
            byte[] byte2 = new byte[2];
            byte[] byte4 = new byte[4];
            byte[] byte10 = new byte[10];

            try
            {
                myStream = new FileStream("C:\\LCT stuff\\CONFIG20.ref", FileMode.Open);
                BinaryReader readBinary = new BinaryReader(myStream);

                readBinary.Read(byte2, 0, 2);
                readBinary.Read(byte4, 0, 4);

                ConfigData.beamScale = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) if (engineerDebug) Console.WriteLine("BEAM SCALE FACTOR-------------------- \t{0:n6}.", ConfigData.beamScale);

                readBinary.Read(byte2, 0, 2);
                ConfigData.numAuxChan = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("NUMBER OF AUXILIARY ANALOG CHANNELS-- \t" + Convert.ToString(ConfigData.numAuxChan));

                readBinary.Read(byte10, 0, 10);
                ConfigData.meterNumber = System.Text.Encoding.Default.GetString(byte10);
                if (engineerDebug) Console.WriteLine("Meter number is---------------------- \t" + ConfigData.meterNumber);

                readBinary.Read(byte2, 0, 2);
                ConfigData.linePrinterSwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("LINE PRINTER SWITCH------------------ \t" + Convert.ToString(ConfigData.linePrinterSwitch));

                readBinary.Read(byte2, 0, 2);
                ConfigData.fileNameSwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("FILE NAME SWITCH--------------------- \t" + Convert.ToString(ConfigData.fileNameSwitch));

                readBinary.Read(byte2, 0, 2);
                ConfigData.hardDiskSwitch = BitConverter.ToInt16(byte2, 0); ;
                if (engineerDebug) Console.WriteLine("HARD DISK SWITCH--------------------- \t" + Convert.ToString(ConfigData.hardDiskSwitch));

                readBinary.Read(byte10, 0, 10);
                ConfigData.engPassword = System.Text.Encoding.Default.GetString(byte10);
                if (engineerDebug) Console.WriteLine("Magic value is ---------------------- \t" + ConfigData.engPassword);

                readBinary.Read(byte2, 0, 2);
                ConfigData.monitorDisplaySwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("MONITOR DISPLAY SWITCH--------------- \t" + Convert.ToString(ConfigData.monitorDisplaySwitch));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossPeriod = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS PERIOD-------------------- \t{0:e4}", ConfigData.crossPeriod);

                readBinary.Read(byte4, 0, 4);
                ConfigData.longPeriod = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG-AXIS PERIOD-------------------- \t{0:e4}", ConfigData.longPeriod);

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossDampFactor = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS DAMPING------------------- \t{0:e4}", ConfigData.crossDampFactor);

                readBinary.Read(byte4, 0, 4);
                ConfigData.longDampFactor = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG-AXIS DAMPING------------------- \t{0:e4}", ConfigData.longDampFactor);

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossGain = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS GAIN---------------------- \t" + Convert.ToString(ConfigData.crossGain));

                readBinary.Read(byte4, 0, 4);
                ConfigData.longGain = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG-AXIS GAIN---------------------- \t" + Convert.ToString(ConfigData.longGain));

                readBinary.Read(byte2, 0, 2);
                ConfigData.serialPortSwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("SERIAL PORT FORMAT SWITCH------------ \t" + Convert.ToString(ConfigData.serialPortSwitch));

                readBinary.Read(byte2, 0, 2);
                ConfigData.digitalInputSwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("DIGITAL INPUT SWITCH----------------- \t" + Convert.ToString(ConfigData.digitalInputSwitch));

                readBinary.Read(byte2, 0, 2);
                ConfigData.printerEmulationSwitch = BitConverter.ToInt16(byte2, 0);
                if (ConfigData.printerEmulationSwitch == 2)
                {
                    if (engineerDebug) Console.WriteLine("PRINTER EMULATION-------------------- \t" + "ESC_P");
                }
                if (ConfigData.printerEmulationSwitch == 3)
                {
                    if (engineerDebug) Console.WriteLine("PRINTER EMULATION-------------------- \t" + "ESC_P2");
                }
                else
                {
                    if (engineerDebug) Console.WriteLine("PRINTER EMULATION-------------------- \t" + "DPL24C");
                }

                readBinary.Read(byte2, 0, 2);
                ConfigData.serialPortOutputSwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("SERIAL PORT OUTPUT SWITCH------------ \t" + Convert.ToString(ConfigData.serialPortOutputSwitch));

                readBinary.Read(byte2, 0, 2);
                ConfigData.alarmSwitch = BitConverter.ToInt16(byte2, 0);
                if (engineerDebug) Console.WriteLine("ALARM SWITCH------------------------- \t" + Convert.ToString(ConfigData.alarmSwitch));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossLead = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS LEAD---------------------- \t" + Convert.ToString(ConfigData.crossLead));

                readBinary.Read(byte4, 0, 4);
                ConfigData.longLead = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG-AXIS LEAD---------------------- \t" + Convert.ToString(ConfigData.longLead));

                readBinary.Read(byte4, 0, 4);
                ConfigData.springTensionMax = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("MAXIMUM SPRING TENSION VALUE--------- \t" + Convert.ToString(ConfigData.springTensionMax));

                readBinary.Read(byte4, 0, 4);
                ConfigData.modeSwitch = BitConverter.ToInt16(byte4, 0);
                if (ConfigData.modeSwitch == 0)
                {
                    if (engineerDebug) Console.WriteLine("MODE SWITCH-------------------------- \t" + "Marine");
                }
                else
                {
                    if (engineerDebug) Console.WriteLine("MODE SWITCH-------------------------- \t" + "Hires");
                }

                readBinary.Read(byte4, 0, 4);
                ConfigData.iAuxGain = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("I aux gain value is --------------- \t" + Convert.ToString(ConfigData.iAuxGain));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossBias = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS BIAS---------------------- \t" + Convert.ToString(ConfigData.crossBias));

                readBinary.Read(byte4, 0, 4);
                ConfigData.longBias = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG-AXIS BIAS---------------------- \t" + Convert.ToString(ConfigData.longBias));

                readBinary.Read(byte2, 0, 2);// extra read for alignment.  need to find out why
                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[6] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("VCC---------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[6]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[7] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("AL----------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[7]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[8] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("AX----------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[8]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[9] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("VE----------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[9]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[10] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("AX2---------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[10]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[11] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("XACC**2------------------------------ \t" + Convert.ToString(ConfigData.crossCouplingFactors[11]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[12] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LACC**2------------------------------ \t" + Convert.ToString(ConfigData.crossCouplingFactors[12]));

                readBinary.Read(byte2, 0, 2);
                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[13] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION (4)---------- \t{0:e4}.", ConfigData.crossCouplingFactors[13]);

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[14] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION (4)----------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[14]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[15] = BitConverter.ToSingle(byte4, 0);
                if (ConfigData.crossCouplingFactors[15] == 1)
                {
                    if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION (16)--------- \t" + "N/A");
                }
                else
                {
                    if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION (16)--------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[15]));
                }

                readBinary.Read(byte4, 0, 4);
                ConfigData.crossCouplingFactors[16] = BitConverter.ToSingle(byte4, 0);
                if (ConfigData.crossCouplingFactors[15] == 1)
                {
                    if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION (16)---------- \t" + "N/A");
                }
                else
                {
                    if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION (16)---------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[16]));
                }

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[1] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("AX PHASE----------------------------- \t" + Convert.ToString(ConfigData.analogFilter[1]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[2] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("AL PHASE----------------------------- \t" + Convert.ToString(ConfigData.analogFilter[2]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[3] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("AFILT[3]---------------------------- \t" + Convert.ToString(ConfigData.analogFilter[3]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[4] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("VCC PHASE---------------------------- \t" + Convert.ToString(ConfigData.analogFilter[4]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[5] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION PHASE (4)---- \t" + Convert.ToString(ConfigData.analogFilter[5]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[6] = BitConverter.ToSingle(byte4, 0);
                if (engineerDebug) Console.WriteLine("LONG AXIS COMPENSATION PHASE (4)----- \t" + Convert.ToString(ConfigData.analogFilter[6]));

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[7] = BitConverter.ToSingle(byte4, 0);
                if (CCFACT[15] == 1)
                {
                    if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION PHASE (16)--- \t" + "N/A");
                }
                else
                {
                    if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION PHASE (16)--- \t" + Convert.ToString(ConfigData.analogFilter[7]));
                }

                readBinary.Read(byte4, 0, 4);
                ConfigData.analogFilter[8] = BitConverter.ToSingle(byte4, 0);
                if (ConfigData.crossCouplingFactors[15] == 1)
                {
                    if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION PHASE (16)--- \t" + "N/A");
                }
                else
                {
                    if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION PHASE (16)--- \t" + Convert.ToString(ConfigData.analogFilter[7]));
                }

                Console.ReadLine();
                readBinary.Close();

                LogConfigData(ConfigData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LogConfigData(ConfigData ConfigData)
        {
            // ConfigData ConfigData = new ConfigData();
            if (engineerDebug) Console.WriteLine("\n\nConfiguration data for meter number   \t" + ConfigData.meterNumber);
            if (engineerDebug) Console.WriteLine("\n\t User defined parameters\n");
            if (engineerDebug) Console.WriteLine("Number of auxillary analog channels-- \t" + Convert.ToString(ConfigData.numAuxChan));
            if (engineerDebug) Console.WriteLine("DIGITAL INPUT SWITCH----------------- \t" + Convert.ToString(ConfigData.digitalInputSwitch));
            if (engineerDebug) Console.WriteLine("MONITOR DISPLAY SWITCH--------------- \t" + Convert.ToString(ConfigData.monitorDisplaySwitch));
            if (engineerDebug) Console.WriteLine("LINE PRINTER SWITCH------------------ \t" + Convert.ToString(ConfigData.linePrinterSwitch));
            if (engineerDebug) Console.WriteLine("FILE NAME SWITCH--------------------- \t" + Convert.ToString(ConfigData.fileNameSwitch));
            if (engineerDebug) Console.WriteLine("HARD DISK SWITCH--------------------- \t" + Convert.ToString(ConfigData.hardDiskSwitch));
            if (engineerDebug) Console.WriteLine("SERIAL PORT FORMAT SWITCH------------ \t" + Convert.ToString(ConfigData.serialPortSwitch));
            if (engineerDebug) Console.WriteLine("SERIAL PORT OUTPUT SWITCH------------ \t" + Convert.ToString(ConfigData.serialPortOutputSwitch));
            if (engineerDebug) Console.WriteLine("ALARM SWITCH------------------------- \t" + Convert.ToString(ConfigData.alarmSwitch));
            if (ConfigData.printerEmulationSwitch == 2)
            {
                if (engineerDebug) Console.WriteLine("PRINTER EMULATION-------------------- \t" + "ESC_P");
            }
            if (ConfigData.printerEmulationSwitch == 3)
            {
                if (engineerDebug) Console.WriteLine("PRINTER EMULATION-------------------- \t" + "ESC_P2");
            }
            else
            {
                if (engineerDebug) Console.WriteLine("PRINTER EMULATION-------------------- \t" + "DPL24C");
            }
            if (ConfigData.modeSwitch == 0)
            {
                if (engineerDebug) Console.WriteLine("MODE SWITCH-------------------------- \t" + "Marine");
            }
            else
            {
                if (engineerDebug) Console.WriteLine("MODE SWITCH-------------------------- \t" + "Hires");
            }
            if (engineerDebug) Console.WriteLine("\n\tParameters defined by ZLS.\n");
            if (engineerDebug) Console.WriteLine("BEAM SCALE FACTOR-------------------- \t{0:n6}.", ConfigData.beamScale);
            if (engineerDebug) Console.WriteLine("CROSS-AXIS PERIOD-------------------- \t{0:e4}", ConfigData.crossPeriod);
            if (engineerDebug) Console.WriteLine("CROSS-AXIS DAMPING------------------- \t{0:e4}", ConfigData.crossDampFactor);
            if (engineerDebug) Console.WriteLine("CROSS-AXIS GAIN---------------------- \t" + Convert.ToString(ConfigData.crossGain));
            if (engineerDebug) Console.WriteLine("CROSS-AXIS LEAD---------------------- \t" + Convert.ToString(ConfigData.crossLead));
            if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION (4)---------- \t{0:e4}.", ConfigData.crossCouplingFactors[13]);
            if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION PHASE (4)---- \t" + Convert.ToString(ConfigData.analogFilter[5]));
            if (ConfigData.crossCouplingFactors[15] == 1)
            {
                if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION (16)--------- \t" + "N/A");
            }
            else
            {
                if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION (16)--------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[15]));
            }

            if (ConfigData.crossCouplingFactors[15] == 1)
            {
                if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION PHASE (16)--- \t" + "N/A");
            }
            else
            {
                if (engineerDebug) Console.WriteLine("CROSS-AXIS COMPENSATION PHASE (16)--- \t" + Convert.ToString(ConfigData.analogFilter[7]));
            }
            if (engineerDebug) Console.WriteLine("CROSS-AXIS BIAS---------------------- \t" + Convert.ToString(ConfigData.crossBias));
            if (engineerDebug) Console.WriteLine("LONG-AXIS PERIOD-------------------- \t{0:e4}", ConfigData.longPeriod);
            if (engineerDebug) Console.WriteLine("LONG-AXIS DAMPING------------------- \t{0:e4}", ConfigData.longDampFactor);
            if (engineerDebug) Console.WriteLine("LONG-AXIS GAIN---------------------- \t{0:n4}", ConfigData.longGain);
            if (engineerDebug) Console.WriteLine("LONG-AXIS LEAD---------------------- \t" + Convert.ToString(ConfigData.longLead));
            if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION (4)----------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[14]));
            if (engineerDebug) Console.WriteLine("LONG AXIS COMPENSATION PHASE (4)----- \t" + Convert.ToString(ConfigData.analogFilter[6]));
            if (ConfigData.crossCouplingFactors[15] == 1)
            {
                if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION (16)---------- \t" + "N/A");
            }
            else
            {
                if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION (16)---------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[16]));
            }
            if (ConfigData.crossCouplingFactors[15] == 1)
            {
                if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION PHASE (16)---- \t" + "N/A");
            }
            else
            {
                if (engineerDebug) Console.WriteLine("LONG-AXIS COMPENSATION PHASE (16)--- \t" + Convert.ToString(ConfigData.analogFilter[7]));
            }
            if (engineerDebug) Console.WriteLine("LONG-AXIS BIAS---------------------- \t" + Convert.ToString(ConfigData.longBias));
            if (engineerDebug) Console.WriteLine("VCC---------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[6]));
            if (engineerDebug) Console.WriteLine("AL----------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[7]));
            if (engineerDebug) Console.WriteLine("AX----------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[8]));
            if (engineerDebug) Console.WriteLine("VE----------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[9]));
            if (engineerDebug) Console.WriteLine("AX2---------------------------------- \t" + Convert.ToString(ConfigData.crossCouplingFactors[10]));
            if (engineerDebug) Console.WriteLine("XACC**2------------------------------ \t" + Convert.ToString(ConfigData.crossCouplingFactors[11]));
            if (engineerDebug) Console.WriteLine("LACC**2------------------------------ \t" + Convert.ToString(ConfigData.crossCouplingFactors[12]));
            if (engineerDebug) Console.WriteLine("AX PHASE----------------------------- \t" + Convert.ToString(ConfigData.analogFilter[1]));
            if (engineerDebug) Console.WriteLine("AL PHASE----------------------------- \t" + Convert.ToString(ConfigData.analogFilter[2]));
            if (engineerDebug) Console.WriteLine("VCC PHASE---------------------------- \t" + Convert.ToString(ConfigData.analogFilter[4]));
            if (engineerDebug) Console.WriteLine("MAXIMUM SPRING TENSION VALUE--------- \t" + Convert.ToString(ConfigData.springTensionMax));
        }
        private void WriteConfigFile()
        {
            // SHOULD I HAVE A FILE TYPE PARAMETER PASSED FOR BINARY OR TEXT OR JUST DO BOTH AT THE SAME TIME?
        }

    }
}
