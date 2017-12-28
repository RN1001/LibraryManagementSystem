using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Book : ObservableObject
    {
              
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

        private int bookPages;

        public int BookPages
        {
            get { return bookPages; }
            set
            {
                bookPages = value;
                NotifyPropertyChanged();
            }
        }

        private int bookEdition;

        public int BookEdition
        {
            get { return bookEdition; }
            set
            {
                bookEdition = value;
                NotifyPropertyChanged();
            }
        }

        private float bookCost;

        public float BookCost
        {
            get { return bookCost; }
            set
            {
                bookCost = value;
                NotifyPropertyChanged();
            }
        }

        private int genreID;

        public int GenreID
        {
            get { return genreID; }
            set
            {
                genreID = value;
                NotifyPropertyChanged();
            }
        }

        private int publisherID;

        public int PublisherID
        {
            get { return publisherID; }
            set
            {
                publisherID = value;
                NotifyPropertyChanged();
            }
        }


    }

}
