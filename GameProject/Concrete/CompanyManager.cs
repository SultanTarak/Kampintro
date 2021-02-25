using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CompanyManager : ICompanyService
    {
        public void Add(Company company)
        {
            Console.WriteLine("{0} kampanyası sisteme eklendi.", company.CompanyName);
        }

        public void Delete(Company company)
        {
            Console.WriteLine("{0} kampanyası bitti.", company.CompanyName);
        }

        public void Update(Company company)
        {
            Console.WriteLine("{0} kampanyası güncellendi.", company.CompanyName);
        }
    }
}
