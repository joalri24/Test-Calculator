using System;
using System.Windows;
using System.Windows.Controls;

namespace testCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Attributes

        private Calculator calculator;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        #endregion


        #region Routed Event Handlers

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var currentValue = this.screen.Text;
            var numberButton = (Button) sender;
            this.screen.Text = currentValue + ((string) numberButton.Content);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.screen.Text = string.Empty;
            this.operationText.Text = string.Empty;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.firstValue = Convert.ToSingle(this.screen.Text);
            this.screen.Text = string.Empty;

            var operatorButton = (Button)sender;
            var operation = (string)operatorButton.Content;

            switch (operation)
            {
                case "+":
                    calculator.operation = Calculator.Operators.sum;
                    break;
                case "-":
                    calculator.operation = Calculator.Operators.substraction;
                    break;
                case "X":
                    calculator.operation = Calculator.Operators.multiplication;
                    break;
                case "/":
                    calculator.operation = Calculator.Operators.division;
                    break;
                default:
                    return;
            }

            this.operationText.Text = $"{calculator.firstValue} {operation} ";

        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.operation == Calculator.Operators.none)
                return;

            calculator.secondValue = Convert.ToSingle(this.screen.Text);
            screen.Text = "" + calculator.Calculate();
            operationText.Text = string.Empty;
            calculator.Clear();
        }

        #endregion
    }
}
