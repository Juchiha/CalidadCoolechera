using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalidadCoolecheraModelos.Modelos;
using Dapper;
using System.Data;

namespace CalidadCoolecheraAcceso
{
    public class DaoFincas
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoFincas(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoFincas(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<Finca> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM calidad.mtfinca";
            var calidad_cda = pConexion.Conexion.Query<Finca>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public List<Finca> buscar(string codconsignante, IDbTransaction transaction = null)
        {
            var strSQl = "SELECT f.codfinca, f.nombre, f.codruta, p.nombre as codplanta  FROM calidad.mtfinca f JOIN mtplanta p ON p.codplanta = f.codplanta where codconsignante = @codconsignante ";
            var Calidad_Leche = pConexion.Conexion.Query<Finca>(strSQl, new { codconsignante = codconsignante }, transaction).ToList();
            return Calidad_Leche;
        }
    }
}
