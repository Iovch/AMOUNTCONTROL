using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports; // пространство имен для портов
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telescop
{
    public partial class Com_port : Form
    {
        
        public Com_port()
        {

            InitializeComponent();

            int i = 0;

            string[] c_ports = SerialPort.GetPortNames(); // GetPortNames Возвращает массив имен последовательных портов для текущего компьютера.

            /* для отладки
            string[] c_ports = new string[6];
            for (int i1 =0; i1<=5; i1++)
            {
                c_ports[i1] = "COM" + (i1+1);
            }
            конец */
            foreach ( string i_port in c_ports)
            {
                listBox1.Items.Insert(i, c_ports[i]);
                i++;
            }
            //f1.textBox1.Text = Convert.ToString(listBox1.SelectedItem);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.textBox4.Text = Convert.ToString(listBox1.SelectedItem);
            }


                // string Com_port_text


                MessageBox.Show("Выбран порт:  " + listBox1.SelectedItem);

            this.Hide();
        }
    }
}
