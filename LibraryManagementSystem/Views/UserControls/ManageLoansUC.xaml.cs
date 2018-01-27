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
using LibraryManagementSystem.Views.LoansForms;


namespace LibraryManagementSystem.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ManageLoansUC.xaml
    /// </summary>
    public partial class ManageLoansUC : UserControl
    {
        public ManageLoansUC()
        {
            InitializeComponent();
        }

        private void ViewLoans_Click(object sender, RoutedEventArgs e)
        {
            CreateLoanForm createLoanForm = new CreateLoanForm();
            createLoanForm.Show();
        }

        private void Returnbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Feature has not been implement yet.", "Not implemented..", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void Renewalsbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Finesbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
