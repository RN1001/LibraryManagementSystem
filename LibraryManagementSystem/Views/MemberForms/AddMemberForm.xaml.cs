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


namespace LibraryManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for AddMemberForm.xaml
    /// </summary>
    public partial class AddMemberForm : Window
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            ManageMemberViewModel manageMemberViewModel = new ManageMemberViewModel();
            try
            {
                manageMemberViewModel.InsertMemberQuery(fNameTbox, MNameTbox, LNameTbox, DOBDPick, PrimAddTbox, SecAddTbox, PostCodeTbox, CityTbox, EmailTbox, TelTbox, MobTbox, MemTypeCBox);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error Occurred");
            }

            this.Close();
        }
    }
}
