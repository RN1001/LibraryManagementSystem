using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// fine model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Fines : ObservableObject
    {
        /// <summary>
        /// The fines identifier, primary key
        /// </summary>
        private int finesID;

        /// <summary>
        /// Gets or sets the fines identifier.
        /// </summary>
        /// <value>
        /// The fines identifier.
        /// </value>
        public int FinesID
        {
            get { return finesID; }
            set
            {
                finesID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The fine cost
        /// </summary>
        private float fineCost;

        /// <summary>
        /// Gets or sets the fine cost.
        /// </summary>
        /// <value>
        /// The fine cost.
        /// </value>
        public float FineCost
        {
            get { return fineCost; }
            set
            {
                fineCost = value;
                NotifyPropertyChanged();
            }
        }


    }

}
