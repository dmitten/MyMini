namespace MyMini
{
    partial class URMFG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URMFG));
            this.CopyBTN = new System.Windows.Forms.Button();
            this.LogOnBTN = new System.Windows.Forms.Button();
            this.loscb = new System.Windows.Forms.ComboBox();
            this.ICD9cb = new System.Windows.Forms.ComboBox();
            this.epicloginnamepb = new System.Windows.Forms.PictureBox();
            this.screenpb = new System.Windows.Forms.PictureBox();
            this.rightsmalltrigger = new System.Windows.Forms.Button();
            this.leftringtrigger = new System.Windows.Forms.Button();
            this.leftsmalltrigger = new System.Windows.Forms.Button();
            this.rightindextrigger = new System.Windows.Forms.Button();
            this.rightlongtrigger = new System.Windows.Forms.Button();
            this.rightringtrigger = new System.Windows.Forms.Button();
            this.leftlongtrigger = new System.Windows.Forms.Button();
            this.leftindextrigger = new System.Windows.Forms.Button();
            this.rightthumbtrigger = new System.Windows.Forms.Button();
            this.leftthumbtrigger = new System.Windows.Forms.Button();
            this.leftbasal = new System.Windows.Forms.Button();
            this.rightbasal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.rBPlan = new System.Windows.Forms.RadioButton();
            this.rBExam = new System.Windows.Forms.RadioButton();
            this.rBHistory = new System.Windows.Forms.RadioButton();
            this.rBAll = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FURB = new System.Windows.Forms.RadioButton();
            this.PostOPRB = new System.Windows.Forms.RadioButton();
            this.NewRB = new System.Windows.Forms.RadioButton();
            this.epicmitten = new System.Windows.Forms.PictureBox();
            this.cBNote = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epicloginnamepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenpb)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicmitten)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyBTN
            // 
            this.CopyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyBTN.Location = new System.Drawing.Point(94, 615);
            this.CopyBTN.Margin = new System.Windows.Forms.Padding(6);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(26, 40);
            this.CopyBTN.TabIndex = 65;
            this.CopyBTN.Text = "C";
            this.CopyBTN.UseVisualStyleBackColor = true;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // LogOnBTN
            // 
            this.LogOnBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOnBTN.Location = new System.Drawing.Point(50, 615);
            this.LogOnBTN.Margin = new System.Windows.Forms.Padding(6);
            this.LogOnBTN.Name = "LogOnBTN";
            this.LogOnBTN.Size = new System.Drawing.Size(26, 40);
            this.LogOnBTN.TabIndex = 66;
            this.LogOnBTN.Text = "L";
            this.LogOnBTN.UseVisualStyleBackColor = true;
            this.LogOnBTN.Click += new System.EventHandler(this.LogOnBTN_Click);
            // 
            // loscb
            // 
            this.loscb.BackColor = System.Drawing.SystemColors.Window;
            this.loscb.FormattingEnabled = true;
            this.loscb.Items.AddRange(new object[] {
            "FU                 99213",
            "New              99243",
            "Postop          99024",
            "SLU                99455",
            "NC                 99999",
            "",
            "OR CCO     All 99999"});
            this.loscb.Location = new System.Drawing.Point(1106, 281);
            this.loscb.Margin = new System.Windows.Forms.Padding(6);
            this.loscb.Name = "loscb";
            this.loscb.Size = new System.Drawing.Size(104, 33);
            this.loscb.TabIndex = 67;
            this.loscb.Text = "LOS";
            this.loscb.SelectedIndexChanged += new System.EventHandler(this.loscb_SelectedIndexChanged);
            // 
            // ICD9cb
            // 
            this.ICD9cb.BackColor = System.Drawing.SystemColors.Window;
            this.ICD9cb.FormattingEnabled = true;
            this.ICD9cb.Location = new System.Drawing.Point(1372, 273);
            this.ICD9cb.Margin = new System.Windows.Forms.Padding(6);
            this.ICD9cb.MaxDropDownItems = 30;
            this.ICD9cb.Name = "ICD9cb";
            this.ICD9cb.Size = new System.Drawing.Size(252, 33);
            this.ICD9cb.TabIndex = 68;
            this.ICD9cb.Text = "Diagnosis";
            // 
            // epicloginnamepb
            // 
            this.epicloginnamepb.Image = ((System.Drawing.Image)(resources.GetObject("epicloginnamepb.Image")));
            this.epicloginnamepb.Location = new System.Drawing.Point(1042, 27);
            this.epicloginnamepb.Margin = new System.Windows.Forms.Padding(6);
            this.epicloginnamepb.Name = "epicloginnamepb";
            this.epicloginnamepb.Size = new System.Drawing.Size(104, 40);
            this.epicloginnamepb.TabIndex = 69;
            this.epicloginnamepb.TabStop = false;
            this.epicloginnamepb.Visible = false;
            // 
            // screenpb
            // 
            this.screenpb.Location = new System.Drawing.Point(1042, 77);
            this.screenpb.Margin = new System.Windows.Forms.Padding(6);
            this.screenpb.Name = "screenpb";
            this.screenpb.Size = new System.Drawing.Size(104, 40);
            this.screenpb.TabIndex = 70;
            this.screenpb.TabStop = false;
            this.screenpb.Visible = false;
            // 
            // rightsmalltrigger
            // 
            this.rightsmalltrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightsmalltrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightsmalltrigger.Location = new System.Drawing.Point(1746, 181);
            this.rightsmalltrigger.Margin = new System.Windows.Forms.Padding(6);
            this.rightsmalltrigger.Name = "rightsmalltrigger";
            this.rightsmalltrigger.Size = new System.Drawing.Size(26, 40);
            this.rightsmalltrigger.TabIndex = 74;
            this.rightsmalltrigger.Text = "T";
            this.rightsmalltrigger.UseVisualStyleBackColor = false;
            this.rightsmalltrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // leftringtrigger
            // 
            this.leftringtrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftringtrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftringtrigger.Location = new System.Drawing.Point(1510, 181);
            this.leftringtrigger.Margin = new System.Windows.Forms.Padding(6);
            this.leftringtrigger.Name = "leftringtrigger";
            this.leftringtrigger.Size = new System.Drawing.Size(26, 40);
            this.leftringtrigger.TabIndex = 76;
            this.leftringtrigger.Text = "T";
            this.leftringtrigger.UseVisualStyleBackColor = false;
            this.leftringtrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // leftsmalltrigger
            // 
            this.leftsmalltrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftsmalltrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftsmalltrigger.Location = new System.Drawing.Point(1570, 181);
            this.leftsmalltrigger.Margin = new System.Windows.Forms.Padding(6);
            this.leftsmalltrigger.Name = "leftsmalltrigger";
            this.leftsmalltrigger.Size = new System.Drawing.Size(26, 40);
            this.leftsmalltrigger.TabIndex = 77;
            this.leftsmalltrigger.Text = "T";
            this.leftsmalltrigger.UseVisualStyleBackColor = false;
            this.leftsmalltrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // rightindextrigger
            // 
            this.rightindextrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightindextrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightindextrigger.Location = new System.Drawing.Point(1880, 252);
            this.rightindextrigger.Margin = new System.Windows.Forms.Padding(6);
            this.rightindextrigger.Name = "rightindextrigger";
            this.rightindextrigger.Size = new System.Drawing.Size(26, 40);
            this.rightindextrigger.TabIndex = 78;
            this.rightindextrigger.Text = "T";
            this.rightindextrigger.UseVisualStyleBackColor = false;
            this.rightindextrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // rightlongtrigger
            // 
            this.rightlongtrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightlongtrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightlongtrigger.Location = new System.Drawing.Point(1848, 210);
            this.rightlongtrigger.Margin = new System.Windows.Forms.Padding(6);
            this.rightlongtrigger.Name = "rightlongtrigger";
            this.rightlongtrigger.Size = new System.Drawing.Size(26, 40);
            this.rightlongtrigger.TabIndex = 79;
            this.rightlongtrigger.Text = "T";
            this.rightlongtrigger.UseVisualStyleBackColor = false;
            this.rightlongtrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // rightringtrigger
            // 
            this.rightringtrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightringtrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightringtrigger.Location = new System.Drawing.Point(1800, 181);
            this.rightringtrigger.Margin = new System.Windows.Forms.Padding(6);
            this.rightringtrigger.Name = "rightringtrigger";
            this.rightringtrigger.Size = new System.Drawing.Size(26, 40);
            this.rightringtrigger.TabIndex = 80;
            this.rightringtrigger.Text = "T";
            this.rightringtrigger.UseVisualStyleBackColor = false;
            this.rightringtrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // leftlongtrigger
            // 
            this.leftlongtrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftlongtrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftlongtrigger.Location = new System.Drawing.Point(1458, 210);
            this.leftlongtrigger.Margin = new System.Windows.Forms.Padding(6);
            this.leftlongtrigger.Name = "leftlongtrigger";
            this.leftlongtrigger.Size = new System.Drawing.Size(26, 40);
            this.leftlongtrigger.TabIndex = 81;
            this.leftlongtrigger.Text = "T";
            this.leftlongtrigger.UseVisualStyleBackColor = false;
            this.leftlongtrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // leftindextrigger
            // 
            this.leftindextrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftindextrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftindextrigger.Location = new System.Drawing.Point(1430, 252);
            this.leftindextrigger.Margin = new System.Windows.Forms.Padding(6);
            this.leftindextrigger.Name = "leftindextrigger";
            this.leftindextrigger.Size = new System.Drawing.Size(26, 40);
            this.leftindextrigger.TabIndex = 82;
            this.leftindextrigger.Text = "T";
            this.leftindextrigger.UseVisualStyleBackColor = false;
            this.leftindextrigger.Click += new System.EventHandler(this.leftthumbtrigger_Click);
            this.leftindextrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // rightthumbtrigger
            // 
            this.rightthumbtrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightthumbtrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightthumbtrigger.Location = new System.Drawing.Point(1822, 373);
            this.rightthumbtrigger.Margin = new System.Windows.Forms.Padding(6);
            this.rightthumbtrigger.Name = "rightthumbtrigger";
            this.rightthumbtrigger.Size = new System.Drawing.Size(26, 40);
            this.rightthumbtrigger.TabIndex = 83;
            this.rightthumbtrigger.Text = "T";
            this.rightthumbtrigger.UseVisualStyleBackColor = false;
            this.rightthumbtrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // leftthumbtrigger
            // 
            this.leftthumbtrigger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftthumbtrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftthumbtrigger.Location = new System.Drawing.Point(1496, 373);
            this.leftthumbtrigger.Margin = new System.Windows.Forms.Padding(6);
            this.leftthumbtrigger.Name = "leftthumbtrigger";
            this.leftthumbtrigger.Size = new System.Drawing.Size(26, 40);
            this.leftthumbtrigger.TabIndex = 84;
            this.leftthumbtrigger.Text = "T";
            this.leftthumbtrigger.UseVisualStyleBackColor = false;
            this.leftthumbtrigger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // leftbasal
            // 
            this.leftbasal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leftbasal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftbasal.Location = new System.Drawing.Point(1560, 392);
            this.leftbasal.Margin = new System.Windows.Forms.Padding(6);
            this.leftbasal.Name = "leftbasal";
            this.leftbasal.Size = new System.Drawing.Size(26, 40);
            this.leftbasal.TabIndex = 85;
            this.leftbasal.Text = "B";
            this.leftbasal.UseVisualStyleBackColor = false;
            this.leftbasal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftbasal_MouseUp);
            // 
            // rightbasal
            // 
            this.rightbasal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rightbasal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightbasal.Location = new System.Drawing.Point(1764, 392);
            this.rightbasal.Margin = new System.Windows.Forms.Padding(6);
            this.rightbasal.Name = "rightbasal";
            this.rightbasal.Size = new System.Drawing.Size(26, 40);
            this.rightbasal.TabIndex = 86;
            this.rightbasal.Text = "B";
            this.rightbasal.UseVisualStyleBackColor = false;
            this.rightbasal.Click += new System.EventHandler(this.button12_Click);
            this.rightbasal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button12_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1770, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 87;
            this.label1.Text = "RIGHT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.916231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1490, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 88;
            this.label2.Text = "LEFT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 587);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 89;
            this.button1.Text = "XRAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(142, 615);
            this.button13.Margin = new System.Windows.Forms.Padding(6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 40);
            this.button13.TabIndex = 90;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.helpToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(61, 39);
            this.toolStrip1.TabIndex = 91;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Visible = false;
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpToolStripButton.Text = "XR&AY";
            this.helpToolStripButton.Visible = false;
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Visible = false;
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Log In";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // rBPlan
            // 
            this.rBPlan.AutoSize = true;
            this.rBPlan.Location = new System.Drawing.Point(1142, 181);
            this.rBPlan.Margin = new System.Windows.Forms.Padding(2);
            this.rBPlan.Name = "rBPlan";
            this.rBPlan.Size = new System.Drawing.Size(86, 29);
            this.rBPlan.TabIndex = 92;
            this.rBPlan.Text = "Plan";
            this.rBPlan.UseVisualStyleBackColor = true;
            // 
            // rBExam
            // 
            this.rBExam.AutoSize = true;
            this.rBExam.Location = new System.Drawing.Point(1042, 181);
            this.rBExam.Margin = new System.Windows.Forms.Padding(2);
            this.rBExam.Name = "rBExam";
            this.rBExam.Size = new System.Drawing.Size(97, 29);
            this.rBExam.TabIndex = 93;
            this.rBExam.Text = "Exam";
            this.rBExam.UseVisualStyleBackColor = true;
            // 
            // rBHistory
            // 
            this.rBHistory.AutoSize = true;
            this.rBHistory.Location = new System.Drawing.Point(930, 181);
            this.rBHistory.Margin = new System.Windows.Forms.Padding(2);
            this.rBHistory.Name = "rBHistory";
            this.rBHistory.Size = new System.Drawing.Size(110, 29);
            this.rBHistory.TabIndex = 94;
            this.rBHistory.Text = "History";
            this.rBHistory.UseVisualStyleBackColor = true;
            // 
            // rBAll
            // 
            this.rBAll.AutoSize = true;
            this.rBAll.Location = new System.Drawing.Point(1228, 181);
            this.rBAll.Margin = new System.Windows.Forms.Padding(2);
            this.rBAll.Name = "rBAll";
            this.rBAll.Size = new System.Drawing.Size(67, 29);
            this.rBAll.TabIndex = 95;
            this.rBAll.Text = "All";
            this.rBAll.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(608, 473);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Maximum = 4;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(82, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 96;
            this.progressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1318, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 400);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 97;
            this.button2.Text = "MAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FURB
            // 
            this.FURB.AutoSize = true;
            this.FURB.Checked = true;
            this.FURB.Location = new System.Drawing.Point(358, 188);
            this.FURB.Margin = new System.Windows.Forms.Padding(2);
            this.FURB.Name = "FURB";
            this.FURB.Size = new System.Drawing.Size(71, 29);
            this.FURB.TabIndex = 99;
            this.FURB.TabStop = true;
            this.FURB.Text = "FU";
            this.FURB.UseVisualStyleBackColor = true;
            this.FURB.CheckedChanged += new System.EventHandler(this.FURB_CheckedChanged);
            // 
            // PostOPRB
            // 
            this.PostOPRB.AutoSize = true;
            this.PostOPRB.Location = new System.Drawing.Point(358, 235);
            this.PostOPRB.Margin = new System.Windows.Forms.Padding(2);
            this.PostOPRB.Name = "PostOPRB";
            this.PostOPRB.Size = new System.Drawing.Size(116, 29);
            this.PostOPRB.TabIndex = 100;
            this.PostOPRB.Text = "PostOP";
            this.PostOPRB.UseVisualStyleBackColor = true;
            this.PostOPRB.CheckedChanged += new System.EventHandler(this.PostOPRB_CheckedChanged);
            // 
            // NewRB
            // 
            this.NewRB.AutoSize = true;
            this.NewRB.Location = new System.Drawing.Point(358, 269);
            this.NewRB.Margin = new System.Windows.Forms.Padding(2);
            this.NewRB.Name = "NewRB";
            this.NewRB.Size = new System.Drawing.Size(85, 29);
            this.NewRB.TabIndex = 101;
            this.NewRB.Text = "New";
            this.NewRB.UseVisualStyleBackColor = true;
            this.NewRB.CheckedChanged += new System.EventHandler(this.NewRB_CheckedChanged);
            // 
            // epicmitten
            // 
            this.epicmitten.Image = ((System.Drawing.Image)(resources.GetObject("epicmitten.Image")));
            this.epicmitten.Location = new System.Drawing.Point(710, 269);
            this.epicmitten.Margin = new System.Windows.Forms.Padding(6);
            this.epicmitten.Name = "epicmitten";
            this.epicmitten.Size = new System.Drawing.Size(104, 40);
            this.epicmitten.TabIndex = 107;
            this.epicmitten.TabStop = false;
            this.epicmitten.Visible = false;
            // 
            // cBNote
            // 
            this.cBNote.AutoSize = true;
            this.cBNote.Checked = true;
            this.cBNote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBNote.Location = new System.Drawing.Point(373, 155);
            this.cBNote.Margin = new System.Windows.Forms.Padding(2);
            this.cBNote.Name = "cBNote";
            this.cBNote.Size = new System.Drawing.Size(86, 29);
            this.cBNote.TabIndex = 98;
            this.cBNote.Text = "note";
            this.cBNote.UseVisualStyleBackColor = true;
            this.cBNote.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 102;
            this.label3.Text = "New";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 103;
            this.label4.Text = "PostOP";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "FU";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 105;
            this.label6.Text = "Nurse";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.TabIndex = 106;
            this.label7.Text = "PA";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // URMFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(162, 130);
            this.ControlBox = false;
            this.Controls.Add(this.epicmitten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewRB);
            this.Controls.Add(this.PostOPRB);
            this.Controls.Add(this.FURB);
            this.Controls.Add(this.cBNote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rBAll);
            this.Controls.Add(this.rBHistory);
            this.Controls.Add(this.rBExam);
            this.Controls.Add(this.rBPlan);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightbasal);
            this.Controls.Add(this.leftbasal);
            this.Controls.Add(this.leftthumbtrigger);
            this.Controls.Add(this.rightthumbtrigger);
            this.Controls.Add(this.leftindextrigger);
            this.Controls.Add(this.leftlongtrigger);
            this.Controls.Add(this.rightringtrigger);
            this.Controls.Add(this.rightlongtrigger);
            this.Controls.Add(this.rightindextrigger);
            this.Controls.Add(this.leftsmalltrigger);
            this.Controls.Add(this.leftringtrigger);
            this.Controls.Add(this.rightsmalltrigger);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.screenpb);
            this.Controls.Add(this.epicloginnamepb);
            this.Controls.Add(this.ICD9cb);
            this.Controls.Add(this.loscb);
            this.Controls.Add(this.LogOnBTN);
            this.Controls.Add(this.CopyBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1400, 850);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "URMFG";
            this.Opacity = 0.75D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "URMFG";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epicloginnamepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenpb)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epicmitten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.Button LogOnBTN;
        private System.Windows.Forms.ComboBox loscb;
        private System.Windows.Forms.ComboBox ICD9cb;
        private System.Windows.Forms.PictureBox epicloginnamepb;
        private System.Windows.Forms.PictureBox screenpb;
        private System.Windows.Forms.Button rightsmalltrigger;
        private System.Windows.Forms.Button leftringtrigger;
        private System.Windows.Forms.Button leftsmalltrigger;
        private System.Windows.Forms.Button rightindextrigger;
        private System.Windows.Forms.Button rightlongtrigger;
        private System.Windows.Forms.Button rightringtrigger;
        private System.Windows.Forms.Button leftlongtrigger;
        private System.Windows.Forms.Button leftindextrigger;
        private System.Windows.Forms.Button rightthumbtrigger;
        private System.Windows.Forms.Button leftthumbtrigger;
        private System.Windows.Forms.Button leftbasal;
        private System.Windows.Forms.Button rightbasal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RadioButton rBPlan;
        private System.Windows.Forms.RadioButton rBExam;
        private System.Windows.Forms.RadioButton rBHistory;
        private System.Windows.Forms.RadioButton rBAll;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton FURB;
        private System.Windows.Forms.RadioButton PostOPRB;
        private System.Windows.Forms.RadioButton NewRB;
        private System.Windows.Forms.PictureBox epicmitten;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.CheckBox cBNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

