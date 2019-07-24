namespace ANCRM_DealerUpload
{
    partial class FrmSDailyUpload1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSDailyUpload1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnBulkUpload = new System.Windows.Forms.Button();
            this.btnUploaddet = new System.Windows.Forms.Button();
            this.pnlSelectFile = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblSalesDateError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.btnSFile = new System.Windows.Forms.Button();
            this.pnlValidate = new System.Windows.Forms.Panel();
            this.pgbUpload = new System.Windows.Forms.ProgressBar();
            this.lnkDownloadErrorFile = new System.Windows.Forms.LinkLabel();
            this.gvErrorData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.gbValidate = new System.Windows.Forms.GroupBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFailureCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSuccessCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblValidation = new System.Windows.Forms.Label();
            this.lblDataCount = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUploadDet = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpTillDate = new System.Windows.Forms.DateTimePicker();
            this.dpFromDate = new System.Windows.Forms.DateTimePicker();
            this.gvUploadDet = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.pnlBtns.SuspendLayout();
            this.pnlSelectFile.SuspendLayout();
            this.pnlValidate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrorData)).BeginInit();
            this.gbValidate.SuspendLayout();
            this.pnlUploadDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUploadDet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHeader
            // 
            this.pbHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbHeader.Image")));
            this.pbHeader.Location = new System.Drawing.Point(0, -1);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1261, 121);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeader.TabIndex = 1;
            this.pbHeader.TabStop = false;
            this.pbHeader.Click += new System.EventHandler(this.pbHeader_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.White;
            this.btnValidate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidate.BackgroundImage")));
            this.btnValidate.Enabled = false;
            this.btnValidate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.Black;
            this.btnValidate.Location = new System.Drawing.Point(16, 63);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(150, 40);
            this.btnValidate.TabIndex = 26;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(16, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(16, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.BackColor = System.Drawing.Color.White;
            this.BtnSelectFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSelectFile.BackgroundImage")));
            this.BtnSelectFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectFile.ForeColor = System.Drawing.Color.Black;
            this.BtnSelectFile.Location = new System.Drawing.Point(16, 16);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(150, 40);
            this.BtnSelectFile.TabIndex = 23;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = false;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Controls.Add(this.btnBulkUpload);
            this.pnlBtns.Controls.Add(this.btnUploaddet);
            this.pnlBtns.Controls.Add(this.btnValidate);
            this.pnlBtns.Controls.Add(this.BtnSelectFile);
            this.pnlBtns.Controls.Add(this.btnCancel);
            this.pnlBtns.Controls.Add(this.btnExit);
            this.pnlBtns.Location = new System.Drawing.Point(0, 119);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(183, 307);
            this.pnlBtns.TabIndex = 27;
            // 
            // btnBulkUpload
            // 
            this.btnBulkUpload.BackColor = System.Drawing.Color.White;
            this.btnBulkUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBulkUpload.BackgroundImage")));
            this.btnBulkUpload.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulkUpload.ForeColor = System.Drawing.Color.Black;
            this.btnBulkUpload.Location = new System.Drawing.Point(16, 157);
            this.btnBulkUpload.Name = "btnBulkUpload";
            this.btnBulkUpload.Size = new System.Drawing.Size(150, 40);
            this.btnBulkUpload.TabIndex = 28;
            this.btnBulkUpload.Text = "Bulk Upload";
            this.btnBulkUpload.UseVisualStyleBackColor = false;
            this.btnBulkUpload.Visible = false;
            this.btnBulkUpload.Click += new System.EventHandler(this.btnBulkUpload_Click);
            // 
            // btnUploaddet
            // 
            this.btnUploaddet.BackColor = System.Drawing.Color.White;
            this.btnUploaddet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploaddet.BackgroundImage")));
            this.btnUploaddet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploaddet.ForeColor = System.Drawing.Color.Black;
            this.btnUploaddet.Location = new System.Drawing.Point(16, 110);
            this.btnUploaddet.Name = "btnUploaddet";
            this.btnUploaddet.Size = new System.Drawing.Size(150, 40);
            this.btnUploaddet.TabIndex = 27;
            this.btnUploaddet.Text = "Uploaded Files";
            this.btnUploaddet.UseVisualStyleBackColor = false;
            this.btnUploaddet.Click += new System.EventHandler(this.btnUploaddet_Click);
            // 
            // pnlSelectFile
            // 
            this.pnlSelectFile.BackColor = System.Drawing.Color.White;
            this.pnlSelectFile.Controls.Add(this.lblFilePath);
            this.pnlSelectFile.Controls.Add(this.lblFname);
            this.pnlSelectFile.Controls.Add(this.lblSalesDateError);
            this.pnlSelectFile.Controls.Add(this.label1);
            this.pnlSelectFile.Controls.Add(this.dpSalesDate);
            this.pnlSelectFile.Controls.Add(this.btnSFile);
            this.pnlSelectFile.Location = new System.Drawing.Point(190, 119);
            this.pnlSelectFile.Name = "pnlSelectFile";
            this.pnlSelectFile.Size = new System.Drawing.Size(1072, 219);
            this.pnlSelectFile.TabIndex = 28;
            this.pnlSelectFile.Visible = false;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.Color.Blue;
            this.lblFilePath.Location = new System.Drawing.Point(326, 106);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 18);
            this.lblFilePath.TabIndex = 29;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Blue;
            this.lblFname.Location = new System.Drawing.Point(389, 147);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(0, 18);
            this.lblFname.TabIndex = 28;
            this.lblFname.Visible = false;
            // 
            // lblSalesDateError
            // 
            this.lblSalesDateError.AutoSize = true;
            this.lblSalesDateError.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDateError.ForeColor = System.Drawing.Color.Red;
            this.lblSalesDateError.Location = new System.Drawing.Point(145, 63);
            this.lblSalesDateError.Name = "lblSalesDateError";
            this.lblSalesDateError.Size = new System.Drawing.Size(85, 18);
            this.lblSalesDateError.TabIndex = 27;
            this.lblSalesDateError.Text = "Date Error";
            this.lblSalesDateError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date";
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.CustomFormat = "dd-MMM-yyyy ddd";
            this.dpSalesDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSalesDate.Location = new System.Drawing.Point(148, 21);
            this.dpSalesDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(180, 26);
            this.dpSalesDate.TabIndex = 25;
            this.dpSalesDate.Value = new System.DateTime(2019, 2, 22, 0, 0, 0, 0);
            // 
            // btnSFile
            // 
            this.btnSFile.BackColor = System.Drawing.Color.White;
            this.btnSFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSFile.BackgroundImage")));
            this.btnSFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSFile.ForeColor = System.Drawing.Color.White;
            this.btnSFile.Location = new System.Drawing.Point(148, 90);
            this.btnSFile.Name = "btnSFile";
            this.btnSFile.Size = new System.Drawing.Size(150, 40);
            this.btnSFile.TabIndex = 24;
            this.btnSFile.Text = "Select File";
            this.btnSFile.UseVisualStyleBackColor = false;
            this.btnSFile.Click += new System.EventHandler(this.btnSFile_Click);
            // 
            // pnlValidate
            // 
            this.pnlValidate.BackColor = System.Drawing.Color.Beige;
            this.pnlValidate.Controls.Add(this.pgbUpload);
            this.pnlValidate.Controls.Add(this.lnkDownloadErrorFile);
            this.pnlValidate.Controls.Add(this.gvErrorData);
            this.pnlValidate.Controls.Add(this.label4);
            this.pnlValidate.Controls.Add(this.gbValidate);
            this.pnlValidate.Location = new System.Drawing.Point(189, 130);
            this.pnlValidate.Name = "pnlValidate";
            this.pnlValidate.Size = new System.Drawing.Size(1069, 567);
            this.pnlValidate.TabIndex = 29;
            this.pnlValidate.Visible = false;
            // 
            // pgbUpload
            // 
            this.pgbUpload.BackColor = System.Drawing.Color.White;
            this.pgbUpload.Location = new System.Drawing.Point(17, 242);
            this.pgbUpload.Name = "pgbUpload";
            this.pgbUpload.Size = new System.Drawing.Size(822, 23);
            this.pgbUpload.TabIndex = 31;
            this.pgbUpload.Value = 1;
            this.pgbUpload.Visible = false;
            // 
            // lnkDownloadErrorFile
            // 
            this.lnkDownloadErrorFile.AutoSize = true;
            this.lnkDownloadErrorFile.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDownloadErrorFile.Location = new System.Drawing.Point(875, 278);
            this.lnkDownloadErrorFile.Name = "lnkDownloadErrorFile";
            this.lnkDownloadErrorFile.Size = new System.Drawing.Size(82, 18);
            this.lnkDownloadErrorFile.TabIndex = 30;
            this.lnkDownloadErrorFile.TabStop = true;
            this.lnkDownloadErrorFile.Text = "Download";
            this.lnkDownloadErrorFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownloadErrorFile_LinkClicked);
            // 
            // gvErrorData
            // 
            this.gvErrorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvErrorData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvErrorData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvErrorData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gvErrorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvErrorData.Location = new System.Drawing.Point(17, 308);
            this.gvErrorData.Name = "gvErrorData";
            this.gvErrorData.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvErrorData.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvErrorData.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.gvErrorData.Size = new System.Drawing.Size(940, 242);
            this.gvErrorData.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Error Data";
            // 
            // gbValidate
            // 
            this.gbValidate.BackColor = System.Drawing.Color.White;
            this.gbValidate.Controls.Add(this.lblFilename);
            this.gbValidate.Controls.Add(this.label6);
            this.gbValidate.Controls.Add(this.lblFailureCount);
            this.gbValidate.Controls.Add(this.label13);
            this.gbValidate.Controls.Add(this.lblSuccessCount);
            this.gbValidate.Controls.Add(this.label11);
            this.gbValidate.Controls.Add(this.btnUpload);
            this.gbValidate.Controls.Add(this.lblValidation);
            this.gbValidate.Controls.Add(this.lblDataCount);
            this.gbValidate.Controls.Add(this.lblSalesDate);
            this.gbValidate.Controls.Add(this.label5);
            this.gbValidate.Controls.Add(this.label3);
            this.gbValidate.Controls.Add(this.label2);
            this.gbValidate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValidate.Location = new System.Drawing.Point(17, 14);
            this.gbValidate.Name = "gbValidate";
            this.gbValidate.Size = new System.Drawing.Size(822, 222);
            this.gbValidate.TabIndex = 8;
            this.gbValidate.TabStop = false;
            this.gbValidate.Text = "Validation";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.ForeColor = System.Drawing.Color.Blue;
            this.lblFilename.Location = new System.Drawing.Point(149, 44);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(78, 18);
            this.lblFilename.TabIndex = 22;
            this.lblFilename.Text = "Validation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "File";
            // 
            // lblFailureCount
            // 
            this.lblFailureCount.AutoSize = true;
            this.lblFailureCount.ForeColor = System.Drawing.Color.Blue;
            this.lblFailureCount.Location = new System.Drawing.Point(422, 132);
            this.lblFailureCount.Name = "lblFailureCount";
            this.lblFailureCount.Size = new System.Drawing.Size(93, 18);
            this.lblFailureCount.TabIndex = 19;
            this.lblFailureCount.Text = "Data Count";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Failure";
            // 
            // lblSuccessCount
            // 
            this.lblSuccessCount.AutoSize = true;
            this.lblSuccessCount.ForeColor = System.Drawing.Color.Blue;
            this.lblSuccessCount.Location = new System.Drawing.Point(149, 129);
            this.lblSuccessCount.Name = "lblSuccessCount";
            this.lblSuccessCount.Size = new System.Drawing.Size(93, 18);
            this.lblSuccessCount.TabIndex = 17;
            this.lblSuccessCount.Text = "Data Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 129);
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
            this.btnUpload.Location = new System.Drawing.Point(650, 164);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 40);
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
            this.lblValidation.Location = new System.Drawing.Point(149, 175);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(78, 18);
            this.lblValidation.TabIndex = 15;
            this.lblValidation.Text = "Validation";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.ForeColor = System.Drawing.Color.Blue;
            this.lblDataCount.Location = new System.Drawing.Point(422, 90);
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
            this.lblSalesDate.Location = new System.Drawing.Point(149, 90);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(87, 18);
            this.lblSalesDate.TabIndex = 12;
            this.lblSalesDate.Text = "Sales Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Validation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // pnlUploadDet
            // 
            this.pnlUploadDet.BackColor = System.Drawing.Color.Beige;
            this.pnlUploadDet.Controls.Add(this.btnView);
            this.pnlUploadDet.Controls.Add(this.label10);
            this.pnlUploadDet.Controls.Add(this.label9);
            this.pnlUploadDet.Controls.Add(this.dpTillDate);
            this.pnlUploadDet.Controls.Add(this.dpFromDate);
            this.pnlUploadDet.Controls.Add(this.gvUploadDet);
            this.pnlUploadDet.Controls.Add(this.label8);
            this.pnlUploadDet.Location = new System.Drawing.Point(190, 703);
            this.pnlUploadDet.Name = "pnlUploadDet";
            this.pnlUploadDet.Size = new System.Drawing.Size(1068, 329);
            this.pnlUploadDet.TabIndex = 29;
            this.pnlUploadDet.Visible = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnView.BackgroundImage")));
            this.btnView.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(568, 44);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 35);
            this.btnView.TabIndex = 23;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(323, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Till";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(61, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "From";
            // 
            // dpTillDate
            // 
            this.dpTillDate.CustomFormat = "dd-MMM-yyyy ddd";
            this.dpTillDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpTillDate.Location = new System.Drawing.Point(369, 50);
            this.dpTillDate.MaxDate = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            this.dpTillDate.Name = "dpTillDate";
            this.dpTillDate.Size = new System.Drawing.Size(148, 23);
            this.dpTillDate.TabIndex = 30;
            this.dpTillDate.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            // 
            // dpFromDate
            // 
            this.dpFromDate.CustomFormat = "dd-MMM-yyyy ddd";
            this.dpFromDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(131, 50);
            this.dpFromDate.MaxDate = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(157, 23);
            this.dpFromDate.TabIndex = 29;
            this.dpFromDate.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            // 
            // gvUploadDet
            // 
            this.gvUploadDet.AllowUserToAddRows = false;
            this.gvUploadDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvUploadDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvUploadDet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvUploadDet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gvUploadDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.NullValue = null;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvUploadDet.DefaultCellStyle = dataGridViewCellStyle20;
            this.gvUploadDet.Location = new System.Drawing.Point(19, 88);
            this.gvUploadDet.Name = "gvUploadDet";
            this.gvUploadDet.ReadOnly = true;
            this.gvUploadDet.Size = new System.Drawing.Size(939, 228);
            this.gvUploadDet.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Uploaded Details";
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSDailyUpload1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1254, 733);
            this.Controls.Add(this.pnlSelectFile);
            this.Controls.Add(this.pnlValidate);
            this.Controls.Add(this.pnlUploadDet);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.pnlBtns);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmSDailyUpload1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer Master Update";
            this.Load += new System.EventHandler(this.FrmSDailyUpload1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.pnlBtns.ResumeLayout(false);
            this.pnlSelectFile.ResumeLayout(false);
            this.pnlSelectFile.PerformLayout();
            this.pnlValidate.ResumeLayout(false);
            this.pnlValidate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrorData)).EndInit();
            this.gbValidate.ResumeLayout(false);
            this.gbValidate.PerformLayout();
            this.pnlUploadDet.ResumeLayout(false);
            this.pnlUploadDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUploadDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Panel pnlSelectFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSalesDateError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpSalesDate;
        private System.Windows.Forms.Button btnSFile;
        private System.Windows.Forms.Panel pnlValidate;
        private System.Windows.Forms.GroupBox gbValidate;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFailureCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSuccessCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label lblDataCount;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkDownloadErrorFile;
        private System.Windows.Forms.DataGridView gvErrorData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlUploadDet;
        private System.Windows.Forms.DataGridView gvUploadDet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUploaddet;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.DateTimePicker dpTillDate;
        private System.Windows.Forms.DateTimePicker dpFromDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBulkUpload;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgbUpload;
    }
}