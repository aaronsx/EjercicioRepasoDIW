using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal class ImpUtilsMenu : IntUtilsMenu
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t╔════════════════════════════════════╗");
            Console.WriteLine("\t\t║           Siiiiiiiiiiiiii          ║");
            Console.WriteLine("\t\t╠════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   1) Registrar empleado            ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   2) Modificar empleado            ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   3) Exportar empleado a fichero   ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║____________________________________║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║           0) Salir                 ║");
            Console.WriteLine("\t\t╚════════════════════════════════════╝");
        }
        public void MenuEditar()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t╔════════════════════════════════════╗");
            Console.WriteLine("\t\t║         Guardar en fichero         ║");
            Console.WriteLine("\t\t╠════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   1) Nombre                        ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   2) Apellido                      ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   3) Dni                           ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   4) Fecha de nacimiento           ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   5) Titulacion mas alta           ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   6) Numero de la seguirdad social ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   7) Numero de cuenta              ║");
            Console.WriteLine("\t\t║____________________________________║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║           0) Salir                 ║");
            Console.WriteLine("\t\t╚════════════════════════════════════╝");
        }
    }
}
