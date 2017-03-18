using System;

public class CommissionEmployee
{
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string SocialSecurityNumber { get; set; }
   private decimal grossSales;
   private decimal commissionRate;

   public CommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales, decimal commissionRate)
   {
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
      GrossSales = grossSales;
      CommissionRate = commissionRate;
   }

   public decimal GrossSales
   {
      get
      {
         return grossSales;
      }
      set
      {
         if (value < 0)
         {
            throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales debe ser >= 0");
         }

         grossSales = value;
      }
   }

   public decimal CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         if (value <= 0 || value >= 1)
         {
            throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate debe ser > 0 y < 1");
         }

         commissionRate = value;
      }
   }

	public virtual decimal Earnings()
	{
		return CommissionRate* GrossSales;
	}

	public override string ToString()
	{
		return	"Empleado por comision   : " + FirstName + " " + LastName + "\n" +
				"Numero de Seguro Social : " + SocialSecurityNumber + "\n" +
				"Ventas Brutas           : " + grossSales + "\n" +
				"Porcentaje de Comision  : " + commissionRate;
	}
}