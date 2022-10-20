bool Flag_correct=false;
byte day=1;
while (Flag_correct== false)
{
  string tmp_answer="";
Console.WriteLine("Введите  число от одного до семи");
String Temp_numbers = Console.ReadLine();
try                                                                   ///вариант проверки через исключения выглядит короче, но, как я понимаю, в серьезной программе к нему лучше не пребегать
{
  day=byte.Parse(Temp_numbers);
  if (1 <= day && day <= 7)
{
  Flag_correct=true;
}
else
{
    Console.WriteLine("некорректный ввод числа");
}
}
catch
{
    Console.WriteLine("некорректный ввод числа");
}
}
if (1 <= day && day <= 5)
{
  Console.WriteLine("рабочий день");
}
else
{
    Console.WriteLine("выходной день");
}
