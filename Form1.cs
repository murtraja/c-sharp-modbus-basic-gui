using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus.Device;

namespace Desktop_modbus_master
{
    public partial class Form1 : Form
    {
        IModbusSerialMaster mb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_ports.DataSource = SerialPort.GetPortNames();
            cb_ports.SelectedIndex = 4;

            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;
            serialPort1.RtsEnable = true;
            serialPort1.ReadTimeout = 400;

            b_read.Hide();

            b_write.Hide();

            tb_readValues.ReadOnly = true;

        }

        private void b_openPort_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cb_ports.Text;
            serialPort1.Open();
            b_read.Visible = true;
            b_write.Visible = true;
            mb = ModbusSerialMaster.CreateRtu(serialPort1);
        }
        private void b_read_Click(object sender, EventArgs e)
        {
            byte slaveId;
            bool parsed = byte.TryParse(tb_slaveIdRead.Text, out slaveId);
            //include an error condition check here!
            if (!isParsed(parsed, tb_slaveIdRead.Text, "byte"))
            {
                return;
            }

            ushort startAddress;
            parsed = ushort.TryParse(tb_startAddressRead.Text, out startAddress);
            if (!isParsed(parsed, tb_startAddressRead.Text, "ushort"))
            {
                return;
            }

            ushort numRegisters = 5;
            parsed = ushort.TryParse(tb_numOfRegisters.Text, out numRegisters);
            if (!isParsed(parsed, tb_startAddressRead.Text, "ushort"))
            {
                return;
            }
            ushort[] registers = null;
            try
            {
                registers = mb.ReadInputRegisters(slaveId, startAddress, numRegisters);
            }catch (Exception ee) 
            {
                MessageBox.Show(ee.Message);
                return;
            }
            
            for (int i = 0; i < numRegisters; i++)
            {
                tb_readValues.AppendText(registers[i].ToString() + "\n");
            }
            tb_readValues.AppendText("\n");
        }

        private void b_write_Click(object sender, EventArgs e)
        {
            byte slaveId;
            bool parsed = byte.TryParse(tb_slaveIdWrite.Text, out slaveId);
            if (!isParsed(parsed, tb_slaveIdWrite.Text, "byte"))
            {
                return;
            }

            ushort startAddress;
            parsed = ushort.TryParse(tb_startAddressWrite.Text, out startAddress);
            if (!isParsed(parsed, tb_startAddressWrite.Text, "ushort"))
            {
                return;
            }

            
            string input = tb_writeValues.Text;
            string[] inputArray = input.Split(',');
            //now split the input received
            List<ushort> registerValues = new List<ushort>();
            foreach(string s in inputArray)
            {
                //MessageBox.Show("now iterating for |" + s + "|");
                ushort reg;
                parsed = ushort.TryParse(s, out reg);
                if (!isParsed(parsed, s, "ushort"))
                {
                    return;
                }
                registerValues.Add(reg);
            }
            ushort[] registers = registerValues.ToArray();
            mb.WriteMultipleRegisters(slaveId, startAddress, registers);
        }
        private bool isParsed(bool parsed, string from, string to)
        {
            if (!parsed)
            {
                MessageBox.Show("Sorry, could not parse '" + from + "' to a " + to);
            }
            return parsed;
                
        }

        private void b_clearReadValues_Click(object sender, EventArgs e)
        {
            tb_readValues.Text = "";
        }

        
    }
}
