namespace PassengerInformationSystem
{
    partial class frmPassportEnter
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastNme = new System.Windows.Forms.TextBox();
            this.dateTimePickDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbCount = new System.Windows.Forms.ComboBox();
            this.mskDOB = new System.Windows.Forms.MaskedTextBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpPassportInfo = new System.Windows.Forms.GroupBox();
            this.dateTimePickIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtPNO = new System.Windows.Forms.TextBox();
            this.mskIssuedDate = new System.Windows.Forms.MaskedTextBox();
            this.grpJourneyInfo = new System.Windows.Forms.GroupBox();
            this.dateTimePickExpectDateOfDep = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickDateOfExpiring = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickArriveDate = new System.Windows.Forms.DateTimePicker();
            this.txtPOV = new System.Windows.Forms.TextBox();
            this.txtPOB = new System.Windows.Forms.TextBox();
            this.mskDateOfDep = new System.Windows.Forms.MaskedTextBox();
            this.mskDateOfExp = new System.Windows.Forms.MaskedTextBox();
            this.txtVisaNo = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mskArrivedDate = new System.Windows.Forms.MaskedTextBox();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblPurposeOfVisit = new System.Windows.Forms.Label();
            this.lblExpectedDateOfDeparture = new System.Windows.Forms.Label();
            this.lblDateOfExpiry = new System.Windows.Forms.Label();
            this.lblPortOfBoard = new System.Windows.Forms.Label();
            this.lblVisaNo = new System.Windows.Forms.Label();
            this.listSelectedCont = new System.Windows.Forms.ListBox();
            this.listCountries = new System.Windows.Forms.ListBox();
            this.lblCountryVisited = new System.Windows.Forms.Label();
            this.lblArrivedDate = new System.Windows.Forms.Label();
            this.lblFlighNo = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.grpDetailsGrid = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.grpPersonalInfo.SuspendLayout();
            this.grpPassportInfo.SuspendLayout();
            this.grpJourneyInfo.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            this.grpDetailsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AccessibleName = "";
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(181, 50);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(65, 23);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB";
            // 
            // lblCountry
            // 
            this.lblCountry.AccessibleName = "";
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(16, 135);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(77, 20);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country";
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblDateOfIssue";
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Issued Date";
            // 
            // label5
            // 
            this.label5.AccessibleName = "lblPassportNo";
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Passport No";
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpPersonalInfo.Controls.Add(this.txtMiddleName);
            this.grpPersonalInfo.Controls.Add(this.label1);
            this.grpPersonalInfo.Controls.Add(this.lblRemarks);
            this.grpPersonalInfo.Controls.Add(this.txtRemarks);
            this.grpPersonalInfo.Controls.Add(this.lblAddress);
            this.grpPersonalInfo.Controls.Add(this.txtAddress);
            this.grpPersonalInfo.Controls.Add(this.txtLastNme);
            this.grpPersonalInfo.Controls.Add(this.dateTimePickDOB);
            this.grpPersonalInfo.Controls.Add(this.cmbCount);
            this.grpPersonalInfo.Controls.Add(this.mskDOB);
            this.grpPersonalInfo.Controls.Add(this.cmbSex);
            this.grpPersonalInfo.Controls.Add(this.lblSex);
            this.grpPersonalInfo.Controls.Add(this.label2);
            this.grpPersonalInfo.Controls.Add(this.txtName);
            this.grpPersonalInfo.Controls.Add(this.lblCountry);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Controls.Add(this.lblDOB);
            this.grpPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPersonalInfo.ForeColor = System.Drawing.Color.Black;
            this.grpPersonalInfo.Location = new System.Drawing.Point(3, 14);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(639, 248);
            this.grpPersonalInfo.TabIndex = 9;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            this.grpPersonalInfo.Enter += new System.EventHandler(this.grpPersonalInfo_Enter);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(290, 19);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(113, 20);
            this.txtMiddleName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblName";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Middle Name";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AccessibleName = "lblName";
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(186, 131);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(76, 23);
            this.lblRemarks.TabIndex = 26;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(280, 132);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(274, 55);
            this.txtRemarks.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.AccessibleName = "lblName";
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(361, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 23);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(439, 53);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 55);
            this.txtAddress.TabIndex = 23;
            // 
            // txtLastNme
            // 
            this.txtLastNme.Location = new System.Drawing.Point(508, 19);
            this.txtLastNme.Name = "txtLastNme";
            this.txtLastNme.Size = new System.Drawing.Size(107, 20);
            this.txtLastNme.TabIndex = 20;
            // 
            // dateTimePickDOB
            // 
            this.dateTimePickDOB.Location = new System.Drawing.Point(336, 52);
            this.dateTimePickDOB.Name = "dateTimePickDOB";
            this.dateTimePickDOB.Size = new System.Drawing.Size(19, 20);
            this.dateTimePickDOB.TabIndex = 22;
            this.dateTimePickDOB.ValueChanged += new System.EventHandler(this.dateTimePickDOB_ValueChanged);
            // 
            // cmbCount
            // 
            this.cmbCount.FormattingEnabled = true;
            this.cmbCount.Location = new System.Drawing.Point(85, 134);
            this.cmbCount.Name = "cmbCount";
            this.cmbCount.Size = new System.Drawing.Size(90, 21);
            this.cmbCount.TabIndex = 24;
            this.cmbCount.Text = "India";
            // 
            // mskDOB
            // 
            this.mskDOB.Location = new System.Drawing.Point(250, 51);
            this.mskDOB.Mask = "00/00/0000";
            this.mskDOB.Name = "mskDOB";
            this.mskDOB.Size = new System.Drawing.Size(82, 20);
            this.mskDOB.TabIndex = 22;
            this.mskDOB.ValidatingType = typeof(System.DateTime);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbSex.Location = new System.Drawing.Point(75, 53);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(100, 21);
            this.cmbSex.TabIndex = 21;
            this.cmbSex.Text = "Male";
            // 
            // lblSex
            // 
            this.lblSex.AccessibleName = "";
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(13, 55);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 23);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblName";
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 18;
            // 
            // grpPassportInfo
            // 
            this.grpPassportInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpPassportInfo.Controls.Add(this.dateTimePickIssueDate);
            this.grpPassportInfo.Controls.Add(this.btnFind);
            this.grpPassportInfo.Controls.Add(this.txtPNO);
            this.grpPassportInfo.Controls.Add(this.mskIssuedDate);
            this.grpPassportInfo.Controls.Add(this.label5);
            this.grpPassportInfo.Controls.Add(this.label4);
            this.grpPassportInfo.Location = new System.Drawing.Point(12, 2);
            this.grpPassportInfo.Name = "grpPassportInfo";
            this.grpPassportInfo.Size = new System.Drawing.Size(577, 48);
            this.grpPassportInfo.TabIndex = 7;
            this.grpPassportInfo.TabStop = false;
            this.grpPassportInfo.Text = "Passport Information";
            this.grpPassportInfo.Enter += new System.EventHandler(this.grpPassportInfo_Enter);
            // 
            // dateTimePickIssueDate
            // 
            this.dateTimePickIssueDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePickIssueDate.Location = new System.Drawing.Point(519, 17);
            this.dateTimePickIssueDate.Name = "dateTimePickIssueDate";
            this.dateTimePickIssueDate.Size = new System.Drawing.Size(19, 20);
            this.dateTimePickIssueDate.TabIndex = 3;
            this.dateTimePickIssueDate.ValueChanged += new System.EventHandler(this.dateTimePickIssueDate_ValueChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Green;
            this.btnFind.Location = new System.Drawing.Point(225, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(41, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtPNO
            // 
            this.txtPNO.BackColor = System.Drawing.SystemColors.Window;
            this.txtPNO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPNO.Location = new System.Drawing.Point(119, 16);
            this.txtPNO.MaxLength = 8;
            this.txtPNO.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtPNO.Name = "txtPNO";
            this.txtPNO.Size = new System.Drawing.Size(100, 20);
            this.txtPNO.TabIndex = 0;
            this.txtPNO.TextChanged += new System.EventHandler(this.txtPNO_TextChanged);
            this.txtPNO.Leave += new System.EventHandler(this.txtPNO_Leave);
            // 
            // mskIssuedDate
            // 
            this.mskIssuedDate.Location = new System.Drawing.Point(422, 16);
            this.mskIssuedDate.Mask = "00-00-0000";
            this.mskIssuedDate.Name = "mskIssuedDate";
            this.mskIssuedDate.Size = new System.Drawing.Size(91, 20);
            this.mskIssuedDate.TabIndex = 2;
            this.mskIssuedDate.ValidatingType = typeof(System.DateTime);
            this.mskIssuedDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIssuedDate_MaskInputRejected);
            // 
            // grpJourneyInfo
            // 
            this.grpJourneyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpJourneyInfo.Controls.Add(this.dateTimePickExpectDateOfDep);
            this.grpJourneyInfo.Controls.Add(this.dateTimePickDateOfExpiring);
            this.grpJourneyInfo.Controls.Add(this.dateTimePickArriveDate);
            this.grpJourneyInfo.Controls.Add(this.txtPOV);
            this.grpJourneyInfo.Controls.Add(this.txtPOB);
            this.grpJourneyInfo.Controls.Add(this.mskDateOfDep);
            this.grpJourneyInfo.Controls.Add(this.mskDateOfExp);
            this.grpJourneyInfo.Controls.Add(this.txtVisaNo);
            this.grpJourneyInfo.Controls.Add(this.btnRemove);
            this.grpJourneyInfo.Controls.Add(this.btnAdd);
            this.grpJourneyInfo.Controls.Add(this.mskArrivedDate);
            this.grpJourneyInfo.Controls.Add(this.txtFlightNo);
            this.grpJourneyInfo.Controls.Add(this.lblPurposeOfVisit);
            this.grpJourneyInfo.Controls.Add(this.lblExpectedDateOfDeparture);
            this.grpJourneyInfo.Controls.Add(this.lblDateOfExpiry);
            this.grpJourneyInfo.Controls.Add(this.lblPortOfBoard);
            this.grpJourneyInfo.Controls.Add(this.lblVisaNo);
            this.grpJourneyInfo.Controls.Add(this.listSelectedCont);
            this.grpJourneyInfo.Controls.Add(this.listCountries);
            this.grpJourneyInfo.Controls.Add(this.lblCountryVisited);
            this.grpJourneyInfo.Controls.Add(this.lblArrivedDate);
            this.grpJourneyInfo.Controls.Add(this.lblFlighNo);
            this.grpJourneyInfo.Location = new System.Drawing.Point(12, 56);
            this.grpJourneyInfo.Name = "grpJourneyInfo";
            this.grpJourneyInfo.Size = new System.Drawing.Size(577, 371);
            this.grpJourneyInfo.TabIndex = 8;
            this.grpJourneyInfo.TabStop = false;
            this.grpJourneyInfo.Text = "Journey Information";
            this.grpJourneyInfo.Enter += new System.EventHandler(this.grpJourneyInfo_Enter);
            // 
            // dateTimePickExpectDateOfDep
            // 
            this.dateTimePickExpectDateOfDep.Location = new System.Drawing.Point(253, 264);
            this.dateTimePickExpectDateOfDep.Name = "dateTimePickExpectDateOfDep";
            this.dateTimePickExpectDateOfDep.Size = new System.Drawing.Size(19, 20);
            this.dateTimePickExpectDateOfDep.TabIndex = 16;
            this.dateTimePickExpectDateOfDep.ValueChanged += new System.EventHandler(this.dateTimePickExpectDateOfDep_ValueChanged);
            // 
            // dateTimePickDateOfExpiring
            // 
            this.dateTimePickDateOfExpiring.Location = new System.Drawing.Point(253, 231);
            this.dateTimePickDateOfExpiring.Name = "dateTimePickDateOfExpiring";
            this.dateTimePickDateOfExpiring.Size = new System.Drawing.Size(19, 20);
            this.dateTimePickDateOfExpiring.TabIndex = 14;
            this.dateTimePickDateOfExpiring.ValueChanged += new System.EventHandler(this.dateTimePickDateOfExpiring_ValueChanged);
            // 
            // dateTimePickArriveDate
            // 
            this.dateTimePickArriveDate.Location = new System.Drawing.Point(519, 17);
            this.dateTimePickArriveDate.Name = "dateTimePickArriveDate";
            this.dateTimePickArriveDate.Size = new System.Drawing.Size(19, 20);
            this.dateTimePickArriveDate.TabIndex = 6;
            this.dateTimePickArriveDate.ValueChanged += new System.EventHandler(this.dateTimePickArriveDate_ValueChanged);
            // 
            // txtPOV
            // 
            this.txtPOV.Location = new System.Drawing.Point(147, 326);
            this.txtPOV.Multiline = true;
            this.txtPOV.Name = "txtPOV";
            this.txtPOV.Size = new System.Drawing.Size(357, 39);
            this.txtPOV.TabIndex = 17;
            // 
            // txtPOB
            // 
            this.txtPOB.Location = new System.Drawing.Point(147, 188);
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.Size = new System.Drawing.Size(100, 20);
            this.txtPOB.TabIndex = 11;
            // 
            // mskDateOfDep
            // 
            this.mskDateOfDep.Location = new System.Drawing.Point(147, 264);
            this.mskDateOfDep.Mask = "00/00/0000";
            this.mskDateOfDep.Name = "mskDateOfDep";
            this.mskDateOfDep.Size = new System.Drawing.Size(100, 20);
            this.mskDateOfDep.TabIndex = 15;
            this.mskDateOfDep.ValidatingType = typeof(System.DateTime);
            // 
            // mskDateOfExp
            // 
            this.mskDateOfExp.Location = new System.Drawing.Point(147, 228);
            this.mskDateOfExp.Mask = "00/00/0000";
            this.mskDateOfExp.Name = "mskDateOfExp";
            this.mskDateOfExp.Size = new System.Drawing.Size(100, 20);
            this.mskDateOfExp.TabIndex = 13;
            this.mskDateOfExp.ValidatingType = typeof(System.DateTime);
            // 
            // txtVisaNo
            // 
            this.txtVisaNo.Location = new System.Drawing.Point(404, 188);
            this.txtVisaNo.Name = "txtVisaNo";
            this.txtVisaNo.Size = new System.Drawing.Size(100, 20);
            this.txtVisaNo.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(252, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(41, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mskArrivedDate
            // 
            this.mskArrivedDate.Location = new System.Drawing.Point(422, 16);
            this.mskArrivedDate.Mask = "00/00/0000";
            this.mskArrivedDate.Name = "mskArrivedDate";
            this.mskArrivedDate.Size = new System.Drawing.Size(91, 20);
            this.mskArrivedDate.TabIndex = 5;
            this.mskArrivedDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(119, 16);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(100, 20);
            this.txtFlightNo.TabIndex = 4;
            // 
            // lblPurposeOfVisit
            // 
            this.lblPurposeOfVisit.AccessibleName = "";
            this.lblPurposeOfVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurposeOfVisit.Location = new System.Drawing.Point(13, 325);
            this.lblPurposeOfVisit.Name = "lblPurposeOfVisit";
            this.lblPurposeOfVisit.Size = new System.Drawing.Size(144, 23);
            this.lblPurposeOfVisit.TabIndex = 11;
            this.lblPurposeOfVisit.Text = "Purpose of visit";
            // 
            // lblExpectedDateOfDeparture
            // 
            this.lblExpectedDateOfDeparture.AccessibleName = "";
            this.lblExpectedDateOfDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedDateOfDeparture.Location = new System.Drawing.Point(15, 264);
            this.lblExpectedDateOfDeparture.Name = "lblExpectedDateOfDeparture";
            this.lblExpectedDateOfDeparture.Size = new System.Drawing.Size(84, 61);
            this.lblExpectedDateOfDeparture.TabIndex = 10;
            this.lblExpectedDateOfDeparture.Text = "Expected Date of Departure";
            this.lblExpectedDateOfDeparture.Click += new System.EventHandler(this.lblExpectedDateOfDeparture_Click);
            // 
            // lblDateOfExpiry
            // 
            this.lblDateOfExpiry.AccessibleName = "";
            this.lblDateOfExpiry.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfExpiry.Location = new System.Drawing.Point(13, 228);
            this.lblDateOfExpiry.Name = "lblDateOfExpiry";
            this.lblDateOfExpiry.Size = new System.Drawing.Size(108, 36);
            this.lblDateOfExpiry.TabIndex = 9;
            this.lblDateOfExpiry.Text = "Passport Expiration Date";
            this.lblDateOfExpiry.Click += new System.EventHandler(this.lblDateOfExpiry_Click);
            // 
            // lblPortOfBoard
            // 
            this.lblPortOfBoard.AccessibleName = "";
            this.lblPortOfBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortOfBoard.Location = new System.Drawing.Point(13, 185);
            this.lblPortOfBoard.Name = "lblPortOfBoard";
            this.lblPortOfBoard.Size = new System.Drawing.Size(144, 23);
            this.lblPortOfBoard.TabIndex = 8;
            this.lblPortOfBoard.Text = "Port of Boarding";
            // 
            // lblVisaNo
            // 
            this.lblVisaNo.AccessibleName = "";
            this.lblVisaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisaNo.Location = new System.Drawing.Point(309, 185);
            this.lblVisaNo.Name = "lblVisaNo";
            this.lblVisaNo.Size = new System.Drawing.Size(100, 23);
            this.lblVisaNo.TabIndex = 7;
            this.lblVisaNo.Text = "Visa  No";
            // 
            // listSelectedCont
            // 
            this.listSelectedCont.FormattingEnabled = true;
            this.listSelectedCont.Location = new System.Drawing.Point(303, 75);
            this.listSelectedCont.Name = "listSelectedCont";
            this.listSelectedCont.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listSelectedCont.Size = new System.Drawing.Size(201, 95);
            this.listSelectedCont.TabIndex = 10;
            this.listSelectedCont.SelectedIndexChanged += new System.EventHandler(this.listSelectedCont_SelectedIndexChanged);
            // 
            // listCountries
            // 
            this.listCountries.FormattingEnabled = true;
            this.listCountries.Location = new System.Drawing.Point(16, 75);
            this.listCountries.Name = "listCountries";
            this.listCountries.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCountries.Size = new System.Drawing.Size(231, 95);
            this.listCountries.TabIndex = 7;
            this.listCountries.SelectedIndexChanged += new System.EventHandler(this.listCountries_SelectedIndexChanged);
            // 
            // lblCountryVisited
            // 
            this.lblCountryVisited.AccessibleName = "";
            this.lblCountryVisited.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryVisited.Location = new System.Drawing.Point(13, 52);
            this.lblCountryVisited.Name = "lblCountryVisited";
            this.lblCountryVisited.Size = new System.Drawing.Size(250, 20);
            this.lblCountryVisited.TabIndex = 4;
            this.lblCountryVisited.Text = "Country visisted in last 6 days";
            // 
            // lblArrivedDate
            // 
            this.lblArrivedDate.AccessibleName = "";
            this.lblArrivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivedDate.Location = new System.Drawing.Point(304, 19);
            this.lblArrivedDate.Name = "lblArrivedDate";
            this.lblArrivedDate.Size = new System.Drawing.Size(112, 20);
            this.lblArrivedDate.TabIndex = 3;
            this.lblArrivedDate.Text = "Arrived Date";
            // 
            // lblFlighNo
            // 
            this.lblFlighNo.AccessibleName = "";
            this.lblFlighNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlighNo.Location = new System.Drawing.Point(13, 16);
            this.lblFlighNo.Name = "lblFlighNo";
            this.lblFlighNo.Size = new System.Drawing.Size(100, 23);
            this.lblFlighNo.TabIndex = 0;
            this.lblFlighNo.Text = "Flight No";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.grpPersonalInfo);
            this.grpDetails.Location = new System.Drawing.Point(595, 2);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(634, 244);
            this.grpDetails.TabIndex = 27;
            this.grpDetails.TabStop = false;
            this.grpDetails.Enter += new System.EventHandler(this.grpDetails_Enter);
            // 
            // dgDetails
            // 
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Location = new System.Drawing.Point(9, 19);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.ReadOnly = true;
            this.dgDetails.Size = new System.Drawing.Size(1167, 233);
            this.dgDetails.TabIndex = 55;
            this.dgDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetails_CellClick);
            this.dgDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetails_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(762, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(860, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(952, 270);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(75, 23);
            this.btnDeleted.TabIndex = 28;
            this.btnDeleted.Text = "Delete";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // grpDetailsGrid
            // 
            this.grpDetailsGrid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpDetailsGrid.Controls.Add(this.dgDetails);
            this.grpDetailsGrid.Location = new System.Drawing.Point(12, 433);
            this.grpDetailsGrid.Name = "grpDetailsGrid";
            this.grpDetailsGrid.Size = new System.Drawing.Size(1260, 258);
            this.grpDetailsGrid.TabIndex = 56;
            this.grpDetailsGrid.TabStop = false;
            this.grpDetailsGrid.Text = "Details";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1052, 270);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblID
            // 
            this.lblID.AccessibleName = "";
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(620, 340);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 23);
            this.lblID.TabIndex = 58;
            this.lblID.Visible = false;
            // 
            // frmPassportEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpDetailsGrid);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpJourneyInfo);
            this.Controls.Add(this.grpPassportInfo);
            this.Controls.Add(this.grpDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassportEnter";
            this.Text = "Enter Passport Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPassportEnter_FormClosed);
            this.Load += new System.EventHandler(this.frmPassportEnter_Load);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpPassportInfo.ResumeLayout(false);
            this.grpPassportInfo.PerformLayout();
            this.grpJourneyInfo.ResumeLayout(false);
            this.grpJourneyInfo.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            this.grpDetailsGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.GroupBox grpPassportInfo;
        private System.Windows.Forms.GroupBox grpJourneyInfo;
        private System.Windows.Forms.Label lblCountryVisited;
        private System.Windows.Forms.Label lblArrivedDate;
        private System.Windows.Forms.Label lblFlighNo;
        private System.Windows.Forms.ListBox listSelectedCont;
        private System.Windows.Forms.ListBox listCountries;
        private System.Windows.Forms.Label lblPurposeOfVisit;
        private System.Windows.Forms.Label lblExpectedDateOfDeparture;
        private System.Windows.Forms.Label lblDateOfExpiry;
        private System.Windows.Forms.Label lblPortOfBoard;
        private System.Windows.Forms.Label lblVisaNo;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCount;
        private System.Windows.Forms.MaskedTextBox mskDOB;
        private System.Windows.Forms.TextBox txtPNO;
        private System.Windows.Forms.MaskedTextBox mskIssuedDate;
        private System.Windows.Forms.MaskedTextBox mskArrivedDate;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mskDateOfDep;
        private System.Windows.Forms.MaskedTextBox mskDateOfExp;
        private System.Windows.Forms.TextBox txtVisaNo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPOV;
        private System.Windows.Forms.TextBox txtPOB;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dateTimePickIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickExpectDateOfDep;
        private System.Windows.Forms.DateTimePicker dateTimePickDateOfExpiring;
        private System.Windows.Forms.DateTimePicker dateTimePickArriveDate;
        private System.Windows.Forms.TextBox txtLastNme;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.GroupBox grpDetailsGrid;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
    }
}