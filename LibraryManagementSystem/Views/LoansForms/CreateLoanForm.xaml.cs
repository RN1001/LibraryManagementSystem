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
using LibraryManagementSystem.ViewModels;

namespace LibraryManagementSystem.Views.LoansForms
{
    /// <summary>
    /// Interaction logic for CreateLoanForm.xaml
    /// </summary>
    public partial class CreateLoanForm : Window
    {
        public CreateLoanForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManageLoansViewModel manageLoansViewModel = new ManageLoansViewModel();
            manageLoansViewModel.SearchMemID(MemIdTbox, MemfnameTbox, MemLnameTbox);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManageLoansViewModel manageLoansViewModel = new ManageLoansViewModel();
            manageLoansViewModel.SearchCopyID(CopyIdTbox, BookTitleTbox, BookISBNTbox);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ManageLoansViewModel manageLoansViewModel = new ManageLoansViewModel();
            manageLoansViewModel.InsertLoan(MemIdTbox, CopyIdTbox, fineinc, stdate, enddate);
            this.Close();
        }
    }
}
