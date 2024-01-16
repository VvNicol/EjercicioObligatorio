using edu.Obligatorio6.nrojlla.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Obligatorio6.nrojlla.Servicios
{
    internal class ClienteImplementacion : ClienteInterface
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto clienteDto = NuevoCliente();

            listaAntigua.Add(clienteDto);

        }


        public void OrdenarLista(List<ClienteDto> listCliente)
        {
            
            int n = listCliente.Count;
            // El bucle externo recorre toda la lista
            for (int i = 0; i < n - 1; i++)
            {
                // El bucle interno compara y realiza intercambios si es necesario
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Compara las edades de los clientes en las posiciones j y j+1
                    if (listCliente[j].Edad < listCliente[j + 1].Edad)
                    {                       
                        ClienteDto temp = listCliente[j];
                        listCliente[j] = listCliente[j + 1];
                        listCliente[j + 1] = temp;
                    }
                }
            }
        }

        private ClienteDto NuevoCliente()
        {
            ClienteDto clienteNuevo = new ClienteDto();

            Console.WriteLine("Ingrese: Nombre ");
            clienteNuevo.NombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese: Apellidos ");
            clienteNuevo.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Ingrese: ID ");
            clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ingrese: Edad");
            clienteNuevo.Edad = Convert.ToInt32(Console.ReadLine());


            clienteNuevo.ActualizarNombreCompleto();

            return clienteNuevo;
        }


    }
}
