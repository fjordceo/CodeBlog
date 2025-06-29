namespace HomeWork002_Int;

// Получить с консоли значение трех чисел с приведением к типу int.
// Условным оператором выбрать наибольшее из них.
// Вывести это число на консоль.
// Сравнить на четность с помощью Switch.
// Проверить на < 100 с помощью тернарного оператора.



class Program
{
    static void Main(string[] args)
    {
        // Основные переменные
        int firstValue;
        int secondValue;
        int thirdValue;
        
        
        // Запрос ввода значений с консоли
        Console.Write("Введите первое число: ");
        firstValue = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите второе число: ");
        secondValue = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите третье число: ");
        thirdValue = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
        
        // Определение наибольшего числа
        if (firstValue >= secondValue && firstValue >= thirdValue)
        {
            Console.WriteLine($"Наибольшее число: {firstValue}");
        }
        else if (secondValue >= firstValue && secondValue >= thirdValue)
        {
            Console.WriteLine($"Наибольшее число: {secondValue}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число: {thirdValue}");
        }

        Console.WriteLine();
        
        // Проверка на четность с помощью Switch
        switch (firstValue % 2)
        {
            case 0:
                Console.WriteLine($"{firstValue} - четное число");
                break;
            default:
                Console.WriteLine($"{firstValue} - нечетное число");
                break;
        }
        switch (secondValue % 2)
        {
            case 0:
                Console.WriteLine($"{secondValue} - четное число");
                break;
            default:
                Console.WriteLine($"{secondValue} - нечетное число");
                break;
        }
        switch (thirdValue % 2)
        {
            case 0:
                Console.WriteLine($"{thirdValue} - четное число");
                break;
            default:
                Console.WriteLine($"{thirdValue} - нечетное число");
                break;
        }

        Console.WriteLine();
        
        // Проверка на < 100 с помощью тернарного оператора
        Console.WriteLine(firstValue < 100 ? $"{firstValue} меньше 100" : $"{firstValue} не меньше 100");
        Console.WriteLine(secondValue < 100 ? $"{secondValue} меньше 100" : $"{secondValue} не меньше 100");
        Console.WriteLine(thirdValue < 100 ? $"{thirdValue} меньше 100" : $"{thirdValue} не меньше 100");
        
        
        Console.WriteLine();
    }
}