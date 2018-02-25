using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Snake : Animal
    {
        public Snake()
        {
            _animalName = "Snake";
            _legsCount = 0;
            _withTail = true;
        }
        public override void Action()
        {
            Console.WriteLine(AnimalName + " can do: Ssss");
        }
    }
}
