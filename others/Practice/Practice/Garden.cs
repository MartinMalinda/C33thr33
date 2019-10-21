using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Garden
    {
        Flower flower1 = new Flower("yellow");
        Flower flower2 = new Flower("blue");
        Tree tree1 = new Tree("purple");
        Tree tree2 = new Tree("orange");


        public List<Plant> plants = new List<Plant>();
        

        


        
    }

    public abstract class Plant
    {
        protected int CurrentWaterLevel { get; set; } = 0;
        protected int neededWaterLevel;
        protected string Color { get; set; }

        public Plant(string color)
        {
            Color = color;
        }
    }
    public class Flower : Plant
    {
        public Flower(string color):base (color)
        {
            neededWaterLevel = 5;
        }
    }
    public class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            neededWaterLevel = 10;
        }
    }
}
