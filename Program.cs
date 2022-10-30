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

// Дополнительно
/* 1. Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные

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
int kol0=0;

Console.WriteLine("Введите массив столбцом");
    int index = 0;
    while (index<len){
        massiv[index] = int.Parse(Console.ReadLine());
        if (massiv[index] == 0) kol0++;
        index++;}

Console.WriteLine();

int[] massiv2 = new int [len];
    for (int j=0; j<kol0; j++){
        massiv2[j]=0;
    }
int k = kol0;
    for (int i=0; i<len; i++){
        if (massiv[i] != 0) 
    {   massiv2[k]=massiv[i];
        k++;}
} 
Console.WriteLine();
Console.WriteLine("преобразованный массив:");

PrintArray(massiv2);
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
// Дополнительно №2
// Массив из 12 случайных целых чисел из отрезка [-10;10]
// отрицательных и положительных элементов поровну и нет нулей. При этом порядок следования элементов случаен

int [] CreateMas(){
    int kol = 12;
    int positiv=0;
    int negativ=0;
    int[] arr = new int[12];
    for (int i=0; i<kol; i++){
        arr[i] = new Random().Next(-10,10);
        while (arr[i] == 0) {
            arr[i] = new Random().Next(-10,10);}
        if (arr[i] > 0) {
            positiv++;
            if (positiv>6) arr[i] = new Random().Next(-10,-1);}
        else { negativ++;
            if (negativ>6) arr[i] = new Random().Next(1,10);}
        }
return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ",arr));
}
int[] arr = new int[12];
arr = CreateMas();
Print(arr);