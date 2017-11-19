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

namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for LMSLoginView.xaml
    /// </summary>
    public partial class LMSLoginView : Window
    {
        public LMSLoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();

            if (UsernameTbx.Text == "admin" && PasswordTbx.Password == "password")
            {
                mw.Show();
                this.Close();
            }
            else
            {
                UsernameTbx.Clear();
                PasswordTbx.Clear();
                ErrorLabel.Content = "Error occured, please try again.";
            }

            
        }

         
    }
}
