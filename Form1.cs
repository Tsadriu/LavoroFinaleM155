using System.IO.Ports;

namespace LavoroFinaleM155
{
    public partial class Form1 : Form
    {
        private static SerialPort _serialPort = _serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            portNotFoundLabel.Text = string.Empty;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (ledTrackBar.Value > 0)
            {
                ledValueLabel.Text = ((float)(ledTrackBar.Value / 255.0f) * 100.0f).ToString("#") + "%";
                return;
            }

            ledValueLabel.Text = "0%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ledComboBox.SelectedIndex == -1)
            {
                return;
            }

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
                portNotFoundLabel.Text = $"Comunicating with port '{_serialPort.PortName}' - Baud {_serialPort.BaudRate}";
                portNotFoundLabel.ForeColor = Color.Green;
            }
            catch
            {
                portNotFoundLabel.Text = $"Port '{_serialPort.PortName}' - Baud {_serialPort.BaudRate} not found!";
                portNotFoundLabel.ForeColor = Color.Red;
            }
        }

        private void applyBoardConfigButton_Click(object sender, EventArgs e)
        {
            SetupSerialPort();
        }
    }
}
