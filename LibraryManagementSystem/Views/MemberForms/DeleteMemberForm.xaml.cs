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

namespace LibraryManagementSystem.Views.MemberForms
{
    /// <summary>
    /// Interaction logic for DeleteMemberForm.xaml
    /// </summary>
    public partial class DeleteMemberForm : Window
    {
        public DeleteMemberForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManageMemberViewModel manageMemberViewModel = new ManageMemberViewModel();
            
            try
            {
                manageMemberViewModel.DeleteMemberQuery(MemIDTbox);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error Occurred");
            }

            Close();
        }

        private void SearchID_Click(object sender, RoutedEventArgs e)
        {
            ManageMemberViewModel manageMemberViewModel = new ManageMemberViewModel();

            manageMemberViewModel.SearchMemByID(MemIDTbox, fnameTbox, lnameTbox, mnameTbox, AddressTbox);
        }

        private void CancelFormBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
