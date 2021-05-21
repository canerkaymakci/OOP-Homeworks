using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    interface IFruitGroup1Squeezer
    {
        void UseSqueezerGroup1(Fruits fruit, ref double tempA, ref double tempC, ref double total, ref double totalA, ref double totalC);
    }

    interface IFruitGroup2Squeezer
    {
        void UseSqueezerGroup2(Fruits fruit, ref double tempA, ref double tempC, ref double total, ref double totalA, ref double totalC);
    }
}
