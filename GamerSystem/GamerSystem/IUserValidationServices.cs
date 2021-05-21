using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    public interface IUserValidationServices
    {
        public bool Validate(Gamer gamer);
    }
}
