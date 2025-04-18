using System;
using System.Text.Json.Serialization;

class Program
{
  static void Main(string[] args)
  {
    double number1;
    double number2;
    int menuOption;
    DisplayMenu();

    string? input = AskInput("your menu option");

    //Verify a correct menu option
    if (!VerifyIntInput(input) || !VerifyMenuOptions(Convert.ToInt32(input)))
    {
      do
      {
        input = AskInput("a valid option");
      } while (!VerifyIntInput(input) || !VerifyMenuOptions(Convert.ToInt32(input)));
    }

    //Do the operation

    switch (Convert.ToInt32(input))
    {
      //Add
      case 1:
        number1 = GetDoubleInput();
        number2 = GetDoubleInput();
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        break;
      //Subtract
      case 2:
        number1 = GetDoubleInput();
        number2 = GetDoubleInput();
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        break;
      //Multiply
      case 3:
        number1 = GetDoubleInput();
        number2 = GetDoubleInput();
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        break;
      //Divide
      case 4:
        number1 = GetDoubleInput();
        number2 = GetDoubleInput();
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
        number2 = GetDoubleInput();
        Console.WriteLine($"{number1} to the power of {number2} = {Math.Pow(number1, number2)}");
        break;
    }

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
  }

  static bool VerifyMenuOptions(int input)
  {
    if (input >= 1 && input <= 6)
      return true;
    else
      return false;
  }
  static double GetDoubleInput()
  {
    string? input = AskInput("your number");

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


  static int GetIntInput()
  {
    string? input = AskInput("your menu option");

    if (!VerifyIntInput(input))
    {
      do
      {
        input = AskInput("a correct option");

      } while (!VerifyIntInput(input));
    }

    return int.Parse(input);
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
}