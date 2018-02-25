using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<Animal> mammalsGroup = new Group<Animal>("Mammals");
            mammalsGroup.Add(new Cat());
            mammalsGroup.Add(new Dog());
            Group<Animal> flyingGroup = new Group<Animal>("Flying");
            flyingGroup.Add(new Bug());
            flyingGroup.Add(new Raven());
            Group<Animal> otherGroup = new Group<Animal>("Others");
            otherGroup.Add(new Snake());

            ShowInfo(mammalsGroup);
            ShowInfo(flyingGroup);
            ShowInfo(otherGroup);

            Console.Read();
        }

        static void ShowInfo(Group<Animal> animalGroup)
        {
            foreach (var animal in animalGroup.GetList())
            {
                Console.WriteLine(animalGroup.GroupName);
                animal.Info();
            }
        }
    }
}
