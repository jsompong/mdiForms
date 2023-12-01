using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiForms
{
    public partial class WinApp : Form
    {
        byte[] sentData = new byte[10];
        byte[] message = new byte[10];
        byte[] byte_buffer = new byte[2048];

        public WinApp()
        {
            InitializeComponent();
        }

        private void rs232comBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rs232comBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rS232portDataSet);

        }

        private void WinApp_Load(object sender, EventArgs e)
        {
            //  loads data into the 'rS232portDataSet.rs232com' table. You can move, or remove it, as needed.
            this.rs232comTableAdapter.Fill(this.rS232portDataSet.rs232com);
            //textBox1.Multiline = true;
            // Set the read/write timeouts
            serialPort1.Encoding = Encoding.ASCII;
            serialPort1.Handshake = Handshake.None;
            //sp.ReceivedBytesThreshold = 100000;

            serialPort1.ReadTimeout = 500;          // set read time out to 0.5 sec.
            serialPort1.WriteTimeout = 500;
            //_continue = true;
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            Console.WriteLine("The following serial ports were found:");
            // Display each port name to the console.
            foreach (string port in ports)
            {
                //Console.WriteLine(port);
                textBox.Text = port;
            }
            // Makes sure serial port is open before trying to write
            try
            {
                if (!(serialPort1.IsOpen))
                    // Console.WriteLine("Ready for Incoming Data:");
                    // MessageBox.Show("opening the serial port :: " );
                    serialPort1.Open();
                serialPort1.Write("SI\r\n");
                //  (RTS = 0, DTR = 0)
                serialPort1.RtsEnable = true; //RTS = 0
                serialPort1.DtrEnable = true; // DTR = 0
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
            timer1.Enabled = true;
            //this.portTextBox.Height = 70;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        static private byte CalCheckSum(byte[] byteBuffer)
        {
            byte _CheckSumByte = 0x00;
            for (int a = 0; a < byteBuffer.Length - 1; a++) //CheckSumı headerdan itibaren kontrol ettir!
                _CheckSumByte ^= byteBuffer[a];
            return _CheckSumByte;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int bytesRead = 0;
            // Initialize a buffer to hold the received data
            //serialPort1.Read will return the number of bytes read
            //serialPort1.Read(result, 0, result.Length);
            //string s = new string(result);
            //char[] result = new char[20];
            //for (int len = 0; len < result.Length;)
            //{
            //  len += serialPort1.Read(result, len, result.Length - len);
            //}
            //byte[] buffer = new byte[serialPort1.ReadBufferSize];
            //bytesRead = serialPort1.ReadBufferSize;         //4096
            //string message = serialPort1.ReadLine();
            string message = serialPort1.ReadExisting();
            //Console.WriteLine(message);
            //textBox2.Text = message + s;
            textBox2.Text = message + bytesRead;
            //MessageBox.Show(s);

            sentData[0] = 0xF1;
            sentData[1]++;
            sentData[2] = 70;
            sentData[3] = 11;
            sentData[4] = 85;
            sentData[5] = 74;
            sentData[6] = 11;
            sentData[7] = 10;
            sentData[8] = 154;
            sentData[9] = CalCheckSum(sentData);
            serialPort1.Write(sentData, 0, 10);
            serialPort1.Write(new byte[] { 0x0A, 0xE2, 0xFF }, 0, 3);
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string[] numchar = { textBox2.Text };
      // {
        //    "123-555-0190",
          //  "444-234-22450",
            //"690-555-0178",
            //"146-893-232",
            //"146-555-0122",
            //"4007-555-0111",
            //"407-555-0111",
            //"407-2-5555",
        //};
            //string sPattern = "APB";
            string sPattern = "XTAL";
            foreach (string s in numchar)
            {
                //System.Console.Write("{0,14}", s);
                //textBox1
                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern))
                {
                    //System.Console.WriteLine(" - valid");
                    textBox1.Text = " - valid  " + sPattern;
                }
               else
                {
                    //System.Console.WriteLine(" - invalid");
                    textBox1.Text = " - invalid";
                }
        
            //foreach (string s in numchar)
           // {
                //System.Console.Write("{0,14}", s);
                //textBox1
             //   if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern))
               // {
                    //System.Console.WriteLine(" - valid");
                 //   textBox1.Text = " - valid2 " + sPattern;
                //}
                //else
                //{
                    //System.Console.WriteLine(" - invalid");
                  //  textBox1.Text = " - invalid";
                //}

            }

        }
    }
}
