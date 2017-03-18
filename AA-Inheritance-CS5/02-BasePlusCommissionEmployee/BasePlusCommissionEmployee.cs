using System;

//Empleado que recibe un salario basico en adicion a una comision 
public class BasePlusCommissionEmployee
{
    public string FirstName { get; set;  }
    public string LastName { get; set;  }
    public string SocialSecurityNumber { get; set; }
   private decimal grossSales; // ventas brutas semanales
   private decimal commissionRate; // porcentaje de comision
   private decimal baseSalary; // Salario base semanal

   public BasePlusCommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
   {
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
      GrossSales = grossSales; // propiedad que valida las ventas brutas
      CommissionRate = commissionRate; // propiedad que valida el porcentaje de comision
      BaseSalary = baseSalary; // propiedad que valida el salario base
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

   public decimal Earnings()
   {
      return baseSalary + (commissionRate * grossSales);
   }

   public override string ToString()
   {
       return	"Empleado por comision + base : " + FirstName + " " + LastName + "\n" +
				"Numero de Seguro Social      : " + SocialSecurityNumber + "\n" +
				"Ventas Brutas                : " + GrossSales + "\n" +
				"Porcentaje de Comision       : " + CommissionRate + "\n" +
				"Salario Base                 : " + BaseSalary;
   }
}