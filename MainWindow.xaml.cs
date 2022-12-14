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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal firstnum;
        decimal secondnum;
        char op;
        bool displayingResult = false;  

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {  
            if (displayingResult)
            {
                TxtResult.Clear();  
            }
            displayingResult = false;
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
            secondnum = decimal.Parse(TxtResult.Text);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            firstnum = decimal.Parse(TxtResult.Text);
            op = '/';
            TxtResult.Clear();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            firstnum = decimal.Parse(TxtResult.Text);
            op = '*';
            TxtResult.Clear();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            firstnum = decimal.Parse(TxtResult.Text);
            op = '-';
            TxtResult.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            firstnum = decimal.Parse(TxtResult.Text);
            op = '+';
            TxtResult.Clear();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            secondnum = decimal.Parse(TxtResult.Text);
            decimal result = 0;

            displayingResult = true;

            switch (op)
            {
                case '/':
                    result = firstnum / secondnum;
                    break;
                case '*':  
                    result = firstnum * secondnum;
                    break;
                case '-':
                    result = firstnum - secondnum;
                    break;
                case '+':
                    result = firstnum + secondnum;
                    break;
            }

            if (TxtResult.Text == "0")
            {
                TxtResult.Clear();    
            }

            TxtResult.Text = result.ToString(); 
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TxtResult.Clear();
        }
    }
}
