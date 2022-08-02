// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void Length(int a)
{
    string num = a.ToString();
    Console.WriteLine(num.Length);
}
Length(456);
Length(78);
Length(89126);


double Digit(double a,double b)
{
    return((Math.Floor(a/(Math.Pow(10,Math.Floor(Math.Log10(a))-b+1)))%10));
}

double Length(double a)
{
    return(((Math.Floor(Math.Log10(a))+1)));
}
