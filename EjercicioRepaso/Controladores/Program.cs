using EjercicioRepaso.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IntUtilsMenu menu = new ImpUtilsMenu();
            IntRegistro emple = new ImpRegistro();
            IntFichero fichero = new ImpFichero();
            List<Empleados> bd = new List<Empleados>();
            string archivo = "C:\\Users\\Sturt\\OneDrive\\Escritorio\\Programas\\txt.txt";
            bool cerrarMenu = false;
            //Se guarda la ruta del fichero y lo guarda en un File llamado archivo
           
            //LLama para la preparacion de los ficheros
            fichero.PreparacionDeFichero(archivo);
            int opcion = 0;



            while (!cerrarMenu)
            {
                try
                {
                    
                    //Mostramos el menú
                    menu.Menu();
                    Console.WriteLine("Introduza la opción deseada: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion >= 0 && opcion <= 3)
                    {
                        Console.WriteLine("[INFO] - Has seleccionado la opcion " + opcion);
                    }
                    //Segun la opcion de hace llama a registrar empleado, modificar empleado y guardar en fichero
                    switch (opcion)
                    {
                        case 1:

                            emple.RegistrarEmpleado(bd);
                            break;

                        case 2:
                            emple.ModificarEmpleado(bd);
                            break;

                        case 3:
                            emple.GuardarEnFichero(bd, archivo);
                            break;


                        case 0:
                            Console.WriteLine("¡Gracias por visitar nuestra Empresa!");
                            cerrarMenu = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("***ERROR***Se ha surgido otro error");
                            Console.ResetColor();
                            break;
                    }
                }catch (Exception )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***ERROR***Se ha surgido otro error");
                    Console.ResetColor();
                   

                }

            }


        }
    }
}
