using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;


namespace LibraryManagementSystem.Models
{
    class Member : ObservableObject
    {
        
        private int memberID;

        public int MemberID
        {
            get { return memberID; }
            set
            {
                memberID = value;
                NotifyPropertyChanged();    
            }
        }

        private string memFirstName;

        public string MemFirstName
        {
            get { return memFirstName; }
            set
            {
                memFirstName = value;
                NotifyPropertyChanged();
            }
        }

        private string memMiddleName;

        public string MemMiddleName
        {
            get { return memMiddleName; }
            set
            {
                memMiddleName = value;
                NotifyPropertyChanged();
            }
        }

        private string memLastName;

        public string MemLastName
        {
            get { return memLastName; }
            set
            {
                memLastName = value;
                NotifyPropertyChanged();
            }
        }

        private MySql.Data.Types.MySqlDateTime memDOB;

        public MySql.Data.Types.MySqlDateTime MemDOB
        {
            get { return memDOB; }
            set
            {
                memDOB = value;
                NotifyPropertyChanged();
            }
        }

        private string memAddress;

        public string MemAddress
        {
            get { return memAddress; }
            set
            {
                memAddress = value;
                NotifyPropertyChanged();
            }
        }

        private string memSecAddress;

        public string MemSecAddress
        {
            get { return memSecAddress; }
            set
            {
                memSecAddress = value;
                NotifyPropertyChanged();
            }
        }

        private string memPostCode;

        public string MemPostCode
        {
            get { return memPostCode; }
            set
            {
                memPostCode = value;
                NotifyPropertyChanged();
            }
        }

        private string memCity;

        public string MemCity
        {
            get { return memCity; }
            set
            {
                memCity = value;
                NotifyPropertyChanged();
            }
        }

        private string memEmail;

        public string MemEmail
        {
            get { return memEmail; }
            set
            {
                memEmail = value;
                NotifyPropertyChanged();
            }
        }

        private string memTelephone;

        public string MemTelephone
        {
            get { return memTelephone; }
            set
            {
                memTelephone = value;
                NotifyPropertyChanged();
            }
        }

        private string memMobile;

        public string MemMobile
        {
            get { return memMobile; }
            set
            {
                memMobile = value;
                NotifyPropertyChanged();
            }
        }

        private string memType;

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
