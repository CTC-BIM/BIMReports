using BIMReports.com.cbimtech.MemberServices;
using BIMReports.com.cbimtech.ProjectServices;
using BIMReports.com.cbimtech.TimesheetServices;
using System;
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
        public static MemberOutput curMember = new MemberOutput();
        public static string userName = "";
        public static int userID = 0;
        public Program()
        {
            InitializeComponent();

            userName = txtUserName.Text;
            //userID = int.Parse(GetValue(this.txtUserID.Text));
            txtSearch.Text = "Search...";
            try
            {
                FillData(true, userName);
            }
            catch (System.Exception ex)
            {
                lblStatus.Content = "Không thể kế nối Server do " + ex.Message;
            }


        }

        private void FillData(bool isEnable, string userName)
        {
            if (isEnable)
            {
                if (userName == null || userName.Trim() == "")
                {
                    lblStatus.Content = "Không tìm thấy User";
                    return;
                }
                //Tạo Client connect to BIMteam Services
                MemberService memberClient = new MemberService();
                ProjectService projectService = new ProjectService();
                TimesheetService timesheetService = new TimesheetService();
                //Điền Dự án
                var items = projectService.GetProjectList();
                var myProjectList = items.Where(s => s.BIMmember == userName).ToList();
                cmbMyProject.ItemsSource = items;
                cmbMyProject.IsTextSearchEnabled = true;
                cmbMyProject.DisplayMemberPath = "TenDuAn";
                cmbMyProject.SelectedValuePath = "MaDuAn";


                //Hủy kết nối
                memberClient.Dispose();
                projectService.Dispose();
                timesheetService.Dispose();
            }
        }

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

    }

    
}
;