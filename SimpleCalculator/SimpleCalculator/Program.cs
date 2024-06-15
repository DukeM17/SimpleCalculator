using SimpleCalculator;

Console.Write("Please enter the operation (add, subtract, multiply or divide): ");
var operation = Validator.ValidateOperation(Console.ReadLine()!);

Console.Write("Please enter the first number: ");
var firstNumber = Validator.ValidateNumber(Console.ReadLine()!);

Console.Write("Please enter the second number: ");
var secondNumber = Validator.ValidateNumber(Console.ReadLine()!);

switch (operation!.ToLower())
{
    case "add":
        Console.WriteLine($"Result: {Calculator.Add(firstNumber, secondNumber)}");
        break;
    case "subtract":
        Console.WriteLine($"Result: {Calculator.Subtract(firstNumber, secondNumber)}");
        break;
    case "multiply":
        Console.WriteLine($"Result: {Calculator.Multiply(firstNumber, secondNumber)}");
        break;
    case "divide":
        Console.WriteLine($"Result: {Calculator.Divide(firstNumber, secondNumber)}");
        break;
}