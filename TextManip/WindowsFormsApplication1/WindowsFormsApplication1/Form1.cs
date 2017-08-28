using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private String text;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Text files |*.txt|All Files (danger!)|*.*";
            o.RestoreDirectory = true;
            if (o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = o.OpenFile()) != null)
                    {
                        readTextFile(fileStream);
                        fileTextBox.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error when opening File!");
                }
            }
        }

        private async void readTextFile(Stream stream)
        {
            byte[] result = new byte[stream.Length];
            using (stream)
            {
                await stream.ReadAsync(result, 0, (int)stream.Length);
            }
            text = System.Text.Encoding.ASCII.GetString(result);
            fileTextBox.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
