using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLib;

namespace PlotGraph
{
    public partial class MainControlForm : Form
    {
        private readonly int BAUD_RATE = 9600;
        private readonly int BITS = 8;
        private SerialPort port;
        private byte[] _dataBuffer;
        public MainControlForm()
        {
            InitializeComponent();
            SetupComPortDropDown();
            //TempDataFeed();
            //PressureDataFeed();
            _dataBuffer = new byte[20];
        }

        private void SetupComPortDropDown()
        {
            // COMs
            foreach (var serialPortName in SerialPort.GetPortNames())
            {
                this.comPortDD.Items.Add(serialPortName);
            }

            // hadle port selected
            this.comPortDD.SelectedValueChanged += (sender, args) =>
            {
                var portName = ((ComboBox) sender).SelectedItem.ToString();
                if (!string.IsNullOrEmpty(portName))
                {
                    SetupSerialPort(portName);
                }
            };
        }

        private void SetupSerialPort(string portName)
        {
            port = new SerialPort(portName, BAUD_RATE, Parity.None, BITS, StopBits.One);
            try
            {
                port.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                if (port != null)
                {
                    port.Dispose();
                }
                return;
            }

            port.DataReceived += SerialPortDataReceivedHadnler;
        }

        private void SerialPortDataReceivedHadnler(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[port.BytesToRead];
            port.Read(data, 0, data.Length);
            ProccessSerialData(data);
        }

        private void ProccessSerialData(byte[] data)
        {
            if (_dataBuffer.All(x => x == Globals.Bytes.NUL))
            {
                data.CopyTo(_dataBuffer, 0);
            }
            else
            {
                data.CopyTo(_dataBuffer, _dataBuffer.IndexOfFirstElement(x => x == Globals.Bytes.NUL));
            }

            if (_dataBuffer.EndsWithCRLF())
            {
                var dataString = Encoding.ASCII.GetString(_dataBuffer.GetBytesWithoutCRLF());
                _dataBuffer.Clear();
                UpdateGraph(dataString);
            }
        }

        private void UpdateGraph(string value)
        {
            //var success = Int32.TryParse(value, out int intValue);
            var success = float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out float intValue);
            if (success)
            {
                var slineGraph = this.oneSLineGraphTemp;
                var valueX = (int)slineGraph.LastXValue;
                valueX++;
                slineGraph.AddPoint(new PointF(valueX, intValue));
            }
        }

        private void TempDataFeed()
        {
            var thread = new Thread(() =>
            {
                var slineGraph = this.oneSLineGraphTemp;
                var valueX = 0;
                var randomGen = new Random();
                while (true)
                {
                    var valueY = randomGen.Next(0, 100);
                    slineGraph.AddPoint(new Point(valueX, valueY));
                    valueX++;
                    Thread.Sleep(100);
                }
            });
            thread.Start();
        }

        private void PressureDataFeed()
        {
            var thread = new Thread(() =>
            {
                var slineGraph = this.oneSLineGraphPress;
                var valueX = 0;
                var randomGen = new Random();
                while (true)
                {
                    var valueY = randomGen.Next(0, 100);
                    slineGraph.AddPoint(new Point(valueX, valueY));
                    valueX++;
                    Thread.Sleep(100);
                }
            });
            thread.Start();
        }
    }
}           
                