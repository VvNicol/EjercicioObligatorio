using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Obligatorio6.nrojlla.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("#############################");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Dar de alta cliente");
            Console.WriteLine("2. Ordenar lista");
            Console.WriteLine("#############################");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        
        }
    }
}
