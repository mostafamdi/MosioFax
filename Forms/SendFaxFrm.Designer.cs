namespace MSIOFAX_Send.Forms
{
    partial class SendFaxFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendFaxFrm));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.GetModemNameLink = new System.Windows.Forms.LinkLabel();
            this.ModemNameComboBox = new System.Windows.Forms.ComboBox();
            this.pleaseWaitLbl = new System.Windows.Forms.Label();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dstTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SendFaxBtn = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.StartGetModemStatusBtn = new System.Windows.Forms.Button();
            this.modemStatusGridView = new System.Windows.Forms.DataGridView();
            this.StopGetModemStatusBtn = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.HUserTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.HPassTxt = new System.Windows.Forms.TextBox();
            this.ServerIPTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorProviderSrc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDst = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.GetModemStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.loadingPic = new System.Windows.Forms.PictureBox();
            this.loadingBarPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modemStatusGridView)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(371, 348);
            this.tabControl2.TabIndex = 38;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage5.Controls.Add(this.loadingPic);
            this.tabPage5.Controls.Add(this.GetModemNameLink);
            this.tabPage5.Controls.Add(this.ModemNameComboBox);
            this.tabPage5.Controls.Add(this.pleaseWaitLbl);
            this.tabPage5.Controls.Add(this.loadingBarPic);
            this.tabPage5.Controls.Add(this.selectFileBtn);
            this.tabPage5.Controls.Add(this.fileNameLbl);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.dstTextBox);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.SendFaxBtn);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(363, 314);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Send";
            // 
            // GetModemNameLink
            // 
            this.GetModemNameLink.AutoSize = true;
            this.GetModemNameLink.Location = new System.Drawing.Point(152, 43);
            this.GetModemNameLink.Name = "GetModemNameLink";
            this.GetModemNameLink.Size = new System.Drawing.Size(105, 21);
            this.GetModemNameLink.TabIndex = 12;
            this.GetModemNameLink.TabStop = true;
            this.GetModemNameLink.Text = "Get Modems";
            this.GetModemNameLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetModemNameLink_LinkClicked);
            // 
            // ModemNameComboBox
            // 
            this.ModemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModemNameComboBox.FormattingEnabled = true;
            this.ModemNameComboBox.Location = new System.Drawing.Point(25, 40);
            this.ModemNameComboBox.Name = "ModemNameComboBox";
            this.ModemNameComboBox.Size = new System.Drawing.Size(121, 29);
            this.ModemNameComboBox.TabIndex = 11;
            // 
            // pleaseWaitLbl
            // 
            this.pleaseWaitLbl.AutoSize = true;
            this.pleaseWaitLbl.ForeColor = System.Drawing.Color.Red;
            this.pleaseWaitLbl.Location = new System.Drawing.Point(130, 267);
            this.pleaseWaitLbl.Name = "pleaseWaitLbl";
            this.pleaseWaitLbl.Size = new System.Drawing.Size(93, 21);
            this.pleaseWaitLbl.TabIndex = 9;
            this.pleaseWaitLbl.Text = "Please Wait";
            this.pleaseWaitLbl.Visible = false;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.selectFileBtn.ForeColor = System.Drawing.Color.Indigo;
            this.selectFileBtn.Location = new System.Drawing.Point(25, 180);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(312, 30);
            this.selectFileBtn.TabIndex = 7;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(92, 140);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(34, 21);
            this.fileNameLbl.TabIndex = 6;
            this.fileNameLbl.Text = "......";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(21, 140);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(39, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "File:";
            // 
            // dstTextBox
            // 
            this.dstTextBox.Location = new System.Drawing.Point(25, 96);
            this.dstTextBox.Name = "dstTextBox";
            this.dstTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dstTextBox.Size = new System.Drawing.Size(312, 29);
            this.dstTextBox.TabIndex = 4;
            this.dstTextBox.Text = "901";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(21, 72);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(188, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Destination Fax Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(21, 16);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(139, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fax Device to use:";
            // 
            // SendFaxBtn
            // 
            this.SendFaxBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SendFaxBtn.ForeColor = System.Drawing.Color.Indigo;
            this.SendFaxBtn.Location = new System.Drawing.Point(25, 216);
            this.SendFaxBtn.Name = "SendFaxBtn";
            this.SendFaxBtn.Size = new System.Drawing.Size(312, 30);
            this.SendFaxBtn.TabIndex = 0;
            this.SendFaxBtn.Text = "Send";
            this.SendFaxBtn.UseVisualStyleBackColor = true;
            this.SendFaxBtn.Click += new System.EventHandler(this.SendFaxBtn_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.StartGetModemStatusBtn);
            this.tabPage6.Controls.Add(this.modemStatusGridView);
            this.tabPage6.Controls.Add(this.StopGetModemStatusBtn);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(363, 314);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Modem";
            // 
            // StartGetModemStatusBtn
            // 
            this.StartGetModemStatusBtn.Location = new System.Drawing.Point(8, 166);
            this.StartGetModemStatusBtn.Name = "StartGetModemStatusBtn";
            this.StartGetModemStatusBtn.Size = new System.Drawing.Size(345, 35);
            this.StartGetModemStatusBtn.TabIndex = 2;
            this.StartGetModemStatusBtn.Text = "Start Modem Monitoring";
            this.StartGetModemStatusBtn.UseVisualStyleBackColor = true;
            this.StartGetModemStatusBtn.Click += new System.EventHandler(this.StartGetModemStatusBtn_Click);
            // 
            // modemStatusGridView
            // 
            this.modemStatusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modemStatusGridView.Location = new System.Drawing.Point(8, 38);
            this.modemStatusGridView.Name = "modemStatusGridView";
            this.modemStatusGridView.Size = new System.Drawing.Size(345, 122);
            this.modemStatusGridView.TabIndex = 0;
            // 
            // StopGetModemStatusBtn
            // 
            this.StopGetModemStatusBtn.Location = new System.Drawing.Point(8, 207);
            this.StopGetModemStatusBtn.Name = "StopGetModemStatusBtn";
            this.StopGetModemStatusBtn.Size = new System.Drawing.Size(345, 35);
            this.StopGetModemStatusBtn.TabIndex = 1;
            this.StopGetModemStatusBtn.Text = "Stop Modem Monitoring";
            this.StopGetModemStatusBtn.UseVisualStyleBackColor = true;
            this.StopGetModemStatusBtn.Click += new System.EventHandler(this.StopGetModemStatusBtn_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.label16);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.HUserTxt);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.HPassTxt);
            this.tabPage7.Controls.Add(this.ServerIPTxt);
            this.tabPage7.Controls.Add(this.SaveBtn);
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(363, 314);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Settings";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(122, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 21);
            this.label16.TabIndex = 4;
            this.label16.Text = "Hylafax Pass:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "ServerIP :";
            // 
            // HUserTxt
            // 
            this.HUserTxt.Location = new System.Drawing.Point(73, 112);
            this.HUserTxt.Name = "HUserTxt";
            this.HUserTxt.Size = new System.Drawing.Size(208, 29);
            this.HUserTxt.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "HylaFax Username:";
            // 
            // HPassTxt
            // 
            this.HPassTxt.Location = new System.Drawing.Point(72, 168);
            this.HPassTxt.Name = "HPassTxt";
            this.HPassTxt.PasswordChar = '*';
            this.HPassTxt.Size = new System.Drawing.Size(209, 29);
            this.HPassTxt.TabIndex = 3;
            // 
            // ServerIPTxt
            // 
            this.ServerIPTxt.Location = new System.Drawing.Point(73, 54);
            this.ServerIPTxt.Name = "ServerIPTxt";
            this.ServerIPTxt.Size = new System.Drawing.Size(208, 29);
            this.ServerIPTxt.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(72, 219);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(209, 29);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 314);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "About";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // errorProviderSrc
            // 
            this.errorProviderSrc.ContainerControl = this;
            // 
            // errorProviderDst
            // 
            this.errorProviderDst.ContainerControl = this;
            // 
            // errorProviderFile
            // 
            this.errorProviderFile.ContainerControl = this;
            // 
            // GetModemStatusTimer
            // 
            this.GetModemStatusTimer.Interval = 4000;
            this.GetModemStatusTimer.Tick += new System.EventHandler(this.GetModemStatusTimer_Tick);
            // 
            // loadingPic
            // 
            this.loadingPic.Image = global::MSIOFAX_Send.Properties.Resources.loading;
            this.loadingPic.Location = new System.Drawing.Point(263, 40);
            this.loadingPic.Name = "loadingPic";
            this.loadingPic.Size = new System.Drawing.Size(31, 31);
            this.loadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingPic.TabIndex = 13;
            this.loadingPic.TabStop = false;
            this.loadingPic.Visible = false;
            // 
            // loadingBarPic
            // 
            this.loadingBarPic.Image = global::MSIOFAX_Send.Properties.Resources.loading21;
            this.loadingBarPic.Location = new System.Drawing.Point(134, 252);
            this.loadingBarPic.Name = "loadingBarPic";
            this.loadingBarPic.Size = new System.Drawing.Size(90, 12);
            this.loadingBarPic.TabIndex = 8;
            this.loadingBarPic.TabStop = false;
            this.loadingBarPic.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = " moradi.victory@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "To contact me:";
            // 
            // SendFaxFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 373);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SendFaxFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MosioFAX";
            this.Load += new System.EventHandler(this.SendFaxFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modemStatusGridView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBarPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dstTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SendFaxBtn;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HPassTxt;
        private System.Windows.Forms.TextBox HUserTxt;
        private System.Windows.Forms.TextBox ServerIPTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ErrorProvider errorProviderSrc;
        private System.Windows.Forms.ErrorProvider errorProviderDst;
        private System.Windows.Forms.ErrorProvider errorProviderFile;
        private System.Windows.Forms.Label pleaseWaitLbl;
        private System.Windows.Forms.PictureBox loadingBarPic;
        private System.Windows.Forms.Timer GetModemStatusTimer;
        private System.Windows.Forms.DataGridView modemStatusGridView;
        private System.Windows.Forms.Button StartGetModemStatusBtn;
        private System.Windows.Forms.Button StopGetModemStatusBtn;
        private System.Windows.Forms.LinkLabel GetModemNameLink;
        private System.Windows.Forms.ComboBox ModemNameComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox loadingPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}