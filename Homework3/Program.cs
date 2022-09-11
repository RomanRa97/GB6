//Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Если кол-во элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.
//1, 3, 8, 3, 2 -> 11 8, 3, 4, 2 -> 28


Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
Random rnd = new Random();

int sum = 0;

for (int i = 0; i<len; i++)
{
    array[i] = rnd.Next(1,10);
}

for (int y = 0; y < len/2; y++)
{
    sum += array[y] * array[len-(y+1)];
}

Console.Write("[{0}] -> {1}", string.Join(", ", array), sum);