using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming
{
    public class Fleet
    {
        private List<Thing> things;



        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }
        public List<Thing> ListOfThings()
        {
            return things;
        }
    }
}