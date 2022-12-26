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
        public string cuentaBancaria { set; get; }
        public string cuantiaAyuda { set; get; }
        public string formaPago { set; get; }
        public Uri foto_S { set; get; }

        public Senderistas(string nombreS, string dni, string telefono, string correo, string cuentaBancaria, string cuantiaAyuda, string formaPago, Uri foto_S)
        {
            this.nombreS = nombreS;
            this.dni = dni;
            this.telefono = telefono;
            this.correo = correo;
            this.cuentaBancaria = cuentaBancaria;
            this.cuantiaAyuda = cuantiaAyuda;
            this.formaPago = formaPago;
            this.foto_S = foto_S;
        }
    }
}
