﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01BASIC
{
    public partial class WINFORM : Form
    {

        private SerialPort serialPort = new SerialPort();


        public WINFORM()
        {
            InitializeComponent();
        }



        private void PortNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
        }
        private void SerialPort_DataRecv(object sendeer, SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialPort.ReadExisting();
            Console.Write(recvData);
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {

            try
            {
                this.serialPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
                this.serialPort.BaudRate = 9600;
                this.serialPort.DataBits = 8;
                this.serialPort.StopBits = System.IO.Ports.StopBits.One;
                this.serialPort.Parity = System.IO.Ports.Parity.None;
                this.serialPort.Open();
                Console.WriteLine(PortNumber.Items[this.PortNumber.SelectedIndex] + " CONN");
                label2.Text = PortNumber.Items[this.PortNumber.SelectedIndex] + " CONN";
                this.serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecv);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.serialPort.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            label2.Text = "LED_01 ON SUCCESS";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            label2.Text = "LED_01 OFF SUCCESS";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            label2.Text = "LED_02 ON SUCCESS";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            label2.Text = "LED_02 OFF SUCCESS";

        }
    }
}