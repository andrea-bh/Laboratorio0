using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad = [0, 0, 0, 0, 0], int billetes = [100, 50, 20, 5, 1])
        {
            Console.WriteLine("Ingrese una cantidad de dinero");

            cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad >= 100)
            {
                int div = cantidad % 100;
                

            }

            return new int[] {};
        }
    }
}
