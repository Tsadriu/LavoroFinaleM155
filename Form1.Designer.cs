namespace LavoroFinaleM155
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            ledLabel = new Label();
            ledComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            sendCommandButton = new Button();
            button3 = new Button();
            label3 = new Label();
            ledValueLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            ledTrackBar = new TrackBar();
            ledStateCheckBox = new CheckBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            applyBoardConfigButton = new Button();
            baudNumericUpDown = new NumericUpDown();
            label5 = new Label();
            portBox = new TextBox();
            label4 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ledTrackBar).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)baudNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ledLabel);
            groupBox1.Controls.Add(ledComboBox);
            groupBox1.Location = new Point(11, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Led selection";
            // 
            // ledLabel
            // 
            ledLabel.AutoSize = true;
            ledLabel.Location = new Point(6, 25);
            ledLabel.Name = "ledLabel";
            ledLabel.Size = new Size(30, 15);
            ledLabel.TabIndex = 1;
            ledLabel.Text = "LED:";
            // 
            // ledComboBox
            // 
            ledComboBox.FormattingEnabled = true;
            ledComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            ledComboBox.Location = new Point(42, 22);
            ledComboBox.Name = "ledComboBox";
            ledComboBox.Size = new Size(183, 23);
            ledComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(sendCommandButton);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(ledValueLabel);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ledTrackBar);
            groupBox2.Controls.Add(ledStateCheckBox);
            groupBox2.Location = new Point(12, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Led properties";
            // 
            // sendCommandButton
            // 
            sendCommandButton.Location = new Point(141, 145);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(111, 23);
            sendCommandButton.TabIndex = 3;
            sendCommandButton.Text = "Send command";
            sendCommandButton.UseVisualStyleBackColor = true;
            sendCommandButton.Click += SendCommandButtonOnClick;
            // 
            // button3
            // 
            button3.Location = new Point(6, 145);
            button3.Name = "button3";
            button3.Size = new Size(111, 23);
            button3.TabIndex = 4;
            button3.Text = "Reset selected led";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Led intensity";
            // 
            // ledValueLabel
            // 
            ledValueLabel.AutoSize = true;
            ledValueLabel.Location = new Point(109, 110);
            ledValueLabel.Name = "ledValueLabel";
            ledValueLabel.Size = new Size(35, 15);
            ledValueLabel.TabIndex = 4;
            ledValueLabel.Text = "100%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 80);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "255";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 2;
            label1.Text = "0";
            // 
            // ledTrackBar
            // 
            ledTrackBar.Location = new Point(17, 80);
            ledTrackBar.Maximum = 255;
            ledTrackBar.Name = "ledTrackBar";
            ledTrackBar.Size = new Size(208, 45);
            ledTrackBar.TabIndex = 1;
            ledTrackBar.Value = 255;
            ledTrackBar.Scroll += LedTrackBarOnChanged;
            // 
            // ledStateCheckBox
            // 
            ledStateCheckBox.AutoSize = true;
            ledStateCheckBox.Location = new Point(6, 22);
            ledStateCheckBox.Name = "ledStateCheckBox";
            ledStateCheckBox.Size = new Size(70, 19);
            ledStateCheckBox.TabIndex = 0;
            ledStateCheckBox.Text = "ON/OFF";
            ledStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 2;
            button1.Text = "Reset all leds";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(11, 426);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 61);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "General";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(applyBoardConfigButton);
            groupBox4.Controls.Add(baudNumericUpDown);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(portBox);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(12, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(260, 145);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Board configuration";
            // 
            // applyBoardConfigButton
            // 
            applyBoardConfigButton.Location = new Point(6, 107);
            applyBoardConfigButton.Name = "applyBoardConfigButton";
            applyBoardConfigButton.Size = new Size(125, 23);
            applyBoardConfigButton.TabIndex = 4;
            applyBoardConfigButton.Text = "Apply board config";
            applyBoardConfigButton.UseVisualStyleBackColor = true;
            applyBoardConfigButton.Click += ApplyBoardConfigButtonOnClick;
            // 
            // baudNumericUpDown
            // 
            baudNumericUpDown.InterceptArrowKeys = false;
            baudNumericUpDown.Location = new Point(42, 69);
            baudNumericUpDown.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            baudNumericUpDown.Name = "baudNumericUpDown";
            baudNumericUpDown.Size = new Size(183, 23);
            baudNumericUpDown.TabIndex = 3;
            baudNumericUpDown.Value = new decimal(new int[] { 9600, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 72);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 2;
            label5.Text = "Baud:";
            // 
            // portBox
            // 
            portBox.Location = new Point(42, 22);
            portBox.Name = "portBox";
            portBox.PlaceholderText = "COM3";
            portBox.Size = new Size(183, 23);
            portBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 0;
            label4.Text = "Port:";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 503);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Verifica Finale M155 - Fabio Oliveira de Sousa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ledTrackBar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)baudNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox ledComboBox;
        private Label ledLabel;
        private GroupBox groupBox2;
        private CheckBox ledStateCheckBox;
        private TrackBar ledTrackBar;
        private Label label1;
        private Label ledValueLabel;
        private Label label2;
        private Label label3;
        private Button sendCommandButton;
        private Button button3;
        private Button button1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private NumericUpDown baudNumericUpDown;
        private Label label5;
        private TextBox portBox;
        private Label label4;
        private Button applyBoardConfigButton;
        private NotifyIcon notifyIcon1;
    }
}
