using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using PassportSystem; 

namespace PassengerInformationSystem
{
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }


        private void login(string userid, string password)
        {
            
            ClsConnections.CN.Close();
            ClsConnections.CN.Open();
            OleDbCommand select = new OleDbCommand();
            select.Connection = ClsConnections.CN;
            select.CommandText = "select * from tbllogin where userid='" + userid.Trim().ToLower() + "' and password='" + password.Trim().ToLower() + "' ";
            OleDbDataReader reader = select.ExecuteReader();
            if (reader.Read())
            {
                Users.User = userid;
                //MessageBox.Show("Please Enter Correct Passenger Passport Details", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmMDI frm = new frmMDI();
                frm.Show();
                this.Hide();
                ClsConnections.CN.Close();
                

            }
            else
            {
                MessageBox.Show("Invalid Login Details");
                txtUserID.Text = "";
                txtPassword.Text = "";
                txtUserID.Focus();
                ClsConnections.CN.Close();
               
            
            }
                 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login(txtUserID.Text.ToLower(), txtPassword.Text.ToLower());
        }

        private void frmLogin2_Load(object sender, EventArgs e)
        {
             ClsConnections conn = new ClsConnections();
            conn.setConnection("C:" + "\\Database\\", "PassportSystem.mdb", "lib2006");
            txtUserID.Focus();
            this.ActiveControl = txtUserID;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
        }

        private void frmLogin2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
