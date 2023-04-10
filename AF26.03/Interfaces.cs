using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF26._03
{
    interface Herbivore
    {
        int Weight { get; set; }
        bool Life { get; set; }
        void Eat_Grass();
    }
    interface Carnivore
    {
        void Eat(Herbivore herbivore);
    }
    interface Continent
    {
        Herbivore CreateHerbivore(int weight);
        Carnivore CreateCarnivore(int power);
    }
}
