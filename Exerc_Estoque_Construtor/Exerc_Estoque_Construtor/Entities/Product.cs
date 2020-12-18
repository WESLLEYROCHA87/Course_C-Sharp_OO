using System.Globalization;

namespace Exerc_Estoque_Construtor.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return "Dados do produto: "
                + Name + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantity + " unidades, $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
