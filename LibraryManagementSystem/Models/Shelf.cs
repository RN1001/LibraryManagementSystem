using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Shelf : ObservableObject
    {
        private int shelfID;

        public int ShelfID
        {
            get { return shelfID; }
            set
            {
                shelfID = value;
                NotifyPropertyChanged();
            }
        }

        private int libraryID;

        public int LibraryID
        {
            get { return libraryID; }
            set
            {
                libraryID = value;
                NotifyPropertyChanged();
            }
        }


    }

}
