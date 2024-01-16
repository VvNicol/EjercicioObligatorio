using edu.Obligatorio6.nrojlla.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Obligatorio6.nrojlla.Servicios
{
    internal interface ClienteInterface
    {
        void darAltaCliente(List<ClienteDto> listaAntigua);
        void OrdenarLista(List<ClienteDto> listCliente);
    }
}
