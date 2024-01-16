using edu.Obligatorio6.nrojlla.Dto;
using edu.Obligatorio6.nrojlla.Servicios;

namespace edu.Obligatorio6.nrojlla.Controlador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listCliente = new List<ClienteDto>();

            MenuInterface mi = new MenuImplementacion();
            ClienteInterface ci = new ClienteImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {

                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("El menu se ha cerrado");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("# Ha seleccionado la opcion 1");
                        ci.darAltaCliente(listCliente);

                        break;
                    case 2:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("# Ha seleccionado la opcion 2");
                        
                        if (listCliente.Count >= 3)
                        {

                            Console.WriteLine("# Lista de clientes");
                            foreach (ClienteDto cc in listCliente)
                            {
                                Console.WriteLine(cc.ToString());
                            }
                            Console.WriteLine("# Lista de clientes ordenado por burbuja");

                            ci.OrdenarLista(listCliente);
                            foreach (ClienteDto cc in listCliente)
                            {
                                Console.WriteLine(cc.ToString());
                            }


                        }
                        else
                        {
                            Console.WriteLine("# Minimo 3 clientes para ordenar");
                        }


                        break;
                    case 3:  

                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}