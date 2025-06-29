namespace Episode007;
/*
 * Циклы. for, while, do while
 * Операторы условного перехода.
 */

class Program
{
    static void Main(string[] args)
    {
        // Стандартный цикл for выводящий числа от 0 до 10
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Цикл for: {i}");
        }

        Console.WriteLine();

        // Цикл while, который будет выполняться пока i меньше 10
        int a = 0;
        while (a <= 10)
        {
            Console.WriteLine("Цикл while: " + a);
            a++;
        }

        Console.WriteLine();

        List <string> list = new List<string>();
        while (list.Count < 5)
        {
            Console.Write($"Введите строку {list.Count+1}: ");
            list.Add(Console.ReadLine() ?? string.Empty);
           
        }

        Console.WriteLine();


        // Вывод элементов списка с помощью цикла while
        int i2 = 0;
        Console.WriteLine("Вывод списка на экран: ");
        while (i2<list.Count)
        {
            Console.WriteLine(list[i2]);
            i2++;
        }
        Console.WriteLine();

        // Цикл do while, который выполнится хотя бы один раз
        
        int c = 0;
        do 
        {
            Console.WriteLine("Цикл do while: " + c);
            c++;
        } while (c <= 10);
        Console.WriteLine();

        // for each цикл для перебора элементов списка
        foreach (string item in list)
        {
            Console.WriteLine("Элемент списка: " + item);
        }

        // break - прерывает выполнение цикла
        // continue - пропускает текущую итерацию цикла и переходит к следующей



    }
}

// Создать коллекучию целых чисел (15 элементов)
// Заполнить данными с консоли
// Посчитать сумму всех элементов коллекции (for)
// Посчитать разность всех элементов  (while)
// Посчитать произведение всех элементов (do while)
// Вывести на консоль все элементы коллекции (foreach)