using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
    public class Periodo
    {
        public string ds_periodoliquidacion { get; set; }
        public int am_numeroliquidacion { get; set; }
        public string ds_estadoperiodocda { get; set;}
        public string ds_usuariocreacion { get; set; }
        public string ds_equipocreacion { get; set;}
        public DateTime dt_fechacreacion { get; set;}
        public string ds_programacreacion { get; set;}  
        public string ds_usuariomodificacion { get; set;  }
        public string ds_equipomodificacion { get; set; }
        public DateTime dt_fechamodificacion { get; set; }
        public string ds_programamodificacion { get; set; }
        public string ds_estadoperiodoasociado { get; set; }
        public Periodo()
        {

        }

        public Periodo(string ds_periodoliquidacion, int am_numeroliquidacion, string ds_estadoperiodocda, string ds_usuariocreacion, string ds_equipocreacion, DateTime dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, DateTime dt_fechamodificacion, string ds_programamodificacion, string ds_estadoperiodoasociado)
        {
            this.ds_periodoliquidacion = ds_periodoliquidacion;
            this.am_numeroliquidacion = am_numeroliquidacion;
            this.ds_estadoperiodocda = ds_estadoperiodocda;
            this.ds_usuariocreacion = ds_usuariocreacion;
            this.ds_equipocreacion = ds_equipocreacion;
            this.dt_fechacreacion = dt_fechacreacion;
            this.ds_programacreacion = ds_programacreacion;
            this.ds_usuariomodificacion = ds_usuariomodificacion;
            this.ds_equipomodificacion = ds_equipomodificacion;
            this.dt_fechamodificacion = dt_fechamodificacion;
            this.ds_programamodificacion = ds_programamodificacion;
            this.ds_estadoperiodoasociado = ds_estadoperiodoasociado;
        }
    }
}
