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

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        double rez = 0, x = 0, y = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        //нажатие удаления последнего символа
        private void btn_deleting_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_2.Text;
            if (buf.Length == 1)
                buf = "0";
            else
            if (buf.Length>0)
                buf = buf.Remove(buf.Length - 1);
            textBlock_2.Text = buf;
        }

        //нажатие на 8
        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "8";

            y = Convert.ToDouble(textBlock_2.Text);

        }

        //нажатие на 9
        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "9";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на кнопку деления
        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "/";
                }
            }
            else
            {
                textBlock_1.Text += Convert.ToString(y) + "/";
            }

            x = Convert.ToDouble(textBlock_2.Text);
           textBlock_2.Text = "0";
        }

        //нажатие на 4
        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "4";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на 5
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "5";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на 6
        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "6";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на кнопку удаления
        private void btn_multip_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' /*|| buf[buf.Length - 1] == '*'*/ || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "*";
                }
            }
            else
            {
                textBlock_1.Text += textBlock_2.Text + "*";
            }

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x * y;
            }
            x = Convert.ToDouble(textBlock_2.Text);
            textBlock_2.Text = "0";
            
            y = 0;

        }

        //нажатие на 1
        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "1";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на 2
        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "2";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на 3
        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text+="3";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на кнопку вычитания
        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "-";
                }

            }
            else
            {
                textBlock_1.Text += textBlock_2.Text + "-";
            }

            if (x == 0)
            {
                rez = y - x;
            }
            else
            {
                rez = x - y;
            }
            x = Convert.ToDouble(textBlock_2.Text);
            textBlock_2.Text ="0";
           
            y = 0;

        }

        //нажатие на 7
        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "7";

            y = Convert.ToDouble(textBlock_2.Text);

        }

        //нажатие на кнопку прибавления
        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "+";
                }
            }
            else
            {
                textBlock_1.Text += textBlock_2.Text + "+";
            }
            x = Convert.ToDouble(textBlock_2.Text);
            textBlock_2.Text = "0";
        }

        //нажатие на 0
        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text == "0")
            {
                textBlock_2.Text = null;
            }

            textBlock_2.Text += "0";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        //нажатие на кнопку очистки полей
        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (btn_0.IsEnabled == false)
            {
                btn_0.IsEnabled = true;
                btn_00.IsEnabled = true;
                btn_1.IsEnabled = true;
                btn_2.IsEnabled = true;
                btn_3.IsEnabled = true;
                btn_4.IsEnabled = true;
                btn_6.IsEnabled = true;
                btn_5.IsEnabled = true;
                btn_7.IsEnabled = true;
                btn_8.IsEnabled = true;
                btn_9.IsEnabled = true;
                btn_change.IsEnabled = true;
                btn_comma.IsEnabled = true;
                btn_deleting.IsEnabled = true;
                btn_div.IsEnabled = true;
                btn_equally.IsEnabled = true;
                btn_minus.IsEnabled = true;
                btn_multip.IsEnabled = true;
                btn_plus.IsEnabled = true;
                btn_proc.IsEnabled = true;
                btn_sq.IsEnabled = true;
                root.IsEnabled = true;
            }
            textBlock_1.Text = "";
            textBlock_2.Text = "0";
        }

        //нажатие на кнопку смены знака
        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;
            if (buf.Length != 0)
            {
                if (buf[buf.Length - 1] == '+')
                    textBlock_1.Text = buf.Substring(0, buf.Length - 1) + "-";
                if (buf[buf.Length - 1] == '-')
                    textBlock_1.Text = buf.Substring(0, buf.Length - 1) + "+";
            }
        }

        //нажатие на 00
        private void btn_00_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_2.Text != "0"&&textBlock_2.Text!="")
            {
                textBlock_2.Text += "00";
                y = Convert.ToDouble(textBlock_2.Text);
            }
        }

        //нажатие на кнопку возведения в степень
        private void btn_sq_Click(object sender, RoutedEventArgs e)
        { x = Convert.ToDouble(textBlock_2.Text);
            textBlock_1.Text = textBlock_2.Text + "^2";
            textBlock_2.Text = Convert.ToString(x * x);
        }

        //нажатие на кнопку процента
        private void btn_proc_Click(object sender, RoutedEventArgs e)
        {
            x = Convert.ToDouble(textBlock_2.Text);
            textBlock_1.Text = textBlock_2.Text + "%";
            textBlock_2.Text = Convert.ToString(x/100);
        }

        //нажатие на кнопку квадратного корня
        private void root_Click(object sender, RoutedEventArgs e)
        {
            x = Convert.ToDouble(textBlock_2.Text);
            textBlock_1.Text = textBlock_2.Text + "^(1/2)";
            textBlock_2.Text = Convert.ToString(Math.Sqrt(x));
        }

        //нажатие на запятую
        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_2.Text;
            if (buf[buf.Length - 1]!=',')
            textBlock_2.Text += ",";
        }

        //нажатие на кнопку =
        
        private void btn_equally_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;
            try
            {
                if (buf[buf.Length - 1] == '+')
                {
                    y = Convert.ToDouble(textBlock_2.Text);
                    rez = x + y;
                    textBlock_2.Text = Convert.ToString(rez);
                }
                if (buf[buf.Length - 1] == '-')
                {
                    y = Convert.ToDouble(textBlock_2.Text);
                    rez = x - y;
                    textBlock_2.Text = Convert.ToString(rez);
                }
                if (buf[buf.Length - 1] == '*')
                {
                    y = Convert.ToDouble(textBlock_2.Text);
                    rez = x * y;
                    textBlock_2.Text = Convert.ToString(rez);
                }
                if (buf[buf.Length - 1] == '/')
                {
                    //создаем изключение деления на ноль
                    y = Convert.ToDouble(textBlock_2.Text);
                    if (y == 0)
                        throw new Exception("На 0 делить нельзя!");
                    rez = x / y;
                    textBlock_2.Text = Convert.ToString(rez);
                }
            }
            //ловим исключение деления на ноль
            catch (Exception ex)
            {
                textBlock_2.Text = ex.Message;
                btn_0.IsEnabled=false;
                btn_00.IsEnabled=false;
                btn_1.IsEnabled=false;
                btn_2.IsEnabled=false;
                btn_3.IsEnabled=false;
                btn_4.IsEnabled=false;
                btn_6.IsEnabled=false;
                btn_5.IsEnabled=false;
                btn_7.IsEnabled=false;
                btn_8.IsEnabled=false;
                btn_9.IsEnabled=false;
                btn_change.IsEnabled=false;
                btn_comma.IsEnabled=false;
                btn_deleting.IsEnabled=false;
                btn_div.IsEnabled=false;
                btn_equally.IsEnabled=false;
                btn_minus.IsEnabled=false;
                btn_multip.IsEnabled=false;
                btn_plus.IsEnabled=false;   
                btn_proc.IsEnabled=false;
                btn_sq.IsEnabled=false;
                root.IsEnabled=false;
            }
            finally
            {
                rez = 0;
                x = 0; y = 0;
                textBlock_1.Text = "";
            }
        }
    }
}
