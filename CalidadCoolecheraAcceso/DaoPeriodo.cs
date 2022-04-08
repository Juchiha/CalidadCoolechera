using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CalidadModelos.Modelos;
using Dapper;

namespace CalidadCoolecheraAcceso
{
    public class DaoPeriodo
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoPeriodo(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoPeriodo(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<Periodo> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM periodos";
            var periodos = pConexion.Conexion.Query<Periodo>(Lsql, transaction).ToList();
            return periodos;
        }

        public Periodo buscar(string ds_periodoliquidacion, IDbTransaction transaction = null)
        {
            var strSQl = "select * from periodos where ds_periodoliquidacion = @ds_periodoliquidacion";
            var Periodo = pConexion.Conexion.QueryFirst<Periodo>(strSQl, new { ds_periodoliquidacion = ds_periodoliquidacion }, transaction);
            return Periodo;
        }

        public int Insertar(Periodo periodo, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO periodos(ds_periodoliquidacion, am_numeroliquidacion, ds_estadoperiodo, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion) 
                           VALUES (@ds_periodoliquidacion, @am_numeroliquidacion, @ds_estadoperiodo, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, periodo, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(Periodo periodo, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE periodos SET am_numeroliquidacion = @am_numeroliquidacion, ds_estadoperiodo = @ds_estadoperiodo, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion  
                           WHERE ds_periodoliquidacion= @ds_periodoliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, periodo, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(Periodo periodo, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM periodos WHERE ds_periodoliquidacion= @ds_periodoliquidacion";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, periodo, transaction);
            return nroFilasAfectadas;
        }
    }
}
