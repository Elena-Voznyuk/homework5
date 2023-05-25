// Задача 34
/*int [] CreatNewArray (int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}
void ShowArray (int [] array1)
{
    for (int i  = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " "); 
        Console.WriteLine();
}
void CountOfHonestNumbers (int [] array2)
{
    int result = 0;
    for (int i =0; i < array2.Length; i++)
        if (array2[i] % 2 == 0)
           result ++;
    Console.WriteLine($"Count of honest numbers is {result}");         
}
Console.WriteLine("Input count of elements to array:");
int count = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int [] array1 = CreatNewArray(count, minValue, maxValue);
ShowArray(array1);
CountOfHonestNumbers(array1);


// Задача 36
int [] CreatNewArray (int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}
void ShowArray (int [] array1)
{
    for (int i  = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " "); 
        Console.WriteLine();
}
void SumOfElements (int [] array2)
{
    int sum = 0;
    for (int i  = 1; i < array2.Length; i = i + 2)
        sum += array2[i];
    Console.WriteLine($"Sum of elementst is {sum}");   
}
Console.WriteLine("Input count of elements to array:");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] array_origin = CreatNewArray(count, minValue, maxValue);
ShowArray(array_origin);
SumOfElements(array_origin);
*/


// Задача 38
double [] CreatNewArray (int size, int min, int max)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round ((new Random().Next(min, max + 1) + new Random().NextDouble()), 1);
        
    return  array;
}
void ShowArray (double [] array1)
{
    for (int i  = 0; i < array1.Length; i++)
        Console.Write(array1[i] + "   "); 
        Console.WriteLine();
}

void Difference (double [] array2)
{
    double min = array2[0];
    for (int i  = 0; i < array2.Length; i++)
        if (array2[i] < min)
           min = array2[i];  
    double max = array2[0]; 
    for (int i  = 0; i < array2.Length; i++)     
        if (array2[i] > max)   
        max = array2[i];
        double result = Math.Round((max - min), 1);
    Console.WriteLine($"Difference is {result}");      
}
  Console.WriteLine("Input count of elements to array:");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array:");
int maxValue = Convert.ToInt32(Console.ReadLine());
double [] array_origin = CreatNewArray(count, minValue, maxValue);
ShowArray(array_origin);
Difference(array_origin);     