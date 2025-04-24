using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        try
        {
        User sam = new User("Sam", "Sam@blabla.com", "aaaAaabc1");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}