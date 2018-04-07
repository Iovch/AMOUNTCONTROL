using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telescop
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

        private void button15_Click(object sender, EventArgs e)
        {
            Com_port newForm = new Com_port();
            newForm.Owner = this;
            newForm.ShowDialog();

            // MyFun mf = new MyFun();

            // MessageBox.Show(" Порт № 1 = " + mf.Choice_Com_Port());
        }

    }
    
}
