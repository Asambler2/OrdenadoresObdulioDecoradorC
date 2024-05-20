using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenadoresObdulioDecoradorC.Ordenadores
{
    public class AVerSiCuela : IVendible
    {
        public float Precio { get; set; }
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }
        public IVendible Ordenador { get; set; }

        public AVerSiCuela(IVendible Ordenador)
        {
            this.Ordenador = Ordenador;
            this.RAM = Ordenador.RAM;
            this.Almacenamiento = Ordenador.Almacenamiento;
            this.Precio = Ordenador.Precio * 2;
        }

        public string mostrar()
        {
            return $"Ordenador[Precio: {this.Precio}, RAM: {this.RAM}, Almacenamiento: {this.Almacenamiento}]";
        }
    }
}
