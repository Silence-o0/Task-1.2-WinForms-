using System;

using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Ви ввели число {Convert.ToInt32(textBox.Text)}");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! Ввести можна лише ціле число.");
            }
            textBox.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
