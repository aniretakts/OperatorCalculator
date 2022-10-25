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
using System.Text.RegularExpressions;

namespace OperatorCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Calculate(object sender, RoutedEventArgs e)
        {
            int input1 = Int32.Parse(UserInput1.Text);
            int input2 = Int32.Parse(UserInput2.Text);
            int input3 = Int32.Parse(UserInput3.Text);
            string result= "";


            if (input1 + input2 == input3)
            {
                result = $"{input1} + {input2} = {input3}";
            }
            else if (input1 - input2 == input3)
            {
                result = $"{input1} - {input2} = {input3}";
            }
            else if (input1 * input2 == input3)
            {
                result = $"{input1} * {input2} = {input3}";
            }
            else if (input1 / input2 == input3)
            {
                result = $"{input1} / {input2} = {input3}";
            }
            else {
                result = "there is no valid operator for the given input";
            }

            Result.Text = result;
        }       

    }
}
