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
    public partial class FrmUpload : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMART"].ToString());
        public static DataTable dtFailedData = new DataTable();
        public static DataTable dtDealers = new DataTable();
        string fname, salesdate, path;
        string[] files;

        Int64 fcount = 0, scount = 0, tcount = 0, sfcount = 0, ffcount = 0, ifcount = 0;
        public FrmUpload()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            lblFailedFiles.Text = "0";
            lblNooffiles.Text = "0";
            lblUploadedFiles.Text = "0";
            lblinvalidfile.Text = "0";
            lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm");

        }
        protected void InsertRecords(DataTable dtRecords)
        {
            try
            {
                SqlBulkCopy objbulk = new SqlBulkCopy(con);
                objbulk.DestinationTableName = "CG_PrimarySalesUpload";
                objbulk.ColumnMappings.Add("DealerCode", "DealerCode");
                objbulk.ColumnMappings.Add("DealerName", "DealerName");
                objbulk.ColumnMappings.Add("SalesDate", "SalesDate");
                objbulk.ColumnMappings.Add("ProductCode", "ProductCode");
                objbulk.ColumnMappings.Add("PrdtGrpCode", "PrdtGrpCode");
                objbulk.ColumnMappings.Add("PrdtGrpName", "PrdtGrpName");
                objbulk.ColumnMappings.Add("Points", "Points");
                objbulk.ColumnMappings.Add("UploadedOn", "UploadedOn");
                if (ConnectionState.Open != con.State)
                    con.Open();
                objbulk.WriteToServer(dtRecords);
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

                UpdateDealer(dtRecords);
                LoadFileDet();
            }
            catch (Exception ex)
            {
                InsetFileLog("FD");
                UpdateDealer(dtRecords);
                LoadFileDet();
            }
        }
        protected void InsetFileLog(string status)
        {
            DateTime saldate;
            try
            {
                try
                {
                    if (string.IsNullOrEmpty(salesdate))
                    {
                        string s1, s2;
                        string[] sdate = fname.Split(' ');
                        salesdate = sdate[1].Remove(8, 4);
                        s1 = salesdate.Insert(2, "-");
                        s2 = s1.Insert(5, "-");
                        salesdate = s2;
                    }
                    saldate = Convert.ToDateTime(salesdate);
                }
                catch (Exception)
                {
                    saldate = DateTime.Now;
                }

                SqlCommand cmd = new SqlCommand("SP_INSERTPRMYSALESLOG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@SalesDate", SqlDbType.Date).Value = saldate;
                cmd.Parameters.Add("@InputFile", SqlDbType.VarChar).Value = fname;
                cmd.Parameters.Add("@DataCount", SqlDbType.BigInt).Value = tcount;
                cmd.Parameters.Add("@UploadedCount", SqlDbType.BigInt).Value = scount;
                cmd.Parameters.Add("@FailedCount", SqlDbType.BigInt).Value = fcount;
                cmd.Parameters.Add("@Status", SqlDbType.Char).Value = status;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                if (con.State != ConnectionState.Closed)
                    con.Close();
                if (status.Equals("SC"))
                {
                    sfcount = sfcount + 1;
                    if (!File.Exists(Application.StartupPath + @"\UploadedFiles\" + fname))
                    {
                        File.Move(path + @"\" + fname, Application.StartupPath + @"\UploadedFiles\" + fname);
                    }
                    else
                    {
                        File.Delete(Application.StartupPath + @"\UploadedFiles\" + fname);
                        File.Move(path + @"\" + fname, Application.StartupPath + @"\UploadedFiles\" + fname);
                    }
                }
                else if (status.Equals("FD"))
                {
                    ffcount = ffcount + 1;
                    if (!File.Exists(Application.StartupPath + @"\ErrorFiles\" + fname))
                    {
                        File.Move(path + @"\" + fname, Application.StartupPath + @"\ErrorFiles\" + fname);
                    }
                    else
                    {
                        File.Delete(Application.StartupPath + @"\ErrorFiles\" + fname);
                        File.Move(path + @"\" + fname, Application.StartupPath + @"\ErrorFiles\" + fname);
                    }
                }
            }
            catch (Exception ex)
            {
                //File.Move(path + @"\" + fname, Application.StartupPath + @"\ErrorFiles\" + fname);
            }

        }
        protected void UpdateDealer(DataTable dtRecords)
        {
            try
            {
                DataView dv = new DataView(dtRecords);
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
                        dtDealers.Columns.Clear();
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

                        //For update the product code
                        SqlCommand cmd1 = new SqlCommand("SP_DEALERDETUPDATE", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("@IMODE", SqlDbType.Int).Value = 2;
                        cmd1.Parameters.Add("@SALESDATE", SqlDbType.DateTime).Value = Convert.ToDateTime(dtTemp.Rows[i]["SalesDate"]);
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
        private void LoadFileDet()
        {
            string filename = "";
            try
            {
                foreach (string file in files)
                {
                    string finame = Path.GetFileName(file);
                    filename = filename + finame + ",";
                }
                filename = filename.Remove(filename.Length - 1, 1);
                SqlCommand cmd = new SqlCommand("SP_INSERTPRMYSALESLOG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 3;
                cmd.Parameters.Add("@FILES", SqlDbType.VarChar).Value = filename;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvFileUpload.DataSource = dt;
                }
                else
                {
                    dgvFileUpload.Rows.Clear();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void StartUpload()
        {
            string[] items = new string[6];
            DataTable dt = new DataTable();
            string ErrFile = null, DealerDetFile = null;

            try
            {
                System.Threading.Thread.Sleep(1000);
                //path = @"D:\murugan\IS new\PrimarySales\SInbox";
                // string path1 = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                path = Application.StartupPath + @"\SInbox";
                files = Directory.GetFiles(path, "*.csv");
                if (files.Length == 0)
                {
                    MessageBox.Show("File not found!");
                    btnStartUpload.Enabled = true;
                    return;
                }
                dt.Columns.Clear();
                dt.Columns.Add("DealerCode");
                dt.Columns.Add("DealerName");
                dt.Columns.Add("SalesDate");
                dt.Columns.Add("ProductCode");
                dt.Columns.Add("PrdtGrpCode");
                dt.Columns.Add("PrdtGrpName");
                dt.Columns.Add("Points");
                dt.Columns.Add("UploadedOn");

                dtFailedData.Columns.Clear();
                dtFailedData.Columns.Add("S_No");
                dtFailedData.Columns.Add("FileName");
                dtFailedData.Columns.Add("DealerCode");
                dtFailedData.Columns.Add("DealerName");
                dtFailedData.Columns.Add("SalesDate");
                dtFailedData.Columns.Add("PrdtGrpCode");
                dtFailedData.Columns.Add("PrdtGrpName");
                dtFailedData.Columns.Add("Points");
                //filefullpath = path + files[0];
                lblNooffiles.Text = files.Length.ToString();

                pgbUpload.Minimum = 0;
                pgbUpload.Value = 0;
                pgbUpload.Maximum = files.Length;
                pgbUpload.Step = 1;
                pgbUpload.Visible = true;
                // pgbUpload.CreateGraphics().DrawString(sfcount.ToString() + " files uploaded!", new Font("Verdana", (float)10, FontStyle.Bold), Brushes.Red, new PointF(pgbUpload.Width / 2 - 20, pgbUpload.Height / 2 - 7));
                foreach (string filedata in files)
                {
                    pgbUpload.PerformStep();
                    pgbUpload.BeginInvoke(new Action(() => pgbUpload.Value = Convert.ToInt32(sfcount)));
                    pgbUpload.CreateGraphics().DrawString(sfcount.ToString() + " files uploaded!", new Font("Verdana", (float)10, FontStyle.Bold), Brushes.Red, new PointF(pgbUpload.Width / 2 - 20, pgbUpload.Height / 2 - 7));
                    tcount = 0; scount = 0; fcount = 0;
                    dt.Rows.Clear();
                    bool isFirst = true;
                    fname = Path.GetFileName(filedata);
                    DataTable dtFile = new DataTable();
                    try
                    {
                        string s1, s2;
                        string[] sdate = fname.Split(' ');
                        if (!sdate[0].Equals("prmsale"))
                        {
                            MessageBox.Show("Invalid file name : " + fname + ". Please check the file name(prmsale ddmmyyyy.csv) ex. prmsale 31012016.csv");
                            ifcount = ifcount + 1;
                            continue;
                        }
                        salesdate = sdate[1].Remove(8, 4);
                        s1 = salesdate.Insert(2, "-");
                        s2 = s1.Insert(5, "-");
                        salesdate = s2;
                        DateTime saldate = Convert.ToDateTime(salesdate);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid file name  : " + fname + ". Please check the file name(prmsale ddmmyyyy.csv) ex. prmsale 31012016.csv");
                        ifcount = ifcount + 1;
                        continue;
                    }
                    SqlCommand cmdFileCheck = new SqlCommand("SP_INSERTPRMYSALESLOG", con);
                    cmdFileCheck.CommandType = CommandType.StoredProcedure;
                    cmdFileCheck.Parameters.Add("@IMODE", SqlDbType.Int).Value = 6;
                    cmdFileCheck.Parameters.Add("@SALESDATE", SqlDbType.Date).Value = Convert.ToDateTime(salesdate);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmdFileCheck.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                        con.Close();

                    //SqlDataAdapter sda = new SqlDataAdapter(cmdFileCheck);
                    //sda.Fill(dtFile);
                    //if (dtFile != null && dtFile.Rows.Count > 0)
                    //{
                    //    if (dtFile.Rows[0]["STATUS"].ToString() == "SC")
                    //    {
                    //        MessageBox.Show(fname + " file is already uploaded on : " + dtFile.Rows[0]["UPLOADEDON"].ToString());
                    //        ifcount = ifcount + 1;
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show(fname + " file is already uploaded on : " + dtFile.Rows[0]["UPLOADEDON"].ToString() + ". Please delete that file and upload again");
                    //        ifcount = ifcount + 1;
                    //    }
                    //    continue;
                    //}

                    string data = File.ReadAllText(filedata);
                    foreach (string dataRow in data.Split('\n'))
                    {

                        try
                        {
                            string dataRow1 = dataRow.Replace('"', ' ');
                            if (!string.IsNullOrEmpty(dataRow1))
                            {
                                salesdate = "";
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
                                        items[3] = "00";
                                        items[4] = FileRec[4];
                                        items[5] = FileRec[5];
                                        items[6] = FileRec[6];
                                    }
                                    else
                                    {
                                        items[0] = FileRec[0];
                                        items[1] = FileRec[1];
                                        items[2] = FileRec[2];
                                        items[3] = "00";
                                        items[4] = FileRec[3];
                                        items[5] = FileRec[4];
                                        items[6] = FileRec[5];
                                    }
                                    if (string.IsNullOrEmpty(items[0]) || string.IsNullOrEmpty(items[2]))
                                    {
                                        dtFailedData.Rows.Add();
                                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["S_No"] = (tcount + 1).ToString();
                                        dtFailedData.Rows[dtFailedData.Rows.Count - 1]["FileName"] = fname;
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
                                    dt.Rows.Add();
                                    for (int j = 0; j < items.Length; j++)
                                    {
                                        if (j == 2)
                                        {
                                            if (string.IsNullOrEmpty(items[j].Trim()))
                                                dt.Rows[dt.Rows.Count - 1][j] = DateTime.Now;
                                            else
                                                dt.Rows[dt.Rows.Count - 1][j] = Convert.ToDateTime(items[j]);
                                        }
                                        else if (j == 6)
                                        {
                                            if (string.IsNullOrEmpty(items[j].Trim()))
                                                dt.Rows[dt.Rows.Count - 1][j] = "0";
                                            else
                                                dt.Rows[dt.Rows.Count - 1][j] = items[j];
                                        }
                                        else
                                        {
                                            dt.Rows[dt.Rows.Count - 1][j] = items[j].Trim();
                                        }
                                    }
                                    dt.Rows[dt.Rows.Count - 1]["UploadedOn"] = DateTime.Now.ToString();
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
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["FileName"] = fname;
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerCode"] = items[0];
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["DealerName"] = items[1];
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["SalesDate"] = items[2];
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["PrdtGrpCode"] = items[3];
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["PrdtGrpName"] = items[4];
                            dtFailedData.Rows[dtFailedData.Rows.Count - 1]["Points"] = items[5];

                            fcount = fcount + 1;
                        }

                    }
                    if (fcount == 0)
                        InsertRecords(dt);

                }
                if (dtFailedData.Rows.Count > 0)
                {
                    var lines = new List<string>();

                    string[] columnNames = dtFailedData.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();

                    var header = string.Join(",", columnNames);
                    lines.Add(header);

                    var valueLines = dtFailedData.AsEnumerable()
                                       .Select(row => string.Join(",", row.ItemArray));
                    lines.AddRange(valueLines);
                    ErrFile = Application.StartupPath + @"\ErrorFiles\PrimarySalesFailed_" + DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + ".csv";
                    File.WriteAllLines(ErrFile, lines);
                }
                if (dtDealers.Rows.Count > 0)
                {
                    DataTable dtDlrs = new DataTable();
                    DataView dv = new DataView(dtDealers);
                    dtDlrs = dv.ToTable(true, "DealerCode", "DealerName");
                    if (dtDlrs.Rows.Count > 0)
                    {
                        var lines = new List<string>();

                        string[] columnNames = dtDealers.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();

                        var header = string.Join(",", columnNames);
                        lines.Add(header);

                        var valueLines = dtDealers.AsEnumerable()
                                           .Select(row => string.Join(",", row.ItemArray));
                        lines.AddRange(valueLines);
                        DealerDetFile = Application.StartupPath + @"\DealerDetails\dealerdetails_" + DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + ".csv";
                        File.WriteAllLines(DealerDetFile, lines);
                    }

                }
                //try
                //{
                //    string filename = "",dfile=null,efile=null;
                //    if ((!string.IsNullOrEmpty(DealerDetFile)) || (!string.IsNullOrEmpty(ErrFile)))
                //    {
                //        if (!string.IsNullOrEmpty(DealerDetFile))
                //            dfile = Path.GetFileName(DealerDetFile);
                //        if (!string.IsNullOrEmpty(ErrFile))
                //            efile = Path.GetFileName(ErrFile);
                //        foreach (string file in files)
                //        {
                //            string finame = Path.GetFileName(file);
                //            filename = filename + finame + ",";
                //        }
                //        filename = filename.Remove(filename.Length - 1, 1);
                //        SqlCommand cmd = new SqlCommand("SP_INSERTPRIMARYSALESLOG", con);
                //        cmd.Parameters.Add("@IMODE", SqlDbType.Int).Value = 4;
                //        cmd.Parameters.Add("@ERRFILE", SqlDbType.VarChar).Value = efile;
                //        cmd.Parameters.Add("@DEALERDETFILE", SqlDbType.VarChar).Value = dfile;
                //        cmd.Parameters.Add("@FILE", SqlDbType.VarChar).Value = filename;
                //        if (con.State == ConnectionState.Closed)
                //            con.Open();
                //        cmd.ExecuteNonQuery();
                //        if (con.State == ConnectionState.Open)
                //            con.Close();
                //    }
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show("Error on Upload the Error File and DealerDetails File!");
                //}
                pgbUpload.Visible = false;
                MessageBox.Show("File uploaded");
                lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm");
                lblFailedFiles.Text = ffcount.ToString();
                lblUploadedFiles.Text = sfcount.ToString();
                lblinvalidfile.Text = ifcount.ToString();
                btnStartUpload.Enabled = true;
            }
            catch (Exception ex)
            {
                ffcount = ffcount + 1;
                InsetFileLog("FD");
                MessageBox.Show("Error on File uploaded - " + fname);
                lblDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm");
                lblFailedFiles.Text = ffcount.ToString();
                lblUploadedFiles.Text = sfcount.ToString();
                lblinvalidfile.Text = ifcount.ToString();
                btnStartUpload.Enabled = true;
            }
        }

        private void btnStartUpload_Click(object sender, EventArgs e)
        {
            btnStartUpload.Enabled = false;
            StartUpload();
        }

        private void btnDailyUpload_Click(object sender, EventArgs e)
        {
            FrmSDailyUpload1 dailyUpload = new FrmSDailyUpload1();
            dailyUpload.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

