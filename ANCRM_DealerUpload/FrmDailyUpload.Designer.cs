namespace ANCRM_DealerUpload
{
    partial class FrmDailyUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyUpload));
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.dpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalesDateError = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbValidate = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFailureCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSuccessCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblValidation = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblDataCount = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.gvErrorData = new System.Windows.Forms.DataGridView();
            this.gvUploadDet = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkDownloadErrorFile = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.gbValidate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUploadDet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHeader
            // 
            this.pbHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbHeader.Image")));
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1261, 121);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeader.TabIndex = 0;
            this.pbHeader.TabStop = false;
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "openFileDialog1";
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.BackColor = System.Drawing.Color.White;
            this.BtnSelectFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSelectFile.BackgroundImage")));
            this.BtnSelectFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectFile.ForeColor = System.Drawing.Color.White;
            this.BtnSelectFile.Location = new System.Drawing.Point(161, 221);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(180, 41);
            this.BtnSelectFile.TabIndex = 1;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = false;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.CustomFormat = "dd-MMM-yyyy ddd";
            this.dpSalesDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSalesDate.Location = new System.Drawing.Point(161, 158);
            this.dpSalesDate.MaxDate = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(180, 26);
            this.dpSalesDate.TabIndex = 2;
            this.dpSalesDate.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sales Date";
            // 
            // lblSalesDateError
            // 
            this.lblSalesDateError.AutoSize = true;
            this.lblSalesDateError.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDateError.ForeColor = System.Drawing.Color.Red;
            this.lblSalesDateError.Location = new System.Drawing.Point(372, 164);
            this.lblSalesDateError.Name = "lblSalesDateError";
            this.lblSalesDateError.Size = new System.Drawing.Size(129, 18);
            this.lblSalesDateError.TabIndex = 4;
            this.lblSalesDateError.Text = "Sales Date Error";
            this.lblSalesDateError.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1064, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(823, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbValidate
            // 
            this.gbValidate.BackColor = System.Drawing.Color.Ivory;
            this.gbValidate.Controls.Add(this.label7);
            this.gbValidate.Controls.Add(this.lblFailureCount);
            this.gbValidate.Controls.Add(this.label13);
            this.gbValidate.Controls.Add(this.lblSuccessCount);
            this.gbValidate.Controls.Add(this.label11);
            this.gbValidate.Controls.Add(this.btnUpload);
            this.gbValidate.Controls.Add(this.lblValidation);
            this.gbValidate.Controls.Add(this.lblTotalPoints);
            this.gbValidate.Controls.Add(this.lblDataCount);
            this.gbValidate.Controls.Add(this.lblSalesDate);
            this.gbValidate.Controls.Add(this.label5);
            this.gbValidate.Controls.Add(this.label3);
            this.gbValidate.Controls.Add(this.label2);
            this.gbValidate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValidate.Location = new System.Drawing.Point(32, 314);
            this.gbValidate.Name = "gbValidate";
            this.gbValidate.Size = new System.Drawing.Size(1212, 157);
            this.gbValidate.TabIndex = 7;
            this.gbValidate.TabStop = false;
            this.gbValidate.Text = "Validation";
            this.gbValidate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Points";
            // 
            // lblFailureCount
            // 
            this.lblFailureCount.AutoSize = true;
            this.lblFailureCount.ForeColor = System.Drawing.Color.Blue;
            this.lblFailureCount.Location = new System.Drawing.Point(748, 44);
            this.lblFailureCount.Name = "lblFailureCount";
            this.lblFailureCount.Size = new System.Drawing.Size(93, 18);
            this.lblFailureCount.TabIndex = 19;
            this.lblFailureCount.Text = "Data Count";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(627, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Failure";
            // 
            // lblSuccessCount
            // 
            this.lblSuccessCount.AutoSize = true;
            this.lblSuccessCount.ForeColor = System.Drawing.Color.Blue;
            this.lblSuccessCount.Location = new System.Drawing.Point(460, 85);
            this.lblSuccessCount.Name = "lblSuccessCount";
            this.lblSuccessCount.Size = new System.Drawing.Size(93, 18);
            this.lblSuccessCount.TabIndex = 17;
            this.lblSuccessCount.Text = "Data Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Success";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpload.BackgroundImage")));
            this.btnUpload.Enabled = false;
            this.btnUpload.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(1019, 101);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(179, 41);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidation.ForeColor = System.Drawing.Color.Blue;
            this.lblValidation.Location = new System.Drawing.Point(748, 85);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(78, 18);
            this.lblValidation.TabIndex = 15;
            this.lblValidation.Text = "Validation";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPoints.Location = new System.Drawing.Point(149, 85);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(93, 18);
            this.lblTotalPoints.TabIndex = 14;
            this.lblTotalPoints.Text = "Total Points";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.ForeColor = System.Drawing.Color.Blue;
            this.lblDataCount.Location = new System.Drawing.Point(460, 44);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(93, 18);
            this.lblDataCount.TabIndex = 13;
            this.lblDataCount.Text = "Data Count";
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDate.ForeColor = System.Drawing.Color.Blue;
            this.lblSalesDate.Location = new System.Drawing.Point(149, 44);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(87, 18);
            this.lblSalesDate.TabIndex = 12;
            this.lblSalesDate.Text = "Sales Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Validation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sales Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Error Data";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Blue;
            this.lblFname.Location = new System.Drawing.Point(372, 232);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(0, 18);
            this.lblFname.TabIndex = 21;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.White;
            this.btnValidate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidate.BackgroundImage")));
            this.btnValidate.Enabled = false;
            this.btnValidate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(575, 221);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(180, 41);
            this.btnValidate.TabIndex = 22;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.Color.Blue;
            this.lblFilePath.Location = new System.Drawing.Point(372, 272);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(87, 18);
            this.lblFilePath.TabIndex = 23;
            this.lblFilePath.Text = "Sales Date";
            this.lblFilePath.Visible = false;
            // 
            // gvErrorData
            // 
            this.gvErrorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvErrorData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvErrorData.BackgroundColor = System.Drawing.Color.MintCream;
            this.gvErrorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvErrorData.Location = new System.Drawing.Point(32, 519);
            this.gvErrorData.Name = "gvErrorData";
            this.gvErrorData.ReadOnly = true;
            this.gvErrorData.Size = new System.Drawing.Size(940, 242);
            this.gvErrorData.TabIndex = 24;
            // 
            // gvUploadDet
            // 
            this.gvUploadDet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvUploadDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUploadDet.Location = new System.Drawing.Point(32, 827);
            this.gvUploadDet.Name = "gvUploadDet";
            this.gvUploadDet.ReadOnly = true;
            this.gvUploadDet.Size = new System.Drawing.Size(940, 250);
            this.gvUploadDet.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 795);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Upload Details";
            // 
            // lnkDownloadErrorFile
            // 
            this.lnkDownloadErrorFile.AutoSize = true;
            this.lnkDownloadErrorFile.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDownloadErrorFile.Location = new System.Drawing.Point(890, 489);
            this.lnkDownloadErrorFile.Name = "lnkDownloadErrorFile";
            this.lnkDownloadErrorFile.Size = new System.Drawing.Size(82, 18);
            this.lnkDownloadErrorFile.TabIndex = 27;
            this.lnkDownloadErrorFile.TabStop = true;
            this.lnkDownloadErrorFile.Text = "Download";
            this.lnkDownloadErrorFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownloadErrorFile_LinkClicked);
            // 
            // FrmDailyUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1262, 997);
            this.Controls.Add(this.lnkDownloadErrorFile);
            this.Controls.Add(this.gvUploadDet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gvErrorData);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.gbValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSalesDateError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpSalesDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.pbHeader);
            this.Name = "FrmDailyUpload";
            this.Text = "FrmDailyUpload";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDailyUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.gbValidate.ResumeLayout(false);
            this.gbValidate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUploadDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.DateTimePicker dpSalesDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalesDateError;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbValidate;
        private System.Windows.Forms.Label lblFailureCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSuccessCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblDataCount;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.DataGridView gvErrorData;
        private System.Windows.Forms.DataGridView gvUploadDet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkDownloadErrorFile;
        private System.Windows.Forms.Label label7;
    }
}