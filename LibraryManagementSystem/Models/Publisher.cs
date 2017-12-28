using System;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Publisher : ObservableObject
    {
        private int publisherID;

        public int PublisherID
        {
            get { return publisherID; }
            set
            {
                publisherID = value;
                NotifyPropertyChanged();
            }
        }

        private string publisherName;

        public string PublisherName
        {
            get { return publisherName; }
            set
            {
                publisherName = value;
                NotifyPropertyChanged();
            }
        }

        private string publisherCity;

        public string PublisherCity
        {
            get { return publisherCity; }
            set
            {
                publisherCity = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime publishedYear; 

        public DateTime PublishedYear
         {
            get { return publishedYear; }
            set
            {
                publishedYear = value;
                NotifyPropertyChanged();
            }
        }


    }

}
