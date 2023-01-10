using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace RobotskaSakaZaGluvoneme
{
    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 9600;
            try
            {
                port.Open();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            try
            {
                port.WriteLine("a");
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            port.WriteLine("b");
        }

         private void buttonC_Click(object sender, EventArgs e)
        {
            port.WriteLine("c");
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            port.WriteLine("d");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            port.WriteLine("e");
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            port.WriteLine("f");
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            port.WriteLine("g");
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            port.WriteLine("h");
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            port.WriteLine("i");
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            port.WriteLine("j");
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            port.WriteLine("k");
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            port.WriteLine("l");
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            port.WriteLine("m");
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            port.WriteLine("n");
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            port.WriteLine("o");
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            port.WriteLine("p");
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            port.WriteLine("q");
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            port.WriteLine("r");
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            port.WriteLine("s");
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            port.WriteLine("t");
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            port.WriteLine("u");
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            port.WriteLine("v");
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            port.WriteLine("w");
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            port.WriteLine("x");
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            port.WriteLine("y");
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            port.WriteLine("z");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine(";");
        }
    }
}
