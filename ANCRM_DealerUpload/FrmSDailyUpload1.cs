using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANCRM_DealerUpload
{
    public partial class FrmSDailyUpload1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMART"].ToString());
        public static DataTable dtSuccessData = new DataTable();
        public static DataTable dtFailedData = new DataTable();
        public static DataTable dtDealers = new DataTable();
        int tcount = 0, scount = 0, fcount = 0;
        public FrmSDailyUpload1()
        {
            InitializeComponent();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            pnlFalse();
            pnlSelectFile.Visible = true;
            pnlSelectFile.Location = new Point(190, 130);
        }

        private void btnSFile_Click(object sender, EventArgs e)
        {
            lblSalesDateError.Visible = false;
            string msg = CheckSalesDate();
            if (msg.Equals("Ok"))
            {
                string filter = "Dealer Data(.xlsb)|*.xlsb";
                //string filter = "DealerData_Test(.xls)|*.xls";
                ofdUploadFile.Filter = filter;
                ofdUploadFile.FilterIndex = 1;
                ofdUploadFile.FileName = "";
                ofdUploadFile.ShowDialog();
                if (!string.IsNullOrEmpty(ofdUploadFile.FileName))
                {
                    lblFilePath.Text = ofdUploadFile.FileName;
                    lblFname.Text = Path.GetFileName(ofdUploadFile.FileName);
                    btnValidate.Enabled = true;
                    btnCancel.Enabled = true;
                }
                //else
                //{
                //    lblSalesDateError.Visible = true;
                //    lblSalesDateError.Text = msg;
                //    btnValidate.Enabled = false;
                //}
            }
            else
            {
                lblSalesDateError.Visible = true;
                lblSalesDateError.Text = msg;
                btnValidate.Enabled = false;
            }
        }

        private void FrmSDailyUpload1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.MaximizeBox = true;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            pbHeader.Width = this.Width;
            SetAsFirst();

            //dpFromDate.MaxDate = DateTime.Today;
            //dpTillDate.MaxDate = DateTime.Today;
            dpSalesDate.MaxDate = DateTime.Today;
            //dpFromDate.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            //dpTillDate.Value = DateTime.Today;
            dpSalesDate.Value = DateTime.Today;
        }
        private void SetAsFirst()
        {
            BtnSelectFile.Enabled = true;
            dpSalesDate.Enabled = true;
            btnValidate.Enabled = false;
            btnCancel.Enabled = false;
            //gvErrorData.DataSource = string.Empty;
            //gbValidate.Visible = false;
            dtDealers.Rows.Clear();
            dtSuccessData.Rows.Clear();
            dtFailedData.Rows.Clear();
            lblFname.Text = "";
            lblFilePath.Text = "";
            lblSalesDate.Text = "";
            lblSalesDateError.Text = "";
            lnkDownloadErrorFile.Enabled = false;

            pnlSelectFile.Visible = true;
            pnlSelectFile.Location = new Point(190, 130);
        }
        private string CheckSalesDate()
        {
            string msg = "Ok";
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM CG_DealerUpdateLog WHERE SalesDate='" + dpSalesDate.Value.ToString("dd MMM yyyy") + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    msg = "The dealer data have already been uploaded for this date. Please check the upload date and try again";
                }
                return msg;
            }
            catch (Exception ex)
            {
                return msg;
            }
        }
        private void Validate()
        {
            
            string path = null;
            lblFilename.Text = lblFilePath.Text;
            try
            {
                path = Application.StartupPath + @"\SInbox\" + lblFname.Text;
                if (!path.Equals(lblFilePath.Text))
                {
                    
                    File.Copy(lblFilePath.Text, path, true);
                }
            }
            catch (Exception EX)
            {
               // MessageBox.Show(ex.Message);
            }

            try
            {
                if (dtSuccessData.Columns.Count == 0)
                {
                    dtSuccessData.Columns.AddRange(new DataColumn[16] { new DataColumn("CUSTOMERCODE", typeof(Int64)),
                        new DataColumn("CUSTOMERNAME", typeof(string)),                        
                        new DataColumn("REGION", typeof(string)),
                        new DataColumn("ZONE", typeof(string)),
                        new DataColumn("DEPOTNAME", typeof(string)),
                        new DataColumn("DEPOT", typeof(string)),
                        new DataColumn("DLRSTART", typeof(string)),
                        new DataColumn("POST", typeof(string)),
                        new DataColumn("CGActive", typeof(string)),
                        new DataColumn("AreaUnitCode", typeof(string)),
                        new DataColumn("DealerType", typeof(string)),
                        new DataColumn("DistributorName", typeof(string)),
                        new DataColumn("DistributorCode", typeof(string)),
                        new DataColumn("SOCode", typeof(string)),
                        new DataColumn("SOName", typeof(string)),
                        new DataColumn("DDate", typeof(DateTime))});                    
                }
                if (dtFailedData.Columns.Count == 0)
                {
                    dtFailedData.Columns.Add("S_No");
                    dtFailedData.Columns.Add("FileName");
                    dtFailedData.Columns.Add("DealerCode");
                    dtFailedData.Columns.Add("DealerName");
                    dtFailedData.Columns.Add("SalesDate");
                    //dtFailedData.Columns.Add("PrdtGrpCode");
                    //dtFailedData.Columns.Add("PrdtGrpName");
                    //dtFailedData.Columns.Add("Points");
                }

                tcount = 0; scount = 0; fcount = 0;
                dtFailedData.Rows.Clear();
                dtSuccessData.Rows.Clear();
                bool isFirst = true;
                string connString = "";
                string strFileType = Path.GetExtension(lblFilename.Text).ToLower();
                if (strFileType.Trim() == ".xls")
                {
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                }
                else if (strFileType.Trim() == ".xlsx" || strFileType.Trim() == ".xlsb")
                {
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                }
               
                using (OleDbConnection connection = new OleDbConnection(connString))
                {

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    DataTable dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheetname = dt.Rows[0]["Table_Name"].ToString();
                    string query = "SELECT * FROM [" + sheetname + "]";

                    OleDbCommand command = new OleDbCommand(query, connection);

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        try
                        {
                            var val1 = reader[0].ToString();

                            tcount = tcount + 1;
                            int count = 0;
                            
                            if (string.IsNullOrEmpty(reader[0].ToString()))
                            {
                                dtFailedData.Rows.Add();
                                dtFailedData.Rows[dtFailedData.Rows.Count - 1]["S_No"] = (tcount + 1).ToString();
                                dtFailedData.Rows[dtFailedData.Rows.Count - 1]["FileName"] = lblFname.Text;
                                dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerCode"] = reader[0].ToString();
                                dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerName"] = reader[1].ToString();
                                dtFailedData.Rows[dtFailedData.Rows.Count - 1]["SalesDate"] = dpSalesDate.Value;

                                fcount = fcount + 1;
                                continue;
                            }
                            
                            dtSuccessData.Rows.Add();
                            for (int j = 0; j < reader.FieldCount; j++)
                            {                                

                                if (j == 0)
                                {
                                    if (!string.IsNullOrEmpty(reader[j].ToString().Trim()))
                                        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = Convert.ToInt64(reader[j].ToString().TrimStart(new char[] { '0' }));
                                }
                                //if (j == 2)
                                //{
                                //    if (string.IsNullOrEmpty(reader[j].ToString().Trim()))
                                //        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = DateTime.Now;
                                //    else
                                //        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = Convert.ToDateTime(reader[j].ToString());
                                //}
                                if (j == 5)
                                {
                                    if (!string.IsNullOrEmpty(reader[j].ToString().Trim()))

                                    {
                                        string Depot = reader[j].ToString();
                                        String SF = Depot.Substring(0,1);
                                        String SL = Depot.Substring(Depot.Length - 1);

                                        if (SF == "Q" && SL == "D")
                                        {
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = string.Concat(reader[j].ToString().Skip(1).Take(reader[j].ToString().Length - 2));
                                        }
                                    }

                                        //dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = string.Concat(reader[j].ToString().Skip(1).Take(reader[j].ToString().Length - 2));

                                    //{
                                    //    //dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = reader[j].ToString().Replace("Q", "").Replace("D", "");

                                    //    //dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = reader[j].ToString().Replace(reader[j].ToString()[0].ToString(), "").Replace(reader[j].ToString()[reader[j].ToString().Length - 1].ToString(), "");

                                    //    //dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = reader[j].ToString().Remove(0, 1).Remove(reader[j].ToString().Length-1,1);

                                    //    //var original = reader[j].ToString();
                                    //    //var firstAndLastRemoved = string.Concat(original.Skip(1).Take(original.Length - 2));
                                    //    //dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = firstAndLastRemoved;

                                    //}




                                }
                                else if (j == 8)
                                {
                                    if (string.IsNullOrEmpty(reader[j].ToString().Trim()))
                                        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = "AC";
                                    else
                                    {
                                        if (reader[j].ToString().Trim().Equals("Yes"))
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = "AC";
                                        else
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = "IA";

                                    }
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(reader[j].ToString().Trim()))
                                        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = reader[j].ToString().Trim();
                                    else
                                        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = null;
                                }
                            }
                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1]["DDate"] = Convert.ToDateTime(dpSalesDate.Value.ToString());
                            scount = scount + 1;

                        }
                        catch (Exception ex)
                        {
                            dtFailedData.Rows.Add();
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["S_No"] = (tcount + 1).ToString();
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["FileName"] = lblFname.Text;
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerCode"] = reader[0].ToString();
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerName"] = reader[1].ToString();
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["SalesDate"] = dpSalesDate.Value;

                            fcount = fcount + 1;
                        }
                    }
                    reader.Close();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fcount = 1;
            }
            
            lblSalesDate.Text = "";
            lblDataCount.Text = tcount.ToString();
            lblSuccessCount.Text = scount.ToString();
            lblFailureCount.Text = fcount.ToString();
            lblSalesDate.Text = dpSalesDate.Value.ToString("dd-MMM-yyyy ddd");
            if (fcount == 0)
                lblValidation.Text = "Success";
            else
                lblValidation.Text = "Failed";
            btnUpload.Enabled = true;
            LoadErrorFile();
            if (fcount == 0 && scount>0)
                btnUpload.Enabled = true;
            else
                btnUpload.Enabled = false;

            dpSalesDate.Enabled = false;
            BtnSelectFile.Enabled = false;
            btnValidate.Enabled = false;
        }
        protected void InsetFileLog(string status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_INSERTDEALERUPDATELOG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@SalesDate", SqlDbType.Date).Value = dpSalesDate.Value;
                cmd.Parameters.Add("@InputFile", SqlDbType.VarChar).Value = lblFname.Text;
                cmd.Parameters.Add("@DataCount", SqlDbType.BigInt).Value = Convert.ToInt32(lblDataCount.Text);
                cmd.Parameters.Add("@UploadedCount", SqlDbType.BigInt).Value = Convert.ToInt32(lblSuccessCount.Text);
                cmd.Parameters.Add("@FailedCount", SqlDbType.BigInt).Value = Convert.ToInt32(lblFailureCount.Text);
                cmd.Parameters.Add("@Status", SqlDbType.Char).Value = status;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                if (con.State != ConnectionState.Closed)
                    con.Close();

                string sinbox = Application.StartupPath + @"\SInbox\" + lblFname.Text;
                if (status.Equals("SC"))
                {
                    if (!File.Exists(Application.StartupPath + @"\UploadedFiles\" + lblFname.Text))
                    {
                        File.Move(sinbox, Application.StartupPath + @"\UploadedFiles\" + lblFname.Text);
                    }
                    else
                    {
                        File.Delete(Application.StartupPath + @"\UploadedFiles\" + lblFname.Text);
                        File.Move(sinbox, Application.StartupPath + @"\UploadedFiles\" + lblFname.Text);
                    }
                }
                else if (status.Equals("FD"))
                {
                    if (!File.Exists(Application.StartupPath + @"\ErrorFiles\" + lblFname.Text))
                    {
                        File.Move(sinbox, Application.StartupPath + @"\ErrorFiles\" + lblFname.Text);
                    }
                    else
                    {
                        File.Delete(Application.StartupPath + @"\ErrorFiles\" + lblFname.Text);
                        File.Move(sinbox, Application.StartupPath + @"\ErrorFiles\" + lblFname.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                //File.Move(path + @"\" + fname, Application.StartupPath + @"\ErrorFiles\" + fname);
            }

        }
        protected void UpdateDealer()
        {
            try
            {
                DataView dv = new DataView(dtSuccessData);
                DataTable dtDlr = new DataTable();
                DataTable dtTemp = dv.ToTable(true, "DDate");
                for (int i = 0; i < dtTemp.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(dtTemp.Rows[i]["DDate"])))
                    {
                        SqlCommand cmd = new SqlCommand("SP_DEALERDETUPDATE", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 3;
                        cmd.Parameters.Add("@SALESDATE", SqlDbType.DateTime).Value = Convert.ToDateTime(dtTemp.Rows[i]["DDate"]);
                        cmd.CommandTimeout = 500;
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        
                        sda.Fill(dtDlr);                                              

                        //TO update INSERT & UPDATE COUNT
                        SqlCommand cmd1 = new SqlCommand("SP_INSERTDEALERUPDATELOG", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("@IMODE", SqlDbType.Int).Value = 7;
                        cmd1.Parameters.Add("@SALESDATE", SqlDbType.DateTime).Value = Convert.ToDateTime(dtTemp.Rows[i]["dDate"].ToString());
                        cmd1.Parameters.Add("@INSERTCOUNT", SqlDbType.BigInt).Value = Convert.ToInt64(dtDlr.Rows[0]["INSERTCOUNT"].ToString());
                        cmd1.Parameters.Add("@UPDATECOUNT", SqlDbType.BigInt).Value = Convert.ToInt64(dtDlr.Rows[0]["UPDATECOUNT"].ToString());

                        //cmd1.Parameters.Add("@SALESDATE", SqlDbType.DateTime).Value = Convert.ToDateTime(dtTemp.Rows[i]["dDate"].ToString());
                        //cmd1.Parameters.Add("@INSERTCOUNT", SqlDbType.BigInt).Value = Convert.ToInt64(dtDlr.Rows[0]["INSERTCOUNT"].ToString());
                        //cmd1.Parameters.Add("@UPDATECOUNT", SqlDbType.DateTime).Value = Convert.ToDateTime(dtDlr.Rows[0]["UPDATECOUNT"].ToString());
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
        private void pnlFalse()
        {
            pnlSelectFile.Visible = false;
            pnlValidate.Visible = false;
            pnlUploadDet.Visible = false;
        }

        private void LoadErrorFile()
        {
            try
            {
                if (dtFailedData.Rows.Count > 0)
                {
                    gvErrorData.DataSource = dtFailedData;
                    lnkDownloadErrorFile.Enabled = true;
                }
                else
                {
                    gvErrorData.DataSource = string.Empty;
                    lnkDownloadErrorFile.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadUploadDet()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_INSERTDEALERUPDATELOG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 5;
                cmd.Parameters.Add("@FROMDATE", SqlDbType.Date).Value = dpFromDate.Value;
                cmd.Parameters.Add("@TILLDATE", SqlDbType.Date).Value = dpTillDate.Value;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvUploadDet.DataSource = dt;
                }
                else
                    gvUploadDet.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            pnlFalse();
            Validate();
            pnlValidate.Visible = true;
            pnlValidate.Location = new Point(190, 130);
        }

        private void btnUploaddet_Click(object sender, EventArgs e)
        {
            pnlFalse();
            pnlUploadDet.Visible = true;

            DateTime now = new DateTime();
           // dpFromDate.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day);
            //dpTillDate.Value = Convert.ToDateTime(DateTime.Today.ToString("dd-MM-yyyy"));
            LoadUploadDet();
            pnlUploadDet.Location = new Point(190, 130);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlFalse();
            SetAsFirst();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           // lblwaitmsg.Visible = true;
           
            
            //pgbUpload.PerformStep();
            pgbUpload.Visible = true;
            timer1.Enabled = true;
            pgbUpload.Visible = true;
            btnUpload.Enabled = false;
            btnCancel.Enabled = false;
            dpSalesDate.Enabled = false;
            BtnSelectFile.Enabled = false;
            btnValidate.Enabled = false;
            try
            {
                if (dtSuccessData.Rows.Count > 0)
                {

                    SqlCommand cmd = new SqlCommand("truncate table CG_DealerUpload", con);
                    cmd.CommandType = CommandType.Text;                    
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    cmd.ExecuteNonQuery();

                    SqlBulkCopy objbulk = new SqlBulkCopy(con);
                    objbulk.DestinationTableName = "CG_DealerUpload";                   
                    objbulk.ColumnMappings.Add("CUSTOMERCODE", "CUSTOMERCODE");                    
                    objbulk.ColumnMappings.Add("CUSTOMERNAME", "CUSTOMERNAME");
                    objbulk.ColumnMappings.Add("DDate", "DDate");
                    objbulk.ColumnMappings.Add("REGION", "REGION");
                    objbulk.ColumnMappings.Add("ZONE", "ZONE");
                    objbulk.ColumnMappings.Add("DEPOTNAME", "DEPOTNAME");
                    objbulk.ColumnMappings.Add("DEPOT", "DEPOT");
                    objbulk.ColumnMappings.Add("DLRSTART", "DLRSTART");
                    objbulk.ColumnMappings.Add("POST", "POST");
                    objbulk.ColumnMappings.Add("CGActive", "CGActive");
                    objbulk.ColumnMappings.Add("AreaUnitCode", "AreaUnitCode");
                    objbulk.ColumnMappings.Add("DealerType", "DealerType");
                    objbulk.ColumnMappings.Add("DistributorName", "DistributorName");
                    objbulk.ColumnMappings.Add("DistributorCode", "DistributorCode");
                    objbulk.ColumnMappings.Add("SOCode", "SOCode");
                    objbulk.ColumnMappings.Add("SOName", "SOName");

                    if (ConnectionState.Open != con.State)
                        con.Open();
                    objbulk.BulkCopyTimeout = 0;
                    objbulk.WriteToServer(dtSuccessData);

                    if (ConnectionState.Closed != con.State)
                        con.Close();

                    if (fcount > 0)
                    {
                        InsetFileLog("FD");
                    }
                    else
                    {
                        InsetFileLog("SC");
                    }

                    UpdateDealer();
                    pgbUpload.MarqueeAnimationSpeed = 0;
                    timer1.Enabled = false;
                    pgbUpload.Visible = false;
                    MessageBox.Show("File has been uploaded successfully!");
                    //DealerDet();
                }
                else
                    MessageBox.Show("Error on Upload the file!");
            }
            catch (Exception ex)
            {
                InsetFileLog("FD");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SetAsFirst();
                pnlFalse();
                pnlUploadDet.Visible = true;
                DateTime now = new DateTime();
               // dpFromDate.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day);
               // dpTillDate.Value = DateTime.Today;
                LoadUploadDet();

                pnlUploadDet.Location = new Point(190, 130);
              //  lblwaitmsg.Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadUploadDet();
        }
        //private void DealerDet()
        //{
        //    try
        //    {
        //        if (dtDealers.Rows.Count > 0)
        //        {
        //            DataTable dtDlrs = new DataTable();
        //            DataView dv = new DataView(dtDealers);
        //            dtDlrs = dv.ToTable(true, "DealerCode", "DealerName");
        //            if (dtDlrs.Rows.Count > 0)
        //            {
        //                var lines = new List<string>();
        //                string[] columnNames = dtDealers.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
        //                var header = string.Join(",", columnNames);
        //                lines.Add(header);
        //                var valueLines = dtDealers.AsEnumerable()
        //                                   .Select(row => string.Join(",", row.ItemArray));
        //                lines.AddRange(valueLines);
        //                string DealerDetFile = Application.StartupPath + @"\DealerDetails\dealerdetails_" + DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + ".csv";
        //                File.WriteAllLines(DealerDetFile, lines);
        //                MessageBox.Show("Dealer details has been saved in " + DealerDetFile);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //}

        private void lnkDownloadErrorFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dtFailedData.Rows.Count > 0)
                {
                    var lines = new List<string>();

                    string[] columnNames = dtFailedData.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();

                    var header = string.Join(",", columnNames);
                    lines.Add(header);

                    var valueLines = dtFailedData.AsEnumerable()
                                       .Select(row => string.Join(",", row.ItemArray));
                    lines.AddRange(valueLines);
                    string ErrFile = Application.StartupPath + @"\ErrorFiles\PrimarySalesFailed_" + DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + ".csv";
                    File.WriteAllLines(ErrFile, lines);
                    MessageBox.Show("Error data have been saved in " + ErrFile);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void pbHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnBulkUpload_Click(object sender, EventArgs e)
        {
            //FrmUpload bulkupload = new FrmUpload();
            //bulkupload.Show();
            //this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbUpload.Value < pgbUpload.Maximum)
            {
                pgbUpload.PerformStep();
            }
            else
            {
                timer1.Enabled = false;
                pgbUpload.Visible = false;
            }
        }
     
    }
}
