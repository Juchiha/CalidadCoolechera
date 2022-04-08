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
            var Lsql = "SELECT * FROM bonificacion";
            var bonificacion = pConexion.Conexion.Query<Bonificacion>(Lsql, transaction).ToList();
            return bonificacion;
        }

        public Bonificacion buscar(string bo_codigo, IDbTransaction transaction = null)
        {
            var strSQl = "select * from bonificacion where bo_codigo = @bo_codigo";
            var bonificacion = pConexion.Conexion.QueryFirst<Bonificacion>(strSQl, new { bo_codigo = bo_codigo }, transaction);
            return bonificacion;
        }

        public int Insertar(Bonificacion bonificacion, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO bonificacion(bo_codigo, am_rangoinferior, am_rangosuperior, am_pagobacterias, am_pagofrio, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion) 
                           VALUES (@bo_codigo, @am_rangoinferior, @am_rangosuperior, @am_pagobacterias, @am_pagofrio, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, bonificacion, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(Bonificacion bonificacion, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE bonificacion SET am_rangoinferior = @am_rangoinferior, am_rangosuperior = @am_rangosuperior, am_pagobacterias = @am_pagobacterias, am_pagofrio = @am_pagofrio, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion  
                           WHERE bo_codigo= @bo_codigo";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, bonificacion, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(Bonificacion bonificacion, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM bonificacion WHERE bo_codigo = @bo_codigo";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, bonificacion, transaction);
            return nroFilasAfectadas;
        }

    }
}
