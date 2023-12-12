namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soda = 0;
            int newsoda = 0;
            int soldsoda = 0;
            int chips = 0;
            int newchips = 0;
            int soldchips = 0;
            int candy = 0;
            int soldcandy = 0;
            int newcandy = 0;
            Console.WriteLine("Welcome to the restocking tool.");
            Console.WriteLine("How many sodas have been sold today? 100 are in stock.");
            soldsoda = int.Parse(Console.ReadLine());

            if (soldsoda > 100)
            {
                Console.WriteLine("Too high, stock not adjusted");
            }
            else
            {
                soda = 100;
                newsoda = soda - soldsoda;
                Console.WriteLine("There were " + soldsoda + " sodas sold today");
                Console.WriteLine("There are " + newsoda + " sodas left in stock");
            }


            Console.WriteLine("How many chips have been sold today? 40 are in stock. ");
            soldchips = int.Parse(Console.ReadLine());
            if (soldchips > 40)
            {
                Console.WriteLine("Too high, stock not adjusted");
            }
            else
            {
                chips = 40;
                newchips = chips - soldchips;
                Console.WriteLine("There were " + soldchips + " chips sold today");
                Console.WriteLine("There are " + newchips + " chips left in stock");              
            }


            Console.WriteLine("How many candy have been sold today? 60 are in stock. ");
            soldcandy = int.Parse(Console.ReadLine());
            if (soldcandy > 60)
            {
                Console.WriteLine("Too high, stock not adjusted");
            }
            else
            {
                candy = 60;
                newcandy = candy - soldcandy;
                Console.WriteLine("There were " + soldcandy + " candy sold today");
                Console.WriteLine("There are " + newcandy + " candy left in stock");
            }
            if (newcandy <= 40)
                {
                Console.WriteLine("Candy needs to be restocked.");
                }
            if (newsoda <= 40)
            {
                Console.WriteLine("Soda needs to be restocked.");
            }
            if (newchips <= 20)
            {
                Console.WriteLine("Chips need to be restocked.");
            }
        }
    }
}
