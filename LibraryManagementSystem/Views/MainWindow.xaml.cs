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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryManagementSystem.ViewModels;
using MySql.Data.MySqlClient;
using System.Data;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the ManageMembersBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ManageMembersBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Visible;
            ManageBooksUC.Visibility = Visibility.Hidden;            
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the Click event of the ManageBooksBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ManageBooksBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Visible;            
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the Click event of the ManageFinesBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ManageFinesBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;          
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the Click event of the ManageLoansBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ManageLoansBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;            
            ManageLoansUC.Visibility = Visibility.Visible;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the Click event of the ToolsBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ToolsBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;            
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Visible;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the Click event of the ReportsBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ReportsBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;          
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the Click event of the MenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        /// <summary>
        /// Handles the Click event of the LoadMemBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void LoadMemBtn_Click(object sender, RoutedEventArgs e)
        {
            
            ManageMemberViewModel manageMemberViewModel = new ManageMemberViewModel();
            manageMemberViewModel.FillDatagridWithMembers(MemberDataGrid);
               
        }

        /// <summary>
        /// Handles the Click event of the LoadBookBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void LoadBookBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageBookViewModel manageBookViewModel = new ManageBookViewModel();
            manageBookViewModel.FillDgBookrecords(BookDataGrid);
        }

        /// <summary>
        /// Handles the Click event of the LoadLoanBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void LoadLoanBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageLoansViewModel manageLoansViewModel = new ManageLoansViewModel();
            manageLoansViewModel.FillDatagridFromLoanQuery(LoanDataGrid);
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Feature not implemented!", "Not Implemented", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the Click event of the ExecuteQueryBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ExecuteQueryBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Feature not implemented!", "Not Implemented", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
