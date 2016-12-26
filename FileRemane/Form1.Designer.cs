namespace FileRemane
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.lab_status = new System.Windows.Forms.Label();
            this.txt_start_number = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "選取位置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(43, 106);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(439, 36);
            this.txtPath.TabIndex = 3;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(43, 292);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(439, 230);
            this.txtFile.TabIndex = 4;
            this.txtFile.Text = "";
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(43, 558);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(65, 24);
            this.lab_status.TabIndex = 5;
            this.lab_status.Text = "Status";
            // 
            // txt_start_number
            // 
            this.txt_start_number.Location = new System.Drawing.Point(43, 232);
            this.txt_start_number.Name = "txt_start_number";
            this.txt_start_number.Size = new System.Drawing.Size(439, 36);
            this.txt_start_number.TabIndex = 6;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(519, 230);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(159, 35);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(43, 173);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(439, 36);
            this.txtOutput.TabIndex = 8;
            this.txtOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(519, 173);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(159, 35);
            this.btnOutput.TabIndex = 9;
            this.btnOutput.Text = "輸出位置";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 594);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_start_number);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.TextBox txt_start_number;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
    }
}

