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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<Usuario> Admins;
        public Window1()
        {
            InitializeComponent();
            Admins = Admins_XML();
            DataContext = Admins;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InterfazPrincipal window = new InterfazPrincipal();
            window.Show();
            this.Close();
        }

        private List<Usuario> Admins_XML()
        {

            List<Usuario> listaU = new List<Usuario>();
            // Cargar contenido de prueba
            XmlDocument doc3 = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("/data/Usuario.xml", UriKind.Relative));
            doc3.Load(fichero.Stream);

            foreach (XmlNode node in doc3.DocumentElement.ChildNodes)
            {
                var nuevoUsuario = new Usuario("", "", "", "", "", 0, "", 0, null, DateTime.Now, "", "");

                nuevoUsuario.usuario = node.Attributes["usuario"].Value;
                nuevoUsuario.password = node.Attributes["password"].Value;
                nuevoUsuario.nombre = node.Attributes["nombre"].Value;
                nuevoUsuario.apellidos = node.Attributes["apellidos"].Value;
                nuevoUsuario.dni = node.Attributes["dni"].Value;
                nuevoUsuario.telefono = Convert.ToInt32(node.Attributes["telefono"].Value);
                nuevoUsuario.correo = node.Attributes["correo"].Value;
                nuevoUsuario.edad = Convert.ToInt32(node.Attributes["edad"].Value);
                nuevoUsuario.foto = new Uri(node.Attributes["foto"].Value, UriKind.Relative);
                nuevoUsuario.dir = node.Attributes["dir"].Value;
                nuevoUsuario.muni = node.Attributes["muni"].Value;


                listaU.Add(nuevoUsuario);
            }

            return listaU;
        }
    }
}
