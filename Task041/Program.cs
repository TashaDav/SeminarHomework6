// Пользователь вводит с клавиатуры М чисел. Посчитать, сколько чисел больше 0 ввел
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4 

Console.Write("Введине количесвто элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];

for(int i = 0; i < M; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine().ToString());
}
int element (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
Console.WriteLine($"Число > 0: {element(array)}");