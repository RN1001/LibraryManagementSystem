using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Copy Model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Copy : ObservableObject
    {
        /// <summary>
        /// The copy identifier, primary key
        /// </summary>
        private int copyID;

        /// <summary>
        /// Gets or sets the copy identifier.
        /// </summary>
        /// <value>
        /// The copy identifier.
        /// </value>
        public int CopyID
        {
            get { return copyID; }
            set
            {
                copyID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The copy amount
        /// </summary>
        private int copyAmount;

        /// <summary>
        /// Gets or sets the copy amount.
        /// </summary>
        /// <value>
        /// The copy amount.
        /// </value>
        public int CopyAmount
        {
            get { return copyAmount; }
            set
            {
                copyAmount = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The book isbn, foreign key
        /// </summary>
        private int bookISBN;

        /// <summary>
        /// Gets or sets the book isbn.
        /// </summary>
        /// <value>
        /// The book isbn.
        /// </value>
        public int BookISBN
        {
            get { return bookISBN; }
            set
            {
                bookISBN = value;
                NotifyPropertyChanged();
            }
        }



    }
}
