using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
   private decimal baseSalary;

   public BasePlusCommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
      : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
   {
      BaseSalary = baseSalary;
   }

   public decimal BaseSalary
   {
      get
      {
         return baseSalary;
      }
      set
      {
         if (value < 0)
         {
				throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary debe ser >= 0");
			}

         baseSalary = value;
      }
   }

	public override decimal Earnings()
	{
		return BaseSalary + (CommissionRate * GrossSales);
	}

	public override string ToString()
	{
		return  "Empleado por comision + base : " + FirstName + " " + LastName + "\n" +
				"Numero de Seguro Social      : " + SocialSecurityNumber + "\n" +
				"Ventas Brutas                : " + GrossSales + "\n" +
				"Porcentaje de Comision       : " + CommissionRate + "\n" +
				"Salario Base                 : " + BaseSalary;
	}
}