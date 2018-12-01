using BIMReports.com.cbimtech.MemberServices;
using BIMReports.com.cbimtech.ProjectServices;
using BIMReports.com.cbimtech.TimesheetServices;
using System.Linq;
using System.Windows;
//Metro

namespace BIMReports.Forms
{
    /// <summary>
    /// Interaction logic for Program.xaml
    /// </summary>
    public partial class Program : Window
    {
        #region DependencyProperty

        public int MemberLoginID
        {
            get { return (int)GetValue(userIDloginDPProperty); }
            set { SetValue(userIDloginDPProperty, value); }
        }

        // Using a DependencyProperty as the backing store for userIDloginDP.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty userIDloginDPProperty =
            DependencyProperty.Register("userIDloginDP", typeof(int), typeof(Program), new PropertyMetadata(0));

        //public string MemberLoginName
        //{
        //    get { return (string)GetValue(userNameloginDPProperty); }
        //    set { SetValue(userNameloginDPProperty, value); }
        //}        
        //public static readonly DependencyProperty userNameloginDPProperty =
        //    DependencyProperty.Register("userNameloginDP", typeof(string), typeof(Program), new PropertyMetadata(0));

        #endregion


        public static MemberOutput curMember = new MemberOutput();
        public static string userName = "";
        public static int userID = 0;
        public static bool CheckServerConnect = false;
        public Program()
        {
            InitializeComponent();
            txtSearch.Text = "Search...";
        }

        #region Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ConnectServerChecking(int id)
        {
            MemberService memberClient = new MemberService();
            MemberOutput userLoginInfo = memberClient.MemberbyID(id);

            if (userLoginInfo == null) return false;
            else
            {
                userName = userLoginInfo.UserName;
                userID = userLoginInfo.ID;
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isEnable"></param>
        private void FillData(int usrID)
        {           
            //Tạo Client connect to BIMteam Services
            MemberService memberClient = new MemberService();
            ProjectService projectService = new ProjectService();
            TimesheetService timesheetService = new TimesheetService();
            //Điền Dự án
            var items = projectService.GetProjectList();

            MemberOutput member = memberClient.MemberbyID(userID);
            var myProjectList = items.Where(s => s.BIMmember == member.SoftName).ToList();

            cmbMyProject.ItemsSource = myProjectList;
            cmbMyProject.IsTextSearchEnabled = true;
            cmbMyProject.DisplayMemberPath = "TenDuAn";
            cmbMyProject.SelectedValuePath = "MaDuAn";

            //Hủy kết nối
            memberClient.Dispose();
            projectService.Dispose();
            timesheetService.Dispose();

        }

        #endregion
        #region Button Commands

        private void TxtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Width = 250;
        }

        private void TxtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "Search...";
            txtSearch.Width = 100;
        }

        private void TxtSearch_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            // your event handler here
            e.Handled = true;
            MessageBox.Show("TODOWORK: Find something: '" + txtSearch.Text + "'.", "BIMreport");
        }

        private void CmdHidePanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CmdRefresh_Click(object sender, RoutedEventArgs e)
        {
            string username = "", Sortname = "";
            int id = 0;
            username = txtUserName.Text;
            Sortname = lblStatus.Text;
            id = MemberLoginID;
            if (ConnectServerChecking(id))
            {
                MessageBox.Show(username + "-" + Sortname + "-" + id, "UserInfo");
            }
        }

        private void CmdDashboard_Click(object sender, RoutedEventArgs e)
        {
            tabMainContent.TabIndex = 0;
            tabItemDashboard.IsSelected = true;
        }

        private void CmdTodoList_Click(object sender, RoutedEventArgs e)
        {
            tabMainContent.TabIndex = 1;
            tabItemTodoList.IsSelected = true;
        }

        private void CmdReport_Click(object sender, RoutedEventArgs e)
        {
            tabMainContent.TabIndex = 2;
            tabItemReport.IsSelected = true;
            if (ConnectServerChecking(MemberLoginID))
            {
                FillData(MemberLoginID);
            }
        }

        private void CmdClashDetect_Click(object sender, RoutedEventArgs e)
        {
            tabMainContent.TabIndex = 3;
            tabItemClash.IsSelected = true;
        }

        private void CmdLogout_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }


}
