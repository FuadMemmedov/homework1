namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            int i = Convert.ToInt32(Console.ReadLine());
            int qaliq = 0;
            int netice = 1;
            while (i > 0)
            {
                qaliq = i % 10;
                netice *= qaliq;
                i /= 10;
            }
            Console.WriteLine(netice);
        }
    }
}
