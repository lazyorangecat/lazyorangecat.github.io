namespace Hw_03_02
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
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.lbl_name3 = new System.Windows.Forms.Label();
            this.lbl_name4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_price1 = new System.Windows.Forms.Label();
            this.lbl_price2 = new System.Windows.Forms.Label();
            this.lbl_price3 = new System.Windows.Forms.Label();
            this.lbl_price4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Location = new System.Drawing.Point(38, 37);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(41, 12);
            this.lbl_name1.TabIndex = 0;
            this.lbl_name1.Text = "高麗菜";
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Location = new System.Drawing.Point(38, 65);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(29, 12);
            this.lbl_name2.TabIndex = 1;
            this.lbl_name2.Text = "豆乾";
            // 
            // lbl_name3
            // 
            this.lbl_name3.AutoSize = true;
            this.lbl_name3.Location = new System.Drawing.Point(38, 101);
            this.lbl_name3.Name = "lbl_name3";
            this.lbl_name3.Size = new System.Drawing.Size(29, 12);
            this.lbl_name3.TabIndex = 2;
            this.lbl_name3.Text = "海帶";
            // 
            // lbl_name4
            // 
            this.lbl_name4.AutoSize = true;
            this.lbl_name4.Location = new System.Drawing.Point(38, 129);
            this.lbl_name4.Name = "lbl_name4";
            this.lbl_name4.Size = new System.Drawing.Size(29, 12);
            this.lbl_name4.TabIndex = 3;
            this.lbl_name4.Text = "肉片";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(38, 205);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 12);
            this.result.TabIndex = 8;
            this.result.Text = "應收:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(235, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(235, 63);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(235, 91);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(235, 119);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "結算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_price1
            // 
            this.lbl_price1.AutoSize = true;
            this.lbl_price1.Location = new System.Drawing.Point(125, 37);
            this.lbl_price1.Name = "lbl_price1";
            this.lbl_price1.Size = new System.Drawing.Size(17, 12);
            this.lbl_price1.TabIndex = 14;
            this.lbl_price1.Text = "30";
            // 
            // lbl_price2
            // 
            this.lbl_price2.AutoSize = true;
            this.lbl_price2.Location = new System.Drawing.Point(125, 65);
            this.lbl_price2.Name = "lbl_price2";
            this.lbl_price2.Size = new System.Drawing.Size(17, 12);
            this.lbl_price2.TabIndex = 15;
            this.lbl_price2.Text = "17";
            // 
            // lbl_price3
            // 
            this.lbl_price3.AutoSize = true;
            this.lbl_price3.Location = new System.Drawing.Point(125, 93);
            this.lbl_price3.Name = "lbl_price3";
            this.lbl_price3.Size = new System.Drawing.Size(17, 12);
            this.lbl_price3.TabIndex = 16;
            this.lbl_price3.Text = "15";
            // 
            // lbl_price4
            // 
            this.lbl_price4.AutoSize = true;
            this.lbl_price4.Location = new System.Drawing.Point(125, 121);
            this.lbl_price4.Name = "lbl_price4";
            this.lbl_price4.Size = new System.Drawing.Size(17, 12);
            this.lbl_price4.TabIndex = 17;
            this.lbl_price4.Text = "40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_price4);
            this.Controls.Add(this.lbl_price3);
            this.Controls.Add(this.lbl_price2);
            this.Controls.Add(this.lbl_price1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lbl_name4);
            this.Controls.Add(this.lbl_name3);
            this.Controls.Add(this.lbl_name2);
            this.Controls.Add(this.lbl_name1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.Label lbl_name3;
        private System.Windows.Forms.Label lbl_name4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_price1;
        private System.Windows.Forms.Label lbl_price2;
        private System.Windows.Forms.Label lbl_price3;
        private System.Windows.Forms.Label lbl_price4;
    }
}

