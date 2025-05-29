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
         
        string DIR = "", modemNumber="";
        Modem modem;
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
                Src = ModemNameComboBox.Text.Trim(),
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
                            var hfax =   HFax.GetInstance(
                                Properties.Settings.Default.Host,
                                Properties.Settings.Default.FaxUsername,
                                Properties.Settings.Default.FaxPassword,
                               4559
                                );
                            

                            if (hfax.hyalafax.IsConnected)
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    modemNumber=ModemNameComboBox.Text.Trim();
                                }));
                                    string faxId = hfax.SendFax(
                                    modemNumber,
                                    dstTextBox.Text.Trim(),
                                    Properties.Settings.Default.Host,
                                    DIR,
                                    hfax.hyalafax
                                       );
                                  
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    MessageBox.Show(faxId, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DisableLoading();
                                    GetModemStatusTimer.Start();
                                }));
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)(() =>
                                 {
                                     DisableLoading();
                                     MessageBox.Show("Unable to establish a connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        errorProviderSrc.SetError(ModemNameComboBox, errors["Src"]);

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
                    ServerIPTxt.Text = InfoSavingManager.GetInformation()["host"];
                    HUserTxt.Text = InfoSavingManager.GetInformation()["faxuser"];
                    HPassTxt.Text = InfoSavingManager.GetInformation()["faxpass"];
                }));
               
            });
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                    InfoSavingManager.SaveInfo(
                          ServerIPTxt.Text.Trim(),
                            HUserTxt.Text.Trim(),
                            HPassTxt.Text.Trim(),
                            Properties.Settings.Default.Product_Key
                        );
                    MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void GetModemStatus()
        {
            if (modemList == null)
                modemList = new List<Modem>();
            Task.Run(() =>
            {
                Hylafax hyalafax = new Hylafax("VOTT-FOFS-SESN-TETH", Properties.Settings.Default.Host, 4559, Properties.Settings.Default.FaxUsername, InfoSavingManager.Decrypt(Properties.Settings.Default.FaxPassword));
                if (hyalafax.IsConnected)
                {
                    HylafaxModems hm = hyalafax.Modems;
                    if (hm.Any())
                    {
                        foreach (var md in hm)
                        {
                            modem = new Modem { ModemNumber = md.PhoneNumber, Status = md.ModemStatus };
                            modemList.Add(modem);
                        }
                        this.Invoke((MethodInvoker)(() =>
                        {
                            modemStatusGridView.DataSource = modemList;
                            modemStatusGridView.Columns[0].Width = 115;
                            modemStatusGridView.Columns[1].Width = 175;
                        }));
                        modemList = null;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to establish a connection.");
                    GetModemStatusTimer.Stop();
                }
            });
        }
        void GetModemNames()
        {
            try
            {
                if (modemList == null)
                    modemList = new List<Modem>();
                Task.Run(() =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        loadingPic.Visible = true;
                    }));
                    var hfax = HFax.GetInstance(
                               Properties.Settings.Default.Host,
                               Properties.Settings.Default.FaxUsername,
                               Properties.Settings.Default.FaxPassword,
                              4559
                               );
                    //Hylafax hyalafax = new Hylafax("VOTT-FOFS-SESN-TETH", Properties.Settings.Default.Host, 4559, Properties.Settings.Default.FaxUsername, InfoSavingManager.Decrypt(Properties.Settings.Default.FaxPassword));
                    if (hfax.hyalafax.IsConnected)
                    {
                        
                        HylafaxModems hm = hfax.hyalafax.Modems;
                        if (hm.Any())
                        {
                            foreach (var md in hm)
                            {
                                modem = new Modem { ModemNumber = md.PhoneNumber, Status = md.ModemStatus };
                                modemList.Add(modem);
                            }
                            this.Invoke((MethodInvoker)(() =>
                            {
                                ModemNameComboBox.DataSource = modemList;
                                ModemNameComboBox.DisplayMember = "ModemNumber";
                                ModemNameComboBox.ValueMember = "ModemNumber";
                            }));
                            modemList = null;
                            this.Invoke((MethodInvoker)(() =>
                            {
                                loadingPic.Visible = false;
                            }));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to establish a connection.");
                        GetModemStatusTimer.Stop();
                        loadingPic.Visible = false;
                    }
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.ToString());
                }));
            }
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
            
            
        }

        private void StartGetModemStatusBtn_Click(object sender, EventArgs e)
        {
            GetModemStatusTimer.Start();
        }

        private void StopGetModemStatusBtn_Click(object sender, EventArgs e)
        {
            GetModemStatusTimer.Stop();
        }

        private void GetModemNameLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetModemNames();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(ModemNameComboBox.Text);
        }
    }
}
