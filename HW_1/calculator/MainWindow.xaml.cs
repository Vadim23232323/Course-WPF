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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float a, b;
        int count;
        bool znak = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_number0_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 0;
        }

        private void btn_number1_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 1;
        }

        
        private void btn_number3_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 3;
        }

        private void btn_number4_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 4;
        }

        private void btn_number5_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 5;
        }

        private void btn_number6_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 6;
        }

        private void btn_number7_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 7;
        }

        private void btn_number8_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 8;
        }

        private void btn_number9_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 9;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            lab_operation.Content = "";
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            lab_operation.Content = "";
        }

        private void btn_sum_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 1;
            lab_operation.Content = a.ToString() + "+";
            znak = true;
        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 2;
            lab_operation.Content = a.ToString() + "-";
            znak = true;
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 3;
            lab_operation.Content = a.ToString() + "*";
            znak = true;
        }

        private void btn_difference_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb_result.Text);
            tb_result.Clear();
            count = 2;
            lab_operation.Content = a.ToString() + "-";
            znak = true;
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + ",";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                tb_result.Text = "-" + tb_result.Text;
                znak = false;
            }
            else if (znak == false)
            {
                tb_result.Text = tb_result.Text.Replace("-", "");
                znak = true;
            }
        }

        private void btn_erase_Click(object sender, RoutedEventArgs e)
        {
            int lenght = tb_result.Text.Length - 1;
            string text = tb_result.Text;
            tb_result.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tb_result.Text = tb_result.Text + text[i];
            }
        }

        private void btn_number2_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = tb_result.Text + 2;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(tb_result.Text);
                    tb_result.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
