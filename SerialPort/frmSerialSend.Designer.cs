namespace SerialPort
{
    partial class frmSerialSend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spPort = new System.IO.Ports.SerialPort(this.components);
            this.lblPortaSerial = new System.Windows.Forms.Label();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblErrorSerial = new System.Windows.Forms.Label();
            this.txtDadosEnviar = new System.Windows.Forms.RichTextBox();
            this.txtDadosRecebidos = new System.Windows.Forms.RichTextBox();
            this.txtEnviar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLimparEnviar = new System.Windows.Forms.Button();
            this.btnLimparRecv = new System.Windows.Forms.Button();
            this.btnEnviarDados = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spPort
            // 
            this.spPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spPort_DataReceived);
            // 
            // lblPortaSerial
            // 
            this.lblPortaSerial.AutoSize = true;
            this.lblPortaSerial.Location = new System.Drawing.Point(45, 43);
            this.lblPortaSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortaSerial.Name = "lblPortaSerial";
            this.lblPortaSerial.Size = new System.Drawing.Size(83, 18);
            this.lblPortaSerial.TabIndex = 0;
            this.lblPortaSerial.Text = "Porta Serial:";
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(135, 40);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(143, 26);
            this.cbSerialPort.TabIndex = 1;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(58, 77);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(71, 18);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "BaudRate:";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(135, 72);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(143, 26);
            this.cbBaudRate.TabIndex = 3;
            // 
            // lblErrorSerial
            // 
            this.lblErrorSerial.AutoSize = true;
            this.lblErrorSerial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSerial.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSerial.Location = new System.Drawing.Point(132, 19);
            this.lblErrorSerial.Name = "lblErrorSerial";
            this.lblErrorSerial.Size = new System.Drawing.Size(225, 18);
            this.lblErrorSerial.TabIndex = 4;
            this.lblErrorSerial.Text = "* Nenhuma porta serial disponivel!";
            this.lblErrorSerial.Visible = false;
            // 
            // txtDadosEnviar
            // 
            this.txtDadosEnviar.Location = new System.Drawing.Point(12, 152);
            this.txtDadosEnviar.Name = "txtDadosEnviar";
            this.txtDadosEnviar.Size = new System.Drawing.Size(235, 96);
            this.txtDadosEnviar.TabIndex = 5;
            this.txtDadosEnviar.Text = "";
            // 
            // txtDadosRecebidos
            // 
            this.txtDadosRecebidos.Location = new System.Drawing.Point(275, 152);
            this.txtDadosRecebidos.Name = "txtDadosRecebidos";
            this.txtDadosRecebidos.ReadOnly = true;
            this.txtDadosRecebidos.Size = new System.Drawing.Size(235, 96);
            this.txtDadosRecebidos.TabIndex = 6;
            this.txtDadosRecebidos.Text = "";
            // 
            // txtEnviar
            // 
            this.txtEnviar.AutoSize = true;
            this.txtEnviar.Location = new System.Drawing.Point(12, 131);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(121, 18);
            this.txtEnviar.TabIndex = 7;
            this.txtEnviar.Text = "Dados para Enviar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dados Recebidos:";
            // 
            // lblLimparEnviar
            // 
            this.lblLimparEnviar.Location = new System.Drawing.Point(139, 254);
            this.lblLimparEnviar.Name = "lblLimparEnviar";
            this.lblLimparEnviar.Size = new System.Drawing.Size(108, 37);
            this.lblLimparEnviar.TabIndex = 9;
            this.lblLimparEnviar.Text = "&Limpar";
            this.lblLimparEnviar.UseVisualStyleBackColor = true;
            this.lblLimparEnviar.Click += new System.EventHandler(this.lblLimparEnviar_Click);
            // 
            // btnLimparRecv
            // 
            this.btnLimparRecv.Location = new System.Drawing.Point(401, 254);
            this.btnLimparRecv.Name = "btnLimparRecv";
            this.btnLimparRecv.Size = new System.Drawing.Size(108, 37);
            this.btnLimparRecv.TabIndex = 10;
            this.btnLimparRecv.Text = "L&impar";
            this.btnLimparRecv.UseVisualStyleBackColor = true;
            this.btnLimparRecv.Click += new System.EventHandler(this.btnLimparRecv_Click);
            // 
            // btnEnviarDados
            // 
            this.btnEnviarDados.Location = new System.Drawing.Point(12, 254);
            this.btnEnviarDados.Name = "btnEnviarDados";
            this.btnEnviarDados.Size = new System.Drawing.Size(108, 37);
            this.btnEnviarDados.TabIndex = 11;
            this.btnEnviarDados.Text = "&Enviar";
            this.btnEnviarDados.UseVisualStyleBackColor = true;
            this.btnEnviarDados.Click += new System.EventHandler(this.btnEnviarDados_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Enabled = false;
            this.btnFechar.Location = new System.Drawing.Point(284, 40);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(105, 26);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "&Fechar Porta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmSerialSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 331);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEnviarDados);
            this.Controls.Add(this.btnLimparRecv);
            this.Controls.Add(this.lblLimparEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.txtDadosRecebidos);
            this.Controls.Add(this.txtDadosEnviar);
            this.Controls.Add(this.lblErrorSerial);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.cbSerialPort);
            this.Controls.Add(this.lblPortaSerial);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 370);
            this.MinimumSize = new System.Drawing.Size(538, 370);
            this.Name = "frmSerialSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSerialSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spPort;
        private System.Windows.Forms.Label lblPortaSerial;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label lblErrorSerial;
        private System.Windows.Forms.RichTextBox txtDadosEnviar;
        private System.Windows.Forms.RichTextBox txtDadosRecebidos;
        private System.Windows.Forms.Label txtEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblLimparEnviar;
        private System.Windows.Forms.Button btnLimparRecv;
        private System.Windows.Forms.Button btnEnviarDados;
        private System.Windows.Forms.Button btnFechar;
    }
}

