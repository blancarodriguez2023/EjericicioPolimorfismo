using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicioPolimorfismo
{
    public interface IOperaciones
    {
        double Num1 { get; set; }
        double Num2 { get; set; }
        double Resultado { get; }
    }

    // Clase Suma que implementa la interfaz
    public class Suma : IOperaciones
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Resultado => Num1 + Num2;
    }

    // Clase Resta que también implementa la interfaz
    public class Resta : IOperaciones
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Resultado => Num1 - Num2;
    }

    // Clase División que también implementa la interfaz
    public class División : IOperaciones
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Resultado => Num1 / Num2;
    }

    class Program
    {
        static void Main()
        {
            // Ejemplo de uso
            var suma = new Suma { Num1 = 10, Num2 = 5 };
            Console.WriteLine($"Resultado de la suma: {suma.Resultado}");

            var resta = new Resta { Num1 = 10, Num2 = 5 };
            Console.WriteLine($"Resultado de la resta: {resta.Resultado}");

            var division = new División { Num1 = 10, Num2 = 2 };
            Console.WriteLine($"Resultado de la división: {division.Resultado}");

            Console.ReadKey();
        }
    }

}
