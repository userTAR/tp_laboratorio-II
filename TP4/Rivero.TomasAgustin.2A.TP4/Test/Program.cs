using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avion1 = new Avion("Cessna", "Centurion", 120, 50, 200000, 1, Avion.EPaso.Variable, 6, 17);
            Avion avion2 = new Avion("Socata TMB", "TMB850", 230, 65, 31000, 2, Avion.EPaso.Variable, 8, 20.8);
            Avion avion3 = new Avion("Pilatus", "PC12", 245, 58, 33000, 3, Avion.EPaso.Variable, 8, 19.8);
            Avion avion4 = new Avion("Cessna", "Centurion", 120, 50, 200000, 1, Avion.EPaso.Variable, 6, 17);

            Planeador planeador = new Planeador("Fighter", "A4", 40, 15000, 3, 24);
            Helicoptero helicoptero = new Helicoptero("McDonell Douglas", "MD500", 120, 550000, 4, 4, 27000);
            
            Deposito<Avion> listaAviones = new Deposito<Avion>();
            Deposito<Avion> retornoXml = new Deposito<Avion>();

            Console.WriteLine("Avion ToString:----");
            Console.WriteLine(avion1.ToString());

            if (avion1 == avion4)
                Console.WriteLine("AVION 1 Y 4 SON IGUALES");

            Console.WriteLine("Planeador ToString:----");
            Console.WriteLine(planeador.ToString());

            Console.WriteLine("Helicoptero ToString:----");
            Console.WriteLine(helicoptero.ToString());


            Console.WriteLine("---------------------------");
            Console.WriteLine("DEPOSITO:----");
            
            
            listaAviones += avion1;
            listaAviones += avion1;
            listaAviones += avion2;
            Console.WriteLine(listaAviones.ToString()); // debería mostrar solo una vez el avion1 y solo una vez el avion 2

            listaAviones -= avion2;
            listaAviones -= avion3; //no debería hacer nada ya que avion3 no se encuentra en la lista
            Console.WriteLine(listaAviones.ToString()); // debería mostrar solo una vez el avion1 ya que se elimina el avion2 de la lista

            if (Xml.GuardarXml(listaAviones))
                Console.WriteLine("ARCHIVO XML GUARDADO");
            else
                Console.WriteLine("ARCHIVO XML NO GUARDADO");

            if (Xml.LeerXml(out retornoXml))
                Console.WriteLine(retornoXml.ToString());
            else
                Console.WriteLine("EL ARCHIVO NO SE PUDO LEER");


            Console.ReadKey();
        }
    }
}
