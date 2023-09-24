using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso
{
    /**
     * Interfas donde va la cabezara de la gestion de ficheros.
     * @author Aaron
     *
     */
    internal interface IntFichero
    {
        /**
	     * Método Escribir en fichero
	     * @param Un string (ruta del archivo), una lista y un numero.
	     * 
	     */
        void GestionarFichero(string ruta, List<Empleados> bd, int num);


        /**
         * Método comprobar si el fichero existe o no.
         * @param Un string (ruta del archivo).
         * 
         */
        void PreparacionDeFichero(string ruta);
        /**
        * Método escribir el encabezado del fichero.
        * @param Un string (ruta del archivo).
        * 
        */
        void EscirbirEncabezado(string ruta);
        
    }
}
