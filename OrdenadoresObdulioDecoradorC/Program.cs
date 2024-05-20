
using OrdenadoresObdulioDecoradorC.Ordenadores;

IVendible OrdenadorManolo = new OrdenadorBase();
Console.WriteLine("MANOLO:" + OrdenadorManolo.mostrar());

IVendible OrdenadorAna = new RAMMaxima(new OrdenadorBase());
Console.WriteLine("ANA:" + OrdenadorAna.mostrar());

IVendible OrdenadorLuisa = new DiscoSolido(new RAMMaxima(new OrdenadorBase()));
Console.WriteLine("LUISA:" + OrdenadorLuisa.mostrar());

IVendible OrdenadorGeronimo = new AVerSiCuela(new DiscoSolido(new OrdenadorBase()));
Console.WriteLine("GERONIMO:" + OrdenadorGeronimo.mostrar());