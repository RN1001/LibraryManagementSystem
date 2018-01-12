using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Genre Model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Genre : ObservableObject
    {

        /// <summary>
        /// The genre identifier, primary key
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
        /// The genre name
        /// </summary>
        private string genreName;

        /// <summary>
        /// Gets or sets the name of the genre.
        /// </summary>
        /// <value>
        /// The name of the genre.
        /// </value>
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
