namespace ShellBrute7kb
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.radioButtonAsp = new System.Windows.Forms.RadioButton();
            this.radioButtonPhp = new System.Windows.Forms.RadioButton();
            this.radioButtonAspx = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxfenzuCount = new System.Windows.Forms.TextBox();
            this.labelfenzucount = new System.Windows.Forms.Label();
            this.textBoxTimeOut = new System.Windows.Forms.TextBox();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(470, 10);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(56, 21);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "开始";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(9, 10);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(396, 21);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Text = "http://baidu.com";
            // 
            // radioButtonAsp
            // 
            this.radioButtonAsp.AutoSize = true;
            this.radioButtonAsp.Checked = true;
            this.radioButtonAsp.Location = new System.Drawing.Point(90, 17);
            this.radioButtonAsp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAsp.Name = "radioButtonAsp";
            this.radioButtonAsp.Size = new System.Drawing.Size(41, 16);
            this.radioButtonAsp.TabIndex = 2;
            this.radioButtonAsp.TabStop = true;
            this.radioButtonAsp.Text = "Asp";
            this.radioButtonAsp.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhp
            // 
            this.radioButtonPhp.AutoSize = true;
            this.radioButtonPhp.Location = new System.Drawing.Point(143, 17);
            this.radioButtonPhp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonPhp.Name = "radioButtonPhp";
            this.radioButtonPhp.Size = new System.Drawing.Size(41, 16);
            this.radioButtonPhp.TabIndex = 3;
            this.radioButtonPhp.Text = "PHP";
            this.radioButtonPhp.UseVisualStyleBackColor = true;
            // 
            // radioButtonAspx
            // 
            this.radioButtonAspx.AutoSize = true;
            this.radioButtonAspx.Location = new System.Drawing.Point(199, 17);
            this.radioButtonAspx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAspx.Name = "radioButtonAspx";
            this.radioButtonAspx.Size = new System.Drawing.Size(47, 16);
            this.radioButtonAspx.TabIndex = 4;
            this.radioButtonAspx.Text = "Aspx";
            this.radioButtonAspx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxfenzuCount);
            this.groupBox1.Controls.Add(this.labelfenzucount);
            this.groupBox1.Controls.Add(this.textBoxTimeOut);
            this.groupBox1.Controls.Add(this.labelTimeOut);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Controls.Add(this.radioButtonAspx);
            this.groupBox1.Controls.Add(this.radioButtonAsp);
            this.groupBox1.Controls.Add(this.radioButtonPhp);
            this.groupBox1.Location = new System.Drawing.Point(9, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(517, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // textBoxfenzuCount
            // 
            this.textBoxfenzuCount.Location = new System.Drawing.Point(344, 16);
            this.textBoxfenzuCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxfenzuCount.Name = "textBoxfenzuCount";
            this.textBoxfenzuCount.Size = new System.Drawing.Size(53, 21);
            this.textBoxfenzuCount.TabIndex = 11;
            this.textBoxfenzuCount.Text = "1000";
            this.textBoxfenzuCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelfenzucount
            // 
            this.labelfenzucount.AutoSize = true;
            this.labelfenzucount.Location = new System.Drawing.Point(283, 18);
            this.labelfenzucount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfenzucount.Name = "labelfenzucount";
            this.labelfenzucount.Size = new System.Drawing.Size(59, 12);
            this.labelfenzucount.TabIndex = 10;
            this.labelfenzucount.Text = "分组个数:";
            // 
            // textBoxTimeOut
            // 
            this.textBoxTimeOut.Location = new System.Drawing.Point(465, 16);
            this.textBoxTimeOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTimeOut.Name = "textBoxTimeOut";
            this.textBoxTimeOut.Size = new System.Drawing.Size(42, 21);
            this.textBoxTimeOut.TabIndex = 8;
            this.textBoxTimeOut.Text = "8000";
            this.textBoxTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.AutoSize = true;
            this.labelTimeOut.Location = new System.Drawing.Point(401, 18);
            this.labelTimeOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(59, 12);
            this.labelTimeOut.TabIndex = 9;
            this.labelTimeOut.Text = "Time-Out:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(17, 18);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(59, 12);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "脚本类型:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(409, 10);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 21);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(9, 82);
            this.textBoxRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(518, 321);
            this.textBoxRes.TabIndex = 7;
            this.textBoxRes.Text = "一句话爆破";
            this.textBoxRes.TextChanged += new System.EventHandler(this.textBoxRes_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 411);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonGo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CXAQHQ         一句话爆破";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.RadioButton radioButtonAsp;
        private System.Windows.Forms.RadioButton radioButtonPhp;
        private System.Windows.Forms.RadioButton radioButtonAspx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxTimeOut;
        private System.Windows.Forms.Label labelTimeOut;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.TextBox textBoxfenzuCount;
        private System.Windows.Forms.Label labelfenzucount;
    }
}

