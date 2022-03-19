using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EscribirDocumento();
            AgregarTexto();
            //Leer del documento
            LeerDocumento();
            Console.ReadKey();

        }

       public static void AgregarTexto()
        {
            StreamWriter fichero;
            string nombreFichero = "C:\\Users\\cesar\\Documents\\POO2\\prubea.txt";
            fichero = File.AppendText(nombreFichero);
            fichero.WriteLine();
            fichero.WriteLine("Nueva linea");
            fichero.Close();
        }

        public static void LeerDocumento()
        {
            //Clase que representa un fichero
            StreamReader fichero;
            //Ruta y nombre del fichero
            string nombreFichero = "C:\\Users\\cesar\\Documents\\POO2\\prubea.txt";
            string linea;
            //Abrimos el documento
            fichero = File.OpenText(nombreFichero);
            do
            {
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
            } while (linea != null);
            fichero.Close();
            Console.ReadKey();
        }

        public static void EscribirDocumento()
        {
            //Clase que representa un fichero
            StreamWriter fichero;
            //Establecemos la ruta y nombre del fichero
            string nombreFichero = "C:\\Users\\cesar\\Documents\\POO2\\prubea.txt";
            //Crear fichero
            fichero = File.CreateText(nombreFichero);
            fichero.WriteLine("Esto es una linea");
            fichero.WriteLine("Fin del documento");
            fichero.Close();
        }
    }
}
