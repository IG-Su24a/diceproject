namespace diceproject
{
    using System.ComponentModel.Design;

    
        internal class Program
        {
            static void Main(string[] args)
            {
                Random rand = new Random();

                int Totallt = 0;
                Console.WriteLine("Hello and welcome to the game of dice. Start by writing roll. ");
                String choice = Console.ReadLine();

                while (choice.ToLower() == "roll")
                {
                    int randomNumbrer = rand.Next(1, 7);
                    Totallt += randomNumbrer;

                    Console.WriteLine($"You rolled {randomNumbrer}");
                    Console.WriteLine($"Your total in points is now {Totallt}");
                    Console.WriteLine("Roll to continue or say stopp to end the game");

                    choice = Console.ReadLine();

                    if (Totallt > 21)
                    {
                        Console.WriteLine("hahah you lost");
                        break;
                    }

                }
                if (choice == "stay")
                {
                    Console.WriteLine("You ended your turn");

                }
                else
                {
                    Console.WriteLine("You didin't write roll or stop, Please write one of those");
                }

                Console.WriteLine($"You ended the game. Your total score is {Totallt}");
            }
        }
    }


