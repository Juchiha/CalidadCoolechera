using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadModelos.Modelos
{
    public class Bonificacion
    {   
        public int am_rangoinferior { get; set; }
		public int am_rangosuperior { get; set; }
		public int am_pagobacterias { get; set; }
		public int am_pagofrio { get; set; }
		public string ds_usuariocreacion { get; set; }
		public string ds_equipocreacion { get; set; }
		public DateTime dt_fechacreacion { get; set; }
		public string ds_programacreacion { get; set; }
		public string ds_usuariomodificacion { get; set; }
		public string ds_equipomodificacion { get; set; }
		public DateTime dt_fechamodificacion { get; set; }
		public string ds_programamodificacion { get; set; }

		public Bonificacion()
        {

        }

        public Bonificacion(int am_rangoinferior, int am_rangosuperior, int am_pagobacterias, int am_pagofrio, string ds_usuariocreacion, string ds_equipocreacion, DateTime dt_fechacreacion, string ds_programacreacion, string ds_usuariomodificacion, string ds_equipomodificacion, DateTime dt_fechamodificacion, string ds_programamodificacion)
        {
            this.am_rangoinferior = am_rangoinferior;
            this.am_rangosuperior = am_rangosuperior;
            this.am_pagobacterias = am_pagobacterias;
            this.am_pagofrio = am_pagofrio;
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
