using Atom8.Communications.Fax;
using MSIOFAX_Send.Assistans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MSIOFAX_Send.Model;
namespace MSIOFAX_Send.Forms
{
    public partial class SendFax : Form
    {
        Hylafax objHFax;
        HylafaxModem modem;
        static string DIR = "";
        static bool INITIALISE = false, ISCONNECTED = false, MODEMSTATUS = false;
        static bool BEFORE = false, MIDDLE = false, AFTER = false, RealTime = false;
        public SendFax()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "PDF Files (*.pdf)|*.PDF";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.SafeFileName;
                DIR = openFileDialog.FileName;
                FileNamelabel.Text = FileName;
            }
        }
        void GetModemStatusFromServer()
        {
            string result = CommandLine.RunCommand("faxstat -r");
            var ServerModemlist = new List<ModemViewModel>();
            var modify = result.Split('\n');

            for (int i = 1; i < modify.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(modify[i]))
                {
                    if (modify[i].Substring(0, 5) == "Modem")
                    {
                        var modem = new ModemViewModel() { ModemName = modify[i] };
                        ServerModemlist.Add(modem);
                    }
                }
            }
            if (dataGridViewStatusModems.InvokeRequired)
                dataGridViewStatusModems.Invoke(new MethodInvoker(() =>
                {
                    dataGridViewStatusModems.DataSource = ServerModemlist;
                }));
                    
        }
        void UpdateModemList()
        {
            try
            {
                string ModemName = "";
                string result = CommandLine.RunCommand("faxstat -r");
                var ServerModemlist = new List<ModemViewModel>();
                var modify = result.Split('\n');
                //ModemListComboBox.DataSource = null;
                XmlDocument xmlEmloyeeDoc = new XmlDocument();
                xmlEmloyeeDoc.Load(Application.StartupPath + "/XMLFiles/ModemNames.xml");

                for (int i = 1; i < modify.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(modify[i]))
                    {
                        if (modify[i].Substring(0, 5) == "Modem")
                        {
                            var temp = modify[i].Split(' ');
                            ModemName = temp[2].Replace('(', ' ').Replace(')', ' ').Replace(':', ' ').Trim();
                            var modem = new ModemViewModel() { ModemName = ModemName };
                            ServerModemlist.Add(modem);
                        }
                    }
                }

                // Load the XML file from our project directory containing the purchase orders
                //var filename = "ModemNames.xml";
                //var currentDirectory = Directory.GetCurrentDirectory();
                //var purchaseOrderFilepath = Path.Combine(currentDirectory, filename);

                XElement purchaseOrder = XElement.Load(Application.StartupPath + "/XMLFiles/ModemNames.xml");

                xmlEmloyeeDoc.Load(Application.StartupPath + "/XMLFiles/ModemNames.xml");
                foreach (XmlNode item in xmlEmloyeeDoc.DocumentElement.ChildNodes)
                {
                    item.ParentNode.RemoveAll();
                    xmlEmloyeeDoc.Save(Application.StartupPath + "/XMLFiles/ModemNames.xml");
                }


                foreach (var item in ServerModemlist)
                {
                    //var res = purchaseOrder.Descendants("modem").Where(x => x.Element("number").Value.Trim() == item.ModemName).ToList();
                    //if ((res.Count() <= 0))
                    //{
                    XmlElement ParentElement = xmlEmloyeeDoc.CreateElement("modem");
                    XmlElement Name = xmlEmloyeeDoc.CreateElement("number");
                    Name.InnerText = item.ModemName;
                    ParentElement.AppendChild(Name);

                    xmlEmloyeeDoc.DocumentElement.AppendChild(ParentElement);
                    xmlEmloyeeDoc.Save(Application.StartupPath + "/XMLFiles/ModemNames.xml");
                    // }
                }
                GetModemNameFromXMLFileAsync();
            }
            catch (Exception ex)
            {
                var error = ex.Message.Split(':');
                if (error[1].Contains("A connection attempt failed because"))
                {
                    ModemListComboBox.Invoke(new MethodInvoker(() =>
                    {
                        listBoxServerMessage.Items.Clear();
                        listBoxServerMessage.Items.Add("ارتباط با سرور برقرار نیست");
                        Waitlabel.Text = "ارنباط با سرور برقرار نیست";
                    }));
                }
            }
        }
        void GetModemNameFromXMLFileAsync()
        {
            if (ModemListComboBox.InvokeRequired)
                ModemListComboBox.Invoke(new MethodInvoker(() =>
                {
                    var list = new List<ModemViewModel>();
                    XmlDocument xmlEmloyeeDoc = new XmlDocument();
                    xmlEmloyeeDoc.Load(Application.StartupPath + "/XMLFiles/ModemNames.xml");
                    foreach (XmlNode item in xmlEmloyeeDoc.DocumentElement.ChildNodes)
                    {
                        ModemListComboBox.DisplayMember = "ModemName";
                        var modem = new ModemViewModel() { ModemName = item.InnerText.ToString() };
                        list.Add(modem);

                    }
                    ModemListComboBox.Refresh();
                    ModemListComboBox.DataSource = list;
                    Waitlabel.Text = "انجام شد";
                }));
          
        }
        void GetModemNameFromXMLFile()
        {
            
                    var list = new List<ModemViewModel>();
                    XmlDocument xmlEmloyeeDoc = new XmlDocument();
                    xmlEmloyeeDoc.Load(Application.StartupPath + "/XMLFiles/ModemNames.xml");
                    foreach (XmlNode item in xmlEmloyeeDoc.DocumentElement.ChildNodes)
                    {
                        ModemListComboBox.DisplayMember = "ModemName";
                        var modem = new ModemViewModel() { ModemName = item.InnerText.ToString() };
                        list.Add(modem);

                    }
                    ModemListComboBox.Refresh();
                    ModemListComboBox.DataSource = list;
                 

        }
        void CreateModemNameFromXMLFile()
        {
            XmlDocument xmlEmloyeeDoc = new XmlDocument();
            xmlEmloyeeDoc.Load(Application.StartupPath + "/XMLFiles/ModemNames.xml");
            XmlElement ParentElement = xmlEmloyeeDoc.CreateElement("modem");
            XmlElement Name = xmlEmloyeeDoc.CreateElement("name");
            Name.InnerText = "900";
            ParentElement.AppendChild(Name);
            xmlEmloyeeDoc.DocumentElement.AppendChild(ParentElement);
            xmlEmloyeeDoc.Save(Application.StartupPath + "/XMLFiles/ModemNames.xml");
        }
        private void SendFax_Load(object sender, EventArgs e)
        {
            GetModemNameFromXMLFile();
            LoadVariable();
            
        }
        void LoadVariable()
        {
            FaxUsernameTextBox.Text = Properties.Settings.Default.FaxUsername;
            FaxPasswordTextBox.Text = Properties.Settings.Default.FaxPassword;
            

            PortTextBox.Text = Properties.Settings.Default.Port;
            ServerIPTextBox.Text = Properties.Settings.Default.ServerIP;
        }
        void CheckConnect()
        {
            try
            {
                if (objHFax.IsConnected)
                {
                    statusStrip1.BackColor = Color.Green;
                    buttonDoConnect.Enabled = false;
                    ISCONNECTED = true;
                }
                else
                {
                    statusStrip1.BackColor = Color.Red;
                    ISCONNECTED = false;

                    buttonDoConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //   GetModemNameFromXMLFile();
           UpdateModemList();
           // CreateModemNameFromXMLFile();
        }

        private void RefreshListModemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(UpdateModemNameBackgroundWorker.IsBusy))
            {
                UpdateModemNameBackgroundWorker.RunWorkerAsync();
                Waitlabel.Visible = true;
                LoadingModempictureBox.Visible = true;
            }
        }

        private void UpdateModemNameBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateModemList();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var srcTree = new XElement("Root",
    new XElement("Element1", 1),
    new XElement("Element2", 2),
    new XElement("Element3", 3),
    new XElement("Element4", 4),
    new XElement("Element5", 5)
);
            var xmlTree = new XElement("Root",
                new XElement("Child1", 1),
                new XElement("Child2", 2),
                new XElement("Child3", 3),
                new XElement("Child4", 4),
                new XElement("Child5", 5)
            );
            xmlTree.Add(new XElement("NewChild", "new content"));
            xmlTree.Add(
                from el in srcTree.Elements()
                where (int)el > 3
                select el
            );
            // Even though Child9 doesn't exist in srcTree, the following statement won't
            // throw an exception, and nothing will be added to xmlTree.
            xmlTree.Add(srcTree.Element("Child9"));
            Console.WriteLine(xmlTree);
        }

        private void SendFaxButton_Click(object sender, EventArgs e)
        {
            if (!(backgroundWorkerSendFax.IsBusy))
                backgroundWorkerSendFax.RunWorkerAsync();
            //if (!(backgroundWorkerModemStatus.IsBusy))
            //    backgroundWorkerModemStatus.RunWorkerAsync();

            //var modem = objHFax.Modems.Where(x => x.PhoneNumber == ModemListComboBox.Text).FirstOrDefault();
            //if (modem.ModemStatus == "Running and idle")
            //{


            //    if (CheckIsSelectedModem() && FileNamelabel.Text.Trim() != "......" && ISCONNECTED && FaxNumberTextBox.Text.Trim() != String.Empty)
            //    {
            //        timerSendStatus.Enabled = true;
            //        //

            //        HylafaxModem modem1 = new HylafaxModem();
            //        modem1.ModemName = ModemListComboBox.Text;
            //        modem1.PhoneNumber = ModemListComboBox.Text;
            //        modem1.ServerName = Properties.Settings.Default.ServerIP;

            //        modem1.IsActive = true;
            //        objHFax.Modems.Add(modem1);

            //        //MessageBox.Show(modem1.ModemStatus);

            //        //Set the Hylafax Job Settings
            //        HylafaxJobSettings objHFJS = new HylafaxJobSettings();
            //        objHFJS.FaxNumber = FaxNumberTextBox.Text.Trim();
            //        //objHFJS.FromCompany = "Moradi";
            //        //objHFJS.ToCompany = "Moradi";
            //        objHFJS.FromUser = ModemListComboBox.Text.Trim();
            //        //any other settings....

            //        //submit the job to be faxed...

            //        string strFaxID = objHFax.SendFax(DIR.Trim(), DIR.Trim(), objHFJS);
            //        //objHFax.GetFaxJob()
            //        var res = strFaxID.Split(' ');
            //        string faxid = res.Last().ToString();
            //        textBoxJobID.Text = faxid;
            //        //MessageBox.Show(faxid);
            //        //jHFax.GetFaxJob(res.Last());
            //        // MessageBox.Show(objHFax.GetFaxJob(faxid).Settings.JobInfo.ToString());
            //        timerGetResultSend.Enabled = true;
            //        timertset.Enabled = true;
            //        // MessageBox.Show("Ok");
            //    }
            //    else
            //    {
            //        //if (MODEMSTATUS == false)
            //        //    listBoxServerMessage.Items.Add("مودم انتخاب شده آماده نیست");

            //        if (!(CheckIsSelectedModem()))
            //            listBoxServerMessage.Items.Add("مودمی انتخاب نشده است");

            //        if (FileNamelabel.Text.Trim() == "......")
            //            listBoxServerMessage.Items.Add("فایلی برای ارسال انتخاب کنید");

            //        if (FaxNumberTextBox.Text.Trim() == String.Empty)
            //            listBoxServerMessage.Items.Add("شماره فکس را وارد کنید");

            //        if (!(ISCONNECTED))
            //            listBoxServerMessage.Items.Add("ارتباط با سرور برقرار نیست");
            //    }
            //}
            //else
            //{

            //}
        }
            bool CheckIsSelectedModem()
        {
            int count = 0;
            if (ModemListComboBox.InvokeRequired)
                ModemListComboBox.Invoke(new MethodInvoker(() =>
                {
                    count = ModemListComboBox.Items.Count;
                }));

            if (count> 0)
                {
                    return true;
                }
                else
                    return false;
            }
        //}
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ServerIPTextBox.Text.Trim() != String.Empty && FaxUsernameTextBox.Text.Trim() != String.Empty && PortTextBox.Text.Trim() != String.Empty && ServerIPTextBox.Text.Trim() != String.Empty)
            {
               
                Properties.Settings.Default.ServerIP = ServerIPTextBox.Text.Trim();
                Properties.Settings.Default.Port = PortTextBox.Text.Trim();
                Properties.Settings.Default.FaxUsername = FaxUsernameTextBox.Text.Trim();
                Properties.Settings.Default.FaxPassword = FaxPasswordTextBox.Text.Trim();
                Properties.Settings.Default.RootUserName = RootUserNameTextBox.Text.Trim();
                Properties.Settings.Default.RootPassword = RootPasswordTextBox.Text.Trim();
                Properties.Settings.Default.Save();
            }
            else
            {
                if (ServerIPTextBox.Text.Trim() == String.Empty)
                    errorProviderServerIP.SetError(ServerIPTextBox, "آی پی سرور را وارد کنید");
                if (FaxUsernameTextBox.Text.Trim() == String.Empty)
                    errorProviderUserName.SetError(FaxUsernameTextBox, "نام کاربری هایلافکس را وارد کنید");
                if (FaxPasswordTextBox.Text.Trim() == String.Empty)
                    errorProviderPassword.SetError(FaxPasswordTextBox, "پسورد هایلافکس را وارد کنید");
                if (PortTextBox.Text.Trim() == String.Empty)
                    errorProviderPort.SetError(PortTextBox, "پورت هایلافکس را وارد کنید");


            }
        }

        private void timerCheckConnect_Tick(object sender, EventArgs e)
        {
            if (!(backgroundWorkerCheckConnect.IsBusy))
                backgroundWorkerCheckConnect.RunWorkerAsync();
        }

        private void backgroundWorkerCheckConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckConnect();
        }

        private void buttonDoConnect_Click(object sender, EventArgs e)
        {
            if (!(backgroundWorkerInitialiseObjFax.IsBusy))
            {
                backgroundWorkerInitialiseObjFax.RunWorkerAsync();
                pictureBoxLoading.Visible = true;
                labelLoading.Visible = true;
                timerCheckConnect.Enabled = true;
                buttonDoConnect.Enabled = false;
            }
        }
        void InitialiseObjFAX()
        {
            objHFax = new Hylafax("VOTT-FOFS-SESN-TETH", Properties.Settings.Default.ServerIP, 4559, Properties.Settings.Default.FaxUsername, Properties.Settings.Default.FaxPassword);
        }
        private void backgroundWorkerInitialiseObjFax_DoWork(object sender, DoWorkEventArgs e)
        {
            InitialiseObjFAX();
        }

        private void backgroundWorkerInitialiseObjFax_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            buttonDoConnect.Enabled = false;

        }

        private void backgroundWorkerInitialiseObjFax_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonDoConnect.Enabled = true;
            pictureBoxLoading.Visible = false;
            labelLoading.Visible = false;
            if ((objHFax.IsConnected))
            { toolStripStatusLabel1.Text = "ارتباط با سرور برقرار است"; ISCONNECTED = true; buttonDoConnect.Enabled = false; timerCheckConnect.Enabled = true; }
            else
            {
                toolStripStatusLabel1.Text = "ارتباط با سرور برقرار نشد ، لطفا دوباره بروی دکمه کلیک کنید";
                ISCONNECTED = false;
                timerCheckConnect.Enabled = false;
                buttonDoConnect.Enabled = true;
            }
        }

        private void FaxNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        void GetStatusSend(string modemNumber)
        {
            try
            {
                string ResultQuery = CommandLine.RunCommand("faxstat -r");
                var modify = ResultQuery.Split('\n');
                for (int i = 1; i < modify.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(modify[i]))
                    {
                        if (modify[i].Substring(0, 5) == "Modem")
                        {
                            if (modify[i].Split(':')[0].Contains(modemNumber))
                            {
                                if (INITIALISE == true && modify[i].Split(':')[1].Contains("Running and idle"))
                                {
                                   // GetModemTimer.Enabled = false;
                                    timerGetResultSend.Enabled = false;
                                    labelSendStatus.Text = objHFax.GetFaxJob(textBoxJobID.Text).FaxStatus;
                                }
                                if (!(modify[i].Split(':')[1].Contains("Running and idle")))
                                    INITIALISE = true;
                                //if (modify[i].Split(':')[0].Contains("Sending"))
                                //    SENDING = true;
                                //if (modify[i].Split(':')[0].Contains("Waiting"))
                                //    WATING = true;
                                //if (INITIALISE == true && SENDING == true && WATING == true)
                                // { GetModemTimer.Enabled = false; timer1.Enabled = false; }

                                labelSendStatus.Text = modify[i];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void GetFinal()
        {
            try
            {
                if (objHFax.GetFaxJob(textBoxJobID.Text).FaxStatus == String.Empty)
                {
                    timerSendStatus.Enabled = false;
                    labelSendStatus.Text ="FAX HAS BEEN Send Correctly ";
                    timerGetResultSend.Enabled = false;
                }
                    // MessageBox.Show(objHFax.GetFaxJob(textBox1.Text).FaxStatus+ objHFax.GetFaxJob(textBox1.Text).FaxStatusCode);
                    if (objHFax.GetFaxJob(textBoxJobID.Text).FaxStatus != String.Empty)
                {
                    timerSendStatus.Enabled = false;
                    labelSendStatus.Text = objHFax.GetFaxJob(textBoxJobID.Text).FaxStatus;
                    timerGetResultSend.Enabled = false;
                }
                //  MessageBox.Show("fax state=" + objHFax.GetFaxJob(textBox1.Text).FaxState + "-fax status=" + objHFax.GetFaxJob(textBox1.Text).FaxStatus + "---fax status code=" + objHFax.GetFaxJob(textBox1.Text).FaxStatusCode + "--to string=" + objHFax.GetFaxJob(textBox1.Text).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void timerSendStatus_Tick(object sender, EventArgs e)
        {
            if (!(backgroundWorkerSendSatus.IsBusy))
                backgroundWorkerSendSatus.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            var ServerModemlist = new List<ModemViewModel>();
            var mvm = new ModemViewModel();
            mvm.ModemName = "111";
            ServerModemlist.Add(mvm);
            listBoxServerMessage.Items.Add(mvm.ModemName);
            //listBoxServerMessage.SelectedItem = "ModemName";
           // MessageBox.Show( objHFax.Modems.Where(x => x.PhoneNumber == ModemListComboBox.Text.Trim()).First().ModemStatus);
            //foreach (var item in objHFax.Modems)
            //{
            //    MessageBox.Show(objHFax.Modems.Where(x => x.PhoneNumber == item.PhoneNumber.Trim()).First().ModemStatus);
            //}
        }
        bool CheckStatusModem()
        {
            try {
                string modemNuber = "", modemStatus = "";
                if (ModemListComboBox.InvokeRequired)
                    ModemListComboBox.Invoke(new MethodInvoker(() =>
                    {
                        modemNuber = (ModemListComboBox.Text);
                        MessageBox.Show(objHFax.Modems.Where(x => x.PhoneNumber == modemNuber.Trim()).First().ModemStatus);
                        modemStatus = objHFax.Modems.Where(x => x.PhoneNumber == modemNuber.Trim()).First().ModemStatus;
                    }));

                if (modemStatus.Trim() == "Running and idle")
                {
                    MODEMSTATUS = true;
                    return true;
                }
                else {
                    MODEMSTATUS = true;
                    return false;
                    
                }
            }
            catch (Exception ex)
            {
                MODEMSTATUS = false;
               
                return false;
            }
        }

        private void backgroundWorkerSendSatus_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                GetStatusSend(ModemListComboBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(objHFax.GetFaxJob("92").FaxStatus.Trim());
            //MessageBox.Show(objHFax.GetFaxJob(textBoxJobID.Text.Trim()).FaxStatus.Trim());
            //string FaxID = objHFax.CompletedQueue.First().JobID;
            //Get the fax job from server.
            //HylafaxJob objJob = objHFax.GetFaxJob("100");
            HylafaxModem modem1 = new HylafaxModem();
            modem1.ModemName = ModemListComboBox.Text;
           
            modem1.ModemName = ModemListComboBox.Text;
            modem1.PhoneNumber = ModemListComboBox.Text;
            modem1.ServerName = Properties.Settings.Default.ServerIP;

            modem1.IsActive = true;
            objHFax.Modems.Add(modem1);
            foreach (var item in objHFax.Modems)
            {
                MessageBox.Show(item.ModemStatus);
            }
        }

        private void backgroundWorkertest_DoWork(object sender, DoWorkEventArgs e)
        {
            GetStatus();
        }
        void GetStatus()
        {
            try
            {
                
                if (listBoxServerMessage.InvokeRequired)
                    listBoxServerMessage.Invoke(new MethodInvoker(() =>
                    {
                     
                        HylafaxJob objJob = objHFax.GetFaxJob(textBoxJobID.Text);

                        if (objJob.FaxStatus != "Running and idle")
                        {
                            MIDDLE = true;
                        }
                        if (MIDDLE && objJob.FaxStatus == "Runnig and idle" && BEFORE)
                        {
                            timertset.Enabled = false;
                            SendFaxButton.Enabled = true;
                            pictureSendLoading.Visible = false;
                            BEFORE = false;
                            MIDDLE = false;
                            listBoxServerMessage.Items.Clear();
                            listBoxServerMessage.Items.Add(objJob.FaxStatus);
                            listBoxServerMessage.Items.Add(objJob.FaxState);
                            
                        }
                        if (objJob.FaxStatus == "Busy signal detected" || objJob.FaxState=="DONE")
                        {
                            timertset.Enabled = false;
                            SendFaxButton.Enabled = true;
                            pictureSendLoading.Visible = false;
                            listBoxServerMessage.Items.Clear();
                            listBoxServerMessage.Items.Add(objJob.FaxStatus);
                            listBoxServerMessage.Items.Add(objJob.FaxState);
                        }
                        //listBoxServerMessage.Items.Add(objJob.FaxStatus);
                        //listBoxServerMessage.Items.Add(objJob.FaxState);
                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //if (objHFax.CompletedQueueCount > 0)
            //{
            //    //Get the FaxID to retrieve.
            //    string FaxID = objHFax.CompletedQueue.First().JobID;
            //    //Get the fax job from server.
            //    HylafaxJob objJob = objHFax.GetFaxJob(FaxID);
            //}
        }

        private void timertset_Tick(object sender, EventArgs e)
        {
            if (!(backgroundWorkertest.IsBusy))
                backgroundWorkertest.RunWorkerAsync();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(backgroundWorkerGetStatusModem.IsBusy))
                backgroundWorkerGetStatusModem.RunWorkerAsync();
        }

        private void backgroundWorkerGetStatusModem_DoWork(object sender, DoWorkEventArgs e)
        {
            GetModemStatusFromServer();
        }

        private void timerStatusModemRealTime_Tick(object sender, EventArgs e)
        {
            if (!(backgroundWorkerGetStatusModem.IsBusy))
                backgroundWorkerGetStatusModem.RunWorkerAsync();
        }

        private void buttonStopModemStatusRealTime_Click(object sender, EventArgs e)
        {
            timerStatusModemRealTime.Enabled = false;
            buttonRealTimeStatus.Enabled = true;
            buttonStopModemStatusRealTime.Enabled = false;
        }

        private void SlideButton_Click(object sender, EventArgs e)
        {
            Size = new Size(705,441);
        }

        private void UpdateModemNameBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RefreshListModemLinkLabel.Enabled = false;
        }

        private void UpdateModemNameBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshListModemLinkLabel.Enabled = true;
            Waitlabel.Visible = true;
            
            LoadingModempictureBox.Visible = false;
            timerFadeLabel.Enabled = true;
        }

        private void timerFadeLabel_Tick(object sender, EventArgs e)
        {
            try {
                Waitlabel.Visible = false;
                
                        timerFadeLabel.Enabled = false;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }
        public async Task GetDataAsync()
        {

            Hylafax hylafax = new Hylafax("VOTT-FOFS-SESN-TETH", "192.168.1.122", 4559, "ali", "123456");
            try
            {
                bool result = await Task.Run(() => hylafax.IsConnected);
                if (result)
                {
                    MessageBox.Show("Ok");
                }
            }
            catch (Exception ex)
            {
              
            }
           
         

        }
        private void Waitlabel_Click(object sender, EventArgs e)
        {

        }

        private   void SendFaxBtn_Click(object sender, EventArgs e)
        {
          
            // await GetDataAsync();
            Task.Run(() =>
            {
                string dir= "C:\\Users\\mostafa\\Downloads\\fax0000000119.pdf";
                IHylafaxConnection hylafaxConnection = new HylafaxConnection("VOTT-FOFS-SESN-TETH", "192.168.1.122", "ali", "123456", 4559);
                if (hylafaxConnection.GetHylafaxConnection().IsConnected)
                {
                    FaxSender sendFax = new FaxSender("900", "901","", dir, hylafaxConnection);
                    string faxId = sendFax.SendFax();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show(faxId);
                    }));
                }
                else
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("ارتباط برقراز نیست");
                    }));
                }
                
               
                //var hylafax = new Hylafax("VOTT-FOFS-SESN-TETH", "192.168.1.122", 4559, "ali", "123456");
                //bool isConnected = hylafax.IsConnected;

                //// به خاطر اینکه UI فقط از ترد اصلی قابل دسترسیه
                //this.Invoke((MethodInvoker)(() =>
                //{
                //    MessageBox.Show(isConnected ? "Connected" : "Not Connected");
                //}));
            });
            //dataGridModem.DataSource = objHFax.Modems.ToList();
            //var modem = objHFax.Modems.Where(x => x.ModemStatus.Trim()== "Running and idle").FirstOrDefault();
            //if (modem.ModemStatus == "Running and idle")
            //{

            //}


            //HylafaxJobSettings hylaFaxSetting = new HylafaxJobSettings();

            //hylaFaxSetting.FaxNumber = toTxt.Text.Trim();


            //HylafaxModem modem1 = new HylafaxModem();


            //modem1.ModemName = "900";

            //modem1.ModemName = "900";
            //modem1.PhoneNumber = "900";
            //modem1.ServerName = "192.168.1.122";

            ////modem1.ModemName = "900";
            ////modem1.PhoneNumber = "900";
            ////modem1.ServerName = Properties.Settings.Default.ServerIP;
            //modem1.IsActive = true;


            //hylaFaxSetting.FromUser = "900";

            //string strFaxID = hylafax.SendFax(DIR.Trim(), DIR.Trim(), hylaFaxSetting);


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void fromTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRealTimeStatus_Click(object sender, EventArgs e)
        {
            timerStatusModemRealTime.Enabled = true;
           
            buttonStopModemStatusRealTime.Enabled = true;
            buttonRealTimeStatus.Enabled = false;
        }

        private void backgroundWorkerSendFax_DoWork(object sender, DoWorkEventArgs e)
        {
            Send();
        }
        void Send()
        {
            string FileName = "", FaxNumber = "";
            string modemNumber = "";
          
            try
            {
                if (FileNamelabel.InvokeRequired)
                    FileNamelabel.Invoke(new MethodInvoker(() =>
                    {
                        FileName = FileNamelabel.Text.Trim();
                        FaxNumber = FaxNumberTextBox.Text.Trim();
                    }));


                if(CheckIsSelectedModem() && FileName != "......" && FaxNumber != String.Empty)
                {
                    if(ModemListComboBox.InvokeRequired)
                        ModemListComboBox.Invoke(new MethodInvoker(() =>
                        {
                            modemNumber = ModemListComboBox.Text;
                        }));
                    modem = objHFax.Modems.Where(x => x.PhoneNumber == modemNumber).FirstOrDefault();
                    if (modem.ModemStatus == "Running and idle")
                    {

                            if (ISCONNECTED)
                            {
                           // timerSendStatus.Enabled = true;
                            //

                            HylafaxModem modem1 = new HylafaxModem();
                            modem1.ModemName = modemNumber;
                            modem1.PhoneNumber = modemNumber;
                            modem1.ServerName = Properties.Settings.Default.ServerIP;

                            modem1.IsActive = true;
                            objHFax.Modems.Add(modem1);

                            //MessageBox.Show(modem1.ModemStatus);

                            //Set the Hylafax Job Settings
                            HylafaxJobSettings objHFJS = new HylafaxJobSettings();
                            objHFJS.FaxNumber = FaxNumber;
                            //objHFJS.FromCompany = "Moradi";
                            //objHFJS.ToCompany = "Moradi";
                            objHFJS.FromUser = modemNumber;
                            //any other settings....

                            //submit the job to be faxed...

                            string strFaxID = objHFax.SendFax(DIR.Trim(), DIR.Trim(), objHFJS);
                            //objHFax.GetFaxJob()
                            var res = strFaxID.Split(' ');
                            string faxid = res.Last().ToString();
                            if (textBoxJobID.InvokeRequired)
                                textBoxJobID.Invoke(new MethodInvoker(() =>
                                {
                                    textBoxJobID.Text = faxid;
                                    BEFORE = true;
                                }));
                          
                            //MessageBox.Show(faxid);
                            //jHFax.GetFaxJob(res.Last());
                            // MessageBox.Show(objHFax.GetFaxJob(faxid).Settings.JobInfo.ToString());
                            // timerGetResultSend.Enabled = true;
                           
                            if (SendFaxButton.InvokeRequired)
                                SendFaxButton.Invoke(new MethodInvoker(() =>
                                {
                                    listBoxServerMessage.Items.Clear();
                                    timertset.Enabled = true;
                                    FileName = FileNamelabel.Text.Trim();
                                    FaxNumber = FaxNumberTextBox.Text.Trim();
                                    SendFaxButton.Enabled = false;
                                    pictureSendLoading.Visible = true;
                                }));
                            // MessageBox.Show("Ok");
                        }
                        else
                        {
                            //if (MODEMSTATUS == false)
                            //    listBoxServerMessage.Items.Add("مودم انتخاب شده آماده نیست");
                            if (SendFaxButton.InvokeRequired)
                                SendFaxButton.Invoke(new MethodInvoker(() =>
                                {
                                    SendFaxButton.Enabled = true;
                                    pictureSendLoading.Visible = false;
                                }));

                          
                            MessageBox.Show("Not Conneced To Server!");

                        }
                    }
                    else
                    {
                        if (SendFaxButton.InvokeRequired)
                            SendFaxButton.Invoke(new MethodInvoker(() =>
                            {
                                SendFaxButton.Enabled = true;
                                pictureSendLoading.Visible = false;
                            }));
                       
                        MessageBox.Show(modem.ModemStatus);
                    }
                }
                else
                {
                    if (listBoxServerMessage.InvokeRequired)
                        listBoxServerMessage.Invoke(new MethodInvoker(() =>
                        {
                            listBoxServerMessage.Items.Clear();
                        }));
                   
                    if (SendFaxButton.InvokeRequired)
                        SendFaxButton.Invoke(new MethodInvoker(() =>
                        {
                            SendFaxButton.Enabled = true;
                            pictureSendLoading.Visible = false;
                        }));

                    if (!(CheckIsSelectedModem()))
                        if (listBoxServerMessage.InvokeRequired)
                            listBoxServerMessage.Invoke(new MethodInvoker(() =>
                            {
                                listBoxServerMessage.Items.Add("مودمی انتخاب نشده است");
                            }));


                    if (FileNamelabel.Text.Trim() == "......")
                        if (listBoxServerMessage.InvokeRequired)
                            listBoxServerMessage.Invoke(new MethodInvoker(() =>
                            {
                                listBoxServerMessage.Items.Add("فایلی برای ارسال انتخاب کنید");
                            }));


                    if (FaxNumberTextBox.Text.Trim() == String.Empty)
                        if (listBoxServerMessage.InvokeRequired)
                            listBoxServerMessage.Invoke(new MethodInvoker(() =>
                            {
                                listBoxServerMessage.Items.Add("شماره فکس را وارد کنید");
                            }));


                    if (!(ISCONNECTED))
                        if (listBoxServerMessage.InvokeRequired)
                            listBoxServerMessage.Invoke(new MethodInvoker(() =>
                            {
                                listBoxServerMessage.Items.Add("ارتباط با سرور برقرار نیست");
                            }));

                   
                }
            }
            catch(Exception ex)
            {
                if (SendFaxButton.InvokeRequired)
                    SendFaxButton.Invoke(new MethodInvoker(() =>
                    {
                        SendFaxButton.Enabled = true;
                        pictureSendLoading.Visible = false;
                    }));

                MessageBox.Show(ex.ToString());
            }
        }
        private void backgroundWorkerModemStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckStatusModem();
        }

        private void timerGetResultSend_Tick(object sender, EventArgs e)
        {
            GetFinal();
        }
    }
}
