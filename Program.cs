task();

int ReadInt(string argument)
{
    System.Console.WriteLine("введите день недели");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void task()
{
	System.Console.WriteLine(GetHolidays(ReadInt ("number")));

}

int GetHolidays(int number)
{
  if (number <= 5)
  {
    System.Console.WriteLine("нет,это будни сэр");
  }

   else
  {
    System.Console.WriteLine("так точно сэр,выходные");
  }

  if (number > 7)
  { 
    System.Console.WriteLine($"в неделе не {number} дней");
  }
  return number;
}
