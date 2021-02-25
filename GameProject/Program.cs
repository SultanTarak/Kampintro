using GameProject.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Oyuncular**********");
            GamerManager gamer = new GamerManager(new UserValidationManager());
            gamer.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1987,
                FirstName = "SULTAN",
                LastName = "TARAK",
                IdentityNumber = 12345
            });

            Console.WriteLine();

            Company company1 = new Company { CompanyName = "%15 Bahar indirimi", DiscountPercentage = 15 };
            Company company2 = new Company { CompanyName = "%10 Ay sonu kampanyası", DiscountPercentage = 10 };

            Console.WriteLine("**********Kampanyalar**********");
            CompanyManager companyManager = new CompanyManager();
            companyManager.Add(company1);
            companyManager.Add(company2);
            Console.WriteLine();

            Console.WriteLine("**********Oyunlar**********");
            Game game1 = new Game() { GameName = "Fifa", Price = 80 };
            Game game2 = new Game() { GameName = "Red Dead", Price = 200 };
            Game game3 = new Game() { GameName = "Minecraft", Price = 280 };
            Game[] games = new Game[] { game1, game2, game3 };
            foreach (var game in games)
            {
                Console.WriteLine("\t Oyunun ismi: " + game.GameName + "---> " + "Oyunun fiyatı: " + game.Price);
            }
            Console.WriteLine();

            Console.WriteLine("**********Satışlar**********");
            SellManager sell = new SellManager();
            sell.SellWithCompany1(company1, game1);
            sell.SellWithCompany2(company2, game2);
            sell.SellWithCompany2(company2, game3);

        }
    }
}
