using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadCoolecheraModelos.Modelos
{
    public class Planta
    {
        public int codplanta { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string contacto { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
        public bool convenio { get; set; }
        public string prefijo { get; set; }
        public int interval { get; set; }
        public string gmail { get; set; }
        public bool cierreautomatico { get; set; }
        public bool sincroniza { get; set; }

        public Planta()
        {

        }
        public Planta(int codplanta, string nombre, string direccion, string telefono, string contacto, string email, bool estado, bool convenio, string prefijo, int interval, string gmail, bool cierreautomatico, bool sincroniza)
        {
            this.codplanta = codplanta;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.contacto = contacto;
            this.email = email;
            this.estado = estado;
            this.convenio = convenio;
            this.prefijo = prefijo;
            this.interval = interval;
            this.gmail = gmail;
            this.cierreautomatico = cierreautomatico;
            this.sincroniza = sincroniza;
        }
    }
}
