namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            
            if (eded < 1)
            {
                Console.WriteLine("Duzgun eded daxil edin");
            
            }
            else if(eded == 1)
            {
                Console.WriteLine("Ne sade ededdir nede murekkeb");
            }
            else
            {
                for(int a = 2; a < eded; a++) 
                { 
                  if(eded % a == 0)
                    {
                        i=1;
                        break;
                    }
                }
                if (i==0)
                {
                    Console.WriteLine("Sade ededdir");

                }
                else
                {
                   Console.WriteLine("Murekkeb ededdir");
                }
            }
        }
    }    
}

