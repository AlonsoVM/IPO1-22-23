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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Senderismo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Usuario admin_u = new Usuario("admin", "ipo1", "", "", "", 0, "", 0, null, DateTime.Now, "", "");
        public MainWindow()
        {
            InitializeComponent();
            PassBox.IsEnabled = false;
            UserTextBox.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private BitmapImage imgCorrecto = new BitmapImage(new Uri("/fotos/correcto.png", UriKind.Relative));
        private BitmapImage imgIncorrecto = new BitmapImage(new Uri("/fotos/incorrecto.png", UriKind.Relative));
        private string user = "admin";
        private string password = "1234";

        private void txtUserKeyDown(object sender, KeyEventArgs e)
        {
            ImgU.Source = imgIncorrecto;
            if (e.Key == Key.Return) {
                if (!String.IsNullOrEmpty(UserTextBox.Text)) {
                    if (ComprobarEntrada(UserTextBox.Text, user, UserTextBox, ImgU))
                    {
                        ImgU.Source = imgCorrecto;
                        PassBox.IsEnabled = true;
                        PassBox.Focus();
                    }
                }
            }
        }
        private Boolean ComprobarEntrada(string valorIntroducido, string valorValido,
Control componenteEntrada, Image imagenFeedBack)
        {
            Boolean valido = false;
            componenteEntrada.BorderThickness = new Thickness(2);
            if (valorIntroducido.Equals(valorValido))
            {
                // borde y background en verde
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> check
                imagenFeedBack.Source = imgCorrecto;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                componenteEntrada.Background = Brushes.LightSalmon;
                // imagen al lado de la entrada de usuario --> cross
                imagenFeedBack.Source = imgIncorrecto;
                valido = false;
            }
            return valido;
        }
        private void btnLogin_click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UserTextBox.Text) || String.IsNullOrEmpty(PassBox.Password)) {
                UserTextBox.Foreground = Brushes.Red;
                PassBox.Foreground = Brushes.Red;
                lblEstado.Content = "Intruduzca usuario y contraseña";
            }
            if (UserTextBox.Text == user && PassBox.Password == password)
            {
                this.Hide();
                Window1 inicio;
                inicio = new Window1();
                inicio.Show();
            }
        }

        private void PassBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            ImgP.Source = imgIncorrecto;
            if (e.Key == Key.Return)
            {
                if (!String.IsNullOrEmpty(PassBox.Password) && ComprobarEntrada(PassBox.Password, password, PassBox, ImgP))
                {
                    ImgP.Source = imgCorrecto;
                    btnLogin.Focus();
                }
            }
        }
    }
}
