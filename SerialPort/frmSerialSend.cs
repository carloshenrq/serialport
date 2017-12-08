using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPort
{
    public partial class frmSerialSend : Form
    {
        public frmSerialSend()
        {
            InitializeComponent();
        }

        private void frmSerialSend_Load(object sender, EventArgs e)
        {
            string[] sSerialPorts = System.IO.Ports.SerialPort.GetPortNames();
            if (sSerialPorts.Length == 0)
            {
                this.lblErrorSerial.Visible = true;
            }
            else
            {
                sSerialPorts.ToList().ForEach(serialPort =>
                {
                    cbSerialPort.Items.Add(serialPort);
                });
                cbSerialPort.SelectedIndex = 0;
            }

            cbBaudRate.SelectedIndex = 3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string sValorRetornado = this.spPort.ReadExisting();
            this.txtDadosRecebidos.Text = sValorRetornado;
        }

        private void lblLimparEnviar_Click(object sender, EventArgs e)
        {
            this.txtDadosEnviar.Text = "";
        }

        private void btnLimparRecv_Click(object sender, EventArgs e)
        {
            this.txtDadosRecebidos.Text = "";
        }

        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            if(!this.spPort.IsOpen)
            {
                this.spPort.PortName = this.cbSerialPort.SelectedItem.ToString();
                this.spPort.BaudRate = Convert.ToInt32(this.cbBaudRate.SelectedItem);
                this.spPort.Open();
                this.btnFechar.Enabled = true;
                this.cbBaudRate.Enabled = this.cbSerialPort.Enabled = false;
            }

            this.spPort.WriteLine(this.txtDadosEnviar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (this.spPort.IsOpen)
            {
                this.spPort.Close();
                this.btnFechar.Enabled = false;
                this.cbBaudRate.Enabled = this.cbSerialPort.Enabled = true;
            }
        }
    }
}
