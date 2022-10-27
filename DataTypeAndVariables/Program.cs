using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 1;
          sbyte mySbyte = 1;
          int myInt = 10;
          uint myUint = 1;
          short myShort = 1;
          ushort myUShort = 1;
          float myFloat = 1;
          double myDouble = 1;
          char myCharacter = 'c';
          bool myBool = true;
          string myText = "I control text";
          string numText = "100";

          Console.WriteLine(myByte);
          Console.WriteLine(mySbyte);
          Console.WriteLine(myInt);
          Console.WriteLine(myUint);
          Console.WriteLine(myShort);
          Console.WriteLine(myUShort);
          Console.WriteLine(myFloat);
          Console.WriteLine(myDouble);
          Console.WriteLine(myCharacter);
          Console.WriteLine(myBool);
          Console.WriteLine(myText);
          Console.WriteLine(Text2Num(numText));
      }

      public static int Text2Num(string numText)
      {
        int a;
        bool res = int.TryParse(numText, out a);
        return a;
        throw new NotImplementedException();
      }
    }
}
