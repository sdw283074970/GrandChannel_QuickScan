namespace Scanner_SDK_Sample_Application
{
    partial class frmScannerApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScannerApp));
            this.grpboxBarcodeLbl = new System.Windows.Forms.GroupBox();
            this.tbCartonRange = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.tbPcs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbContainerNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbBatchId = new System.Windows.Forms.TextBox();
            this.btnUploadMinus = new System.Windows.Forms.Button();
            this.btnUploadAdd = new System.Windows.Forms.Button();
            this.lblSyblogy = new System.Windows.Forms.Label();
            this.txtSyblogy = new System.Windows.Forms.TextBox();
            this.lblDecdBarCde = new System.Windows.Forms.Label();
            this.txtBarcodeLbl = new System.Windows.Forms.TextBox();
            this.btnAbortMacroPdf = new System.Windows.Forms.Button();
            this.btnBarcodeClear = new System.Windows.Forms.Button();
            this.btnFlushMacroPdf = new System.Windows.Forms.Button();
            this.grpTrigger = new System.Windows.Forms.GroupBox();
            this.btnReleaseTrigger = new System.Windows.Forms.Button();
            this.btnPullTrigger = new System.Windows.Forms.Button();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblSlctScnnr = new System.Windows.Forms.Label();
            this.combSlcrScnr = new System.Windows.Forms.ComboBox();
            this.grpScanners = new System.Windows.Forms.GroupBox();
            this.lstvScanners = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFrmwr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMnftrd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetScanners = new System.Windows.Forms.Button();
            this.openFileDialogFW = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNewEpcId = new System.Windows.Forms.TextBox();
            this.chkAutoIncrement = new System.Windows.Forms.CheckBox();
            this.tabISO15434 = new System.Windows.Forms.TabPage();
            this.grpIDC = new System.Windows.Forms.GroupBox();
            this.pbxISO15434Image = new System.Windows.Forms.PictureBox();
            this.btnClearpbx = new System.Windows.Forms.Button();
            this.checkUseHID = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSnapiStore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSnapiParamValue = new System.Windows.Forms.ComboBox();
            this.btnSnapiSet = new System.Windows.Forms.Button();
            this.btnSnapiGet = new System.Windows.Forms.Button();
            this.cmbSnapiParams = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocCapDecodeDataSymbol = new System.Windows.Forms.TextBox();
            this.txtDocCapDecodeData = new System.Windows.Forms.TextBox();
            this.openFileDialogAttr = new System.Windows.Forms.OpenFileDialog();
            this.stStripResult = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblIbmhid = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblSnapi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIBMTT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblHidkb = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblSsi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblNxmdb = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveImgFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogWavFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDADF = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogBarcodePath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabXml = new System.Windows.Forms.TabPage();
            this.btnClearXmlArea = new System.Windows.Forms.Button();
            this.btnClearLogsArea = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.grpOutXml = new System.Windows.Forms.GroupBox();
            this.txtOutXml = new System.Windows.Forms.TextBox();
            this.tabSSW = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEpcId = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtUserBank = new System.Windows.Forms.TextBox();
            this.txtUpcaBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.rdoASCII = new System.Windows.Forms.RadioButton();
            this.btnVerifyTag = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteTag = new System.Windows.Forms.Button();
            this.cmbPartition = new System.Windows.Forms.ComboBox();
            this.cmbFilterValue = new System.Windows.Forms.ComboBox();
            this.statusIcon = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblUserBank = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabScale = new System.Windows.Forms.TabPage();
            this.grpScale = new System.Windows.Forms.GroupBox();
            this.lblScalStatusDesc = new System.Windows.Forms.Label();
            this.txtWeightUnit = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSystemRest = new System.Windows.Forms.Button();
            this.btnZeroScale = new System.Windows.Forms.Button();
            this.btnReadWeight = new System.Windows.Forms.Button();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.grpMiscOther = new System.Windows.Forms.GroupBox();
            this.grpMiscCmd = new System.Windows.Forms.GroupBox();
            this.btnGetDevTopology = new System.Windows.Forms.Button();
            this.btnSdkVersion = new System.Windows.Forms.Button();
            this.grpAsync = new System.Windows.Forms.GroupBox();
            this.chkAsync = new System.Windows.Forms.CheckBox();
            this.grpBaudrate = new System.Windows.Forms.GroupBox();
            this.lblStpBits = new System.Windows.Forms.Label();
            this.comboStpBits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.btnSetSrilInfce = new System.Windows.Forms.Button();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.lblBaudRte = new System.Windows.Forms.Label();
            this.comboDataBits = new System.Windows.Forms.ComboBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.flwCtrlChkBox = new System.Windows.Forms.CheckBox();
            this.tabScan2Connect = new System.Windows.Forms.TabPage();
            this.grpScan2Connect = new System.Windows.Forms.GroupBox();
            this.btnSaveBarcode = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbHostName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbScannerType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picBBarcode = new System.Windows.Forms.PictureBox();
            this.cmbImageSize = new System.Windows.Forms.ComboBox();
            this.cmbDefaultOption = new System.Windows.Forms.ComboBox();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.grpCustomDecodeTone = new System.Windows.Forms.GroupBox();
            this.btnEraseTone = new System.Windows.Forms.Button();
            this.buttonWavFileUpload = new System.Windows.Forms.Button();
            this.textBoxWavFile = new System.Windows.Forms.TextBox();
            this.buttonWavFileBrowse = new System.Windows.Forms.Button();
            this.filterScnrs = new System.Windows.Forms.GroupBox();
            this.comboFilterScnrs = new System.Windows.Forms.ComboBox();
            this.grpFrmWrUpdate = new System.Windows.Forms.GroupBox();
            this.grpFWoptns = new System.Windows.Forms.GroupBox();
            this.chkBulk = new System.Windows.Forms.CheckBox();
            this.btnAbortFWUpdate = new System.Windows.Forms.Button();
            this.btnFWUpdate = new System.Windows.Forms.Button();
            this.btnLaunchNewFW = new System.Windows.Forms.Button();
            this.progressBarFWUpdate = new System.Windows.Forms.ProgressBar();
            this.buttonFWBrowse = new System.Windows.Forms.Button();
            this.txtFWFile = new System.Windows.Forms.TextBox();
            this.grpScannerProp = new System.Windows.Forms.GroupBox();
            this.chkClaim = new System.Windows.Forms.CheckBox();
            this.tabRsm = new System.Windows.Forms.TabPage();
            this.grpRSM = new System.Windows.Forms.GroupBox();
            this.grpBoxClrSlect = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.grpBoxSetRset = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnGetNext = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.dgvAttributes = new System.Windows.Forms.DataGridView();
            this.attrNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabScnAction = new System.Windows.Forms.TabPage();
            this.grpScnActions = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grpHVS = new System.Windows.Forms.GroupBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.chkShmPermChange = new System.Windows.Forms.CheckBox();
            this.chkShmSilentSwitch = new System.Windows.Forms.CheckBox();
            this.btnSwitchHostMode = new System.Windows.Forms.Button();
            this.grpReboot = new System.Windows.Forms.GroupBox();
            this.btnRebootScanner = new System.Windows.Forms.Button();
            this.grpEnbDisScanner = new System.Windows.Forms.GroupBox();
            this.chkScannerEnable = new System.Windows.Forms.CheckBox();
            this.grpBeeper = new System.Windows.Forms.GroupBox();
            this.comboBeep = new System.Windows.Forms.ComboBox();
            this.btnSoundBeeper = new System.Windows.Forms.Button();
            this.grpLed = new System.Windows.Forms.GroupBox();
            this.cmbLed = new System.Windows.Forms.ComboBox();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.btnLedOn = new System.Windows.Forms.Button();
            this.grpAim = new System.Windows.Forms.GroupBox();
            this.btnAimOn = new System.Windows.Forms.Button();
            this.btnAimOff = new System.Windows.Forms.Button();
            this.tabImgVdo = new System.Windows.Forms.TabPage();
            this.grpImageVideo = new System.Windows.Forms.GroupBox();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.chkVideoViewFinderEnable = new System.Windows.Forms.CheckBox();
            this.btnSveImge = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnAbortImageXfer = new System.Windows.Forms.Button();
            this.grpBoxImgType = new System.Windows.Forms.GroupBox();
            this.rdoJPG = new System.Windows.Forms.RadioButton();
            this.rdoTIFF = new System.Windows.Forms.RadioButton();
            this.rdoBMP = new System.Windows.Forms.RadioButton();
            this.pbxImageVideo = new System.Windows.Forms.PictureBox();
            this.tabBarcode = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.upcList = new System.Windows.Forms.ListView();
            this.colUPC1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStyle1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOperation1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseScript = new System.Windows.Forms.Button();
            this.chkBoxAppADF = new System.Windows.Forms.CheckBox();
            this.grpBoxLanguage = new System.Windows.Forms.GroupBox();
            this.btnScriptEditor = new System.Windows.Forms.Button();
            this.cmbEmulation = new System.Windows.Forms.ComboBox();
            this.chkBoxEmulation = new System.Windows.Forms.CheckBox();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.barcodeGridView = new System.Windows.Forms.DataGridView();
            this.colUPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpboxBarcodeLbl.SuspendLayout();
            this.grpTrigger.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpScanners.SuspendLayout();
            this.tabISO15434.SuspendLayout();
            this.grpIDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxISO15434Image)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stStripResult.SuspendLayout();
            this.tabXml.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.grpOutXml.SuspendLayout();
            this.tabSSW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).BeginInit();
            this.tabScale.SuspendLayout();
            this.grpScale.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.grpMiscOther.SuspendLayout();
            this.grpMiscCmd.SuspendLayout();
            this.grpAsync.SuspendLayout();
            this.grpBaudrate.SuspendLayout();
            this.tabScan2Connect.SuspendLayout();
            this.grpScan2Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarcode)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.grpCustomDecodeTone.SuspendLayout();
            this.filterScnrs.SuspendLayout();
            this.grpFrmWrUpdate.SuspendLayout();
            this.grpFWoptns.SuspendLayout();
            this.grpScannerProp.SuspendLayout();
            this.tabRsm.SuspendLayout();
            this.grpRSM.SuspendLayout();
            this.grpBoxClrSlect.SuspendLayout();
            this.grpBoxSetRset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).BeginInit();
            this.tabScnAction.SuspendLayout();
            this.grpScnActions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpHVS.SuspendLayout();
            this.grpReboot.SuspendLayout();
            this.grpEnbDisScanner.SuspendLayout();
            this.grpBeeper.SuspendLayout();
            this.grpLed.SuspendLayout();
            this.grpAim.SuspendLayout();
            this.tabImgVdo.SuspendLayout();
            this.grpImageVideo.SuspendLayout();
            this.grpBoxImgType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageVideo)).BeginInit();
            this.tabBarcode.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxLanguage.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxBarcodeLbl
            // 
            this.grpboxBarcodeLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpboxBarcodeLbl.Controls.Add(this.tbCartonRange);
            this.grpboxBarcodeLbl.Controls.Add(this.label19);
            this.grpboxBarcodeLbl.Controls.Add(this.lbStatus);
            this.grpboxBarcodeLbl.Controls.Add(this.tbResult);
            this.grpboxBarcodeLbl.Controls.Add(this.label18);
            this.grpboxBarcodeLbl.Controls.Add(this.btnAddBatch);
            this.grpboxBarcodeLbl.Controls.Add(this.tbPcs);
            this.grpboxBarcodeLbl.Controls.Add(this.label15);
            this.grpboxBarcodeLbl.Controls.Add(this.label17);
            this.grpboxBarcodeLbl.Controls.Add(this.lbTotal);
            this.grpboxBarcodeLbl.Controls.Add(this.tbContainerNumber);
            this.grpboxBarcodeLbl.Controls.Add(this.label16);
            this.grpboxBarcodeLbl.Controls.Add(this.tbBatchId);
            this.grpboxBarcodeLbl.Controls.Add(this.btnUploadMinus);
            this.grpboxBarcodeLbl.Controls.Add(this.btnUploadAdd);
            this.grpboxBarcodeLbl.Controls.Add(this.lblSyblogy);
            this.grpboxBarcodeLbl.Controls.Add(this.txtSyblogy);
            this.grpboxBarcodeLbl.Controls.Add(this.lblDecdBarCde);
            this.grpboxBarcodeLbl.Controls.Add(this.txtBarcodeLbl);
            this.grpboxBarcodeLbl.Controls.Add(this.btnAbortMacroPdf);
            this.grpboxBarcodeLbl.Controls.Add(this.btnBarcodeClear);
            this.grpboxBarcodeLbl.Controls.Add(this.btnFlushMacroPdf);
            this.grpboxBarcodeLbl.Location = new System.Drawing.Point(6, 518);
            this.grpboxBarcodeLbl.Name = "grpboxBarcodeLbl";
            this.grpboxBarcodeLbl.Size = new System.Drawing.Size(557, 174);
            this.grpboxBarcodeLbl.TabIndex = 1;
            this.grpboxBarcodeLbl.TabStop = false;
            this.grpboxBarcodeLbl.Text = "Barcode Scanning";
            // 
            // tbCartonRange
            // 
            this.tbCartonRange.BackColor = System.Drawing.Color.White;
            this.tbCartonRange.Location = new System.Drawing.Point(443, 51);
            this.tbCartonRange.Multiline = true;
            this.tbCartonRange.Name = "tbCartonRange";
            this.tbCartonRange.Size = new System.Drawing.Size(104, 20);
            this.tbCartonRange.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(379, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "No. Range";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(398, 74);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 51;
            this.lbStatus.Text = "Status";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Gainsboro;
            this.tbResult.Location = new System.Drawing.Point(18, 93);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(529, 41);
            this.tbResult.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "Result";
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.Location = new System.Drawing.Point(493, 19);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(54, 23);
            this.btnAddBatch.TabIndex = 49;
            this.btnAddBatch.Text = "Add";
            this.btnAddBatch.UseVisualStyleBackColor = true;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // tbPcs
            // 
            this.tbPcs.BackColor = System.Drawing.Color.White;
            this.tbPcs.Location = new System.Drawing.Point(443, 21);
            this.tbPcs.Multiline = true;
            this.tbPcs.Name = "tbPcs";
            this.tbPcs.Size = new System.Drawing.Size(44, 20);
            this.tbPcs.TabIndex = 48;
            this.tbPcs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPcs_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Batch Id";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(389, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Quantity";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(464, 74);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(61, 13);
            this.lbTotal.TabIndex = 46;
            this.lbTotal.Text = "Total Pcs:0";
            // 
            // tbContainerNumber
            // 
            this.tbContainerNumber.BackColor = System.Drawing.Color.White;
            this.tbContainerNumber.Location = new System.Drawing.Point(103, 48);
            this.tbContainerNumber.Name = "tbContainerNumber";
            this.tbContainerNumber.Size = new System.Drawing.Size(99, 20);
            this.tbContainerNumber.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Container #";
            // 
            // tbBatchId
            // 
            this.tbBatchId.BackColor = System.Drawing.Color.White;
            this.tbBatchId.Location = new System.Drawing.Point(269, 50);
            this.tbBatchId.Name = "tbBatchId";
            this.tbBatchId.Size = new System.Drawing.Size(104, 20);
            this.tbBatchId.TabIndex = 43;
            this.tbBatchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatchId_KeyPress);
            // 
            // btnUploadMinus
            // 
            this.btnUploadMinus.Location = new System.Drawing.Point(133, 141);
            this.btnUploadMinus.Name = "btnUploadMinus";
            this.btnUploadMinus.Size = new System.Drawing.Size(105, 23);
            this.btnUploadMinus.TabIndex = 41;
            this.btnUploadMinus.Text = "Upload (Minus)";
            this.btnUploadMinus.UseVisualStyleBackColor = true;
            this.btnUploadMinus.Click += new System.EventHandler(this.btnUploadMinus_Clik);
            // 
            // btnUploadAdd
            // 
            this.btnUploadAdd.Location = new System.Drawing.Point(18, 141);
            this.btnUploadAdd.Name = "btnUploadAdd";
            this.btnUploadAdd.Size = new System.Drawing.Size(105, 23);
            this.btnUploadAdd.TabIndex = 40;
            this.btnUploadAdd.Text = "Upload (Add)";
            this.btnUploadAdd.UseVisualStyleBackColor = true;
            this.btnUploadAdd.Click += new System.EventHandler(this.btnUploadAdd_Click);
            // 
            // lblSyblogy
            // 
            this.lblSyblogy.AutoSize = true;
            this.lblSyblogy.Location = new System.Drawing.Point(208, 21);
            this.lblSyblogy.Name = "lblSyblogy";
            this.lblSyblogy.Size = new System.Drawing.Size(58, 13);
            this.lblSyblogy.TabIndex = 39;
            this.lblSyblogy.Text = "Symbology";
            // 
            // txtSyblogy
            // 
            this.txtSyblogy.BackColor = System.Drawing.Color.White;
            this.txtSyblogy.Location = new System.Drawing.Point(269, 19);
            this.txtSyblogy.Name = "txtSyblogy";
            this.txtSyblogy.ReadOnly = true;
            this.txtSyblogy.Size = new System.Drawing.Size(104, 20);
            this.txtSyblogy.TabIndex = 1;
            // 
            // lblDecdBarCde
            // 
            this.lblDecdBarCde.AutoSize = true;
            this.lblDecdBarCde.Location = new System.Drawing.Point(3, 21);
            this.lblDecdBarCde.Name = "lblDecdBarCde";
            this.lblDecdBarCde.Size = new System.Drawing.Size(94, 13);
            this.lblDecdBarCde.TabIndex = 0;
            this.lblDecdBarCde.Text = "Decoded Barcode";
            // 
            // txtBarcodeLbl
            // 
            this.txtBarcodeLbl.BackColor = System.Drawing.Color.White;
            this.txtBarcodeLbl.Location = new System.Drawing.Point(103, 18);
            this.txtBarcodeLbl.Multiline = true;
            this.txtBarcodeLbl.Name = "txtBarcodeLbl";
            this.txtBarcodeLbl.Size = new System.Drawing.Size(99, 20);
            this.txtBarcodeLbl.TabIndex = 0;
            // 
            // btnAbortMacroPdf
            // 
            this.btnAbortMacroPdf.Location = new System.Drawing.Point(246, 141);
            this.btnAbortMacroPdf.Name = "btnAbortMacroPdf";
            this.btnAbortMacroPdf.Size = new System.Drawing.Size(104, 23);
            this.btnAbortMacroPdf.TabIndex = 3;
            this.btnAbortMacroPdf.Text = "Abort Macro PDF";
            this.btnAbortMacroPdf.UseVisualStyleBackColor = true;
            this.btnAbortMacroPdf.Visible = false;
            this.btnAbortMacroPdf.Click += new System.EventHandler(this.btnAbortMacroPdf_Click);
            // 
            // btnBarcodeClear
            // 
            this.btnBarcodeClear.Location = new System.Drawing.Point(444, 140);
            this.btnBarcodeClear.Name = "btnBarcodeClear";
            this.btnBarcodeClear.Size = new System.Drawing.Size(103, 23);
            this.btnBarcodeClear.TabIndex = 4;
            this.btnBarcodeClear.Text = "Clear";
            this.btnBarcodeClear.UseVisualStyleBackColor = true;
            this.btnBarcodeClear.Click += new System.EventHandler(this.btnBarcodeClear_Click);
            // 
            // btnFlushMacroPdf
            // 
            this.btnFlushMacroPdf.Location = new System.Drawing.Point(246, 141);
            this.btnFlushMacroPdf.Name = "btnFlushMacroPdf";
            this.btnFlushMacroPdf.Size = new System.Drawing.Size(104, 23);
            this.btnFlushMacroPdf.TabIndex = 2;
            this.btnFlushMacroPdf.Text = "Flush Macro PDF";
            this.btnFlushMacroPdf.UseVisualStyleBackColor = true;
            this.btnFlushMacroPdf.Visible = false;
            this.btnFlushMacroPdf.Click += new System.EventHandler(this.btnFlushMacroPdf_Click);
            // 
            // grpTrigger
            // 
            this.grpTrigger.Controls.Add(this.btnReleaseTrigger);
            this.grpTrigger.Controls.Add(this.btnPullTrigger);
            this.grpTrigger.Location = new System.Drawing.Point(7, 673);
            this.grpTrigger.Name = "grpTrigger";
            this.grpTrigger.Size = new System.Drawing.Size(460, 53);
            this.grpTrigger.TabIndex = 3;
            this.grpTrigger.TabStop = false;
            this.grpTrigger.Text = "Soft Trigger";
            // 
            // btnReleaseTrigger
            // 
            this.btnReleaseTrigger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReleaseTrigger.Location = new System.Drawing.Point(290, 19);
            this.btnReleaseTrigger.Name = "btnReleaseTrigger";
            this.btnReleaseTrigger.Size = new System.Drawing.Size(110, 23);
            this.btnReleaseTrigger.TabIndex = 1;
            this.btnReleaseTrigger.Text = "Release Trigger";
            this.btnReleaseTrigger.UseVisualStyleBackColor = false;
            this.btnReleaseTrigger.Click += new System.EventHandler(this.btnReleaseTrigger_Click);
            // 
            // btnPullTrigger
            // 
            this.btnPullTrigger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPullTrigger.Location = new System.Drawing.Point(32, 19);
            this.btnPullTrigger.Name = "btnPullTrigger";
            this.btnPullTrigger.Size = new System.Drawing.Size(110, 23);
            this.btnPullTrigger.TabIndex = 0;
            this.btnPullTrigger.Text = "Pull Trigger";
            this.btnPullTrigger.UseVisualStyleBackColor = false;
            this.btnPullTrigger.Click += new System.EventHandler(this.btnPullTrigger_Click);
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Location = new System.Drawing.Point(0, 0);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(200, 100);
            this.gbAdvanced.TabIndex = 0;
            this.gbAdvanced.TabStop = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblSlctScnnr);
            this.grpGeneral.Controls.Add(this.combSlcrScnr);
            this.grpGeneral.Controls.Add(this.grpScanners);
            this.grpGeneral.Controls.Add(this.btnGetScanners);
            this.grpGeneral.Location = new System.Drawing.Point(7, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(460, 655);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Selected Scanners";
            // 
            // lblSlctScnnr
            // 
            this.lblSlctScnnr.AutoSize = true;
            this.lblSlctScnnr.Location = new System.Drawing.Point(153, 52);
            this.lblSlctScnnr.Name = "lblSlctScnnr";
            this.lblSlctScnnr.Size = new System.Drawing.Size(80, 13);
            this.lblSlctScnnr.TabIndex = 66;
            this.lblSlctScnnr.Text = "Select Scanner";
            // 
            // combSlcrScnr
            // 
            this.combSlcrScnr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSlcrScnr.FormattingEnabled = true;
            this.combSlcrScnr.Location = new System.Drawing.Point(246, 50);
            this.combSlcrScnr.Name = "combSlcrScnr";
            this.combSlcrScnr.Size = new System.Drawing.Size(183, 21);
            this.combSlcrScnr.TabIndex = 1;
            this.combSlcrScnr.SelectedIndexChanged += new System.EventHandler(this.combSlcrScnr_SelectedIndexChanged);
            // 
            // grpScanners
            // 
            this.grpScanners.Controls.Add(this.lstvScanners);
            this.grpScanners.Location = new System.Drawing.Point(8, 91);
            this.grpScanners.Name = "grpScanners";
            this.grpScanners.Size = new System.Drawing.Size(446, 558);
            this.grpScanners.TabIndex = 2;
            this.grpScanners.TabStop = false;
            this.grpScanners.Text = "Connected Scanners";
            // 
            // lstvScanners
            // 
            this.lstvScanners.BackColor = System.Drawing.Color.White;
            this.lstvScanners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmType,
            this.clmModel,
            this.clmFrmwr,
            this.clmMnftrd,
            this.clmSerial,
            this.clmGuid});
            this.lstvScanners.FullRowSelect = true;
            this.lstvScanners.GridLines = true;
            this.lstvScanners.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvScanners.HideSelection = false;
            this.lstvScanners.Location = new System.Drawing.Point(6, 19);
            this.lstvScanners.MultiSelect = false;
            this.lstvScanners.Name = "lstvScanners";
            this.lstvScanners.ShowItemToolTips = true;
            this.lstvScanners.Size = new System.Drawing.Size(434, 533);
            this.lstvScanners.TabIndex = 0;
            this.lstvScanners.UseCompatibleStateImageBehavior = false;
            this.lstvScanners.View = System.Windows.Forms.View.Details;
            this.lstvScanners.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstvScanners_ItemSelectionChanged);
            this.lstvScanners.SelectedIndexChanged += new System.EventHandler(this.lstvScanners_SelectedIndexChanged);
            // 
            // clmId
            // 
            this.clmId.Text = "#";
            this.clmId.Width = 30;
            // 
            // clmType
            // 
            this.clmType.Text = "Com Interface";
            this.clmType.Width = 94;
            // 
            // clmModel
            // 
            this.clmModel.Text = "Model #";
            this.clmModel.Width = 132;
            // 
            // clmFrmwr
            // 
            this.clmFrmwr.Text = "Firmware";
            this.clmFrmwr.Width = 119;
            // 
            // clmMnftrd
            // 
            this.clmMnftrd.Text = "Built";
            // 
            // clmSerial
            // 
            this.clmSerial.Text = "Serial # or Port #";
            this.clmSerial.Width = 120;
            // 
            // clmGuid
            // 
            this.clmGuid.Text = "GUID";
            this.clmGuid.Width = 110;
            // 
            // btnGetScanners
            // 
            this.btnGetScanners.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGetScanners.Location = new System.Drawing.Point(26, 48);
            this.btnGetScanners.Name = "btnGetScanners";
            this.btnGetScanners.Size = new System.Drawing.Size(124, 23);
            this.btnGetScanners.TabIndex = 0;
            this.btnGetScanners.Text = "Discover Scanners";
            this.btnGetScanners.UseVisualStyleBackColor = false;
            this.btnGetScanners.Click += new System.EventHandler(this.btnGetScanners_Click);
            // 
            // openFileDialogFW
            // 
            this.openFileDialogFW.Filter = "Firmware files (*.dat)|*.dat|Plugin Files (*.SCNPLG)|*.SCNPLG";
            // 
            // txtNewEpcId
            // 
            this.txtNewEpcId.BackColor = System.Drawing.Color.White;
            this.txtNewEpcId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewEpcId.Location = new System.Drawing.Point(94, 80);
            this.txtNewEpcId.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewEpcId.Name = "txtNewEpcId";
            this.txtNewEpcId.ReadOnly = true;
            this.txtNewEpcId.Size = new System.Drawing.Size(193, 20);
            this.txtNewEpcId.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNewEpcId, "SGTIN 96 encoded");
            // 
            // chkAutoIncrement
            // 
            this.chkAutoIncrement.AutoSize = true;
            this.chkAutoIncrement.Location = new System.Drawing.Point(408, 107);
            this.chkAutoIncrement.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoIncrement.Name = "chkAutoIncrement";
            this.chkAutoIncrement.Size = new System.Drawing.Size(97, 17);
            this.chkAutoIncrement.TabIndex = 8;
            this.chkAutoIncrement.Text = "Auto increment";
            this.toolTip1.SetToolTip(this.chkAutoIncrement, "Increment provided serial number and write tags continuously.");
            this.chkAutoIncrement.UseVisualStyleBackColor = true;
            // 
            // tabISO15434
            // 
            this.tabISO15434.Controls.Add(this.grpIDC);
            this.tabISO15434.Location = new System.Drawing.Point(4, 22);
            this.tabISO15434.Name = "tabISO15434";
            this.tabISO15434.Padding = new System.Windows.Forms.Padding(3);
            this.tabISO15434.Size = new System.Drawing.Size(567, 698);
            this.tabISO15434.TabIndex = 9;
            this.tabISO15434.Text = "IDC";
            this.toolTip1.SetToolTip(this.tabISO15434, "Intelligent Document Capture");
            this.tabISO15434.ToolTipText = "Intelligent Document Capture";
            this.tabISO15434.UseVisualStyleBackColor = true;
            // 
            // grpIDC
            // 
            this.grpIDC.Controls.Add(this.pbxISO15434Image);
            this.grpIDC.Controls.Add(this.btnClearpbx);
            this.grpIDC.Controls.Add(this.checkUseHID);
            this.grpIDC.Controls.Add(this.groupBox3);
            this.grpIDC.Controls.Add(this.groupBox2);
            this.grpIDC.Enabled = false;
            this.grpIDC.Location = new System.Drawing.Point(6, 6);
            this.grpIDC.Name = "grpIDC";
            this.grpIDC.Size = new System.Drawing.Size(493, 456);
            this.grpIDC.TabIndex = 0;
            this.grpIDC.TabStop = false;
            // 
            // pbxISO15434Image
            // 
            this.pbxISO15434Image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbxISO15434Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxISO15434Image.Location = new System.Drawing.Point(6, 19);
            this.pbxISO15434Image.MaximumSize = new System.Drawing.Size(481, 299);
            this.pbxISO15434Image.Name = "pbxISO15434Image";
            this.pbxISO15434Image.Size = new System.Drawing.Size(481, 299);
            this.pbxISO15434Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxISO15434Image.TabIndex = 0;
            this.pbxISO15434Image.TabStop = false;
            // 
            // btnClearpbx
            // 
            this.btnClearpbx.Location = new System.Drawing.Point(424, 426);
            this.btnClearpbx.Name = "btnClearpbx";
            this.btnClearpbx.Size = new System.Drawing.Size(63, 23);
            this.btnClearpbx.TabIndex = 3;
            this.btnClearpbx.Text = "Clear";
            this.btnClearpbx.UseVisualStyleBackColor = true;
            this.btnClearpbx.Click += new System.EventHandler(this.btnClearpbx_Click);
            // 
            // checkUseHID
            // 
            this.checkUseHID.AutoSize = true;
            this.checkUseHID.Location = new System.Drawing.Point(205, 430);
            this.checkUseHID.Name = "checkUseHID";
            this.checkUseHID.Size = new System.Drawing.Size(67, 17);
            this.checkUseHID.TabIndex = 2;
            this.checkUseHID.Text = "Use HID";
            this.checkUseHID.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSnapiStore);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbSnapiParamValue);
            this.groupBox3.Controls.Add(this.btnSnapiSet);
            this.groupBox3.Controls.Add(this.btnSnapiGet);
            this.groupBox3.Controls.Add(this.cmbSnapiParams);
            this.groupBox3.Location = new System.Drawing.Point(6, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 119);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // btnSnapiStore
            // 
            this.btnSnapiStore.Location = new System.Drawing.Point(135, 55);
            this.btnSnapiStore.Name = "btnSnapiStore";
            this.btnSnapiStore.Size = new System.Drawing.Size(52, 21);
            this.btnSnapiStore.TabIndex = 4;
            this.btnSnapiStore.Text = "Store";
            this.btnSnapiStore.UseVisualStyleBackColor = true;
            this.btnSnapiStore.Click += new System.EventHandler(this.btnSnapiStore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // cmbSnapiParamValue
            // 
            this.cmbSnapiParamValue.FormattingEnabled = true;
            this.cmbSnapiParamValue.Location = new System.Drawing.Point(46, 87);
            this.cmbSnapiParamValue.Name = "cmbSnapiParamValue";
            this.cmbSnapiParamValue.Size = new System.Drawing.Size(141, 21);
            this.cmbSnapiParamValue.TabIndex = 2;
            // 
            // btnSnapiSet
            // 
            this.btnSnapiSet.Location = new System.Drawing.Point(77, 55);
            this.btnSnapiSet.Name = "btnSnapiSet";
            this.btnSnapiSet.Size = new System.Drawing.Size(52, 21);
            this.btnSnapiSet.TabIndex = 3;
            this.btnSnapiSet.Text = "Set";
            this.btnSnapiSet.UseVisualStyleBackColor = true;
            this.btnSnapiSet.Click += new System.EventHandler(this.btnSnapiSet_Click);
            // 
            // btnSnapiGet
            // 
            this.btnSnapiGet.Location = new System.Drawing.Point(16, 55);
            this.btnSnapiGet.Name = "btnSnapiGet";
            this.btnSnapiGet.Size = new System.Drawing.Size(52, 21);
            this.btnSnapiGet.TabIndex = 1;
            this.btnSnapiGet.Text = "Get";
            this.btnSnapiGet.UseVisualStyleBackColor = true;
            this.btnSnapiGet.Click += new System.EventHandler(this.btnSnapiGet_Click);
            // 
            // cmbSnapiParams
            // 
            this.cmbSnapiParams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnapiParams.FormattingEnabled = true;
            this.cmbSnapiParams.Location = new System.Drawing.Point(46, 26);
            this.cmbSnapiParams.Name = "cmbSnapiParams";
            this.cmbSnapiParams.Size = new System.Drawing.Size(141, 21);
            this.cmbSnapiParams.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDocCapDecodeDataSymbol);
            this.groupBox2.Controls.Add(this.txtDocCapDecodeData);
            this.groupBox2.Location = new System.Drawing.Point(205, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Symbology";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decode Data";
            // 
            // txtDocCapDecodeDataSymbol
            // 
            this.txtDocCapDecodeDataSymbol.Location = new System.Drawing.Point(89, 45);
            this.txtDocCapDecodeDataSymbol.Name = "txtDocCapDecodeDataSymbol";
            this.txtDocCapDecodeDataSymbol.ReadOnly = true;
            this.txtDocCapDecodeDataSymbol.Size = new System.Drawing.Size(187, 20);
            this.txtDocCapDecodeDataSymbol.TabIndex = 1;
            // 
            // txtDocCapDecodeData
            // 
            this.txtDocCapDecodeData.Location = new System.Drawing.Point(89, 19);
            this.txtDocCapDecodeData.Name = "txtDocCapDecodeData";
            this.txtDocCapDecodeData.ReadOnly = true;
            this.txtDocCapDecodeData.Size = new System.Drawing.Size(187, 20);
            this.txtDocCapDecodeData.TabIndex = 0;
            // 
            // openFileDialogAttr
            // 
            this.openFileDialogAttr.Filter = "xml files (*.xml)|*.xml";
            // 
            // stStripResult
            // 
            this.stStripResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stStripResult.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl,
            this.toolStripStatusLblTotal,
            this.toolStripStatusLblIbmhid,
            this.toolStripStatusLblSnapi,
            this.toolStripStatusIBMTT,
            this.toolStripStatusLblHidkb,
            this.toolStripStatusLblSsi,
            this.toolStripStatusLblNxmdb});
            this.stStripResult.Location = new System.Drawing.Point(0, 739);
            this.stStripResult.Name = "stStripResult";
            this.stStripResult.Size = new System.Drawing.Size(1048, 22);
            this.stStripResult.TabIndex = 2;
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLbl.Size = new System.Drawing.Size(319, 17);
            this.toolStripStatusLbl.Text = "                                                                                 " +
    "                       ";
            // 
            // toolStripStatusLblTotal
            // 
            this.toolStripStatusLblTotal.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLblTotal.Name = "toolStripStatusLblTotal";
            this.toolStripStatusLblTotal.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblTotal.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLblTotal.Text = "Total = 0";
            // 
            // toolStripStatusLblIbmhid
            // 
            this.toolStripStatusLblIbmhid.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblIbmhid.Name = "toolStripStatusLblIbmhid";
            this.toolStripStatusLblIbmhid.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblIbmhid.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLblIbmhid.Text = "IBMHID = 0";
            // 
            // toolStripStatusLblSnapi
            // 
            this.toolStripStatusLblSnapi.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblSnapi.Name = "toolStripStatusLblSnapi";
            this.toolStripStatusLblSnapi.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblSnapi.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLblSnapi.Text = "SNAPI = 0";
            // 
            // toolStripStatusIBMTT
            // 
            this.toolStripStatusIBMTT.Name = "toolStripStatusIBMTT";
            this.toolStripStatusIBMTT.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusIBMTT.Text = "IBMTT = 0";
            // 
            // toolStripStatusLblHidkb
            // 
            this.toolStripStatusLblHidkb.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblHidkb.Name = "toolStripStatusLblHidkb";
            this.toolStripStatusLblHidkb.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblHidkb.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLblHidkb.Text = "HIDKB = 0";
            // 
            // toolStripStatusLblSsi
            // 
            this.toolStripStatusLblSsi.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblSsi.Name = "toolStripStatusLblSsi";
            this.toolStripStatusLblSsi.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblSsi.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLblSsi.Text = "SSI = 0";
            // 
            // toolStripStatusLblNxmdb
            // 
            this.toolStripStatusLblNxmdb.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblNxmdb.Name = "toolStripStatusLblNxmdb";
            this.toolStripStatusLblNxmdb.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblNxmdb.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLblNxmdb.Text = "NXMODB = 0";
            // 
            // openFileDialogWavFile
            // 
            this.openFileDialogWavFile.FileName = "openFileDialogWavFile";
            this.openFileDialogWavFile.Filter = "Wav files (*.wav)|*.wav";
            // 
            // openFileDialogDADF
            // 
            this.openFileDialogDADF.Filter = "Driver ADF Script files (*.dadf)|*.dadf";
            // 
            // tabXml
            // 
            this.tabXml.Controls.Add(this.btnClearXmlArea);
            this.tabXml.Controls.Add(this.btnClearLogsArea);
            this.tabXml.Controls.Add(this.grpResult);
            this.tabXml.Controls.Add(this.grpOutXml);
            this.tabXml.Location = new System.Drawing.Point(4, 22);
            this.tabXml.Name = "tabXml";
            this.tabXml.Size = new System.Drawing.Size(567, 698);
            this.tabXml.TabIndex = 7;
            this.tabXml.Text = "Logs";
            this.tabXml.UseVisualStyleBackColor = true;
            // 
            // btnClearXmlArea
            // 
            this.btnClearXmlArea.Location = new System.Drawing.Point(306, 436);
            this.btnClearXmlArea.Name = "btnClearXmlArea";
            this.btnClearXmlArea.Size = new System.Drawing.Size(91, 23);
            this.btnClearXmlArea.TabIndex = 3;
            this.btnClearXmlArea.Text = "Clear XML Log";
            this.btnClearXmlArea.UseVisualStyleBackColor = true;
            this.btnClearXmlArea.Click += new System.EventHandler(this.btnClearXmlArea_Click);
            // 
            // btnClearLogsArea
            // 
            this.btnClearLogsArea.Location = new System.Drawing.Point(124, 436);
            this.btnClearLogsArea.Name = "btnClearLogsArea";
            this.btnClearLogsArea.Size = new System.Drawing.Size(96, 23);
            this.btnClearLogsArea.TabIndex = 2;
            this.btnClearLogsArea.Text = "Clear Event Log";
            this.btnClearLogsArea.UseVisualStyleBackColor = true;
            this.btnClearLogsArea.Click += new System.EventHandler(this.btnClearLogsArea_Click);
            // 
            // grpResult
            // 
            this.grpResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpResult.Controls.Add(this.txtResults);
            this.grpResult.Location = new System.Drawing.Point(4, 3);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(490, 177);
            this.grpResult.TabIndex = 0;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Event Log";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.White;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(8, 19);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(476, 152);
            this.txtResults.TabIndex = 0;
            // 
            // grpOutXml
            // 
            this.grpOutXml.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpOutXml.Controls.Add(this.txtOutXml);
            this.grpOutXml.Location = new System.Drawing.Point(4, 186);
            this.grpOutXml.Name = "grpOutXml";
            this.grpOutXml.Size = new System.Drawing.Size(490, 244);
            this.grpOutXml.TabIndex = 1;
            this.grpOutXml.TabStop = false;
            this.grpOutXml.Text = "XML Log";
            // 
            // txtOutXml
            // 
            this.txtOutXml.BackColor = System.Drawing.Color.White;
            this.txtOutXml.Location = new System.Drawing.Point(8, 16);
            this.txtOutXml.Multiline = true;
            this.txtOutXml.Name = "txtOutXml";
            this.txtOutXml.ReadOnly = true;
            this.txtOutXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutXml.Size = new System.Drawing.Size(476, 219);
            this.txtOutXml.TabIndex = 0;
            // 
            // tabSSW
            // 
            this.tabSSW.Controls.Add(this.btnClear);
            this.tabSSW.Controls.Add(this.txtEpcId);
            this.tabSSW.Controls.Add(this.txtSerialNumber);
            this.tabSSW.Controls.Add(this.txtUserBank);
            this.tabSSW.Controls.Add(this.txtNewEpcId);
            this.tabSSW.Controls.Add(this.txtUpcaBarcode);
            this.tabSSW.Controls.Add(this.label14);
            this.tabSSW.Controls.Add(this.rdoHex);
            this.tabSSW.Controls.Add(this.rdoASCII);
            this.tabSSW.Controls.Add(this.btnVerifyTag);
            this.tabSSW.Controls.Add(this.label7);
            this.tabSSW.Controls.Add(this.btnWriteTag);
            this.tabSSW.Controls.Add(this.cmbPartition);
            this.tabSSW.Controls.Add(this.cmbFilterValue);
            this.tabSSW.Controls.Add(this.statusIcon);
            this.tabSSW.Controls.Add(this.label21);
            this.tabSSW.Controls.Add(this.label22);
            this.tabSSW.Controls.Add(this.chkAutoIncrement);
            this.tabSSW.Controls.Add(this.lblUserBank);
            this.tabSSW.Controls.Add(this.label25);
            this.tabSSW.Controls.Add(this.label23);
            this.tabSSW.Location = new System.Drawing.Point(4, 22);
            this.tabSSW.Margin = new System.Windows.Forms.Padding(2);
            this.tabSSW.Name = "tabSSW";
            this.tabSSW.Size = new System.Drawing.Size(567, 698);
            this.tabSSW.TabIndex = 11;
            this.tabSSW.Text = "Scan Scan Write";
            this.tabSSW.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 103);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 24);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtEpcId
            // 
            this.txtEpcId.BackColor = System.Drawing.Color.White;
            this.txtEpcId.Location = new System.Drawing.Point(94, 53);
            this.txtEpcId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEpcId.Name = "txtEpcId";
            this.txtEpcId.ReadOnly = true;
            this.txtEpcId.Size = new System.Drawing.Size(193, 20);
            this.txtEpcId.TabIndex = 33;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(408, 80);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(90, 20);
            this.txtSerialNumber.TabIndex = 7;
            // 
            // txtUserBank
            // 
            this.txtUserBank.BackColor = System.Drawing.Color.White;
            this.txtUserBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBank.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserBank.Location = new System.Drawing.Point(94, 150);
            this.txtUserBank.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserBank.Multiline = true;
            this.txtUserBank.Name = "txtUserBank";
            this.txtUserBank.ReadOnly = true;
            this.txtUserBank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserBank.Size = new System.Drawing.Size(193, 81);
            this.txtUserBank.TabIndex = 9;
            // 
            // txtUpcaBarcode
            // 
            this.txtUpcaBarcode.BackColor = System.Drawing.Color.White;
            this.txtUpcaBarcode.Location = new System.Drawing.Point(94, 25);
            this.txtUpcaBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpcaBarcode.Name = "txtUpcaBarcode";
            this.txtUpcaBarcode.ReadOnly = true;
            this.txtUpcaBarcode.Size = new System.Drawing.Size(193, 20);
            this.txtUpcaBarcode.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Existing EPC Id";
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdoHex.Location = new System.Drawing.Point(152, 233);
            this.rdoHex.Margin = new System.Windows.Forms.Padding(2);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(44, 17);
            this.rdoHex.TabIndex = 32;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            // 
            // rdoASCII
            // 
            this.rdoASCII.AutoSize = true;
            this.rdoASCII.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdoASCII.Location = new System.Drawing.Point(95, 232);
            this.rdoASCII.Margin = new System.Windows.Forms.Padding(2);
            this.rdoASCII.Name = "rdoASCII";
            this.rdoASCII.Size = new System.Drawing.Size(52, 17);
            this.rdoASCII.TabIndex = 31;
            this.rdoASCII.TabStop = true;
            this.rdoASCII.Text = "ASCII";
            this.rdoASCII.UseVisualStyleBackColor = true;
            // 
            // btnVerifyTag
            // 
            this.btnVerifyTag.Location = new System.Drawing.Point(160, 103);
            this.btnVerifyTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerifyTag.Name = "btnVerifyTag";
            this.btnVerifyTag.Size = new System.Drawing.Size(72, 24);
            this.btnVerifyTag.TabIndex = 30;
            this.btnVerifyTag.Text = "Verify Tag";
            this.btnVerifyTag.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Serial Number";
            // 
            // btnWriteTag
            // 
            this.btnWriteTag.Location = new System.Drawing.Point(94, 103);
            this.btnWriteTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteTag.Name = "btnWriteTag";
            this.btnWriteTag.Size = new System.Drawing.Size(63, 24);
            this.btnWriteTag.TabIndex = 27;
            this.btnWriteTag.Text = "Write Tag";
            this.btnWriteTag.UseVisualStyleBackColor = true;
            // 
            // cmbPartition
            // 
            this.cmbPartition.FormattingEnabled = true;
            this.cmbPartition.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbPartition.Location = new System.Drawing.Point(408, 52);
            this.cmbPartition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPartition.Name = "cmbPartition";
            this.cmbPartition.Size = new System.Drawing.Size(92, 21);
            this.cmbPartition.TabIndex = 25;
            // 
            // cmbFilterValue
            // 
            this.cmbFilterValue.FormattingEnabled = true;
            this.cmbFilterValue.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbFilterValue.Location = new System.Drawing.Point(408, 24);
            this.cmbFilterValue.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterValue.Name = "cmbFilterValue";
            this.cmbFilterValue.Size = new System.Drawing.Size(92, 21);
            this.cmbFilterValue.TabIndex = 24;
            // 
            // statusIcon
            // 
            this.statusIcon.ErrorImage = null;
            this.statusIcon.InitialImage = null;
            this.statusIcon.Location = new System.Drawing.Point(291, 80);
            this.statusIcon.Margin = new System.Windows.Forms.Padding(2);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(17, 19);
            this.statusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.statusIcon.TabIndex = 23;
            this.statusIcon.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(332, 55);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Partition";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(332, 28);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Filter value";
            // 
            // lblUserBank
            // 
            this.lblUserBank.AutoSize = true;
            this.lblUserBank.Location = new System.Drawing.Point(14, 150);
            this.lblUserBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserBank.Name = "lblUserBank";
            this.lblUserBank.Size = new System.Drawing.Size(56, 13);
            this.lblUserBank.TabIndex = 12;
            this.lblUserBank.Text = "User bank";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 83);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "New EPC Id";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Scan barcode";
            // 
            // tabScale
            // 
            this.tabScale.Controls.Add(this.grpScale);
            this.tabScale.Location = new System.Drawing.Point(4, 22);
            this.tabScale.Name = "tabScale";
            this.tabScale.Padding = new System.Windows.Forms.Padding(3);
            this.tabScale.Size = new System.Drawing.Size(567, 698);
            this.tabScale.TabIndex = 8;
            this.tabScale.Text = "Scale";
            this.tabScale.UseVisualStyleBackColor = true;
            // 
            // grpScale
            // 
            this.grpScale.Controls.Add(this.lblScalStatusDesc);
            this.grpScale.Controls.Add(this.txtWeightUnit);
            this.grpScale.Controls.Add(this.txtWeight);
            this.grpScale.Controls.Add(this.label2);
            this.grpScale.Controls.Add(this.label1);
            this.grpScale.Controls.Add(this.btnSystemRest);
            this.grpScale.Controls.Add(this.btnZeroScale);
            this.grpScale.Controls.Add(this.btnReadWeight);
            this.grpScale.Location = new System.Drawing.Point(6, 6);
            this.grpScale.Name = "grpScale";
            this.grpScale.Size = new System.Drawing.Size(493, 456);
            this.grpScale.TabIndex = 20;
            this.grpScale.TabStop = false;
            // 
            // lblScalStatusDesc
            // 
            this.lblScalStatusDesc.AutoSize = true;
            this.lblScalStatusDesc.Location = new System.Drawing.Point(91, 216);
            this.lblScalStatusDesc.Name = "lblScalStatusDesc";
            this.lblScalStatusDesc.Size = new System.Drawing.Size(0, 13);
            this.lblScalStatusDesc.TabIndex = 21;
            // 
            // txtWeightUnit
            // 
            this.txtWeightUnit.Location = new System.Drawing.Point(293, 144);
            this.txtWeightUnit.Name = "txtWeightUnit";
            this.txtWeightUnit.ReadOnly = true;
            this.txtWeightUnit.Size = new System.Drawing.Size(100, 20);
            this.txtWeightUnit.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(94, 144);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Weight Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Weight Measured";
            // 
            // btnSystemRest
            // 
            this.btnSystemRest.Location = new System.Drawing.Point(321, 24);
            this.btnSystemRest.Name = "btnSystemRest";
            this.btnSystemRest.Size = new System.Drawing.Size(128, 23);
            this.btnSystemRest.TabIndex = 2;
            this.btnSystemRest.Text = "Reset Scale";
            this.btnSystemRest.UseVisualStyleBackColor = true;
            this.btnSystemRest.Click += new System.EventHandler(this.btnSystemRest_Click);
            // 
            // btnZeroScale
            // 
            this.btnZeroScale.Location = new System.Drawing.Point(167, 24);
            this.btnZeroScale.Name = "btnZeroScale";
            this.btnZeroScale.Size = new System.Drawing.Size(128, 23);
            this.btnZeroScale.TabIndex = 1;
            this.btnZeroScale.Text = "Zero scale";
            this.btnZeroScale.UseVisualStyleBackColor = true;
            this.btnZeroScale.Click += new System.EventHandler(this.btnZeroScale_Click);
            // 
            // btnReadWeight
            // 
            this.btnReadWeight.Location = new System.Drawing.Point(17, 24);
            this.btnReadWeight.Name = "btnReadWeight";
            this.btnReadWeight.Size = new System.Drawing.Size(128, 23);
            this.btnReadWeight.TabIndex = 0;
            this.btnReadWeight.Text = "Read weight";
            this.btnReadWeight.UseVisualStyleBackColor = true;
            this.btnReadWeight.Click += new System.EventHandler(this.btnReadWeight_Click);
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.grpMiscOther);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Size = new System.Drawing.Size(567, 698);
            this.tabMisc.TabIndex = 4;
            this.tabMisc.Text = "Miscellaneous";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // grpMiscOther
            // 
            this.grpMiscOther.Controls.Add(this.grpMiscCmd);
            this.grpMiscOther.Controls.Add(this.grpAsync);
            this.grpMiscOther.Controls.Add(this.grpBaudrate);
            this.grpMiscOther.Location = new System.Drawing.Point(3, 3);
            this.grpMiscOther.Name = "grpMiscOther";
            this.grpMiscOther.Size = new System.Drawing.Size(500, 459);
            this.grpMiscOther.TabIndex = 28;
            this.grpMiscOther.TabStop = false;
            this.grpMiscOther.Text = "Miscellaneous";
            // 
            // grpMiscCmd
            // 
            this.grpMiscCmd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpMiscCmd.Controls.Add(this.btnGetDevTopology);
            this.grpMiscCmd.Controls.Add(this.btnSdkVersion);
            this.grpMiscCmd.Location = new System.Drawing.Point(10, 26);
            this.grpMiscCmd.Name = "grpMiscCmd";
            this.grpMiscCmd.Size = new System.Drawing.Size(280, 66);
            this.grpMiscCmd.TabIndex = 0;
            this.grpMiscCmd.TabStop = false;
            this.grpMiscCmd.Text = "Miscellaneous Commands";
            // 
            // btnGetDevTopology
            // 
            this.btnGetDevTopology.Location = new System.Drawing.Point(143, 26);
            this.btnGetDevTopology.Name = "btnGetDevTopology";
            this.btnGetDevTopology.Size = new System.Drawing.Size(119, 23);
            this.btnGetDevTopology.TabIndex = 1;
            this.btnGetDevTopology.Text = "Get Device Topology";
            this.btnGetDevTopology.UseVisualStyleBackColor = true;
            this.btnGetDevTopology.Click += new System.EventHandler(this.btnGetDevTopology_Click);
            // 
            // btnSdkVersion
            // 
            this.btnSdkVersion.Location = new System.Drawing.Point(19, 26);
            this.btnSdkVersion.Name = "btnSdkVersion";
            this.btnSdkVersion.Size = new System.Drawing.Size(118, 23);
            this.btnSdkVersion.TabIndex = 0;
            this.btnSdkVersion.Text = "CoreScanner Version";
            this.btnSdkVersion.UseVisualStyleBackColor = true;
            this.btnSdkVersion.Click += new System.EventHandler(this.btnSdkVersion_Click);
            // 
            // grpAsync
            // 
            this.grpAsync.Controls.Add(this.chkAsync);
            this.grpAsync.Location = new System.Drawing.Point(326, 25);
            this.grpAsync.Name = "grpAsync";
            this.grpAsync.Size = new System.Drawing.Size(150, 63);
            this.grpAsync.TabIndex = 1;
            this.grpAsync.TabStop = false;
            this.grpAsync.Text = "Command Mode";
            // 
            // chkAsync
            // 
            this.chkAsync.AutoSize = true;
            this.chkAsync.Location = new System.Drawing.Point(19, 19);
            this.chkAsync.Name = "chkAsync";
            this.chkAsync.Size = new System.Drawing.Size(93, 17);
            this.chkAsync.TabIndex = 0;
            this.chkAsync.Text = "Asynchronous";
            this.chkAsync.UseVisualStyleBackColor = true;
            // 
            // grpBaudrate
            // 
            this.grpBaudrate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpBaudrate.Controls.Add(this.lblStpBits);
            this.grpBaudrate.Controls.Add(this.comboStpBits);
            this.grpBaudrate.Controls.Add(this.lblParity);
            this.grpBaudrate.Controls.Add(this.comboParity);
            this.grpBaudrate.Controls.Add(this.btnSetSrilInfce);
            this.grpBaudrate.Controls.Add(this.lblDataBit);
            this.grpBaudrate.Controls.Add(this.lblBaudRte);
            this.grpBaudrate.Controls.Add(this.comboDataBits);
            this.grpBaudrate.Controls.Add(this.comboBaudRate);
            this.grpBaudrate.Controls.Add(this.flwCtrlChkBox);
            this.grpBaudrate.Location = new System.Drawing.Point(10, 98);
            this.grpBaudrate.Name = "grpBaudrate";
            this.grpBaudrate.Size = new System.Drawing.Size(485, 90);
            this.grpBaudrate.TabIndex = 2;
            this.grpBaudrate.TabStop = false;
            this.grpBaudrate.Text = "Serial Interface Settings";
            // 
            // lblStpBits
            // 
            this.lblStpBits.AutoSize = true;
            this.lblStpBits.Location = new System.Drawing.Point(204, 25);
            this.lblStpBits.Name = "lblStpBits";
            this.lblStpBits.Size = new System.Drawing.Size(49, 13);
            this.lblStpBits.TabIndex = 14;
            this.lblStpBits.Text = "Stop Bits";
            // 
            // comboStpBits
            // 
            this.comboStpBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStpBits.FormattingEnabled = true;
            this.comboStpBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboStpBits.Location = new System.Drawing.Point(266, 22);
            this.comboStpBits.Name = "comboStpBits";
            this.comboStpBits.Size = new System.Drawing.Size(121, 21);
            this.comboStpBits.TabIndex = 2;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(6, 22);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(33, 13);
            this.lblParity.TabIndex = 12;
            this.lblParity.Text = "Parity";
            // 
            // comboParity
            // 
            this.comboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.comboParity.Location = new System.Drawing.Point(75, 19);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(121, 21);
            this.comboParity.TabIndex = 0;
            // 
            // btnSetSrilInfce
            // 
            this.btnSetSrilInfce.Location = new System.Drawing.Point(404, 48);
            this.btnSetSrilInfce.Name = "btnSetSrilInfce";
            this.btnSetSrilInfce.Size = new System.Drawing.Size(75, 23);
            this.btnSetSrilInfce.TabIndex = 5;
            this.btnSetSrilInfce.Text = "Set";
            this.btnSetSrilInfce.UseVisualStyleBackColor = true;
            this.btnSetSrilInfce.Click += new System.EventHandler(this.btnSetSrilInfce_Click);
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Location = new System.Drawing.Point(204, 52);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(50, 13);
            this.lblDataBit.TabIndex = 9;
            this.lblDataBit.Text = "Data Bits";
            // 
            // lblBaudRte
            // 
            this.lblBaudRte.AutoSize = true;
            this.lblBaudRte.Location = new System.Drawing.Point(6, 49);
            this.lblBaudRte.Name = "lblBaudRte";
            this.lblBaudRte.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRte.TabIndex = 8;
            this.lblBaudRte.Text = "Baud Rate";
            // 
            // comboDataBits
            // 
            this.comboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDataBits.FormattingEnabled = true;
            this.comboDataBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboDataBits.Location = new System.Drawing.Point(266, 49);
            this.comboDataBits.Name = "comboDataBits";
            this.comboDataBits.Size = new System.Drawing.Size(121, 21);
            this.comboDataBits.TabIndex = 3;
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBaudRate.Location = new System.Drawing.Point(75, 46);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBaudRate.TabIndex = 1;
            // 
            // flwCtrlChkBox
            // 
            this.flwCtrlChkBox.AutoSize = true;
            this.flwCtrlChkBox.Location = new System.Drawing.Point(395, 22);
            this.flwCtrlChkBox.Name = "flwCtrlChkBox";
            this.flwCtrlChkBox.Size = new System.Drawing.Size(84, 17);
            this.flwCtrlChkBox.TabIndex = 4;
            this.flwCtrlChkBox.Text = "Flow Control";
            this.flwCtrlChkBox.UseVisualStyleBackColor = true;
            // 
            // tabScan2Connect
            // 
            this.tabScan2Connect.Controls.Add(this.grpScan2Connect);
            this.tabScan2Connect.Location = new System.Drawing.Point(4, 22);
            this.tabScan2Connect.Name = "tabScan2Connect";
            this.tabScan2Connect.Size = new System.Drawing.Size(567, 698);
            this.tabScan2Connect.TabIndex = 10;
            this.tabScan2Connect.Text = "ScanToConnect";
            this.tabScan2Connect.UseVisualStyleBackColor = true;
            // 
            // grpScan2Connect
            // 
            this.grpScan2Connect.Controls.Add(this.btnSaveBarcode);
            this.grpScan2Connect.Controls.Add(this.label13);
            this.grpScan2Connect.Controls.Add(this.cmbHostName);
            this.grpScan2Connect.Controls.Add(this.label12);
            this.grpScan2Connect.Controls.Add(this.label11);
            this.grpScan2Connect.Controls.Add(this.cmbScannerType);
            this.grpScan2Connect.Controls.Add(this.label10);
            this.grpScan2Connect.Controls.Add(this.label9);
            this.grpScan2Connect.Controls.Add(this.label8);
            this.grpScan2Connect.Controls.Add(this.picBBarcode);
            this.grpScan2Connect.Controls.Add(this.cmbImageSize);
            this.grpScan2Connect.Controls.Add(this.cmbDefaultOption);
            this.grpScan2Connect.Controls.Add(this.cmbProtocol);
            this.grpScan2Connect.Location = new System.Drawing.Point(3, 15);
            this.grpScan2Connect.Name = "grpScan2Connect";
            this.grpScan2Connect.Size = new System.Drawing.Size(505, 450);
            this.grpScan2Connect.TabIndex = 4;
            this.grpScan2Connect.TabStop = false;
            this.grpScan2Connect.Text = "ScanToConnect Barcode";
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.Location = new System.Drawing.Point(384, 274);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.Size = new System.Drawing.Size(104, 23);
            this.btnSaveBarcode.TabIndex = 21;
            this.btnSaveBarcode.Text = "Save Barcode";
            this.btnSaveBarcode.UseVisualStyleBackColor = true;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Host Name";
            // 
            // cmbHostName
            // 
            this.cmbHostName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHostName.FormattingEnabled = true;
            this.cmbHostName.Items.AddRange(new object[] {
            "SSI BT Classic (Non-Discoverable)"});
            this.cmbHostName.Location = new System.Drawing.Point(98, 119);
            this.cmbHostName.Name = "cmbHostName";
            this.cmbHostName.Size = new System.Drawing.Size(167, 21);
            this.cmbHostName.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Received Barcode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Scanner Type";
            // 
            // cmbScannerType
            // 
            this.cmbScannerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScannerType.FormattingEnabled = true;
            this.cmbScannerType.Items.AddRange(new object[] {
            "Legacy",
            "New"});
            this.cmbScannerType.Location = new System.Drawing.Point(98, 27);
            this.cmbScannerType.Name = "cmbScannerType";
            this.cmbScannerType.Size = new System.Drawing.Size(167, 21);
            this.cmbScannerType.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Image Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Default Option";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Protocol Name";
            // 
            // picBBarcode
            // 
            this.picBBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBBarcode.Location = new System.Drawing.Point(6, 305);
            this.picBBarcode.Name = "picBBarcode";
            this.picBBarcode.Size = new System.Drawing.Size(493, 135);
            this.picBBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBBarcode.TabIndex = 10;
            this.picBBarcode.TabStop = false;
            // 
            // cmbImageSize
            // 
            this.cmbImageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageSize.FormattingEnabled = true;
            this.cmbImageSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbImageSize.Location = new System.Drawing.Point(98, 211);
            this.cmbImageSize.Name = "cmbImageSize";
            this.cmbImageSize.Size = new System.Drawing.Size(76, 21);
            this.cmbImageSize.TabIndex = 9;
            // 
            // cmbDefaultOption
            // 
            this.cmbDefaultOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultOption.FormattingEnabled = true;
            this.cmbDefaultOption.Items.AddRange(new object[] {
            "No Defaults",
            "Set Factory Defaults",
            "Restore Factory Defaults"});
            this.cmbDefaultOption.Location = new System.Drawing.Point(98, 165);
            this.cmbDefaultOption.Name = "cmbDefaultOption";
            this.cmbDefaultOption.Size = new System.Drawing.Size(167, 21);
            this.cmbDefaultOption.TabIndex = 2;
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Items.AddRange(new object[] {
            "Simple Serial Interface (SSI)",
            "Serial Port Profile (SPP)",
            "Human Interface Device (HID)"});
            this.cmbProtocol.Location = new System.Drawing.Point(98, 73);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(190, 21);
            this.cmbProtocol.TabIndex = 1;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.grpCustomDecodeTone);
            this.tabConfig.Controls.Add(this.filterScnrs);
            this.tabConfig.Controls.Add(this.grpFrmWrUpdate);
            this.tabConfig.Controls.Add(this.grpScannerProp);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(567, 698);
            this.tabConfig.TabIndex = 3;
            this.tabConfig.Text = "Advanced";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // grpCustomDecodeTone
            // 
            this.grpCustomDecodeTone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpCustomDecodeTone.Controls.Add(this.btnEraseTone);
            this.grpCustomDecodeTone.Controls.Add(this.buttonWavFileUpload);
            this.grpCustomDecodeTone.Controls.Add(this.textBoxWavFile);
            this.grpCustomDecodeTone.Controls.Add(this.buttonWavFileBrowse);
            this.grpCustomDecodeTone.Location = new System.Drawing.Point(16, 213);
            this.grpCustomDecodeTone.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomDecodeTone.Name = "grpCustomDecodeTone";
            this.grpCustomDecodeTone.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomDecodeTone.Size = new System.Drawing.Size(468, 89);
            this.grpCustomDecodeTone.TabIndex = 3;
            this.grpCustomDecodeTone.TabStop = false;
            this.grpCustomDecodeTone.Text = "Custom Good Decode Tone";
            // 
            // btnEraseTone
            // 
            this.btnEraseTone.Location = new System.Drawing.Point(339, 51);
            this.btnEraseTone.Name = "btnEraseTone";
            this.btnEraseTone.Size = new System.Drawing.Size(113, 25);
            this.btnEraseTone.TabIndex = 3;
            this.btnEraseTone.Text = "Erase Tone";
            this.btnEraseTone.UseVisualStyleBackColor = true;
            this.btnEraseTone.Click += new System.EventHandler(this.btnEraseTone_Click);
            // 
            // buttonWavFileUpload
            // 
            this.buttonWavFileUpload.Location = new System.Drawing.Point(209, 51);
            this.buttonWavFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWavFileUpload.Name = "buttonWavFileUpload";
            this.buttonWavFileUpload.Size = new System.Drawing.Size(125, 25);
            this.buttonWavFileUpload.TabIndex = 2;
            this.buttonWavFileUpload.Text = "Upload To Scanner";
            this.buttonWavFileUpload.UseVisualStyleBackColor = true;
            this.buttonWavFileUpload.Click += new System.EventHandler(this.buttonWavFileUpload_Click);
            // 
            // textBoxWavFile
            // 
            this.textBoxWavFile.Location = new System.Drawing.Point(8, 24);
            this.textBoxWavFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWavFile.Name = "textBoxWavFile";
            this.textBoxWavFile.Size = new System.Drawing.Size(354, 20);
            this.textBoxWavFile.TabIndex = 0;
            // 
            // buttonWavFileBrowse
            // 
            this.buttonWavFileBrowse.Location = new System.Drawing.Point(375, 20);
            this.buttonWavFileBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWavFileBrowse.Name = "buttonWavFileBrowse";
            this.buttonWavFileBrowse.Size = new System.Drawing.Size(77, 26);
            this.buttonWavFileBrowse.TabIndex = 1;
            this.buttonWavFileBrowse.Text = "Browse";
            this.buttonWavFileBrowse.UseVisualStyleBackColor = true;
            this.buttonWavFileBrowse.Click += new System.EventHandler(this.buttonWavFileBrowse_Click);
            // 
            // filterScnrs
            // 
            this.filterScnrs.Controls.Add(this.comboFilterScnrs);
            this.filterScnrs.Location = new System.Drawing.Point(321, 152);
            this.filterScnrs.Name = "filterScnrs";
            this.filterScnrs.Size = new System.Drawing.Size(163, 51);
            this.filterScnrs.TabIndex = 2;
            this.filterScnrs.TabStop = false;
            this.filterScnrs.Text = "Protocol Select";
            // 
            // comboFilterScnrs
            // 
            this.comboFilterScnrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterScnrs.FormattingEnabled = true;
            this.comboFilterScnrs.Items.AddRange(new object[] {
            "ALL",
            "HID KEYBOARD",
            "IBM HANDHELD",
            "SNAPI"});
            this.comboFilterScnrs.Location = new System.Drawing.Point(33, 17);
            this.comboFilterScnrs.Name = "comboFilterScnrs";
            this.comboFilterScnrs.Size = new System.Drawing.Size(121, 21);
            this.comboFilterScnrs.TabIndex = 0;
            this.comboFilterScnrs.SelectedIndexChanged += new System.EventHandler(this.comboFilterScnrs_SelectedIndexChanged);
            // 
            // grpFrmWrUpdate
            // 
            this.grpFrmWrUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpFrmWrUpdate.Controls.Add(this.grpFWoptns);
            this.grpFrmWrUpdate.Controls.Add(this.progressBarFWUpdate);
            this.grpFrmWrUpdate.Controls.Add(this.buttonFWBrowse);
            this.grpFrmWrUpdate.Controls.Add(this.txtFWFile);
            this.grpFrmWrUpdate.Location = new System.Drawing.Point(16, 14);
            this.grpFrmWrUpdate.Name = "grpFrmWrUpdate";
            this.grpFrmWrUpdate.Size = new System.Drawing.Size(468, 130);
            this.grpFrmWrUpdate.TabIndex = 0;
            this.grpFrmWrUpdate.TabStop = false;
            this.grpFrmWrUpdate.Text = "Firmware Operations";
            // 
            // grpFWoptns
            // 
            this.grpFWoptns.Controls.Add(this.chkBulk);
            this.grpFWoptns.Controls.Add(this.btnAbortFWUpdate);
            this.grpFWoptns.Controls.Add(this.btnFWUpdate);
            this.grpFWoptns.Controls.Add(this.btnLaunchNewFW);
            this.grpFWoptns.Location = new System.Drawing.Point(23, 56);
            this.grpFWoptns.Name = "grpFWoptns";
            this.grpFWoptns.Size = new System.Drawing.Size(435, 44);
            this.grpFWoptns.TabIndex = 28;
            this.grpFWoptns.TabStop = false;
            // 
            // chkBulk
            // 
            this.chkBulk.AutoSize = true;
            this.chkBulk.Checked = true;
            this.chkBulk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBulk.Location = new System.Drawing.Point(37, 19);
            this.chkBulk.Name = "chkBulk";
            this.chkBulk.Size = new System.Drawing.Size(85, 17);
            this.chkBulk.TabIndex = 0;
            this.chkBulk.Text = "Bulk Update";
            this.chkBulk.UseVisualStyleBackColor = true;
            // 
            // btnAbortFWUpdate
            // 
            this.btnAbortFWUpdate.Location = new System.Drawing.Point(340, 13);
            this.btnAbortFWUpdate.Name = "btnAbortFWUpdate";
            this.btnAbortFWUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnAbortFWUpdate.TabIndex = 2;
            this.btnAbortFWUpdate.Text = "Abort";
            this.btnAbortFWUpdate.UseVisualStyleBackColor = true;
            this.btnAbortFWUpdate.Click += new System.EventHandler(this.btnAbortFWUpdate_Click);
            // 
            // btnFWUpdate
            // 
            this.btnFWUpdate.Location = new System.Drawing.Point(157, 13);
            this.btnFWUpdate.Name = "btnFWUpdate";
            this.btnFWUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnFWUpdate.TabIndex = 1;
            this.btnFWUpdate.Text = "Update";
            this.btnFWUpdate.UseVisualStyleBackColor = true;
            this.btnFWUpdate.Click += new System.EventHandler(this.btnFWUpdate_Click);
            // 
            // btnLaunchNewFW
            // 
            this.btnLaunchNewFW.Location = new System.Drawing.Point(244, 13);
            this.btnLaunchNewFW.Name = "btnLaunchNewFW";
            this.btnLaunchNewFW.Size = new System.Drawing.Size(90, 23);
            this.btnLaunchNewFW.TabIndex = 3;
            this.btnLaunchNewFW.Text = "Launch";
            this.btnLaunchNewFW.UseVisualStyleBackColor = true;
            this.btnLaunchNewFW.Click += new System.EventHandler(this.btnStartNewFW_Click);
            // 
            // progressBarFWUpdate
            // 
            this.progressBarFWUpdate.BackColor = System.Drawing.Color.White;
            this.progressBarFWUpdate.Location = new System.Drawing.Point(23, 111);
            this.progressBarFWUpdate.Name = "progressBarFWUpdate";
            this.progressBarFWUpdate.Size = new System.Drawing.Size(435, 13);
            this.progressBarFWUpdate.TabIndex = 17;
            // 
            // buttonFWBrowse
            // 
            this.buttonFWBrowse.Location = new System.Drawing.Point(375, 24);
            this.buttonFWBrowse.Name = "buttonFWBrowse";
            this.buttonFWBrowse.Size = new System.Drawing.Size(77, 23);
            this.buttonFWBrowse.TabIndex = 1;
            this.buttonFWBrowse.Text = "Browse";
            this.buttonFWBrowse.UseVisualStyleBackColor = true;
            this.buttonFWBrowse.Click += new System.EventHandler(this.buttonFWBrowse_Click);
            // 
            // txtFWFile
            // 
            this.txtFWFile.BackColor = System.Drawing.Color.White;
            this.txtFWFile.Location = new System.Drawing.Point(23, 27);
            this.txtFWFile.Name = "txtFWFile";
            this.txtFWFile.Size = new System.Drawing.Size(339, 20);
            this.txtFWFile.TabIndex = 0;
            // 
            // grpScannerProp
            // 
            this.grpScannerProp.Controls.Add(this.chkClaim);
            this.grpScannerProp.Location = new System.Drawing.Point(16, 152);
            this.grpScannerProp.Name = "grpScannerProp";
            this.grpScannerProp.Size = new System.Drawing.Size(218, 44);
            this.grpScannerProp.TabIndex = 1;
            this.grpScannerProp.TabStop = false;
            this.grpScannerProp.Text = "Exclusively Claim Selected Scanner";
            // 
            // chkClaim
            // 
            this.chkClaim.AutoSize = true;
            this.chkClaim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkClaim.Location = new System.Drawing.Point(18, 19);
            this.chkClaim.Name = "chkClaim";
            this.chkClaim.Size = new System.Drawing.Size(94, 17);
            this.chkClaim.TabIndex = 0;
            this.chkClaim.Text = "Claim Scanner";
            this.chkClaim.UseVisualStyleBackColor = false;
            this.chkClaim.CheckedChanged += new System.EventHandler(this.OnClaimScanner);
            // 
            // tabRsm
            // 
            this.tabRsm.Controls.Add(this.grpRSM);
            this.tabRsm.Location = new System.Drawing.Point(4, 22);
            this.tabRsm.Name = "tabRsm";
            this.tabRsm.Size = new System.Drawing.Size(567, 698);
            this.tabRsm.TabIndex = 2;
            this.tabRsm.Text = "RSM";
            this.tabRsm.ToolTipText = "Remote Scanner Management";
            this.tabRsm.UseVisualStyleBackColor = true;
            // 
            // grpRSM
            // 
            this.grpRSM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpRSM.Controls.Add(this.grpBoxClrSlect);
            this.grpRSM.Controls.Add(this.grpBoxSetRset);
            this.grpRSM.Controls.Add(this.dgvAttributes);
            this.grpRSM.Location = new System.Drawing.Point(10, 3);
            this.grpRSM.Name = "grpRSM";
            this.grpRSM.Size = new System.Drawing.Size(486, 457);
            this.grpRSM.TabIndex = 0;
            this.grpRSM.TabStop = false;
            this.grpRSM.Text = "RSM";
            // 
            // grpBoxClrSlect
            // 
            this.grpBoxClrSlect.Controls.Add(this.btnClearAll);
            this.grpBoxClrSlect.Controls.Add(this.btnSelectAll);
            this.grpBoxClrSlect.Location = new System.Drawing.Point(358, 365);
            this.grpBoxClrSlect.Name = "grpBoxClrSlect";
            this.grpBoxClrSlect.Size = new System.Drawing.Size(122, 87);
            this.grpBoxClrSlect.TabIndex = 1;
            this.grpBoxClrSlect.TabStop = false;
            this.grpBoxClrSlect.Text = "Select/Clear";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(24, 50);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(24, 19);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // grpBoxSetRset
            // 
            this.grpBoxSetRset.Controls.Add(this.btnGetAll);
            this.grpBoxSetRset.Controls.Add(this.btnGet);
            this.grpBoxSetRset.Controls.Add(this.btnGetNext);
            this.grpBoxSetRset.Controls.Add(this.btnSet);
            this.grpBoxSetRset.Controls.Add(this.btnStore);
            this.grpBoxSetRset.Location = new System.Drawing.Point(6, 365);
            this.grpBoxSetRset.Name = "grpBoxSetRset";
            this.grpBoxSetRset.Size = new System.Drawing.Size(272, 86);
            this.grpBoxSetRset.TabIndex = 0;
            this.grpBoxSetRset.TabStop = false;
            this.grpBoxSetRset.Text = "Attribute Get/Set";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(4, 19);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(77, 23);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All IDs";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(4, 50);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(77, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Value";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnGetNext
            // 
            this.btnGetNext.Location = new System.Drawing.Point(91, 19);
            this.btnGetNext.Name = "btnGetNext";
            this.btnGetNext.Size = new System.Drawing.Size(77, 23);
            this.btnGetNext.TabIndex = 2;
            this.btnGetNext.Text = "Next Value";
            this.btnGetNext.UseVisualStyleBackColor = true;
            this.btnGetNext.Click += new System.EventHandler(this.btnGetNext_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(91, 50);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(77, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set Value";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(181, 19);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(77, 23);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "Store Value";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // dgvAttributes
            // 
            this.dgvAttributes.AllowUserToAddRows = false;
            this.dgvAttributes.AllowUserToDeleteRows = false;
            this.dgvAttributes.AllowUserToResizeColumns = false;
            this.dgvAttributes.AllowUserToResizeRows = false;
            this.dgvAttributes.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttributes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attrNum,
            this.attrType,
            this.property,
            this.value});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttributes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAttributes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAttributes.Location = new System.Drawing.Point(6, 19);
            this.dgvAttributes.Name = "dgvAttributes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttributes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAttributes.RowHeadersWidth = 30;
            this.dgvAttributes.RowTemplate.Height = 15;
            this.dgvAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttributes.Size = new System.Drawing.Size(474, 340);
            this.dgvAttributes.TabIndex = 2;
            // 
            // attrNum
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            this.attrNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.attrNum.Frozen = true;
            this.attrNum.HeaderText = "ID";
            this.attrNum.Name = "attrNum";
            this.attrNum.ReadOnly = true;
            this.attrNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.attrNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.attrNum.Width = 45;
            // 
            // attrType
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            this.attrType.DefaultCellStyle = dataGridViewCellStyle3;
            this.attrType.HeaderText = "Type";
            this.attrType.Name = "attrType";
            this.attrType.ReadOnly = true;
            this.attrType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.attrType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.attrType.Width = 40;
            // 
            // property
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            this.property.DefaultCellStyle = dataGridViewCellStyle4;
            this.property.HeaderText = "Property";
            this.property.Name = "property";
            this.property.ReadOnly = true;
            this.property.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.property.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.property.Width = 55;
            // 
            // value
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            this.value.DefaultCellStyle = dataGridViewCellStyle5;
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.value.Width = 320;
            // 
            // tabScnAction
            // 
            this.tabScnAction.Controls.Add(this.grpScnActions);
            this.tabScnAction.Location = new System.Drawing.Point(4, 22);
            this.tabScnAction.Name = "tabScnAction";
            this.tabScnAction.Size = new System.Drawing.Size(567, 698);
            this.tabScnAction.TabIndex = 5;
            this.tabScnAction.Text = "Actions";
            this.tabScnAction.UseVisualStyleBackColor = true;
            // 
            // grpScnActions
            // 
            this.grpScnActions.Controls.Add(this.groupBox4);
            this.grpScnActions.Controls.Add(this.grpHVS);
            this.grpScnActions.Controls.Add(this.grpReboot);
            this.grpScnActions.Controls.Add(this.grpEnbDisScanner);
            this.grpScnActions.Controls.Add(this.grpBeeper);
            this.grpScnActions.Controls.Add(this.grpLed);
            this.grpScnActions.Controls.Add(this.grpAim);
            this.grpScnActions.Location = new System.Drawing.Point(3, 3);
            this.grpScnActions.Name = "grpScnActions";
            this.grpScnActions.Size = new System.Drawing.Size(500, 455);
            this.grpScnActions.TabIndex = 41;
            this.grpScnActions.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDisconnect);
            this.groupBox4.Location = new System.Drawing.Point(16, 190);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 59);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disconnect BT Scanner";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(20, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(113, 31);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // grpHVS
            // 
            this.grpHVS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpHVS.Controls.Add(this.cmbMode);
            this.grpHVS.Controls.Add(this.chkShmPermChange);
            this.grpHVS.Controls.Add(this.chkShmSilentSwitch);
            this.grpHVS.Controls.Add(this.btnSwitchHostMode);
            this.grpHVS.Location = new System.Drawing.Point(223, 247);
            this.grpHVS.Name = "grpHVS";
            this.grpHVS.Size = new System.Drawing.Size(261, 175);
            this.grpHVS.TabIndex = 5;
            this.grpHVS.TabStop = false;
            this.grpHVS.Text = "Switch Host Variant";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Location = new System.Drawing.Point(33, 35);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(204, 21);
            this.cmbMode.TabIndex = 0;
            // 
            // chkShmPermChange
            // 
            this.chkShmPermChange.AutoSize = true;
            this.chkShmPermChange.Location = new System.Drawing.Point(36, 95);
            this.chkShmPermChange.Name = "chkShmPermChange";
            this.chkShmPermChange.Size = new System.Drawing.Size(117, 17);
            this.chkShmPermChange.TabIndex = 2;
            this.chkShmPermChange.Text = "Permanent Change";
            this.chkShmPermChange.UseVisualStyleBackColor = true;
            // 
            // chkShmSilentSwitch
            // 
            this.chkShmSilentSwitch.AutoSize = true;
            this.chkShmSilentSwitch.Location = new System.Drawing.Point(35, 72);
            this.chkShmSilentSwitch.Name = "chkShmSilentSwitch";
            this.chkShmSilentSwitch.Size = new System.Drawing.Size(112, 17);
            this.chkShmSilentSwitch.TabIndex = 1;
            this.chkShmSilentSwitch.Text = "Silent Switch Host";
            this.chkShmSilentSwitch.UseVisualStyleBackColor = true;
            // 
            // btnSwitchHostMode
            // 
            this.btnSwitchHostMode.Location = new System.Drawing.Point(33, 133);
            this.btnSwitchHostMode.Name = "btnSwitchHostMode";
            this.btnSwitchHostMode.Size = new System.Drawing.Size(117, 23);
            this.btnSwitchHostMode.TabIndex = 3;
            this.btnSwitchHostMode.Text = "Switch Host Mode";
            this.btnSwitchHostMode.UseVisualStyleBackColor = true;
            this.btnSwitchHostMode.Click += new System.EventHandler(this.btnSetReport_Click);
            // 
            // grpReboot
            // 
            this.grpReboot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpReboot.Controls.Add(this.btnRebootScanner);
            this.grpReboot.Location = new System.Drawing.Point(16, 117);
            this.grpReboot.Name = "grpReboot";
            this.grpReboot.Size = new System.Drawing.Size(158, 64);
            this.grpReboot.TabIndex = 2;
            this.grpReboot.TabStop = false;
            this.grpReboot.Text = "Reboot Scanner";
            // 
            // btnRebootScanner
            // 
            this.btnRebootScanner.Location = new System.Drawing.Point(20, 19);
            this.btnRebootScanner.Name = "btnRebootScanner";
            this.btnRebootScanner.Size = new System.Drawing.Size(113, 31);
            this.btnRebootScanner.TabIndex = 0;
            this.btnRebootScanner.Text = "Reboot Scanner";
            this.btnRebootScanner.UseVisualStyleBackColor = true;
            this.btnRebootScanner.Click += new System.EventHandler(this.btnRebootScanner_Click);
            // 
            // grpEnbDisScanner
            // 
            this.grpEnbDisScanner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpEnbDisScanner.Controls.Add(this.chkScannerEnable);
            this.grpEnbDisScanner.Location = new System.Drawing.Point(16, 32);
            this.grpEnbDisScanner.Name = "grpEnbDisScanner";
            this.grpEnbDisScanner.Size = new System.Drawing.Size(161, 69);
            this.grpEnbDisScanner.TabIndex = 0;
            this.grpEnbDisScanner.TabStop = false;
            this.grpEnbDisScanner.Text = "Enable/Disable Scanner";
            // 
            // chkScannerEnable
            // 
            this.chkScannerEnable.AutoSize = true;
            this.chkScannerEnable.Location = new System.Drawing.Point(20, 27);
            this.chkScannerEnable.Name = "chkScannerEnable";
            this.chkScannerEnable.Size = new System.Drawing.Size(104, 17);
            this.chkScannerEnable.TabIndex = 0;
            this.chkScannerEnable.Text = "Disable Scanner";
            this.chkScannerEnable.UseVisualStyleBackColor = true;
            this.chkScannerEnable.CheckedChanged += new System.EventHandler(this.OnScannerEnable);
            // 
            // grpBeeper
            // 
            this.grpBeeper.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpBeeper.Controls.Add(this.comboBeep);
            this.grpBeeper.Controls.Add(this.btnSoundBeeper);
            this.grpBeeper.Location = new System.Drawing.Point(223, 117);
            this.grpBeeper.Name = "grpBeeper";
            this.grpBeeper.Size = new System.Drawing.Size(261, 111);
            this.grpBeeper.TabIndex = 3;
            this.grpBeeper.TabStop = false;
            this.grpBeeper.Text = "Beeper";
            // 
            // comboBeep
            // 
            this.comboBeep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBeep.FormattingEnabled = true;
            this.comboBeep.Items.AddRange(new object[] {
            "ONE SHORT HIGH",
            "TWO SHORT HIGH",
            "THREE SHORT HIGH",
            "FOUR SHORT HIGH",
            "FIVE SHORT HIGH",
            "ONE SHORT LOW",
            "TWO SHORT LOW",
            "THREE SHORT LOW",
            "FOUR SHORT LOW",
            "FIVE SHORT LOW",
            "ONE LONG HIGH",
            "TWO LONG HIGH",
            "THREE LONG HIGH",
            "FOUR LONG HIGH",
            "FIVE LONG HIGH",
            "ONE LONG LOW",
            "TWO LONG LOW",
            "THREE LONG LOW",
            "FOUR LONG LOW",
            "FIVE LONG LOW",
            "FAST HIGH LOW HIGH LOW",
            "SLOW HIGH LOW HIGH LOW",
            "HIGH LOW",
            "LOW HIGH",
            "HIGH LOW HIGH",
            "LOW HIGH LOW",
            "HIGH HIGH LOW LOW"});
            this.comboBeep.Location = new System.Drawing.Point(87, 43);
            this.comboBeep.Name = "comboBeep";
            this.comboBeep.Size = new System.Drawing.Size(168, 21);
            this.comboBeep.TabIndex = 0;
            // 
            // btnSoundBeeper
            // 
            this.btnSoundBeeper.Location = new System.Drawing.Point(6, 41);
            this.btnSoundBeeper.Name = "btnSoundBeeper";
            this.btnSoundBeeper.Size = new System.Drawing.Size(70, 23);
            this.btnSoundBeeper.TabIndex = 1;
            this.btnSoundBeeper.Text = "Beep";
            this.btnSoundBeeper.UseVisualStyleBackColor = true;
            this.btnSoundBeeper.Click += new System.EventHandler(this.btnSoundBeeper_Click);
            // 
            // grpLed
            // 
            this.grpLed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpLed.Controls.Add(this.cmbLed);
            this.grpLed.Controls.Add(this.btnLedOff);
            this.grpLed.Controls.Add(this.btnLedOn);
            this.grpLed.Location = new System.Drawing.Point(16, 255);
            this.grpLed.Name = "grpLed";
            this.grpLed.Size = new System.Drawing.Size(161, 167);
            this.grpLed.TabIndex = 4;
            this.grpLed.TabStop = false;
            this.grpLed.Text = "LED";
            // 
            // cmbLed
            // 
            this.cmbLed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLed.FormattingEnabled = true;
            this.cmbLed.Items.AddRange(new object[] {
            "GREEN",
            "YELLOW",
            "RED"});
            this.cmbLed.Location = new System.Drawing.Point(20, 45);
            this.cmbLed.Name = "cmbLed";
            this.cmbLed.Size = new System.Drawing.Size(113, 21);
            this.cmbLed.TabIndex = 0;
            // 
            // btnLedOff
            // 
            this.btnLedOff.Location = new System.Drawing.Point(80, 111);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(54, 23);
            this.btnLedOff.TabIndex = 2;
            this.btnLedOff.Text = "Off";
            this.btnLedOff.UseVisualStyleBackColor = true;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // btnLedOn
            // 
            this.btnLedOn.Location = new System.Drawing.Point(20, 111);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(54, 23);
            this.btnLedOn.TabIndex = 1;
            this.btnLedOn.Text = "On";
            this.btnLedOn.UseVisualStyleBackColor = true;
            this.btnLedOn.Click += new System.EventHandler(this.btnLedOn_Click);
            // 
            // grpAim
            // 
            this.grpAim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpAim.Controls.Add(this.btnAimOn);
            this.grpAim.Controls.Add(this.btnAimOff);
            this.grpAim.Location = new System.Drawing.Point(223, 32);
            this.grpAim.Name = "grpAim";
            this.grpAim.Size = new System.Drawing.Size(261, 58);
            this.grpAim.TabIndex = 1;
            this.grpAim.TabStop = false;
            this.grpAim.Text = "Aim";
            // 
            // btnAimOn
            // 
            this.btnAimOn.Location = new System.Drawing.Point(33, 22);
            this.btnAimOn.Name = "btnAimOn";
            this.btnAimOn.Size = new System.Drawing.Size(75, 23);
            this.btnAimOn.TabIndex = 0;
            this.btnAimOn.Text = "Aim On";
            this.btnAimOn.UseVisualStyleBackColor = true;
            this.btnAimOn.Click += new System.EventHandler(this.btnAimOn_Click);
            // 
            // btnAimOff
            // 
            this.btnAimOff.Location = new System.Drawing.Point(153, 22);
            this.btnAimOff.Name = "btnAimOff";
            this.btnAimOff.Size = new System.Drawing.Size(75, 23);
            this.btnAimOff.TabIndex = 1;
            this.btnAimOff.Text = "Aim Off";
            this.btnAimOff.UseVisualStyleBackColor = true;
            this.btnAimOff.Click += new System.EventHandler(this.btnAimOff_Click);
            // 
            // tabImgVdo
            // 
            this.tabImgVdo.Controls.Add(this.grpImageVideo);
            this.tabImgVdo.Location = new System.Drawing.Point(4, 22);
            this.tabImgVdo.Name = "tabImgVdo";
            this.tabImgVdo.Padding = new System.Windows.Forms.Padding(3);
            this.tabImgVdo.Size = new System.Drawing.Size(567, 698);
            this.tabImgVdo.TabIndex = 1;
            this.tabImgVdo.Text = "Image";
            this.tabImgVdo.UseVisualStyleBackColor = true;
            // 
            // grpImageVideo
            // 
            this.grpImageVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpImageVideo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpImageVideo.Controls.Add(this.btnBarcode);
            this.grpImageVideo.Controls.Add(this.chkVideoViewFinderEnable);
            this.grpImageVideo.Controls.Add(this.btnSveImge);
            this.grpImageVideo.Controls.Add(this.btnVideo);
            this.grpImageVideo.Controls.Add(this.btnImage);
            this.grpImageVideo.Controls.Add(this.btnAbortImageXfer);
            this.grpImageVideo.Controls.Add(this.grpBoxImgType);
            this.grpImageVideo.Controls.Add(this.pbxImageVideo);
            this.grpImageVideo.Location = new System.Drawing.Point(6, 6);
            this.grpImageVideo.Name = "grpImageVideo";
            this.grpImageVideo.Size = new System.Drawing.Size(484, 456);
            this.grpImageVideo.TabIndex = 32;
            this.grpImageVideo.TabStop = false;
            this.grpImageVideo.Text = "Imaging";
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBarcode.Location = new System.Drawing.Point(325, 296);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(75, 23);
            this.btnBarcode.TabIndex = 2;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Visible = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // chkVideoViewFinderEnable
            // 
            this.chkVideoViewFinderEnable.AutoSize = true;
            this.chkVideoViewFinderEnable.Location = new System.Drawing.Point(183, 355);
            this.chkVideoViewFinderEnable.Name = "chkVideoViewFinderEnable";
            this.chkVideoViewFinderEnable.Size = new System.Drawing.Size(147, 17);
            this.chkVideoViewFinderEnable.TabIndex = 3;
            this.chkVideoViewFinderEnable.Text = "Enable Video View Finder";
            this.chkVideoViewFinderEnable.UseVisualStyleBackColor = true;
            this.chkVideoViewFinderEnable.CheckedChanged += new System.EventHandler(this.OnVideoViewFinderEnable);
            // 
            // btnSveImge
            // 
            this.btnSveImge.Location = new System.Drawing.Point(183, 415);
            this.btnSveImge.Name = "btnSveImge";
            this.btnSveImge.Size = new System.Drawing.Size(105, 23);
            this.btnSveImge.TabIndex = 6;
            this.btnSveImge.Text = "Save Image";
            this.btnSveImge.UseVisualStyleBackColor = true;
            this.btnSveImge.Click += new System.EventHandler(this.btnSveImge_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(199, 296);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(80, 23);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Visible = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImage.Location = new System.Drawing.Point(74, 296);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(81, 23);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnAbortImageXfer
            // 
            this.btnAbortImageXfer.Location = new System.Drawing.Point(183, 386);
            this.btnAbortImageXfer.Name = "btnAbortImageXfer";
            this.btnAbortImageXfer.Size = new System.Drawing.Size(105, 23);
            this.btnAbortImageXfer.TabIndex = 5;
            this.btnAbortImageXfer.Text = "Abort Transfer";
            this.btnAbortImageXfer.UseVisualStyleBackColor = true;
            this.btnAbortImageXfer.Click += new System.EventHandler(this.btnAbortImageXfer_Click);
            // 
            // grpBoxImgType
            // 
            this.grpBoxImgType.Controls.Add(this.rdoJPG);
            this.grpBoxImgType.Controls.Add(this.rdoTIFF);
            this.grpBoxImgType.Controls.Add(this.rdoBMP);
            this.grpBoxImgType.Location = new System.Drawing.Point(32, 336);
            this.grpBoxImgType.Name = "grpBoxImgType";
            this.grpBoxImgType.Size = new System.Drawing.Size(123, 113);
            this.grpBoxImgType.TabIndex = 4;
            this.grpBoxImgType.TabStop = false;
            this.grpBoxImgType.Text = "Set Image Type";
            // 
            // rdoJPG
            // 
            this.rdoJPG.AutoSize = true;
            this.rdoJPG.Location = new System.Drawing.Point(25, 19);
            this.rdoJPG.Name = "rdoJPG";
            this.rdoJPG.Size = new System.Drawing.Size(45, 17);
            this.rdoJPG.TabIndex = 0;
            this.rdoJPG.TabStop = true;
            this.rdoJPG.Text = "JPG";
            this.rdoJPG.UseVisualStyleBackColor = true;
            this.rdoJPG.CheckedChanged += new System.EventHandler(this.OnJpg);
            // 
            // rdoTIFF
            // 
            this.rdoTIFF.AutoSize = true;
            this.rdoTIFF.ForeColor = System.Drawing.Color.Black;
            this.rdoTIFF.Location = new System.Drawing.Point(26, 50);
            this.rdoTIFF.Name = "rdoTIFF";
            this.rdoTIFF.Size = new System.Drawing.Size(47, 17);
            this.rdoTIFF.TabIndex = 1;
            this.rdoTIFF.Text = "TIFF";
            this.rdoTIFF.UseVisualStyleBackColor = true;
            this.rdoTIFF.CheckedChanged += new System.EventHandler(this.OnTiff);
            // 
            // rdoBMP
            // 
            this.rdoBMP.AutoSize = true;
            this.rdoBMP.ForeColor = System.Drawing.Color.Black;
            this.rdoBMP.Location = new System.Drawing.Point(25, 79);
            this.rdoBMP.Name = "rdoBMP";
            this.rdoBMP.Size = new System.Drawing.Size(48, 17);
            this.rdoBMP.TabIndex = 2;
            this.rdoBMP.Text = "BMP";
            this.rdoBMP.UseVisualStyleBackColor = true;
            this.rdoBMP.CheckedChanged += new System.EventHandler(this.OnBmp);
            // 
            // pbxImageVideo
            // 
            this.pbxImageVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImageVideo.BackColor = System.Drawing.Color.White;
            this.pbxImageVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImageVideo.Enabled = false;
            this.pbxImageVideo.Location = new System.Drawing.Point(74, 19);
            this.pbxImageVideo.Name = "pbxImageVideo";
            this.pbxImageVideo.Size = new System.Drawing.Size(317, 262);
            this.pbxImageVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageVideo.TabIndex = 10;
            this.pbxImageVideo.TabStop = false;
            // 
            // tabBarcode
            // 
            this.tabBarcode.AutoScroll = true;
            this.tabBarcode.BackColor = System.Drawing.Color.AliceBlue;
            this.tabBarcode.Controls.Add(this.groupBox6);
            this.tabBarcode.Controls.Add(this.groupBox5);
            this.tabBarcode.Controls.Add(this.groupBox1);
            this.tabBarcode.Controls.Add(this.grpBoxLanguage);
            this.tabBarcode.Controls.Add(this.grpboxBarcodeLbl);
            this.tabBarcode.Location = new System.Drawing.Point(4, 22);
            this.tabBarcode.Name = "tabBarcode";
            this.tabBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarcode.Size = new System.Drawing.Size(567, 698);
            this.tabBarcode.TabIndex = 0;
            this.tabBarcode.Text = "Barcode";
            this.tabBarcode.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.txtBarcode);
            this.groupBox6.Location = new System.Drawing.Point(6, 307);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(557, 211);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Manual Input";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Location = new System.Drawing.Point(6, 19);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBarcode.Size = new System.Drawing.Size(541, 186);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextChanged += new System.EventHandler(this.TxtBarcode_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.barcodeGridView);
            this.groupBox5.Controls.Add(this.upcList);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(557, 300);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Scaned Result";
            // 
            // upcList
            // 
            this.upcList.BackColor = System.Drawing.Color.White;
            this.upcList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upcList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUPC1,
            this.colStyle1,
            this.colColor1,
            this.colSize1,
            this.colQuantity1,
            this.colOperation1});
            this.upcList.FullRowSelect = true;
            this.upcList.GridLines = true;
            this.upcList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.upcList.HideSelection = false;
            this.upcList.Location = new System.Drawing.Point(6, 19);
            this.upcList.MultiSelect = false;
            this.upcList.Name = "upcList";
            this.upcList.ShowItemToolTips = true;
            this.upcList.Size = new System.Drawing.Size(545, 91);
            this.upcList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.upcList.TabIndex = 1;
            this.upcList.UseCompatibleStateImageBehavior = false;
            this.upcList.View = System.Windows.Forms.View.Details;
            // 
            // colUPC1
            // 
            this.colUPC1.Text = "UPC #";
            this.colUPC1.Width = 130;
            // 
            // colStyle1
            // 
            this.colStyle1.Text = "Style #";
            this.colStyle1.Width = 130;
            // 
            // colColor1
            // 
            this.colColor1.Text = "Color #";
            // 
            // colSize1
            // 
            this.colSize1.Text = "Size #";
            // 
            // colQuantity1
            // 
            this.colQuantity1.Text = "Quantity";
            // 
            // colOperation1
            // 
            this.colOperation1.Text = "Operation";
            this.colOperation1.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnBrowseScript);
            this.groupBox1.Controls.Add(this.chkBoxAppADF);
            this.groupBox1.Location = new System.Drawing.Point(6, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application ADF";
            this.groupBox1.Visible = false;
            // 
            // btnBrowseScript
            // 
            this.btnBrowseScript.Location = new System.Drawing.Point(163, 16);
            this.btnBrowseScript.Name = "btnBrowseScript";
            this.btnBrowseScript.Size = new System.Drawing.Size(103, 23);
            this.btnBrowseScript.TabIndex = 1;
            this.btnBrowseScript.Text = "Browse Script ...";
            this.btnBrowseScript.UseVisualStyleBackColor = true;
            this.btnBrowseScript.Click += new System.EventHandler(this.btnBrowseScript_Click);
            // 
            // chkBoxAppADF
            // 
            this.chkBoxAppADF.AutoSize = true;
            this.chkBoxAppADF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkBoxAppADF.Enabled = false;
            this.chkBoxAppADF.Location = new System.Drawing.Point(18, 22);
            this.chkBoxAppADF.Name = "chkBoxAppADF";
            this.chkBoxAppADF.Size = new System.Drawing.Size(62, 17);
            this.chkBoxAppADF.TabIndex = 0;
            this.chkBoxAppADF.Text = "Not Set";
            this.chkBoxAppADF.UseVisualStyleBackColor = false;
            // 
            // grpBoxLanguage
            // 
            this.grpBoxLanguage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpBoxLanguage.Controls.Add(this.btnScriptEditor);
            this.grpBoxLanguage.Controls.Add(this.cmbEmulation);
            this.grpBoxLanguage.Controls.Add(this.chkBoxEmulation);
            this.grpBoxLanguage.Location = new System.Drawing.Point(6, 431);
            this.grpBoxLanguage.Name = "grpBoxLanguage";
            this.grpBoxLanguage.Size = new System.Drawing.Size(468, 53);
            this.grpBoxLanguage.TabIndex = 2;
            this.grpBoxLanguage.TabStop = false;
            this.grpBoxLanguage.Text = "Keyboard Emulation and Language/Locale Details";
            this.grpBoxLanguage.Visible = false;
            // 
            // btnScriptEditor
            // 
            this.btnScriptEditor.Location = new System.Drawing.Point(288, 19);
            this.btnScriptEditor.Name = "btnScriptEditor";
            this.btnScriptEditor.Size = new System.Drawing.Size(103, 23);
            this.btnScriptEditor.TabIndex = 2;
            this.btnScriptEditor.Text = "Script Editor ...";
            this.btnScriptEditor.UseVisualStyleBackColor = true;
            this.btnScriptEditor.Click += new System.EventHandler(this.btnScriptEditor_Click);
            // 
            // cmbEmulation
            // 
            this.cmbEmulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmulation.FormattingEnabled = true;
            this.cmbEmulation.Items.AddRange(new object[] {
            "DEFAULT",
            "FRENCH",
            "ENGLISH"});
            this.cmbEmulation.Location = new System.Drawing.Point(163, 20);
            this.cmbEmulation.Name = "cmbEmulation";
            this.cmbEmulation.Size = new System.Drawing.Size(151, 21);
            this.cmbEmulation.TabIndex = 1;
            this.cmbEmulation.SelectedIndexChanged += new System.EventHandler(this.cmbEmulation_SelectedIndexChanged);
            // 
            // chkBoxEmulation
            // 
            this.chkBoxEmulation.AutoSize = true;
            this.chkBoxEmulation.Location = new System.Drawing.Point(18, 22);
            this.chkBoxEmulation.Name = "chkBoxEmulation";
            this.chkBoxEmulation.Size = new System.Drawing.Size(108, 17);
            this.chkBoxEmulation.TabIndex = 0;
            this.chkBoxEmulation.Text = "Enable Emulation";
            this.chkBoxEmulation.UseVisualStyleBackColor = true;
            this.chkBoxEmulation.CheckedChanged += new System.EventHandler(this.chkBoxEmulation_CheckedChanged);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabBarcode);
            this.tabCtrl.Controls.Add(this.tabImgVdo);
            this.tabCtrl.Controls.Add(this.tabISO15434);
            this.tabCtrl.Controls.Add(this.tabScnAction);
            this.tabCtrl.Controls.Add(this.tabRsm);
            this.tabCtrl.Controls.Add(this.tabConfig);
            this.tabCtrl.Controls.Add(this.tabScan2Connect);
            this.tabCtrl.Controls.Add(this.tabMisc);
            this.tabCtrl.Controls.Add(this.tabScale);
            this.tabCtrl.Controls.Add(this.tabSSW);
            this.tabCtrl.Controls.Add(this.tabXml);
            this.tabCtrl.Location = new System.Drawing.Point(473, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(575, 724);
            this.tabCtrl.TabIndex = 1;
            // 
            // barcodeGridView
            // 
            this.barcodeGridView.AllowUserToAddRows = false;
            this.barcodeGridView.AllowUserToDeleteRows = false;
            this.barcodeGridView.AllowUserToResizeColumns = false;
            this.barcodeGridView.AllowUserToResizeRows = false;
            this.barcodeGridView.BackgroundColor = System.Drawing.Color.White;
            this.barcodeGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barcodeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barcodeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUPC,
            this.colStyle,
            this.colColor,
            this.colSize,
            this.colQuantity,
            this.colOperation});
            this.barcodeGridView.Location = new System.Drawing.Point(6, 116);
            this.barcodeGridView.Name = "barcodeGridView";
            this.barcodeGridView.ReadOnly = true;
            this.barcodeGridView.Size = new System.Drawing.Size(545, 178);
            this.barcodeGridView.TabIndex = 2;
            // 
            // colUPC
            // 
            this.colUPC.Frozen = true;
            this.colUPC.HeaderText = "UPC#";
            this.colUPC.Name = "colUPC";
            this.colUPC.ReadOnly = true;
            // 
            // colStyle
            // 
            this.colStyle.Frozen = true;
            this.colStyle.HeaderText = "Style #";
            this.colStyle.Name = "colStyle";
            this.colStyle.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.Frozen = true;
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Width = 60;
            // 
            // colSize
            // 
            this.colSize.Frozen = true;
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 60;
            // 
            // colQuantity
            // 
            this.colQuantity.Frozen = true;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 60;
            // 
            // colOperation
            // 
            this.colOperation.Frozen = true;
            this.colOperation.HeaderText = "Operation";
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            this.colOperation.Width = 120;
            // 
            // frmScannerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1048, 761);
            this.Controls.Add(this.stStripResult);
            this.Controls.Add(this.grpTrigger);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmScannerApp";
            this.Text = "Grand Channel Quick Scan App";
            this.Load += new System.EventHandler(this.frmScannerApp_Load);
            this.grpboxBarcodeLbl.ResumeLayout(false);
            this.grpboxBarcodeLbl.PerformLayout();
            this.grpTrigger.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpScanners.ResumeLayout(false);
            this.tabISO15434.ResumeLayout(false);
            this.grpIDC.ResumeLayout(false);
            this.grpIDC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxISO15434Image)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stStripResult.ResumeLayout(false);
            this.stStripResult.PerformLayout();
            this.tabXml.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpOutXml.ResumeLayout(false);
            this.grpOutXml.PerformLayout();
            this.tabSSW.ResumeLayout(false);
            this.tabSSW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).EndInit();
            this.tabScale.ResumeLayout(false);
            this.grpScale.ResumeLayout(false);
            this.grpScale.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.grpMiscOther.ResumeLayout(false);
            this.grpMiscCmd.ResumeLayout(false);
            this.grpAsync.ResumeLayout(false);
            this.grpAsync.PerformLayout();
            this.grpBaudrate.ResumeLayout(false);
            this.grpBaudrate.PerformLayout();
            this.tabScan2Connect.ResumeLayout(false);
            this.grpScan2Connect.ResumeLayout(false);
            this.grpScan2Connect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarcode)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.grpCustomDecodeTone.ResumeLayout(false);
            this.grpCustomDecodeTone.PerformLayout();
            this.filterScnrs.ResumeLayout(false);
            this.grpFrmWrUpdate.ResumeLayout(false);
            this.grpFrmWrUpdate.PerformLayout();
            this.grpFWoptns.ResumeLayout(false);
            this.grpFWoptns.PerformLayout();
            this.grpScannerProp.ResumeLayout(false);
            this.grpScannerProp.PerformLayout();
            this.tabRsm.ResumeLayout(false);
            this.grpRSM.ResumeLayout(false);
            this.grpBoxClrSlect.ResumeLayout(false);
            this.grpBoxSetRset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).EndInit();
            this.tabScnAction.ResumeLayout(false);
            this.grpScnActions.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.grpHVS.ResumeLayout(false);
            this.grpHVS.PerformLayout();
            this.grpReboot.ResumeLayout(false);
            this.grpEnbDisScanner.ResumeLayout(false);
            this.grpEnbDisScanner.PerformLayout();
            this.grpBeeper.ResumeLayout(false);
            this.grpLed.ResumeLayout(false);
            this.grpAim.ResumeLayout(false);
            this.tabImgVdo.ResumeLayout(false);
            this.grpImageVideo.ResumeLayout(false);
            this.grpImageVideo.PerformLayout();
            this.grpBoxImgType.ResumeLayout(false);
            this.grpBoxImgType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageVideo)).EndInit();
            this.tabBarcode.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxLanguage.ResumeLayout(false);
            this.grpBoxLanguage.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.GroupBox grpTrigger;
        private System.Windows.Forms.Button btnReleaseTrigger;
        private System.Windows.Forms.Button btnPullTrigger;
        private System.Windows.Forms.Button btnGetScanners;
        private System.Windows.Forms.GroupBox grpScanners;
        private System.Windows.Forms.ListView lstvScanners;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.ColumnHeader clmSerial;
        private System.Windows.Forms.ColumnHeader clmModel;
        private System.Windows.Forms.ColumnHeader clmGuid;
        private System.Windows.Forms.OpenFileDialog openFileDialogFW;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogAttr;
        private System.Windows.Forms.StatusStrip stStripResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblSnapi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblSsi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblIbmhid;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblHidkb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblNxmdb;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.ComboBox combSlcrScnr;
        private System.Windows.Forms.GroupBox grpboxBarcodeLbl;
        private System.Windows.Forms.TextBox txtBarcodeLbl;
        private System.Windows.Forms.SaveFileDialog saveImgFileDialog;
        private System.Windows.Forms.Label lblSlctScnnr;
        private System.Windows.Forms.Button btnFlushMacroPdf;
        private System.Windows.Forms.Button btnBarcodeClear;
        private System.Windows.Forms.Button btnAbortMacroPdf;
        private System.Windows.Forms.Label lblDecdBarCde;
        private System.Windows.Forms.Label lblSyblogy;
        private System.Windows.Forms.TextBox txtSyblogy;
        private System.Windows.Forms.ColumnHeader clmFrmwr;
        private System.Windows.Forms.ColumnHeader clmMnftrd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIBMTT;
        private System.Windows.Forms.OpenFileDialog openFileDialogWavFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogDADF;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBarcodePath;
        private System.Windows.Forms.Button btnUploadAdd;
        private System.Windows.Forms.Button btnUploadMinus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbContainerNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbBatchId;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.TextBox tbPcs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbCartonRange;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabXml;
        private System.Windows.Forms.Button btnClearXmlArea;
        private System.Windows.Forms.Button btnClearLogsArea;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.GroupBox grpOutXml;
        private System.Windows.Forms.TextBox txtOutXml;
        private System.Windows.Forms.TabPage tabSSW;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtEpcId;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtUserBank;
        private System.Windows.Forms.TextBox txtNewEpcId;
        private System.Windows.Forms.TextBox txtUpcaBarcode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.RadioButton rdoASCII;
        private System.Windows.Forms.Button btnVerifyTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteTag;
        private System.Windows.Forms.ComboBox cmbPartition;
        private System.Windows.Forms.ComboBox cmbFilterValue;
        private System.Windows.Forms.PictureBox statusIcon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkAutoIncrement;
        private System.Windows.Forms.Label lblUserBank;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabScale;
        private System.Windows.Forms.GroupBox grpScale;
        private System.Windows.Forms.Label lblScalStatusDesc;
        private System.Windows.Forms.TextBox txtWeightUnit;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSystemRest;
        private System.Windows.Forms.Button btnZeroScale;
        private System.Windows.Forms.Button btnReadWeight;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.GroupBox grpMiscOther;
        private System.Windows.Forms.GroupBox grpMiscCmd;
        private System.Windows.Forms.Button btnGetDevTopology;
        private System.Windows.Forms.Button btnSdkVersion;
        private System.Windows.Forms.GroupBox grpAsync;
        private System.Windows.Forms.CheckBox chkAsync;
        private System.Windows.Forms.GroupBox grpBaudrate;
        private System.Windows.Forms.Label lblStpBits;
        private System.Windows.Forms.ComboBox comboStpBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.Button btnSetSrilInfce;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.Label lblBaudRte;
        private System.Windows.Forms.ComboBox comboDataBits;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.CheckBox flwCtrlChkBox;
        private System.Windows.Forms.TabPage tabScan2Connect;
        private System.Windows.Forms.GroupBox grpScan2Connect;
        private System.Windows.Forms.Button btnSaveBarcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbHostName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbScannerType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBBarcode;
        private System.Windows.Forms.ComboBox cmbImageSize;
        private System.Windows.Forms.ComboBox cmbDefaultOption;
        private System.Windows.Forms.ComboBox cmbProtocol;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.GroupBox grpCustomDecodeTone;
        private System.Windows.Forms.Button btnEraseTone;
        private System.Windows.Forms.Button buttonWavFileUpload;
        private System.Windows.Forms.TextBox textBoxWavFile;
        private System.Windows.Forms.Button buttonWavFileBrowse;
        private System.Windows.Forms.GroupBox filterScnrs;
        private System.Windows.Forms.ComboBox comboFilterScnrs;
        private System.Windows.Forms.GroupBox grpFrmWrUpdate;
        private System.Windows.Forms.GroupBox grpFWoptns;
        private System.Windows.Forms.CheckBox chkBulk;
        private System.Windows.Forms.Button btnAbortFWUpdate;
        private System.Windows.Forms.Button btnFWUpdate;
        private System.Windows.Forms.Button btnLaunchNewFW;
        private System.Windows.Forms.ProgressBar progressBarFWUpdate;
        private System.Windows.Forms.Button buttonFWBrowse;
        private System.Windows.Forms.TextBox txtFWFile;
        private System.Windows.Forms.GroupBox grpScannerProp;
        private System.Windows.Forms.CheckBox chkClaim;
        private System.Windows.Forms.TabPage tabRsm;
        private System.Windows.Forms.GroupBox grpRSM;
        private System.Windows.Forms.GroupBox grpBoxClrSlect;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox grpBoxSetRset;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnGetNext;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.DataGridView dgvAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn attrNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn attrType;
        private System.Windows.Forms.DataGridViewTextBoxColumn property;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.TabPage tabScnAction;
        private System.Windows.Forms.GroupBox grpScnActions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grpHVS;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.CheckBox chkShmPermChange;
        private System.Windows.Forms.CheckBox chkShmSilentSwitch;
        private System.Windows.Forms.Button btnSwitchHostMode;
        private System.Windows.Forms.GroupBox grpReboot;
        private System.Windows.Forms.Button btnRebootScanner;
        private System.Windows.Forms.GroupBox grpEnbDisScanner;
        private System.Windows.Forms.CheckBox chkScannerEnable;
        private System.Windows.Forms.GroupBox grpBeeper;
        private System.Windows.Forms.ComboBox comboBeep;
        private System.Windows.Forms.Button btnSoundBeeper;
        private System.Windows.Forms.GroupBox grpLed;
        private System.Windows.Forms.ComboBox cmbLed;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.GroupBox grpAim;
        private System.Windows.Forms.Button btnAimOn;
        private System.Windows.Forms.Button btnAimOff;
        private System.Windows.Forms.TabPage tabISO15434;
        public System.Windows.Forms.GroupBox grpIDC;
        private System.Windows.Forms.PictureBox pbxISO15434Image;
        private System.Windows.Forms.Button btnClearpbx;
        private System.Windows.Forms.CheckBox checkUseHID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSnapiStore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSnapiParamValue;
        private System.Windows.Forms.Button btnSnapiSet;
        private System.Windows.Forms.Button btnSnapiGet;
        private System.Windows.Forms.ComboBox cmbSnapiParams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocCapDecodeDataSymbol;
        private System.Windows.Forms.TextBox txtDocCapDecodeData;
        private System.Windows.Forms.TabPage tabImgVdo;
        private System.Windows.Forms.GroupBox grpImageVideo;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.CheckBox chkVideoViewFinderEnable;
        private System.Windows.Forms.Button btnSveImge;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnAbortImageXfer;
        private System.Windows.Forms.GroupBox grpBoxImgType;
        private System.Windows.Forms.RadioButton rdoJPG;
        private System.Windows.Forms.RadioButton rdoTIFF;
        private System.Windows.Forms.RadioButton rdoBMP;
        private System.Windows.Forms.PictureBox pbxImageVideo;
        private System.Windows.Forms.TabPage tabBarcode;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnBrowseScript;
        private System.Windows.Forms.CheckBox chkBoxAppADF;
        private System.Windows.Forms.ListView upcList;
        private System.Windows.Forms.ColumnHeader colUPC1;
        private System.Windows.Forms.ColumnHeader colStyle1;
        private System.Windows.Forms.ColumnHeader colColor1;
        private System.Windows.Forms.ColumnHeader colSize1;
        private System.Windows.Forms.GroupBox grpBoxLanguage;
        private System.Windows.Forms.Button btnScriptEditor;
        private System.Windows.Forms.ComboBox cmbEmulation;
        private System.Windows.Forms.CheckBox chkBoxEmulation;
        private System.Windows.Forms.ColumnHeader colQuantity1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ColumnHeader colOperation1;
        private System.Windows.Forms.DataGridView barcodeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn colOperation;
    }
}

