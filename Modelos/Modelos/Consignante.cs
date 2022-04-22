using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public class Consignante
    {
        public string codconsignante { get; set; }
        public string nombre { get; set; }
        public int codciudad { get; set; }
        public int codtipo { get; set; }
        public string comentario { get; set; }
        public string estado { get; set; }
        public string email { get; set; }

        public Consignante()
        {

        }
        public Consignante(string codconsignante, string nombre, int codciudad, int codtipo, string comentario, string estado, string email)
        {
            this.codconsignante = codconsignante;
            this.nombre = nombre;
            this.codciudad = codciudad;
            this.codtipo = codtipo;
            this.comentario = comentario;
            this.estado = estado;
            this.email = email;
        }
    }
}
