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

namespace MSIOFAX_Send.Forms
{
    public partial class SendFaxFrm : Form
    {
        string DIR = "";
        
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
                MessageBox.Show(DIR);
            }
        }
        void EnableLoadin()
        {
            pleaseWaitLbl.Visible = true;
            loadingBarPic.Visible = true;
        }
        void DisableLoading()
        {
            pleaseWaitLbl.Visible = false;
            loadingBarPic.Visible = false;
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
                            IHylafaxConnection hylafaxConnection = new HylafaxConnection(
                                Properties.Settings.Default.ProductKey,
                                Properties.Settings.Default.ServerIP,
                                Properties.Settings.Default.FaxUsername,
                                Properties.Settings.Default.FaxPassword,
                                Convert.ToInt32(Properties.Settings.Default.Port)
                                );
                            if(hylafaxConnection.GetHylafaxConnection().IsConnected)
                            {
                                FaxSender sendFax = new FaxSender(
                                    srcTxtBox.Text.Trim(),
                                    dstTextBox.Text.Trim(),
                                    DIR,
                                    Properties.Settings.Default.ServerIP,
                                    hylafaxConnection
                                    );
                                string faxId = sendFax.SendFax();
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    MessageBox.Show(faxId);
                                    DisableLoading();
                                }));
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)(() =>
                                 {
                                     DisableLoading();
                                     MessageBox.Show("not connected!");
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
                MessageBox.Show("The file not found.!");
            }
            
        }

        private void SendFaxFrm_Load(object sender, EventArgs e)
        {
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
                            Properties.Settings.Default.ProductKey,
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

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
