namespace Task_8___23._05._2024
{
    internal class Product
    {
        private double _price;
        private int _count;

        public Product(int id)
        {
            Id = id;
        }
        public Product(int id, string name) : this(id)
        {
            Name = name;
        }
        public Product(int id, string name, double price) : this(id, name)
        {
            Price = price;
        }




        public int Id { get; set; }
        public string Name { get; set; }

        public double Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }
        public int Count
        {
            get => _count;
            set
            {
                if (value >= 0)
                    _count = value;
            }
        }



    }
}
