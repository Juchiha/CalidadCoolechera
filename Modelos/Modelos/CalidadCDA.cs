using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
    public class CalidadCDA
    {
		public int cd_codigocda { get; set; }
		public string ds_periodoliquidacion { get; set; }
		public int am_numeroliquidacion { get; set; }
		public int am_valorsolidostotales { get; set; }
		public int am_valorunidadformadoracolonias { get; set; }
		public string ds_usuariocreacion { get; set; }
		public string ds_equipocreacion { get; set; }
		public string dt_fechacreacion { get; set; }
		public string ds_programacreacion { get; set; }
		public string ds_usuariomodificacion { get; set; }
		public string ds_equipomodificacion { get; set; }
		public string dt_fechamodificacion { get; set; }
		public string ds_programamodificacion { get; set; }
		public CalidadCDA()
        {

        }

        public CalidadCDA(int cd_codigocda, string ds_periodoliquidacion, int am_numeroliquidacion, int am_valorsolidostotales, int am_valorunidadformadoracolonias, string ds_usuariocreacion, string ds_equipocreacion, string dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, string dt_fechamodificacion, string ds_programamodificacion)
        {
            this.cd_codigocda = cd_codigocda;
            this.ds_periodoliquidacion = ds_periodoliquidacion;
            this.am_numeroliquidacion = am_numeroliquidacion;
            this.am_valorsolidostotales = am_valorsolidostotales;
            this.am_valorunidadformadoracolonias = am_valorunidadformadoracolonias;
            this.ds_usuariocreacion = ds_usuariocreacion;
            this.ds_equipocreacion = ds_equipocreacion;
            this.dt_fechacreacion = dt_fechacreacion;
            this.ds_programacreacion = ds_programacreacion;
            this.ds_usuariomodificacion = ds_usuariomodificacion;
            this.ds_equipomodificacion = ds_equipomodificacion;
            this.dt_fechamodificacion = dt_fechamodificacion;
            this.ds_programamodificacion = ds_programamodificacion;
        }
    }
}
