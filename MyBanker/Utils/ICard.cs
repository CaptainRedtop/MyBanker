using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Utils
{
    internal interface ICard
    {
        void GenerateCardNumber();
        string ToString();
    }
}
