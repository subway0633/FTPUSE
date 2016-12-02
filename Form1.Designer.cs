namespace FTPUse
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
            this.components = new System.ComponentModel.Container();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetAllLog = new System.Windows.Forms.Button();
            this.btnGetNowLog = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnUpdateFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.ContextMenuStrip = this.contextMenuStrip;
            this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtResult.Location = new System.Drawing.Point(12, 142);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1178, 448);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPatse});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 70);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(148, 22);
            this.tsmiCut.Text = "剪下 Crtl + X";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(148, 22);
            this.tsmiCopy.Text = "複製  Crtl + C";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPatse
            // 
            this.tsmiPatse.Name = "tsmiPatse";
            this.tsmiPatse.Size = new System.Drawing.Size(148, 22);
            this.tsmiPatse.Text = "貼上  Crtl + V";
            this.tsmiPatse.Click += new System.EventHandler(this.tsmiPatse_Click);
            // 
            // btnGetAllLog
            // 
            this.btnGetAllLog.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetAllLog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetAllLog.Location = new System.Drawing.Point(276, 12);
            this.btnGetAllLog.Name = "btnGetAllLog";
            this.btnGetAllLog.Size = new System.Drawing.Size(126, 55);
            this.btnGetAllLog.TabIndex = 1;
            this.btnGetAllLog.Text = "取得全部LOG";
            this.btnGetAllLog.UseVisualStyleBackColor = false;
            this.btnGetAllLog.Click += new System.EventHandler(this.btnGetAllLog_Click);
            // 
            // btnGetNowLog
            // 
            this.btnGetNowLog.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetNowLog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetNowLog.Location = new System.Drawing.Point(408, 12);
            this.btnGetNowLog.Name = "btnGetNowLog";
            this.btnGetNowLog.Size = new System.Drawing.Size(126, 55);
            this.btnGetNowLog.TabIndex = 2;
            this.btnGetNowLog.Text = "取得即時LOG";
            this.btnGetNowLog.UseVisualStyleBackColor = false;
            this.btnGetNowLog.Click += new System.EventHandler(this.btnGetNowLog_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDeleteFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteFile.Location = new System.Drawing.Point(144, 12);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(126, 55);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "刪除檔案";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnUpdateFile
            // 
            this.btnUpdateFile.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnUpdateFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateFile.Location = new System.Drawing.Point(1135, 95);
            this.btnUpdateFile.Name = "btnUpdateFile";
            this.btnUpdateFile.Size = new System.Drawing.Size(55, 33);
            this.btnUpdateFile.TabIndex = 4;
            this.btnUpdateFile.Text = "更新";
            this.btnUpdateFile.UseVisualStyleBackColor = false;
            this.btnUpdateFile.Click += new System.EventHandler(this.btnUpdateFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.LawnGreen;
            this.btnOpenFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(126, 55);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "開啟檔案";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDir.Location = new System.Drawing.Point(12, 84);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(654, 33);
            this.txtDir.TabIndex = 6;
            this.txtDir.Text = "D:\\SecureFX\\SecureFX.log";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1082, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "label1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "SecureFX.log";
            this.openFileDialog.InitialDirectory = "D:\\SecureFX";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "開啟舊檔";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 602);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnUpdateFile);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnGetNowLog);
            this.Controls.Add(this.btnGetAllLog);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "FTP用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnGetAllLog;
        private System.Windows.Forms.Button btnGetNowLog;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnUpdateFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
    }
}

