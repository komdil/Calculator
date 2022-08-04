using Calculator;

MyCalculator myCalculator = new();
MyFileReader myFileReader = new MyFileReader();
while (true)
{
    Console.WriteLine("Enter file path");
    var fileApth = Console.ReadLine();
    Console.WriteLine(myCalculator.DivideTwoNumbersFromFile(fileApth, myFileReader));

    //Console.WriteLine("Enter the first number");
    //var firstNumber = Console.ReadLine();

    //Console.WriteLine("Enter the second number");
    //var secondNumber = Console.ReadLine();

    //Console.WriteLine(myCalculator.DivideTwoNumbers(firstNumber, secondNumber));
}