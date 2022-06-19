namespace WolfSheepVeg
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
            this.listBox_L = new System.Windows.Forms.ListBox();
            this.listBox_R = new System.Windows.Forms.ListBox();
            this.btn_Across = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_L
            // 
            this.listBox_L.FormattingEnabled = true;
            this.listBox_L.ItemHeight = 12;
            this.listBox_L.Location = new System.Drawing.Point(12, 12);
            this.listBox_L.Name = "listBox_L";
            this.listBox_L.Size = new System.Drawing.Size(120, 256);
            this.listBox_L.TabIndex = 0;
            // 
            // listBox_R
            // 
            this.listBox_R.FormattingEnabled = true;
            this.listBox_R.ItemHeight = 12;
            this.listBox_R.Location = new System.Drawing.Point(187, 12);
            this.listBox_R.Name = "listBox_R";
            this.listBox_R.Size = new System.Drawing.Size(120, 256);
            this.listBox_R.TabIndex = 1;
            // 
            // btn_Across
            // 
            this.btn_Across.Font = new System.Drawing.Font("新細明體", 10F);
            this.btn_Across.Location = new System.Drawing.Point(138, 127);
            this.btn_Across.Name = "btn_Across";
            this.btn_Across.Size = new System.Drawing.Size(43, 41);
            this.btn_Across.TabIndex = 3;
            this.btn_Across.Text = "<--->";
            this.btn_Across.UseVisualStyleBackColor = true;
            this.btn_Across.Click += new System.EventHandler(this.btn_Across_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("新細明體", 10F);
            this.btn_Reset.Location = new System.Drawing.Point(237, 274);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(70, 41);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 327);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Across);
            this.Controls.Add(this.listBox_R);
            this.Controls.Add(this.listBox_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_L;
        private System.Windows.Forms.ListBox listBox_R;
        private System.Windows.Forms.Button btn_Across;
        private System.Windows.Forms.Button btn_Reset;
    }
}

