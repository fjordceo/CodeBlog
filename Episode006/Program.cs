namespace Episode006
/*
 * Условные операторы. if, switch
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int age;

            Console.Write("А ну-ка скажи сколько у тебя денег? ");
            money = int.Parse(Console.ReadLine() ?? "0"); 

            if (money >1000)
            {
                Console.WriteLine("Ну пошли в клуб!");
            }
            else
            {
                Console.WriteLine("Хрен тебе, а не клуб!");
            }

            // Логические операторы
            // && - логическое И
            // || - логическое ИЛИ
            // ! - логическое НЕ

            // Пример использования оператора Switch
            switch (money)
            {
                case 0:
                    Console.WriteLine("Ты вообще без денег!");
                    break;
                case 100:
                    Console.WriteLine("Ну хоть что-то есть!");
                    break;
                case 1000:
                    Console.WriteLine("Ну ты богатый, конечно!");
                    break;
                default:
                    Console.WriteLine("У тебя денег больше чем 1000, но меньше чем 10000!");
                    break;
            }
            
            // Оператор быстрой проверки (тернарный оператор)
            Console.WriteLine("Сколько тебе лет?");
            age = int.Parse(Console.ReadLine() ?? "0");
            string massage = age > 18 ? "ну ты взрослый!" : "ты еще малой!";
            Console.WriteLine(massage);
        }
    }
}

// Получить с консоли значение трех чисел с приведением к типу int. Условным оператором выбрать наибольшее из них.
// Вывести это число на консоль.
// Сравнить на четность с помощью Switch.
// Проверить на < 100 с помощью тернарного оператора.