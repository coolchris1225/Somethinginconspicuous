namespace bingRewards
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mobileSearchesLeftBox = new System.Windows.Forms.TextBox();
            this.searchModeBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.stuckTimer = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.AmazonBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBrowser = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.timeStartEnable = new System.Windows.Forms.CheckBox();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.timeStartLabel = new System.Windows.Forms.Label();
            this.timeStartMinutes = new System.Windows.Forms.NumericUpDown();
            this.timeStartHours = new System.Windows.Forms.NumericUpDown();
            this.searchTypeLabel = new System.Windows.Forms.Label();
            this.searchType = new System.Windows.Forms.TextBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.timeVariance = new System.Windows.Forms.TextBox();
            this.timeVarianceLabel = new System.Windows.Forms.Label();
            this.desktopSearchesMax = new System.Windows.Forms.TextBox();
            this.desktopSearchesMaxLabel = new System.Windows.Forms.Label();
            this.desktopSearchesMinLabel = new System.Windows.Forms.Label();
            this.desktopSearchesMin = new System.Windows.Forms.TextBox();
            this.mobileSearchesMax = new System.Windows.Forms.TextBox();
            this.mobileSearchesMaxLabel = new System.Windows.Forms.Label();
            this.mobileSearchesMinLabel = new System.Windows.Forms.Label();
            this.searchSpeedMaxLabel = new System.Windows.Forms.Label();
            this.searchSpeedMinLabel = new System.Windows.Forms.Label();
            this.startSpeedLabel = new System.Windows.Forms.Label();
            this.mobileSearchesMin = new System.Windows.Forms.TextBox();
            this.searchSpeedMax = new System.Windows.Forms.TextBox();
            this.searchSpeedMin = new System.Windows.Forms.TextBox();
            this.startSpeed = new System.Windows.Forms.TextBox();
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.hideBrowser = new System.Windows.Forms.CheckBox();
            this.startMinimized = new System.Windows.Forms.CheckBox();
            this.pursueSearchOrder = new System.Windows.Forms.CheckBox();
            this.randomizeAccountOrder = new System.Windows.Forms.CheckBox();
            this.autoClose = new System.Windows.Forms.CheckBox();
            this.testLBL = new System.Windows.Forms.Label();
            this.searchTimerIntervalLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desktopSearchesLeftBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBrowser.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mobile Searches Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mode";
            // 
            // mobileSearchesLeftBox
            // 
            this.mobileSearchesLeftBox.Enabled = false;
            this.mobileSearchesLeftBox.Location = new System.Drawing.Point(345, 7);
            this.mobileSearchesLeftBox.Name = "mobileSearchesLeftBox";
            this.mobileSearchesLeftBox.Size = new System.Drawing.Size(37, 20);
            this.mobileSearchesLeftBox.TabIndex = 3;
            // 
            // searchModeBox
            // 
            this.searchModeBox.Enabled = false;
            this.searchModeBox.Location = new System.Drawing.Point(529, 601);
            this.searchModeBox.Name = "searchModeBox";
            this.searchModeBox.Size = new System.Drawing.Size(88, 20);
            this.searchModeBox.TabIndex = 4;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(9, 9);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(47, 13);
            this.accountLabel.TabIndex = 5;
            this.accountLabel.Text = "Account";
            // 
            // accountBox
            // 
            this.accountBox.Enabled = false;
            this.accountBox.Location = new System.Drawing.Point(59, 6);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(168, 20);
            this.accountBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // startTimer
            // 
            this.startTimer.Interval = 50000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // searchTimer
            // 
            this.searchTimer.Interval = 50000;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.startBtn.Location = new System.Drawing.Point(1080, 6);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // notesBox
            // 
            this.notesBox.Enabled = false;
            this.notesBox.Location = new System.Drawing.Point(601, 6);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(383, 21);
            this.notesBox.TabIndex = 10;
            this.notesBox.Text = "If you see windows login page, do not fill it in or login. The system will login " +
    "itself. The search results will come up with 0 results most of the time. Ignore " +
    "this, this still counts as a search.";
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 30000;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // stuckTimer
            // 
            this.stuckTimer.Interval = 60000;
            this.stuckTimer.Tick += new System.EventHandler(this.stuckTimer_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 394);
            this.listBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 423);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 64);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amazon Account";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(18, 506);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 30);
            this.listBox2.TabIndex = 0;
            // 
            // PauseBtn
            // 
            this.PauseBtn.ForeColor = System.Drawing.Color.Red;
            this.PauseBtn.Location = new System.Drawing.Point(999, 6);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 18;
            this.PauseBtn.Text = "PAUSE";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // AmazonBtn
            // 
            this.AmazonBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AmazonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmazonBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.AmazonBtn.Location = new System.Drawing.Point(1161, 6);
            this.AmazonBtn.Name = "AmazonBtn";
            this.AmazonBtn.Size = new System.Drawing.Size(95, 23);
            this.AmazonBtn.TabIndex = 19;
            this.AmazonBtn.Text = "$$NIGGA$$";
            this.AmazonBtn.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 621);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1237, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1008, 492);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(238, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 517);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browser";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBrowser);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 600);
            this.tabControl1.TabIndex = 1;
            // 
            // tabBrowser
            // 
            this.tabBrowser.Controls.Add(this.desktopSearchesLeftBox);
            this.tabBrowser.Controls.Add(this.label4);
            this.tabBrowser.Controls.Add(this.accountBox);
            this.tabBrowser.Controls.Add(this.accountLabel);
            this.tabBrowser.Controls.Add(this.listBox2);
            this.tabBrowser.Controls.Add(this.groupBox2);
            this.tabBrowser.Controls.Add(this.label1);
            this.tabBrowser.Controls.Add(this.groupBox3);
            this.tabBrowser.Controls.Add(this.AmazonBtn);
            this.tabBrowser.Controls.Add(this.groupBox1);
            this.tabBrowser.Controls.Add(this.PauseBtn);
            this.tabBrowser.Controls.Add(this.mobileSearchesLeftBox);
            this.tabBrowser.Controls.Add(this.label3);
            this.tabBrowser.Controls.Add(this.notesBox);
            this.tabBrowser.Controls.Add(this.startBtn);
            this.tabBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser.Size = new System.Drawing.Size(1278, 574);
            this.tabBrowser.TabIndex = 0;
            this.tabBrowser.Text = "Browser";
            this.tabBrowser.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.timeStartEnable);
            this.tabSettings.Controls.Add(this.MinutesLabel);
            this.tabSettings.Controls.Add(this.timeStartLabel);
            this.tabSettings.Controls.Add(this.timeStartMinutes);
            this.tabSettings.Controls.Add(this.timeStartHours);
            this.tabSettings.Controls.Add(this.searchTypeLabel);
            this.tabSettings.Controls.Add(this.searchType);
            this.tabSettings.Controls.Add(this.saveSettings);
            this.tabSettings.Controls.Add(this.timeVariance);
            this.tabSettings.Controls.Add(this.timeVarianceLabel);
            this.tabSettings.Controls.Add(this.desktopSearchesMax);
            this.tabSettings.Controls.Add(this.desktopSearchesMaxLabel);
            this.tabSettings.Controls.Add(this.desktopSearchesMinLabel);
            this.tabSettings.Controls.Add(this.desktopSearchesMin);
            this.tabSettings.Controls.Add(this.mobileSearchesMax);
            this.tabSettings.Controls.Add(this.mobileSearchesMaxLabel);
            this.tabSettings.Controls.Add(this.mobileSearchesMinLabel);
            this.tabSettings.Controls.Add(this.searchSpeedMaxLabel);
            this.tabSettings.Controls.Add(this.searchSpeedMinLabel);
            this.tabSettings.Controls.Add(this.startSpeedLabel);
            this.tabSettings.Controls.Add(this.mobileSearchesMin);
            this.tabSettings.Controls.Add(this.searchSpeedMax);
            this.tabSettings.Controls.Add(this.searchSpeedMin);
            this.tabSettings.Controls.Add(this.startSpeed);
            this.tabSettings.Controls.Add(this.autoStart);
            this.tabSettings.Controls.Add(this.hideBrowser);
            this.tabSettings.Controls.Add(this.startMinimized);
            this.tabSettings.Controls.Add(this.pursueSearchOrder);
            this.tabSettings.Controls.Add(this.randomizeAccountOrder);
            this.tabSettings.Controls.Add(this.autoClose);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1278, 574);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // timeStartEnable
            // 
            this.timeStartEnable.AutoSize = true;
            this.timeStartEnable.Location = new System.Drawing.Point(703, 156);
            this.timeStartEnable.Name = "timeStartEnable";
            this.timeStartEnable.Size = new System.Drawing.Size(59, 17);
            this.timeStartEnable.TabIndex = 66;
            this.timeStartEnable.Text = "Enable";
            this.timeStartEnable.UseVisualStyleBackColor = true;
            this.timeStartEnable.CheckedChanged += new System.EventHandler(this.timeStartEnable_CheckedChanged);
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(382, 154);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(25, 13);
            this.MinutesLabel.TabIndex = 65;
            this.MinutesLabel.Text = "MM";
            // 
            // timeStartLabel
            // 
            this.timeStartLabel.AutoSize = true;
            this.timeStartLabel.Location = new System.Drawing.Point(202, 154);
            this.timeStartLabel.Name = "timeStartLabel";
            this.timeStartLabel.Size = new System.Drawing.Size(139, 13);
            this.timeStartLabel.TabIndex = 64;
            this.timeStartLabel.Text = "Automatic Time Start     HH:";
            // 
            // timeStartMinutes
            // 
            this.timeStartMinutes.Location = new System.Drawing.Point(408, 151);
            this.timeStartMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.timeStartMinutes.Name = "timeStartMinutes";
            this.timeStartMinutes.Size = new System.Drawing.Size(35, 20);
            this.timeStartMinutes.TabIndex = 63;
            // 
            // timeStartHours
            // 
            this.timeStartHours.Location = new System.Drawing.Point(343, 151);
            this.timeStartHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timeStartHours.Name = "timeStartHours";
            this.timeStartHours.Size = new System.Drawing.Size(37, 20);
            this.timeStartHours.TabIndex = 62;
            // 
            // searchTypeLabel
            // 
            this.searchTypeLabel.AutoSize = true;
            this.searchTypeLabel.Location = new System.Drawing.Point(274, 21);
            this.searchTypeLabel.Name = "searchTypeLabel";
            this.searchTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.searchTypeLabel.TabIndex = 60;
            this.searchTypeLabel.Text = "Search Type";
            // 
            // searchType
            // 
            this.searchType.Location = new System.Drawing.Point(343, 18);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(100, 20);
            this.searchType.TabIndex = 59;
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(1134, 516);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(75, 23);
            this.saveSettings.TabIndex = 58;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // timeVariance
            // 
            this.timeVariance.Location = new System.Drawing.Point(597, 153);
            this.timeVariance.Name = "timeVariance";
            this.timeVariance.Size = new System.Drawing.Size(100, 20);
            this.timeVariance.TabIndex = 57;
            // 
            // timeVarianceLabel
            // 
            this.timeVarianceLabel.AutoSize = true;
            this.timeVarianceLabel.Location = new System.Drawing.Point(464, 156);
            this.timeVarianceLabel.Name = "timeVarianceLabel";
            this.timeVarianceLabel.Size = new System.Drawing.Size(132, 13);
            this.timeVarianceLabel.TabIndex = 56;
            this.timeVarianceLabel.Text = "Time Variance (in Minutes)";
            // 
            // desktopSearchesMax
            // 
            this.desktopSearchesMax.Location = new System.Drawing.Point(597, 127);
            this.desktopSearchesMax.Name = "desktopSearchesMax";
            this.desktopSearchesMax.Size = new System.Drawing.Size(100, 20);
            this.desktopSearchesMax.TabIndex = 53;
            // 
            // desktopSearchesMaxLabel
            // 
            this.desktopSearchesMaxLabel.AutoSize = true;
            this.desktopSearchesMaxLabel.Location = new System.Drawing.Point(464, 130);
            this.desktopSearchesMaxLabel.Name = "desktopSearchesMaxLabel";
            this.desktopSearchesMaxLabel.Size = new System.Drawing.Size(118, 13);
            this.desktopSearchesMaxLabel.TabIndex = 52;
            this.desktopSearchesMaxLabel.Text = "Desktop Searches Max";
            // 
            // desktopSearchesMinLabel
            // 
            this.desktopSearchesMinLabel.AutoSize = true;
            this.desktopSearchesMinLabel.Location = new System.Drawing.Point(222, 127);
            this.desktopSearchesMinLabel.Name = "desktopSearchesMinLabel";
            this.desktopSearchesMinLabel.Size = new System.Drawing.Size(115, 13);
            this.desktopSearchesMinLabel.TabIndex = 51;
            this.desktopSearchesMinLabel.Text = "Desktop Searches Min";
            // 
            // desktopSearchesMin
            // 
            this.desktopSearchesMin.Location = new System.Drawing.Point(343, 124);
            this.desktopSearchesMin.Name = "desktopSearchesMin";
            this.desktopSearchesMin.Size = new System.Drawing.Size(100, 20);
            this.desktopSearchesMin.TabIndex = 50;
            // 
            // mobileSearchesMax
            // 
            this.mobileSearchesMax.Location = new System.Drawing.Point(597, 101);
            this.mobileSearchesMax.Name = "mobileSearchesMax";
            this.mobileSearchesMax.Size = new System.Drawing.Size(100, 20);
            this.mobileSearchesMax.TabIndex = 49;
            // 
            // mobileSearchesMaxLabel
            // 
            this.mobileSearchesMaxLabel.AutoSize = true;
            this.mobileSearchesMaxLabel.Location = new System.Drawing.Point(473, 104);
            this.mobileSearchesMaxLabel.Name = "mobileSearchesMaxLabel";
            this.mobileSearchesMaxLabel.Size = new System.Drawing.Size(109, 13);
            this.mobileSearchesMaxLabel.TabIndex = 48;
            this.mobileSearchesMaxLabel.Text = "Mobile Searches Max";
            // 
            // mobileSearchesMinLabel
            // 
            this.mobileSearchesMinLabel.AutoSize = true;
            this.mobileSearchesMinLabel.Location = new System.Drawing.Point(231, 101);
            this.mobileSearchesMinLabel.Name = "mobileSearchesMinLabel";
            this.mobileSearchesMinLabel.Size = new System.Drawing.Size(106, 13);
            this.mobileSearchesMinLabel.TabIndex = 47;
            this.mobileSearchesMinLabel.Text = "Mobile Searches Min";
            // 
            // searchSpeedMaxLabel
            // 
            this.searchSpeedMaxLabel.AutoSize = true;
            this.searchSpeedMaxLabel.Location = new System.Drawing.Point(484, 75);
            this.searchSpeedMaxLabel.Name = "searchSpeedMaxLabel";
            this.searchSpeedMaxLabel.Size = new System.Drawing.Size(98, 13);
            this.searchSpeedMaxLabel.TabIndex = 46;
            this.searchSpeedMaxLabel.Text = "Search Speed Max";
            // 
            // searchSpeedMinLabel
            // 
            this.searchSpeedMinLabel.AutoSize = true;
            this.searchSpeedMinLabel.Location = new System.Drawing.Point(242, 72);
            this.searchSpeedMinLabel.Name = "searchSpeedMinLabel";
            this.searchSpeedMinLabel.Size = new System.Drawing.Size(95, 13);
            this.searchSpeedMinLabel.TabIndex = 45;
            this.searchSpeedMinLabel.Text = "Search Speed Min";
            // 
            // startSpeedLabel
            // 
            this.startSpeedLabel.AutoSize = true;
            this.startSpeedLabel.Location = new System.Drawing.Point(274, 47);
            this.startSpeedLabel.Name = "startSpeedLabel";
            this.startSpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.startSpeedLabel.TabIndex = 44;
            this.startSpeedLabel.Text = "Start Speed";
            // 
            // mobileSearchesMin
            // 
            this.mobileSearchesMin.Location = new System.Drawing.Point(343, 98);
            this.mobileSearchesMin.Name = "mobileSearchesMin";
            this.mobileSearchesMin.Size = new System.Drawing.Size(100, 20);
            this.mobileSearchesMin.TabIndex = 43;
            // 
            // searchSpeedMax
            // 
            this.searchSpeedMax.Location = new System.Drawing.Point(597, 72);
            this.searchSpeedMax.Name = "searchSpeedMax";
            this.searchSpeedMax.Size = new System.Drawing.Size(100, 20);
            this.searchSpeedMax.TabIndex = 42;
            // 
            // searchSpeedMin
            // 
            this.searchSpeedMin.Location = new System.Drawing.Point(343, 69);
            this.searchSpeedMin.Name = "searchSpeedMin";
            this.searchSpeedMin.Size = new System.Drawing.Size(100, 20);
            this.searchSpeedMin.TabIndex = 41;
            // 
            // startSpeed
            // 
            this.startSpeed.Location = new System.Drawing.Point(343, 44);
            this.startSpeed.Name = "startSpeed";
            this.startSpeed.Size = new System.Drawing.Size(100, 20);
            this.startSpeed.TabIndex = 40;
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Location = new System.Drawing.Point(25, 83);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(73, 17);
            this.autoStart.TabIndex = 39;
            this.autoStart.Text = "Auto Start";
            this.autoStart.UseVisualStyleBackColor = true;
            // 
            // hideBrowser
            // 
            this.hideBrowser.AutoSize = true;
            this.hideBrowser.Location = new System.Drawing.Point(25, 152);
            this.hideBrowser.Name = "hideBrowser";
            this.hideBrowser.Size = new System.Drawing.Size(89, 17);
            this.hideBrowser.TabIndex = 38;
            this.hideBrowser.Text = "Hide Browser";
            this.hideBrowser.UseVisualStyleBackColor = true;
            // 
            // startMinimized
            // 
            this.startMinimized.AutoSize = true;
            this.startMinimized.Location = new System.Drawing.Point(25, 129);
            this.startMinimized.Name = "startMinimized";
            this.startMinimized.Size = new System.Drawing.Size(97, 17);
            this.startMinimized.TabIndex = 37;
            this.startMinimized.Text = "Start Minimized";
            this.startMinimized.UseVisualStyleBackColor = true;
            // 
            // pursueSearchOrder
            // 
            this.pursueSearchOrder.AutoSize = true;
            this.pursueSearchOrder.Location = new System.Drawing.Point(25, 60);
            this.pursueSearchOrder.Name = "pursueSearchOrder";
            this.pursueSearchOrder.Size = new System.Drawing.Size(134, 17);
            this.pursueSearchOrder.TabIndex = 35;
            this.pursueSearchOrder.Text = "Pursue Search Results";
            this.pursueSearchOrder.UseVisualStyleBackColor = true;
            // 
            // randomizeAccountOrder
            // 
            this.randomizeAccountOrder.AutoSize = true;
            this.randomizeAccountOrder.Location = new System.Drawing.Point(25, 37);
            this.randomizeAccountOrder.Name = "randomizeAccountOrder";
            this.randomizeAccountOrder.Size = new System.Drawing.Size(151, 17);
            this.randomizeAccountOrder.TabIndex = 34;
            this.randomizeAccountOrder.Text = "Randomize Account Order";
            this.randomizeAccountOrder.UseVisualStyleBackColor = true;
            // 
            // autoClose
            // 
            this.autoClose.AutoSize = true;
            this.autoClose.Location = new System.Drawing.Point(25, 106);
            this.autoClose.Name = "autoClose";
            this.autoClose.Size = new System.Drawing.Size(77, 17);
            this.autoClose.TabIndex = 36;
            this.autoClose.Text = "Auto Close";
            this.autoClose.UseVisualStyleBackColor = true;
            // 
            // testLBL
            // 
            this.testLBL.AutoSize = true;
            this.testLBL.Location = new System.Drawing.Point(1248, 621);
            this.testLBL.Name = "testLBL";
            this.testLBL.Size = new System.Drawing.Size(35, 13);
            this.testLBL.TabIndex = 31;
            this.testLBL.Text = "label4";
            // 
            // searchTimerIntervalLbl
            // 
            this.searchTimerIntervalLbl.AutoSize = true;
            this.searchTimerIntervalLbl.Location = new System.Drawing.Point(12, 604);
            this.searchTimerIntervalLbl.Name = "searchTimerIntervalLbl";
            this.searchTimerIntervalLbl.Size = new System.Drawing.Size(111, 13);
            this.searchTimerIntervalLbl.TabIndex = 32;
            this.searchTimerIntervalLbl.Text = "Search Timer Interval:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Desktop Searches Left:";
            // 
            // desktopSearchesLeftBox
            // 
            this.desktopSearchesLeftBox.Enabled = false;
            this.desktopSearchesLeftBox.Location = new System.Drawing.Point(507, 6);
            this.desktopSearchesLeftBox.Name = "desktopSearchesLeftBox";
            this.desktopSearchesLeftBox.Size = new System.Drawing.Size(37, 20);
            this.desktopSearchesLeftBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 655);
            this.Controls.Add(this.searchTimerIntervalLbl);
            this.Controls.Add(this.testLBL);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.searchModeBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bing Rewards Search Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBrowser.ResumeLayout(false);
            this.tabBrowser.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStartHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mobileSearchesLeftBox;
        private System.Windows.Forms.TextBox searchModeBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Timer stuckTimer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button AmazonBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBrowser;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.CheckBox pursueSearchOrder;
        private System.Windows.Forms.CheckBox randomizeAccountOrder;
        private System.Windows.Forms.CheckBox autoClose;
        private System.Windows.Forms.TextBox mobileSearchesMax;
        private System.Windows.Forms.Label mobileSearchesMaxLabel;
        private System.Windows.Forms.Label mobileSearchesMinLabel;
        private System.Windows.Forms.Label searchSpeedMaxLabel;
        private System.Windows.Forms.Label searchSpeedMinLabel;
        private System.Windows.Forms.Label startSpeedLabel;
        private System.Windows.Forms.TextBox mobileSearchesMin;
        private System.Windows.Forms.TextBox searchSpeedMax;
        private System.Windows.Forms.TextBox searchSpeedMin;
        private System.Windows.Forms.TextBox startSpeed;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.CheckBox hideBrowser;
        private System.Windows.Forms.CheckBox startMinimized;
        private System.Windows.Forms.TextBox desktopSearchesMax;
        private System.Windows.Forms.Label desktopSearchesMaxLabel;
        private System.Windows.Forms.Label desktopSearchesMinLabel;
        private System.Windows.Forms.TextBox desktopSearchesMin;
        private System.Windows.Forms.TextBox timeVariance;
        private System.Windows.Forms.Label timeVarianceLabel;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Label searchTypeLabel;
        private System.Windows.Forms.TextBox searchType;
        private System.Windows.Forms.Label timeStartLabel;
        private System.Windows.Forms.NumericUpDown timeStartMinutes;
        private System.Windows.Forms.NumericUpDown timeStartHours;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label testLBL;
        private System.Windows.Forms.CheckBox timeStartEnable;
        private System.Windows.Forms.Label searchTimerIntervalLbl;
        private System.Windows.Forms.TextBox desktopSearchesLeftBox;
        private System.Windows.Forms.Label label4;
    }
}

