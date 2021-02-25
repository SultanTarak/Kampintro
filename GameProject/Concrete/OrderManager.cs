using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class OrderManager : IOrderService
    {
        public void Add(Game order)
        {
            Console.WriteLine("{0} isimli oyunun satışı yapıldı.", order.GameName);
        }

        public void Delete(Game order)
        {
            Console.WriteLine("{0} isimli oyun silindi.", order.GameName);
        }

        public void Update(Game order)
        {
            Console.WriteLine("{0} isimli oyun güncellendi.", order.GameName);
        }
    }
}
