using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderismo
{
    class guia
    {
        public string nombre_G { get; set; }
        public Uri foto_G { get; set; }

        public string apellido { get; set; }

        public string dni { get; set; }

        public string edad { get; set; }

        public string idiomas { get; set; }

        public List<Ruta> rutas_ya_realizada { get; set; }

        public List<Ruta> rutas_no_realizadad { get; set; }

        public float nota { get; set; }

        public string email { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public guia(string n, Uri f, string apellido, string dni, string idioma, List<Ruta> rutas, List<Ruta> rutas2, float nota, string email, string direccion, string telefono, string edad)
        {
            this.nombre_G = n;
            this.foto_G = f;
            this.apellido = apellido;
            this.dni = dni;
            this.idiomas = idioma;
            this.rutas_ya_realizada = rutas;
            this.rutas_no_realizadad = rutas2;
            this.nota = nota;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.edad = edad;
        }
    }
}
