using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public struct BUTTON
    {
        public bool isOn;
    }

    public partial class Form1 : Form
    {
        BUTTON button7, button6, button5, button4;
        /*byte msg_buttons = 0xFF;
        byte byte7 = 0x8F;*/
        uint msg_buttons = 0b_0000_0000;
        byte[] buffer = BitConverter.GetBytes(0x00);
        public Form1()
        {
            InitializeComponent();
            if (!myPort.IsOpen)
            {
                myPort.Open();
               // tbRX.Text = "port opened";
            }
            else
            {
                //tbRX.Text = "port busy :(";
            }

        }

        private void b5_Click(object sender, EventArgs e)
        {
            button5.isOn = !button5.isOn;
            if (button5.isOn)
            {
                b5.BackColor = Color.LimeGreen;
                msg_buttons = 0b_0010_1111 | msg_buttons;
            }
            else
            {
                b5.BackColor = Color.Gainsboro;
                msg_buttons = 0b_1101_1111 & msg_buttons;
            }
            buffer = BitConverter.GetBytes(msg_buttons);
            myPort.Write(buffer, 0, 1);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            button4.isOn = !button4.isOn;
            if (button4.isOn)
            {
                b4.BackColor = Color.LimeGreen;
                msg_buttons = 0b_0001_1111 | msg_buttons;
            }
            else
            {
                b4.BackColor = Color.Gainsboro;
                msg_buttons = 0b_1110_1111 & msg_buttons;
            }
            buffer = BitConverter.GetBytes(msg_buttons);
            myPort.Write(buffer, 0, 1);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            b4.BackColor = Color.Gainsboro;
            b5.BackColor = Color.Gainsboro;
            b6.BackColor = Color.Gainsboro;
            b7.BackColor = Color.Gainsboro;
            button4.isOn = false;
            button5.isOn = false;
            button6.isOn = false;
            button7.isOn = false;
            msg_buttons = 0b_0000_1111 & msg_buttons;
            buffer = BitConverter.GetBytes(msg_buttons);
            myPort.Write(buffer, 0, 1);
        }

        private void myPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Array.Clear(buffer, 0, buffer.Length);
            myPort.Read(buffer, 0, 1);
            msg_buttons = (uint)(0b_0000_1111 & buffer[0]);
            b0.BackColor = ((msg_buttons & 0b_0000_0001) > 0) ? Color.Red : Color.Gainsboro;
            b1.BackColor = ((msg_buttons & 0b_0000_0010) > 0) ? Color.Red : Color.Gainsboro;
            b2.BackColor = ((msg_buttons & 0b_0000_0100) > 0) ? Color.Red : Color.Gainsboro;
            b3.BackColor = ((msg_buttons & 0b_0000_1000) > 0) ? Color.Red : Color.Gainsboro;
            /*Console.WriteLine("Buffer length: {0}", buffer.Length);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.WriteLine("Contenido de Buffer: {0}", buffer[i]);
            }*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myPort.Close();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            b4.BackColor = Color.LimeGreen;
            b5.BackColor = Color.LimeGreen;
            b6.BackColor = Color.LimeGreen;
            b7.BackColor = Color.LimeGreen;
            button4.isOn = true;
            button5.isOn = true;
            button6.isOn = true;
            button7.isOn = true;
            msg_buttons = 0b_1111_1111 | msg_buttons;
            buffer = BitConverter.GetBytes(msg_buttons);
            myPort.Write(buffer, 0, 1);
        }


        private void b7_Click(object sender, EventArgs e)
        {
            button7.isOn = !button7.isOn;
            if (button7.isOn)
            {
                b7.BackColor = Color.LimeGreen;
                msg_buttons = 0b_1000_1111 | msg_buttons;
            }
            else
            {
                b7.BackColor = Color.Gainsboro;
                msg_buttons = 0b_0111_1111 & msg_buttons;
            }
            buffer = BitConverter.GetBytes(msg_buttons);
            myPort.Write(buffer, 0, 1);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            button6.isOn = !button6.isOn;
            if (button6.isOn)
            {
                b6.BackColor = Color.LimeGreen;
                msg_buttons = 0b_0100_1111 | msg_buttons;
            }
            else
            {
                b6.BackColor = Color.Gainsboro;
                msg_buttons = 0b_1011_1111 & msg_buttons;
            }
            buffer = BitConverter.GetBytes(msg_buttons);
            myPort.Write(buffer, 0, 1);
        }
    }

}
