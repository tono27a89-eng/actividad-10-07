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
            


                Console.WriteLine($"Ingrese  ID NO.{i + 1} de 3 productos");
                int.TryParse(Console.ReadLine(), out clave);
                if (producto.ContainsKey(clave))
                {
                    Console.WriteLine("valor ya ingresado ingrese otro");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    producto.Add(clave, nombre);

                }

            }
            foreach (var item in producto)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
