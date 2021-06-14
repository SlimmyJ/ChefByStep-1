using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefByStep.API.Entities
{
    public class Step
    {
        public int Id { get; set; }
        public string Instruction { get; set; }
        public int DurationMin { get; set; }
        public bool IsDone { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}