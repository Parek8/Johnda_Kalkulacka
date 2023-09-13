float num1, num2, result = 0;
Console.Write("What's your first number?: ");
float.TryParse(Console.ReadLine(), out num1);

Console.Write("\nWhat's your operator?: ");
string Operator = Console.ReadLine();

Console.Write("\nWhat's your second number?: ");
float.TryParse(Console.ReadLine(), out num2);

switch(Operator)
{
    case "+":
        result = Add(num1, num2);
        break;
    case "-":
        result = Substract(num1, num2);
        break;
    case "*":
        result = Multiply(num1, num2);
        break;
    case "/":
        result = Divide(num1, num2);
        break;
    case "%":
        result = Mod(num1, num2);
        break;
}
Console.WriteLine($"The result is: {result}");

float Add(float num1, float num2)
{
    return (num1 + num2);
}
float Substract(float num1, float num2)
{
    return (num1 - num2);
}
float Multiply(float num1, float num2)
{
    return (num1 * num2);
}
float Divide(float num1, float num2)
{
    return (num1 / num2);
}
float Mod(float num1, float num2)
{
    return (num1 % num2);
}