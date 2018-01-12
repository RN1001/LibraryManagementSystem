using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// author book model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class AuthorBook : ObservableObject
    {
        /// <summary>
        /// The author identifier, joint primary key
        /// </summary>
        private int authorID;

        /// <summary>
        /// Gets or sets the author identifier.
        /// </summary>
        /// <value>
        /// The author identifier.
        /// </value>
        public int AuthorID
        {
            get { return authorID; }
            set
            {
                authorID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The book isbn, joint primary key
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


    }

}
