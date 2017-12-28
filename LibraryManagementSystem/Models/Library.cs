using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Library : ObservableObject
    {
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

        private string libraryName;

        public string LibraryName
        {
            get { return libraryName; }
            set
            {
                libraryName = value;
                NotifyPropertyChanged();
            }
        }

        private string libraryAddress;

        public string LibraryAddress
        {
            get { return libraryAddress; }
            set
            {
                libraryAddress = value;
                NotifyPropertyChanged();
            }
        }

        private string libPostCode;

        public string LibPostCode
        {
            get { return libPostCode; }
            set
            {
                libPostCode = value;
                NotifyPropertyChanged();
            }
        }

        private string libTelephone;

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
