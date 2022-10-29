﻿/* программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите натуральное число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int stepen = int.Parse(Console.ReadLine());

double F(int A, int B){
    double res = Math.Pow(A, B);
    return res;
}
Console.WriteLine();
Console.WriteLine($"{N} в степени {stepen} = {F(N,stepen)}");
Console.WriteLine();
*/

/* 1. цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введите число N");
double N = double.Parse (Console.ReadLine());
Console.WriteLine("Введите степень");
double stepen = double.Parse(Console.ReadLine());

double F(double A, double B)
{   double res=1;
    for (int count=0; count<Math.Abs(B); count++){
    if (B>0)  res = res*A;
    if (B<0)  res = res*(1/A);}
return res;
}
Console.WriteLine();
Console.WriteLine($"{N} в степени {stepen} = {F(N,stepen)}");
Console.WriteLine();
*/

//программа, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите натуральное число N");
int N = int.Parse (Console.ReadLine());

int Sum(int num){
int sum=0;
int temp=0;
int ostatok=num;
    while (ostatok != 0) {
        temp = ostatok%10;
        sum = sum + temp;
        ostatok = ostatok/10;
    }
return sum;
}
Console.WriteLine($"Сумма цифр в числе = {Sum(N)}");

