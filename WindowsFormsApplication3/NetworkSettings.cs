using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class NetworkSettings : Form
    {
        public NetworkSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 MainWindow = new Form1();
            MainWindow.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // baud rate
            
                int baudrate_new = Convert.ToInt32(comboBox1.Text);
            switch (baudrate_new)
            {
                case 1200:
                   // control_reg[0] = 0;
                    //control_reg[1] = 0;
                   // control_reg[2] = 0;
                    break;
                case 2400:
                    //control_reg[0] = 1;
                    //control_reg[1] = 0;
                    //control_reg[2] = 0;
                    break;
                case 4800:
                    //control_reg[0] = 0;
                    //control_reg[1] = 1;
                    //control_reg[2] = 0;
                    break;
                case 9600:
                    //control_reg[0] = 1;
                    //control_reg[1] = 1;
                    //control_reg[2] = 0;
                    break;
                case 19200:
                    //control_reg[0] = 0;
                    //control_reg[1] = 0;
                    //control_reg[2] = 1;
                    break;
                default:
                    break;
            }
                /* ========================== */
            }
        }
}
