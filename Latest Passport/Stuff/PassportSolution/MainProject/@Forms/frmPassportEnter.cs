using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1.Cms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using PassportSystem;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.util;
namespace PassengerInformationSystem
{
    public partial class frmPassportEnter : Form
    {
        private static string countriesVisited = string.Empty;
        List<string> ListCountries = new List<string>();
        frmMDI frmMdi = new frmMDI();
        public string PNo = string.Empty;
        public bool isUpdated = false;
        public bool isFind = false;
        Excel.Application oXL;
        Excel.Workbook oWB;
        Excel.Worksheet oSheet;
        Excel.Range oRange;
        DataTable passportData = new DataTable();

        public frmPassportEnter()
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isUpdated = false;
            ClearValues();
        }

        private void ClearValues()
        {

            txtPNO.Clear();
            mskIssuedDate.Clear();
            txtFlightNo.Clear();
            mskArrivedDate.Clear();
            txtPOB.Clear();
            txtVisaNo.Clear();
            mskDateOfExp.Clear();
            mskDateOfDep.Clear();
            txtPOV.Clear();
            txtName.Clear();
            txtMiddleName.Clear();
            txtLastNme.Clear();
            mskDOB.Clear();
            cmbCount.SelectedIndex = 1;
            //            BindCountry();
            btnDeleted.Visible = false;
            btnPrint.Visible = true;
            btnSubmit.Text = "Save";
            //           BindPassportData();
            txtPNO.ReadOnly = false;
            txtPNO.BackColor = Color.White;
            //          BindCountryListBox();
            listSelectedCont.Items.Clear();
            btnFind.Enabled = true;
            txtAddress.Clear();
            txtRemarks.Clear();
            if (isUpdated == false) 
            { dgDetails.DataSource = null;
            btnPrint.Visible = false;
            }
            PNo = string.Empty;
            
            listSelectedCont.ClearSelected();






        }

        private void frmPassportEnter_Load(object sender, EventArgs e)
        {
            ClsConnections conn = new ClsConnections();
            conn.setConnection("C:" + "\\Database\\", "PassportSystem.mdb", "lib2006");
            BindCountry();
            BindPassportData();
            btnDeleted.Visible = false;

            BindCountryListBox();
            dgDetails.ReadOnly = true;
            conn.IsOpened = true;
            frmMdi.IsChildOpened = true;




        }

        private void ExportData()
        {
            // Start Excel and get Application object.
            oXL = new Excel.Application();

            // Set some properties
            oXL.Visible = true;
            oXL.DisplayAlerts = false;

            // Get a new workbook.
            oWB = oXL.Workbooks.Add(Missing.Value);

            // Get the active sheet
            oSheet = (Excel.Worksheet)oWB.ActiveSheet;
            oSheet.Name = "PassengerData";

            // Process the DataTable
            // BE SURE TO CHANGE THIS LINE TO USE *YOUR* DATATABLE
            DataTable dt = passportData;

            if (dt.Rows.Count > 0)
            {
                int rowCount = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    rowCount += 1;
                    for (int i = 1; i < dt.Columns.Count + 1; i++)
                    {
                        // Add the header the first time through
                        if (rowCount == 2)
                        {
                            oSheet.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                        }
                        oSheet.Cells[rowCount, i] = dr[i - 1].ToString();
                    }
                }


                // Resize the columns
                //oRange = oSheet.get_Range(oSheet.Cells[1, 1],
                //              oSheet.Cells[rowCount, dt.Columns.Count]);
                //oRange.EntireColumn.AutoFit();

                // Save the sheet and close
                oSheet = null;
                oRange = null;
                oWB.SaveAs("PassengerData.xls", Excel.XlFileFormat.xlWorkbookNormal,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Excel.XlSaveAsAccessMode.xlExclusive,
                    Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);
                //oWB.Close(Missing.Value, Missing.Value, Missing.Value);
                //oWB = null;
                //oXL.Quit();

                // Clean up
                // NOTE: When in release mode, this does the trick
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();


















            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listSelectedCont.Items.Count; i++)
            {
                var country = listSelectedCont.Items[i];
                if (i == 0)
                { countriesVisited = country.ToString(); }
                else { countriesVisited = string.Concat(countriesVisited, ",", country); }
            }
            if (listSelectedCont.Items.Count != 0)
            {
                listSelectedCont.SetSelected(0, true);
            }
            if (txtPNO.Text == String.Empty || mskIssuedDate.Text == String.Empty || txtFlightNo.Text == String.Empty || listSelectedCont.Text == "" || mskArrivedDate.Text == String.Empty || txtPOB.Text == String.Empty || txtVisaNo.Text == String.Empty || mskDateOfExp.Text == String.Empty || mskDateOfDep.Text == String.Empty || txtPOV.Text == String.Empty || txtName.Text == String.Empty || txtMiddleName.Text == string.Empty || txtLastNme.Text == String.Empty || mskDOB.Text == String.Empty)
            {
                MessageBox.Show("Enter proper values", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.Compare(btnSubmit.Text, "save", true) == 0)
                {

                    
                    DialogResult dr = MessageBox.Show("Are you sure you want to save changes?", "Confirm Insert", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand oledbAdd =
                            new OleDbCommand("INSERT INTO tblPassport(PassportNumber,IssuedDate,FlightNo,ArrivedDate,CountVisitLastSixDays,PortOfBoarding,VisaNo,DateOfExpiring,ExpectDateOfDep,PurposeOfVisit,FirstName,LastName,Sex,DateOfBirth,Country,IsDeleted,Address,Remarks,MiddleName) VALUES('" + txtPNO.Text + "','" + mskIssuedDate.Text + "','" + txtFlightNo.Text + "','" + mskArrivedDate.Text + "','" + countriesVisited + "','" + txtPOB.Text + "','" + txtVisaNo.Text + "','" + mskDateOfExp.Text + "','" + mskDateOfDep.Text + "','" + txtPOV.Text + "','" + txtName.Text + "','" + txtLastNme.Text + "','" + cmbSex.Text + "','" + mskDOB.Text + "','" + cmbCount.Text + "','" + "0" + "','" + txtAddress.Text + "','" + txtRemarks.Text + "','" + txtMiddleName.Text + "')", ClsConnections.CN);
                        oledbAdd.CommandType = CommandType.Text;
                        OleDbDataAdapter oledbData = new OleDbDataAdapter(oledbAdd);
                        oledbAdd.ExecuteNonQuery();

                        MessageBox.Show("Records Successully added");
                        BindCountry();
                        BindPassportData();
                        BindCountryListBox();
                        isUpdated = true;
                        ClearValues();
                    }
                    else
                    {
                        ClearValues();

                    }

                }
                else
                {                   
                    DialogResult dr = MessageBox.Show("Are you sure you want to save changes?", "Confirm Update", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand oledbAdd =
                       new OleDbCommand("update  tblPassport set IssuedDate='" + mskIssuedDate.Text + "',FlightNo='" + txtFlightNo.Text + "',ArrivedDate='" + mskArrivedDate.Text + "',CountVisitLastSixDays='" + countriesVisited + "',PortOfBoarding='" + txtPOB.Text + "',VisaNo='" + txtVisaNo.Text + "',DateOfExpiring='" + mskDateOfExp.Text + "',ExpectDateOfDep='" + mskDateOfDep.Text + "',PurposeOfVisit='" + txtPOV.Text + "',FirstName='" + txtName.Text + "',MiddleName='" + txtMiddleName.Text + "',LastName='" + txtLastNme.Text + "',Sex='" + cmbSex.Text + "',DateOfBirth='" + mskDOB.Text + "',Country='" + cmbCount.Text + "',Address='" + txtAddress.Text + "',Remarks='" + txtRemarks.Text + "' where id=" + lblID.Text + " ", ClsConnections.CN);
                        oledbAdd.CommandType = CommandType.Text;
                        OleDbDataAdapter oledbData = new OleDbDataAdapter(oledbAdd);
                        oledbAdd.ExecuteNonQuery();

                        MessageBox.Show("Records Successully updated");
                        BindCountry();
                        BindPassportData();
                        BindCountryListBox();
                        isUpdated = true;
                        ClearValues();

                    }
                    else
                    {
                        //ClearValues();
                    }


                }
            }
        }


        private void BindPassportData()
        {
            string sqlquery = string.Empty;
            string pn = txtPNO.Text == string.Empty ? Convert.ToString(0) : txtPNO.Text;

            if (PNo == string.Empty)
            {
                sqlquery = "select * from tblPassport where IsDeleted='" + "0" + "' and passportnumber='" + pn.Trim() + "' ";
            }
            else
            {
                sqlquery = "select * from tblPassport where IsDeleted='" + "0" + "' and passportnumber='" + pn.Trim() + "' ";

            }


            OleDbDataAdapter da = new OleDbDataAdapter(sqlquery, ClsConnections.CN);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnPrint.Visible = true;
            }

            //if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                dgDetails.DataSource = ds.Tables[0];
                passportData = ds.Tables[0];



                dgDetails.Columns[0].Visible = false;
                dgDetails.Columns[16].Visible = false;
                dgDetails.Columns[1].HeaderText = "Passport No";
                dgDetails.Columns[1].Width = 60;

                dgDetails.Columns[2].HeaderText = "Issued Date";
                dgDetails.Columns[2].Width = 63;

                dgDetails.Columns[3].HeaderText = "Flight No";
                dgDetails.Columns[3].Width = 60;

                dgDetails.Columns[4].HeaderText = "Arrived Date";
                dgDetails.Columns[4].Width = 63;

                dgDetails.Columns[5].HeaderText = "Last Six Countries Visited";
                dgDetails.Columns[5].Width = 70;

                dgDetails.Columns[6].HeaderText = "Boarding Port";
                dgDetails.Columns[6].Width = 60;

                dgDetails.Columns[7].HeaderText = "Visa No";
                dgDetails.Columns[7].Width = 60;

                dgDetails.Columns[8].HeaderText = "Passport Expiration Date";
                dgDetails.Columns[8].Width = 63;

                dgDetails.Columns[9].HeaderText = "Departure Date";
                dgDetails.Columns[9].Width = 63;

                dgDetails.Columns[10].HeaderText = "Visit's Purpose";
                dgDetails.Columns[10].Width = 63;

                dgDetails.Columns[11].HeaderText = "First Name";
                dgDetails.Columns[11].Width = 60;

                dgDetails.Columns[12].HeaderText = "Middle Name";
                dgDetails.Columns[12].Width = 60;


                dgDetails.Columns[13].HeaderText = "Last Name";
                dgDetails.Columns[13].Width = 60;

                dgDetails.Columns[14].HeaderText = "Sex";
                dgDetails.Columns[14].Width = 50;


                dgDetails.Columns[15].HeaderText = "Birth Date";
                dgDetails.Columns[15].Width = 63;


                dgDetails.Columns[16].HeaderText = "Country";
                dgDetails.Columns[16].Width = 60;

                dgDetails.Columns[17].Visible = false;

                //dgDetails.Columns[16].HeaderText = "Address";
                dgDetails.Columns[18].Width = 60;

                //dgDetails.Columns[17].HeaderText = "Remarks";
                dgDetails.Columns[19].Width = 60;




            }




        }

        private void WritePDF()
        {
            var document = new Document(PageSize.A4.Rotate(), 1, 1, 25, 1);
            //document.SetPageSize(PageSize.A4.Rotate());
           
            PdfWriter.GetInstance(document, new FileStream(@"C:\PassportDetails\PassportInfo.pdf", FileMode.Create));
            document.Open();

            var paragraph = new Paragraph("PASSENGER INFORMATION SYSTEM\n DABOLIM AIRPORT GOA");
            //Paragraph paragraph = new Paragraph("data Exported From DataGridview!" + System.Environment.NewLine);
            paragraph.Font.SetFamily("Verdana");
            paragraph.Font.SetColor(72, 72, 72);
            paragraph.Font.Size = 25;
            paragraph.Alignment = 1;
            paragraph.Font.IsBold();

            document.Add(paragraph);


            #region First Table
            PdfPTable t1 = new PdfPTable(3);
            //float[] widths = new float[] { 4, 4, 4};
            //t1.SetWidths(widths);
            //t1.TotalWidth = 900f; 
            //t1.width = 216f;
            ////fix the absolute width of the table
            //t1.LockedWidth = true;

            ////relative col widths in proportions - 1/3 and 2/3
            //float[] widths = new float[] { 1f, 2f };
            //t1.SetWidths(widths);
            //t1.HorizontalAlignment = 0;
            ////leave a gap before and after the table
            t1.SpacingBefore = 20f;
            t1.SpacingAfter = 30f;

            //cid.HorizontalAlignment = Element.ALIGN_LEFT;
            //cid.Column.FilledWidth = 1;



            //Paragraph myParagraph = new Paragraph();
            //myParagraph.Font.SetFamily("Verdana");
            //myParagraph.Font.SetColor(72, 72, 72);
            //myParagraph.Font.Size = 12;
            //myParagraph.Font.IsBold();



            PdfPCell passNo = new PdfPCell(new Phrase("PASSPORT NUMBER"));
            PdfPCell issueDate = new PdfPCell(new Phrase("ISSUE DATE"));
            PdfPCell visaExpDate = new PdfPCell(new Phrase("DATE OF EXPIRY"));

            t1.AddCell(passNo);
            t1.AddCell(issueDate);
            t1.AddCell(visaExpDate);

            
            #endregion



           
            PdfPTable t2 = new PdfPTable(5);

            t2.SpacingBefore = 20f;
            t2.SpacingAfter = 30f;

            PdfPCell flightNo = new PdfPCell(new Phrase("FLIGHT No"));
            PdfPCell arrivedDate = new PdfPCell(new Phrase("ARRIVED DATE"));
            PdfPCell countVisit = new PdfPCell(new Phrase("COUNTRIES VISITIED"));            
            PdfPCell depDate = new PdfPCell(new Phrase("DEPARTURE DATE"));
            PdfPCell purp = new PdfPCell(new Phrase("PURPOSE OF VISIT"));

            //PdfPCell boardPoint = new PdfPCell(new Phrase("Boarding Point"));
            //PdfPCell visaNo = new PdfPCell(new Phrase("Visa No"));



            PdfPTable t3 = new PdfPTable(6);

            PdfPCell name = new PdfPCell(new Phrase("Name"));
            //PdfPCell mname = new PdfPCell(new Phrase("Middle Name"));
            //PdfPCell lname = new PdfPCell(new Phrase("Last Name"));
            PdfPCell sex = new PdfPCell(new Phrase("Sex"));

            PdfPCell bdate = new PdfPCell(new Phrase("Birth Date"));
            PdfPCell count = new PdfPCell(new Phrase("Country"));
            PdfPCell add = new PdfPCell(new Phrase("Address"));
            PdfPCell rem = new PdfPCell(new Phrase("Remarks"));





            //var FullName = string.Concat(Convert.ToString(fname), Convert.ToString(mname), Convert.ToString(lname));





            t2.AddCell(flightNo);
            t2.AddCell(arrivedDate);
            //t1.AddCell(boardPoint);
            //t1.AddCell(visaNo);
            t2.AddCell(depDate);

            t2.AddCell(purp);
            t3.AddCell(name);
            //t1.AddCell(mname);
            //t1.AddCell(lname);
            t3.AddCell(sex);
            t3.AddCell(bdate);
            t3.AddCell(count);
            t3.AddCell(add);
            t3.AddCell(rem);
            t2.AddCell(countVisit);


            foreach (DataGridViewRow rows in dgDetails.Rows)
            {
               // m = dgDetails.Rows.Count[];
                if (dgDetails.Rows[rows.Index].Cells[1].Value!=null)
                {
                    string passportNo = dgDetails.Rows[rows.Index].Cells[1].Value.ToString();
                    string issueDate1 = dgDetails.Rows[rows.Index].Cells[2].Value.ToString();
                    string flightNo1 = dgDetails.Rows[rows.Index].Cells[3].Value.ToString();
                    string arrivedDate1 = dgDetails.Rows[rows.Index].Cells[4].Value.ToString();
                    string countvisit = dgDetails.Rows[rows.Index].Cells[5].Value.ToString();

                    //string boardPoint1 = dgDetails.Rows[rows.Index].Cells[6].Value.ToString();
                    //string visaNo1 = dgDetails.Rows[rows.Index].Cells[7].Value.ToString();
                    string visaExpDate1 = dgDetails.Rows[rows.Index].Cells[8].Value.ToString();
                    string depDate1 = dgDetails.Rows[rows.Index].Cells[9].Value.ToString();

                    string purp1 = dgDetails.Rows[rows.Index].Cells[10].Value.ToString();



                    string fname1 = dgDetails.Rows[rows.Index].Cells[11].Value.ToString();
                    string mname1 = dgDetails.Rows[rows.Index].Cells[12].Value.ToString();
                    string lname1 = dgDetails.Rows[rows.Index].Cells[13].Value.ToString();
                    var FullName = string.Concat(Convert.ToString(fname1)," ", Convert.ToString(mname1), " ",Convert.ToString(lname1));
                    string sex1 = dgDetails.Rows[rows.Index].Cells[14].Value.ToString();

                    string birth = dgDetails.Rows[rows.Index].Cells[15].Value.ToString();
                    string count1 = dgDetails.Rows[rows.Index].Cells[16].Value.ToString();

                    string add1 = dgDetails.Rows[rows.Index].Cells[18].Value.ToString();
                    string rem1 = dgDetails.Rows[rows.Index].Cells[19].Value.ToString();

                    string isdate = (issueDate1);
                    string ardate = (arrivedDate1);
                    string deDate =(depDate1);
                    string vexpDate = (visaExpDate1);
                    string birth1 = (birth);



                    PdfPCell c1 = new PdfPCell(new Phrase(passportNo));
                    PdfPCell c2 = new PdfPCell(new Phrase(Convert.ToString(isdate)));
                    PdfPCell c3 = new PdfPCell(new Phrase(flightNo1));
                    PdfPCell c4 = new PdfPCell(new Phrase(Convert.ToString(ardate)));
                    //PdfPCell c5 = new PdfPCell(new Phrase(boardPoint1));
                    //PdfPCell c6 = new PdfPCell(new Phrase(visaNo1));
                    PdfPCell c7 = new PdfPCell(new Phrase(Convert.ToString(vexpDate)));
                    PdfPCell c8 = new PdfPCell(new Phrase(Convert.ToString(deDate)));

                    PdfPCell c9 = new PdfPCell(new Phrase(purp1));
                    PdfPCell c10 = new PdfPCell(new Phrase(countvisit));
                    PdfPCell c11 = new PdfPCell(new Phrase(FullName));
                    //PdfPCell c12 = new PdfPCell(new Phrase(mname1));
                    //PdfPCell c13 = new PdfPCell(new Phrase(lname1));
                    PdfPCell c14 = new PdfPCell(new Phrase(sex1));

                    PdfPCell c15 = new PdfPCell(new Phrase(Convert.ToString(birth1)));
                    PdfPCell c16 = new PdfPCell(new Phrase(count1));
                    PdfPCell c17 = new PdfPCell(new Phrase(add1));
                    PdfPCell c18 = new PdfPCell(new Phrase(rem1));
                    

                    t1.AddCell(c1);
                    t1.AddCell(c2);
                    t2.AddCell(c3);
                    t2.AddCell(c4);
                    //t1.AddCell(c5);
                    //t1.AddCell(c6);
                    t1.AddCell(c7);
                    t2.AddCell(c8);

                    t2.AddCell(c9);
                    t2.AddCell(c10);
                    t3.AddCell(c11);
                    //t1.AddCell(c12);
                    //t1.AddCell(c13);
                    t3.AddCell(c14);
                    t3.AddCell(c15);
                    t3.AddCell(c16);
                    t3.AddCell(c17);
                    t3.AddCell(c18);
                   

                    
                   // break;
                }
            }
            //document.Add(paragraph);
            document.Add(t1);
            document.Add(t2);
            document.Add(t3);
            document.Close();
            MessageBox.Show("Report Created!");


            string filename = @"C:\PassportDetails\PassportInfo.pdf";

            Process.Start(filename);
       
       




        }


        private void BindCountry()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from tblCountry", ClsConnections.CN);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbCount.DataSource = ds.Tables[0];
            cmbCount.DisplayMember = "CountryName";
            cmbCount.ValueMember = "CountryId";
        }

        private void BindCountryListBox()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from tblCountry", ClsConnections.CN);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListCountries.Add(dr[2].ToString());

            }
            if (ListCountries.Count > 0)
            {
                foreach (var count in ListCountries)
                {
                    listCountries.Items.Add(count);

                }

            }

        }



        private void dgDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgDetails.SelectedCells[0].RowIndex;
            string[] countries = null;
            var passportNum = dgDetails.Rows[i].Cells[1].Value.ToString();
            if (!string.IsNullOrWhiteSpace(passportNum))
            {

                txtPNO.Text = passportNum;
                lblID.Text = dgDetails.Rows[i].Cells[0].Value.ToString();
                PNo = dgDetails.Rows[i].Cells[0].Value.ToString();
                mskIssuedDate.Text = dgDetails.Rows[i].Cells[2].Value.ToString();
                txtFlightNo.Text = dgDetails.Rows[i].Cells[3].Value.ToString();
                mskArrivedDate.Text = dgDetails.Rows[i].Cells[4].Value.ToString();

                //listSelectedCont.Text = string.Empty;
                countries = dgDetails.Rows[i].Cells[5].Value.ToString().Split(',');
                listSelectedCont.Items.Clear();
                foreach (var count in countries)
                {

                    listSelectedCont.Items.Add(count);
                }
                txtPOB.Text = dgDetails.Rows[i].Cells[6].Value.ToString();
                txtVisaNo.Text = dgDetails.Rows[i].Cells[7].Value.ToString();
                mskDateOfExp.Text = dgDetails.Rows[i].Cells[8].Value.ToString();
                mskDateOfDep.Text = dgDetails.Rows[i].Cells[9].Value.ToString();
                txtPOV.Text = dgDetails.Rows[i].Cells[10].Value.ToString();
                txtName.Text = dgDetails.Rows[i].Cells[11].Value.ToString();
                txtMiddleName.Text = dgDetails.Rows[i].Cells[12].Value.ToString();

                txtLastNme.Text = dgDetails.Rows[i].Cells[13].Value.ToString();
                cmbSex.Text = dgDetails.Rows[i].Cells[14].Value.ToString();
                mskDOB.Text = dgDetails.Rows[i].Cells[15].Value.ToString();
                cmbCount.Text = dgDetails.Rows[i].Cells[16].Value.ToString();

                txtRemarks.Text = dgDetails.Rows[i].Cells[19].Value.ToString();
                txtAddress.Text = dgDetails.Rows[i].Cells[18].Value.ToString();
                btnSubmit.Text = "Update";
                if (string.Compare("user123", Users.User, true) == 0)
                { btnDeleted.Visible = false; }
                else { btnDeleted.Visible = true;
                    btnPrint.Visible = true;
                }
                //btnPrint.Visible = true;

                txtPNO.ReadOnly = true;
                txtPNO.BackColor = Color.Silver;
                btnFind.Enabled = false;


            }


        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete changes?", "Confirm delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand oledbAdd =
                  new OleDbCommand("update  tblPassport set IsDeleted='" + "1" + "' where ID=" + Convert.ToInt16(lblID.Text) + " ", ClsConnections.CN);
                oledbAdd.CommandType = CommandType.Text;
                OleDbDataAdapter oledbData = new OleDbDataAdapter(oledbAdd);
                oledbAdd.ExecuteNonQuery();
                MessageBox.Show("Records Successully Deleted");

                BindPassportData();
                isUpdated = true;
                ClearValues();
            }
           

        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            var dataGridHasValues = true;
            if (string.IsNullOrWhiteSpace(txtPNO.Text))
                MessageBox.Show("Please enter passport number");

            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select * from tblPassport where IsDeleted='" + "0" + "' and passportNumber='" + txtPNO.Text + "' ", ClsConnections.CN);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgDetails.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count > 0)
                {
                    btnPrint.Visible = true;
                    dgDetails.Columns[0].Visible = false;
                    dgDetails.Columns[16].Visible = false;
                    dgDetails.Columns[1].HeaderText = "Passport No";
                    dgDetails.Columns[1].Width = 60;

                    dgDetails.Columns[2].HeaderText = "Issued Date";
                    dgDetails.Columns[2].Width = 63;

                    dgDetails.Columns[3].HeaderText = "Flight No";
                    dgDetails.Columns[3].Width = 60;

                    dgDetails.Columns[4].HeaderText = "Arrived Date";
                    dgDetails.Columns[4].Width = 63;

                    dgDetails.Columns[5].HeaderText = "Last Six Countries Visited";
                    dgDetails.Columns[5].Width = 70;

                    dgDetails.Columns[6].HeaderText = "Boarding Port";
                    dgDetails.Columns[6].Width = 60;

                    dgDetails.Columns[7].HeaderText = "Visa No";
                    dgDetails.Columns[7].Width = 60;

                    dgDetails.Columns[8].HeaderText = "Passport Expiration Date";
                    dgDetails.Columns[8].Width = 63;

                    dgDetails.Columns[9].HeaderText = "Departure Date";
                    dgDetails.Columns[9].Width = 63;

                    dgDetails.Columns[10].HeaderText = "Visit's Purpose";
                    dgDetails.Columns[10].Width = 63;

                    dgDetails.Columns[11].HeaderText = "First Name";
                    dgDetails.Columns[11].Width = 60;

                    dgDetails.Columns[12].HeaderText = "Middle Name";
                    dgDetails.Columns[12].Width = 60;


                    dgDetails.Columns[13].HeaderText = "Last Name";
                    dgDetails.Columns[13].Width = 60;

                    dgDetails.Columns[14].HeaderText = "Sex";
                    dgDetails.Columns[14].Width = 50;


                    dgDetails.Columns[15].HeaderText = "Birth Date";
                    dgDetails.Columns[15].Width = 63;


                    dgDetails.Columns[16].HeaderText = "Country";
                    dgDetails.Columns[16].Width = 60;

                    dgDetails.Columns[17].Visible = false;

                    //dgDetails.Columns[16].HeaderText = "Address";
                    dgDetails.Columns[18].Width = 60;

                    //dgDetails.Columns[17].HeaderText = "Remarks";
                    dgDetails.Columns[19].Width = 60;




                }
                passportData = ds.Tables[0];
                if (ds.Tables[0].Rows.Count == 0)
                    dataGridHasValues = false;


            }
            if (dataGridHasValues == false)
            {
                MessageBox.Show("No Record Found");
                ClearValues();

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in listCountries.SelectedItems)
            {
                listSelectedCont.Items.Add(item);
            }

            listCountries.ClearSelected();


        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listSelectedCont.SelectedItems.Count; i++)
            {
                listSelectedCont.Items.Remove(listSelectedCont.SelectedItems[i].ToString());
                i--;
            }


        }

        private void dateTimePickIssueDate_ValueChanged(object sender, EventArgs e)
        {

            DateTime date = dateTimePickIssueDate.Value;
            mskIssuedDate.Text = date.ToString("dd/MM/yyyy");
        }

        private void dateTimePickArriveDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickArriveDate.Value;
            mskArrivedDate.Text = date.ToString("dd/MM/yyyy");
        }

        private void dateTimePickDateOfExpiring_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickDateOfExpiring.Value;
            mskDateOfExp.Text = date.ToString("dd/MM/yyyy");

        }

        private void dateTimePickExpectDateOfDep_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickExpectDateOfDep.Value;
            mskDateOfDep.Text = date.ToString("dd/MM/yyyy");
        }

        private void dateTimePickDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickDOB.Value;
            mskDOB.Text = date.ToString("dd/MM/yyyy");
        }

        private void dgDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void grpDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grpJourneyInfo_Enter(object sender, EventArgs e)
        {

        }

        private void mskIssuedDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void grpPassportInfo_Enter(object sender, EventArgs e)
        {

        }

        private void listSelectedCont_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPassportEnter_FormClosed(object sender, FormClosedEventArgs e)
        {

            frmMdi.IsChildOpened = false;
        }

        private void txtPNO_Leave(object sender, EventArgs e)
        {
            String m = ((System.Windows.Forms.TextBoxBase)(sender)).Text;



            if (!string.IsNullOrWhiteSpace(m))
            {
                if (m.Length == 8)
                {

                    var isValid = isValidPassPort(ref m);
                    if (isValid)
                    {

                        txtPNO.Text = m.ToUpper();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Passport Number");
                        txtPNO.Clear();
                        txtPNO.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid Passport Number");
                    txtPNO.Clear();
                    txtPNO.Focus();

                }


            }


            //isValid =false ? MessageBox.Show("Invalid Passport Number") : null;

        }




        private bool isValidPassPort(ref string passportNumber)
        {
            for (int i = 0; i <= passportNumber.Length - 1; i++)
            {
                char c = passportNumber[i];
                if (i == 0)
                {

                    if (!char.IsLetter(c))
                    {

                        return false;

                    }

                }
                else
                {
                    if (!char.IsDigit(c))
                    {
                        return false;

                    }

                }
            }

            return true;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bm = new Bitmap(this.dgDetails.Width,this.dgDetails.Height);
            //dgDetails.DrawToBitmap(bm, new Rectangle(0, 0, this.dgDetails.Width, this.dgDetails.Height));
            //e.Graphics.DrawImage(bm,0,0);
            //export a DataTable to Excel
            DialogResult retry = DialogResult.Retry;



        }
        //void ExportPDF()
        //{
        //    DataTable dt = passportData;
        //    //HttpWebResponse Response =new HttpWebResponse(;
        //    //FileWebResponse response = null;

        //    HttpResponseHeader g = new HttpResponseHeader();

        //    //Response.ContentType = 
        //     //HttpResponseHeader.ContentType="application/pdf";
        //    //Response.AddHeader("content-disposition",

        //    //    "attachment;filename=DataTable.pdf");

        //    //Response.Cache.SetCacheability(HttpCacheability.NoCache);

        //    StringWriter sw = new StringWriter();

        //    StringBuilder hw = new StringBuilder();
        //    hw.Append(sw);

        //    //HtmlTextWriter hw = new HtmlTextWriter(sw);



        //    StringReader sr = new StringReader(sw.ToString());

        //    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

        //    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);

        //    PdfWriter.GetInstance(pdfDoc, Response.GetResponseStream());

        //    pdfDoc.Open();

        //    htmlparser.Parse(sr);

        //    pdfDoc.Close();


        //    //response.Write(pdfDoc);

        //    //Response.End();

        //}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //WebApplication2.PDFConverter p=new WebApplication2.PDFConverter();
            //p.ConvertToPDF(passportData);
            //ExportPDF();
            //printDocument1.Print();


            //ExportData();
            //ExportToPDF();
            WritePDF();

        }

        private void grpPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void ExportToPDF1()
        {
            //Get the Directory path
            string DirectoryPath = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            //need a PDF to create/modify based on our requirement
            string sourcePath = Path.Combine("E:\\Doc", "Passport.pdf");
            //Dataset will bring all the data for PDF
            DataTable DT = new DataTable();
            DT = passportData;
            using (Document doc = new Document(PageSize.A4, 42, 73, 85, 46))
            {
                var TestData =Convert.ToString( DT);
                //Create a new PDF from template
                var existingFileStream = new FileStream(sourcePath, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(doc, existingFileStream);
                doc.Open();
                //Create First Page
                // a table with three columns          
                PdfPTable table = new PdfPTable(1);
                table.WidthPercentage = 100;
                //Adjust the font size
                iTextSharp.text.Font bodyFont = FontFactory.GetFont("Time New Roman", 5f, iTextSharp.text.Font.NORMAL,
                                                                    BaseColor.BLACK);
                Chunk testChunk = new Chunk(TestData, bodyFont);
                Phrase testPhrase = new Phrase(testChunk);
                PdfPCell cell;
                cell = new PdfPCell(testPhrase);
                //adjust Table cell padding
                cell.PaddingTop = 10;
                cell.PaddingBottom = 10;
                cell.PaddingLeft = 10;
                cell.PaddingRight = 10;
                cell.FixedHeight = 120f;
                // cell.Border = PdfPCell.NO_BORDER; //Adjust Border
                table.AddCell(cell);
                doc.Add(table);
                doc.Close();

            }
        }


        private void ExportToPDF()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            string sourcePath = Path.Combine("E:\\Doc", "Passport.pdf");
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sourcePath, FileMode.Create));
            doc.Open();
            //Paragraph paragraph = new Paragraph("PASSENGER DATA\n hi hello");
            //doc.Add(paragraph);

            PdfPTable table=new PdfPTable(dgDetails.Columns.Count);
            //add headers from the passport grid to the table

            for (int j = 0; j < dgDetails.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgDetails.Columns[j].HeaderText));

            }

            //float[] widths = new float[] { 1f, 2f };
            //table.SetWidths(widths);


            //flag the first row as header
            table.WidthPercentage = 100;
            //iTextSharp.text.Font bodyFont = FontFactory.GetFont("Time New Roman", 8f, iTextSharp.text.Font.BOLD,
            //                                                        BaseColor.BLACK);

            
           
            PdfPCell cell;
            cell = new PdfPCell(new Phrase(string.Empty, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 5f, iTextSharp.text.Font.NORMAL,
                                                                    BaseColor.BLACK)));
            cell.Colspan = 0;
            cell.Border = 0;
            cell.HorizontalAlignment = 1;

            //adjust Table cell padding
            cell.PaddingTop = 10;
            cell.PaddingBottom = 10;
            cell.PaddingLeft = 10;
            cell.PaddingRight = 10;
            cell.FixedHeight = 60f;
            // cell.Border = PdfPCell.NO_BORDER; //Adjust Border
            table.AddCell(cell);
            
            //add the actual rows from pasport grid to the table
            for (int i = 0; i < dgDetails.Rows.Count; i++)
            {
                for (int k = 0; k < dgDetails.Columns.Count; k++)
                {
                    if (dgDetails[k,i].Value!=null)
                    {
                        table.AddCell(new Phrase(dgDetails[k, i].Value.ToString()));
                    }
                }
            }

            //add the table
            doc.Add(table);

            #region Unwanted
            //PdfPCell pCell=new PdfPCell(new Phrase("Header Spanning "));
            //pCell.Colspan = 3;
            //pCell.HorizontalAlignment = 1;
            //table.AddCell(pCell);
            //foreach (DataRow dr in passportData.Rows)
            //{
            //    PdfPCell cell21 = new PdfPCell(); 

            //    cell21.AddElement(new Paragraph("Passport NUMBER"));
            //    table.AddCell(dr[1].ToString());
            //    table.AddCell(dr[2].ToString());
            //    table.AddCell(dr[3].ToString());
            //    doc.Add(table);

            //} 
            #endregion
           
            doc.Close();

        }

        private void lblExpectedDateOfDeparture_Click(object sender, EventArgs e)
        {

        }

        private void lblDateOfExpiry_Click(object sender, EventArgs e)
        {

        }

        #region Unwanted
        //public static void ExcelExport(System.Data.DataTable data, String fileName, bool openAfter)
        //{

        //    DialogResult retry = DialogResult.Retry;

        //    while (retry == DialogResult.Retry)
        //    {
        //        try
        //        {
        //            using (ExcelWriter writer = new ExcelWriter(fileName))
        //            {
        //                writer.WriteStartDocument();

        //                // Write the worksheet contents
        //                writer.WriteStartWorksheet("Sheet1");

        //                //Write header row
        //                writer.WriteStartRow();
        //                foreach (DataColumn col in data.Columns)
        //                    writer.WriteExcelUnstyledCell(col.Caption);
        //                writer.WriteEndRow();

        //                //write data
        //                foreach (DataRow row in data.Rows)
        //                {
        //                    writer.WriteStartRow();
        //                    foreach (object o in row.ItemArray)
        //                    {
        //                        writer.WriteExcelAutoStyledCell(o);
        //                    }
        //                    writer.WriteEndRow();
        //                }

        //                // Close up the document
        //                writer.WriteEndWorksheet();
        //                writer.WriteEndDocument();
        //                writer.Close();
        //                if (openAfter)
        //                    OpenFile(fileName);
        //                retry = DialogResult.Cancel;
        //            }
        //        }
        //        catch (Exception myException)
        //        {
        //            retry = MessageBox.Show(myException.Message, "Excel Export", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
        //        }
        //    }



        //} 
        #endregion



        }


    }

