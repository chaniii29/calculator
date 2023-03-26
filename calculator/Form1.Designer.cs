namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_dividedby = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_times = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_zero);
            this.groupBox1.Controls.Add(this.btn_equals);
            this.groupBox1.Controls.Add(this.btn_dividedby);
            this.groupBox1.Controls.Add(this.btn_seven);
            this.groupBox1.Controls.Add(this.btn_eight);
            this.groupBox1.Controls.Add(this.btn_nine);
            this.groupBox1.Controls.Add(this.btn_times);
            this.groupBox1.Controls.Add(this.btn_four);
            this.groupBox1.Controls.Add(this.btn_five);
            this.groupBox1.Controls.Add(this.btn_six);
            this.groupBox1.Controls.Add(this.btn_minus);
            this.groupBox1.Controls.Add(this.btn_three);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_two);
            this.groupBox1.Controls.Add(this.btn_one);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(195, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 465);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(111, 372);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 81);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(22, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 34);
            this.textBox1.TabIndex = 23;
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(22, 372);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(83, 81);
            this.btn_zero.TabIndex = 21;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(200, 372);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(83, 81);
            this.btn_equals.TabIndex = 19;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_dividedby
            // 
            this.btn_dividedby.Location = new System.Drawing.Point(289, 372);
            this.btn_dividedby.Name = "btn_dividedby";
            this.btn_dividedby.Size = new System.Drawing.Size(83, 81);
            this.btn_dividedby.TabIndex = 18;
            this.btn_dividedby.Text = "/";
            this.btn_dividedby.UseVisualStyleBackColor = true;
            this.btn_dividedby.Click += new System.EventHandler(this.btn_dividedby_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Location = new System.Drawing.Point(22, 285);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(83, 81);
            this.btn_seven.TabIndex = 17;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Location = new System.Drawing.Point(111, 285);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(83, 81);
            this.btn_eight.TabIndex = 16;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(200, 285);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(83, 81);
            this.btn_nine.TabIndex = 15;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_times
            // 
            this.btn_times.Location = new System.Drawing.Point(289, 285);
            this.btn_times.Name = "btn_times";
            this.btn_times.Size = new System.Drawing.Size(83, 81);
            this.btn_times.TabIndex = 14;
            this.btn_times.Text = "*";
            this.btn_times.UseVisualStyleBackColor = true;
            this.btn_times.Click += new System.EventHandler(this.btn_times_Click);
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(22, 198);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(83, 81);
            this.btn_four.TabIndex = 13;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_five
            // 
            this.btn_five.Location = new System.Drawing.Point(111, 198);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(83, 81);
            this.btn_five.TabIndex = 12;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_six
            // 
            this.btn_six.Location = new System.Drawing.Point(200, 198);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(83, 81);
            this.btn_six.TabIndex = 11;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(289, 198);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(83, 81);
            this.btn_minus.TabIndex = 10;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(200, 111);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(83, 81);
            this.btn_three.TabIndex = 9;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(289, 111);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 81);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(111, 111);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(83, 81);
            this.btn_two.TabIndex = 4;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(22, 111);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(83, 81);
            this.btn_one.TabIndex = 0;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 563);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_dividedby;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_times;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
    }
}

