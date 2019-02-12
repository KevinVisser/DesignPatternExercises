using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExercises.Design_Patterns.Composite_Pattern
{
    public class Bike
    {
        private string type;
        private List<Bike> bikeParts;

        public Bike(string type)
        {
            this.type = type;
            bikeParts = new List<Bike>();
        }

        public void Add(Bike b)
        {
            bikeParts.Add(b);
        }

        public void Remove(Bike b)
        {
            bikeParts.Remove(b);
        }

        public List<Bike> GetBikeParts()
        {
            return bikeParts;
        }

        public string toString()
        {
            return ("Bike :[ Type: " + type + " ]");
        }
    }
}
