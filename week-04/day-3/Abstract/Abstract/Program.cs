using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract
{
    public abstract class Instrument
    {
        protected string Name { get; set; }
        public virtual void Play()
        {
            Console.WriteLine("Playing on an instrument");
        }
    }


    public abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine($"{Name}, a {NumberOfStrings}-stringed instrument that {Sound()}");
        }
    }

    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            NumberOfStrings = 6;
            Name = "Electric Guitar";
        }
        public ElectricGuitar(int n)
        {
            NumberOfStrings = n;
            Name = "Electric Guitar";
        }
        public override string Sound()
        {
            return "twangs";
        }
    }


    public class BassGuitar : StringedInstrument
    {
        public BassGuitar ()
        {
            NumberOfStrings = 4;
            Name = "Bass Guitar";
        }
        public BassGuitar(int n)
        {
            NumberOfStrings = n;
            Name = "Bass Guitar";
        }
        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }

    public class Violin : StringedInstrument
    {
        public Violin()
        {
            NumberOfStrings = 4;
            Name = "Violin";
        }
        public Violin(int n)
        {
            NumberOfStrings = n;
            Name = "Violin";
        }
        public override string Sound()
        {
            return "screeches";
        }
       
    }
}
