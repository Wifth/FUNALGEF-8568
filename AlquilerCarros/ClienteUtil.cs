using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class ClienteUtil
    {
        private static List<Cliente> Cliente = new List<Cliente>();
        public static void CrearCliente()
        {
            Cliente nuevoCliente = new Cliente(DNI, Nombre, PagoMaximo);
            clientes.Add(nuevoCliente);
            Console.WriteLine($"Cliente{Nombre} creado con éxito.");
        }
        public static void ListarCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en este sistema.");
                return;
            }
            Console.WriteLine("Listado de clientes: ");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"DNI: {cliente.Dni}, Nombre: {cliente.Nombre}, PagoMaximo: {cliente.PagoMaximo}");
            }
        }
        public static void EliminarCliente()
        {
            bool clienteEliminado = false;

            for (int i = 0; i < Cliente.Count; i++)
            {
                clientes.RemoveAt(i);
                clienteEliminado = true;
                Console.WriteLine($"Cliente con DNI {Dni} fue eliminado del sistema");
                break;
            }
            if (int !clienteEliminado) {
                Console.WriteLine($"No se encontró el cliente con el siguiente DNI {Dni}");
            }
        }
    }
}
