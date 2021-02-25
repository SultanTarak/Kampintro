using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IOrderService
    {
        void Add(Game order);
        void Update(Game order);
        void Delete(Game order);
    }
}
