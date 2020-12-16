using System.Globalization;

namespace Exerc_SalarioFuncionario.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Tax { get; set; }

        public double LiquidSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percent)
        {
            GrossSalary += GrossSalary * percent / 100.0;
        }

        public override string ToString()
        {
            return "Employee: "
                   + Name + ", $ "
                   + LiquidSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
