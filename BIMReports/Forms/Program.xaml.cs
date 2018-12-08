using BIMReports.com.cbimtech.MemberServices;
using BIMReports.com.cbimtech.ProjectServices;
using BIMReports.com.cbimtech.TimesheetServices;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
//using System.Windows.Forms;
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
        /// Kiểm tra kết nối tới Server
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ConnectServerChecking(int id)
        {
            MemberService memberClient = new MemberService();
            MemberOutput userLoginInfo = memberClient.MemberbyID(id);
            memberClient.Dispose();
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
        /// <param name="usrID"></param>
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

        /// <summary>
        /// Kiểm tra kết nối tới Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdRefresh_Click(object sender, RoutedEventArgs e)
        {
            string username = "", Sortname = "";
            int id = 0;
            username = txtUserName.Text;
            Sortname = lblStatus1.Text;
            id = MemberLoginID;
            if (ConnectServerChecking(id))
            {
                //MessageBox.Show(username + "-" + Sortname + "-" + id, "UserInfo");
                lblConnect.Text = "Connect server OK";
            }
            else
            {
                lblConnect.Text = "Cannot connect to server";
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

            //tvProjectTreeView.Items.Clear();

            if (ConnectServerChecking(MemberLoginID))
            {
                FillData(MemberLoginID);
                cmbMyProject.SelectedIndex = 0;
                TreeViewSetup();
            }

        }

        private void CmdClashDetect_Click(object sender, RoutedEventArgs e)
        {
            tabMainContent.TabIndex = 3;
            tabItemClash.IsSelected = true;
        }

        private void CmdLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Logout ?", "BIM Reports", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Login login = new Login();
                WindowCollection windowCollection = new WindowCollection();
                windowCollection = App.Current.Windows;
                foreach (Window item in windowCollection)
                {
                    if (item.GetType().ToString() == "BIMReports.Forms.Program")
                    {
                        item.Close();
                        login.Show();
                    }
                }
            }
        }

        #endregion

        #region Các Hàm thực thi

        //Tạo danh sách dự án cho Cây dự án
        private void TreeViewSetup()
        {
            int memberid = MemberLoginID;
            int sumProject = 0;
            try
            {
                ProjectService client = new ProjectService();
                MemberService memberService = new MemberService();
                //Lấy username
                string username = memberService.MemberbyID(memberid).SoftName;
                memberService.Dispose();
                //Lấy dự án
                List<DuAnOutput> projectList = client.GetProjectList().ToList();
                client.Dispose();

                List<DuAnOutput> myProject = projectList.Where(s => s.BIMmember == username).ToList();

                List<DuAnOutput> ongoingList = new List<DuAnOutput>();
                List<DuAnOutput> PauseList = new List<DuAnOutput>();
                List<DuAnOutput> FinishList = new List<DuAnOutput>();

                //Gán các dự án theo tình trạng dự án
                foreach (var item in myProject)
                {
                    if (item.ProjectState == "Ongoing")
                    {
                        ongoingList.Add(item);
                    }
                    else if (item.ProjectState == "Pause")
                    {
                        PauseList.Add(item);
                    }
                    else
                    {
                        FinishList.Add(item);
                    }
                }
                tviOngoing.ItemsSource = ongoingList;
                tviOngoing.IsExpanded = true;

                //foreach (DuAnOutput item in ongoingList)
                //{
                //    tviOngoing.Items.Add(item.MaDuAn + "-" + item.TenDuAn);
                //    tviOngoing.IsExpanded = true;
                //}
                foreach (DuAnOutput item in PauseList)
                {
                    tviPause.Items.Add(item.MaDuAn + "-" + item.TenDuAn);
                    tviPause.IsExpanded = true;
                }

                foreach (DuAnOutput item in FinishList)
                {
                    tviFinish.Items.Add(item.MaDuAn + "-" + item.TenDuAn);
                    tviFinish.IsExpanded = true;
                }
                sumProject = ongoingList.Count() + PauseList.Count() + FinishList.Count();
                lblStatus2.Text = sumProject + " projects";
            }
            catch (System.Exception ex)
            {
                lblStatus2.Text = "Không kết nối được server do " + ex.Message;
            }
        }
        #endregion

        private void TvProjectTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            lblStatus1.Text = tvProjectTreeView.SelectedItem.ToString();
        }
    }


}
