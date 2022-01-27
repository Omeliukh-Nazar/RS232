using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace IDPP_lab1_ver2
{
    public partial class Form1 : Form
    {
        string dataIn;
        private static byte[] arrBytes = Enumerable.Range(192, 64).Select(x => (byte)x).ToArray();
        private static Encoding w1251 = Encoding.GetEncoding(1251);
        private static char[] arrChars = w1251.GetChars(arrBytes);
        private static Dictionary<byte, char> alfabet = new Dictionary<byte, char>();
        
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            for (int i = 0; i < arrBytes.Length; i++)
            {
                alfabet.Add(arrBytes[i], arrChars[i]);
            }
            alfabet.Add(178,'І');
            alfabet.Add(179,'і');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            serialPort1.Encoding = System.Text.Encoding.GetEncoding(1251);
            cBoxCOMPORT.Items.AddRange(ports);
        }
        private delegate void SetTextDeleg(string text);

        private string dateTime;
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dateTime = DateTime.Now.ToString("hh.mm.ss.fffffff");
            tBoxDataIn.Clear();
            string data = serialPort1.ReadExisting();
            tBoxDataIn.Text += data;

            dataIn = data;
            lTime.Text = dateTime;
            ShowByte(0);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParituBits.Text);
                serialPort1.ReadTimeout = 3000;
                serialPort1.Open();
                progressBar1.Value = 100;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }
        private void ShowByte(int byteNumber)
        {
            chart1.Series["Signal"].Points.Clear();
            chart1.Series["Signal"].Points.AddXY(0, 1);
            chart1.Series["Signal"].Points.AddXY(1, 0);


            // string bits = (Convert.ToString(dataIn[byteNumber], 2).PadLeft(8, '0'));
            var a = alfabet.FirstOrDefault(pair => pair.Value == dataIn[byteNumber]);
            string bits = (Convert.ToString(a.Key, 2).PadLeft(8, '0'));

            int x = 2;
            int parity = 0;
            foreach (var item in bits)
            {
                int y = Int32.Parse(item.ToString());
                chart1.Series["Signal"].Points.AddXY(x, y);
                parity += y;
                x++;
            }

            if (cBoxParituBits.SelectedItem.ToString() == "Odd")
            {
                if (parity % 2 == 0)
                    chart1.Series["Signal"].Points.AddXY(x, 1);
                else
                    chart1.Series["Signal"].Points.AddXY(x, 0);
                x++;
            }
            if (cBoxParituBits.SelectedItem.ToString() == "Even")
            {
                if (parity % 2 == 0)
                    chart1.Series["Signal"].Points.AddXY(x, 0);
                else
                    chart1.Series["Signal"].Points.AddXY(x, 1);
                x++;    
            }

            if (cBoxStopBits.SelectedItem.ToString() == "One")
            {
                
                chart1.Series["Signal"].Points.AddXY(x, 1);
                if (cBoxParituBits.SelectedItem.ToString() == "Odd" || cBoxParituBits.SelectedItem.ToString() == "Even")
                    chart1.Series["Signal"].Points.Last().Color = Color.Green;
   
               
                x++;
                chart1.Series["Signal"].Points.AddXY(x, 1);
                chart1.Series["Signal"].Points.Last().Color = Color.Red;
            }
               
            if (cBoxStopBits.SelectedItem.ToString() == "Two")
            {
                chart1.Series["Signal"].Points.AddXY(x, 1);
                if (cBoxParituBits.SelectedItem == "Odd" || cBoxParituBits.SelectedItem.ToString() == "Even")
                    chart1.Series["Signal"].Points.Last().Color = Color.Green;
                
                x++;
                chart1.Series["Signal"].Points.AddXY(x, 1);
                chart1.Series["Signal"].Points.Last().Color = Color.Red;
                x++;
                chart1.Series["Signal"].Points.AddXY(x, 1);
                chart1.Series["Signal"].Points.Last().Color = Color.Red;
            }
            chart1.Series["Signal"].Points[0].Color = Color.Red;
            chart1.Series["Signal"].Points[1].Color = Color.Red;
            chart1.Series["Signal"].Points[2].Color = Color.Red;
            lLeter.Text = dataIn[byteNumber].ToString() + " == " + bits;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int16.Parse(tBoxByteNumber.Text);
            if (num > dataIn.Length-1)
            {
                MessageBox.Show("There is no such byte!");
                return;
            }
            else
            {
                ShowByte(Int16.Parse(tBoxByteNumber.Text));
            }    
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lLeter_Click(object sender, EventArgs e)
        {

        }

        private void tBoxByteNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
