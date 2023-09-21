using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso
{
    internal interface IntRegistro
    {

        /**
        * Método para registrar a un empleado.
        * @param Una lista Empleado
        * @return 
        */
        void RegistrarEmpleado(List<Empleados> bd);
        /**
         * Método para modicar un empleado.
         * @param Una lista Empleado.
         * @return 
         */
        void ModificarEmpleado(List<Empleados> bd);
        /**
         * Método para guardar en un fichero.
         * @param Una lista Empleado y un string (ruta del archivo).
         * @return 
         */
        void GuardarEnFichero(List<Empleados> bd, string archivo);

    }
}
