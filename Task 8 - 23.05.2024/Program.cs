namespace Task_8___23._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Product class
             - Id
             - Name
             - Price - Encapsulation
             - Count - Encapsulation
            
            Book class - Productdan miras alır
             - Genre
             
            Id, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz
            Genre dəyəri təyin olunmadan Book yaradıla bilməz
            
            
            Library class
             - Books - Book type-da array
            - AddBook() - parametr olaraq book type-da dəyər qəbul edib Books arayinə əlavə edir
            - GetBookById() - parametr olaraq int id qebul edir ve bu id'li kitab`ı geriyə qaytarır. tapmasa null qaytarır
            - GetBookByName() - parametr olaraq string name qebul edir ve bu name'li kitab`ı geriyə qaytarır. tapmasa null qaytarır
            - GetFilteredBooks() -  parametr olaraq string value qəbul edir ve genre adı həmin string value olan Book-lardan ibarət array qaytarir
            - GetFilteredBooks() - parametr olaraq minPrice və maxPrice dəyərləri qəbul edir və Price dəyəri minPrice və maxPrice aralığında olan Book-lardan ibarət array qaytarır*/


            Book book1 = new Book(1, "Hannibal", 100, "Crime");
            Book book2 = new Book(2, "Gurur ve Onyargi", 15, "Love");
            Book book3 = new Book(3, "Demir Okce", 22, "Story");
            Book book4 = new Book(4, "Lupen", 3, "Crime");
            Book book5 = new Book(5, "Fahrenheit 451", 12, "Sci-Fi");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            foreach (Book book in library.Books)
            {
                Console.WriteLine(book.Id + " - " + book.Name + " - " + book.Price + " - " + book.Genre);
            }
            Console.WriteLine("\n\n");

            foreach (Book book in library.GetFilteredBooks("Crime"))
            {
                Console.WriteLine(book.Name + " - " + book.Genre);
            }
            Console.WriteLine("\n\n");

            foreach (Book book in library.GetFilteredBooks(10,25))
            {
                Console.WriteLine(book.Name + " - " + book.Price);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine(library.GetBookById(3).Id+ " - " + library.GetBookById(3).Name);
            Console.WriteLine("\n\n");

            Console.WriteLine(library.GetBookByName("Hannibal").Name + " - " + library.GetBookByName("Hannibal").Genre);
            Console.WriteLine("\n");
        }
    }
}