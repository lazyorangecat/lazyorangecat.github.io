namespace Hw_03_05
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
            this.combox_from = new System.Windows.Forms.ComboBox();
            this.combox_to = new System.Windows.Forms.ComboBox();
            this.radioBtn_S2N = new System.Windows.Forms.RadioButton();
            this.radioBtn_N2S = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckBox_2Direction = new System.Windows.Forms.CheckBox();
            this.ckBox_discount = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combox_from
            // 
            this.combox_from.FormattingEnabled = true;
            this.combox_from.Location = new System.Drawing.Point(31, 108);
            this.combox_from.Name = "combox_from";
            this.combox_from.Size = new System.Drawing.Size(121, 20);
            this.combox_from.TabIndex = 0;
            this.combox_from.SelectedIndexChanged += new System.EventHandler(this.comboBox_from_SelectedIndexChanged);
            // 
            // combox_to
            // 
            this.combox_to.FormattingEnabled = true;
            this.combox_to.Location = new System.Drawing.Point(183, 108);
            this.combox_to.Name = "combox_to";
            this.combox_to.Size = new System.Drawing.Size(121, 20);
            this.combox_to.TabIndex = 1;
            // 
            // radioBtn_S2N
            // 
            this.radioBtn_S2N.AutoSize = true;
            this.radioBtn_S2N.Location = new System.Drawing.Point(31, 52);
            this.radioBtn_S2N.Name = "radioBtn_S2N";
            this.radioBtn_S2N.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_S2N.TabIndex = 2;
            this.radioBtn_S2N.TabStop = true;
            this.radioBtn_S2N.Text = "北上";
            this.radioBtn_S2N.UseVisualStyleBackColor = true;
            // 
            // radioBtn_N2S
            // 
            this.radioBtn_N2S.AutoSize = true;
            this.radioBtn_N2S.Location = new System.Drawing.Point(31, 30);
            this.radioBtn_N2S.Name = "radioBtn_N2S";
            this.radioBtn_N2S.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_N2S.TabIndex = 3;
            this.radioBtn_N2S.TabStop = true;
            this.radioBtn_N2S.Text = "南下";
            this.radioBtn_N2S.UseVisualStyleBackColor = true;
            this.radioBtn_N2S.CheckedChanged += new System.EventHandler(this.radioBtn_N2S_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "起站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "迄站";
            // 
            // ckBox_2Direction
            // 
            this.ckBox_2Direction.AutoSize = true;
            this.ckBox_2Direction.Location = new System.Drawing.Point(31, 147);
            this.ckBox_2Direction.Name = "ckBox_2Direction";
            this.ckBox_2Direction.Size = new System.Drawing.Size(60, 16);
            this.ckBox_2Direction.TabIndex = 7;
            this.ckBox_2Direction.Text = "來回票";
            this.ckBox_2Direction.UseVisualStyleBackColor = true;
            // 
            // ckBox_discount
            // 
            this.ckBox_discount.AutoSize = true;
            this.ckBox_discount.Location = new System.Drawing.Point(31, 169);
            this.ckBox_discount.Name = "ckBox_discount";
            this.ckBox_discount.Size = new System.Drawing.Size(60, 16);
            this.ckBox_discount.TabIndex = 8;
            this.ckBox_discount.Text = "優惠票";
            this.ckBox_discount.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "票價為:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(254, 196);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(23, 12);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "0元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckBox_discount);
            this.Controls.Add(this.ckBox_2Direction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioBtn_N2S);
            this.Controls.Add(this.radioBtn_S2N);
            this.Controls.Add(this.combox_to);
            this.Controls.Add(this.combox_from);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_from;
        private System.Windows.Forms.ComboBox combox_to;
        private System.Windows.Forms.RadioButton radioBtn_S2N;
        private System.Windows.Forms.RadioButton radioBtn_N2S;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckBox_2Direction;
        private System.Windows.Forms.CheckBox ckBox_discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_price;
    }
}

