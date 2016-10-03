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
    public partial class FileTransfer : Form
    {
        public FileTransfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 MainWindow = new Form1();
            MainWindow.Show();
            this.Close();
        }

        private void FileTransfer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // browse send file

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
               /*
                * file = openFileDialog1.FileName;
                text = File.ReadAllText(file);
                size = text.Length;
                textBox1.Text = file;
                button2.Enabled = true;
                */
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                /*
                 * file = openFileDialog1.FileName;
                 text = File.ReadAllText(file);
                 size = text.Length;
                 textBox1.Text = file;
                 button2.Enabled = true;
                 */
            }
        }
    }
}
