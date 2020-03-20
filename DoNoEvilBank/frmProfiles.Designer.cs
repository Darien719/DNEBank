namespace DoNoEvilBank
{
    partial class frmProfiles
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbProfileCenter = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAccountCenter = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeposit = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWithdrawal = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbChecks = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCCApp = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoans = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLogOut = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPayment = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUploadCustomerSignature = new System.Windows.Forms.Button();
            this.btnUploadProfilePic = new System.Windows.Forms.Button();
            this.picCustomerSignature = new System.Windows.Forms.PictureBox();
            this.picProfilePic = new System.Windows.Forms.PictureBox();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtmDOB = new System.Windows.Forms.DateTimePicker();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMailing = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUpdate = new System.Windows.Forms.RadioButton();
            this.radNewCustomer = new System.Windows.Forms.RadioButton();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.grpProfileInfo = new System.Windows.Forms.GroupBox();
            this.lvwAccounts = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.sfdDialog = new System.Windows.Forms.SaveFileDialog();
            this.tsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 65);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1040, 42);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Profile Management Center";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsTools
            // 
            this.tsTools.AutoSize = false;
            this.tsTools.BackColor = System.Drawing.Color.White;
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.ToolStripSeparator3,
            this.tsbProfileCenter,
            this.ToolStripSeparator4,
            this.tsbAccountCenter,
            this.ToolStripSeparator9,
            this.tsbDeposit,
            this.ToolStripSeparator2,
            this.tsbWithdrawal,
            this.ToolStripSeparator5,
            this.tsbChecks,
            this.ToolStripSeparator7,
            this.tsbCCApp,
            this.ToolStripSeparator11,
            this.tsbLoans,
            this.ToolStripSeparator10,
            this.tsbLogOut,
            this.ToolStripSeparator8,
            this.tsbHelp,
            this.ToolStripSeparator1,
            this.tsbPayment,
            this.ToolStripSeparator6});
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(1040, 65);
            this.tsTools.TabIndex = 24;
            this.tsTools.Text = "tsStrip";
            // 
            // tsbHome
            // 
            this.tsbHome.AutoSize = false;
            this.tsbHome.BackgroundImage = global::DoNoEvilBank.Properties.Resources.home;
            this.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(50, 50);
            this.tsbHome.Text = "Home";
            this.tsbHome.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            this.tsbHome.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbHome.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbProfileCenter
            // 
            this.tsbProfileCenter.AutoSize = false;
            this.tsbProfileCenter.BackgroundImage = global::DoNoEvilBank.Properties.Resources.user;
            this.tsbProfileCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbProfileCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProfileCenter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbProfileCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProfileCenter.Name = "tsbProfileCenter";
            this.tsbProfileCenter.Size = new System.Drawing.Size(50, 50);
            this.tsbProfileCenter.Text = "Profile";
            this.tsbProfileCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbProfileCenter.ToolTipText = "Profile";
            this.tsbProfileCenter.Click += new System.EventHandler(this.tsbAccountCenter_Click);
            this.tsbProfileCenter.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbProfileCenter.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbAccountCenter
            // 
            this.tsbAccountCenter.AutoSize = false;
            this.tsbAccountCenter.BackgroundImage = global::DoNoEvilBank.Properties.Resources.add;
            this.tsbAccountCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbAccountCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAccountCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccountCenter.Name = "tsbAccountCenter";
            this.tsbAccountCenter.Size = new System.Drawing.Size(50, 50);
            this.tsbAccountCenter.Text = "Account";
            this.tsbAccountCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbAccountCenter.ToolTipText = "Account";
            this.tsbAccountCenter.Click += new System.EventHandler(this.tsbProfileCenter_Click);
            this.tsbAccountCenter.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbAccountCenter.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbDeposit
            // 
            this.tsbDeposit.AutoSize = false;
            this.tsbDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbDeposit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeposit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeposit.Name = "tsbDeposit";
            this.tsbDeposit.Size = new System.Drawing.Size(50, 50);
            this.tsbDeposit.Text = "Deposit";
            this.tsbDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbDeposit.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbDeposit.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbWithdrawal
            // 
            this.tsbWithdrawal.AutoSize = false;
            this.tsbWithdrawal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbWithdrawal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWithdrawal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWithdrawal.Name = "tsbWithdrawal";
            this.tsbWithdrawal.Size = new System.Drawing.Size(50, 50);
            this.tsbWithdrawal.Text = "Withd.";
            this.tsbWithdrawal.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbWithdrawal.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbWithdrawal.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbChecks
            // 
            this.tsbChecks.AutoSize = false;
            this.tsbChecks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbChecks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChecks.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tsbChecks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChecks.Name = "tsbChecks";
            this.tsbChecks.Size = new System.Drawing.Size(50, 50);
            this.tsbChecks.Text = "Checks";
            this.tsbChecks.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbChecks.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbChecks.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbCCApp
            // 
            this.tsbCCApp.AutoSize = false;
            this.tsbCCApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCCApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCCApp.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tsbCCApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCCApp.Name = "tsbCCApp";
            this.tsbCCApp.Size = new System.Drawing.Size(50, 50);
            this.tsbCCApp.Text = "CC Appl.";
            this.tsbCCApp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbCCApp.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbCCApp.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbLoans
            // 
            this.tsbLoans.AutoSize = false;
            this.tsbLoans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbLoans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoans.Name = "tsbLoans";
            this.tsbLoans.Size = new System.Drawing.Size(50, 50);
            this.tsbLoans.Text = "Loans";
            this.tsbLoans.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbLoans.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbLoans.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbLogOut
            // 
            this.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLogOut.AutoSize = false;
            this.tsbLogOut.BackgroundImage = global::DoNoEvilBank.Properties.Resources.logout;
            this.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogOut.Name = "tsbLogOut";
            this.tsbLogOut.Size = new System.Drawing.Size(50, 50);
            this.tsbLogOut.Text = "Log Out";
            this.tsbLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbLogOut.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbLogOut.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHelp.AutoSize = false;
            this.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(50, 50);
            this.tsbHelp.Text = "Help";
            this.tsbHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbHelp.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbHelp.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 65);
            // 
            // tsbPayment
            // 
            this.tsbPayment.AutoSize = false;
            this.tsbPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPayment.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPayment.Name = "tsbPayment";
            this.tsbPayment.Size = new System.Drawing.Size(50, 50);
            this.tsbPayment.Text = "Payment";
            this.tsbPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbPayment.MouseEnter += new System.EventHandler(this.tsb_MouseEnter);
            this.tsbPayment.MouseLeave += new System.EventHandler(this.tsb_MouseLeave);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 65);
            // 
            // btnUploadCustomerSignature
            // 
            this.btnUploadCustomerSignature.Location = new System.Drawing.Point(908, 575);
            this.btnUploadCustomerSignature.Name = "btnUploadCustomerSignature";
            this.btnUploadCustomerSignature.Size = new System.Drawing.Size(99, 23);
            this.btnUploadCustomerSignature.TabIndex = 58;
            this.btnUploadCustomerSignature.TabStop = false;
            this.btnUploadCustomerSignature.Text = "Attach File";
            this.btnUploadCustomerSignature.UseVisualStyleBackColor = true;
            // 
            // btnUploadProfilePic
            // 
            this.btnUploadProfilePic.Location = new System.Drawing.Point(908, 332);
            this.btnUploadProfilePic.Name = "btnUploadProfilePic";
            this.btnUploadProfilePic.Size = new System.Drawing.Size(99, 23);
            this.btnUploadProfilePic.TabIndex = 57;
            this.btnUploadProfilePic.TabStop = false;
            this.btnUploadProfilePic.Text = "Attatch File";
            this.btnUploadProfilePic.UseVisualStyleBackColor = true;
            // 
            // picCustomerSignature
            // 
            this.picCustomerSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomerSignature.Location = new System.Drawing.Point(730, 380);
            this.picCustomerSignature.Name = "picCustomerSignature";
            this.picCustomerSignature.Size = new System.Drawing.Size(276, 196);
            this.picCustomerSignature.TabIndex = 56;
            this.picCustomerSignature.TabStop = false;
            // 
            // picProfilePic
            // 
            this.picProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfilePic.Location = new System.Drawing.Point(730, 130);
            this.picProfilePic.Name = "picProfilePic";
            this.picProfilePic.Size = new System.Drawing.Size(276, 203);
            this.picProfilePic.TabIndex = 55;
            this.picProfilePic.TabStop = false;
            // 
            // mtbZip
            // 
            this.mtbZip.Location = new System.Drawing.Point(596, 74);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(93, 20);
            this.mtbZip.TabIndex = 9;
            this.mtbZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(943, 626);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 30);
            this.btnSave.TabIndex = 53;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(869, 626);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 30);
            this.btnClear.TabIndex = 47;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(374, 116);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(315, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(374, 197);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(20, 197);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(315, 20);
            this.mtbPhone.TabIndex = 6;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtmDOB
            // 
            this.dtmDOB.Location = new System.Drawing.Point(20, 156);
            this.dtmDOB.Name = "dtmDOB";
            this.dtmDOB.Size = new System.Drawing.Size(200, 20);
            this.dtmDOB.TabIndex = 5;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(20, 140);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(66, 13);
            this.Label12.TabIndex = 46;
            this.Label12.Text = "Date of Birth";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(374, 74);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtMailing
            // 
            this.txtMailing.Location = new System.Drawing.Point(374, 33);
            this.txtMailing.MaxLength = 50;
            this.txtMailing.Name = "txtMailing";
            this.txtMailing.Size = new System.Drawing.Size(315, 20);
            this.txtMailing.TabIndex = 7;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(20, 74);
            this.txtMiddleInitial.MaxLength = 2;
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(106, 20);
            this.txtMiddleInitial.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(20, 115);
            this.txtLName.MaxLength = 30;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(315, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(20, 33);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(315, 20);
            this.txtFName.TabIndex = 2;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(374, 100);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(60, 13);
            this.Label11.TabIndex = 41;
            this.Label11.Text = "User Name";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(20, 181);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(78, 13);
            this.Label9.TabIndex = 39;
            this.Label9.Text = "Phone Number";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(593, 60);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(24, 13);
            this.Label8.TabIndex = 38;
            this.Label8.Text = "ZIP";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(374, 181);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 13);
            this.Label7.TabIndex = 37;
            this.Label7.Text = "Email";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(374, 59);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(24, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "City";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(374, 17);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(81, 13);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "Mailing Address";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(20, 59);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "Middle Initial";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(20, 100);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Last Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(20, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "First Name";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(583, 356);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(89, 13);
            this.Label14.TabIndex = 62;
            this.Label14.Text = "Current Accounts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Customer Picture";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(727, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Customer Signature";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(236, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 23);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProfileID
            // 
            this.txtProfileID.Location = new System.Drawing.Point(19, 51);
            this.txtProfileID.Name = "txtProfileID";
            this.txtProfileID.Size = new System.Drawing.Size(315, 20);
            this.txtProfileID.TabIndex = 1;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(19, 35);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(50, 13);
            this.Label17.TabIndex = 66;
            this.Label17.Text = "Profile ID";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(374, 138);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(53, 13);
            this.Label10.TabIndex = 40;
            this.Label10.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(374, 154);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUpdate);
            this.groupBox1.Controls.Add(this.radNewCustomer);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtProfileID);
            this.groupBox1.Controls.Add(this.Label17);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 110);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Search";
            // 
            // radUpdate
            // 
            this.radUpdate.AutoSize = true;
            this.radUpdate.Location = new System.Drawing.Point(125, 15);
            this.radUpdate.Name = "radUpdate";
            this.radUpdate.Size = new System.Drawing.Size(90, 17);
            this.radUpdate.TabIndex = 71;
            this.radUpdate.Text = "Update Mode";
            this.radUpdate.UseVisualStyleBackColor = true;
            // 
            // radNewCustomer
            // 
            this.radNewCustomer.AutoSize = true;
            this.radNewCustomer.Location = new System.Drawing.Point(22, 15);
            this.radNewCustomer.Name = "radNewCustomer";
            this.radNewCustomer.Size = new System.Drawing.Size(94, 17);
            this.radNewCustomer.TabIndex = 70;
            this.radNewCustomer.Text = "New Customer";
            this.radNewCustomer.UseVisualStyleBackColor = true;
            // 
            // grpProfileInfo
            // 
            this.grpProfileInfo.Controls.Add(this.lvwAccounts);
            this.grpProfileInfo.Controls.Add(this.label15);
            this.grpProfileInfo.Controls.Add(this.mtbZip);
            this.grpProfileInfo.Controls.Add(this.txtPassword);
            this.grpProfileInfo.Controls.Add(this.txtUsername);
            this.grpProfileInfo.Controls.Add(this.txtEmail);
            this.grpProfileInfo.Controls.Add(this.mtbPhone);
            this.grpProfileInfo.Controls.Add(this.dtmDOB);
            this.grpProfileInfo.Controls.Add(this.Label12);
            this.grpProfileInfo.Controls.Add(this.txtCity);
            this.grpProfileInfo.Controls.Add(this.txtMailing);
            this.grpProfileInfo.Controls.Add(this.txtMiddleInitial);
            this.grpProfileInfo.Controls.Add(this.txtLName);
            this.grpProfileInfo.Controls.Add(this.txtFName);
            this.grpProfileInfo.Controls.Add(this.Label11);
            this.grpProfileInfo.Controls.Add(this.Label10);
            this.grpProfileInfo.Controls.Add(this.Label9);
            this.grpProfileInfo.Controls.Add(this.Label8);
            this.grpProfileInfo.Controls.Add(this.Label7);
            this.grpProfileInfo.Controls.Add(this.Label6);
            this.grpProfileInfo.Controls.Add(this.Label5);
            this.grpProfileInfo.Controls.Add(this.Label4);
            this.grpProfileInfo.Controls.Add(this.Label3);
            this.grpProfileInfo.Controls.Add(this.Label2);
            this.grpProfileInfo.Location = new System.Drawing.Point(11, 230);
            this.grpProfileInfo.Name = "grpProfileInfo";
            this.grpProfileInfo.Size = new System.Drawing.Size(713, 457);
            this.grpProfileInfo.TabIndex = 71;
            this.grpProfileInfo.TabStop = false;
            this.grpProfileInfo.Text = "Customer Profile";
            // 
            // lvwAccounts
            // 
            this.lvwAccounts.HideSelection = false;
            this.lvwAccounts.Location = new System.Drawing.Point(20, 240);
            this.lvwAccounts.Name = "lvwAccounts";
            this.lvwAccounts.Size = new System.Drawing.Size(669, 186);
            this.lvwAccounts.TabIndex = 73;
            this.lvwAccounts.UseCompatibleStateImageBehavior = false;
            this.lvwAccounts.View = System.Windows.Forms.View.Details;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "Accounts";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip1.TabIndex = 72;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(730, 626);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(84, 30);
            this.btnExport.TabIndex = 73;
            this.btnExport.TabStop = false;
            this.btnExport.Text = "Export Profile";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_click);
            // 
            // frmProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 687);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpProfileInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.btnUploadCustomerSignature);
            this.Controls.Add(this.btnUploadProfilePic);
            this.Controls.Add(this.picCustomerSignature);
            this.Controls.Add(this.picProfilePic);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfiles";
            this.Load += new System.EventHandler(this.frmProfiles_Load);
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpProfileInfo.ResumeLayout(false);
            this.grpProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblInfo;
        internal System.Windows.Forms.ToolStrip tsTools;
        internal System.Windows.Forms.ToolStripButton tsbHome;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton tsbProfileCenter;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton tsbAccountCenter;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripButton tsbDeposit;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton tsbWithdrawal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton tsbChecks;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripButton tsbCCApp;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator11;
        internal System.Windows.Forms.ToolStripButton tsbLoans;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        internal System.Windows.Forms.ToolStripButton tsbLogOut;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripButton tsbHelp;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbPayment;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.Button btnUploadCustomerSignature;
        internal System.Windows.Forms.Button btnUploadProfilePic;
        internal System.Windows.Forms.PictureBox picCustomerSignature;
        internal System.Windows.Forms.PictureBox picProfilePic;
        internal System.Windows.Forms.MaskedTextBox mtbZip;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.MaskedTextBox mtbPhone;
        internal System.Windows.Forms.DateTimePicker dtmDOB;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtMailing;
        internal System.Windows.Forms.TextBox txtMiddleInitial;
        internal System.Windows.Forms.TextBox txtLName;
        internal System.Windows.Forms.TextBox txtFName;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtProfileID;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox grpProfileInfo;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.RadioButton radUpdate;
        private System.Windows.Forms.RadioButton radNewCustomer;
        internal System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdDialog;
        private System.Windows.Forms.ListView lvwAccounts;
    }
}