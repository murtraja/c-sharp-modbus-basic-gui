namespace Desktop_modbus_master
{
    partial class Form1
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
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.b_openPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_slaveIdRead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_startAddressRead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_numOfRegisters = new System.Windows.Forms.TextBox();
            this.tb_readValues = new System.Windows.Forms.TextBox();
            this.b_read = new System.Windows.Forms.Button();
            this.tb_startAddressWrite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_slaveIdWrite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_writeValues = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b_write = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.b_clearReadValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_ports
            // 
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.Location = new System.Drawing.Point(13, 13);
            this.cb_ports.Name = "cb_ports";
            this.cb_ports.Size = new System.Drawing.Size(121, 21);
            this.cb_ports.TabIndex = 0;
            // 
            // b_openPort
            // 
            this.b_openPort.Location = new System.Drawing.Point(141, 13);
            this.b_openPort.Name = "b_openPort";
            this.b_openPort.Size = new System.Drawing.Size(75, 23);
            this.b_openPort.TabIndex = 1;
            this.b_openPort.Text = "open port";
            this.b_openPort.UseVisualStyleBackColor = true;
            this.b_openPort.Click += new System.EventHandler(this.b_openPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slave Id";
            // 
            // tb_slaveIdRead
            // 
            this.tb_slaveIdRead.Location = new System.Drawing.Point(141, 57);
            this.tb_slaveIdRead.Name = "tb_slaveIdRead";
            this.tb_slaveIdRead.Size = new System.Drawing.Size(100, 20);
            this.tb_slaveIdRead.TabIndex = 3;
            this.tb_slaveIdRead.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "start address";
            // 
            // tb_startAddressRead
            // 
            this.tb_startAddressRead.Location = new System.Drawing.Point(141, 88);
            this.tb_startAddressRead.Name = "tb_startAddressRead";
            this.tb_startAddressRead.Size = new System.Drawing.Size(100, 20);
            this.tb_startAddressRead.TabIndex = 5;
            this.tb_startAddressRead.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of registers";
            // 
            // tb_numOfRegisters
            // 
            this.tb_numOfRegisters.Location = new System.Drawing.Point(141, 119);
            this.tb_numOfRegisters.Name = "tb_numOfRegisters";
            this.tb_numOfRegisters.Size = new System.Drawing.Size(100, 20);
            this.tb_numOfRegisters.TabIndex = 7;
            this.tb_numOfRegisters.Text = "10";
            // 
            // tb_readValues
            // 
            this.tb_readValues.Location = new System.Drawing.Point(273, 57);
            this.tb_readValues.Multiline = true;
            this.tb_readValues.Name = "tb_readValues";
            this.tb_readValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_readValues.Size = new System.Drawing.Size(100, 79);
            this.tb_readValues.TabIndex = 8;
            // 
            // b_read
            // 
            this.b_read.Location = new System.Drawing.Point(389, 86);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(75, 23);
            this.b_read.TabIndex = 9;
            this.b_read.Text = "read";
            this.b_read.UseVisualStyleBackColor = true;
            this.b_read.Click += new System.EventHandler(this.b_read_Click);
            // 
            // tb_startAddressWrite
            // 
            this.tb_startAddressWrite.Location = new System.Drawing.Point(141, 202);
            this.tb_startAddressWrite.Name = "tb_startAddressWrite";
            this.tb_startAddressWrite.Size = new System.Drawing.Size(100, 20);
            this.tb_startAddressWrite.TabIndex = 13;
            this.tb_startAddressWrite.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "start address";
            // 
            // tb_slaveIdWrite
            // 
            this.tb_slaveIdWrite.Location = new System.Drawing.Point(141, 171);
            this.tb_slaveIdWrite.Name = "tb_slaveIdWrite";
            this.tb_slaveIdWrite.Size = new System.Drawing.Size(100, 20);
            this.tb_slaveIdWrite.TabIndex = 11;
            this.tb_slaveIdWrite.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Slave Id";
            // 
            // tb_writeValues
            // 
            this.tb_writeValues.Location = new System.Drawing.Point(141, 233);
            this.tb_writeValues.Name = "tb_writeValues";
            this.tb_writeValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_writeValues.Size = new System.Drawing.Size(232, 20);
            this.tb_writeValues.TabIndex = 14;
            this.tb_writeValues.Text = "1234,5678,9012";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "values to be written";
            // 
            // b_write
            // 
            this.b_write.Location = new System.Drawing.Point(389, 202);
            this.b_write.Name = "b_write";
            this.b_write.Size = new System.Drawing.Size(75, 23);
            this.b_write.TabIndex = 16;
            this.b_write.Text = "write";
            this.b_write.UseVisualStyleBackColor = true;
            this.b_write.Click += new System.EventHandler(this.b_write_Click);
            // 
            // b_clearReadValues
            // 
            this.b_clearReadValues.Location = new System.Drawing.Point(389, 57);
            this.b_clearReadValues.Name = "b_clearReadValues";
            this.b_clearReadValues.Size = new System.Drawing.Size(75, 23);
            this.b_clearReadValues.TabIndex = 17;
            this.b_clearReadValues.Text = "clear";
            this.b_clearReadValues.UseVisualStyleBackColor = true;
            this.b_clearReadValues.Click += new System.EventHandler(this.b_clearReadValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 274);
            this.Controls.Add(this.b_clearReadValues);
            this.Controls.Add(this.b_write);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_writeValues);
            this.Controls.Add(this.tb_startAddressWrite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_slaveIdWrite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_read);
            this.Controls.Add(this.tb_readValues);
            this.Controls.Add(this.tb_numOfRegisters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_startAddressRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_slaveIdRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_openPort);
            this.Controls.Add(this.cb_ports);
            this.Name = "Form1";
            this.Text = "Modbus Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ports;
        private System.Windows.Forms.Button b_openPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_slaveIdRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_startAddressRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_numOfRegisters;
        private System.Windows.Forms.TextBox tb_readValues;
        private System.Windows.Forms.Button b_read;
        private System.Windows.Forms.TextBox tb_startAddressWrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_slaveIdWrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_writeValues;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_write;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button b_clearReadValues;
    }
}

