namespace LibraryManagementSystem.Models
{
    class Book
    {
        public int BookISBN { get; set; }
        public string BookTitle { get; set; }
        public int BookPages { get; set; }
        public int BookEdition { get; set; }
        public float BookCost { get; set; }

        public int GenreID { get; set; }
        public int PublisherID { get; set; }
    }

}
