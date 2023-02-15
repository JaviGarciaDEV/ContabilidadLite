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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton==MouseButtonState.Pressed) 
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

        }
    }
}
