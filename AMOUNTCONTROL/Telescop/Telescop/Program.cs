using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports; // пространство имен для портов
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telescop
{
    class LastControl
    {
        public int Axis;
        public int Focus;
    }

    class RaRa
    {
        public double myX;
        public double myY;
        public int F;
    }
    class MyFun
    {
        public string N_port = "";
        public string Choice_Com_Port()
        {
            string i_Com_port = "";
            string[] ports = SerialPort.GetPortNames(); // GetPortNames Возвращает массив имен последовательных портов для текущего компьютера.
            MessageBox.Show(" Портов в компе:" + ports.Length);

            i_Com_port = ports[0];
            return (i_Com_port);
        }
    }
    static class Program
    {
        public static Form1 f1; //Создаем экземпляр класса Form1
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
