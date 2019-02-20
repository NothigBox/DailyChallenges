using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantContactos = int.Parse(Console.ReadLine());
            string[] datosContactos = new string[cantContactos];
            string dato = "", nombre = "";
            IDictionary<string, int> contactos = new Dictionary<string, int>();

            for (int a = 0; a < datosContactos.Length; a++) datosContactos[a] = Console.ReadLine();

            for (int i = 0; i < cantContactos; i++)
            {
                for(int h = 0; h < datosContactos[i].Length; h++)
                {
                    if (datosContactos[i][h] != ' ') dato += datosContactos[i][h];
                    else
                    {
                        nombre = dato;
                        dato = "";
                    }
                }
                contactos.Add(nombre,int.Parse(dato));
                dato = "";
            }


            for (int b = 0; b < contactos.Count;b++)
            {
                Console.WriteLine(contactos.ElementAt(b));
            }
            
        }
    }
}
