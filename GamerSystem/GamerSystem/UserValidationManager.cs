using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    public class UserValidationManager : IUserValidationServices
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Ufuk" && gamer.IdNumber == 1 && gamer.LastName == "Değer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
