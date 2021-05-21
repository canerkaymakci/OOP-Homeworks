using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class FruitType2:Fruits
    {

    }


    class Apple : FruitType2
    {
        public Apple()
        {
            VitaminA = 54;
            VitaminC = 5;
            imageOfFruits=Image.FromFile("apple.png");
        }
    }

    class Pear : FruitType2
    {
        public Pear()
        {
            VitaminA = 25;
            VitaminC = 5;
            imageOfFruits = Image.FromFile("pear.png");
        }
    }

    class Strawberry : FruitType2
    { 
        public Strawberry()
        {
            VitaminA = 12;
            VitaminC = 60;
            imageOfFruits = Image.FromFile("strawberry.png");
        }
    }
}
