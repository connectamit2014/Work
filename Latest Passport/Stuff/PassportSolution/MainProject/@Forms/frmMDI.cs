using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PassportSystem;

namespace PassengerInformationSystem
{
    public partial class frmMDI : Form
    {
        public bool IsChildOpened { get; set; }
        ClsConnections conn = new ClsConnections();

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

            
           
        }

        private void enterPassportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
            {
                MessageBox.Show("Please Enter Correct Passenger Passport Details","Information" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frmPassportEnter = new frmPassportEnter();
                frmPassportEnter.MdiParent = this;
                frmPassportEnter.Show();
              
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Dispose(true);


            }
        }
    }
}
