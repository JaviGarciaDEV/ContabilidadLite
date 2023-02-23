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

namespace ProyectoInterfaces
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool darkTheme = true;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ButtonCasa_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonCalcular_click(object sender, RoutedEventArgs e)
        {
            try
            {
                int comida, luz, coche, alquiler, ingreso, restante, gasto;
                ingreso = int.Parse(numIngresos.Text);
                comida = int.Parse(gastoComida.Text);
                luz = int.Parse(gastoLuz.Text);
                coche = int.Parse(gastoCoche.Text);
                alquiler = int.Parse(gastoAlquiler.Text);

                gasto = comida + luz + coche + alquiler;
                restante = ingreso - gasto;

                numRestante.Content = restante.ToString();
                gastoTotal.Content = gasto.ToString();
                textoError.Content = "";
            }
            catch
            {
                textoError.Content = "Debes introducir numeros";
            }


        }

        private void Button_Theme(object sender, RoutedEventArgs e)
        {
            if (darkTheme == true)
            {
                darkTheme = false;
                // Crear un nuevo SolidColorBrush con el color deseado
                var colorFondo = (Color)ColorConverter.ConvertFromString("#FFFFFF");
                var colorAzulContenedores = (Color)ColorConverter.ConvertFromString("#9ACAEE");
                var colorAzulBotones = (Color)ColorConverter.ConvertFromString("#76AFD7");

                // Cambio color fondo y contenedores
                var brush = new SolidColorBrush(colorFondo);
                ventana.Background = brush;
                brush = new SolidColorBrush(colorAzulContenedores);
                menu.Background = brush;
                contenedor.Background = brush;

                // Cambio color titulos
                titulo.Foreground = brush;

                // Cambio color botones menu
                brush = new SolidColorBrush(colorAzulBotones);
                botonCasa.Background = brush;
                var border = (Border)botonCasa.Template.FindName("border", botonCasa);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)botonFacturas.Template.FindName("border", botonFacturas);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)botonOcio.Template.FindName("border", botonOcio);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)botonPagas.Template.FindName("border", botonPagas);
                border.Background = new SolidColorBrush(colorAzulBotones);

                // Cambio botones contenedor
                border = (Border)comida.Template.FindName("border", comida);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)coche.Template.FindName("border", coche);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)luz.Template.FindName("border", luz);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)alquiler.Template.FindName("border", alquiler);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)botonCalcular.Template.FindName("border", botonCalcular);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)ingresos.Template.FindName("border", ingresos);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)restante.Template.FindName("border", restante);
                border.Background = new SolidColorBrush(colorAzulBotones);

                border = (Border)gastoTotalCont.Template.FindName("border", gastoTotalCont);
                border.Background = new SolidColorBrush(colorAzulBotones);

                numIngresos.Background = brush;
                gastoComida.Background = brush;
                gastoCoche.Background = brush;
                gastoLuz.Background = brush;
                gastoAlquiler.Background = brush;

                // Obtener la imagen actual
                Image image = (Image)buttonTheme.Template.FindName("image", buttonTheme);
                image.Source = new BitmapImage(new Uri("temaoscuro.png", UriKind.Relative));

            }
            else
            {
                darkTheme = true;
                // Crear un nuevo SolidColorBrush con el color deseado
                var colorFondo = (Color)ColorConverter.ConvertFromString("#FF1B1B1B");
                var colorContenedores = (Color)ColorConverter.ConvertFromString("#FF303030");
                var colorBotones = (Color)ColorConverter.ConvertFromString("#FF1B1B1B");
                var colorTitulo = (Color)ColorConverter.ConvertFromString("#FFFFFF");

                // Cambio color fondo y contenedores
                var brush = new SolidColorBrush(colorFondo);
                ventana.Background = brush;
                brush = new SolidColorBrush(colorContenedores);
                menu.Background = brush;
                contenedor.Background = brush;

                // Cambio color titulos
                brush = new SolidColorBrush(colorTitulo);
                titulo.Foreground = brush;

                // Cambio color botones menu
                brush = new SolidColorBrush(colorBotones);
                botonCasa.Background = brush;
                var border = (Border)botonCasa.Template.FindName("border", botonCasa);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)botonFacturas.Template.FindName("border", botonFacturas);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)botonOcio.Template.FindName("border", botonOcio);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)botonPagas.Template.FindName("border", botonPagas);
                border.Background = new SolidColorBrush(colorBotones);

                // Cambio botones contenedor
                border = (Border)comida.Template.FindName("border", comida);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)coche.Template.FindName("border", coche);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)luz.Template.FindName("border", luz);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)alquiler.Template.FindName("border", alquiler);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)botonCalcular.Template.FindName("border", botonCalcular);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)ingresos.Template.FindName("border", ingresos);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)restante.Template.FindName("border", restante);
                border.Background = new SolidColorBrush(colorBotones);

                border = (Border)gastoTotalCont.Template.FindName("border", gastoTotalCont);
                border.Background = new SolidColorBrush(colorBotones);

                numIngresos.Background = brush;
                gastoComida.Background = brush;
                gastoCoche.Background = brush;
                gastoLuz.Background = brush;
                gastoAlquiler.Background = brush;

                // Obtener la imagen actual
                Image image = (Image)buttonTheme.Template.FindName("image", buttonTheme);
                image.Source = new BitmapImage(new Uri("tema.png", UriKind.Relative));
            }

        }
    }
}
