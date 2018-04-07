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
        public SerialPort mySerialPort = new SerialPort();

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

        private void button17_Click(object sender, EventArgs e)
        {
            // добавить проверку на имя порта , не д.б. пустым
            if (textBox4.Text != "")
            {
                mySerialPort.PortName = textBox4.Text;

                mySerialPort.BaudRate = 2400;
                mySerialPort.Parity = Parity.None; // протокол контроля четности
                mySerialPort.WriteTimeout = 500;
                mySerialPort.ReadTimeout = 500;
                mySerialPort.DataBits = 8;
                mySerialPort.Open();
                System.Threading.Thread.Sleep(500);

                mySerialPort.Write("F-"+ textBox1.Text);
                System.Threading.Thread.Sleep(500);
                mySerialPort.Write("F0");

                mySerialPort.Close();
            }
            else MessageBox.Show("СОМ-порт не выбран, зайдите в Setup");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // добавить проверку на имя порта , не д.б. пустым
            if (textBox4.Text != "")
            {
                mySerialPort.PortName = textBox4.Text;

                mySerialPort.BaudRate = 2400;
                mySerialPort.Parity = Parity.None; // протокол контроля четности
                mySerialPort.WriteTimeout = 500;
                mySerialPort.ReadTimeout = 500;
                mySerialPort.DataBits = 8;
                mySerialPort.Open();
                System.Threading.Thread.Sleep(500);

                mySerialPort.Write("F+"+ textBox1.Text);
                System.Threading.Thread.Sleep(500);
                mySerialPort.Write("F0");

                mySerialPort.Close();
            }
            else MessageBox.Show("СОМ-порт не выбран, зайдите в Setup");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        
    }
    
}
