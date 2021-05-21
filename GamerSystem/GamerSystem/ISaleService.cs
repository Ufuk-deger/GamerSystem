using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem
{
    public interface ISaleService
    {
        void Sale(Sales sales);
        void Return(Sales sales);
    }
}
