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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chat ChatWindow = new chat();
            ChatWindow.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileTransfer FileTransferWindow = new FileTransfer();
            FileTransferWindow.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NetworkSettings NetworkSettingWindow = new NetworkSettings();
            NetworkSettingWindow.Show();
            this.Hide();
        }
    }
}
