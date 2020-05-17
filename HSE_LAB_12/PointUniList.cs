using System;

namespace HSE_LAB_12
{
    public class PointUniList
    {
        private static Random random = new Random();
        public const int maxCount = 100;
        public Animals animal;
        public PointUniList next;

        public PointUniList()
        {
            animal = new Animals();
            next = null;
        }

        public PointUniList(Animals a)
        {
            animal = a;
            next = null;
        }

        public override string ToString()
        {
            return animal + " ";
        }

        static PointUniList MakePoint(Animals a)
        {
            PointUniList p = new PointUniList(a);
            return p;
        }

        public static PointUniList MakeList(int size)
        {
            Animals a = new Animals();
            a = a.CreateObjectAnimalsRandom();
            Console.WriteLine("Элемент {0} добавляется ...", a.ToString());
            PointUniList beg = MakePoint((Animals)a.Clone());
            for (int i = 1; i < size; i++)
            {
                a = a.CreateObjectAnimalsRandom();
                Console.WriteLine("Элемент {0} добавляется ...", a.ToString());
                PointUniList p = MakePoint((Animals)a.Clone());
                p.next = beg;
                beg = p;
            }
            return beg;
        }

        public static void ShowList(PointUniList beg)
        {
            if (beg == null)
            {
                Console.WriteLine("\nСписок пустой");
                return;
            }
            PointUniList p = beg;
            Console.WriteLine("\nСписок:");
            while (p != null)
            {
                Console.WriteLine(p.ToString());
                p = p.next;
            }
        }

        public static PointUniList AddPoint(PointUniList beg, int number)
        {
            Animals a = new Animals();
            a = a.CreateObjectAnimalsRandom();
            Console.WriteLine("\nЭлемент {0} добавляется ...", a.ToString());
            PointUniList NewPoint = MakePoint((Animals)a.Clone());
            if (beg == null)
            {
                beg = MakePoint((Animals)a.Clone());
                return beg;
            }
            if (number == 1)
            { 
                NewPoint.next = beg;
                beg = NewPoint;
                return beg;
            }
            PointUniList p = beg;
            for (int i = 1; i < number - 1 && p != null; i++) p = p.next;
            NewPoint.next = p.next;
            p.next = NewPoint;
            return beg;
        }

        public static PointUniList DelElement(PointUniList beg, int number)
        {
            if (number == 1)
            {
                beg = beg.next;
                return beg;
            }
            PointUniList p = beg;
            for (int i = 1; i < number - 1 && p != null; i++) { p = p.next; }
            p.next = p.next.next;
            return beg;
        }
        
        public static PointUniList DelEvenObjects(PointUniList beg)
        {
            if (beg == null) // пустой список
            {
                Console.WriteLine("\nОшибка! Список пустой");
                return null;
            }

            while (beg.animal.Weight % 2 == 0 & beg != null)
            {
                beg = beg.next;
            }
            PointUniList p = beg;
            // ищем элемент для удаления и встаем на предыдущий
            while (p != null)
            {
                if (p.next == null) break;
                else if (p.next.animal.Weight % 2 == 0) p.next = p.next.next;
                else p = p.next; // переход к следующему элементу
            }
            return beg;
        }

        public static int GetCount(PointUniList beg)
        {
            int i = 0;
            PointUniList p = beg;
            while (p != null)
            {
                i++;
                p = p.next; // переход к следующему элементу
            }
            return i;
        }
    }
}
