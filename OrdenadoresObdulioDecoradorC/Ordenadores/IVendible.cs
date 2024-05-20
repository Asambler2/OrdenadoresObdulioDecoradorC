using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenadoresObdulioDecoradorC.Ordenadores
{
    public interface IVendible
    {
        public float Precio {  get; set; }
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }
        public string mostrar();
    }
}
