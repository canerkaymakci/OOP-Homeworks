using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class SqueezerForGroup1 : IFruitGroup1Squeezer
    {
        public void UseSqueezerGroup1(Fruits fruit, ref double tempA, ref double tempC, ref double total, ref double totalA, ref double totalC)
        {
            tempA = Convert.ToDouble(fruit.VitaminA) * Convert.ToDouble(fruit.Efficiency) * Convert.ToDouble(fruit.Weight) / 10000.0;
            tempC = Convert.ToDouble(fruit.VitaminC) * Convert.ToDouble(fruit.Efficiency) * Convert.ToDouble(fruit.Weight) / 10000.0;

            total += Convert.ToDouble(fruit.Weight) * Convert.ToDouble(fruit.Efficiency) / 100.0;
            totalA += tempA;
            totalC += tempC;
        }
    }

    public class SqueezerForGroup2: IFruitGroup2Squeezer
    {
        public void UseSqueezerGroup2(Fruits fruit, ref double tempA, ref double tempC, ref double total, ref double totalA, ref double totalC)
        {
            tempA = Convert.ToDouble(fruit.VitaminA) * Convert.ToDouble(fruit.Efficiency) * Convert.ToDouble(fruit.Weight) / 10000.0;
            tempC = Convert.ToDouble(fruit.VitaminC) * Convert.ToDouble(fruit.Efficiency) * Convert.ToDouble(fruit.Weight) / 10000.0;

            total += Convert.ToDouble(fruit.Weight) * Convert.ToDouble(fruit.Efficiency) / 100.0;
            totalA += tempA;
            totalC += tempC;
        }
    }
}
