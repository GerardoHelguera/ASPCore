using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class MaestrosModel
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_M { get; set; }
        public DateTime Hora_Entrada { get; set; }
        public DateTime Hora_Salida { get; set; }
    }
}
