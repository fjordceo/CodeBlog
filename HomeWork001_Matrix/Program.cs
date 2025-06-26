namespace HomeWork001_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delay = 3000; 

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Wake up, Neo... ");
            ClearScreenWithDelay(delay);

            Console.Write("The Matrix has you... ");
            ClearScreenWithDelay(delay);

            Console.Write("Follow the white rabbit... ");
            ClearScreenWithDelay(delay);

            Console.Write("Knock, knock, Neo... ");
            ClearScreenWithDelay(delay);

            Console.ResetColor(); 
            Console.Write("Press any key to exit...");

        }

        static void ClearScreenWithDelay(int delay)
        {
            System.Threading.Thread.Sleep(delay);
            Console.Clear();
        }
    }
}


