using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Genre : ObservableObject
    {
        
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

        private string genreName;

        public string GenreName
        {
            get { return genreName; }
            set
            {
                genreName = value;
                NotifyPropertyChanged();
            }
        }


    }

}
