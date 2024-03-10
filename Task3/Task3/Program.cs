namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int netice = 1;
            int a = 1;
           
            if( eded < 0)
            {
                Console.WriteLine("Duzgun deyer daxil edin");
            }
            else
            {
               while ( a <= eded) 
            {

                netice *= a;
                a++;
            }  
                    Console.WriteLine(netice);

            }
            
            
            
            
                 

                



        }
    }
}
