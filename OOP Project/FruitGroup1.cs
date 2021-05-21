using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{

    public class FruitType1:Fruits
    {

    }

    public class Orange : FruitType1
    {
        public Orange()
        {
            VitaminA = 225;
            VitaminC = 45;
            imageOfFruits=Image.FromFile("orange.png");
        }
    }

    public class Grapefruit : FruitType1
    {
        public Grapefruit()
        {
            VitaminA = 3;
            VitaminC = 44;
            imageOfFruits=Image.FromFile("grapefruit.png");
        }
    }

    public class Mandarin : FruitType1
    {
        public Mandarin()
        {
            VitaminA = 681;
            VitaminC = 26;
            imageOfFruits=Image.FromFile("mandarin.png");
        }
    }


}
