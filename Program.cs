task();



int ReadInt(string argument)
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void task()
{
	System.Console.WriteLine(GetSecondDigit(ReadInt ("number")));
}


int GetSecondDigit(int number)
{
  if (number < 10)
  {
    return -1;
  }

  while(number > 100)
  {
	number /=10;
  }
  return number % 10;
}