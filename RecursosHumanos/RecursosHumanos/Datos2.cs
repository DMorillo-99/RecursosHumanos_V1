using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos
{
    class Datos2
    {
        public string fecha1 { get; set; }
        public string fecha2 { get; set; }
        public int montoTotal { get; set; }

        public int codigoEmpleado { get; set; }
        public string comentario { get; set; }
        public string año { get; set; }

        public string nombreEmpleado { get; set; }
        public string tipoSalida { get; set; }
        public string motivo { get; set; }


        public Datos2() { }

        public Datos2(string fecha1, string fecha2, int montoTotal, int codigoEmpleado, string comentario, string año, string nombreEmpleado, string tipoSalida, string motivo)
        {
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.montoTotal = montoTotal;
            this.codigoEmpleado = codigoEmpleado;
            this.comentario = comentario;
            this.año = año;
            this.nombreEmpleado = nombreEmpleado;
            this.tipoSalida = tipoSalida;
            this.motivo = motivo;
        }
    }
    

}
