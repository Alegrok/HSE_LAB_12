using System;

namespace HSE_LAB_12
{
    public class Artiodactyls : Mammals
    {
        int hoofSize;

        public int HoofSize
        {
            get { return hoofSize; }
            set
            {
                if (value <= 30 && value >= 1) hoofSize = value;
                else hoofSize = 1;
            }
        }

        public Artiodactyls() : base()
        {
            HoofSize = 1;
        }

        public Artiodactyls(string name, string kind, int weight, int size, int hoofSize) : base(name, kind, weight, size)
        {
            HoofSize = hoofSize;
        }
        public new Animals BaseAnimals

        {
            get
            {
                return new Animals(Name, Kind, Weight);
            }
        }

        public new Artiodactyls CreateObjectAnimals()
        {
            Console.WriteLine("\nВведите имя");
            string name = InputString();
            Console.WriteLine("\nВведите вид");
            string kind = InputString();
            Console.WriteLine("\nВведите вес");
            int weight = InputInt();
            Console.WriteLine("\nВведите размер животного");
            int size = InputInt();
            Console.WriteLine("\nВведите размер копыта");
            int hoofSize = InputInt(1, 30);
            return new Artiodactyls(name, kind, weight, size, hoofSize);
        }

        public new Artiodactyls CreateObjectAnimalsRandom()
        {
            string name = arrayNames[random.Next(0, arrayNames.Length)];
            string kind = arrayKinds[random.Next(0, arrayKinds.Length)];
            int weight = random.Next(1, 10000);
            int size = random.Next(1, 100);
            int hoofSize = random.Next(1, 30);
            return new Artiodactyls(name, kind, weight, size, hoofSize);
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Размер копыта = " + HoofSize);
        }

        public override bool Equals(object obj)
        {
            Artiodactyls animal = (Artiodactyls)obj;
            return Name.Equals(animal.Name) & Kind.Equals(animal.Kind) & Weight == animal.Weight & Size == animal.Size & HoofSize == animal.HoofSize;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), HoofSize, BaseAnimals);
        }
    }
}
