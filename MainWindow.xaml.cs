using System;
using System.Data;
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

namespace Ejercicio05Calculadora
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender; // Obtiene el botón que ha sido clickeado
            string content = button.Content.ToString(); // Obtiene el contenido del botón

            switch (content)
            {
                case "C":
                    display.Text = "0"; // reinicia el valor en el display
                    break;
                case "=":
                    // realiza el cálculo y actualiza el valor en el display
                    string expression = display.Text;
                    if (expression.Contains("+") || expression.Contains("-") || expression.Contains("*") || expression.Contains("/") || expression.Contains("."))
                    {
                        try
                        {
                            double result = Calculate(expression);
                            display.Text = result.ToString();
                        }
                        catch (Exception ex)
                        {
                            display.Text = "Error"; // Mostrar un mensaje de error en el display en caso de excepción
                        }
                    }
                    break;
                default:
                    // agrega el número u operador al final del valor en el display
                    if (display.Text == "0")
                    {
                        display.Text = content;
                    }
                    else
                    {
                        display.Text += content;
                    }
                    break;
            }
        }


        // Función auxiliar para realizar el cálculo de una expresión matemática dada

        private double Calculate(string expression)
        {
            DataTable table = new DataTable();
            var result = table.Compute(expression, "");
            return Convert.ToDouble(result);
        }
    }
}
