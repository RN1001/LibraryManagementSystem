using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Author :ObservableObject
    {

        /// <summary>
        /// The author identifier
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
        /// The author firstname
        /// </summary>
        private string authorFirstname;

        /// <summary>
        /// Gets or sets the author firstname.
        /// </summary>
        /// <value>
        /// The author firstname.
        /// </value>
        public string AuthorFirstname
        {
            get { return authorFirstname; }
            set
            {
                authorFirstname = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The author middlename
        /// </summary>
        private string authorMiddlename;

        /// <summary>
        /// Gets or sets the name of the author middle.
        /// </summary>
        /// <value>
        /// The name of the author middle.
        /// </value>
        public string AuthorMiddleName
        {
            get { return authorMiddlename; }
            set
            {
                authorMiddlename = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The author lastname
        /// </summary>
        private string authorLastname;

        /// <summary>
        /// Gets or sets the author lastname.
        /// </summary>
        /// <value>
        /// The author lastname.
        /// </value>
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
