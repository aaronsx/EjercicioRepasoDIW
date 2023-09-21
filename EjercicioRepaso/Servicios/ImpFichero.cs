using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioRepaso.Servicios
{
    internal class ImpFichero : IntFichero
    {
       

        public void GestionarFichero(string ruta, List<Empleados> bd)
        {
            
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                foreach (Empleados item in bd) 
                    sw.WriteLine(item.ToString());
    
                sw.Close();

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void PreparacionDeFichero(string ruta)
        {
            if (!File.Exists(ruta))
                EscirbirEncabezado(ruta);
    
            else 
            {
                int contador = 0;
                StreamReader sr = new StreamReader(ruta);
                
                while (!sr.EndOfStream)   
                    contador++; 
                
                if (contador == 0 || contador == 1)
                    EscirbirEncabezado(ruta);
            }
        }
        

        public void EscirbirEncabezado(string ruta)
        {
            
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                sw.WriteLine("Id Empleado;Nombre;Apellidos;Dni;Titulación más alta");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
           
           

        }

        
    }
}
