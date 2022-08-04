namespace Calculator
{
    public class MyCalculator
    {
        public string DivideTwoNumbers(string firstNumberStr, string secondNumberStr)
        {
            if (double.TryParse(firstNumberStr, out double firstNumber) && double.TryParse(secondNumberStr, out double secondNumber))
            {
                if (secondNumber == 0)
                    return "Cannot divide to zero";
                double result = firstNumber / secondNumber;
                return $"Result of divide is {result}";
            }
            else
            {
                return "Parameters are not integer";
            }
        }

        public string DivideTwoNumbersFromFile(string filePath, IFileReader fileReader)
        {
            var allLines = fileReader.GetLines(filePath);
            return DivideTwoNumbers(allLines[0], allLines[1]);
        }
    }

    public interface IFileReader
    {
        string[] GetLines(string filePath);
    }

    public class MyFileReader : IFileReader
    {
        public string[] GetLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
