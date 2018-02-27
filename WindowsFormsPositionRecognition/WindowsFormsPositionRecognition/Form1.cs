using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPositionRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            float sensor1 = Convert.ToInt32(textBox1.Text);
            float sensor2 = Convert.ToInt32(textBox2.Text);
            float sensor3 = Convert.ToInt32(textBox3.Text);
            float sensor4 = Convert.ToInt32(textBox4.Text);
            float sensor5 = Convert.ToInt32(textBox5.Text);
            float sensor6 = Convert.ToInt32(textBox6.Text);
            float sensor7 = Convert.ToInt32(textBox7.Text);
            float sensor8 = Convert.ToInt32(textBox8.Text);

            float[] force_data = new float[] {sensor1, sensor2, sensor3, sensor4, sensor5, sensor6, sensor7, sensor8};


            float total_left = sensor1 + sensor2 + sensor3 + sensor4;
            float avg_left = total_left / 4;

            float total_right = sensor5 + sensor6 + sensor7 + sensor8;
            float avg_right = total_right / 4;

            float total_forward = sensor1 + sensor2 + sensor5 + sensor6;
            float avg_forward = total_forward / 4;

            float total_back = sensor3 + sensor4 + sensor7 + sensor8;
            float avg_back = total_back / 4;


            float total_force = total_left + total_right;

            float percent_left = (total_left / total_force);
            float percent_right = (total_right / total_force);
            float percent_forward = (total_forward / total_force);
            float percent_back = (total_back / total_force);

            
            textBoxleftpercent.Text = String.Format("{0:0.00000}", percent_left);
            textBoxrightpercent.Text = String.Format("{0:0.00000}", percent_right);
            textBoxforwardpercent.Text = String.Format("{0:0.00000}", percent_forward);
            textBoxbackpercent.Text = String.Format("{0:0.00000}", percent_back);

            float[] percent_array = { percent_left, percent_right, percent_forward, percent_back };

            Array.Sort(percent_array);
            float difference = (percent_array[3] - percent_array[2]);
            textBoxdifference.Text = String.Format("{0:0.000000}", difference);

            textBoxleft.Text = String.Format("{0:0.000000}", avg_left);
            textBoxright.Text = String.Format("{0:0.000000}", avg_right);
            textBoxforward.Text = String.Format("{0:0.000000}", avg_forward);
            textBoxback.Text = String.Format("{0:0.000000}", avg_back);


            if(difference> 0.1f)
            {
                if((avg_left > avg_right) && (avg_left > avg_forward) && (avg_left > avg_back))
                {
                    textBoxresult.Text = "left";
                }

                if ((avg_right > avg_left) && (avg_right > avg_forward) && (avg_right > avg_back))
                {
                    textBoxresult.Text = "right";
                }

                if ((avg_forward > avg_right) && (avg_forward > avg_left) && (avg_forward > avg_back))
                {
                    textBoxresult.Text = "forward";
                }

                if ((avg_back > avg_right) && (avg_back > avg_forward) && (avg_back > avg_forward))
                {
                    textBoxresult.Text = "back";
                }          
            }
            else{
                textBoxresult.Text = "center";

            }







        }
    }
}
