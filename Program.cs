// программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B
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
