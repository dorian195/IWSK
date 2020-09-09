namespace Iwsk2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxProtocole = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxMaster = new System.Windows.Forms.GroupBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.transactionAddress = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.receivedMessage = new System.Windows.Forms.RichTextBox();
            this.buttonMasterSendMessage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.masterSendMessage = new System.Windows.Forms.RichTextBox();
            this.comboBoxOrderType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxMasterFrameCharsTimeLimit = new System.Windows.Forms.ComboBox();
            this.comboBoxRetransmission = new System.Windows.Forms.ComboBox();
            this.comboBoxTransactionTimeLimit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSlave = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSlaveSendMessage = new System.Windows.Forms.Button();
            this.comboBoxMessageType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonExecuteOrder = new System.Windows.Forms.Button();
            this.buttonAddressCheck = new System.Windows.Forms.Button();
            this.buttonFrameCheck = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.slaveAddress = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSlaveFrameCharsTimeLimit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSlaveReceiveMsg = new System.Windows.Forms.Button();
            this.groupBoxMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAddress)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxSlave.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slaveAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProtocole
            // 
            this.comboBoxProtocole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocole.FormattingEnabled = true;
            this.comboBoxProtocole.Location = new System.Drawing.Point(267, 32);
            this.comboBoxProtocole.Name = "comboBoxProtocole";
            this.comboBoxProtocole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProtocole.TabIndex = 0;
            this.comboBoxProtocole.SelectedIndexChanged += new System.EventHandler(this.comboBoxProtocole_SelectedIndexChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(407, 32);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.Sorted = true;
            this.comboBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rodzaj stacji Modbus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // groupBoxMaster
            // 
            this.groupBoxMaster.Controls.Add(this.disconnect);
            this.groupBoxMaster.Controls.Add(this.connect);
            this.groupBoxMaster.Controls.Add(this.transactionAddress);
            this.groupBoxMaster.Controls.Add(this.label10);
            this.groupBoxMaster.Controls.Add(this.receivedMessage);
            this.groupBoxMaster.Controls.Add(this.buttonMasterSendMessage);
            this.groupBoxMaster.Controls.Add(this.groupBox4);
            this.groupBoxMaster.Controls.Add(this.groupBox3);
            this.groupBoxMaster.Controls.Add(this.label4);
            this.groupBoxMaster.Controls.Add(this.comboBoxTransactionType);
            this.groupBoxMaster.Controls.Add(this.label3);
            this.groupBoxMaster.Location = new System.Drawing.Point(12, 59);
            this.groupBoxMaster.Name = "groupBoxMaster";
            this.groupBoxMaster.Size = new System.Drawing.Size(776, 206);
            this.groupBoxMaster.TabIndex = 4;
            this.groupBoxMaster.TabStop = false;
            this.groupBoxMaster.Text = "Master";
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(395, 169);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(133, 31);
            this.disconnect.TabIndex = 11;
            this.disconnect.Text = "Odłącz";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(257, 169);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(132, 31);
            this.connect.TabIndex = 10;
            this.connect.Text = "Połącz";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // transactionAddress
            // 
            this.transactionAddress.Enabled = false;
            this.transactionAddress.Location = new System.Drawing.Point(9, 121);
            this.transactionAddress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.transactionAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionAddress.Name = "transactionAddress";
            this.transactionAddress.Size = new System.Drawing.Size(120, 20);
            this.transactionAddress.TabIndex = 9;
            this.transactionAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Odebrany tekst:";
            // 
            // receivedMessage
            // 
            this.receivedMessage.Location = new System.Drawing.Point(571, 81);
            this.receivedMessage.Name = "receivedMessage";
            this.receivedMessage.ReadOnly = true;
            this.receivedMessage.Size = new System.Drawing.Size(190, 82);
            this.receivedMessage.TabIndex = 7;
            this.receivedMessage.Text = "";
            // 
            // buttonMasterSendMessage
            // 
            this.buttonMasterSendMessage.Location = new System.Drawing.Point(571, 19);
            this.buttonMasterSendMessage.Name = "buttonMasterSendMessage";
            this.buttonMasterSendMessage.Size = new System.Drawing.Size(190, 23);
            this.buttonMasterSendMessage.TabIndex = 6;
            this.buttonMasterSendMessage.Text = "Wyślij";
            this.buttonMasterSendMessage.UseVisualStyleBackColor = true;
            this.buttonMasterSendMessage.Click += new System.EventHandler(this.buttonMasterSendMessage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.masterSendMessage);
            this.groupBox4.Controls.Add(this.comboBoxOrderType);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(395, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 154);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ramka:";
            // 
            // masterSendMessage
            // 
            this.masterSendMessage.Location = new System.Drawing.Point(21, 72);
            this.masterSendMessage.Name = "masterSendMessage";
            this.masterSendMessage.Size = new System.Drawing.Size(121, 76);
            this.masterSendMessage.TabIndex = 0;
            this.masterSendMessage.Text = "";
            // 
            // comboBoxOrderType
            // 
            this.comboBoxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderType.FormattingEnabled = true;
            this.comboBoxOrderType.Location = new System.Drawing.Point(21, 33);
            this.comboBoxOrderType.Name = "comboBoxOrderType";
            this.comboBoxOrderType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderType.TabIndex = 2;
            this.comboBoxOrderType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Argumenty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rozkaz:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxMasterFrameCharsTimeLimit);
            this.groupBox3.Controls.Add(this.comboBoxRetransmission);
            this.groupBox3.Controls.Add(this.comboBoxTransactionTimeLimit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(137, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrola stacji:";
            // 
            // comboBoxMasterFrameCharsTimeLimit
            // 
            this.comboBoxMasterFrameCharsTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMasterFrameCharsTimeLimit.FormattingEnabled = true;
            this.comboBoxMasterFrameCharsTimeLimit.Location = new System.Drawing.Point(19, 111);
            this.comboBoxMasterFrameCharsTimeLimit.Name = "comboBoxMasterFrameCharsTimeLimit";
            this.comboBoxMasterFrameCharsTimeLimit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMasterFrameCharsTimeLimit.TabIndex = 5;
            // 
            // comboBoxRetransmission
            // 
            this.comboBoxRetransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRetransmission.FormattingEnabled = true;
            this.comboBoxRetransmission.Location = new System.Drawing.Point(19, 72);
            this.comboBoxRetransmission.Name = "comboBoxRetransmission";
            this.comboBoxRetransmission.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRetransmission.TabIndex = 4;
            // 
            // comboBoxTransactionTimeLimit
            // 
            this.comboBoxTransactionTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransactionTimeLimit.FormattingEnabled = true;
            this.comboBoxTransactionTimeLimit.Location = new System.Drawing.Point(19, 31);
            this.comboBoxTransactionTimeLimit.Name = "comboBoxTransactionTimeLimit";
            this.comboBoxTransactionTimeLimit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransactionTimeLimit.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ograniczenie czasowe między znakami ramki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Liczba retransmisji:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ograniczenie czasowe na wykonanie transakcji:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres transakcji:";
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Location = new System.Drawing.Point(9, 56);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransactionType.TabIndex = 1;
            this.comboBoxTransactionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransactionType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rodzaj transakcji:";
            // 
            // groupBoxSlave
            // 
            this.groupBoxSlave.Controls.Add(this.groupBox6);
            this.groupBoxSlave.Controls.Add(this.buttonExecuteOrder);
            this.groupBoxSlave.Controls.Add(this.buttonAddressCheck);
            this.groupBoxSlave.Controls.Add(this.buttonFrameCheck);
            this.groupBoxSlave.Controls.Add(this.groupBox5);
            this.groupBoxSlave.Controls.Add(this.buttonSlaveReceiveMsg);
            this.groupBoxSlave.Location = new System.Drawing.Point(12, 271);
            this.groupBoxSlave.Name = "groupBoxSlave";
            this.groupBoxSlave.Size = new System.Drawing.Size(776, 167);
            this.groupBoxSlave.TabIndex = 5;
            this.groupBoxSlave.TabStop = false;
            this.groupBoxSlave.Text = "Slave";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonSlaveSendMessage);
            this.groupBox6.Controls.Add(this.comboBoxMessageType);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(589, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(156, 136);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Odpowiedź:";
            // 
            // buttonSlaveSendMessage
            // 
            this.buttonSlaveSendMessage.Location = new System.Drawing.Point(21, 82);
            this.buttonSlaveSendMessage.Name = "buttonSlaveSendMessage";
            this.buttonSlaveSendMessage.Size = new System.Drawing.Size(121, 29);
            this.buttonSlaveSendMessage.TabIndex = 2;
            this.buttonSlaveSendMessage.Text = "Wyślij";
            this.buttonSlaveSendMessage.UseVisualStyleBackColor = true;
            this.buttonSlaveSendMessage.Click += new System.EventHandler(this.buttonSlaveSendMessage_Click);
            // 
            // comboBoxMessageType
            // 
            this.comboBoxMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMessageType.FormattingEnabled = true;
            this.comboBoxMessageType.Location = new System.Drawing.Point(21, 34);
            this.comboBoxMessageType.Name = "comboBoxMessageType";
            this.comboBoxMessageType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMessageType.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Rodzaj odpowiedzi:";
            // 
            // buttonExecuteOrder
            // 
            this.buttonExecuteOrder.Location = new System.Drawing.Point(145, 104);
            this.buttonExecuteOrder.Name = "buttonExecuteOrder";
            this.buttonExecuteOrder.Size = new System.Drawing.Size(120, 37);
            this.buttonExecuteOrder.TabIndex = 4;
            this.buttonExecuteOrder.Text = "Wykonaj rozkaz";
            this.buttonExecuteOrder.UseVisualStyleBackColor = true;
            this.buttonExecuteOrder.Click += new System.EventHandler(this.buttonExecuteOrder_Click);
            // 
            // buttonAddressCheck
            // 
            this.buttonAddressCheck.Location = new System.Drawing.Point(144, 40);
            this.buttonAddressCheck.Name = "buttonAddressCheck";
            this.buttonAddressCheck.Size = new System.Drawing.Size(121, 43);
            this.buttonAddressCheck.TabIndex = 3;
            this.buttonAddressCheck.Text = "Sprawdź adres";
            this.buttonAddressCheck.UseVisualStyleBackColor = true;
            this.buttonAddressCheck.Click += new System.EventHandler(this.buttonAddressCheck_Click);
            // 
            // buttonFrameCheck
            // 
            this.buttonFrameCheck.Location = new System.Drawing.Point(10, 104);
            this.buttonFrameCheck.Name = "buttonFrameCheck";
            this.buttonFrameCheck.Size = new System.Drawing.Size(120, 37);
            this.buttonFrameCheck.TabIndex = 2;
            this.buttonFrameCheck.Text = "Sprawdź ramkę";
            this.buttonFrameCheck.UseVisualStyleBackColor = true;
            this.buttonFrameCheck.Click += new System.EventHandler(this.buttonFrameCheck_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.slaveAddress);
            this.groupBox5.Controls.Add(this.comboBoxSlaveFrameCharsTimeLimit);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(285, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 136);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kontrola stacji:";
            // 
            // slaveAddress
            // 
            this.slaveAddress.Location = new System.Drawing.Point(22, 34);
            this.slaveAddress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.slaveAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slaveAddress.Name = "slaveAddress";
            this.slaveAddress.Size = new System.Drawing.Size(120, 20);
            this.slaveAddress.TabIndex = 4;
            this.slaveAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxSlaveFrameCharsTimeLimit
            // 
            this.comboBoxSlaveFrameCharsTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSlaveFrameCharsTimeLimit.FormattingEnabled = true;
            this.comboBoxSlaveFrameCharsTimeLimit.Location = new System.Drawing.Point(22, 102);
            this.comboBoxSlaveFrameCharsTimeLimit.Name = "comboBoxSlaveFrameCharsTimeLimit";
            this.comboBoxSlaveFrameCharsTimeLimit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSlaveFrameCharsTimeLimit.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ograniczenie czasowe między znakami ramki:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adres stacji:";
            // 
            // buttonSlaveReceiveMsg
            // 
            this.buttonSlaveReceiveMsg.Location = new System.Drawing.Point(10, 42);
            this.buttonSlaveReceiveMsg.Name = "buttonSlaveReceiveMsg";
            this.buttonSlaveReceiveMsg.Size = new System.Drawing.Size(120, 41);
            this.buttonSlaveReceiveMsg.TabIndex = 0;
            this.buttonSlaveReceiveMsg.Text = "Odbiór zapytania";
            this.buttonSlaveReceiveMsg.UseVisualStyleBackColor = true;
            this.buttonSlaveReceiveMsg.Click += new System.EventHandler(this.buttonSlaveReceiveMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSlave);
            this.Controls.Add(this.groupBoxMaster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.comboBoxProtocole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMaster.ResumeLayout(false);
            this.groupBoxMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAddress)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSlave.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slaveAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxProtocole;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxSlave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxMasterFrameCharsTimeLimit;
        private System.Windows.Forms.ComboBox comboBoxRetransmission;
        private System.Windows.Forms.ComboBox comboBoxTransactionTimeLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox receivedMessage;
        private System.Windows.Forms.Button buttonMasterSendMessage;
        private System.Windows.Forms.RichTextBox masterSendMessage;
        private System.Windows.Forms.ComboBox comboBoxOrderType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxSlaveFrameCharsTimeLimit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSlaveReceiveMsg;
        private System.Windows.Forms.Button buttonFrameCheck;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxMessageType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonExecuteOrder;
        private System.Windows.Forms.Button buttonAddressCheck;
        private System.Windows.Forms.Button buttonSlaveSendMessage;
        private System.Windows.Forms.NumericUpDown transactionAddress;
        private System.Windows.Forms.NumericUpDown slaveAddress;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
    }
}

