using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;
using BIMReports.com.cbimtech.MemberServices;

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
            GetMemberInfo(true);
        }

        private List<MemberOutput> GetMemberInfo(bool isEnable)
        {
            List<MemberOutput> listMember = new List<MemberOutput>();
            MemberService client = new MemberService();
            var items = client.DanhSachMember().ToList();
            return listMember;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {            
            LoginCheck();

        }
        private string LoginCheck()
        {
            
            Program mainPrograme = new Program();
            mainPrograme.ShowDialog();
            mainPrograme.txtUserName.Text = "";
            return "OK";
        }
    }
}
