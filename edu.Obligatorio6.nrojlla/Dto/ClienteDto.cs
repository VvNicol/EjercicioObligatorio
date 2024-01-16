using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Obligatorio6.nrojlla.Dto
{
    internal class ClienteDto
    {
        long idCliente = 0000;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        int edad = 0000;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.edad = edad;
            this.nombreCompletoCliente = nombreCliente + apellidosCliente;
        }

        public ClienteDto() { }

        override

        public string ToString ()
        {
            string clienteTexto = "Cliente : " + this.nombreCompletoCliente + 
                                  " Edad: " + this.edad;

            return clienteTexto;
        }

        internal void ActualizarNombreCompleto()
        {
            NombreCompletoCliente = $"{NombreCliente} {ApellidosCliente}";
        }

    }
}
