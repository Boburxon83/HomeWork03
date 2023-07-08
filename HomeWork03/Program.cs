namespace HomeWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int userInput;
            int count = 1;
            Random rand = new Random();

            number = rand.Next(1, 100);

            Console.WriteLine("1 dan 100 gacha bo'lgan sonni toping, bu qaysi son = ");

            while (true)
            {
                Console.WriteLine("Sizning variantingiz = ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Siz variantingiz to'g'ri bu " + number + " soni. Siz " + count + " - chi urinishda topdingiz.");
                    break;
                }
                if (userInput > number)
                {
                    Console.WriteLine($"Sizning variantingizdagi son {userInput} dan kichik:");
                }
                else
                {
                    Console.WriteLine($"Sizning variantingizdagi son {userInput} dan katta:");
                }
                count++;
            }
            Console.ReadLine();
        }
    }
 }