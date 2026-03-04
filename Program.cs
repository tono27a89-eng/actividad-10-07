using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10__07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un diccionario de productos. Antes de agregar un producto, verifique con ContainsKey si la clave ya existe.");
            
            Dictionary<int,string> producto = new Dictionary<int,string>();
            int clave;
            string nombre;
                Console.WriteLine($"Ingrese  ID de productos");
                int.TryParse(Console.ReadLine(), out clave);
                 Console.WriteLine("ingrese nombre:");
                 nombre = Console.ReadLine();
                 producto.Add(clave, nombre);
           bool valiadar= false;
            while (valiadar != true)
            {
                Console.WriteLine($"Ingrese  ID de productos");
                int.TryParse(Console.ReadLine(), out clave);
                if (producto.ContainsKey(clave))
                {
                    Console.WriteLine("valor ya ingresado ingrese otro");

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    producto.Add(clave, nombre);
                    valiadar = true;

                }
            }
            
            foreach (var item in producto)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
