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

        public guia(string n, Uri f)
        {
            this.nombre_G = n;
            this.foto_G = f;
        }
    }
}
