namespace OCAssignment5
{
    partial class LuckyNumbers
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
            this.comboBox1_birthYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2_birthMonth = new System.Windows.Forms.ComboBox();
            this.comboBox3_birthday = new System.Windows.Forms.ComboBox();
            this.comboBox4_color = new System.Windows.Forms.ComboBox();
            this.btn1_getNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1_birthYear
            // 
            this.comboBox1_birthYear.FormattingEnabled = true;
            this.comboBox1_birthYear.Location = new System.Drawing.Point(369, 125);
            this.comboBox1_birthYear.Name = "comboBox1_birthYear";
            this.comboBox1_birthYear.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_birthYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your birth year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your birth month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter your birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter your favorite color";
            // 
            // comboBox2_birthMonth
            // 
            this.comboBox2_birthMonth.FormattingEnabled = true;
            this.comboBox2_birthMonth.Location = new System.Drawing.Point(369, 170);
            this.comboBox2_birthMonth.Name = "comboBox2_birthMonth";
            this.comboBox2_birthMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_birthMonth.TabIndex = 5;
            this.comboBox2_birthMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox2_birthMonth_SelectedIndexChanged);
            // 
            // comboBox3_birthday
            // 
            this.comboBox3_birthday.FormattingEnabled = true;
            this.comboBox3_birthday.Location = new System.Drawing.Point(369, 215);
            this.comboBox3_birthday.Name = "comboBox3_birthday";
            this.comboBox3_birthday.Size = new System.Drawing.Size(121, 24);
            this.comboBox3_birthday.TabIndex = 6;
            // 
            // comboBox4_color
            // 
            this.comboBox4_color.FormattingEnabled = true;
            this.comboBox4_color.Location = new System.Drawing.Point(369, 260);
            this.comboBox4_color.Name = "comboBox4_color";
            this.comboBox4_color.Size = new System.Drawing.Size(121, 24);
            this.comboBox4_color.TabIndex = 7;
            // 
            // btn1_getNumber
            // 
            this.btn1_getNumber.Location = new System.Drawing.Point(284, 303);
            this.btn1_getNumber.Name = "btn1_getNumber";
            this.btn1_getNumber.Size = new System.Drawing.Size(141, 45);
            this.btn1_getNumber.TabIndex = 8;
            this.btn1_getNumber.Text = "Get Your Lucky Number!";
            this.btn1_getNumber.UseVisualStyleBackColor = true;
            this.btn1_getNumber.Click += new System.EventHandler(this.btn1_getNumber_Click);
            // 
            // LuckyNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1_getNumber);
            this.Controls.Add(this.comboBox4_color);
            this.Controls.Add(this.comboBox3_birthday);
            this.Controls.Add(this.comboBox2_birthMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_birthYear);
            this.Name = "LuckyNumbers";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2_birthMonth;
        private System.Windows.Forms.ComboBox comboBox3_birthday;
        private System.Windows.Forms.Button btn1_getNumber;
        public System.Windows.Forms.ComboBox comboBox1_birthYear;
        public System.Windows.Forms.ComboBox comboBox4_color;
    }
}

