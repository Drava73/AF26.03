using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF26._03
{
    class Wildebeest : Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; }
        public Wildebeest(int weight)
        {
            Weight = weight;
            Life = true;
        }
        public void Eat_Grass()
        {
            Weight += 10;
        }
    }
    class Bison : Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; }
        public Bison(int weight)
        {
            Weight = weight;
            Life = true;
        }
        public void Eat_Grass()
        {
            Weight += 10;
        }
    }
    class Lion : Carnivore
    {
        public int Power;
        public Lion(int power)
        {
            Power = power;
        }
        public void Eat(Herbivore wildebeast)
        {
            if (wildebeast.Life == false)
                throw new Exception("He is allredy dead!");
            if (wildebeast.Weight > Power)
            {
                Power -= 10;
                return;
            }
            Power += 10;
            wildebeast.Life = false;
        }
    }
    class Wolf : Carnivore
    {
        public int Power;
        public Wolf(int power)
        {
            Power = power;
        }
        public void Eat(Herbivore wildebeast)
        {
            if (wildebeast.Life == false)
                throw new Exception("He is allredy dead!");
            if (wildebeast.Weight > Power)
            {
                Power -= 10;
                return;
            }
            Power += 10;
            wildebeast.Life = false;
        }
    }
    class Africa : Continent
    {
        public Carnivore CreateCarnivore(int power)
        {
            return new Lion(power);
        }
        public Herbivore CreateHerbivore(int weight)
        {
            return new Wildebeest(weight);
        }
    }
    class North_America : Continent
    {
        public Carnivore CreateCarnivore(int power)
        {
            return new Wolf(power);
        }
        public Herbivore CreateHerbivore(int weight)
        {
            return new Bison(weight);
        }
    }
}
