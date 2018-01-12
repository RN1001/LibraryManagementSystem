using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Supplier : ObservableObject
    {

        /// <summary>
        /// The supplier identifier
        /// </summary>
        private int supplierID;

        /// <summary>
        /// Gets or sets the supplier identifier.
        /// </summary>
        /// <value>
        /// The supplier identifier.
        /// </value>
        public int SupplierID
        {
            get { return supplierID; }
            set
            {
                supplierID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The supplier name
        /// </summary>
        private string supplierName;

        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        /// <value>
        /// The name of the supplier.
        /// </value>
        public string SupplierName
        {
            get { return supplierName; }
            set
            {
                supplierName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The supplier address
        /// </summary>
        private string supplierAddress;

        /// <summary>
        /// Gets or sets the supplier address.
        /// </summary>
        /// <value>
        /// The supplier address.
        /// </value>
        public string SupplierAddress
        {
            get { return supplierAddress; }
            set
            {
                supplierAddress = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The supplier post code
        /// </summary>
        private string supplierPostCode;

        /// <summary>
        /// Gets or sets the supplier post code.
        /// </summary>
        /// <value>
        /// The supplier post code.
        /// </value>
        public string SupplierPostCode
        {
            get { return supplierPostCode; }
            set
            {
                supplierPostCode = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The supplier email
        /// </summary>
        private string supplierEmail;

        /// <summary>
        /// Gets or sets the supplier email.
        /// </summary>
        /// <value>
        /// The supplier email.
        /// </value>
        public string SupplierEmail
        {
            get { return supplierEmail; }
            set
            {
                supplierEmail = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The supplier telephone
        /// </summary>
        private string supplierTelephone;

        /// <summary>
        /// Gets or sets the supplier telephone.
        /// </summary>
        /// <value>
        /// The supplier telephone.
        /// </value>
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
