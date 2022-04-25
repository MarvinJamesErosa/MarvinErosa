using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HERE IS MY NAME: MARVIN JAMES A. EROSA", "THANK YOU FOR CLICKING THE BUTTON", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
