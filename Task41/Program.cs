// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// ВАРИАНТ 1

Console.Write(" Введите несколько чисел =  ");
string nums = Console.ReadLine() + " ";

int[] array = nums.Split(",")
                .Select(item => item.Replace(" ", ""))
                .Select(item => int.Parse(item))
                .ToArray();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.Write(String.Join(", ", array) + "->");
Console.WriteLine(count);



// ВАРИАНТ 2

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
     if (array[i] > 0)
     {
         count++;
     }
}
Console.Write(String.Join(", ", array) + "->");
Console.WriteLine(count);

