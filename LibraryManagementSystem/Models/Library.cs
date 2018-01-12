using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Library model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Library : ObservableObject
    {
        /// <summary>
        /// The library identifier, primary key
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

        /// <summary>
        /// The library name
        /// </summary>
        private string libraryName;

        /// <summary>
        /// Gets or sets the name of the library.
        /// </summary>
        /// <value>
        /// The name of the library.
        /// </value>
        public string LibraryName
        {
            get { return libraryName; }
            set
            {
                libraryName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The library address
        /// </summary>
        private string libraryAddress;

        /// <summary>
        /// Gets or sets the library address.
        /// </summary>
        /// <value>
        /// The library address.
        /// </value>
        public string LibraryAddress
        {
            get { return libraryAddress; }
            set
            {
                libraryAddress = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The library post code
        /// </summary>
        private string libPostCode;

        /// <summary>
        /// Gets or sets the library post code.
        /// </summary>
        /// <value>
        /// The library post code.
        /// </value>
        public string LibPostCode
        {
            get { return libPostCode; }
            set
            {
                libPostCode = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The library telephone
        /// </summary>
        private string libTelephone;

        /// <summary>
        /// Gets or sets the library telephone.
        /// </summary>
        /// <value>
        /// The library telephone.
        /// </value>
        public string LibTelephone
        {
            get { return libTelephone; }
            set
            {
                libTelephone = value;
                NotifyPropertyChanged();
            }
        }


    }

}
