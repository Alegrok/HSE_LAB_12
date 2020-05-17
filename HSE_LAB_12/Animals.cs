using System;
using System.Collections.Generic;

namespace HSE_LAB_12
{
    public interface IExecutable
    {
        public abstract void Show();

        public abstract Animals CreateObjectAnimals();

        public abstract Animals CreateObjectAnimalsRandom();

        public abstract int InputInt();

        public abstract int InputInt(int min, int max);

        public abstract string InputString();
    }

    public class Animals : IExecutable, IComparable, ICloneable
    {
        protected Random random = new Random();
        protected string[] arrayNames = {"Жучка", "Синий", "Снежок", "Дакар", "Летяга", "Шарик", "Жвачка", "Дэнни", "Тайсон", "Джек" };
        protected string[] arrayKinds = { "Собака", "Кошка", "Лис", "Синица", "Корова", "Воробей", "Мышь", "Конь", "Хомяк", "Дельфин" };
        string name;
        string kind;
        int weight;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != value.Replace(" ", "")) name = "Неизвестный";
                else name = value;
            }
        }

        public string Kind
        {
            get { return kind; }
            set
            {
                if (value != value.Replace(" ", "")) kind = "Неизвестный";
                else kind = value;
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 10000 && value >= 1) weight = value;
                else weight = 1;
            }
        }

        public Animals()
        {
            Name = "Неизвестный";
            Kind = "Неизвестный";
            Weight = 1;
        }

        public Animals(string name, string kind, int weight)
        {
            Name = name;
            Kind = kind;
            Weight = weight;
        }

        public Animals CreateObjectAnimals()
        {
            Console.WriteLine("\nВведите имя");
            string name = InputString();
            Console.WriteLine("\nВведите вид");
            string kind = InputString();
            Console.WriteLine("\nВведите вес");
            int weight = InputInt(1, 10000);
            return new Animals(name, kind, weight);
        }
         
        public Animals CreateObjectAnimalsRandom()
        {
            string name = arrayNames[random.Next(0,arrayNames.Length)];
            string kind = arrayKinds[random.Next(0, arrayKinds.Length)];
            int weight = random.Next(1, 10000);
            return new Animals(name, kind, weight);
        }

        virtual public void Show()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Вид: " + Kind);
            Console.WriteLine("Вес = " + Weight);
        }

        public int CompareTo(object obj)
        {
            Animals animals = (Animals)obj;
            if (string.Compare(Name, animals.Name) > 0) return 1;
            else if (string.Compare(Name, animals.Name) < 0) return -1;
            else return 0;
        }

        public Animals ShallowCopy()
        {
            return (Animals)MemberwiseClone();
        }

        public object Clone()
        {
            return new Animals(Name, Kind, Weight);
        }

        public override bool Equals(object obj)
        {
            Animals animal = (Animals)obj;
            return Name.Equals(animal.Name) & Kind.Equals(animal.Kind) & Weight == animal.Weight;
        }

        public string InputString()
        {
            string str;
            bool inputCheck;
            do
            {
                Console.Write("\nВвод: ");
                str = Console.ReadLine();
                inputCheck = str != "";
                if (!inputCheck) Console.WriteLine("Ошибка ввода! Введите не пустые данные\n");
            } while (!inputCheck);
            return str;
        }

        public int InputInt()
        {
            int number;
            bool inputCheck;
            do
            {
                Console.Write("\nВвод: ");
                inputCheck = int.TryParse(Console.ReadLine(), out number);
                if (!inputCheck) Console.WriteLine("Ошибка ввода! Введите целое число\n");
            } while (!inputCheck);
            return number;
        }

        public int InputInt(int min, int max)
        {
            int number;
            bool inputCheck;
            do
            {
                Console.Write("\nВвод: ");
                inputCheck = int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;
                if (!inputCheck) Console.WriteLine("Ошибка ввода! Введите целое число в пределах от {0} до {1} (включительно)\n", min, max);
            } while (!inputCheck);
            return number;
        }

        public override string ToString()
        {
            return name + " " +  kind + " " + weight;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Kind, Weight);
        }
    }

    public class AnimalsComparer : IComparer<Animals>
    {
        public int Compare(Animals animal1, Animals animal2)
        {
            if (string.Compare(animal1.Kind, animal2.Kind) > 0) return 1;
            else if (string.Compare(animal1.Kind, animal2.Kind) < 0) return -1;
            else return 0;
        }
    }
}
