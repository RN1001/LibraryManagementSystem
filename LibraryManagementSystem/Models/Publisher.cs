using System;
using LibraryManagementSystem.Utility;
using MySql.Data.Types;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Publisher : ObservableObject
    {
        /// <summary>
        /// The publisher identifier
        /// </summary>
        private int publisherID;

        /// <summary>
        /// Gets or sets the publisher identifier.
        /// </summary>
        /// <value>
        /// The publisher identifier.
        /// </value>
        public int PublisherID
        {
            get { return publisherID; }
            set
            {
                publisherID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The publisher name
        /// </summary>
        private string publisherName;

        /// <summary>
        /// Gets or sets the name of the publisher.
        /// </summary>
        /// <value>
        /// The name of the publisher.
        /// </value>
        public string PublisherName
        {
            get { return publisherName; }
            set
            {
                publisherName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The publisher city
        /// </summary>
        private string publisherCity;

        /// <summary>
        /// Gets or sets the publisher city.
        /// </summary>
        /// <value>
        /// The publisher city.
        /// </value>
        public string PublisherCity
        {
            get { return publisherCity; }
            set
            {
                publisherCity = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The published year of a book
        /// </summary>
        private MySqlDateTime publishedYear;

        /// <summary>
        /// Gets or sets the published year.
        /// </summary>
        /// <value>
        /// The published year.
        /// </value>
        public MySqlDateTime PublishedYear
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
