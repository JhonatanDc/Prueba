using System;

class BasePlusCommissionEmployeeTest
{
   static void Main()
   {
		Console.WriteLine("(02) Empleado por Comision + Sueldo Base\n");

		var employee = new BasePlusCommissionEmployee("Bob", "Lewis",
         "333-33-3333", 5000.00M, .04M, 300.00M);

      Console.WriteLine("Informacion del Empleado obtenido por Propiedades y Metodos: \n");
	  Console.WriteLine("Nombre                       : "+employee.FirstName);
      Console.WriteLine("Apellido                     : "+employee.LastName);
      Console.WriteLine("Numero de Seguro Social      : "+employee.SocialSecurityNumber);
      Console.WriteLine("Ventas Brutas                : "+employee.GrossSales);
      Console.WriteLine("Porcentaje de Comision       : "+employee.CommissionRate);
      Console.WriteLine("Ganancias                    : "+employee.Earnings());
      Console.WriteLine("Salario Base                 : "+employee.BaseSalary);

      employee.BaseSalary = 1000.00M; // Se actualiza el salario base

      Console.WriteLine("\nInformacion actualizada obtenida por ToString:\n");
      Console.WriteLine(employee);
      Console.WriteLine("Ganancias                    : " + employee.Earnings() + "\n");
   }
}