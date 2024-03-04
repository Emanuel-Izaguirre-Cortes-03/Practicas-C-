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

namespace Practicas.Parte1
{
    /// <summary>
    /// Lógica de interacción para Practica02_c.xaml
    /// </summary>
    public partial class Practica02_c : Window
    {
        public Practica02_c()
        {
            InitializeComponent();
        }
        private void BSalir_Click(object sender, RoutedEventArgs e)
        {
            string cadena = $"Valor de JTextField: {campoTexto.Text.Trim()}\n";
            cadena += $"Valor de JPasswordField: {campoPassword.Password.Trim()}\n";
            cadena += $"Valor de JTextArea: {areaTexto.Text}\n";
            cadena += $"Valor de JFormattedTextField: {campoFormateado.Text.Trim()}\n";
            cadena += $"Valor de JSpinner: {spinner.Text}\n";
            cadena += $"Valor de JSlider: {slider.Value}\n";

            if (comboBox.SelectedIndex > -1)
            {
                cadena += $"Valor de JComboBox: {comboBox.Text}\n";
                MessageBox.Show(cadena);
            }
        }

        private void IncrementarJSpinner(object sender, RoutedEventArgs e)
        {
            int valor = int.Parse(spinner.Text);
            spinner.Text = (++valor).ToString();
        }

        private void DecrementarJSpinner(object sender, RoutedEventArgs e)
        {
            int valor = int.Parse(spinner.Text);
            spinner.Text = (--valor).ToString();
        }
    }
}
