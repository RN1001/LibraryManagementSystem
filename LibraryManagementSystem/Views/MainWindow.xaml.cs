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

namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageMembersBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Visible;
            ManageBooksUC.Visibility = Visibility.Hidden;
            ManageFinesUC.Visibility = Visibility.Hidden;
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        private void ManageBooksBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Visible;
            ManageFinesUC.Visibility = Visibility.Hidden;
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        private void ManageFinesBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;
            ManageFinesUC.Visibility = Visibility.Visible;
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        private void ManageLoansBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;
            ManageFinesUC.Visibility = Visibility.Hidden;
            ManageLoansUC.Visibility = Visibility.Visible;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        private void ToolsBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;
            ManageFinesUC.Visibility = Visibility.Hidden;
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Visible;
            ReportsUC.Visibility = Visibility.Hidden;
        }

        private void ReportsBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMembersUC.Visibility = Visibility.Hidden;
            ManageBooksUC.Visibility = Visibility.Hidden;
            ManageFinesUC.Visibility = Visibility.Hidden;
            ManageLoansUC.Visibility = Visibility.Hidden;
            ToolsUC.Visibility = Visibility.Hidden;
            ReportsUC.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
