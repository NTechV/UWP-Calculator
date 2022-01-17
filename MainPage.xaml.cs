using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        double result = 0.0;
        char op;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void answerbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "1";
            this.answerbox.Text = input;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "2";
            this.answerbox.Text = input;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "3";
            this.answerbox.Text = input;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "4";
            this.answerbox.Text = input;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "5";
            this.answerbox.Text = input;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "6";
            this.answerbox.Text = input;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "7";
            this.answerbox.Text = input;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "8";
            this.answerbox.Text = input;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "9";
            this.answerbox.Text = input;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            this.answerbox.Text = "";
            input += "0";
            this.answerbox.Text = input;
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            op2 = input;
            double num1, num2;

            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);
            switch (op)
            {
                case '+':
                    try
                    {
                        result = num1 + num2;
                        answerbox.Text = result.ToString();
                        
                    }
                    catch (Exception ex) {}
                    break;
                case '-':
                    try
                    {
                        result = num1 - num2;
                        answerbox.Text = result.ToString();
                    }
                    catch(Exception ex) { }
                    break;
                case '*':
                    try
                    {
                        result = num1 * num2;
                        answerbox.Text = result.ToString();
                    }
                    catch { }
                    break;
                case '/':
                    try
                    {
                        result = num1 / num2;
                        answerbox.Text = result.ToString();
                        if (num1 == 0)
                            answerbox.Text = "Cannot divide by zero!";
                        if (num2 == 0)
                            answerbox.Text = "Cannot divide by zero!";
                    }
                    catch(Exception ex) { }
                    break;
                case '%':
                    try
                    {
                        result = num1 % num2;
                        answerbox.Text = result.ToString();
                    }
                    catch (Exception ex)
                    { }
                    break;
                default:
                    
                    break;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
          
            this.answerbox.Text = "";
            this.input = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            op1 = input;
            op = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            op1 = input;
            op = '-';
            input = string.Empty;
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            op1 = input;
            op = '*';
            input = string.Empty;
        }

        private void divison_Click(object sender, RoutedEventArgs e)
        {
            op1 = input;
            op = '/';
            input = string.Empty;
        }

        private void modulues_Click(object sender, RoutedEventArgs e)
        {
            op1 = input;
            op = '%';
            input = string.Empty;
            //use insert key to remove replace mode
        }
    }
}
