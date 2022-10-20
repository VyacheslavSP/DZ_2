using System.Text.RegularExpressions;
String Number_str="";
  bool Flag_correct=false;

while (Flag_correct== false)
{
  bool Flag_char=false;
  bool Flag_float=false;
  string tmp_answer="";
Console.WriteLine("Введите  число");
String Temp_numbers = Console.ReadLine();
Regex regex = new Regex(@"\D");
if(Temp_numbers.IndexOf(',')!=-1)       //если дробное число
{
  Flag_float=true;
}
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
if (arr.Length > 1 & Flag_float==false)
{
  Console.WriteLine("Вы ввели больше одного числа");
  Flag_correct=false;
}
else
{
  if(Flag_float)
  {
    string String_tmp_float=string.Concat(arr[0],",",arr[1]) ;
  Console.WriteLine(String_tmp_float);
   Number_str=String_tmp_float;
   Flag_correct=true;
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
}
// блок выполнения задания
int len=0;
bool Flag_err=false;
bool NULL=false;
int Correct_number=0;
int TMP_convert_num_2=0;
len=Number_str.Length;
if(Number_str.IndexOf(',')!=-1)       //если дробное
  {
    float TMP_convert_num=float.Parse(Number_str);      // дополнительная переменная для обработки дробных
    TMP_convert_num=Math.Abs(TMP_convert_num);          // по модулю без проверки
    if (TMP_convert_num*100<1)                        //если при умножении получаем меньше 0 то цифра точно ноль
    {
      Console.WriteLine("третья цифра числа = 0");
    }
    else
    {
      TMP_convert_num_2=(int)(TMP_convert_num*1000);
    if (TMP_convert_num*1000 == TMP_convert_num_2)//целое
  {
    if (TMP_convert_num_2>10)
    {
      while (TMP_convert_num_2>100)
      {
        TMP_convert_num_2/=10;
      }
        TMP_convert_num_2%=10;
        if (TMP_convert_num_2==(int) 0)
          {
              Console.WriteLine("У числа нет 3 цифры!!!");
          }
        }
      }
      else
      {
        if (TMP_convert_num_2>10)
        {
          while (TMP_convert_num_2>100)
          {
            TMP_convert_num_2/=10;
          }
            TMP_convert_num_2%=10;
            Console.WriteLine("третья цифра числа ="+TMP_convert_num_2);
        }
      }

      TMP_convert_num=TMP_convert_num*100;
      Correct_number= (int) TMP_convert_num;
      if (Correct_number>100)
      {
        while (Correct_number>100*10)
        {
          Correct_number/=10;
        }
          Correct_number%=10;
          if (Flag_err!=true)
          {
          Console.WriteLine("третья цифра числа ="+Correct_number);
        }
      }
}
}
else
{
if(Number_str.IndexOf('-')!=-1) //отрицательное
  {
Correct_number= int.Parse(Number_str);
Correct_number=Math.Abs(Correct_number);
  }
  else
  {
Correct_number= int.Parse(Number_str);
  }
if (Correct_number>100)
{
  while (Correct_number>1000)
  {
    Correct_number/=10;
  }
    Correct_number%=10;
    Console.WriteLine("третья цифра числа ="+Correct_number);
}
else
{
    Console.WriteLine("У числа нет 3 цифры");
}
}
/// я так и не смог придумать как только математикой заставить показать 3 чило у положительной дроби с двумя знаками и с тремя после запятой. дроби ищет 3 цифру,какв задаче в не 3 знак
