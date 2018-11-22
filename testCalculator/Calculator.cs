namespace testCalculator
{
    /// <summary>
    /// Class that contains the logic of the calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Operations supported by the calculator.
        /// </summary>
        public enum Operators
        {
            sum,
            substraction,
            multiplication,
            division,
            none

        }

        /// <summary>
        /// The "left side" value of the operation.
        /// </summary>
        public float firstValue { get; set; }

        /// <summary>
        /// The currently selecte operation. 
        /// </summary>
        public Operators operation { get; set; }

        /// <summary>
        /// The "right side" value of the operation.
        /// </summary>
        public float secondValue { get; set; }

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Calculator()
        {
            operation = Operators.none;
        }

        /// <summary>
        /// Performs a mathematical operation according to the values stored in the attributes. 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Clears the values stored in the calculator.
        /// </summary>
        public void Clear()
        {
            operation = Operators.none;
        }

        /// <summary>
        /// Adds the two numbers passed as parameter.
        /// </summary>
        /// <param name="number1">A number to be added.</param>
        /// <param name="number2">A number to be added</param>
        /// <returns></returns>
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
