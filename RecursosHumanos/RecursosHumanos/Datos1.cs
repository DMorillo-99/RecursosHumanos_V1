using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos
{
    class Datos1
    {
        public int codigoEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string apellidoEmpleado { get; set; }
        public string telefonoEmpleado { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public string fechaIngreso { get; set; }
        public int salario { get; set; }
        public string estatus { get; set; }

        public string codigoDepartamento { get; set; }
        public string nombreDepartamento { get; set; }
        public string encargado { get; set; }

        public int codigoCargo { get; set; }
        public string nombrecargo { get; set; }

        public Datos1() { }


        public Datos1(int codigoEmpleado, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string departamento, string cargo, string fechaIngreso, int salario, string estatus, string codigoDepartamento, string nombreDepartamento, string encargado, int codigoCargo, string nombrecargo)
        {
            this.codigoEmpleado = codigoEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.apellidoEmpleado = apellidoEmpleado;
            this.telefonoEmpleado = telefonoEmpleado;
            this.departamento = departamento;
            this.cargo = cargo;
            this.fechaIngreso = fechaIngreso;
            this.salario = salario;
            this.estatus = estatus;

            this.codigoDepartamento = codigoDepartamento;
            this.nombreDepartamento = nombreDepartamento;
            this.encargado = encargado;

            this.codigoCargo = codigoCargo;
            this.nombrecargo = nombrecargo;
        }
    }
}
