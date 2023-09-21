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
        public void MenuGuardar()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t╔════════════════════════════════════╗");
            Console.WriteLine("\t\t║         Guardar en fichero         ║");
            Console.WriteLine("\t\t╠════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   1) Guardar un empleado           ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║   2) Guardar todo los empleado     ║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║____________________________________║");
            Console.WriteLine("\t\t║                                    ║");
            Console.WriteLine("\t\t║           0) Salir                 ║");
            Console.WriteLine("\t\t╚════════════════════════════════════╝");
        }
    }
}
