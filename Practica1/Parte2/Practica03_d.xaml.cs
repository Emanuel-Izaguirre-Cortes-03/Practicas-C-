using System;
using System.Collections.Generic;
using System.IO;
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

namespace Practica1.Parte2
{
    /// <summary>
    /// Lógica de interacción para Practica03_d.xaml
    /// </summary>
    public partial class Practica03_d : Window
    {
        public Practica03_d()
        {
            InitializeComponent();
            Loaded += Practica03_d_Loaded;  // Asociar el evento Loaded
        }
        private void Practica03_d_Loaded(object sender, RoutedEventArgs e)
        {
            CargarCategorias();
            CargarDatosDesdeArchivo();
        }

        private void CargarCategorias()
        {

            ComboCategoria.Items.Add("Categoría 1");
            ComboCategoria.Items.Add("Categoría 2");
            ComboCategoria.Items.Add("Categoría 3");

            ComboCategoria.SelectedIndex = 0;
        }

        private void Bagregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarInsumo();
        }

        private void Beliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarInsumo();
        }

        private void Bsalir_Click(object sender, RoutedEventArgs e)
        {
            GuardarDatos();
            Close();
        }

        private void AgregarInsumo()
        {
            string id = Tid.Text;
            string producto = Tproducto.Text;
            string categoria = ComboCategoria.Text;

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(producto) && !string.IsNullOrWhiteSpace(categoria))
            {
                Tarea.Text += $"{id},{producto},{categoria}\n";
                Tid.Text = "";
                Tproducto.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los valores.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarInsumo()
        {
            string texto = Tarea.Text;
            if (!string.IsNullOrWhiteSpace(texto))
            {
                string[] lineas = texto.Split('\n');
                string nuevoTexto = string.Join("\n", lineas, 0, lineas.Length - 1);
                Tarea.Text = nuevoTexto;
            }
        }

        private void GuardarDatos()
        {
            try
            {
                string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "datos.txt");
                File.WriteAllText(filePath, Tarea.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al guardar los datos en el archivo: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void CargarDatosDesdeArchivo()
        {
            try
            {
                string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "datos.txt");
                if (File.Exists(filePath))
                {
                    Tarea.Text = File.ReadAllText(filePath);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error al cargar los datos desde el archivo: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
