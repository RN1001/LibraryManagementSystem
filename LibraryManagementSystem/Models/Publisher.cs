using System;

namespace LibraryManagementSystem.Models
{
    class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public string PublisherCity { get; set; }
        public string PublisherPostcode { get; set; }
        public string PublisherState { get; set; }
        public DateTime PublishedYear { get; set; }
    }

}
