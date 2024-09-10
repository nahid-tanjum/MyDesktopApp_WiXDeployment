using System;
using System.Windows.Forms;

namespace MyDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display a simple message box with "Hello, World!"
            MessageBox.Show("Hello, World!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
