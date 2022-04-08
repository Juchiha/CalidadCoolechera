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
    public class DaoConfiguracionCalidad
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoConfiguracionCalidad(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoConfiguracionCalidad(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<ConfiguracionCalidad> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM configuracion_calidad";
            var calidad_cda = pConexion.Conexion.Query<ConfiguracionCalidad>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public ConfiguracionCalidad buscar(string ds_codigo, IDbTransaction transaction = null)
        {
            var strSQl = "select * from configuracion_calidad where cd_codigovariable = @cd_codigovariable";
            var Calidad_Leche = pConexion.Conexion.QueryFirst<ConfiguracionCalidad>(strSQl, new { ds_codigo = ds_codigo }, transaction);
            return Calidad_Leche;
        }

        public int Insertar(ConfiguracionCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"INSERT INTO configuracion_calidad(cd_codigovariable, ds_tipovariable, ds_valorvariable, ds_descripcionvariable, ds_usuariocreacion, ds_equipocreacion, dt_fechacreacion, ds_programacreacion) 
                           VALUES (@cd_codigovariable, @ds_tipovariable, @ds_valorvariable, @ds_descripcionvariable, @ds_usuariocreacion, @ds_equipocreacion, @dt_fechacreacion, @ds_programacreacion)  ";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Actualizar(ConfiguracionCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"UPDATE configuracion_calidad SET cd_codigovariable = @cd_codigovariable, ds_tipovariable = @ds_tipovariable, ds_valorvariable = @ds_valorvariable, ds_descripcionvariable = @ds_descripcionvariable, ds_usuariomodificacion = @ds_usuariomodificacion, ds_equipomodificacion = @ds_equipomodificacion, dt_fechamodificacion = @dt_fechamodificacion, ds_programamodificacion = @ds_programamodificacion
                           WHERE cd_codigovariable= @cd_codigovariable";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }

        public int Borrar(ConfiguracionCalidad Calidad_Leche, IDbTransaction transaction = null)
        {
            var strSQl = @"DELETE FROM configuracion_calidad WHERE cd_codigovariable= @cd_codigovariable";
            var nroFilasAfectadas = pConexion.Conexion.Execute(strSQl, Calidad_Leche, transaction);
            return nroFilasAfectadas;
        }
    }
}
