using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Senderismo
{
    /// <summary>
    /// Lógica de interacción para InterfazPrincipal.xaml
    /// </summary>
    public partial class InterfazPrincipal : Window
    {
        private List<Senderistas> listaSenderistas;
        public InterfazPrincipal()
        {
            InitializeComponent();
            listaSenderistas = CargarContenidoXML_S();
            lstSenderistas.ItemsSource = listaSenderistas;
        }

        private List<Senderistas> CargarContenidoXML_S()
        {
            List<Senderistas> aux = new List<Senderistas>();
            XmlDocument doc2 = new XmlDocument();
            var fichero2 = Application.GetResourceStream(new Uri("data/Senderistas.xml", UriKind.Relative));
            doc2.Load(fichero2.Stream);

            foreach (XmlNode node in doc2.DocumentElement.ChildNodes)
            {
                var nuevoSocio = new Senderistas("", "", "", "", "", "", "", null);

                nuevoSocio.nombreS = node.Attributes["nombreS"].Value;
                nuevoSocio.dni = node.Attributes["dni"].Value;
                nuevoSocio.telefono = (node.Attributes["telefono"].Value);
                nuevoSocio.correo = node.Attributes["correo"].Value;
                nuevoSocio.cuentaBancaria = node.Attributes["cuentaBancaria"].Value;
                nuevoSocio.cuantiaAyuda = (node.Attributes["cuantiaAyuda"].Value);
                nuevoSocio.formaPago = node.Attributes["formaPago"].Value;
                nuevoSocio.foto_S = new Uri(node.Attributes["foto_S"].Value, UriKind.Relative);
                aux.Add(nuevoSocio);
            }

            return aux;
        }

        private void annadir_senderias_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eliminar_senderista_click(object sender, RoutedEventArgs e)
        {

        }

        private void lstSenderistas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
