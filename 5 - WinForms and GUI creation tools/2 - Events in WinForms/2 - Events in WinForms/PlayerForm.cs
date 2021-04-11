using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2___Events_in_WinForms
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a PLAY button!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a PAUSE button!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a STOP button!");
        }
    }
}
