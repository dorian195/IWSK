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

/*
 * DO ZROBIENIA na pewno na samym dole:
 * 
 * Odebranie wiadomości przez Slave'a
 * Sprawdzenie poprawności adresu
 * Sprawdzenie poprawności ramki
 * Wykonanie rozkazu
 * Odesłanie wiadomości zwrotnej przez Slave'a
 * 
 * Generalnie część po stronie Slave'a, praktycznie analogicznie
 */

namespace Iwsk2
{
    //Struktura ramki
    struct Message
    {
        public char[] sof;
        public char[] address;
        public char[] order;
        public char[] message;
        public char[] lrc;
        public char[] eof;

        public Message(char[] sof, char[] eof)
        {
            this.sof = sof;
            this.address = null;
            this.order = null;
            this.message = null;
            this.lrc = null;
            this.eof = eof;
        }
        public void deleteMessage()
        {
            this.address = null;
            this.order = null;
            this.message = null;
            this.lrc = null;
        }
    }
    public partial class Form1 : Form
    {
        const string addressTrans = "Adresowana";
        const string broadcastTrans = "Rozgłoszeniowa";
        const string normalAnswer = "Normalna";
        const string specialAnswer = "Szczególna";
        Message message;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProtocole.Items.Add("Master");
            comboBoxProtocole.Items.Add("Slave");
            comboBoxTransactionType.Items.Add(addressTrans);
            comboBoxTransactionType.Items.Add(broadcastTrans);
            comboBoxMessageType.Items.Add(specialAnswer);
            comboBoxMessageType.Items.Add(normalAnswer);
            comboBoxOrderType.Items.Add(1);
            comboBoxOrderType.Items.Add(2);
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            masterSendMessage.MaxLength = 252;
            comboBoxMasterFrameCharsTimeLimit.Items.Add(0);
            comboBoxSlaveFrameCharsTimeLimit.Items.Add(0);

            for (int i =100;i<=10000; i =i +100)
            {
                comboBoxMasterFrameCharsTimeLimit.Items.Add(i / 10);
                comboBoxTransactionTimeLimit.Items.Add(i);
                comboBoxSlaveFrameCharsTimeLimit.Items.Add(i / 10);
            }

            for(int i = 0; i<=5; i++)
            {
                comboBoxRetransmission.Items.Add(i);
            }

            //Wartości startowe
            comboBoxTransactionType.SelectedIndex = 0;
            comboBoxMessageType.SelectedIndex = 0;
            comboBoxTransactionTimeLimit.SelectedIndex = 0;
            comboBoxRetransmission.SelectedIndex = 0;
            comboBoxMasterFrameCharsTimeLimit.SelectedIndex = 0;
            comboBoxOrderType.SelectedIndex = 0;
            comboBoxSlaveFrameCharsTimeLimit.SelectedIndex = 0;

            if (comboBoxPort.Items.Count > 0)
            {
                comboBoxPort.SelectedIndex = 0;
            }
        }

        //Blokuje okna Slave i Master w zależności od wyboru
        private void comboBoxProtocole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxProtocole.Text == "Master" && comboBoxPort.Text != "")
            //{
            //    groupBoxMaster.Enabled = true;
            //    groupBoxSlave.Enabled = false;
            //}
            //else if(comboBoxProtocole.Text == "Slave" && comboBoxPort.Text != "")
            //{
            //    groupBoxSlave.Enabled = true;
            //    groupBoxMaster.Enabled = false;
            //}
        }

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTransactionType.Text == addressTrans)
            {
                transactionAddress.Enabled = true;
            }
            else
            {
                transactionAddress.Enabled = false;
                comboBoxOrderType.SelectedIndex = 0;
            }
        }

        private void comboBoxOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxOrderType.Text == "2" && comboBoxTransactionType.Text == broadcastTrans)
            {
                comboBoxOrderType.SelectedIndex = 0;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //zamykanie portu po wyłączeniu programu
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadExisting();
        }

        //Automatyczne wyznaczanie LRC
        public static byte calculateLRC(byte[] bytes)
        {
            byte LRC = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                LRC ^= bytes[i];
            }
            return LRC;
        }

        //Wysłanie stworzonej ramki
        private void buttonMasterSendMessage_Click(object sender, EventArgs e)
        {
            message.address = transactionAddress.Value.ToString().ToCharArray();
            message.order = comboBoxOrderType.Text.ToCharArray();
            message.message = masterSendMessage.Text.ToCharArray();
            message.lrc = calculateLRC(Encoding.ASCII.GetBytes(masterSendMessage.Text.ToString())).ToString().ToCharArray();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {   
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.ReadTimeout = Convert.ToInt32(comboBoxTransactionTimeLimit.Text);
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            masterSendMessage.Enabled = true;
            connect.Enabled = false;
            disconnect.Enabled = true;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            disconnect.Enabled = false;
            connect.Enabled = true;
            masterSendMessage.Enabled = false;
        }

        //Odebranie wiadomości zwrotnej przez Mastera
        private void receivedMessage_TextChanged(object sender, EventArgs e)
        {
            string msg = serialPort1.ReadExisting();
            if (receivedMessage.InvokeRequired)
            {
                Action act = () => receivedMessage.Text += msg;
                Invoke(act);
            }
            else
            {
                receivedMessage.Text += msg;
            }
        }

        //Odebranie wiadomości przez Slave'a
        private void buttonSlaveReceiveMsg_Click(object sender, EventArgs e)
        {

        }
        //Sprawdzenie poprawności adresu
        private void buttonAddressCheck_Click(object sender, EventArgs e)
        {

        }
        //Sprawdzenie poprawności ramki
        private void buttonFrameCheck_Click(object sender, EventArgs e)
        {

        }
        //Wykonanie rozkazu
        private void buttonExecuteOrder_Click(object sender, EventArgs e)
        {

        }
        //Odesłanie wiadomości zwrotnej przez Slave'a
        private void buttonSlaveSendMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
