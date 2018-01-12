using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;


namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Member : ObservableObject
    {

        /// <summary>
        /// The member identifier, primary key
        /// </summary>
        private int memberID;

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberID
        {
            get { return memberID; }
            set
            {
                memberID = value;
                NotifyPropertyChanged();    
            }
        }

        /// <summary>
        /// The member first name
        /// </summary>
        private string memFirstName;

        /// <summary>
        /// Gets or sets the first name of the member.
        /// </summary>
        /// <value>
        /// The first name of the member.
        /// </value>
        public string MemFirstName
        {
            get { return memFirstName; }
            set
            {
                memFirstName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member middle name
        /// </summary>
        private string memMiddleName;

        /// <summary>
        /// Gets or sets the name of the Member middle.
        /// </summary>
        /// <value>
        /// The name of the Member middle.
        /// </value>
        public string MemMiddleName
        {
            get { return memMiddleName; }
            set
            {
                memMiddleName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member last name
        /// </summary>
        private string memLastName;

        /// <summary>
        /// Gets or sets the last name of the Member.
        /// </summary>
        /// <value>
        /// The last name of the Member.
        /// </value>
        public string MemLastName
        {
            get { return memLastName; }
            set
            {
                memLastName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member dob
        /// </summary>
        private MySql.Data.Types.MySqlDateTime memDOB;

        /// <summary>
        /// Gets or sets the Member dob.
        /// </summary>
        /// <value>
        /// The Member dob.
        /// </value>
        public MySql.Data.Types.MySqlDateTime MemDOB
        {
            get { return memDOB; }
            set
            {
                memDOB = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member address
        /// </summary>
        private string memAddress;

        /// <summary>
        /// Gets or sets the Member address.
        /// </summary>
        /// <value>
        /// The Member address.
        /// </value>
        public string MemAddress
        {
            get { return memAddress; }
            set
            {
                memAddress = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member sec address
        /// </summary>
        private string memSecAddress;

        /// <summary>
        /// Gets or sets the Member sec address.
        /// </summary>
        /// <value>
        /// The Member sec address.
        /// </value>
        public string MemSecAddress
        {
            get { return memSecAddress; }
            set
            {
                memSecAddress = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member post code
        /// </summary>
        private string memPostCode;

        /// <summary>
        /// Gets or sets the Member post code.
        /// </summary>
        /// <value>
        /// The Member post code.
        /// </value>
        public string MemPostCode
        {
            get { return memPostCode; }
            set
            {
                memPostCode = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member city
        /// </summary>
        private string memCity;

        /// <summary>
        /// Gets or sets the Member city.
        /// </summary>
        /// <value>
        /// The Member city.
        /// </value>
        public string MemCity
        {
            get { return memCity; }
            set
            {
                memCity = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member email
        /// </summary>
        private string memEmail;

        /// <summary>
        /// Gets or sets the Member email.
        /// </summary>
        /// <value>
        /// The Member email.
        /// </value>
        public string MemEmail
        {
            get { return memEmail; }
            set
            {
                memEmail = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member telephone
        /// </summary>
        private string memTelephone;

        /// <summary>
        /// Gets or sets the Member telephone.
        /// </summary>
        /// <value>
        /// The Member telephone.
        /// </value>
        public string MemTelephone
        {
            get { return memTelephone; }
            set
            {
                memTelephone = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member mobile
        /// </summary>
        private string memMobile;

        /// <summary>
        /// Gets or sets the Member mobile.
        /// </summary>
        /// <value>
        /// The Member mobile.
        /// </value>
        public string MemMobile
        {
            get { return memMobile; }
            set
            {
                memMobile = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Member type
        /// </summary>
        private string memType;

        /// <summary>
        /// Gets or sets the type of the Member.
        /// </summary>
        /// <value>
        /// The type of the Member.
        /// </value>
        public string MemType
        {
            get { return memType; }
            set
            {
                memType = value;
                NotifyPropertyChanged();
            }
        }
       
    }
}
