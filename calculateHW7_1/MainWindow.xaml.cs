using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Collections.Generic;
namespace calculateHW7_1
{
    public partial class MainWindow : Window
    {
        bool checkPlus = false; bool checkMinus = false;
        bool checkDivide = false; bool checkMultiply = false;
        string leftOperand; double leftPars;
        double result = 0;
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string> { "light", "dark", "dictionary1" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "Dictionary1";
        }
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            //determine the path to the file
            var uri=new Uri(style+".xaml",UriKind.Relative);
            //loading resource dictionary
            ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
            //we clear app resource collection
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 1;
        }
        private void two_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 2;
        }
        private void three_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 3;
        }
        private void four_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 4;
        }
        private void five_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 5;
        }
        private void six_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 6;
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 7;
        }
        private void eight_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 8;
        }
        private void nine_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 9;
        }
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            txt.Text += 0;
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            leftOperand = txt.Text;
            try { leftPars = Convert.ToDouble(leftOperand); }
            catch (FormatException)
            {
                MessageBox.Show("Не корректные данные!\r\nПовторите попытку");
            }
            checkPlus = true;
            txt.Clear();
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            leftOperand = txt.Text;
            try { leftPars = Convert.ToDouble(leftOperand); }
            catch (FormatException)
            {
                MessageBox.Show("Не корректные данные!\r\nПовторите попытку");
            }
            checkMinus = true;
            txt.Clear();
        }
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            leftOperand = txt.Text;
            try { leftPars = Convert.ToDouble(leftOperand); }
            catch (FormatException)
            {
                MessageBox.Show("Не корректные данные!\r\nПовторите попытку");
            }
            checkDivide = true;
            txt.Clear();
        }
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            leftOperand = txt.Text;
            try { leftPars = Convert.ToDouble(leftOperand); }
            catch (FormatException)
            {
                MessageBox.Show("Не корректные данные!\r\nПовторите попытку");
            }
            checkMultiply = true;
            txt.Clear();
        }
        private void equally_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result = Convert.ToDouble(txt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не корректные данные!\r\nПовторите попытку");
                txt.Clear();
            }
            if (checkPlus == true)
            {
                result += leftPars;
                txt.Text = result.ToString();
                checkPlus = false;
            }
            if (checkMinus == true)
            {
                result = leftPars - result;
                txt.Text = result.ToString();
                checkMinus = false;
            }
            if (checkDivide == true)
            {
                result = leftPars / result;
                txt.Text = result.ToString();
                checkDivide = false;
            }
            if (checkMultiply == true)
            {
                result *= leftPars;
                txt.Text = result.ToString();
                checkMultiply = false;
            }
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txt.Clear();
        }
    }
}