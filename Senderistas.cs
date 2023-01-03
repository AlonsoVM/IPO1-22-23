using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderismo
{
    class Senderistas
    {
        public string nombreS { set; get; }
        public string dni { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }
        public string apellido { set; get; }
        public string rutas_realizadas { set; get; }
        public Uri foto_S { set; get; }

        public string edad { set; get; }

        public string sexo { set; get; }

        public string direccion { set; get; }

        public string telefono_m { set; get; }

        public string participacion { set; get; }

        public List<Ruta> participacion_futura { set; get; }

        public List<Ruta> rutas_realizadas_l { get; set; }

        public Senderistas(string nombreS, string dni, string telefono, string telefono_m, string correo, string apellido, string rutas_realizadas, Uri foto_S, string edad, string Sexo, string dir, List<Ruta> p, List<Ruta> f)
        {
            this.nombreS = nombreS;
            this.dni = dni;
            this.telefono = telefono;
            this.telefono_m = telefono_m;
            this.correo = correo;
            this.apellido = apellido;
            this.rutas_realizadas = rutas_realizadas;
            this.foto_S = foto_S;
            this.edad = edad;
            this.sexo = sexo;
            this.direccion = dir;
            this.participacion = participacion;
            this.participacion_futura = f;
            this.rutas_realizadas_l = p;
        }
    }
}
