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
       

        public void GestionarFichero(string ruta, List<Empleados> bd,int idEmpleado)
        {
            //Guarda en un txt la informacion elegida.
            try
            {
                StreamWriter sw = new StreamWriter(ruta,true);
                //Recorre toda la lista.
                foreach (Empleados emple in bd)
                {
                    //If segun la id que te pidan.
                    if (idEmpleado == emple.IdEmpleado)
                    {
                        sw.WriteLine(emple.ToString());
                        break;
                    }
                    else if(idEmpleado==0) 
                    {
                        sw.WriteLine(emple.ToString());
                    }

                }
                sw.Close();

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void PreparacionDeFichero(string ruta)
        {
            //Pregunta si existe la ruta y si no existe la crea
            if (!File.Exists(ruta))
                EscirbirEncabezado(ruta);
    
            else 
            {
                int contador = 0;
                StreamReader sr = new StreamReader(ruta);
                //Un contador para ver si esta escrito o no 
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine(); // Lee una línea del archivo y avanza al siguiente
                    contador++;
                }
                   
                
                if (contador == 0 || contador == 1)
                    EscirbirEncabezado(ruta);

                sr.Close();
            }

        }
        

        public void EscirbirEncabezado(string ruta)
        {
            //try para escrribir el encabezado
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
