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
                var senderista_aux = new Senderistas("", "", "", "", "", "", "", null, "", "", "", "");

                senderista_aux.nombreS = node.Attributes["nombreS"].Value;
                senderista_aux.dni = node.Attributes["dni"].Value;
                senderista_aux.telefono = (node.Attributes["telefono"].Value);
                senderista_aux.telefono_m = (node.Attributes["telefono_m"].Value);
                senderista_aux.correo = node.Attributes["correo"].Value;
                senderista_aux.apellido = node.Attributes["apellidos"].Value;
                senderista_aux.rutas_realizadas = node.Attributes["rutas_realizadas"].Value;
                senderista_aux.foto_S = new Uri(node.Attributes["foto_S"].Value, UriKind.Relative);
                senderista_aux.edad = node.Attributes["edad"].Value;
                senderista_aux.sexo = node.Attributes["sexo"].Value;
                senderista_aux.direccion = node.Attributes["direccion"].Value;
                senderista_aux.participacion = (node.Attributes["participacion"].Value);
                aux.Add(senderista_aux);
            }

            return aux;
        }

        private void annadir_senderias_Click(object sender, RoutedEventArgs e)
        {
            Senderistas senderista = new Senderistas("Nuevo Elemento", "", "", "", "", "", "", new Uri("fotos/jose.jpg", UriKind.Relative), "", "", "", "");
            btnGuardar.Visibility = Visibility.Visible;
            listaSenderistas.Add(senderista);
            lstSenderistas.Items.Refresh();
            MessageBox.Show("Ya se pude introducir información del nuevo senderitsta");
        }

        private void Eliminar_senderista_click(object sender, RoutedEventArgs e)
        {
            listaSenderistas.RemoveAt(lstSenderistas.SelectedIndex);
            lstSenderistas.Items.Refresh();
            MessageBox.Show("se elimino al senderista");
        }

        private void lstSenderistas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
