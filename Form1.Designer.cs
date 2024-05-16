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
            ledSixCheckBox = new CheckBox();
            ledFiveCheckBox = new CheckBox();
            button1 = new Button();
            sendCommandButton = new Button();
            ledFourCheckBox = new CheckBox();
            ledTwoCheckBox = new CheckBox();
            ledThreeCheckBox = new CheckBox();
            ledOneCheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            disconnectButton = new Button();
            applyBoardConfigButton = new Button();
            baudNumericUpDown = new NumericUpDown();
            label5 = new Label();
            portBox = new TextBox();
            label4 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            randomLedsButton = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)baudNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(randomLedsButton);
            groupBox1.Controls.Add(ledSixCheckBox);
            groupBox1.Controls.Add(ledFiveCheckBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(sendCommandButton);
            groupBox1.Controls.Add(ledFourCheckBox);
            groupBox1.Controls.Add(ledTwoCheckBox);
            groupBox1.Controls.Add(ledThreeCheckBox);
            groupBox1.Controls.Add(ledOneCheckBox);
            groupBox1.Location = new Point(11, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Led selection";
            // 
            // ledSixCheckBox
            // 
            ledSixCheckBox.AutoSize = true;
            ledSixCheckBox.Location = new Point(143, 59);
            ledSixCheckBox.Name = "ledSixCheckBox";
            ledSixCheckBox.RightToLeft = RightToLeft.No;
            ledSixCheckBox.Size = new Size(32, 19);
            ledSixCheckBox.TabIndex = 8;
            ledSixCheckBox.Text = "6";
            ledSixCheckBox.UseVisualStyleBackColor = true;
            // 
            // ledFiveCheckBox
            // 
            ledFiveCheckBox.AutoSize = true;
            ledFiveCheckBox.Location = new Point(73, 59);
            ledFiveCheckBox.Name = "ledFiveCheckBox";
            ledFiveCheckBox.RightToLeft = RightToLeft.No;
            ledFiveCheckBox.Size = new Size(32, 19);
            ledFiveCheckBox.TabIndex = 7;
            ledFiveCheckBox.Text = "5";
            ledFiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 94);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 2;
            button1.Text = "Reset all leds";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ResetAllLedsOnClick;
            // 
            // sendCommandButton
            // 
            sendCommandButton.Location = new Point(134, 94);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(111, 23);
            sendCommandButton.TabIndex = 3;
            sendCommandButton.Text = "Send command";
            sendCommandButton.UseVisualStyleBackColor = true;
            sendCommandButton.Click += SendCommandButtonOnClick;
            // 
            // ledFourCheckBox
            // 
            ledFourCheckBox.AutoSize = true;
            ledFourCheckBox.Location = new Point(213, 22);
            ledFourCheckBox.Name = "ledFourCheckBox";
            ledFourCheckBox.Size = new Size(32, 19);
            ledFourCheckBox.TabIndex = 6;
            ledFourCheckBox.Text = "4";
            ledFourCheckBox.UseVisualStyleBackColor = true;
            // 
            // ledTwoCheckBox
            // 
            ledTwoCheckBox.AutoSize = true;
            ledTwoCheckBox.Location = new Point(73, 22);
            ledTwoCheckBox.Name = "ledTwoCheckBox";
            ledTwoCheckBox.Size = new Size(32, 19);
            ledTwoCheckBox.TabIndex = 5;
            ledTwoCheckBox.Text = "2";
            ledTwoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ledThreeCheckBox
            // 
            ledThreeCheckBox.AutoSize = true;
            ledThreeCheckBox.Location = new Point(143, 22);
            ledThreeCheckBox.Name = "ledThreeCheckBox";
            ledThreeCheckBox.Size = new Size(32, 19);
            ledThreeCheckBox.TabIndex = 3;
            ledThreeCheckBox.Text = "3";
            ledThreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ledOneCheckBox
            // 
            ledOneCheckBox.AutoSize = true;
            ledOneCheckBox.Location = new Point(6, 22);
            ledOneCheckBox.Name = "ledOneCheckBox";
            ledOneCheckBox.Size = new Size(32, 19);
            ledOneCheckBox.TabIndex = 2;
            ledOneCheckBox.Text = "1";
            ledOneCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(disconnectButton);
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
            // disconnectButton
            // 
            disconnectButton.Location = new Point(0, 107);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(125, 23);
            disconnectButton.TabIndex = 5;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += DisconnectButtonOnClick;
            // 
            // applyBoardConfigButton
            // 
            applyBoardConfigButton.Location = new Point(129, 107);
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
            // randomLedsButton
            // 
            randomLedsButton.Location = new Point(73, 132);
            randomLedsButton.Name = "randomLedsButton";
            randomLedsButton.Size = new Size(111, 23);
            randomLedsButton.TabIndex = 9;
            randomLedsButton.Text = "Random leds";
            randomLedsButton.UseVisualStyleBackColor = true;
            randomLedsButton.Click += RandomLedsButtonOnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 354);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Verifica Finale M155 - Fabio Oliveira de Sousa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)baudNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button sendCommandButton;
        private Button button1;
        private GroupBox groupBox4;
        private NumericUpDown baudNumericUpDown;
        private Label label5;
        private TextBox portBox;
        private Label label4;
        private Button applyBoardConfigButton;
        private NotifyIcon notifyIcon1;
        private CheckBox ledFourCheckBox;
        private CheckBox ledTwoCheckBox;
        private CheckBox ledThreeCheckBox;
        private CheckBox ledOneCheckBox;
        private Button disconnectButton;
        private CheckBox ledSixCheckBox;
        private CheckBox ledFiveCheckBox;
        private Button randomLedsButton;
    }
}
