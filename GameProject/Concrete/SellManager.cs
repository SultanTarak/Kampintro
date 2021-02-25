using GameProject;
using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SellManager : ISellService
    {
        public void SellWithCompany1(Company company, Game game)
        {

            game.Price = game.Price - (15 * game.Price) / 100;

            Console.WriteLine("Müşteri, " + company.CompanyName + " kampanyasını kullandı");
            Console.WriteLine("Oyunu kampanya ile " + game.Price + " TL'ye aldı");
        }

        public void SellWithCompany2(Company company, Game game)
        {

            game.Price = game.Price - (10 * game.Price) / 100;
            Console.WriteLine("Müşteri, " + company.CompanyName + " kampanyasını kullandı");
            Console.WriteLine("Oyunu kampanya ile " + game.Price + " TL'ye aldı");

        }
    }


}

