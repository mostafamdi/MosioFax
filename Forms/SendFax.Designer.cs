namespace MSIOFAX_Send.Forms
{
    partial class SendFax
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listBoxServerMessage = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileNamelabel = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.FaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.RefreshListModemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Waitlabel = new System.Windows.Forms.Label();
            this.ModemListComboBox = new System.Windows.Forms.ComboBox();
            this.SendFaxButton = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSendStatus = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.RootUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RootPasswordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.FaxUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FaxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpdateModemNameBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.errorProviderUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPort = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderServerIP = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorkerCheckConnect = new System.ComponentModel.BackgroundWorker();
            this.timerCheckConnect = new System.Windows.Forms.Timer(this.components);
            this.buttonDoConnect = new System.Windows.Forms.Button();
            this.backgroundWorkerInitialiseObjFax = new System.ComponentModel.BackgroundWorker();
            this.timerSendStatus = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerSendSatus = new System.ComponentModel.BackgroundWorker();
            this.textBoxJobID = new System.Windows.Forms.TextBox();
            this.timerGetResultSend = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerModemStatus = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStatusModems = new System.Windows.Forms.DataGridView();
            this.timertset = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkertest = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSendFax = new System.ComponentModel.BackgroundWorker();
            this.buttonGetStatusModem = new System.Windows.Forms.Button();
            this.buttonRealTimeStatus = new System.Windows.Forms.Button();
            this.backgroundWorkerGetStatusModem = new System.ComponentModel.BackgroundWorker();
            this.timerStatusModemRealTime = new System.Windows.Forms.Timer(this.components);
            this.buttonStopModemStatusRealTime = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timerFadeLabel = new System.Windows.Forms.Timer(this.components);
            this.SendFaxBtn = new System.Windows.Forms.Button();
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SendFaxBtn2 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label53 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LoadingModempictureBox = new System.Windows.Forms.PictureBox();
            this.pictureSendLoading = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderServerIP)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusModems)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingModempictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSendLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(435, 115);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 467);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.labelLoading);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBoxLoading);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(357, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ارسال فکس";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listBoxServerMessage);
            this.groupBox9.Location = new System.Drawing.Point(14, 348);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(310, 66);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "پیام های سرور";
            // 
            // listBoxServerMessage
            // 
            this.listBoxServerMessage.FormattingEnabled = true;
            this.listBoxServerMessage.Location = new System.Drawing.Point(34, 20);
            this.listBoxServerMessage.Name = "listBoxServerMessage";
            this.listBoxServerMessage.Size = new System.Drawing.Size(240, 30);
            this.listBoxServerMessage.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox12);
            this.groupBox5.Controls.Add(this.groupBox11);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.pictureSendLoading);
            this.groupBox5.Controls.Add(this.SendFaxButton);
            this.groupBox5.Location = new System.Drawing.Point(18, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 323);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.SelectFileButton);
            this.groupBox12.Controls.Add(this.FileNamelabel);
            this.groupBox12.Location = new System.Drawing.Point(9, 150);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(297, 80);
            this.groupBox12.TabIndex = 27;
            this.groupBox12.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(215, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "نام فایل:";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.ForeColor = System.Drawing.Color.Purple;
            this.SelectFileButton.Location = new System.Drawing.Point(12, 49);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(71, 26);
            this.SelectFileButton.TabIndex = 12;
            this.SelectFileButton.Text = "انتخاب فایل";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileNamelabel
            // 
            this.FileNamelabel.AutoSize = true;
            this.FileNamelabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.FileNamelabel.Location = new System.Drawing.Point(24, 25);
            this.FileNamelabel.Name = "FileNamelabel";
            this.FileNamelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileNamelabel.Size = new System.Drawing.Size(31, 13);
            this.FileNamelabel.TabIndex = 9;
            this.FileNamelabel.Text = "......";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.FaxNumberTextBox);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Location = new System.Drawing.Point(6, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(300, 47);
            this.groupBox11.TabIndex = 26;
            this.groupBox11.TabStop = false;
            // 
            // FaxNumberTextBox
            // 
            this.FaxNumberTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaxNumberTextBox.Location = new System.Drawing.Point(6, 14);
            this.FaxNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.FaxNumberTextBox.Name = "FaxNumberTextBox";
            this.FaxNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FaxNumberTextBox.Size = new System.Drawing.Size(187, 23);
            this.FaxNumberTextBox.TabIndex = 6;
            this.FaxNumberTextBox.Text = "901";
            this.FaxNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FaxNumberTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumPurple;
            this.label9.Location = new System.Drawing.Point(193, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "شماره فکس مقصد";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.RefreshListModemLinkLabel);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.LoadingModempictureBox);
            this.groupBox10.Controls.Add(this.Waitlabel);
            this.groupBox10.Controls.Add(this.ModemListComboBox);
            this.groupBox10.Location = new System.Drawing.Point(7, 73);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(299, 71);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "انتخاب مودم";
            // 
            // RefreshListModemLinkLabel
            // 
            this.RefreshListModemLinkLabel.AutoSize = true;
            this.RefreshListModemLinkLabel.Location = new System.Drawing.Point(24, 27);
            this.RefreshListModemLinkLabel.Name = "RefreshListModemLinkLabel";
            this.RefreshListModemLinkLabel.Size = new System.Drawing.Size(112, 13);
            this.RefreshListModemLinkLabel.TabIndex = 15;
            this.RefreshListModemLinkLabel.TabStop = true;
            this.RefreshListModemLinkLabel.Text = "بروزرسانی نام مودم ها";
            this.RefreshListModemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RefreshListModemLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(217, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام مودم:";
            // 
            // Waitlabel
            // 
            this.Waitlabel.AutoSize = true;
            this.Waitlabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Waitlabel.Location = new System.Drawing.Point(103, 52);
            this.Waitlabel.Name = "Waitlabel";
            this.Waitlabel.Size = new System.Drawing.Size(108, 13);
            this.Waitlabel.TabIndex = 18;
            this.Waitlabel.Text = "لطفا کمی صبر کنید...";
            this.Waitlabel.Visible = false;
            this.Waitlabel.Click += new System.EventHandler(this.Waitlabel_Click);
            // 
            // ModemListComboBox
            // 
            this.ModemListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModemListComboBox.ForeColor = System.Drawing.Color.Purple;
            this.ModemListComboBox.FormattingEnabled = true;
            this.ModemListComboBox.Location = new System.Drawing.Point(142, 22);
            this.ModemListComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModemListComboBox.Name = "ModemListComboBox";
            this.ModemListComboBox.Size = new System.Drawing.Size(69, 21);
            this.ModemListComboBox.TabIndex = 14;
            // 
            // SendFaxButton
            // 
            this.SendFaxButton.ForeColor = System.Drawing.Color.Purple;
            this.SendFaxButton.Location = new System.Drawing.Point(11, 235);
            this.SendFaxButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendFaxButton.Name = "SendFaxButton";
            this.SendFaxButton.Size = new System.Drawing.Size(270, 24);
            this.SendFaxButton.TabIndex = 13;
            this.SendFaxButton.Text = "ارسال فکس";
            this.SendFaxButton.UseVisualStyleBackColor = true;
            this.SendFaxButton.Click += new System.EventHandler(this.SendFaxButton_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLoading.Location = new System.Drawing.Point(88, 5);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(108, 13);
            this.labelLoading.TabIndex = 18;
            this.labelLoading.Text = "لطفا کمی صبر کنید...";
            this.labelLoading.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(514, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 55);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مودم ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(514, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 52);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب فایل";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.labelSendStatus);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(467, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 35);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پیام های سرور";
            // 
            // labelSendStatus
            // 
            this.labelSendStatus.AutoSize = true;
            this.labelSendStatus.Location = new System.Drawing.Point(194, 19);
            this.labelSendStatus.Name = "labelSendStatus";
            this.labelSendStatus.Size = new System.Drawing.Size(35, 13);
            this.labelSendStatus.TabIndex = 0;
            this.labelSendStatus.Text = "label9";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Get Modem Status";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.AccessibleName = "SendLoadingGif";
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(6, 413);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(403, 24);
            this.button5.TabIndex = 13;
            this.button5.Text = "ارسال فکس";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.SendFaxButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.SaveButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(357, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تنظیمات برنامه";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.RootUserNameTextBox);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.RootPasswordTextBox);
            this.groupBox8.Location = new System.Drawing.Point(36, 178);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(282, 82);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "تنظیمات مانیتور مودم ها";
            // 
            // RootUserNameTextBox
            // 
            this.RootUserNameTextBox.Location = new System.Drawing.Point(22, 21);
            this.RootUserNameTextBox.Name = "RootUserNameTextBox";
            this.RootUserNameTextBox.Size = new System.Drawing.Size(161, 21);
            this.RootUserNameTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label3.Location = new System.Drawing.Point(189, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "کلمه عبور سرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label2.Location = new System.Drawing.Point(189, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام کاربری سرور";
            // 
            // RootPasswordTextBox
            // 
            this.RootPasswordTextBox.Location = new System.Drawing.Point(22, 48);
            this.RootPasswordTextBox.Name = "RootPasswordTextBox";
            this.RootPasswordTextBox.PasswordChar = '*';
            this.RootPasswordTextBox.Size = new System.Drawing.Size(161, 21);
            this.RootPasswordTextBox.TabIndex = 13;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.FaxUsernameTextBox);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.FaxPasswordTextBox);
            this.groupBox7.Location = new System.Drawing.Point(36, 88);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(282, 84);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "تنظیمات فکس";
            // 
            // FaxUsernameTextBox
            // 
            this.FaxUsernameTextBox.Location = new System.Drawing.Point(23, 20);
            this.FaxUsernameTextBox.Name = "FaxUsernameTextBox";
            this.FaxUsernameTextBox.Size = new System.Drawing.Size(161, 21);
            this.FaxUsernameTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label7.Location = new System.Drawing.Point(190, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "نام کاربری فکس";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label8.Location = new System.Drawing.Point(190, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "کلمه عبور فکس";
            // 
            // FaxPasswordTextBox
            // 
            this.FaxPasswordTextBox.Location = new System.Drawing.Point(23, 47);
            this.FaxPasswordTextBox.Name = "FaxPasswordTextBox";
            this.FaxPasswordTextBox.PasswordChar = '*';
            this.FaxPasswordTextBox.Size = new System.Drawing.Size(161, 21);
            this.FaxPasswordTextBox.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ServerIPTextBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.PortTextBox);
            this.groupBox6.Location = new System.Drawing.Point(37, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 77);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "تنظیمات عمومی";
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(22, 18);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(161, 21);
            this.ServerIPTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label4.Location = new System.Drawing.Point(204, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "آی پی سرور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label6.Location = new System.Drawing.Point(204, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "پورت";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(22, 48);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(161, 21);
            this.PortTextBox.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(37, 266);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(281, 26);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "ذخیره";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(357, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "راه نمایی";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(357, 441);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "درباره ما";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "وضعیت ارتباط با سرور";
            // 
            // UpdateModemNameBackgroundWorker
            // 
            this.UpdateModemNameBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateModemNameBackgroundWorker_DoWork);
            this.UpdateModemNameBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.UpdateModemNameBackgroundWorker_ProgressChanged);
            this.UpdateModemNameBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UpdateModemNameBackgroundWorker_RunWorkerCompleted);
            // 
            // errorProviderUserName
            // 
            this.errorProviderUserName.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderPort
            // 
            this.errorProviderPort.ContainerControl = this;
            // 
            // errorProviderServerIP
            // 
            this.errorProviderServerIP.ContainerControl = this;
            // 
            // backgroundWorkerCheckConnect
            // 
            this.backgroundWorkerCheckConnect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCheckConnect_DoWork);
            // 
            // timerCheckConnect
            // 
            this.timerCheckConnect.Interval = 5000;
            this.timerCheckConnect.Tick += new System.EventHandler(this.timerCheckConnect_Tick);
            // 
            // buttonDoConnect
            // 
            this.buttonDoConnect.Location = new System.Drawing.Point(13, 370);
            this.buttonDoConnect.Name = "buttonDoConnect";
            this.buttonDoConnect.Size = new System.Drawing.Size(279, 29);
            this.buttonDoConnect.TabIndex = 3;
            this.buttonDoConnect.Text = "برقراری ارتباط با سرور";
            this.buttonDoConnect.UseVisualStyleBackColor = true;
            this.buttonDoConnect.Click += new System.EventHandler(this.buttonDoConnect_Click);
            // 
            // backgroundWorkerInitialiseObjFax
            // 
            this.backgroundWorkerInitialiseObjFax.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInitialiseObjFax_DoWork);
            this.backgroundWorkerInitialiseObjFax.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerInitialiseObjFax_ProgressChanged);
            this.backgroundWorkerInitialiseObjFax.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInitialiseObjFax_RunWorkerCompleted);
            // 
            // timerSendStatus
            // 
            this.timerSendStatus.Interval = 5000;
            this.timerSendStatus.Tick += new System.EventHandler(this.timerSendStatus_Tick);
            // 
            // backgroundWorkerSendSatus
            // 
            this.backgroundWorkerSendSatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSendSatus_DoWork);
            // 
            // textBoxJobID
            // 
            this.textBoxJobID.Location = new System.Drawing.Point(456, 462);
            this.textBoxJobID.Name = "textBoxJobID";
            this.textBoxJobID.Size = new System.Drawing.Size(69, 21);
            this.textBoxJobID.TabIndex = 4;
            this.textBoxJobID.Visible = false;
            // 
            // timerGetResultSend
            // 
            this.timerGetResultSend.Interval = 5000;
            this.timerGetResultSend.Tick += new System.EventHandler(this.timerGetResultSend_Tick);
            // 
            // backgroundWorkerModemStatus
            // 
            this.backgroundWorkerModemStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerModemStatus_DoWork);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewStatusModems);
            this.groupBox3.Location = new System.Drawing.Point(12, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 237);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست وضعیت مودم ها";
            // 
            // dataGridViewStatusModems
            // 
            this.dataGridViewStatusModems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatusModems.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewStatusModems.Name = "dataGridViewStatusModems";
            this.dataGridViewStatusModems.Size = new System.Drawing.Size(268, 204);
            this.dataGridViewStatusModems.TabIndex = 0;
            // 
            // timertset
            // 
            this.timertset.Interval = 3000;
            this.timertset.Tick += new System.EventHandler(this.timertset_Tick);
            // 
            // backgroundWorkertest
            // 
            this.backgroundWorkertest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkertest_DoWork);
            // 
            // backgroundWorkerSendFax
            // 
            this.backgroundWorkerSendFax.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSendFax_DoWork);
            // 
            // buttonGetStatusModem
            // 
            this.buttonGetStatusModem.Location = new System.Drawing.Point(157, 308);
            this.buttonGetStatusModem.Name = "buttonGetStatusModem";
            this.buttonGetStatusModem.Size = new System.Drawing.Size(135, 26);
            this.buttonGetStatusModem.TabIndex = 23;
            this.buttonGetStatusModem.Text = "مشاهده وضعیت مودم ها";
            this.buttonGetStatusModem.UseVisualStyleBackColor = true;
            this.buttonGetStatusModem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonRealTimeStatus
            // 
            this.buttonRealTimeStatus.Location = new System.Drawing.Point(12, 308);
            this.buttonRealTimeStatus.Name = "buttonRealTimeStatus";
            this.buttonRealTimeStatus.Size = new System.Drawing.Size(146, 26);
            this.buttonRealTimeStatus.TabIndex = 24;
            this.buttonRealTimeStatus.Text = "مشاهده لحظه ای مودم ها";
            this.buttonRealTimeStatus.UseVisualStyleBackColor = true;
            this.buttonRealTimeStatus.Click += new System.EventHandler(this.buttonRealTimeStatus_Click);
            // 
            // backgroundWorkerGetStatusModem
            // 
            this.backgroundWorkerGetStatusModem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetStatusModem_DoWork);
            // 
            // timerStatusModemRealTime
            // 
            this.timerStatusModemRealTime.Interval = 5000;
            this.timerStatusModemRealTime.Tick += new System.EventHandler(this.timerStatusModemRealTime_Tick);
            // 
            // buttonStopModemStatusRealTime
            // 
            this.buttonStopModemStatusRealTime.Enabled = false;
            this.buttonStopModemStatusRealTime.Location = new System.Drawing.Point(12, 336);
            this.buttonStopModemStatusRealTime.Name = "buttonStopModemStatusRealTime";
            this.buttonStopModemStatusRealTime.Size = new System.Drawing.Size(280, 29);
            this.buttonStopModemStatusRealTime.TabIndex = 25;
            this.buttonStopModemStatusRealTime.Text = "توقف مانیتور لحظه ای مودم ها";
            this.buttonStopModemStatusRealTime.UseVisualStyleBackColor = true;
            this.buttonStopModemStatusRealTime.Click += new System.EventHandler(this.buttonStopModemStatusRealTime_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(298, 34);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(86, 29);
            this.ExitButton.TabIndex = 26;
            this.ExitButton.Text = "خروج";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // timerFadeLabel
            // 
            this.timerFadeLabel.Interval = 5000;
            this.timerFadeLabel.Tick += new System.EventHandler(this.timerFadeLabel_Tick);
            // 
            // SendFaxBtn
            // 
            this.SendFaxBtn.Location = new System.Drawing.Point(435, 433);
            this.SendFaxBtn.Name = "SendFaxBtn";
            this.SendFaxBtn.Size = new System.Drawing.Size(122, 23);
            this.SendFaxBtn.TabIndex = 27;
            this.SendFaxBtn.Text = "Send";
            this.SendFaxBtn.UseVisualStyleBackColor = true;
            this.SendFaxBtn.Click += new System.EventHandler(this.SendFaxBtn_Click);
            // 
            // fromTxt
            // 
            this.fromTxt.Location = new System.Drawing.Point(447, 375);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(100, 21);
            this.fromTxt.TabIndex = 28;
            this.fromTxt.TextChanged += new System.EventHandler(this.fromTxt_TextChanged);
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(447, 402);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(100, 21);
            this.toTxt.TabIndex = 29;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl2.Location = new System.Drawing.Point(920, 21);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(404, 360);
            this.tabControl2.TabIndex = 30;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.SendFaxBtn2);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(396, 326);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Send";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(10, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "Select File";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "......";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(39, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "File:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(161, 29);
            this.textBox2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(188, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Destination Fax Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(113, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(139, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fax Device to use:";
            // 
            // SendFaxBtn2
            // 
            this.SendFaxBtn2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SendFaxBtn2.ForeColor = System.Drawing.Color.Indigo;
            this.SendFaxBtn2.Location = new System.Drawing.Point(10, 180);
            this.SendFaxBtn2.Name = "SendFaxBtn2";
            this.SendFaxBtn2.Size = new System.Drawing.Size(366, 30);
            this.SendFaxBtn2.TabIndex = 0;
            this.SendFaxBtn2.Text = "Send";
            this.SendFaxBtn2.UseVisualStyleBackColor = true;
            this.SendFaxBtn2.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.textBox5);
            this.tabPage6.Controls.Add(this.textBox4);
            this.tabPage6.Controls.Add(this.textBox3);
            this.tabPage6.Controls.Add(this.SaveBtn);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(396, 326);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 21);
            this.label16.TabIndex = 4;
            this.label16.Text = "Hylafax Pass:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "HylaFax Username:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "ServerIP:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(209, 29);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 29);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 29);
            this.textBox3.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(25, 143);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(359, 29);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(396, 326);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "About";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(298, 510);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(251, 21);
            this.textBox6.TabIndex = 32;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(89, 457);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 143);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label53);
            this.flowLayoutPanel1.Controls.Add(this.label17);
            this.flowLayoutPanel1.Controls.Add(this.label18);
            this.flowLayoutPanel1.Controls.Add(this.label19);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(920, 387);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 93);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.SandyBrown;
            this.label53.Location = new System.Drawing.Point(335, 5);
            this.label53.Margin = new System.Windows.Forms.Padding(5);
            this.label53.Name = "label53";
            this.label53.Padding = new System.Windows.Forms.Padding(10);
            this.label53.Size = new System.Drawing.Size(60, 35);
            this.label53.TabIndex = 71;
            this.label53.Text = "label53";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.SandyBrown;
            this.label17.Location = new System.Drawing.Point(266, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(5);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(10);
            this.label17.Size = new System.Drawing.Size(59, 35);
            this.label17.TabIndex = 72;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.SandyBrown;
            this.label18.Location = new System.Drawing.Point(197, 5);
            this.label18.Margin = new System.Windows.Forms.Padding(5);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(10);
            this.label18.Size = new System.Drawing.Size(59, 35);
            this.label18.TabIndex = 73;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.SandyBrown;
            this.label19.Location = new System.Drawing.Point(63, 5);
            this.label19.Margin = new System.Windows.Forms.Padding(5);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(10);
            this.label19.Size = new System.Drawing.Size(124, 35);
            this.label19.TabIndex = 74;
            this.label19.Text = "tty 900, seding a fax";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(149, 381);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(126, 21);
            this.label20.TabIndex = 8;
            this.label20.Text = "List Of Modems";
            // 
            // LoadingModempictureBox
            // 
            this.LoadingModempictureBox.Image = global::MSIOFAX_Send.Properties.Resources.loading2;
            this.LoadingModempictureBox.Location = new System.Drawing.Point(32, 57);
            this.LoadingModempictureBox.Name = "LoadingModempictureBox";
            this.LoadingModempictureBox.Size = new System.Drawing.Size(64, 8);
            this.LoadingModempictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoadingModempictureBox.TabIndex = 4;
            this.LoadingModempictureBox.TabStop = false;
            this.LoadingModempictureBox.Visible = false;
            // 
            // pictureSendLoading
            // 
            this.pictureSendLoading.Image = global::MSIOFAX_Send.Properties.Resources.loading2;
            this.pictureSendLoading.Location = new System.Drawing.Point(21, 272);
            this.pictureSendLoading.Name = "pictureSendLoading";
            this.pictureSendLoading.Size = new System.Drawing.Size(64, 8);
            this.pictureSendLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureSendLoading.TabIndex = 24;
            this.pictureSendLoading.TabStop = false;
            this.pictureSendLoading.Visible = false;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::MSIOFAX_Send.Properties.Resources.loading2;
            this.pictureBoxLoading.Location = new System.Drawing.Point(18, 5);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(64, 8);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLoading.TabIndex = 4;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // SendFax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1362, 646);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.toTxt);
            this.Controls.Add(this.fromTxt);
            this.Controls.Add(this.SendFaxBtn);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.buttonStopModemStatusRealTime);
            this.Controls.Add(this.buttonRealTimeStatus);
            this.Controls.Add(this.buttonGetStatusModem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxJobID);
            this.Controls.Add(this.buttonDoConnect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SendFax";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MosioFAX";
            this.Load += new System.EventHandler(this.SendFax_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderServerIP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusModems)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingModempictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSendLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox ModemListComboBox;
        private System.Windows.Forms.LinkLabel RefreshListModemLinkLabel;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FileNamelabel;
        private System.Windows.Forms.TextBox FaxNumberTextBox;
        private System.Windows.Forms.Button SendFaxButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FaxPasswordTextBox;
        private System.Windows.Forms.TextBox FaxUsernameTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveButton;
        private System.ComponentModel.BackgroundWorker UpdateModemNameBackgroundWorker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProviderUserName;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderPort;
        private System.Windows.Forms.ErrorProvider errorProviderServerIP;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCheckConnect;
        private System.Windows.Forms.Timer timerCheckConnect;
        private System.Windows.Forms.Button buttonDoConnect;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInitialiseObjFax;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSendStatus;
        private System.Windows.Forms.Timer timerSendStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSendSatus;
        private System.Windows.Forms.TextBox textBoxJobID;
        private System.Windows.Forms.Timer timerGetResultSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerModemStatus;
        private System.Windows.Forms.ListBox listBoxServerMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewStatusModems;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timertset;
        private System.ComponentModel.BackgroundWorker backgroundWorkertest;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSendFax;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureSendLoading;
        private System.Windows.Forms.Button buttonGetStatusModem;
        private System.Windows.Forms.Button buttonRealTimeStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetStatusModem;
        private System.Windows.Forms.Timer timerStatusModemRealTime;
        private System.Windows.Forms.Button buttonStopModemStatusRealTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox RootUserNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RootPasswordTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label Waitlabel;
        private System.Windows.Forms.PictureBox LoadingModempictureBox;
        private System.Windows.Forms.Timer timerFadeLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.Button SendFaxBtn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SendFaxBtn2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}