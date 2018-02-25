using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmChair_Functions;

namespace SmartChairUIBluetooth
{
    public partial class Smr_Chair : Form
    {

        //some variables
        SmChairFunc Smfunc = new SmChairFunc();
        private float[] heatmap_sens = new float[9];
        private float temp_val;
        private string temp_string;
        private string display_val;
        private string com_port;
        private Time_Data TData = new Time_Data(50);

        public Smr_Chair()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bluetoothMenu_Click(object sender, EventArgs e)
        {
            //test
        }

        private void BluetoothMenuConnect_Click(object sender, EventArgs e)
        {
            //Connect should connect to the bluetooth device (the MCU), currently, you have to find
            //which com port that is by yourself and change it below
            serialPort1.PortName = com_port;

            //Now we configure the port
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Handshake = System.IO.Ports.Handshake.None;

            serialPort1.Open();
            serialPort1.ReadTimeout = 1000000; //reading timeouts in 100 milliseconds, later this should be no timeout

            //handle the recieve data event for our serial port (how we store data basically)
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataRecieved);
        }

        private void serialPort1_DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Store the data recieved through serial port
            //Notation D - data, 1 - 9 which sensor
            //example: D53.33 is sending a reading from sensor 5 of 3.33 volts
            display_val = serialPort1.ReadExisting();

            //processing the data
            if (display_val[0] == 'D')
            {
                //finds floats in recieved data.
                temp_string = display_val.Substring(2);
                temp_val = Convert.ToSingle(temp_string);
                switch (display_val[1])
                {
                    case '1':
                        heatmap_sens[0] = temp_val;
                        break;
                    case '2':
                        heatmap_sens[1] = temp_val;
                        break;
                    case '3':
                        heatmap_sens[2] = temp_val;
                        break;
                    case '4':
                        heatmap_sens[3] = temp_val;
                        break;
                    case '5':
                        heatmap_sens[4] = temp_val;
                        break;
                    case '6':
                        heatmap_sens[5] = temp_val;
                        break;
                    case '7':
                        heatmap_sens[6] = temp_val;
                        break;
                    case '8':
                        heatmap_sens[7] = temp_val;
                        break;
                    case '9':
                        heatmap_sens[8] = temp_val;
                        break;
                    default:
                        display_val = "INVALID DATA";
                        break;
                }

            }

            //call a seperate event to handle recieved data
            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            textBox1.AppendText(display_val);
            textBox2.AppendText(Convert.ToString(heatmap_sens[0]));
            textBox3.AppendText(Convert.ToString(heatmap_sens[1]));
            textBox4.AppendText(Convert.ToString(heatmap_sens[2]));
            textBox5.AppendText(Convert.ToString(heatmap_sens[3]));
            textBox6.AppendText(Convert.ToString(heatmap_sens[4]));
            textBox7.AppendText(Convert.ToString(heatmap_sens[5]));
            textBox8.AppendText(Convert.ToString(heatmap_sens[6]));
            textBox9.AppendText(Convert.ToString(heatmap_sens[7]));
            textBox10.AppendText(Convert.ToString(heatmap_sens[8]));

        }

        private void BluetoothMenuDisconnect_Click(object sender, EventArgs e)
        {
            //Clicking Disconnect will close COM5, make sure to do this when you're done with it
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)    //Quit the program
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Input_TextChanged(object sender, EventArgs e)
        {
            com_port = User_Input.Text;
        }
    }
}
