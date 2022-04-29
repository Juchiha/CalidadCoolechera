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

        public int am_valorfriovoluntario { get; set; }


        public Bonificacion()
        {

        }

    }
}
