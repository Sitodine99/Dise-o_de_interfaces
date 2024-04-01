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

namespace Ejercicio_06
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static void rellenarComboBox(ComboBox combo)
        {
            for (int f = 0; f <= 225; f++)
            {
                combo.Items.Add(f.ToString());
            }
        }

        private void btnPinta_Click(object sender, RoutedEventArgs e)
        {
            byte r = (byte)comboRojo.SelectedIndex;
            byte g = (byte)comboVerde.SelectedIndex;
            byte b = (byte)comboAzul.SelectedIndex;

            Color color = Color.FromRgb(r, g, b);
            SolidColorBrush brush = new SolidColorBrush(color);
            btnPinta.Background = brush;
        }

        public MainWindow()

        {
            InitializeComponent();
            rellenarComboBox(comboRojo);
            rellenarComboBox(comboAzul);
            rellenarComboBox(comboVerde);
        }
    }
}
