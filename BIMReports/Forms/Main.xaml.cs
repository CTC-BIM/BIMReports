using System.IO;
using System.Windows;


namespace BIMReports.Forms
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            #region Step 0 - Checking Current data resource
            //Checking File data
            string Step = "Step ";
            int stepNumber = 0;
            string CurrentStep = Step + stepNumber.ToString();
            string AppPath = @"D:/BIMReports/";
            string LocalVersionfile = "Version.txt";
            //Kiểm tra tồn tại của đường dẫn
            if (Directory.Exists(AppPath))//Kiểm tra thư mục Hệ thống có tồn tại hay không
            {
                if (File.Exists(AppPath + LocalVersionfile))
                {
                    lblStatus.Content = "File tồn tại ";
                    lblStatus.Content += CurrentStep;
                    processBar.Value = 10;

                }
                else
                {
                    lblStatus.Content = "File không tồn tại";
                }
            }
            else //Nếu ko thì tạo mới thư mục
            {
                if (MessageBox.Show("Không tìm thấy thư mục cho Ứng dụng vận hành, Tạo mới thư mục?","BIMReport",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Directory.CreateDirectory(AppPath);
                    lblStatus.Content = "Tạo thư mục thành công tại " + AppPath;
                    lblStatus.Content += "\nThời gian tạo " + Directory.GetCreationTime(AppPath);

                    File.Create(AppPath + LocalVersionfile);
                    lblStatus.Content += "\nTạo file Version lúc " + File.GetLastWriteTime(AppPath).ToString();
                    processBar.Value = 20;
                }
                else {
                    MessageBox.Show("App sẽ đóng do không có tài nguyên", "BIMReports");
                    processBar.Value = 0;
                    Application.Current.Shutdown();
                }
            }
            #endregion

            #region Step 1 - Connect to Server
            //1.0 Checking Re
            //1.1 Checking connect

            //1.2 Checking Version Online with current version


            #endregion

            #region Step 2 = Login

            #endregion

            #region Step 3 - Done - Cleaning - Write file

            #endregion

        }
    }
}
