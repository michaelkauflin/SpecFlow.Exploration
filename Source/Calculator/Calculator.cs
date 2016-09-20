namespace SpecFlow.Exploration
{
    public class Calculator
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }

        public int Result { get; private set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public void Add(int first, int second)
        {
            Result = first + second;
        }

        public void Subtract(int first, int second)
        {
            Result = first - second;
        }
    }
}
