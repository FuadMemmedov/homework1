namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            bool sade = true;
            
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
                        sade = false;
                        break;
                    }
                }
                if (sade)
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

