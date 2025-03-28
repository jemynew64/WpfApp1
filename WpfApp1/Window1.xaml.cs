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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Persona> personas = new List<Persona>();

        public Window1()
        {

            InitializeComponent();
        }

        private void dgDemo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Apellido = txtApellidos.Text;
            string Nombre = txtNombres.Text;
            personas.Add(new Persona { Apellido = Apellido, Nombre = Nombre });
            dgDemo.ItemsSource = null;
            dgDemo.ItemsSource = personas;
        }
    }
}
