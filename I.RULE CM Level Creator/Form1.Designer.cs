namespace I.RULE_CM_Level_Creator
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
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.levelNameTextBox = new System.Windows.Forms.TextBox();
            this.levelDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.levelHeartFallSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.levelHeartValueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.levelStartingHeartsTextBox = new System.Windows.Forms.TextBox();
            this.levelHeartsCapTextBox = new System.Windows.Forms.TextBox();
            this.levelWaveAmountTextBox = new System.Windows.Forms.TextBox();
            this.levelHeartTimerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level\'s name:";
            // 
            // levelNameTextBox
            // 
            this.levelNameTextBox.Location = new System.Drawing.Point(170, 28);
            this.levelNameTextBox.Name = "levelNameTextBox";
            this.levelNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelNameTextBox.TabIndex = 0;
            // 
            // levelDescriptionTextBox
            // 
            this.levelDescriptionTextBox.Location = new System.Drawing.Point(170, 62);
            this.levelDescriptionTextBox.Name = "levelDescriptionTextBox";
            this.levelDescriptionTextBox.Size = new System.Drawing.Size(220, 27);
            this.levelDescriptionTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level\'s description:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change level name color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Change level description color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save level";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hearts falling speed: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hearts value: ";
            // 
            // levelHeartFallSpeedTextBox
            // 
            this.levelHeartFallSpeedTextBox.Location = new System.Drawing.Point(171, 95);
            this.levelHeartFallSpeedTextBox.Name = "levelHeartFallSpeedTextBox";
            this.levelHeartFallSpeedTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelHeartFallSpeedTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Starting hearts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hearts\' disappering timer starts on: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hearts limit:";
            // 
            // levelHeartValueTextBox
            // 
            this.levelHeartValueTextBox.Location = new System.Drawing.Point(170, 137);
            this.levelHeartValueTextBox.Name = "levelHeartValueTextBox";
            this.levelHeartValueTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelHeartValueTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Max numer of vawes: ";
            // 
            // levelStartingHeartsTextBox
            // 
            this.levelStartingHeartsTextBox.Location = new System.Drawing.Point(185, 223);
            this.levelStartingHeartsTextBox.Name = "levelStartingHeartsTextBox";
            this.levelStartingHeartsTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelStartingHeartsTextBox.TabIndex = 2;
            // 
            // levelHeartsCapTextBox
            // 
            this.levelHeartsCapTextBox.Location = new System.Drawing.Point(185, 262);
            this.levelHeartsCapTextBox.Name = "levelHeartsCapTextBox";
            this.levelHeartsCapTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelHeartsCapTextBox.TabIndex = 2;
            // 
            // levelWaveAmountTextBox
            // 
            this.levelWaveAmountTextBox.Location = new System.Drawing.Point(185, 297);
            this.levelWaveAmountTextBox.Name = "levelWaveAmountTextBox";
            this.levelWaveAmountTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelWaveAmountTextBox.TabIndex = 2;
            // 
            // levelHeartTimerTextBox
            // 
            this.levelHeartTimerTextBox.Location = new System.Drawing.Point(277, 177);
            this.levelHeartTimerTextBox.Name = "levelHeartTimerTextBox";
            this.levelHeartTimerTextBox.Size = new System.Drawing.Size(125, 27);
            this.levelHeartTimerTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.levelHeartTimerTextBox);
            this.groupBox1.Controls.Add(this.levelWaveAmountTextBox);
            this.groupBox1.Controls.Add(this.levelHeartsCapTextBox);
            this.groupBox1.Controls.Add(this.levelStartingHeartsTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.levelHeartValueTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.levelHeartFallSpeedTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.levelDescriptionTextBox);
            this.groupBox1.Controls.Add(this.levelNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 770);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "I.RULE Campaingn Mod Level Creator by Adamo2499";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private SaveFileDialog saveFileDialog1;
        private TextBox levelNameTextBox;
        private TextBox levelDescriptionTextBox;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox levelHeartFallSpeedTextBox;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox levelHeartValueTextBox;
        private Label label8;
        private TextBox levelStartingHeartsTextBox;
        private TextBox levelHeartsCapTextBox;
        private TextBox levelWaveAmountTextBox;
        private TextBox levelHeartTimerTextBox;
        private GroupBox groupBox1;
    }
}