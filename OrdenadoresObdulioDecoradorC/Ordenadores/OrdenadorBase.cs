using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenadoresObdulioDecoradorC.Ordenadores
{
    internal class OrdenadorBase : IVendible
    {
        public float Precio { get; set; } = 100;
        public int RAM { get; set; } = 10;
        public int Almacenamiento { get; set; } = 100;

        public string mostrar()
        {
            return $"Ordenador[Precio: {this.Precio}, RAM: {this.RAM}, Almacenamiento: {this.Almacenamiento}]"; ;
        }
    }
}
