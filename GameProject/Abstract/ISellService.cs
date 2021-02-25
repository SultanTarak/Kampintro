using GameProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISellService
    {
        void SellWithCompany1(Company company, Game order);
        void SellWithCompany2(Company company, Game order);
    }
}
