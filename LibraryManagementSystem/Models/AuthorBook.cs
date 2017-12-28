using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class AuthorBook : ObservableObject
    {
        

        private int authorID;

        public int AuthorID
        {
            get { return authorID; }
            set
            {
                authorID = value;
                NotifyPropertyChanged();
            }
        }

        private int bookISBN;

        public int BookISBN
        {
            get { return bookISBN; }
            set
            {
                bookISBN = value;
                NotifyPropertyChanged();
            }
        }


    }

}
