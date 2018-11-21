namespace testCalculator
{
    public class Calculator
    {

        public enum Operators
        {
            sum,
            substraction,
            multiplication,
            division,
            none

        }

        public float firstValue { get; set; }

        public Operators operation { get; set; }

        public float secondValue { get; set; }


        public Calculator()
        {
            operation = Operators.none;
        }


        public float Calculate()
        {
            switch (operation)
            {
                case Operators.sum:
                    return Sum(firstValue, secondValue);

                case Operators.substraction:
                    return Substract(firstValue, secondValue);

                case Operators.multiplication:
                    return Multiply(firstValue, secondValue);

                case Operators.division:
                    return Divide(firstValue, secondValue);

                default:
                    return firstValue;
            }
        }

        public void Clear()
        {
            operation = Operators.none;
        }

        private float Sum(float number1, float number2)
        {
            return number1 + number2;
        }

        private float Substract(float number1, float number2)
        {
            return number1 - number2;
        }

        private float Multiply(float number1, float number2)
        {
            return number1 * number2;
        }

        private float Divide(float number1, float number2)
        {
            return number1 / number2;
        }

         





    }
}
