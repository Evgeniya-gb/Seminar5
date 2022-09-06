//34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num_s = new int[size];
Array_of_Random_Num_s(num_s);
Console.Clear();
Console.WriteLine("Массив: ");
Array(num_s);
int count = 0;

for (int a = 0; a < num_s.Length; a++)
if (num_s[a] % 2 == 0)
count++;

Console.WriteLine($"{count} чисел из массива - чётные");

void Array_of_Random_Num_s(int[] num_s)
{
    for(int i = 0; i < num_s.Length; i++)
    {
        num_s[i] = new Random().Next(100,1000);
    }
}
void Array(int[] num_s)
{
    Console.Write("[ ");
    for(int i = 0; i < num_s.Length; i++)
    {
        Console.Write(num_s[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 

int Num_s(int size, int min, int max)
  {
  int[] Num_s = new int[size];
  int sum = 0;
  Console.Write("Массив: ");

    for (int i = 0; i <Num_s.Length; i++ ){
      Num_s[i] = new Random().Next(min, max);

      Console.Write(Num_s[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + Num_s[i];
      }
    }
  return sum;
  }

int RandomNum_s =  Num_s(size, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {RandomNum_s}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[5];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(-10, 100);
    Console.Write(array[i] + " ");
  }

double max = array[0];
double min = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (max < array[i])
    {
      max = array[i];
    }
        if (min > array[i])
    {
      min = array[i];
    }
  }

  Double difference = max - min;

  Console.WriteLine($"\nРазница между между максимальным элементом {max} и минимальным элементом {min} массива: {difference}");


