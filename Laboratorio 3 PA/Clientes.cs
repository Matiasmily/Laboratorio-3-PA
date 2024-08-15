using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_PA
{
    public class Clientes
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Clientes(string nombre, string correo, string telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }
        public Clientes (List <Clientes> ListaClientes) { }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("--- RESTAURANTE ---");
            Console.WriteLine("1. Registrar Clientes");
            Console.WriteLine("2. Registrar Reservas");
            Console.WriteLine("3. Mostrar Detalles de Clientes y Reservas");
            Console.WriteLine("4. Buscar Cliente o Reserva");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void MenuClientes()
        {
            Console.Clear();
            Console.WriteLine("--- CLIENTES ---");
            Console.WriteLine("1. Cliente Regular");
            Console.WriteLine("2. Cliente VIP");
            Console.WriteLine("3. Regresar al menú anterior");
            Console.Write("Ingrese una opción: ");
        }
        public void Enter()
        {
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
        }
       
        public void RegistrarCliente(List<Clientes> ListaClientes)
        {
            Console.WriteLine("--- REGISTRAR CLIENTES ---");
            MenuClientes();
            string nombre, correo, telefono;
            int opcionClientes = int.Parse(Console.ReadLine() ?? "");
            bool menuClientes = true;
            do
            {
                try
                {
                    switch(opcionClientes)
                    {
                        case 1:
                            Console.Clear ();
                            Console.WriteLine("--- CLIENTE REGULAR ---");
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine()??"";
                            Console.Write("Correo: ");
                            correo = Console.ReadLine() ?? "";
                            Console.Write("Número de Teléfono: ");
                            telefono = Console.ReadLine() ?? "";
                            Cliente_Regular nuevoClienteRegular = new Cliente_Regular(nombre, correo, telefono);
                            Console.WriteLine("\nCliente Agregado");
                            Enter();
                            menuClientes = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("--- CLIENTE VIP ---");
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine() ?? "";
                            Console.Write("Correo: ");
                            correo = Console.ReadLine() ?? "";
                            Console.Write("Número de Teléfono: ");
                            telefono = Console.ReadLine() ?? "";
                            Cliente_VIP nuevoClienteVip = new Cliente_VIP(nombre, correo, telefono);
                            Console.WriteLine("\nCliente Agregado");
                            Enter();
                            menuClientes = false;
                            break;
                        case 3:
                            Console.WriteLine("\nUsted está regresando al menú anterior...");
                            Enter();
                            menuClientes = false;
                            break;
                        default:
                            Console.WriteLine("\nIngrese una opción válida");
                            menuClientes = false;
                            Enter();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Ingrese una opción válida..");
                    Enter();
                }
            } while (menuClientes);
        }
    }
}
