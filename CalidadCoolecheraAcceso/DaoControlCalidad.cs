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
            var Lsql = "SELECT ds_periodoliquidacion, am_numeroliquidacion, ds_estadoliquidacion FROM calidad.control_calidad";
            var calidad_cda = pConexion.Conexion.Query<ControlCalidad>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public ControlCalidad buscar(string ds_periodoliquidacion, int am_numeroliquidacion,  IDbTransaction transaction = null)
        {
            var strSQl = "select * from calidad.control_calidad where ds_periodoliquidacion = @ds_periodoliquidacion and am_numeroliquidacion = @am_numeroliquidacion";
            var Calidad_Leche = pConexion.Conexion.QueryFirst<ControlCalidad>(strSQl, new { ds_periodoliquidacion = ds_periodoliquidacion, am_numeroliquidacion = am_numeroliquidacion }, transaction);
            return Calidad_Leche;
        }

        public int Insertar(ControlCalidad controlCalidad, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO calidad.control_calidad(ds_periodoliquidacion, am_numeroliquidacion, ds_estadoliquidacion, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion, ds_usuariomodificacion, ds_equipomodificacion, dt_fechamodificacion, ds_programamodificacion) 
                           VALUES (@ds_periodoliquidacion, @am_numeroliquidacion, @ds_estadoliquidacion, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion, @ds_usuariomodificacion, @ds_equipomodificacion, @dt_fechamodificacion, @ds_programamodificacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, controlCalidad, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(ControlCalidad controlCalidad, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE calidad.control_calidad SET ds_periodoliquidacion = @ds_periodoliquidacion, am_numeroliquidacion = @am_numeroliquidacion, ds_estadoliquidacion = @ds_estadoliquidacion, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion
                           WHERE ds_periodoliquidacion = @ds_periodoliquidacion and am_numeroliquidacion = @am_numeroliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, controlCalidad, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(ControlCalidad controlCalidad, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM calidad.control_calidad WHERE ds_periodoliquidacion = @ds_periodoliquidacion and am_numeroliquidacion = @am_numeroliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, controlCalidad, transaction);
            return nroFilasAfectadas;
        }
    }
}
