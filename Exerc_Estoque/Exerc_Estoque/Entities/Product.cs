using System.Globalization;

namespace Exerc_Estoque.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return "Product data: " + Name + ", $ " 
                                    + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                                    + Quantity + " unidades, Total: " 
                                    + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
