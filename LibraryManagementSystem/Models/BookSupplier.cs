using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class BookSupplier : ObservableObject
    {
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

        /// <summary>
        /// The supplier identifier, joint primary key
        /// </summary>
        private int supplierID;

        /// <summary>
        /// Gets or sets the supplier identifier.
        /// </summary>
        /// <value>
        /// The supplier identifier.
        /// </value>
        public int SupplierID
        {
            get { return supplierID; }
            set
            {
                supplierID = value;
                NotifyPropertyChanged();
            }
        }



    }

}
