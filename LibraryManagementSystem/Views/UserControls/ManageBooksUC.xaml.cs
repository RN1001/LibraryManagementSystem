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
using LibraryManagementSystem.Views.BookForms;

namespace LibraryManagementSystem.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ManageBooksUC.xaml
    /// </summary>
    public partial class ManageBooksUC : UserControl
    {
        public ManageBooksUC()
        {
            InitializeComponent();
        }

        private void AddBooksBtn_Click(object sender, RoutedEventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void UpdateBookBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateBookForm updateBookform = new UpdateBookForm();
            updateBookform.Show();
        }

        private void DeleteBookBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteBookForm deletebookform = new DeleteBookForm();
            deletebookform.Show();
        }
    }
}
