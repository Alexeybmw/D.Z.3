Console.WriteLine("Введите число:");
string number = Console.ReadLine();

void num (string number)
{
      if ( number [0] == number[4] || number [1] == number[3])
      {
            Console.WriteLine("число -> палиндром." );
      }
      else Console.WriteLine("число -> не палиндром.");
}
if (number.Length==5)
{
      num(number);
}