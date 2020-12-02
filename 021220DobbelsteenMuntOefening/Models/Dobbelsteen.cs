using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021220DobbelsteenMuntOefening.Models
{
    public class Dobbelsteen : RandomElement
    {
        public override int Gooi()
        {
            return GetGenerator().Next(1,7);
        }
    }
}
