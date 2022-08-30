// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("введите пятизначное число: ");
string N=Console.ReadLine();

int length=N.Length;
if (length==5)
{
   if (N[0]==N[4])
   {
    if (N[1]==N[3])
    {
        Console.WriteLine("данное число является палиндромом");
    }
   }
   else
   {
    Console.WriteLine("данное число НЕ является палиндромом");
   } 
}
else
{
    Console.WriteLine("введено не пятизначное число");
}

