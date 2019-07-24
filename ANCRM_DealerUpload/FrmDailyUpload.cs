using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANCRM_DealerUpload
{
    public partial class FrmDailyUpload : Form
    {
        #region "Declaration"
 SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMART"].ToString());
        public static DataTable dtSuccessData = new DataTable();
        public static DataTable dtFailedData = new DataTable();
        public static DataTable dtDealers = new DataTable();
        int tcount = 0, scount = 0, fcount = 0;
        string salesdate;
        #endregion
       
        public FrmDailyUpload()
        {
            InitializeComponent();            
        }

        private void FrmDailyUpload_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.MaximizeBox = true;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            pbHeader.Width = this.Width;
            LoadUploadDet();
            SetAsFirst();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            lblSalesDateError.Visible = false;
            string msg = CheckSalesDate();
            if (msg.Equals("Ok"))
            {
                string filter = "PrimarySales(.csv)|prmsale " + dpSalesDate.Value.ToString("ddMMyyyy") + ".csv";
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

        private string CheckSalesDate()
        {
            string msg = "Ok";
            try
            {
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM CG_PRIMARYSALESLOG WHERE SALESDATE='" + dpSalesDate.Value.ToString("dd MMM yyyy") + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    msg = "The Sales data have been already uploaded for this date. Please check this sales date";
                }
                return msg;
            }
            catch (Exception ex)
            {
                return msg;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            gbValidate.Visible = true;
            Validate();
        }
        private void Validate()
        {
            string[] items = new string[6];
            string path = null;
            try
            {
                path = Application.StartupPath + @"\SInbox\" + lblFname.Text;
                if (!File.Exists(path)) 
                    File.Create(path);
                File.Copy(lblFilePath.Text, path, true);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            try
            {
                if (dtSuccessData.Columns.Count == 0)
                {
                    dtSuccessData.Columns.AddRange(new DataColumn[7] { new DataColumn("DealerCode", typeof(string)),
                        new DataColumn("DealerName", typeof(string)),
                        new DataColumn("SalesDate", typeof(string)),
                        new DataColumn("PrdtGrpCode", typeof(string)),
                        new DataColumn("PrdtGrpName", typeof(string)),
                        new DataColumn("Points", typeof(double)),
                        new DataColumn("UploadedOn", typeof(string))});

                    //dtSuccessData.Columns.Add("DealerCode");
                    //dtSuccessData.Columns.Add("DealerName");
                    //dtSuccessData.Columns.Add("SalesDate");
                    //dtSuccessData.Columns.Add("PrdtGrpCode");
                    //dtSuccessData.Columns.Add("PrdtGrpName");
                    //dtSuccessData.Columns.Add("Points");
                    //dtSuccessData.Columns.Add("UploadedOn");
                }
                if (dtFailedData.Columns.Count == 0)
                {
                    dtFailedData.Columns.Add("S_No");
                    dtFailedData.Columns.Add("FileName");
                    dtFailedData.Columns.Add("DealerCode");
                    dtFailedData.Columns.Add("DealerName");
                    dtFailedData.Columns.Add("SalesDate");
                    dtFailedData.Columns.Add("PrdtGrpCode");
                    dtFailedData.Columns.Add("PrdtGrpName");
                    dtFailedData.Columns.Add("Points");
                }

                tcount = 0; scount = 0; fcount = 0;
                dtFailedData.Rows.Clear();
                dtSuccessData.Rows.Clear();
                bool isFirst = true;
                string data = File.ReadAllText(path);
                foreach (string dataRow in data.Split('\n'))
                {

                    try
                    {
                        string dataRow1 = dataRow.Replace('"', ' ');
                        if (!string.IsNullOrEmpty(dataRow1))
                        {
                            if (!isFirst)
                            {
                                tcount = tcount + 1;
                                int count = 0;
                                string[] FileRec = dataRow1.Split(',');
                                if (FileRec.Length == 7)
                                {
                                    items[0] = FileRec[0];
                                    items[1] = FileRec[1] + FileRec[2];
                                    items[2] = FileRec[3];
                                    items[3] = FileRec[4];
                                    items[4] = FileRec[5];
                                    items[5] = FileRec[6];
                                }
                                else
                                    items = FileRec;
                                if (string.IsNullOrEmpty(items[0]) || string.IsNullOrEmpty(items[2]))
                                {
                                    dtFailedData.Rows.Add();
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["S_No"] = (tcount + 1).ToString();
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["FileName"] = lblFname.Text;
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerCode"] = items[0];
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerName"] = items[1];
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["SalesDate"] = items[2];
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["PrdtGrpCode"] = items[3];
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["PrdtGrpName"] = items[4];
                                    dtFailedData.Rows[dtFailedData.Rows.Count - 1]["Points"] = items[5];
                                    fcount = fcount + 1;
                                    continue;
                                }
                                // salesdate = items[2];
                                dtSuccessData.Rows.Add();
                                for (int j = 0; j < items.Length; j++)
                                {
                                    if (j == 2)
                                    {
                                        if (string.IsNullOrEmpty(items[j].Trim()))
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = DateTime.Now;
                                        else
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = Convert.ToDateTime(items[j]);
                                    }
                                    else if (j == 5)
                                    {
                                        if (string.IsNullOrEmpty(items[j].Trim()))
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = 0;
                                        else
                                        {
                                            string points = items[j];
                                            string value = points.Remove(points.Length - 1);
                                            dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = Convert.ToDouble(value);

                                        }
                                    }
                                    else
                                    {
                                        dtSuccessData.Rows[dtSuccessData.Rows.Count - 1][j] = items[j].Trim();
                                    }
                                }
                                dtSuccessData.Rows[dtSuccessData.Rows.Count - 1]["UploadedOn"] = DateTime.Now.ToString();
                                scount = scount + 1;
                            }
                            else
                                isFirst = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        dtFailedData.Rows.Add();
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["S_No"] = (tcount + 1).ToString();
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["FileName"] = lblFname.Text;
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerCode"] = items[0];
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerName"] = items[1];
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["SalesDate"] = items[2];
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["PrdtGrpCode"] = items[3];
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["PrdtGrpName"] = items[4];
                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["Points"] = items[5];

                        fcount = fcount + 1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (dtSuccessData.Rows.Count > 0)
                    lblTotalPoints.Text = Convert.ToString(dtSuccessData.Compute("SUM(Points)", string.Empty));
                else
                    lblTotalPoints.Text = "0";
            }
            catch(Exception ex)
            {
                lblTotalPoints.Text = "0";
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
            if (fcount > 0)
                btnUpload.Enabled = false;
            else
                btnUpload.Enabled = true;
            dpSalesDate.Enabled = false;
            BtnSelectFile.Enabled = false;
            btnValidate.Enabled = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            btnUpload.Enabled = false;
            btnCancel.Enabled = false;
            dpSalesDate.Enabled = false;
            BtnSelectFile.Enabled = false;
            btnValidate.Enabled = false;

            try
            {
                if (dtSuccessData.Rows.Count > 0)
                {
                    SqlBulkCopy objbulk = new SqlBulkCopy(con);
                    objbulk.DestinationTableName = "CG_PrimarySalesUpload";
                    objbulk.ColumnMappings.Add("DealerCode", "DealerCode");
                    objbulk.ColumnMappings.Add("DealerName", "DealerName");
                    objbulk.ColumnMappings.Add("SalesDate", "SalesDate");
                    objbulk.ColumnMappings.Add("PrdtGrpCode", "PrdtGrpCode");
                    objbulk.ColumnMappings.Add("PrdtGrpName", "PrdtGrpName");
                    objbulk.ColumnMappings.Add("Points", "Points");
                    objbulk.ColumnMappings.Add("UploadedOn", "UploadedOn");
                    if (ConnectionState.Open != con.State)
                        con.Open();
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
                    MessageBox.Show("File has been uploaded successfully!");
                }
                else
                    MessageBox.Show("Error on Upload the file!");
                SetAsFirst();
            }
            catch (Exception ex)
            {
                InsetFileLog("FD");
                UpdateDealer();
                SetAsFirst();
                MessageBox.Show(ex.Message);
            }
        }

        protected void InsetFileLog(string status)
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("SP_INSERTPRMYSALESLOG", con);
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
                if (status.Equals("SC"))
                {
                    if (!File.Exists(Application.StartupPath + @"\UploadedFiles\" + lblFname.Text))
                    {
                        File.Move(lblFilePath.Text, Application.StartupPath + @"\UploadedFiles\" + lblFname.Text);
                    }
                    else
                    {
                        File.Delete(Application.StartupPath + @"\UploadedFiles\" + lblFname.Text);
                        File.Move(lblFilePath.Text, Application.StartupPath + @"\UploadedFiles\" + lblFname.Text);
                    }
                }
                else if (status.Equals("FD"))
                {
                    if (!File.Exists(Application.StartupPath + @"\ErrorFiles\" + lblFname.Text))
                    {
                        File.Move(lblFilePath.Text, Application.StartupPath + @"\ErrorFiles\" + lblFname.Text);
                    }
                    else
                    {
                        File.Delete(Application.StartupPath + @"\ErrorFiles\" + lblFname.Text);
                        File.Move(lblFilePath.Text, Application.StartupPath + @"\ErrorFiles\" + lblFname.Text);
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
                DataTable dtTemp = dv.ToTable(true, "SalesDate");
                for (int i = 0; i < dtTemp.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(dtTemp.Rows[i]["SalesDate"])))
                    {
                        SqlCommand cmd = new SqlCommand("SP_DEALERDETUPDATE", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@SALESDATE", SqlDbType.DateTime).Value = Convert.ToDateTime(dtTemp.Rows[i]["SalesDate"]);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dtDlr);
                        dtDealers = dtDlr;
                        dtDealers.Columns.Add("Contact_No");
                        dtDealers.Columns.Add("EMail_ID");
                        dtDealers.Columns.Add("Street");
                        dtDealers.Columns.Add("City");
                        dtDealers.Columns.Add("State");
                        dtDealers.Columns.Add("Postal_Code");
                        dtDealers.Columns.Add("Depot");
                        dtDealers.Columns.Add("Zone");
                        dtDealers.Columns.Add("Region");
                    }
                }
            }
            catch (Exception ex)
            {

            }
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
            catch(Exception ex)
            {

            }
        }

        private void lnkDownloadErrorFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dtFailedData.Rows.Count > 0)
                {
                    string data = "";
                    foreach (DataColumn col in dtFailedData.Columns)
                        data += col.ColumnName + ',';
                    foreach (DataRow row in dtFailedData.Rows)
                    {
                        data = "\r\n";
                        foreach (DataColumn col in dtFailedData.Columns)
                            data += row[col.ColumnName].ToString().Replace(",", ";") + ",";
                    }
                    
                    string filepath = Application.StartupPath + @"\ErrorFiles\FailedData_"+salesdate+".csv";
                    if (File.Exists(filepath))
                        File.Delete(filepath);
                    File.WriteAllText(filepath, data);
                    MessageBox.Show("Error Data has been saved as " + filepath + "!");
                }
                else
                {
                    MessageBox.Show("No records found!");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetAsFirst();
        }
        private void SetAsFirst()
        {
            BtnSelectFile.Enabled=true;
            dpSalesDate.Enabled=true;
            btnValidate.Enabled=false;
            btnCancel.Enabled=false;
            gvErrorData.DataSource=string.Empty;
            gbValidate.Visible = false;
            dtDealers.Rows.Clear();
            dtSuccessData.Rows.Clear();
            dtFailedData.Rows.Clear();
            lblFname.Text = "";
            lblFilePath.Text = "";
            lblSalesDate.Text = "";
            lblSalesDateError.Text="";
            lnkDownloadErrorFile.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadUploadDet()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_INSERTPRMYSALESLOG",con);
                cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 5;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    gvUploadDet.DataSource = dt;
                }
            }
            catch(Exception ex)
            {

            }
        }
    }

   
}
