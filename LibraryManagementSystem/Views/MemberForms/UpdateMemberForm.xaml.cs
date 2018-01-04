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
    /// Interaction logic for UpdateMemberForm.xaml
    /// </summary>
    public partial class UpdateMemberForm : Window
    {
        public UpdateMemberForm()
        {
            InitializeComponent();
        }

        private void SearchIDButton_Click(object sender, RoutedEventArgs e)
        {
            ManageMemberViewModel manageMemberViewModel = new ManageMemberViewModel();
                      
            manageMemberViewModel.SearchMemByID(MemIDTbox, fNameTbox, MNameTbox, LNameTbox, DOBDPick, PrimAddTbox, SecAddTbox, PostCodeTbox, CityTbox, EmailTbox, TelTbox, MobTbox, MemTypeCBox);
           
        }

        private void UpdateMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageMemberViewModel manageMemberViewModel = new ManageMemberViewModel();

            manageMemberViewModel.UpdateMemberQuery(MemIDTbox, fNameTbox, MNameTbox, LNameTbox, DOBDPick, PrimAddTbox, SecAddTbox, PostCodeTbox, CityTbox, EmailTbox, TelTbox, MobTbox, MemTypeCBox);

            Close();
        }

        private void CancelFormBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
