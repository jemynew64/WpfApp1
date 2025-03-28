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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persona> personas = new List<Persona>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Arriba la Alianza");
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona { Apellido = "leon", Nombre = "jemal" });
            personas.Add(new Persona { Apellido = "leon", Nombre = "jemal" });
            personas.Add(new Persona { Apellido = "leon", Nombre = "jemal" });

            dgDemo.ItemsSource = personas;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Curso> cursos = new List<Curso>();
            cursos.Add(new Curso { Seccion = "A", Nombre = "ingles" });
            cursos.Add(new Curso { Seccion = "A", Nombre = "comunicacion" });
            cursos.Add(new Curso { Seccion = "B", Nombre = "matematicas" });

            dgDemo.ItemsSource = cursos;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string Apellido = txtApellidos.Text;
            string Nombre = txtNombres.Text;
            personas.Add(new Persona { Apellido = Apellido, Nombre = Nombre });
            dgDemo.ItemsSource = null;
            dgDemo.ItemsSource = personas;
        }

        private void txtNombres_TextChanged(object sender, TextChangedEventArgs e)
        {
             //string Nombre = txtNombres.Text;
        }

        private void txtApellidos_TextChanged(object sender, TextChangedEventArgs e)
        {
          //  string Apellido = txtApellidos.Text;

        }
    }
}
