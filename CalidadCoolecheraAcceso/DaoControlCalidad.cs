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
    public class DaoControlCalidad
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoControlCalidad(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoControlCalidad(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<ControlCalidad> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM control_calidad";
            var calidad_cda = pConexion.Conexion.Query<ControlCalidad>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public ControlCalidad buscar(string ds_codigo, IDbTransaction transaction = null)
        {
            var strSQl = "select * from control_calidad where ds_codigo = @ds_codigo";
            var Calidad_Leche = pConexion.Conexion.QueryFirst<ControlCalidad>(strSQl, new { ds_codigo = ds_codigo }, transaction);
            return Calidad_Leche;
        }

        public int Insertar(ControlCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO control_calidad(ds_codigo, ds_periodoliquidacion, am_numeroliquidacion, ds_estadoliquidacion, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion) 
                           VALUES (@ds_codigo, @ds_periodoliquidacion, @am_numeroliquidacion, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(ControlCalidad ds_codigo, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE control_calidad SET ds_periodoliquidacion = @ds_periodoliquidacion, am_numeroliquidacion = @am_numeroliquidacion, ds_estadoliquidacion = @ds_estadoliquidacion, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion
                           WHERE ds_codigo= @ds_codigo";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, ds_codigo, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(ControlCalidad ds_codigo, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM control_calidad WHERE ds_codigo= @ds_codigo";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, ds_codigo, transaction);
            return nroFilasAfectadas;
        }
    }
}
