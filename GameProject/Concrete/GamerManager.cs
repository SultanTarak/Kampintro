using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("{0}{1} isimli oyuncu kaydedildi.", gamer.FirstName, gamer.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0}{1} isimli oyuncu kaydı silindi.", gamer.FirstName, gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0}{1} isimli oyuncu kaydı güncellendi.", gamer.FirstName, gamer.LastName);
        }
    }
}
