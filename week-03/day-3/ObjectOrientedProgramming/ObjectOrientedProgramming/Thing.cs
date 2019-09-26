﻿using System;

namespace ObjectOrientedProgramming
{
    public class Thing
    {
        public string name;
        public bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            completed = true;
        }
    }
}