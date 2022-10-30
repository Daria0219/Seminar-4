/* программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B
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

/* 2. программа, которая принимает на вход число и выдаёт сумму цифр в числе

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
*/

/* программа, которая задаёт массив из 8 элементов и выводит на экран массив из сумм цифр каждого числа

void FillArr (int[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = new Random().Next(0,10000);}
}
void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
        {Console.Write($"{arr[pos]} ");
        pos++;}
}
int[] mass1 = new int[8];
Console.WriteLine("массив из 8 чисел:");
FillArr(mass1);
PrintArray(mass1);
Console.WriteLine();

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
Console.WriteLine("массив из сумм цифр каждого числа первого массива:");
int[] mass2 = new int[8];
    for (int ind=0; ind<mass2.Length; ind++){
        mass2[ind]=Sum(mass1[ind]);}
PrintArray(mass2);
*/

// Дополнительно
// 1. Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные

void FillArr (int[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = new Random().Next(0,100);}
}
void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
        {Console.Write($"{arr[pos]} ");
        pos++;}
}
Console.WriteLine("Введите число элементов массива");
int len = int.Parse(Console.ReadLine());
int[] massiv = new int [len];

Console.WriteLine("Введите массив столбцом");
FillArr(massiv);

int[] massiv2 = new int [len];
    int index = 1;
    int temp = 0;
    int j=0;
    massiv2[0]=massiv[0];
    while (index<len){
        if (massiv[index] == 0) 
            {   while (j<len) {
                if (massiv[j] != 0) {
                    temp = massiv[j];
                    massiv[j]=0; 
                    massiv[index]=temp}
                else j++;}            }
        index++;}

Console.WriteLine();
Console.WriteLine("исходный массив:");

PrintArray(massiv);
/*
int[] massiv2 = new int [len];
    for (int j=0; j<kol0; j++){
        massiv2[j]=0;
    }
    for (int i=kol0; i<massiv2.Length; i++){
        if (massiv[i-kol0] != 0) massiv2[i]=massiv[i];
} */
Console.WriteLine();
Console.WriteLine("преобразованный массив:");
PrintArray(massiv2);