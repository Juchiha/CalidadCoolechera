using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public class DataGridCalidaLeche
    {
        public DateTime dt_fechamuestra { get; set; }
        public string cd_codigoconsignante { get; set; }
        public string consignante { get; set; }
        public string cd_codigofinca{ get; set; }
        public string nombrefinca { get; set; }
        public double am_valorsolidostotales{ get; set; }
        public double am_valorunidadformadoracolonias { get; set; }

        public DataGridCalidaLeche() { }
       
    }
}
