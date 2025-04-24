using System;
using System.Text.Json.Serialization;

class Program
{
  static void Main(string[] args)
  {
    bool exit = false;
    Console.WriteLine("Welcome to the calculator!");


    do
    {
      DisplayMenu();

      string? input = GetCorrectMenuOption(AskInput("your menu option"));

      DoOperation(input, out exit);
      
    } while (exit == false);

  }


  static void DisplayMenu()
  {
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1- Addition");
    Console.WriteLine("2- Subtraction");
    Console.WriteLine("3- Multiplication");
    Console.WriteLine("4- Division");
    Console.WriteLine("5- Square root");
    Console.WriteLine("6- Power");
    Console.WriteLine("7- Exit");
  }


  static string GetCorrectMenuOption(string input)
  {
    if (!VerifyIntInput(input) || !VerifyMenuOptions(Convert.ToInt32(input)))
    {
      do
      {
        input = AskInput("a valid option");
      } while (!VerifyIntInput(input) || !VerifyMenuOptions(Convert.ToInt32(input)));
    }
    return input;
  }


  static bool VerifyMenuOptions(int input)
  {
    if (input >= 1 && input <= 7)
      return true;
    else
      return false;
  }


  static double GetDoubleInput(string whatYouAsk = "your number")
  {
    string? input = AskInput(whatYouAsk);

    if (!VerifyDoubleInput(input))
    {
      do
      {
        input = AskInput("a correct number");

      } while (!VerifyDoubleInput(input));
    }

    return double.Parse(input);
  }


  static bool VerifyDoubleInput(string input)
  {
    bool isCorrect = false;
    isCorrect = double.TryParse(input, out double result);

    if (isCorrect)
      return true;
    else
      return false;
  }


  static bool VerifyIntInput(string input)
  {
    bool isCorrect = false;
    isCorrect = int.TryParse(input, out int result);

    if (isCorrect)
      return true;
    else
      return false;
  }


  static string AskInput(string typeOfInput)
  {
    Console.WriteLine($"Please enter {typeOfInput}.");
    return Console.ReadLine();
  }


  static void DoOperation(string input, out bool exit)
  {
    double number1;
    double number2;
    exit = false;

    switch (Convert.ToInt32(input))
    {
      //Add
      case 1:
        number1 = GetDoubleInput("your first number");
        number2 = GetDoubleInput("your second number");
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        break;
      //Subtract
      case 2:
        number1 = GetDoubleInput("your first number");
        number2 = GetDoubleInput("your second number");
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        break;
      //Multiply
      case 3:
        number1 = GetDoubleInput("your first number");
        number2 = GetDoubleInput("your second number");
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        break;
      //Divide
      case 4:
        number1 = GetDoubleInput("your dividend");
        number2 = GetDoubleInput("your divider");
        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        break;
      //Sqrt
      case 5:
        number1 = GetDoubleInput();
        Console.WriteLine($"Square root of {number1} = {Math.Sqrt(number1)}");
        break;
      //Power
      case 6:
        number1 = GetDoubleInput();
        number2 = GetDoubleInput("the power");
        Console.WriteLine($"{number1} to the power of {number2} = {Math.Pow(number1, number2)}");
        break;
      case 7:
        exit = true;
        break;
    }
  }
}
