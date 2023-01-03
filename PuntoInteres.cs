using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderismo
{
    class PuntoInteres
    {
        public string tipo { get; set; }

        public Uri foto { get; set; }

        public int id_ruta { get; set; }

        public PuntoInteres(string tipo, Uri foto, int i) { 
            this.tipo = tipo;
            this.foto = foto;
            this.id_ruta = i;
        }
    }
}
