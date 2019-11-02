using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foxclub.Models;

namespace Foxclub.Models
{
    public class LoFService
    {
        private List<Fox> Foxes { get; set; }

        public LoFService()
        {
            Foxes = new List<Fox>();
        }

        public void AddFox(string name)
        {
            Foxes.Add(new Fox(name));
        }

        public Fox FindFoxByName(string name)
        {
            return Foxes.FirstOrDefault(f => f.name == name);
        }
        public List<Fox> ListAllFoxes()
        {
            return Foxes;
        }
    }
}
