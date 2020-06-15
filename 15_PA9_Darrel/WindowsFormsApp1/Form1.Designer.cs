namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_converted = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rb_us = new System.Windows.Forms.RadioButton();
            this.rb_yen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select currency";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Converted amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(202, 54);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(227, 20);
            this.txt_amount.TabIndex = 3;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // txt_converted
            // 
            this.txt_converted.Location = new System.Drawing.Point(202, 227);
            this.txt_converted.Name = "txt_converted";
            this.txt_converted.Size = new System.Drawing.Size(227, 20);
            this.txt_converted.TabIndex = 4;
            this.txt_converted.TextChanged += new System.EventHandler(this.txt_converted_TextChanged);
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(452, 224);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(452, 253);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rb_us
            // 
            this.rb_us.AutoSize = true;
            this.rb_us.Location = new System.Drawing.Point(202, 121);
            this.rb_us.Name = "rb_us";
            this.rb_us.Size = new System.Drawing.Size(75, 17);
            this.rb_us.TabIndex = 7;
            this.rb_us.TabStop = true;
            this.rb_us.Text = "US Dollars";
            this.rb_us.UseVisualStyleBackColor = true;
            this.rb_us.CheckedChanged += new System.EventHandler(this.rb_us_CheckedChanged);
            // 
            // rb_yen
            // 
            this.rb_yen.AutoSize = true;
            this.rb_yen.Location = new System.Drawing.Point(202, 144);
            this.rb_yen.Name = "rb_yen";
            this.rb_yen.Size = new System.Drawing.Size(93, 17);
            this.rb_yen.TabIndex = 8;
            this.rb_yen.TabStop = true;
            this.rb_yen.Text = "Japanese Yen";
            this.rb_yen.UseVisualStyleBackColor = true;
            this.rb_yen.CheckedChanged += new System.EventHandler(this.rb_yen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 315);
            this.Controls.Add(this.rb_yen);
            this.Controls.Add(this.rb_us);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_converted);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_converted;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rb_us;
        private System.Windows.Forms.RadioButton rb_yen;
    }
}

