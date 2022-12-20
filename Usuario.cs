using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderismo
{
    public class Usuario
    {
        public string usuario { set; get; }
        public string password { set; get; }

        public string nombre { set; get; }
        public string apellidos { set; get; }
        public string dni { set; get; }
        public int telefono { set; get; }
        public string correo { set; get; }
        public int edad { set; get; }
        public Uri foto { set; get; }
        public DateTime ultimo { set; get; }

        public string muni { set; get; }

        public string dir { set; get; }
        public Usuario(string usuario, string password, string nombre, string apellidos, string dni, int telefono, string correo, int edad, Uri foto, DateTime fehca, string muni, string dir)
        {
            this.usuario = usuario;
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.correo = correo;
            this.edad = edad;
            this.foto = foto;
            this.ultimo = fehca;
            this.muni = muni;
            this.dir = dir;
        }
    }
}
