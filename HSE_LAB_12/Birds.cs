using System;

namespace HSE_LAB_12
{
    public class Birds : Animals
    {
        int beakSize;

        public int BeakSize
        {
            get { return beakSize; }
            set
            {
                if (value <= 50 && value >= 1) beakSize = value;
                else beakSize = 1;
            }
        }

        public Birds() : base()
        {
            BeakSize = 1;
        }

        public Birds(string name, string kind, int weight, int beakSize) : base(name, kind, weight)
        {
            BeakSize = beakSize;
        }

        public Animals BaseAnimals
        {
            get
            {
                return new Animals(Name, Kind, Weight);
            }
        }

        public new Birds CreateObjectAnimals()
        {
            Console.WriteLine("\nВведите имя");
            string name = InputString();
            Console.WriteLine("\nВведите вид");
            string kind = InputString();
            Console.WriteLine("\nВведите вес");
            int weight = InputInt(1, 10000);
            Console.WriteLine("\nВведите размер клюва");
            int beakSize = InputInt(1, 50);
            return new Birds(name, kind, weight, beakSize);
        }

        public new Birds CreateObjectAnimalsRandom()
        {
            string name = arrayNames[random.Next(0, arrayNames.Length)];
            string kind = arrayKinds[random.Next(0, arrayKinds.Length)];
            int weight = random.Next(1,10000);
            int beakSize = random.Next(1, 50);
            return new Birds(name, kind, weight, beakSize);
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Размер клюва = " + BeakSize);
        }

        public override bool Equals(object obj)
        {
            Birds animal = (Birds)obj;
            return Name.Equals(animal.Name) & Kind.Equals(animal.Kind) & Weight == animal.Weight & BeakSize == animal.BeakSize;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), BeakSize, BaseAnimals);
        }
    }
}
