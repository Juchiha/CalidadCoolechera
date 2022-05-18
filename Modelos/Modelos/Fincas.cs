using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public  class Finca
    {
        public string codfinca { get; set; }
        public string nombre { get; set; }
        public string codconsignante { get; set; }
        public string codruta { get; set; }
        public string codplanta { get; set; }
        public string codfincaasociada { get; set; }
        public string usuario { get; set; }
        public DateTime fechamod { get; set; }
        public string estadoreg { get; set; }

        public string codigosap { get; set; }
        public Finca() { }
       
    }
}
