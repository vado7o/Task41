// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Программа, показывающая сколько чисел больше нуля ввёл пользователь.");
Console.WriteLine("Вам необходимо ввести любые пять чисел");

List<int> array = new List<int>();
int count = 0;

while (count < 5)
{
    Console.Write("\nВведите следующее любое число : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        array.Add(number);
        count++;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

Console.Write("\nCгенерированный массив - [ " + String.Join(", ", array) + " ]");
Console.WriteLine("\nКоличество элементов массива больше 0: " + CalcPositive(array));

int CalcPositive(List<int> array)
{
    int count = 0;
    for(int index = 0; index < array.Count; index++)
    {
        if(array[index] > 0)
        {
            count++;
        }
    }
    return count;
}