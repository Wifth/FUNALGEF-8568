using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class AlquilerUtil
    {
        public void CrearAlquiler(List<Alquiler> alquilers,)
        {
            Console.Write("\n********registro de alquileres********");
            Console.WriteLine("ingresar el nombre de cliente: ");
            string cliente = Console.ReadLine();
            Console.WriteLine("ingresar dni: ");
            string dni = Console.ReadLine();
            Console.WriteLine("ingresar pago maximo:  ");
            string pagomax = Console.ReadLine();
            Console.WriteLine("ingresar placa de carro");
            string placa = Console.ReadLine();
            Console.WriteLine("ingresar marca de carro");
            string marca = Console.ReadLine();
            Console.WriteLine("ingresar precio de alquiler";
            string palquiler = Console.ReadLine();
            alquileres.Add(new Alquiler { cliente = cliente, DNI = dni, PagoMaximo = pagomax, Placa = placa, Marca = marca, PrecioAlquiler = palquiler });
            Console.Clear();
            Console.WriteLine("\nRegistrado correctamente");
        }
    
        public void ListarAlquiler(List<Alquiler> alquileres)
        {
            Console.Clear();
            if (alquileres.Count == 0)
            {
                Console.WriteLine("NO HAY ALQUILERES REGISTRADOS");
            }
            else
            {
                Console.WriteLine("***********Lista de alquileres***********");
                for (int i = 0; i < alquileres.Count; i++)
                {
                    Console.WriteLine($"{i}: {alquileres}");
                }
            }
        }
        public static void CarrosAlquiler()
        {

        }
    }
}
