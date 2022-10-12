namespace DrawCsvToLine
{
    partial class MainFrom
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
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.btn_hideLine = new System.Windows.Forms.Button();
            this.cb_line1 = new System.Windows.Forms.CheckBox();
            this.cb_line2 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1460, 549);
            this.cartesianChart1.TabIndex = 0;
            // 
            // btn_hideLine
            // 
            this.btn_hideLine.Location = new System.Drawing.Point(1322, 597);
            this.btn_hideLine.Name = "btn_hideLine";
            this.btn_hideLine.Size = new System.Drawing.Size(100, 30);
            this.btn_hideLine.TabIndex = 1;
            this.btn_hideLine.Text = "button";
            this.btn_hideLine.UseVisualStyleBackColor = true;
            this.btn_hideLine.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_line1
            // 
            this.cb_line1.AutoSize = true;
            this.cb_line1.Font = new System.Drawing.Font("宋体", 13F);
            this.cb_line1.Location = new System.Drawing.Point(580, 597);
            this.cb_line1.Name = "cb_line1";
            this.cb_line1.Size = new System.Drawing.Size(108, 22);
            this.cb_line1.TabIndex = 2;
            this.cb_line1.Text = "checkBox1";
            this.cb_line1.UseVisualStyleBackColor = true;
            this.cb_line1.CheckedChanged += new System.EventHandler(this.cb_line1_CheckedChanged);
            // 
            // cb_line2
            // 
            this.cb_line2.AutoSize = true;
            this.cb_line2.Font = new System.Drawing.Font("宋体", 13F);
            this.cb_line2.Location = new System.Drawing.Point(733, 597);
            this.cb_line2.Name = "cb_line2";
            this.cb_line2.Size = new System.Drawing.Size(108, 22);
            this.cb_line2.TabIndex = 3;
            this.cb_line2.Text = "checkBox2";
            this.cb_line2.UseVisualStyleBackColor = true;
            this.cb_line2.CheckedChanged += new System.EventHandler(this.cb_line2_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 642);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 303);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cb_line2);
            this.Controls.Add(this.cb_line1);
            this.Controls.Add(this.btn_hideLine);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btn_hideLine;
        private System.Windows.Forms.CheckBox cb_line1;
        private System.Windows.Forms.CheckBox cb_line2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

