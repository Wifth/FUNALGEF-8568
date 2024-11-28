using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class AlquilerUtil
    {
        public void CrearAlquiler(List<Alquiler> alquileres)
        {
            Console.Write("\n********registro de alquileres********");
            Console.WriteLine("Ingresar el nombre de cliente: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar dni: ");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingresar pago maximo: ");
            string pagomaximo = Console.ReadLine();
            Console.WriteLine("Ingresar placa de carro");
            string placa = Console.ReadLine();
            Console.WriteLine("Ingresar marca de carro");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingresar precio de alquiler");
            string precio = Console.ReadLine();
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
        public void CarrosAlquiler()
        {
            Console.WriteLine("agregar cliente: ");
            string cliente = Console.ReadLine();
        }
    }
}
