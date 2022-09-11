Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Осталось ввести чисел {0}", m-i);
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0) sum += 1;
}
Console.WriteLine("Введено чисел больше 0: {0}", sum);