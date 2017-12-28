using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class BookSupplier : ObservableObject
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

        private int supplierID;

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
