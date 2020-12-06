using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI01
{
    public partial class Exceptions : Form
    {
        public Exceptions(String message)
        {
            InitializeComponent();
            labelException.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
