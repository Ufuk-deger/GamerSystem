using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    public class GamerManager : IGamerService
    {
       IUserValidationServices _userValidation;

        public GamerManager(IUserValidationServices userValidation)
        {
            _userValidation = userValidation;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Eklendi-"+gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }         
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
