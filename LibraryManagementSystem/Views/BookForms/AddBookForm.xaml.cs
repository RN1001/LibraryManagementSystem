using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows;
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
    /// Interaction logic for AddBookForm.xaml
    /// </summary>
    public partial class AddBookForm : Window
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManageBookViewModel manageBookViewModel = new ManageBookViewModel();
            manageBookViewModel.InsertBookQuery(BookTitleTbox, BookPagesTbox, BookEdiTbox, BookCostTbox, PubNameTbox, PubCityTbox, PubYearTbox, fnameTbox, mnameTbox, lnameTbox, genreTbox, amountTbox);
        }
    }
}
