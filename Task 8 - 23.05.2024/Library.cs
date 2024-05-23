namespace Task_8___23._05._2024
{
    internal class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            foreach (Book book in Books)
            {
                if (book.Genre.ToLower() == genre.ToLower())
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }

            return filteredBooks;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            foreach (Book book in Books)
            {
                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }

            return filteredBooks;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in Books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }


        public Book GetBookByName(string name)
        {
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }
            return null;
        }

    }
}
