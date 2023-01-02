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
        private List<guia> listaGuias;
        public InterfazPrincipal()
        {
            InitializeComponent();
            listaSenderistas = CargarContenidoXML_S();
            lstSenderistas.ItemsSource = listaSenderistas;
            listaGuias = CargarContenidoXML_G();
            lstGuias.ItemsSource = listaGuias;
            
        }

        private List<guia> CargarContenidoXML_G() {
            List<guia> aux = new List<guia>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("data/guias.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes) {
                var guia_aux = new guia("", null, "", "", "", "", 0, "", "", "","");
                guia_aux.nombre_G = node.Attributes["nombre_G"].Value;
                guia_aux.foto_G = new Uri(node.Attributes["foto_G"].Value, UriKind.Relative);
                guia_aux.apellido = node.Attributes["apellido"].Value;
                guia_aux.dni = node.Attributes["dni"].Value;
                guia_aux.idiomas = node.Attributes["idiomas"].Value;
                guia_aux.rutas = node.Attributes["rutas"].Value;
                guia_aux.nota = float.Parse(node.Attributes["nota"].Value);
                guia_aux.email = node.Attributes["email"].Value;
                guia_aux.direccion = node.Attributes["direccion"].Value;
                guia_aux.telefono = node.Attributes["telefono"].Value;
                guia_aux.edad = node.Attributes["edad"].Value;
                aux.Add(guia_aux);
            }
            return aux;
        }

        private List<Senderistas> CargarContenidoXML_S()
        {
            List<Senderistas> aux = new List<Senderistas>();
            XmlDocument doc = new XmlDocument();
            var fichero2 = Application.GetResourceStream(new Uri("data/Senderistas.xml", UriKind.Relative));
            doc.Load(fichero2.Stream);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var senderista_aux = new Senderistas("", "", "", "", "", "", "", null, "", "", "", "", "");

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
                senderista_aux.participacion_futura = node.Attributes["futura"].Value;
                aux.Add(senderista_aux);
            }

            return aux;
        }

        private void annadir_senderias_Click(object sender, RoutedEventArgs e)
        {
            Senderistas senderista = new Senderistas("Nuevo Elemento", "", "", "", "", "", "", new Uri("fotos/jose.jpg", UriKind.Relative), "", "", "", "", "");
            btnGuardar.Visibility = Visibility.Visible;
            listaSenderistas.Add(senderista);
            lstSenderistas.Items.Refresh();
            MessageBox.Show("Ya se pude introducir información del nuevo senderitsta");
        }

        private void Eliminar_senderista_click(object sender, RoutedEventArgs e)
        {
            try {
                listaSenderistas.RemoveAt(lstSenderistas.SelectedIndex);
                lstSenderistas.Items.Refresh();
                MessageBox.Show("se elimino al senderista");
            }
            catch (Exception ex){
                MessageBox.Show("error de indice :" + ex.ToString());
            }
        }

        private void lstSenderistas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnGuardar_MouseEnter(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/guardar.png", UriKind.Relative));
            imgGuardar.Source = img_drag_ong;
        }

        private void btnGuardar_MouseLeave(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/guardar_bn.png", UriKind.Relative));
            imgGuardar.Source = img_drag_ong;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(boxNombre.Text) && !String.IsNullOrEmpty(boxDNI.Text) && !String.IsNullOrEmpty(boxEdad.Text)
                && !String.IsNullOrEmpty(boxSexo.Text) && !String.IsNullOrEmpty(boxFijo.Text) && !String.IsNullOrEmpty(boxMovil.Text)
                && !String.IsNullOrEmpty(boxDir.Text))
            {
                try
                {
                    Senderistas sender_aux = listaSenderistas[lstSenderistas.SelectedIndex];
                    sender_aux.nombreS = lblNombre.Text;
                    sender_aux.dni = boxDNI.Text;
                    sender_aux.sexo = boxSexo.Text;
                    sender_aux.edad = boxEdad.Text;
                    sender_aux.telefono = boxFijo.Text;
                    sender_aux.telefono_m = boxMovil.Text;
                    sender_aux.direccion = boxDir.Text;
                    sender_aux.rutas_realizadas = boxrutas_realizadas.Text;
                    lstSenderistas.Items.Refresh();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error :" + ex.ToString());
                }
                MessageBox.Show("Se guardaron los cambios correctamente");
            }
            else {
                MessageBox.Show("Adevertencia rellene los parametros necesarios");
            }
        }

        private void btnSalir_MouseEnter(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/salir_c.jpg", UriKind.Relative));
            imgSalir.Source = img_drag_ong;
        }

        private void btnSalir_MouseLeave(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/salir_bn.png", UriKind.Relative));
            imgSalir.Source = img_drag_ong;
        }

        private void btn_Cambiar_click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    Senderistas sender_aux = listaSenderistas[lstSenderistas.SelectedIndex];
                    sender_aux.foto_S = new Uri(dialog.FileName, UriKind.Absolute);
                    lstSenderistas.Items.Refresh();
                }
                catch (Exception ex) { 
                    MessageBox.Show("Error  :"+ex.ToString());
                }
            }
        }

        private void img_cambiar_enter(object sender, MouseEventArgs e)
        {
            var img_enter = new BitmapImage(new Uri("/fotos/editar_c.jpg", UriKind.Relative));
            imgCambiar.Source = img_enter;
        }

        private void img_cambiar_leave(object sender, MouseEventArgs e)
        {
            var img_enter = new BitmapImage(new Uri("/fotos/editar_bn.png", UriKind.Relative));
            imgCambiar.Source = img_enter;
        }

        private void MouseEnter_btnGuardar_g(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/guardar.png", UriKind.Relative));
            imgGuardar_g.Source = img_drag_ong;
        }

        private void MouseLeabe_btnGuardar_g(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/guardar_bn.png", UriKind.Relative));
            imgGuardar_g.Source = img_drag_ong;
        }

        private void Click_btnGuardar_g(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(boxapellidos_g.Text) && !String.IsNullOrEmpty(boxdni_g.Text) && !String.IsNullOrEmpty(boxedad_g.Text) && !String.IsNullOrEmpty(boxtelefono_g.Text) && !String.IsNullOrEmpty(boxdir_g.Text)
                && !String.IsNullOrEmpty(boxemail_g.Text) && !String.IsNullOrEmpty(boxrutas_realizadas.Text) && !String.IsNullOrEmpty(boxnota_media.Text) && !String.IsNullOrEmpty(boxidiomas.Text) && !String.IsNullOrEmpty(lblName_G.Text))
            {
                try
                {
                    guia guia_aux = listaGuias[lstGuias.SelectedIndex];
                    guia_aux.nombre_G = lblName_G.Text;
                    guia_aux.apellido = boxapellidos_g.Text;
                    guia_aux.dni = boxdni_g.Text;
                    guia_aux.edad = boxedad_g.Text;
                    guia_aux.telefono = boxtelefono_g.Text;
                    guia_aux.direccion = boxdir_g.Text;
                    guia_aux.email = boxemail_g.Text;
                    guia_aux.rutas = boxrutas_realizadas.Text;
                    guia_aux.idiomas = boxidiomas.Text;
                    guia_aux.nota = float.Parse(boxnota_media.Text);
                    lstGuias.Items.Refresh();
                    MessageBox.Show("Se guardaron los cambios correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.ToString());
                }
            }
            else {
                MessageBox.Show("Adevertencia rellene los parametros necesarios");
            }
        }

        private void MouseEnter_btnCambiarImg_g(object sender, MouseEventArgs e)
        {
            var img_enter = new BitmapImage(new Uri("/fotos/editar_c.jpg", UriKind.Relative));
            imgCambiar_g.Source = img_enter;
        }

        private void MouseLeave_btnCambiarimg_g(object sender, MouseEventArgs e)
        {
            var img_enter = new BitmapImage(new Uri("/fotos/editar_bn.png", UriKind.Relative));
            imgCambiar_g.Source = img_enter;
        }

        private void Click_btnCambiarImg_g(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            guia guia_aux = listaGuias[lstGuias.SelectedIndex];
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    guia_aux.foto_G = new Uri(dialog.FileName, UriKind.Absolute);
                    lstGuias.Items.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error  :" + ex.ToString());
                }
            }
        }
        private void Click_btnSalir_g(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la aplicación");
            Application.Current.Shutdown(); 
        }

        private void btnSalir_g_MouseEnter(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/salir_c.jpg", UriKind.Relative));
            imgSalir_g.Source = img_drag_ong;
        }

        private void btnSalir_g_MouseLeave(object sender, MouseEventArgs e)
        {
            var img_drag_ong = new BitmapImage(new Uri("/fotos/salir_bn.jpg", UriKind.Relative));
            imgSalir_g.Source = img_drag_ong;
        }

        private void Annadir_guia(object sender, RoutedEventArgs e)
        {
            guia guia_aux = new guia("Nuevo Elemento", new Uri("fotos/jose.jpg", UriKind.Relative), "", "", "", "", 0, "", "","","");
            listaGuias.Add(guia_aux);
            lstGuias.Items.Refresh();
            MessageBox.Show("Ya se pude introducir información del nuevo senderitsta");
        }

        private void Eliminar_guia(object sender, RoutedEventArgs e)
        {
            try
            {
                listaGuias.RemoveAt(lstGuias.SelectedIndex);
                lstGuias.Items.Refresh();
                MessageBox.Show("Se elimino al guia");
            }
            catch (Exception ex){
                MessageBox.Show("Error de indice :" + ex.ToString());
            }
        }

        private void btnSalir_s_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la aplicación");
            Application.Current.Shutdown();
        }
    }
}
