using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Raven : Animal, IWings
    {
        private readonly bool _withWings;
        public bool WithWings { get { return _withWings; } }
        public Raven()
        {
            _animalName = "Raven";
            _legsCount = 2;
            _withTail = true;
            _withWings = true;
        }
        public override void Action()
        {
            Console.WriteLine(AnimalName + " can do: Karrr");
            if (_withWings)
            {
                Console.WriteLine(AnimalName + " have wings and can fly");
            }
        }
    }
}
