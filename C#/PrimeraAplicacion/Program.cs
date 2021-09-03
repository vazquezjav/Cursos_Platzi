using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola C#");
            Console.WriteLine(" 5 + 7 = 12"+(5+7));
            Console.WriteLine("Fin");
            String c = Console.ReadLine();
            Console.WriteLine("dddd "+c);

            float pi = 3.14159633213232F;
            decimal dinero = 2656461815.32M;
            char letra = 'M';
            Boolean bandera = true;
            String cadena = "Programacion";
        }

        public void metodo()
        {
            byte num = 255;
            Console.Write("Byte " + num);
            Console.Read();
        }
    }
}
