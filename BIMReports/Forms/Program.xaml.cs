using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
//Metro

namespace BIMReports.Forms
{
    /// <summary>
    /// Interaction logic for Program.xaml
    /// </summary>
    public partial class Program : Window
    {
        public Program()
        {
            InitializeComponent();
            txtSearch.Text = "Search...";
            FillData(true);
        }

        private void FillData(bool isEnable)
        {
            if (isEnable)
            {

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
