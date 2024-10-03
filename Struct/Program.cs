using System;

namespace Struct
{
    class program
    {
        static void Main()
        {
            // Instancia de um Objeto do tipo Product
           var product1 = new Product(1, "Notebook Intel Core", 1500);
           var product2 = new Product(2, "Mouse Gamer RXT", 120);
           var product3 = new Product(3, "Notebook Samsung Celeron", 999);

           Console.WriteLine(product1.GetNotaFiscal());
           Console.WriteLine(product2.GetNotaFiscal());
           Console.WriteLine(product3.GetNotaFiscal());
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public float Price;

        public Product(int Id, string Name, float Price) {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
        public float PriceInDollar(float dollar){
            return Price * dollar;
        }

        public string GetNotaFiscal() {
            return $"Produto [{this.Id}] - {this.Name}: R$ {this.Price}";
        }

    }
}
