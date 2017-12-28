using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Fines : ObservableObject
    {
       private int finesID;

        public int FinesID
        {
            get { return finesID; }
            set
            {
                finesID = value;
                NotifyPropertyChanged();
            }
        }

        private float fineCost;

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
