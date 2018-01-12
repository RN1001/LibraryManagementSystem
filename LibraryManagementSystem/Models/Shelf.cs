using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Shelf : ObservableObject
    {
        /// <summary>
        /// The shelf identifier
        /// </summary>
        private int shelfID;

        /// <summary>
        /// Gets or sets the shelf identifier.
        /// </summary>
        /// <value>
        /// The shelf identifier.
        /// </value>
        public int ShelfID
        {
            get { return shelfID; }
            set
            {
                shelfID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The library identifier
        /// </summary>
        private int libraryID;

        /// <summary>
        /// Gets or sets the library identifier.
        /// </summary>
        /// <value>
        /// The library identifier.
        /// </value>
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
