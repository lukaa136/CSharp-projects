using System;

class Program
{
  static void Main(string[] args)
  {
    decimal number1;
    decimal number2;
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
      case 1:
        number1 = GetDecimalInput();
        number2 = GetDecimalInput();
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        break;
      case 2:
        number1 = GetDecimalInput();
        number2 = GetDecimalInput();
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        break;
      case 3:
        break;
      case 4:
        break;
      case 5:
        break;
      case 6:
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
  static decimal GetDecimalInput()
  {
    string? input = AskInput("your number");

    if (!VerifyDecimalInput(input))
    {
      do
      {
        input = AskInput("a correct number");

      } while (!VerifyDecimalInput(input));
    }

    return decimal.Parse(input);
  }

  static bool VerifyDecimalInput(string input)
  {
    bool isCorrect = false;
    isCorrect = decimal.TryParse(input, out decimal result);

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