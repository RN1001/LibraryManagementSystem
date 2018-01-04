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
using LibraryManagementSystem.Utility;

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

        /// <summary>
        /// Button that log the user into the application to start using.
        /// default username and password has been set until database is added to solution
        /// and will have an admin type username and password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                Log log = new Log();
                log.ErrorMsg("Error occurred whilst user trying to log into application,\n Username and password may have been entered incorrectly.");
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
