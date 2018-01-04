using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    class Copy
    {
        private int copyID;

        public int CopyID
        {
            get { return copyID; }
            set { copyID = value; }
        }

        private int copyAmount;

        public int CopyAmount
        {
            get { return copyAmount; }
            set { copyAmount = value; }
        }

        private int bookISBN;

        public int BookISBN
        {
            get { return bookISBN; }
            set { bookISBN = value; }
        }



    }
}
