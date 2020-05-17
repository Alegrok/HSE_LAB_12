using System;

namespace HSE_LAB_12
{
    public class Mammals : Animals
    {
        int size;

        public int Size
        {
            get { return size; }
            set
            {
                if (value <= 100 && value >= 1) size = value;
                else size = 1;
            }
        }

        public Mammals() : base()
        {
            Size = 1;
        }

        public Mammals(string name, string kind, int weight, int size) : base(name, kind, weight)
        {
            Size = size;
        }

        public Animals BaseAnimals
        {
            get
            {
                return new Animals(Name, Kind, Weight);
            }
        }

        public new Mammals CreateObjectAnimals()
        {
            Console.WriteLine("\nВведите имя");
            string name = InputString();
            Console.WriteLine("\nВведите вид");
            string kind = InputString();
            Console.WriteLine("\nВведите вес");
            int weight = InputInt();
            Console.WriteLine("\nВведите размер животного");
            int size = InputInt();
            return new Mammals(name, kind, weight, size);
        }

        public new Mammals CreateObjectAnimalsRandom()
        {
            string name = arrayNames[random.Next(0, arrayNames.Length)];
            string kind = arrayKinds[random.Next(0, arrayKinds.Length)];
            int weight = random.Next(1, 10000);
            int size = random.Next(1, 50);
            return new Mammals(name, kind, weight, size);
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Размер животного = " + Size);
        }

        public override bool Equals(object obj)
        {
            Mammals animal = (Mammals)obj;
            return Name.Equals(animal.Name) & Kind.Equals(animal.Kind) & Weight == animal.Weight & Size == animal.Size;
        }

        public new object Clone()
        {
            return new Mammals(Name, Kind, Weight, Size);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Size, BaseAnimals);
        }
    }
}
