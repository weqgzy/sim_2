task();



int ReadInt(string argument)
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void task()
{
	System.Console.WriteLine(GetThirdDigit(ReadInt ("number")));

}


int GetThirdDigit(int number)
{
  if (number < 10)
  {
    return +1;
  }

  if(number < 100)
  {
    System.Console.WriteLine("третьей цифры нет");
    number = 0;
  }

  while(number > 1000)
  {
	number /=10;
  }
  return number % 10;
}

