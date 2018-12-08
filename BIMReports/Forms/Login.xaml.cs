using BIMReports.com.cbimtech.MemberServices;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace BIMReports.Forms
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblStatus.Content = LoginCheck();
        }

        private string LoginCheck()
        {
            //RUN
            string userName = "";
            string pass = "";

            lblStatus.Content = "Connecting server";

            if (txtUserName.Text == null || txtUserName.Text.Trim() == "")
            {
                userName = "nhantc";
            }
            else
            {
                userName = txtUserName.Text;
            }
            if (txtPass.Password == null || txtPass.Password.Trim() == "")
            {
                pass = "123";
            }
            else
            {
                pass = txtPass.Password.ToString();
            }


            string imageUserName = "";
            string pathImage = @"pack://application:,,,/BIMReports;component/Resources/UserImg/";


            MemberOutput member = GetMember(true, userName, pass);
            if (member != null)
            {
                //Đóng cửa sổ Login
                WindowCollection windowCollection = new WindowCollection();
                windowCollection = App.Current.Windows;
                foreach (Window item in windowCollection)
                {
                    //MessageBox.Show(item.GetType().ToString());
                    if (item.GetType().ToString() == "BIMReports.Forms.Login")
                    {
                        //MessageBox.Show("Chào mừng bạn " + member.SoftName, "BIMreport");
                        //Mở chương trình chính
                        Program mainPrograme = new Program()
                        {
                            //Cách mới tạo DP và Set value cho DP
                            MemberLoginID = member.ID
                        };
                        mainPrograme.MemberLoginID = member.ID;

                        //Cách cũ - gán giá trị 
                        mainPrograme.txtUserName.Text = member.SoftName;
                        mainPrograme.lblStatus1.Text = member.UserName;
                        mainPrograme.txtUserID.Text = member.ID.ToString();

                        //set image
                        imageUserName = member.Image; // gán imageName tìm được vào ImageName
                        string fullimagePath = pathImage + imageUserName; //FullPath tìm tới Image                   
                        mainPrograme.imgUser.ImageSource = new BitmapImage(new Uri(fullimagePath));//Gán ImageUser vào Window mới

                        item.Close();
                        mainPrograme.ShowDialog();

                        return "Login OK";
                    }
                }
            }
            return "Login False, Wrong Username or Pass";
        }

        private MemberOutput GetMember(bool isEnable, string userName, string pass)
        {
            if (isEnable)
            {
                if (userName == null || userName.Trim() == "") return null;
                if (pass == null || pass.Trim() == "") return null;
                try
                {
                    MemberService client = new MemberService();
                    MemberOutput userReturn = client.MemberbyUsername(userName);
                    client.Dispose();
                    if (userReturn.UserName == userName && userReturn.Password == pass) return userReturn;
                }
                catch (System.Exception)
                {
                    return null;
                }
            }
            return null;
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            LoginCheck();
        }
    }
}
