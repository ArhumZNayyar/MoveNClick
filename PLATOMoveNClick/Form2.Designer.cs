namespace PLATOMoveNClick
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.warningLabel = new System.Windows.Forms.Label();
            this.delayValue2 = new System.Windows.Forms.NumericUpDown();
            this.delayValue = new System.Windows.Forms.NumericUpDown();
            this.StopButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.X2TxtBox = new System.Windows.Forms.TextBox();
            this.Y2TxtBox = new System.Windows.Forms.TextBox();
            this.XTxtBox = new System.Windows.Forms.TextBox();
            this.YTxtBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.delayValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).BeginInit();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Perpetua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(322, 199);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(267, 13);
            this.warningLabel.TabIndex = 33;
            this.warningLabel.Text = "CLICK START AFTER YOU FINISH CHANGING THE DELAY";
            this.warningLabel.Visible = false;
            // 
            // delayValue2
            // 
            this.delayValue2.Location = new System.Drawing.Point(474, 153);
            this.delayValue2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.delayValue2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.delayValue2.Name = "delayValue2";
            this.delayValue2.Size = new System.Drawing.Size(104, 20);
            this.delayValue2.TabIndex = 32;
            this.delayValue2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // delayValue
            // 
            this.delayValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayValue.Location = new System.Drawing.Point(338, 153);
            this.delayValue.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.delayValue.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(104, 20);
            this.delayValue.TabIndex = 31;
            this.delayValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // StopButton
            // 
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.ForeColor = System.Drawing.Color.DarkRed;
            this.StopButton.Location = new System.Drawing.Point(474, 238);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 30;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(588, 39);
            this.label7.TabIndex = 29;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Second Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Delay(Seconds)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "2nd Y Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Y Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "X Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "2nd X Position";
            // 
            // X2TxtBox
            // 
            this.X2TxtBox.Location = new System.Drawing.Point(93, 160);
            this.X2TxtBox.Name = "X2TxtBox";
            this.X2TxtBox.Size = new System.Drawing.Size(100, 20);
            this.X2TxtBox.TabIndex = 22;
            this.X2TxtBox.Text = "811";
            // 
            // Y2TxtBox
            // 
            this.Y2TxtBox.Location = new System.Drawing.Point(93, 194);
            this.Y2TxtBox.Name = "Y2TxtBox";
            this.Y2TxtBox.Size = new System.Drawing.Size(100, 20);
            this.Y2TxtBox.TabIndex = 21;
            this.Y2TxtBox.Text = "-214";
            // 
            // XTxtBox
            // 
            this.XTxtBox.Location = new System.Drawing.Point(93, 78);
            this.XTxtBox.Name = "XTxtBox";
            this.XTxtBox.Size = new System.Drawing.Size(100, 20);
            this.XTxtBox.TabIndex = 20;
            this.XTxtBox.Text = "665";
            // 
            // YTxtBox
            // 
            this.YTxtBox.Location = new System.Drawing.Point(93, 112);
            this.YTxtBox.Name = "YTxtBox";
            this.YTxtBox.Size = new System.Drawing.Size(100, 20);
            this.YTxtBox.TabIndex = 19;
            this.YTxtBox.Text = "-214";
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.StartButton.Location = new System.Drawing.Point(338, 238);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 18;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 39);
            this.label8.TabIndex = 34;
            this.label8.Text = "DEFAULT: 1800 seconds = 30 minutes.\r\n1 hour = 3600\r\n2 hours = 7200 (MAXIUIM)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 287);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.delayValue2);
            this.Controls.Add(this.delayValue);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X2TxtBox);
            this.Controls.Add(this.Y2TxtBox);
            this.Controls.Add(this.XTxtBox);
            this.Controls.Add(this.YTxtBox);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoveNClick ADVANCED MODE";
            ((System.ComponentModel.ISupportInitialize)(this.delayValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.NumericUpDown delayValue2;
        private System.Windows.Forms.NumericUpDown delayValue;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X2TxtBox;
        private System.Windows.Forms.TextBox Y2TxtBox;
        private System.Windows.Forms.TextBox XTxtBox;
        private System.Windows.Forms.TextBox YTxtBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}