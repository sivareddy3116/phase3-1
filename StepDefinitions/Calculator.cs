namespace SpecFlowAssignment_1.StepDefinitions
{
    public class Calculator
    {
        private int result;

        public void EnterNumber(int number)
        {
            result = number;
        }

        public void Multiply(int number)
        {
            result *= number;
        }

        public void Subtract(int number)
        {
            result -= number;
        }

        public void Divide(int number)
        {
            if (number != 0)
            {
                result /= number;
            }
            else
            {
                // Handle division by zero if needed
                throw new ArgumentException("Cannot divide by zero.");
            }
        }

        public int GetResult()
        {
            return result;
        }

        internal void Subtract()
        {
            throw new NotImplementedException();
        }

        internal void Multiply()
        {
            throw new NotImplementedException();
        }

        internal void Divide()
        {
            throw new NotImplementedException();
        }
    }


}