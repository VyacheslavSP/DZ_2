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
  Console.WriteLine("Вы ввели больше одного числа или дробное число");
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
int len=0;
Byte correct_len =0;

len=Number_str.Length;
if(Number_str.IndexOf(',')!=-1)       //если дробное которое записали через точку
  {
    Console.WriteLine("Вы ввели дробное число");
}
else
{
  if(Number_str.IndexOf('-')!=-1) //отрицательное
    {
    correct_len=4;        // корректная длина строки 4 символа
    }
    else
    {
    correct_len=3;        // корректная длина строки 3 символа
    }
}
if (len!=correct_len)
{
  Console.WriteLine("Введено некорректное число");
}
else
{
int Correct_number= int.Parse(Number_str);
int tmp_num=Correct_number/10;
float RETURN_NUM=tmp_num%10;
RETURN_NUM=Math.Abs(RETURN_NUM); // модуль для корректного выведения второй цифры орицательного числа
Console.WriteLine(RETURN_NUM);
}
