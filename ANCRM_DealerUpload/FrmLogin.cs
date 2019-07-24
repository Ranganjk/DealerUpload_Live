using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANCRM_DealerUpload
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" || txtPassword.Text == "")
            {
                lblError.Text = "Please enter username and password!";
            }
            else if(txtUsername.Text.ToLower() == "admin" && txtPassword.Text == "1nn0v$")
            {
                this.Hide();
                //FrmUpload upload = new FrmUpload();
                //upload.Show();
                FrmSDailyUpload1 DlyUpld = new FrmSDailyUpload1();
                DlyUpld.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username and password!";
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
