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
    /// Lógica de interacción para Practica01_03.xaml
    /// </summary>
    public partial class Practica01_03 : Window
    {
        public Practica01_03()
        {
            InitializeComponent();
            InitializeUI();
        }
        private void InitializeUI()
        {
            Title = "Practica01_03";
            Width = 450;
            Height = 300;

            StackPanel contentPanel = new StackPanel();
            contentPanel.Margin = new Thickness(5);
            Content = contentPanel;
            TextBlock textBlock = new TextBlock
            {
                Text = "Este es el contenido de la ventana.",
                Margin = new Thickness(0, 0, 0, 10)
            };
            contentPanel.Children.Add(textBlock);

            // Crear el panel de botones
            StackPanel buttonPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(0, 10, 0, 0)
            };
            contentPanel.Children.Add(buttonPanel);

            Button okButton = new Button
            {
                Content = "OK",
                Margin = new Thickness(5)
            };
            okButton.Click += (sender, e) => { Close(); };
            buttonPanel.Children.Add(okButton);

            Button cancelButton = new Button
            {
                Content = "Cancel",
                Margin = new Thickness(5)
            };
            cancelButton.Click += (sender, e) => { Close(); };
            buttonPanel.Children.Add(cancelButton);
        }

    }
}
