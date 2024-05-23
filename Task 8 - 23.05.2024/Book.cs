namespace Task_8___23._05._2024
{
    internal class Book : Product
    {
        public Book(int id) : base(id) { }

        public Book(int id, string name) : base(id, name) { }
        public Book(int id, string name, double price) : base(id, name, price) { }
        public Book(int id, string name, double price, string genre) : base(id, name, price)
        {
            Genre = genre;
        }

        public string Genre { get; set; }
    }
}
