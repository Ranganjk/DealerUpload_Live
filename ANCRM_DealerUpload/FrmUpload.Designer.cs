namespace ANCRM_DealerUpload
{
    partial class FrmUpload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFileUpload = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNooffiles = new System.Windows.Forms.Label();
            this.lblUploadedFiles = new System.Windows.Forms.Label();
            this.lblFailedFiles = new System.Windows.Forms.Label();
            this.btnStartUpload = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblinvalidfile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDailyUpload = new System.Windows.Forms.Button();
            this.pgbUpload = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFileUpload
            // 
            this.dgvFileUpload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFileUpload.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFileUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileUpload.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileUpload.GridColor = System.Drawing.Color.LemonChiffon;
            this.dgvFileUpload.Location = new System.Drawing.Point(28, 218);
            this.dgvFileUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFileUpload.Name = "dgvFileUpload";
            this.dgvFileUpload.ReadOnly = true;
            this.dgvFileUpload.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFileUpload.Size = new System.Drawing.Size(928, 311);
            this.dgvFileUpload.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(242, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRIMARY SALES UPLOAD - ONE TIME UPLOAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "No.of Files";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Uploaded";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Failed";
            // 
            // lblNooffiles
            // 
            this.lblNooffiles.AutoSize = true;
            this.lblNooffiles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNooffiles.Location = new System.Drawing.Point(173, 184);
            this.lblNooffiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNooffiles.Name = "lblNooffiles";
            this.lblNooffiles.Size = new System.Drawing.Size(42, 16);
            this.lblNooffiles.TabIndex = 11;
            this.lblNooffiles.Text = "Files";
            // 
            // lblUploadedFiles
            // 
            this.lblUploadedFiles.AutoSize = true;
            this.lblUploadedFiles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadedFiles.Location = new System.Drawing.Point(367, 184);
            this.lblUploadedFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUploadedFiles.Name = "lblUploadedFiles";
            this.lblUploadedFiles.Size = new System.Drawing.Size(84, 16);
            this.lblUploadedFiles.TabIndex = 13;
            this.lblUploadedFiles.Text = "No.of Files";
            // 
            // lblFailedFiles
            // 
            this.lblFailedFiles.AutoSize = true;
            this.lblFailedFiles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailedFiles.Location = new System.Drawing.Point(580, 184);
            this.lblFailedFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFailedFiles.Name = "lblFailedFiles";
            this.lblFailedFiles.Size = new System.Drawing.Size(84, 16);
            this.lblFailedFiles.TabIndex = 14;
            this.lblFailedFiles.Text = "No.of Files";
            // 
            // btnStartUpload
            // 
            this.btnStartUpload.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartUpload.Location = new System.Drawing.Point(118, 105);
            this.btnStartUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartUpload.Name = "btnStartUpload";
            this.btnStartUpload.Size = new System.Drawing.Size(137, 36);
            this.btnStartUpload.TabIndex = 15;
            this.btnStartUpload.Text = "Start Upload";
            this.btnStartUpload.UseVisualStyleBackColor = true;
            this.btnStartUpload.Click += new System.EventHandler(this.btnStartUpload_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(735, 109);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(77, 16);
            this.lblDateTime.TabIndex = 16;
            this.lblDateTime.Text = "DateTime";
            // 
            // lblinvalidfile
            // 
            this.lblinvalidfile.AutoSize = true;
            this.lblinvalidfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvalidfile.Location = new System.Drawing.Point(803, 184);
            this.lblinvalidfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinvalidfile.Name = "lblinvalidfile";
            this.lblinvalidfile.Size = new System.Drawing.Size(84, 16);
            this.lblinvalidfile.TabIndex = 18;
            this.lblinvalidfile.Text = "No.of Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Invalid Files";
            // 
            // btnDailyUpload
            // 
            this.btnDailyUpload.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyUpload.Location = new System.Drawing.Point(298, 105);
            this.btnDailyUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDailyUpload.Name = "btnDailyUpload";
            this.btnDailyUpload.Size = new System.Drawing.Size(137, 36);
            this.btnDailyUpload.TabIndex = 19;
            this.btnDailyUpload.Text = "Daily Upload";
            this.btnDailyUpload.UseVisualStyleBackColor = true;
            this.btnDailyUpload.Click += new System.EventHandler(this.btnDailyUpload_Click);
            // 
            // pgbUpload
            // 
            this.pgbUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pgbUpload.Location = new System.Drawing.Point(118, 152);
            this.pgbUpload.Name = "pgbUpload";
            this.pgbUpload.Size = new System.Drawing.Size(730, 23);
            this.pgbUpload.TabIndex = 20;
            this.pgbUpload.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(475, 105);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 36);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 557);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pgbUpload);
            this.Controls.Add(this.btnDailyUpload);
            this.Controls.Add(this.lblinvalidfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnStartUpload);
            this.Controls.Add(this.lblFailedFiles);
            this.Controls.Add(this.lblUploadedFiles);
            this.Controls.Add(this.lblNooffiles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFileUpload);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmUpload";
            this.Text = "File Upload";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNooffiles;
        private System.Windows.Forms.Label lblUploadedFiles;
        private System.Windows.Forms.Label lblFailedFiles;
        private System.Windows.Forms.Button btnStartUpload;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblinvalidfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDailyUpload;
        private System.Windows.Forms.ProgressBar pgbUpload;
        private System.Windows.Forms.Button btnExit;
    }
}

