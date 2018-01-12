using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Book model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Book : ObservableObject
    {

        /// <summary>
        /// The book isbn, primary key
        /// </summary>
        private int bookISBN;

        /// <summary>
        /// Gets or sets the book isbn.
        /// </summary>
        /// <value>
        /// The book isbn.
        /// </value>
        public int BookISBN
        {
            get { return bookISBN; }
            set
            {
                bookISBN = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The book pages
        /// </summary>
        private int bookPages;

        /// <summary>
        /// Gets or sets the book pages.
        /// </summary>
        /// <value>
        /// The book pages.
        /// </value>
        public int BookPages
        {
            get { return bookPages; }
            set
            {
                bookPages = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The book edition
        /// </summary>
        private int bookEdition;

        /// <summary>
        /// Gets or sets the book edition.
        /// </summary>
        /// <value>
        /// The book edition.
        /// </value>
        public int BookEdition
        {
            get { return bookEdition; }
            set
            {
                bookEdition = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The book cost
        /// </summary>
        private float bookCost;

        /// <summary>
        /// Gets or sets the book cost.
        /// </summary>
        /// <value>
        /// The book cost.
        /// </value>
        public float BookCost
        {
            get { return bookCost; }
            set
            {
                bookCost = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The genre identifier, foreign key
        /// </summary>
        private int genreID;

        /// <summary>
        /// Gets or sets the genre identifier.
        /// </summary>
        /// <value>
        /// The genre identifier.
        /// </value>
        public int GenreID
        {
            get { return genreID; }
            set
            {
                genreID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The publisher identifier, foreign key
        /// </summary>
        private int publisherID;

        /// <summary>
        /// Gets or sets the publisher identifier.
        /// </summary>
        /// <value>
        /// The publisher identifier.
        /// </value>
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
