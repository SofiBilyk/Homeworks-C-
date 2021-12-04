using System;

namespace Ex4
{ /*
   * 
   * В даному прикладі порушується Принцип розділення інтерфейсу
    interface IItem
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
        void SetColor(byte color);
        void SetSize(byte size); 
        void SetPrice(double price);
    }
*/
    interface IBook
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
        void SetPrice(double price);
    }
    interface IClose
    {
        void SetColor(byte color);
        void SetSize(byte size);
        void SetPrice(double price);
    }
    interface ICloseDisc : IClose
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }

    class Book : IBook
    {
        public string name;
        public string _discount;
        public string _promocode;
        public double _price;

        public Book(string Name)
        {
            name = Name;
        }
       
        
        public void ApplyDiscount(string discount)
        {
            _discount = discount;
        }

        public void ApplyPromocode(string promocode)
        {
            _promocode = promocode;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }
        public void Info()
        {
            Console.WriteLine(name);
            Console.WriteLine("You can get discount " + _discount);
            Console.WriteLine("You can use promocod " + _promocode);
            Console.WriteLine("The price is " + _price);
            Console.WriteLine("");
        }
    }

    class Close : IClose
    {
        public string name;
        public byte _color;
        public byte _size;
        public double _price;

        public Close(string Name)
        {
            name = Name;
        }
        public void SetColor(byte color)
        {
            _color = color;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetSize(byte size)
        {
            _size = size;
        }
       
        public void Info()
        {
            Console.WriteLine(name);
            Console.WriteLine("The color of " + name + "is "+ _color);
            Console.WriteLine("The size of " + name + "is " + _size);
            Console.WriteLine("The price is " + _price);
            Console.WriteLine("");

        }
    }

    class CloseDisc : ICloseDisc
    {

        public string name;
        public byte _color;
        public byte _size;
        public double _price;
        public string _discount;
        public string _promocode;

        public CloseDisc(string Name)
        {
            name = Name;
        }
        public void SetColor(byte color)
        {
            _color = color;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetSize(byte size)
        {
            _size = size;
        }
        public void ApplyDiscount(string discount)
        {
            _discount = discount;
        }

        public void ApplyPromocode(string promocode)
        {
            _promocode = promocode;
        }
        public void Info()
        {
            Console.WriteLine(name);
            Console.WriteLine("The color of " + name + "is " + _color);
            Console.WriteLine("The size of " + name + "is " + _size);
            Console.WriteLine("You can get discount " + _discount);
            Console.WriteLine("You can use promocod " + _promocode);
            Console.WriteLine("The price is " + _price);
            Console.WriteLine("");

        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter");
            book1.ApplyDiscount("20 %");
            book1.ApplyPromocode("Harry");
            book1.SetPrice(128.50);

            book1.Info();

            Close close1 = new Close("jeans");
            close1.SetColor(1);
            close1.SetSize(44);
            close1.SetPrice(12.50);

            close1.Info();


            CloseDisc close2 = new CloseDisc("jamper");
            close2.SetColor(3);
            close2.SetSize(40);
            close2.SetPrice(3.50);
            close2.ApplyDiscount("20 %");
            close2.ApplyPromocode("Warm");

            close2.Info();

            Console.ReadKey();
        }
    }
}
