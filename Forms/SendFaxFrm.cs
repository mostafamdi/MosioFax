using Atom8.Communications.Fax;
using MSIOFAX_Send.Infrastructure;
using MSIOFAX_Send.Model;
using MSIOFAX_Send.Sservices;
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
using MSIOFAX_Send.Models;
namespace MSIOFAX_Send.Forms
{
    public partial class SendFaxFrm : Form
    {
        static int GetModemStatusClick = 0;
        string DIR = "";
        static Hylafax hylafaxObj;
        List<Modem> modemList;
        public SendFaxFrm()
        {
            InitializeComponent();
        }
        
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Supported Files (*.tiff; *.pdf; *.txt)|*.tiff;*.pdf;*.txt|TIFF Files (*.tiff)|*.tiff|PDF Files (*.pdf)|*.pdf|Text Files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.SafeFileName;
                DIR = openFileDialog.FileName;
                fileNameLbl.Text = FileName;
            }
        }
        void EnableLoadin()
        {
            pleaseWaitLbl.Visible = true;
            loadingBarPic.Visible = true;
            SendFaxBtn.Enabled = false;
        }
        void DisableLoading()
        {
            pleaseWaitLbl.Visible = false;
            loadingBarPic.Visible = false;
            SendFaxBtn.Enabled = true;
        }
        private void SendFaxBtn_Click(object sender, EventArgs e)
        {
            var fax = new Fax
            {
                Src = srcTxtBox.Text,
                Dst = dstTextBox.Text,
                File = fileNameLbl.Text
            };
            var validator = new FaxValidator();
            var errors = validator.Validate(fax);
            if (File.Exists(DIR))
            {
                if (errors.Count == 0)
                {
                    pleaseWaitLbl.Invoke((MethodInvoker)(() =>
                    {
                        pleaseWaitLbl.Visible = true;
                        loadingBarPic.Visible = true;
                    }));
                    try
                    {
                        Task.Run(() =>
                        {
                            ISecureStorage secureStorage = new SecureStorage();
                            IHylafax Ihylafax = new HFax(
                              
                                Properties.Settings.Default.ServerIP,
                                Properties.Settings.Default.FaxUsername,
                                Properties.Settings.Default.FaxPassword,
                                Convert.ToInt32(Properties.Settings.Default.Port),
                                secureStorage
                                );
                            hylafaxObj = Ihylafax.GetHylafax();
                            
                            if (hylafaxObj.IsConnected)
                            {
                                string faxId = Ihylafax.SendFax(
                                    srcTxtBox.Text.Trim(),
                                    dstTextBox.Text.Trim(),
                                    Properties.Settings.Default.ServerIP,
                                    DIR,
                                    hylafaxObj
                                       );
                                  
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    MessageBox.Show(faxId, "result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DisableLoading();
                                    GetModemStatusTimer.Start();
                                }));
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)(() =>
                                 {
                                     DisableLoading();
                                     MessageBox.Show("not connected!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 }));
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    if (errors.ContainsKey("Src"))
                        errorProviderSrc.SetError(srcTxtBox, errors["Src"]);

                    if (errors.ContainsKey("Dst"))
                        errorProviderDst.SetError(dstTextBox, errors["Dst"]);

                    if (errors.ContainsKey("File"))
                        errorProviderFile.SetError(fileNameLbl, errors["File"]);
                }
            }
            else
            {
                MessageBox.Show("The file not found!");
            }
            
        }

        private void SendFaxFrm_Load(object sender, EventArgs e)
        {
            modemList = new List<Modem>();
            LoadInfo();
            
        }
        void LoadInfo()
        {
            Task.Run(() =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    ServerIPTxt.Text = GetInfo.GetInformation()["serverip"];
                    HUserTxt.Text = GetInfo.GetInformation()["faxuser"];
                    HPassTxt.Text = GetInfo.GetInformation()["faxpass"];
                }));
               
            });
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                    ISecureStorage secureStorage = new SecureStorage();
                    InfoSavingManager saveingInfo = new InfoSavingManager
                        (
                            HUserTxt.Text.Trim(),
                            HPassTxt.Text.Trim(),
                            ServerIPTxt.Text.Trim(),
                            Properties.Settings.Default.Product_Key,
                            secureStorage
                        );
                    saveingInfo.SaveInfo();
                    MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
        void GetModemStatus()
        {
            Task.Run(() =>
            {

                HylafaxModems hm = hylafaxObj.Modems;
                if (hm.Any())
                {
                    foreach (var md in hm)
                    {
                        var modem = new Modem {ModemName=md.ModemName, Status=md.ModemStatus };
                        modemList.Add(modem);
                    }
                    this.Invoke((MethodInvoker)(() =>
                    {
                        modemStatusGridView.DataSource = modemList;
                    }));
                }
            });
            
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetModemStatus();
        }

        private void GetModemStatusTimer_Tick(object sender, EventArgs e)
        {
            GetModemStatus();
        }

        private void GetModemStatusBtn_Click(object sender, EventArgs e)
        {
            if (GetModemStatusClick == 1)
            {
                GetModemStatusBtn.Name = "Get Modem Status";
                GetModemStatusClick = 0;
                GetModemStatusTimer.Stop();
            }
            
            if (GetModemStatusClick == 0)
            {
                GetModemStatusBtn.Name = "Disable";
                GetModemStatusClick = 1;
                GetModemStatusTimer.Start();
            }
            
        }

        private void StartGetModemStatusBtn_Click(object sender, EventArgs e)
        {
            GetModemStatusTimer.Start();
        }

        private void StopGetModemStatusBtn_Click(object sender, EventArgs e)
        {
            GetModemStatusTimer.Stop();
        }
    }
}
