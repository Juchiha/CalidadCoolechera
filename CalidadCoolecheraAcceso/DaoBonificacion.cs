using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalidadModelos.Modelos;
using Dapper;
using System.Data;

namespace CalidadCoolecheraAcceso
{
    public class DaoBonificacion
    {
        private ConexionBaseDatos pConexion;
        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoBonificacion(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoBonificacion(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<Bonificacion> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT am_rangoinferior, am_rangosuperior, am_pagobacterias, am_pagofrio FROM calidad.bonificacion";
            var bonificacion = pConexion.Conexion.Query<Bonificacion>(Lsql, transaction).ToList();
            return bonificacion;
        }

        public Bonificacion buscar(int am_rangoinferior, int am_rangosuperior , IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.bonificacion where am_rangoinferior = @am_rangoinferior and am_rangosuperior = @am_rangosuperior";
            var bonificacion = pConexion.Conexion.QueryFirst<Bonificacion>(strSQl, new { am_rangoinferior = am_rangoinferior, am_rangosuperior = am_rangosuperior }, transaction);
            return bonificacion;
        }

        public int Insertar(Bonificacion bonificacion, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.bonificacion(am_rangoinferior, am_rangosuperior, am_pagobacterias, am_pagofrio, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion, ds_programamodificacion) 
                           VALUES (@am_rangoinferior, @am_rangosuperior, @am_pagobacterias, @am_pagofrio, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion, @ds_programamodificacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, bonificacion, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(Bonificacion bonificacion, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.bonificacion SET am_rangoinferior = @am_rangoinferior, am_rangosuperior = @am_rangosuperior, am_pagobacterias = @am_pagobacterias, am_pagofrio = @am_pagofrio, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion  
                           WHERE am_rangoinferior = @am_rangoinferior and am_rangosuperior = @am_rangosuperior";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, bonificacion, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(Bonificacion bonificacion, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.bonificacion WHERE am_rangoinferior = @am_rangoinferior and am_rangosuperior = @am_rangosuperior";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, bonificacion, transaction);
            return nroFilasAfectadas;
        }

    }
}
