using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public  class DataGridPeriodo
    {
        public string ds_periodoliquidacion { get; set; }
        public int am_numeroliquidacion { get; set; }
        public string ds_estadoperiodocda { get; set; }
        public string ds_estadoperiodoasociado { get; set; }

        public DataGridPeriodo() { }
    }
}
