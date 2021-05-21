using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public abstract class Fruits
    {
        public Random random=new Random();
        public Image imageOfFruits = null;


        public int VitaminA { get; set; }
        public int VitaminC { get; set; }
        public int Weight { get; set; }
        public int Efficiency { get; set; }
    }
}
