using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Profesor> profesores = new List<Profesor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El equipo de vocal es basura");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Boca hijo de alianza");

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
                Profesor nuevoProfesor = new Profesor
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text
                };

                profesores.Add(nuevoProfesor);

                dgProfesores.ItemsSource = null;
                dgProfesores.ItemsSource = profesores;

                txtNombres.Clear();
                txtApellidos.Clear();
        }
    }
}
