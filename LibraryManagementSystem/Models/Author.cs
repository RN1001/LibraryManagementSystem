using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Author :ObservableObject
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

        private string authorFirstname;

        public string AuthorFirstname
        {
            get { return authorFirstname; }
            set
            {
                authorFirstname = value;
                NotifyPropertyChanged();
            }
        }

        private string authorMiddlename;

        public string AuthorMiddleName
        {
            get { return authorMiddlename; }
            set
            {
                authorMiddlename = value;
                NotifyPropertyChanged();
            }
        }

        private string authorLastname;

        public string AuthorLastname
        {
            get { return authorLastname; }
            set
            {
                authorLastname = value;
                NotifyPropertyChanged();
            }
        }



    }

}
