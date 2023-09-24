using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal class ImpRegistro : IntRegistro
    {
        
        public void RegistrarEmpleado(List<Empleados> bd)
        {
          
            Empleados empleado = new Empleados();

            try
            {
                empleado.IdEmpleado=calculoId(bd);

                Console.WriteLine("Introduce el nombre del usuarios.");
                empleado.Nombre = Console.ReadLine();

                Console.WriteLine("Introduce el apellido del usuarios.");
                empleado.Apellidos = Console.ReadLine();

                Console.WriteLine("Introduce el dni del usuarios.");
                empleado.Dni = Console.ReadLine();

                Console.WriteLine("Introduce la fecha de nacimiento del usuarios.");
                empleado.FechaDeNacimiento = Console.ReadLine();

                Console.WriteLine("Introduce la titulación mas alta del usuarios.");
                empleado.TitulaciónMasAlta = Console.ReadLine();

                Console.WriteLine("Introduce el numero de la seguirdad social del usuarios.");
                empleado.NuSeguriSocial = Console.ReadLine();

                Console.WriteLine("Introduce el numero de cuenta del usuarios.");
                empleado.NuCuenta = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***ERROR***No se guardo correctamente.");
                Console.ResetColor();

            }

            bd.Add(empleado);
        }

        public void ModificarEmpleado(List<Empleados> bd)
        {
            IntUtilsMenu menu = new ImpUtilsMenu();
            bool encontrado = false;
            Console.WriteLine("Que id quieres editar:");
            foreach (Empleados empleado in bd)
            {
                 Console.WriteLine(empleado.IdEmpleado);
            }
            do
            {
                int buscarid = Convert.ToInt32(Console.ReadLine());


                foreach (Empleados emple in bd)
                {

                    if (buscarid == emple.IdEmpleado)
                    {


                        //Si encuentra la id te pregunta si quieres editar todo o por partes
                        if (MetodoSiono("Quieres editar todo el usuario Si/NO"))
                        {
                            try
                            {
                                Console.WriteLine("Introduce el nombre del usuarios.");
                                emple.Nombre=Console.ReadLine();

                                Console.WriteLine("Introduce el apellido del usuarios.");
                                emple.Apellidos= Console.ReadLine();

                                 Console.WriteLine("Introduce el dni del usuarios.");
                                emple.Dni= Console.ReadLine();

                                 Console.WriteLine("Introduce la fecha de nacimiento del usuarios.");
                                emple.FechaDeNacimiento = Console.ReadLine();

                                 Console.WriteLine("Introduce la titulación mas alta del usuarios.");
                                emple.TitulaciónMasAlta = Console.ReadLine();

                                 Console.WriteLine("Introduce el numero de la seguirdad social del usuarios.");
                                emple.NuSeguriSocial = Console.ReadLine();

                                 Console.WriteLine("Introduce el numero de cuenta del usuarios.");
                                emple.NuCuenta = Console.ReadLine();

                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("***ERROR***No se guardo correctamente.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            try
                            {
                                menu.MenuEditar();
                                bool cerrarmenu = false;
                                do
                                {
                                    int opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            Console.WriteLine("Introduce el nombre del usuarios.");
                                            emple.Nombre = Console.ReadLine();
                                            break;
                                        case 2:
                                            Console.WriteLine("Introduce el apellido del usuarios.");
                                            emple.Apellidos = Console.ReadLine();
                                            break;
                                        case 3:
                                            Console.WriteLine("Introduce el dni del usuarios.");
                                            emple.Dni = Console.ReadLine();
                                            break;
                                        case 4:
                                            Console.WriteLine("Introduce la fecha de nacimiento del usuarios.");
                                            emple.FechaDeNacimiento = Console.ReadLine();
                                            break;
                                        case 5:
                                            Console.WriteLine("Introduce la titulación mas alta del usuarios.");
                                            emple.TitulaciónMasAlta = Console.ReadLine();
                                            break;
                                        case 6:
                                            Console.WriteLine("Introduce el numero de la seguirdad social del usuarios.");
                                            emple.NuSeguriSocial = Console.ReadLine();
                                            break;
                                        case 7:
                                            Console.WriteLine("Introduce el numero de cuenta del usuarios.");
                                            emple.NuCuenta = Console.ReadLine();
                                            break;
                                        case 0:
                                            cerrarmenu = true;
                                            break;
                                        default:
                                            Console.WriteLine("Porfavor elige un numero");
                                            break;
                                    }
                                } while (cerrarmenu);
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("***ERROR***No se guardo correctamente.");
                                Console.ResetColor();
                          
                            }
                        }

                        encontrado = true;
                        break;
                    }

                }
                if (!encontrado)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontro ningun empleado con ese id");
                    Console.ResetColor();
                }
                    

            } while (!encontrado);
        }

        public void GuardarEnFichero(List<Empleados> bd, string archivo)
        {
            int IdParaGuardar = 0;
            
            IntFichero fichero = new ImpFichero();
            //Si la persona le da que no entra en if.
            try
            {
                if (!MetodoSiono("¿Quieres guardar todo los usuarios?"))
                {
                    Console.WriteLine("╔════════════════════════════════════╗");
                    Console.WriteLine("║       Que id Quieres guardar       ║");
                    Console.WriteLine("╠════════════════════════════════════╣");
                    //Bucle para imprimir por pantalla toda la lista.
                    foreach (Empleados empleado in bd)
                    {
                        Console.WriteLine("║                                    ║");
                       if(empleado.IdEmpleado <=10)
                            Console.WriteLine("║               {0}                    ║", empleado.IdEmpleado);
                       else
                            Console.WriteLine("║               {0}                     ║", empleado.IdEmpleado);

                    }
                    Console.WriteLine("╚════════════════════════════════════╝");
                    //Pregunta que id quieres modificar.
                    IdParaGuardar = Convert.ToInt32(Console.ReadLine());
                    fichero.GestionarFichero(archivo, bd, IdParaGuardar);
                }
                else
                    fichero.GestionarFichero(archivo, bd, IdParaGuardar);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***ERROR***No se guardo correctamente.");
                Console.ResetColor();
            }
        }
        /**
	     * Método para calcular una id segun el tamaño de la lista.
	     * @param Una lista empleados.
	     * @return devuelve la id del empleado.
	     */
        private int calculoId(List<Empleados> bdAntigua)
        {
            //Calculamos ids
            int auxiliar = 0;
            for (int i = 0; i < bdAntigua.Count; i++)
            {
                int j = bdAntigua[i].IdEmpleado ;
                if (auxiliar < j)
                {
                    auxiliar = j;
                }
            }
            return auxiliar + 1;
        }
        /**
         * Método Preguntar si quieres hacer una interaccion o no.
         * @param dos string uno para hacer la pregunta y captura la respuesta.
         * @return devuelve un boolean.
         */
        private bool MetodoSiono(String txt)
        {

            String sioNo;
            bool cerrarmenu = true; // Declarar cerrarmenu antes de usarlo
            do
            {
                Console.WriteLine(txt);
                sioNo =Console.ReadLine().ToLower();

                switch (sioNo)
                {
                    case "si":
                        return true;
                    case "no":
                        return false;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("***ERROR*** solo se puede si o no.");
                        Console.ResetColor();
                        cerrarmenu = false;
                        break;// Agregar break para salir del switch después del mensaje de error
                }
            

            } while (!cerrarmenu);
            return true;

        }
    }
}
