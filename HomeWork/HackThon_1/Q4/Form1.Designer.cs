namespace Q4
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
            this.watchAns = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // watchAns
            // 
            this.watchAns.Location = new System.Drawing.Point(12, 26);
            this.watchAns.Name = "watchAns";
            this.watchAns.Size = new System.Drawing.Size(78, 43);
            this.watchAns.TabIndex = 1;
            this.watchAns.Text = "看答案";
            this.watchAns.UseVisualStyleBackColor = true;
            this.watchAns.Click += new System.EventHandler(this.watchAns_Click);
            // 
            // textBox1
            // 
            this.txt_Input.Location = new System.Drawing.Point(20, 247);
            this.txt_Input.Name = "textBox1";
            this.txt_Input.Size = new System.Drawing.Size(97, 22);
            this.txt_Input.TabIndex = 2;
            // 
            // checkAns
            // 
            this.btn_Guess.Location = new System.Drawing.Point(20, 286);
            this.btn_Guess.Name = "checkAns";
            this.btn_Guess.Size = new System.Drawing.Size(78, 32);
            this.btn_Guess.TabIndex = 3;
            this.btn_Guess.Text = "檢查答案";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(104, 286);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(78, 32);
            this.btn_Restart.TabIndex = 4;
            this.btn_Restart.Text = "放棄重來";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // textBox2
            // 
            this.txt_Output.Location = new System.Drawing.Point(204, 39);
            this.txt_Output.Multiline = true;
            this.txt_Output.Name = "textBox2";
            this.txt_Output.Size = new System.Drawing.Size(209, 279);
            this.txt_Output.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 364);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.watchAns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button watchAns;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox txt_Output;
    }
}

