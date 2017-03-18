using System;

class CommissionEmployeeTest
{
   static void Main()
   {
		Console.WriteLine("(01) Empleado por Comision\n");

		var employee = new CommissionEmployee("Sue", "Jones",
         "222-22-2222", 10000.00M, .06M);

      Console.WriteLine("Informacion del empleado obtenida por las propiedades y metodos: \n");
      Console.WriteLine("Nombre                  : {0}", employee.FirstName);
      Console.WriteLine("Apellido                : {0}", employee.LastName);
      Console.WriteLine("Numero de Seguro Social : {0}", employee.SocialSecurityNumber);
      Console.WriteLine("Ventas Brutas           : {0}", employee.GrossSales);
      Console.WriteLine("Porcentaje de Comision  : {0}", employee.CommissionRate);
      Console.WriteLine("Ganancias               : {0}", employee.Earnings());

      employee.GrossSales = 5000.00M; // Se actualiza las ventas brutas del empleado
      employee.CommissionRate = .1M; // Se actualiza el porcentaje de comision del empleado

      Console.WriteLine("\nInformacion actualizada obtenida por ToString:\n");
      Console.WriteLine(employee);
      Console.WriteLine("Ganancias               : {0}\n", employee.Earnings());
   }
}