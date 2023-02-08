using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderismo
{
    class Ruta
    {
        public Uri foto_R { get; set; }
        public string nombre { get; set; }
        public int id { get; set; }
        public string provincia { get; set; }
        public string origen { set; get; }
        public string destino { set; get; }

        public string h_salida { set; get; }

        public string fecha_salida { set; get; }

        public string duracion { set; get; }

        public string dificultad { set; get; }

        public List<Senderistas> participantes { get; set; }

        public guia guia_r { get; set; }

        public Boolean realizada { set; get; }

        public List<PuntoInteres> puntos { get; set; }


        public Ruta(string nombre, int id, string provincia, string origen, string destino, string h_salida, string fecha_salida, string duracion, string dificultad, Uri f, Boolean realizada, List<PuntoInteres> p) {
            this.foto_R = f;
            this.nombre = nombre;
            this.id = id;
            this.provincia = provincia;
            this.origen = origen;    
            this.destino = destino;
            this.h_salida = h_salida;
            this.fecha_salida = fecha_salida;
            this.duracion = duracion;
            this.dificultad = dificultad;
            this.realizada = realizada;
            this.puntos = p;
        }
        public Ruta(string nombre, int id, string provincia, string origen, string destino, string h_salida, string fecha_salida, string duracion, string dificultad, List<Senderistas> s, guia g, Uri f)
        {
            this.foto_R = f;
            this.nombre = nombre;
            this.id = id;
            this.provincia = provincia;
            this.origen = origen;
            this.destino = destino;
            this.h_salida = h_salida;
            this.fecha_salida = fecha_salida;
            this.duracion = duracion;
            this.dificultad = dificultad;
            this.participantes = s;
            this.guia_r = g;
        }




    }
}
