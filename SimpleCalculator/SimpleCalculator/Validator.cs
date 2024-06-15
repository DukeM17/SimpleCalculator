namespace SimpleCalculator;

public static class Validator
{
    public static string ValidateOperation(string operation)
    {
        if (operation == "add" || operation == "subtract" || operation == "multiply" || operation == "divide")
        {
            return operation.ToLower();
        }
        var message = "Operation not legitimate";
        Console.WriteLine(message);
        throw new Exception(message);
    }

    public static int ValidateNumber(string number)
    {
        try
        {
            return int.Parse(number);
        }
        catch
        {
            Console.WriteLine("Could not parse input number, please ensure it is an integer");
            throw;
        }
    }
}
