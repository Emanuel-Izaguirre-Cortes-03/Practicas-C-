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

namespace Practica1.Parte2
{
    /// <summary>
    /// Lógica de interacción para Practica03_a.xaml
    /// </summary>
    public partial class Practica03_a : Window
    {
        private ListaInsumos listainsumo;
        private ListaCategorias listacategorias;
        public Practica03_a()
        {
            InitializeComponent();
            InicializarCategorias();
            this.listainsumo = new ListaInsumos();
            Closed += Practica03_a_Closed;
            Visibility = Visibility.Visible;
        }
        private void Practica03_a_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ComboCategoria_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Bagregar_Click(object sender, RoutedEventArgs e)
        {
            Altas();
        }

        private void Beliminar_Click(object sender, RoutedEventArgs e)
        {
            Eliminar();
        }

        private void Bsalir_Click(object sender, RoutedEventArgs e)
        {
            if (Bsalir.Content.ToString() == "Cancelar")
            {
                VolverAlInicio();
            }
            else
            {
                Close();
            }
        }

        private void InicializarCategorias()
        {
            this.listacategorias = new ListaCategorias();
            Categoria nodo1 = new Categoria("01", "Materiales");
            Categoria nodo2 = new Categoria("02", "Mano de Obra");
            Categoria nodo3 = new Categoria("03", "Maquinaria y Equipo");
            Categoria nodo4 = new Categoria("04", "Servicios");
            this.listacategorias.AgregarCategoria(nodo1);
            this.listacategorias.AgregarCategoria(nodo2);
            this.listacategorias.AgregarCategoria(nodo3);
            this.listacategorias.AgregarCategoria(nodo4);
            ComboCategoria.ItemsSource = this.listacategorias.CategoriaArreglo();
        }

        private void VolverAlInicio()
        {
            Bagregar.Content = "Agregar";
            Bsalir.Content = "Salir";
            Beliminar.IsEnabled = true;
            Tid.IsReadOnly = true;
            Tinsumo.IsReadOnly = true;
            Tid.Text = "";
            Tinsumo.Text = "";
        }

        private void Altas()
        {
            if (Bagregar.Content.ToString() == "Agregar")
            {
                Bagregar.Content = "Guardar";
                Bsalir.Content = "Cancelar";
                Beliminar.IsEnabled = false;
                Tid.IsReadOnly = false;
                Tinsumo.IsReadOnly = false;
                ComboCategoria.IsEditable = true;
                ComboCategoria.Focus();
            }
            else
            {
                if (EsDatosCompletos())
                {
                    string id, insumo, idcategoria;
                    id = Tid.Text.Trim();
                    insumo = Tinsumo.Text.Trim();
                    idcategoria = ((Categoria)ComboCategoria.SelectedItem).Idcategoria.Trim();
                    Insumo nodo = new Insumo(id, insumo, idcategoria);
                    if (!listainsumo.AgregarInsumo(nodo))
                    {
                        MessageBox.Show($"Lo siento pero el id {id} ya existe, lo tiene asignado {listainsumo.BuscarInsumo(id)}");
                    }
                    else
                    {
                        areaProductos.Text = listainsumo.ToString();
                    }
                }
                VolverAlInicio();
            }
        }

        private void Eliminar()
        {
            string[] opciones = listainsumo.IdInsumos();

            MessageBoxResult result = MessageBox.Show("Seleccione una opción: ", "Eliminación de Insumos", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {

            }
            else
            {

            }
        }
        private bool EsDatosCompletos()
        {
            return true;
        }

    }
}
