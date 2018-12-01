using BIMReports.com.cbimtech.MemberServices;
using System.Windows;
using System.Windows.Input;

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
            //string userName = txtUserName.Text;
            //string pass = txtPass.Password.ToString();

            //TEST
            string userName = "nhantc";
            string pass = "123";

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
                        mainPrograme.lblStatus.Text = member.UserName;
                        mainPrograme.txtUserID.Text = member.ID.ToString();

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

    }
}
