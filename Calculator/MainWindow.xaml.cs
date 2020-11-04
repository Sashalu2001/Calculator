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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        double a = 0, b = 0;
        char symbol = '0';
        bool flag = false, flag2 = false;
        double value = 0;

        public double operation(double a, char symbol)
        {
            b = Convert.ToDouble(tbox.Text);
            switch (symbol)
            {
                case '+':
                    a += b;
                    break;
                case '-':
                    a -= b;
                    break;
                case '*':
                    a = a * b;
                    break;
                case '/':
                    a = a / b;
                    break;
                default:
                    break;

            }
            return a;
        }

        private void pbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Версия программы 1.01\nАвтор: Луцик Александр Николаевич", "О программе");
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text != "0") tbox.Text += "0";
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "1"; else tbox.Text += "1";
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "2"; else tbox.Text += "2";
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "3"; else tbox.Text += "3";
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "4"; else tbox.Text += "4";
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "5"; else tbox.Text += "5";
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "6"; else tbox.Text += "6";
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "7"; else tbox.Text += "7";
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "8"; else tbox.Text += "8";
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true)
            {
                pbox.Text = "";
                flag2 = false;
            }

            if (flag == true)
            {
                tbox.Clear();
                flag = false;
            }
            if (tbox.Text == "0") tbox.Text = "9"; else tbox.Text += "9";
        }

        private void b_alldelete_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text = "0";
            pbox.Text = "";
            a = 0; b = 0; symbol = '0';
        }

        private void b_linedelete_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text = "0";
        }

        private void b_delete_Click(object sender, RoutedEventArgs e)
        {
            if (tbox.Text.Length == 1) tbox.Text = "0"; else tbox.Text = tbox.Text.Remove(tbox.Text.Length - 1);
        }

        private void b_sign_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true) flag = false;
            if (tbox.Text != "0")
            {
                if (tbox.Text[0] == 45) tbox.Text = tbox.Text.Remove(0, 1); else tbox.Text = Convert.ToChar(45) + tbox.Text;
            }
        }

        private void b_plus_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0') symbol = '+';
            if (flag2 == true)
            {
                flag2 = false;
                pbox.Text = tbox.Text + symbol;
            } else pbox.Text = pbox.Text + tbox.Text + symbol;
            a = operation(a, symbol);
            tbox.Text = Convert.ToString(a);
            flag = true;
            symbol = '+';
        }

        private void b_minus_Click(object sender, RoutedEventArgs e)
        {
            if (symbol != '0')
            {
                symbol = '-';
                a = operation(a, symbol);
                tbox.Text = Convert.ToString(a);
                flag = true;
            }
            else
            {
                a = Convert.ToDouble(tbox.Text);
                flag = true;
                symbol = '-';
            }
            if (flag2 == true)
            {
                flag2 = false;
                pbox.Text = tbox.Text + symbol;
            }
            else pbox.Text = pbox.Text + tbox.Text + symbol;
        }


        private void b_multi_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                symbol = '*';
                a = 1;
            }
            a = operation(a, symbol);
            tbox.Text = Convert.ToString(a);
            flag = true;
            symbol = '*';
            if (flag2 == true)
            {
                flag2 = false;
                pbox.Text = tbox.Text + symbol;
            }
            else pbox.Text = pbox.Text + tbox.Text + symbol;
        }

        private void b_div_Click(object sender, RoutedEventArgs e)
        {
            if (symbol == '0')
            {
                a = Convert.ToDouble(tbox.Text);
                flag = true;
                symbol = '/';
            }
            else
            {
                a = operation(a, symbol);
                tbox.Text = Convert.ToString(a);
                flag = true;
                symbol = '/';
            }
            if (flag2 == true)
            {
                flag2 = false;
                pbox.Text = tbox.Text + symbol;
            }
            else pbox.Text = pbox.Text + tbox.Text + symbol;
        }

        private void b_equal_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == true) pbox.Text = tbox.Text; else pbox.Text = pbox.Text + tbox.Text + '=';
            flag2 = true;
            if (symbol != '0')
            {
                tbox.Text = Convert.ToString(operation(a, symbol));
                symbol = '0'; a = 0;
                flag = true;
            }
        }

        private void file_Click(object sender, RoutedEventArgs e) {}

        private void b_ms_Click(object sender, RoutedEventArgs e)
        {
            value = Convert.ToDouble(tbox.Text);
        }

        private void b_mr_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text = Convert.ToString(value);
        }

        private void b_mc_Click(object sender, RoutedEventArgs e)
        {
            value = 0;
        }

        private void b_m_plus_Click(object sender, RoutedEventArgs e)
        {
            value = value + Convert.ToDouble(tbox.Text);
        }

        private void b_m_minus_Click(object sender, RoutedEventArgs e)
        {
            value = value - Convert.ToDouble(tbox.Text);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void b_comma_Click(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                bool f = false;
                for (short i = 0; i < tbox.Text.Length; i++)
                {
                    if (tbox.Text[i] == ',')
                    {
                        f = true;
                        break;
                    }
                }
                if (f == false) tbox.Text += ',';
            }
            else
            {
                tbox.Text = "0,";
                flag = false;
            }

        }
    }
}
