namespace LavoroFinaleM155
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }
    }
}
