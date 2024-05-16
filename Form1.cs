using System.IO.Ports;

namespace LavoroFinaleM155
{
    public partial class Form1 : Form
    {
        private static readonly SerialPort SerialPort = SerialPort = new SerialPort();

        /// <summary>
        /// Represents the state of LedOne.
        /// </summary>
        /// <remarks>
        /// It returns a byte value, where 1 indicates that the LedOne is checked, and 0 indicates it is unchecked.
        /// </remarks>
        private byte LedOneState => (byte)(ledOneCheckBox.Checked ? 1 : 0);
        
        /// <summary>
        /// Represents the state of LedTwo.
        /// </summary>
        /// <remarks>
        /// It returns a byte value, where 1 indicates that the LedTwo is checked, and 0 indicates it is unchecked.
        /// </remarks>
        private byte LedTwoState => (byte)(ledTwoCheckBox.Checked ? 1 : 0);
        
        /// <summary>
        /// Represents the state of LedThree.
        /// </summary>
        /// <remarks>
        /// It returns a byte value, where 1 indicates that the LedThree is checked, and 0 indicates it is unchecked.
        /// </remarks>
        private byte LedThreeState => (byte)(ledThreeCheckBox.Checked ? 1 : 0);
        
        /// <summary>
        /// Represents the state of LedFour.
        /// </summary>
        /// <remarks>
        /// It returns a byte value, where 1 indicates that the LedFour is checked, and 0 indicates it is unchecked.
        /// </remarks>
        private byte LedFourState => (byte)(ledFourCheckBox.Checked ? 1 : 0);
        
        /// <summary>
        /// Represents the state of LedFive.
        /// </summary>
        /// <remarks>
        /// It returns a byte value, where 1 indicates that the LedFive is checked, and 0 indicates it is unchecked.
        /// </remarks>
        private byte LedFiveState => (byte)(ledFiveCheckBox.Checked ? 1 : 0);

        /// <summary>
        /// Represents the state of LedSix.
        /// </summary>
        /// <remarks>
        /// It returns a byte value, where 1 indicates that the LedSix is checked, and 0 indicates it is unchecked.
        /// </remarks>
        private byte LedSixState => (byte)(ledSixCheckBox.Checked ? 1 : 0);

        /// <summary>
        /// Represents a LED message consisting of the states of six LEDs.
        /// </summary>
        /// <example>110011.</example>
        private string LedMessage => $"{LedOneState}{LedTwoState}{LedThreeState}{LedFourState}{LedFiveState}{LedSixState}";

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Executes the SendCommandButtonOnClick event handler.
        /// </summary>
        /// <param name="sender">The object firing the event.</param>
        /// <param name="e">An EventArgs object containing event data.</param>
        private void SendCommandButtonOnClick(object sender, EventArgs e)
        {
            if (!SerialPort.IsOpen)
            {
                MessageBox.Show("Please make sure your board is configured correctly, and connected to this device and try again.", "Could not connect to Arduino!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SerialPort.Write($"{LedMessage}");
        }

        /// <summary>
        /// Event handler for ApplyBoardConfigButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ApplyBoardConfigButtonOnClick(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }
            try
            {
                if (string.IsNullOrEmpty(portBox.Text) || baudNumericUpDown.Value <= 0)
                {
                    SerialPort.PortName = "COM3";
                    SerialPort.BaudRate = 9600;
                }
                else
                {
                    SerialPort.PortName = portBox.Text;
                    SerialPort.BaudRate = (int)baudNumericUpDown.Value;
                }

                SerialPort.Open();
                MessageBox.Show($"Successfully communicating with port '{SerialPort.PortName}' - Baud {SerialPort.BaudRate}", "Connection successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Could not connect to port '{SerialPort.PortName}' - Baud {SerialPort.BaudRate}", "Connection unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets all LED checkboxes and sends a message to the serial port.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ResetAllLedsOnClick(object sender, EventArgs e)
        {
            ledOneCheckBox.Checked = false;
            ledTwoCheckBox.Checked = false;
            ledThreeCheckBox.Checked = false;
            ledFourCheckBox.Checked = false;
            ledFiveCheckBox.Checked = false;
            ledSixCheckBox.Checked = false;
            SerialPort.Write($"{LedMessage}");
        }

        /// <summary>
        /// Handles the click event of the DisconnectButton.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void DisconnectButtonOnClick(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
                MessageBox.Show($"Disconnected from '{SerialPort.PortName}' - Baud {SerialPort.BaudRate}", "Disconnection successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"You can't disconnect from something you're not even connected to 💀", "Why?", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Event handler for the Random LEDs button click event.
        /// Generates random values to set the state of the LEDs and sends the data to the serial port.
        /// </summary>
        /// <param name="sender">The object that raises the event.</param>
        /// <param name="e">The event data.</param>
        private void RandomLedsButtonOnClick(object sender, EventArgs e)
        {
            if (!SerialPort.IsOpen)
            {
                MessageBox.Show("Please make sure your board is configured correctly, and connected to this device and try again.", "Could not connect to Arduino!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            ledOneCheckBox.Checked = Convert.ToBoolean(random.Next(2));
            ledTwoCheckBox.Checked = Convert.ToBoolean(random.Next(2));
            ledThreeCheckBox.Checked = Convert.ToBoolean(random.Next(2));
            ledFourCheckBox.Checked = Convert.ToBoolean(random.Next(2));
            ledFiveCheckBox.Checked = Convert.ToBoolean(random.Next(2));
            ledSixCheckBox.Checked = Convert.ToBoolean(random.Next(2));

            SerialPort.Write(LedMessage);
        }
    }
}
