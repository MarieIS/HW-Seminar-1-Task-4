Console.Write("Insert number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Insert number2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Insert number3: ");
int number3 = int.Parse(Console.ReadLine());

 if (number1 == number2 || number1 == number3 || number2 == number3)
 {
    Console.WriteLine("no maximum");
 }

 else if (number1 > number2 && number1 > number3)
 {
    Console.WriteLine($"{number1} is the maximum");
 }

 else if (number2 > number1 && number2 > number3)
 {
    Console.WriteLine($"{number2} is the maximum");
 }

 else
 {
    Console.WriteLine($"{number3} is the maximum");
 }