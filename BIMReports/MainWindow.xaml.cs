using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows;

namespace BIMReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string dest = "Reports";
        static bool connectServices = false;
        public MainWindow()
        {
            InitializeComponent();
            if (CheckServerStatus() != "Services not Found")
            {
                FillData();
                cmbFileType.SelectedIndex = 3;
                lblStatus.Text = CheckServerStatus();
                connectServices = true;
            }
            else
            {
                lblStatus.Text = CheckServerStatus();
            }

        }

        private string CheckServerStatus()
        {
            string connectResult = "Connect Services false";
            string result = "";
            Ping pingToServer = new Ping();
            try
            {
                string servicesAdd = @"services.cbimtech.com";               
                result = pingToServer.Send(servicesAdd, 100).Status.ToString();
                if (pingToServer.Send(servicesAdd, 100).Status == IPStatus.Success)
                    return connectResult = "Connect Services Successful";
                return connectResult;
            }
            catch (Exception)
            {
                return "Services not Found";
            }
        }

        private void FillData()
        {
            cmbFileType.DisplayMemberPath = "Value";
            cmbFileType.SelectedValuePath = "Key";
            cmbFileType.Items.Add(new KeyValuePair<string, string>("BCFs", "Issue Files"));
            cmbFileType.Items.Add(new KeyValuePair<string, string>("BEPs", "BIM execution plan"));
            cmbFileType.Items.Add(new KeyValuePair<string, string>("Images", "Images"));
            cmbFileType.Items.Add(new KeyValuePair<string, string>("Reports", "Report, RFI,..."));
        }

        private void CmdSelectFile_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Open File";
            //openFileDialog.Filter = "All Files|*.*";
            //openFileDialog.FileName = "";
            //try
            //{
            //    openFileDialog.InitialDirectory = "D:\\";
            //}
            //catch
            //{
            //    // skip it
            //}
            //openFileDialog.ShowDialog();

            //if (openFileDialog.FileName == "")
            //    return;
            //else
            //    txtFileAddress.Text = openFileDialog.FileName;

        }

        private void CmdUpload_Click(object sender, RoutedEventArgs e)
        {
            if (connectServices)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Open File";
                openFileDialog.Filter = "All Files|*.*";
                openFileDialog.FileName = "";

                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName == "") return;
                else
                    txtFileAddress.Text = openFileDialog.FileName;

                if (txtFileAddress.Text != string.Empty)
                {
                    string fileName = openFileDialog.FileName;
                    lblStatus.Text = UploadFile(txtFileAddress.Text);
                }
                else
                    lblStatus.Text = "You must select a file first.";
            }
        }

        private string UploadFile(string filename)
        {
            try
            {
                // get the exact file name from the path
                String strFile = System.IO.Path.GetFileName(filename);

                // create an instance fo the web service
                localhost_UploadFile.FilesUploadService srv = new localhost_UploadFile.FilesUploadService();
                // get the file information form the selected file
                FileInfo fInfo = new FileInfo(filename);

                long numBytes = fInfo.Length;
                double dLen = Convert.ToDouble(fInfo.Length / 1024000);

                if (dLen < 10)
                {
                    // set up a file stream and binary reader for the
                    // selected file

                    FileStream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);

                    // convert the file to a byte array
                    byte[] data = br.ReadBytes((int)numBytes);
                    br.Close();
                    // pass the byte array (file) and file name to the web service
                    dest = cmbFileType.SelectedValue.ToString();

                    string sTmp = srv.UploadFiles(strFile, data, dest,"0000");// Hàm đẩy file lên server
                    for (int i = 0; i < dLen; i++)
                    {
                        processbarUpload.Value = (i / 0.5) * 100;
                    }

                    fStream.Close();
                    fStream.Dispose();
                    srv.Dispose();
                    // this will always say OK unless an error occurs,
                    // if an error occurs, the service returns the error message

                    //MessageBox.Show("File Upload Status: " + sTmp, "File Upload");
                    return sTmp;
                }
                else
                {
                    // Display message if the file was too large to upload
                    //MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");
                    return "The file selected exceeds the size limit for uploads.";
                }
            }
            catch (Exception ex)
            {
                // display an error message to the user
                //MessageBox.Show(ex.Message.ToString(), "Upload Error");
                return "Upload Error" + ex.Message.ToString();
            }
        }

        private void CmbFileType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            dest = cmbFileType.SelectedValue.ToString();
        }        
    }
}

