using System.Globalization;

namespace Exerc_Estoque_Construtor.Entities
{
    class Product
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
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
