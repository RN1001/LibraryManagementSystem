using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Supplier : ObservableObject
    {
       
        private int supplierID;

        public int SupplierID
        {
            get { return supplierID; }
            set
            {
                supplierID = value;
                NotifyPropertyChanged();
            }
        }

        private string supplierName;

        public string SupplierName
        {
            get { return supplierName; }
            set
            {
                supplierName = value;
                NotifyPropertyChanged();
            }
        }

        private string supplierAddress;

        public string SupplierAddress
        {
            get { return supplierAddress; }
            set
            {
                supplierAddress = value;
                NotifyPropertyChanged();
            }
        }

        private string supplierPostCode;

        public string SupplierPostCode
        {
            get { return supplierPostCode; }
            set
            {
                supplierPostCode = value;
                NotifyPropertyChanged();
            }
        }

        private string supplierEmail;

        public string SupplierEmail
        {
            get { return supplierEmail; }
            set
            {
                supplierEmail = value;
                NotifyPropertyChanged();
            }
        }

        private string supplierTelephone;

        public string SupplierTelephone
        {
            get { return supplierTelephone; }
            set
            {
                supplierTelephone = value;
                NotifyPropertyChanged();
            }
        }
                
    }

}
