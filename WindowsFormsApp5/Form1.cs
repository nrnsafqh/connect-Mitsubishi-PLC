using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        bool bbtnY0 = false;
        bool bbtnY1 = false;
        bool bbtnY2 = false;
        bool bbtnY3 = false;
        bool bbtnY4 = false;
        bool bbtnY5 = false;
        bool bbtnY6 = false;
        bool bbtnY7 = false;
        bool plcStat = false;
        System.Timers.Timer _Timer;


        public Form1()
        {
            InitializeComponent();

        }
        public ActUtlType plc = new ActUtlType();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void _Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

        private void But_Connect_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 10;
            plc.Open();
            timer1.Start();
            But_Connect.BackColor = Color.Green;
            But_Dis.BackColor = Color.White;
            
            plcStat = true;

        }

        private void But_Dis_Click(object sender, EventArgs e)
        {
            plc.Close();
            timer1.Stop();
            But_Connect.BackColor = Color.White;
            But_Dis.BackColor = Color.Red;
            plcStat = false;

            lblX0.BackColor = Color.White; 
            lblX1.BackColor = Color.White;
            lblX2.BackColor = Color.White;
            lblX3.BackColor = Color.White;        
            lblX4.BackColor = Color.White;
            lblX5.BackColor = Color.White;
            lblX6.BackColor = Color.White;
            lblX7.BackColor = Color.White;
            lblY7.BackColor = Color.White;
            lblY0.BackColor = Color.White;
            lblY1.BackColor = Color.White;
            lblY2.BackColor = Color.White;
            lblY3.BackColor = Color.White;
            lblY4.BackColor = Color.White;
            lblY5.BackColor = Color.White;
            lblY6.BackColor = Color.White;
            lblY7.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void but_Write_Click(object sender, EventArgs e)
        {
            if (plcStat == true)
            {
                plc.SetDevice(TxtAdd_W.Text, Convert.ToInt16(TxtVal_W.Text));
            }
        }

        private void but_Read_Click(object sender, EventArgs e)
        {
            if (plcStat == false)
            {
                int read_result;
                plc.GetDevice(TxtAdd_R.Text, out read_result);
                TxtVal_R.Text = read_result.ToString();
            }
           
        }

        private void but_Y0_Click(object sender, EventArgs e)
        {
            if (bbtnY0 == false)
            {
                plc.SetDevice("Y0", 1);
                but_Y0.Text = "ON";
                bbtnY0 = true;
            }
            else
            {
                plc.SetDevice("Y0", 0);
                but_Y0.Text = "OFF";
                bbtnY0 = false;
            }
        }

        private void but_Y1_Click(object sender, EventArgs e)
        {
            if (bbtnY1 == false)
            {
                plc.SetDevice("Y1", 1);
                but_Y1.Text = "ON";
                bbtnY1 = true;
            }
            else
            {
                plc.SetDevice("Y1", 0);
                but_Y1.Text = "OFF";
                bbtnY1 = false;
            }

        }

        private void but_Y2_Click(object sender, EventArgs e)
        {
            if (bbtnY2 == false)
            {
                plc.SetDevice("Y2", 1);
                but_Y2.Text = "ON";
                bbtnY2 = true;
            }
            else
            {
                plc.SetDevice("Y2", 0);
                but_Y2.Text = "OFF";
                bbtnY2 = false;
            }
        }

        private void but_Y3_Click(object sender, EventArgs e)
        {
            if (bbtnY3 == false)
            {
                plc.SetDevice("Y3", 1);
                but_Y3.Text = "ON";
                bbtnY3 = true;
            }
            else
            {
                plc.SetDevice("Y3", 0);
                but_Y3.Text = "OFF";
                bbtnY3 = false;
            }
        }

        private void but_Y4_Click(object sender, EventArgs e)
        {
            if (bbtnY4 == false)
            {
                plc.SetDevice("Y4", 1);
                but_Y4.Text = "ON";
                bbtnY4 = true;
            }
            else
            {
                plc.SetDevice("Y4", 0);
                but_Y4.Text = "OFF";
                bbtnY4 = false;
            }
        }

        private void but_Y5_Click(object sender, EventArgs e)
        {
            if (bbtnY5 == false)
            {
                plc.SetDevice("Y5", 1);
                but_Y5.Text = "ON";
                bbtnY5 = true;
            }
            else
            {
                plc.SetDevice("Y5", 0);
                but_Y5.Text = "OFF";
                bbtnY5 = false;
            }
        }

        private void but_Y6_Click(object sender, EventArgs e)
        {
            if (bbtnY6 == false)
            {
                plc.SetDevice("Y6", 1);
                but_Y6.Text = "ON";
                bbtnY6 = true;
            }
            else
            {
                plc.SetDevice("Y6", 0);
                but_Y6.Text = "OFF";
                bbtnY6 = false;
            }
        }

        private void but_Y7_Click(object sender, EventArgs e)
        {
            if (bbtnY7 == false)
            {
                plc.SetDevice("Y7", 1);
                but_Y7.Text = "ON";
                bbtnY7 = true;
             
            }
            else
            {
                plc.SetDevice("Y7", 0);
                but_Y7.Text = "OFF";
                bbtnY7 = false;
            
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (plcStat == true)
            {
                plc.GetDevice("X0", out int X0);
                plc.GetDevice("X1", out int X1);
                plc.GetDevice("X2", out int X2);
                plc.GetDevice("X3", out int X3);
                plc.GetDevice("X4", out int X4);
                plc.GetDevice("X5", out int X5);
                plc.GetDevice("X6", out int X6);
                plc.GetDevice("X7", out int X7);


                plc.GetDevice("Y0", out int Y0);
                plc.GetDevice("Y1", out int Y1);
                plc.GetDevice("Y2", out int Y2);
                plc.GetDevice("Y3", out int Y3);
                plc.GetDevice("Y4", out int Y4);
                plc.GetDevice("Y5", out int Y5);
                plc.GetDevice("Y6", out int Y6);
                plc.GetDevice("Y7", out int Y7);

                //input monitor
                if (X0 == 1) lblX0.BackColor = Color.Green;
                if (X0 == 0) lblX0.BackColor = Color.Red;
                if (X1 == 1) lblX1.BackColor = Color.Green;
                if (X1 == 0) lblX1.BackColor = Color.Red;
                if (X2 == 1) lblX2.BackColor = Color.Green;
                if (X2 == 0) lblX2.BackColor = Color.Red;
                if (X3 == 1) lblX3.BackColor = Color.Green;
                if (X3 == 0) lblX3.BackColor = Color.Red;
                if (X4 == 1) lblX4.BackColor = Color.Green;
                if (X4 == 0) lblX4.BackColor = Color.Red;
                if (X5 == 1) lblX5.BackColor = Color.Green;
                if (X5 == 0) lblX5.BackColor = Color.Red;
                if (X6 == 1) lblX6.BackColor = Color.Green;
                if (X6 == 0) lblX6.BackColor = Color.Red;
                if (X7 == 1) lblX7.BackColor = Color.Green;
                if (X7 == 0) lblX7.BackColor = Color.Red;

                if (Y0 == 1) lblY0.BackColor = Color.Green;
                if (Y0 == 0) lblY0.BackColor = Color.Red;
                if (Y1 == 1) lblY1.BackColor = Color.Green;
                if (Y1 == 0) lblY1.BackColor = Color.Red;
                if (Y2 == 1) lblY2.BackColor = Color.Green;
                if (Y2 == 0) lblY2.BackColor = Color.Red;
                if (Y3 == 1) lblY3.BackColor = Color.Green;
                if (Y3 == 0) lblY3.BackColor = Color.Red;
                if (Y4 == 1) lblY4.BackColor = Color.Green;
                if (Y4 == 0) lblY4.BackColor = Color.Red;
                if (Y5 == 1) lblY5.BackColor = Color.Green;
                if (Y5 == 0) lblY5.BackColor = Color.Red;
                if (Y6 == 1) lblY6.BackColor = Color.Green;
                if (Y6 == 0) lblY6.BackColor = Color.Red;
                if (Y7 == 1) lblY7.BackColor = Color.Green;
                if (Y7 == 0) lblY7.BackColor = Color.Red;

                //output monitor
                if (Y0 == 0) but_Y0.Text = "OFF";
                if (Y0 == 1) but_Y0.Text = "ON";

                if (Y1 == 0) but_Y1.Text = "OFF";
                if (Y1 == 1) but_Y1.Text = "ON";

                if (Y2 == 0) but_Y2.Text = "OFF";
                if (Y2 == 1) but_Y2.Text = "ON";

                if (Y3 == 0) but_Y3.Text = "OFF";
                if (Y3 == 1) but_Y3.Text = "ON";

                if (Y4 == 0) but_Y4.Text = "OFF";
                if (Y4 == 1) but_Y4.Text = "ON";

                if (Y5 == 0) but_Y5.Text = "OFF";
                if (Y5 == 1) but_Y5.Text = "ON";

                if (Y6 == 0) but_Y6.Text = "OFF";
                if (Y6 == 1) but_Y6.Text = "ON";

                if (Y7 == 0) but_Y7.Text = "OFF";
                if (Y7 == 1) but_Y7.Text = "ON";
            }
        }

        private void TxtAdd_W_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
