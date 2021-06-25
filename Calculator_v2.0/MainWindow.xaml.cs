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
using Calculator_v2._0.Others;


namespace Calculator_v2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int commar = 0;
        public static int numbr = 0;
        public static int Prn = 0;
        public static int chr = 0;
        public static string num1 = null;
        public static int lght = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BlockUnlock(int n)
        {
            if (n == 1)
            {
                btn0.IsEnabled = false;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
                btnClearEntry.IsEnabled = false;
                btnEQU.IsEnabled = false;
                btnDivide.IsEnabled = false;
                btnMULT.IsEnabled = false;
                btnMINUS.IsEnabled = false;
                btnPLUS.IsEnabled = false;
                btnERASE.IsEnabled = false;
                btnCOMMA.IsEnabled = false;
                txbSMALL.Text = "";
            }
            else if (n == 2)
            {
                btn0.IsEnabled = true;
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
                btn8.IsEnabled = true;
                btn9.IsEnabled = true;
                btnClearEntry.IsEnabled = true;
                btnEQU.IsEnabled = true;
                btnDivide.IsEnabled = true;
                btnMULT.IsEnabled = true;
                btnMINUS.IsEnabled = true;
                btnPLUS.IsEnabled = true;
                btnERASE.IsEnabled = true;
                btnCOMMA.IsEnabled = true;
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 0;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txbBIG.Text += 9;
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txbBIG.Text = null;
                commar = 0;
                Prn = 0;
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txbBIG.Text = null;
                txbSMALL.Text = null;
                commar = 0;
                Prn = 0;
                numbr = 0;
                num1 = null;
                BlockUnlock(2);
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = txbBIG.Text;
                if ((num1 != string.Empty) && (txbBIG.Text != "-"))
                {
                    txbSMALL.Text = txbBIG.Text + "/";
                    txbBIG.Text = null;
                    numbr = 5;
                    commar = 0;

                    btnEQU.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }
        }

        private void btnMULT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = txbBIG.Text;
                if ((num1 != string.Empty) && (txbBIG.Text != "-"))
                {
                    txbSMALL.Text = txbBIG.Text + "×";
                    txbBIG.Text = null;
                    numbr = 6;
                    commar = 0;

                    btnEQU.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }
        }

        private void btnMINUS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbBIG.Text == string.Empty)
                {
                    txbBIG.Text = "-";
                    Prn = 1;
                }
                else if ((txbBIG.Text != null) && (txbBIG.Text != "-"))
                {
                    num1 = txbBIG.Text;
                    if (num1 != string.Empty)
                    {
                        txbSMALL.Text = txbBIG.Text + "-";
                        txbBIG.Text = null;
                        numbr = 7;
                        Prn = 0;
                        commar = 0;

                        btnEQU.IsEnabled = true;
                    }
                }

            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }

        }

        private void btnPLUS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = txbBIG.Text;
                if ((num1 != string.Empty) && (txbBIG.Text != "-"))
                {
                    txbSMALL.Text = txbBIG.Text + "+";
                    txbBIG.Text = null;
                    numbr = 8;
                    commar = 0;

                    btnEQU.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }
        }

        private void btnEQU_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((num1 != string.Empty) && (txbBIG.Text != "-") && (txbBIG.Text != string.Empty))
                {
                    if (numbr == 1)
                    {
                        txbSMALL.Text += txbBIG.Text + "=";

                        num1 = null;
                        commar = 0;
                    }
                    else if (numbr == 3)
                    {
                        txbSMALL.Text += txbBIG.Text;
                        txbBIG.Text = (Calcul.Pow(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                        string str = txbBIG.Text;
                        if (txbBIG.Text.Length > 11)
                        {
                            txbBIG.Text = null;
                            txbBIG.Text = Convert.ToString(str[0]) + "," + Convert.ToString(str[1]) + Convert.ToString(str[2]);
                            txbBIG.Text += $"×10^{str.Length - 1}";
                        }

                        num1 = null;
                        commar = 0;
                    }
                    else if (numbr == 5)
                    {
                        txbSMALL.Text += txbBIG.Text + "=";
                        txbBIG.Text = (Calcul.Divide(num1, txbBIG.Text));
                        if (txbBIG.Text.Length > 10)
                        {
                            string text = txbBIG.Text;
                            txbBIG.Text = null;
                            for (int i = 0; i < 10; i++)
                            {
                                txbBIG.Text += text[i];
                            }

                        }
                        commar = 0;
                        num1 = null;
                    }
                    else if (numbr == 6)
                    {
                        txbSMALL.Text += txbBIG.Text + "=";
                        txbBIG.Text = (Calcul.Multiply(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                        string str = txbBIG.Text;
                        if (txbBIG.Text.Length > 11)
                        {
                            txbBIG.Text = null;
                            txbBIG.Text = Convert.ToString(str[0]) + "," + Convert.ToString(str[1]) + Convert.ToString(str[2]);
                            txbBIG.Text += $"×10^{str.Length - 1}";
                        }
                        commar = 0;
                        num1 = null;
                    }
                    else if (numbr == 7)
                    {
                        txbSMALL.Text += txbBIG.Text + "=";
                        txbBIG.Text = (Calcul.Minus(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();
                        commar = 0;
                        num1 = null;
                    }
                    else if (numbr == 8)
                    {
                        txbSMALL.Text += txbBIG.Text + "=";
                        txbBIG.Text = (Calcul.Plus(Convert.ToDouble(num1), Convert.ToDouble(txbBIG.Text))).ToString();

                        string str = txbBIG.Text;
                        if (txbBIG.Text.Length > 11)
                        {
                            txbBIG.Text = null;
                            txbBIG.Text = Convert.ToString(str[0]) + "," + Convert.ToString(str[1]) + Convert.ToString(str[2]);
                            txbBIG.Text += $"×10^{str.Length - 1}";
                        }

                        commar = 0;
                        num1 = null;
                    }

                    btnEQU.IsEnabled = false;
                }
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }

        }

        private void btnCOMMA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (commar == 0)
                {
                    txbBIG.Text += ",";
                    commar = 1;
                }
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }
        }

        private void btnERASE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int lenght = txbBIG.Text.Length - 1;
                string text = txbBIG.Text;
                txbBIG.Text = null;
                for (int i = 0; i < lenght; i++)
                {
                    txbBIG.Text += text[i];
                }
            }
            catch (Exception)
            {
                txbBIG.Text = "Ошибка";
                BlockUnlock(1);
            }
        }
    }
}
