namespace _013_计算器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJiSuan = new System.Windows.Forms.Button();
            this.cboCaoZuoFu = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJiSuan
            // 
            this.btnJiSuan.Location = new System.Drawing.Point(562, 53);
            this.btnJiSuan.Name = "btnJiSuan";
            this.btnJiSuan.Size = new System.Drawing.Size(75, 23);
            this.btnJiSuan.TabIndex = 0;
            this.btnJiSuan.Text = "=";
            this.btnJiSuan.UseVisualStyleBackColor = true;
            this.btnJiSuan.Click += new System.EventHandler(this.btnJiSuan_Click);
            // 
            // cboCaoZuoFu
            // 
            this.cboCaoZuoFu.FormattingEnabled = true;
            this.cboCaoZuoFu.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboCaoZuoFu.Location = new System.Drawing.Point(208, 56);
            this.cboCaoZuoFu.Name = "cboCaoZuoFu";
            this.cboCaoZuoFu.Size = new System.Drawing.Size(121, 23);
            this.cboCaoZuoFu.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(687, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 15);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(39, 54);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 25);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(401, 54);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 25);
            this.txtNum2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 141);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cboCaoZuoFu);
            this.Controls.Add(this.btnJiSuan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJiSuan;
        private System.Windows.Forms.ComboBox cboCaoZuoFu;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

