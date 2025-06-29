namespace Episode005
/*
 * Коллекции. Массивы, списки, словари
 */


{
    internal class Program
    {
        enum Days // Создание перечислителя для перебора элементов списка
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,  
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // Создание массива целых чисел длиной 5
            numbers[0] = 1; // Присваивание значения первому элементу массива
            numbers[1] = 2; // Присваивание значения второму элементу массива
            numbers[2] = 3; // Присваивание значения третьему элементу массива
            numbers[3] = 4; // Присваивание значения четвертому элементу массива
            numbers[4] = 5; // Присваивание значения пятому элементу массива

            Console.WriteLine($"Пятый элемент массива = {numbers[4]}");

            List<int> numberList = new List<int>(); // Создание пустого списка целых чисел
            numberList.Add(115); // Добавление элемента в список
            numberList.Add(2227); // Добавление второго элемента в список
            Console.WriteLine($"Первый элемент списка = {numberList[0]}");

            Console.WriteLine(Days.Friday);
            
               

        }

        


            


        
    }
}

