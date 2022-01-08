using System;

namespace DIO.games
{
    class Program
    {
        static GameRepository repository = new GameRepository();

        static void Main(string[] args)
        {
            string userOption = GetUserOption();
            
            while(userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        //ListGames();
                        break;
                    case "2":
                        //InsertGame();
                        break;
                    case "3":
                        //UpdateGame();
                        break;
                    case "4":
                        //DeleteGame();
                        break;
                    case "5":
                        //ViewGame();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }

        }


        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("DIO games at your service!!");
            Console.WriteLine("Select the desired option...");

            Console.WriteLine("1- Games List");
            Console.WriteLine("2- Insert new game");
            Console.WriteLine("3- Update game");
            Console.WriteLine("4- Delete game");
            Console.WriteLine("5- View game");
            Console.WriteLine("C- Clean screen");
            Console.WriteLine("X- Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return userOption;
        }
    }
}
