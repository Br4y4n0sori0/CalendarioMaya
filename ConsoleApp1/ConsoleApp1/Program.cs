using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader leerArchivo = new System.IO.StreamReader(@"C:\Users\Bryan\Documents\Grone\Universidad\2019-ll\Plataformas de programación empresarial\Prueba\prueba.txt");
            String linea, dia;
            //System.IO.StreamWriter sobreescribirArchivo = new System.IO.StreamWriter(@"C:\Users\Bryan\Documents\Grone\Universidad\2019-ll\Plataformas de programación empresarial\Prueba\prueba.txt");
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            int i = 0, dia0;
            try
            {
                linea = leerArchivo.ReadLine();

                while (linea != null)
                {
                    String[] division = linea.Split(' ');
                    linea = leerArchivo.ReadLine();
                    dia = division[0];
                    dia0 = dia[0] - '0';

                    HAAB temp = new HAAB(dia0, division[1], Int32.Parse(division[2]));
                    
                    Console.WriteLine(temp.Convertir());

                    //sobreescribirArchivo.WriteLine(temp.Convertir());
                    

                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Intente leer el archivo de nuevo");
            }
            Console.Read();

        }
        
    }

  
}
