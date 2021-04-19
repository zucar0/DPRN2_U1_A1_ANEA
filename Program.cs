using System;
 
namespace DPRN2_U1_A1_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);*/        
            /*  Actividad 1   */
            Empleado empleado = new Empleado();
            Console.WriteLine("Ingresar el Salario Mensual: ");
            var salarioInput = Console.ReadLine();
            double sal= double.Parse(salarioInput);
            // decimal salario = Convert.ToDecimal(Console.ReadLine());
            var salarioMensual = sal;
            empleado.Salario = salarioMensual;
            var salarioconaumento = empleado.aumentarSalario(salarioMensual);
            var salarioAnual = empleado.salarioAnual(salarioMensual);
            Console.WriteLine("El Salario Mensual es: " + empleado.Salario);
            Console.WriteLine("El Salario aumentó a " + salarioconaumento);
            Console.WriteLine("El Salario anual es " + salarioAnual);

        }
    }
}
