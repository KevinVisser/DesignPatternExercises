using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternExercises.Design_Patterns.Composite_Pattern;

namespace DesignPatternExercises.Design_Patterns.Composite_Pattern
{
    public class CompositeExecute
    {
        public static void Execute()
        {
            Bike fiets = new Bike("Fiets");
            Bike voorWiel = new Bike("Wiel");
            Bike achterWiel = new Bike("Wiel");

            Bike frame = new Bike("Frame");

            Bike spaken = new Bike("Spaken");

            Bike metaal = new Bike("Metaal");

            fiets.Add(voorWiel);
            fiets.Add(achterWiel);
            fiets.Add(frame);

            voorWiel.Add(spaken);
            achterWiel.Add(spaken);

            frame.Add(metaal);

            //print alleen de fiets
            Console.WriteLine(fiets.toString());

            foreach (Bike b in fiets.GetBikeParts())
            {
                Console.WriteLine("\t" + b.toString());
                foreach (Bike bike in b.GetBikeParts())
                {
                    Console.WriteLine("\t\t" + bike.toString());
                }
            }
            Console.ReadLine();
        }


    }
}