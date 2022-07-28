namespace RndSqr21
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ETextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Z0Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(23, 90);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 26);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Calculate";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DTextBox
            // 
            this.DTextBox.Location = new System.Drawing.Point(23, 12);
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.Size = new System.Drawing.Size(96, 20);
            this.DTextBox.TabIndex = 2;
            this.DTextBox.Text = "3";
            this.DTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxes_KeyPress);
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(23, 38);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(96, 20);
            this.HTextBox.TabIndex = 5;
            this.HTextBox.Text = "0,65";
            this.HTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxes_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "h";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "e";
            // 
            // ETextBox
            // 
            this.ETextBox.Location = new System.Drawing.Point(23, 64);
            this.ETextBox.Name = "ETextBox";
            this.ETextBox.Size = new System.Drawing.Size(96, 20);
            this.ETextBox.TabIndex = 9;
            this.ETextBox.Text = "1";
            this.ETextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxes_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "mm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 100;
            this.label15.Text = "mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "C";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(223, 16);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(0, 13);
            this.CLabel.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "L";
            // 
            // LLabel
            // 
            this.LLabel.AutoSize = true;
            this.LLabel.Location = new System.Drawing.Point(223, 41);
            this.LLabel.Name = "LLabel";
            this.LLabel.Size = new System.Drawing.Size(0, 13);
            this.LLabel.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Z0";
            // 
            // Z0Label
            // 
            this.Z0Label.AutoSize = true;
            this.Z0Label.Location = new System.Drawing.Point(223, 66);
            this.Z0Label.Name = "Z0Label";
            this.Z0Label.Size = new System.Drawing.Size(0, 13);
            this.Z0Label.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "em";
            // 
            // emLabel
            // 
            this.emLabel.AutoSize = true;
            this.emLabel.Location = new System.Drawing.Point(223, 91);
            this.emLabel.Name = "emLabel";
            this.emLabel.Size = new System.Drawing.Size(0, 13);
            this.emLabel.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "pF/m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "nH/m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Ohm";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(371, 129);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Z0Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ETextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HTextBox);
            this.Controls.Add(this.DTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sqr1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxes_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox DTextBox;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ETextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Z0Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label emLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

