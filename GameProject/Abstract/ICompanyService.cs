using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ICompanyService
    {
        void Add(Company company);
        void Update(Company company);
        void Delete(Company company);
    }
}
