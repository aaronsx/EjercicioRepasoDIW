using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso
{
    /**
     * Clase donde esta declarada las entidades.Atributos,Getters y setters
     * @author Aaron
     *
     */
    internal class Empleados
    {
        //---------Atribuetos-----------
        private int idEmpleado = 0;
        private string nombre="aaaaaa";
        private string apellidos = "aaaaaa";
        private string dni = "aaaaaa";
        private string fechaDeNacimiento = "aaaaaa";
        private string titulaciónMasAlta = "aaaaaa";
        private string nuSeguriSocial = "aaaaaa";
        private string nuCuenta = "aaaaaa";
        //--------Getters Y Setters---------
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string TitulaciónMasAlta { get => titulaciónMasAlta; set => titulaciónMasAlta = value; }
        public string NuSeguriSocial { get => nuSeguriSocial; set => nuSeguriSocial = value; }
        public string NuCuenta { get => nuCuenta; set => nuCuenta = value; }

         
        public String ToString()
        {
            return String.Format("{0};{1};{2};{3};{4};{5}", idEmpleado, nombre, apellidos, dni, fechaDeNacimiento,titulaciónMasAlta);
        }
    }
}
