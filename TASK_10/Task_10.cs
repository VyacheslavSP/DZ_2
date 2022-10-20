/// блок предворительного запроса и обработки строки ввода, проверка на ошибки при заполнении
using System.Text.RegularExpressions;
String Number_str="";
  bool Flag_correct=false;

while (Flag_correct== false)
{
  bool Flag_char=false;
  string tmp_answer="";
Console.WriteLine("Введите трехзначное число");
String Temp_numbers = Console.ReadLine();
Regex regex = new Regex(@"\D");
MatchCollection Chars = regex.Matches(Temp_numbers);
foreach (Match Char in Chars)
 if (Char.Value.Contains('-')|Char.Value.Contains(','))
 {
    }
    else
    {
      if (Chars.Count >0)
      {
      Flag_char=true;
    }
    }

var arr = Regex.Matches(Temp_numbers, @"-?\d+(\.\d+)?")
    .Cast<Match>()
    .Select(m => m.Value)
    .ToArray();
if (arr.Length > 1)
{
  Console.WriteLine("Вы ввели больше одного числа");
  Flag_correct=false;
}
else
{
  if (arr.Length!= 0)
{
if (Flag_char)
{
  string String_tmp=arr[0];
  String_tmp=String_tmp.Replace('.', ',');
  arr[0]=String_tmp;
  Console.WriteLine("В строке есть символы. Вы имели ввиду число "+arr[0]+ "? (y/n)");
  tmp_answer=Console.ReadLine();
  if (tmp_answer=="y")
  {
    Flag_correct=true;
    Number_str=arr[0];
  }
  else
  {
    Flag_correct=false;
  }
  }
else
{
Number_str=arr[0];
Flag_correct=true;
}
}
}
}
// блок выполнения задания
Console.WriteLine(Number_str);
