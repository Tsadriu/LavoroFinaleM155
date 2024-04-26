using System.IO.Ports;

namespace LavoroFinaleM155
{
    public partial class Form1 : Form
    {
        private static SerialPort _serialPort = _serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LedTrackBarOnChanged(object sender, EventArgs e)
        {
            if (ledTrackBar.Value > 0)
            {
                ledValueLabel.Text = ((float)(ledTrackBar.Value / 255.0f) * 100.0f).ToString("#") + "%";
                return;
            }

            ledValueLabel.Text = "0%";
        }

        private void SendCommandButtonOnClick(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                MessageBox.Show("Please make sure your board is configured correctly, and connected to this device and try again.", "Could not connect to Arduino!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ledComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid LED first.", "No led selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        private void ApplyBoardConfigButtonOnClick(object sender, EventArgs e)
        {
            SetupSerialPort();
        }

        private void SetupSerialPort()
        {
            try
            {
                if (string.IsNullOrEmpty(portBox.Text) && baudNumericUpDown.Value <= 0)
                {
                    _serialPort.PortName = "COM3";
                    _serialPort.BaudRate = 9600;
                }
                else
                {
                    _serialPort.PortName = portBox.Text;
                    _serialPort.BaudRate = (int)baudNumericUpDown.Value;
                }

                _serialPort.Open();
                MessageBox.Show($"Successfully communicating with port '{_serialPort.PortName}' - Baud {_serialPort.BaudRate}", "Connection successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Could not connect to port '{_serialPort.PortName}' - Baud {_serialPort.BaudRate}", "Connection unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
