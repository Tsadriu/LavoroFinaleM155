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
            groupBox1 = new GroupBox();
            ledLabel = new Label();
            ledComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            ledValueLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            ledTrackBar = new TrackBar();
            ledStateCheckBox = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ledTrackBar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ledLabel);
            groupBox1.Controls.Add(ledComboBox);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 58);
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
            ledComboBox.Size = new Size(121, 23);
            ledComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ledValueLabel);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ledTrackBar);
            groupBox2.Controls.Add(ledStateCheckBox);
            groupBox2.Location = new Point(12, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Led properties";
            // 
            // ledValueLabel
            // 
            ledValueLabel.AutoSize = true;
            ledValueLabel.Location = new Point(111, 92);
            ledValueLabel.Name = "ledValueLabel";
            ledValueLabel.Size = new Size(35, 15);
            ledValueLabel.TabIndex = 4;
            ledValueLabel.Text = "100%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 71);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "255";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 71);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 2;
            label1.Text = "0";
            // 
            // ledTrackBar
            // 
            ledTrackBar.Location = new Point(19, 62);
            ledTrackBar.Maximum = 255;
            ledTrackBar.Name = "ledTrackBar";
            ledTrackBar.Size = new Size(208, 45);
            ledTrackBar.TabIndex = 1;
            ledTrackBar.Value = 255;
            ledTrackBar.Scroll += trackBar1_Scroll;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Verifica Finale M155 - Fabio Oliveira de Sousa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ledTrackBar).EndInit();
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
    }
}
