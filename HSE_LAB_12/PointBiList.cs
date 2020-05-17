using System;

namespace HSE_LAB_12
{
    public class PointBiList
    {
        public const int maxCount = 100;
        public static Random random = new Random();
        public Animals animal; // информационное поле
        public PointBiList next; // адрес следующего элемента
        public PointBiList pred; // адрес предыдущего элемента
        
        public PointBiList()
        {
            animal = new Animals();
            next = null;
            pred = null;
        }

        public PointBiList(Animals a)
        {
            animal = a;
            next = null;
            pred = null;
        }

        public override string ToString()
        {
            return animal + " ";
        }

        // создание элемента списка
        static PointBiList MakePoint(Animals a)
        {
            PointBiList p = new PointBiList(a);
            return p;
        }

        // формирование двунаправленного списка
        public static PointBiList MakeList(int size) //добавление в начало
        {
            Animals a = new Animals();
            a = a.CreateObjectAnimalsRandom();
            Console.WriteLine("Элемент {0} добавляется ...", a.ToString());
            PointBiList beg = MakePoint((Animals)a.Clone());
            for (int i = 1; i < size; i++)
            {
                a = a.CreateObjectAnimalsRandom();
                Console.WriteLine("Элемент {0} добавляется ...", a.ToString());
                PointBiList p = MakePoint((Animals)a.Clone());
                p.next = beg;
                beg.pred = p;
                beg = p;
            }
            return beg;
        }

        public static void ShowList(PointBiList beg)
        {
            // проверка наличия элементов в списке
            if (beg == null)
            {
                Console.WriteLine("\nСписок пустой");
                return;
            }
            PointBiList p = beg;
            Console.WriteLine("\nСписок:");
            while (p != null)
            {
                Console.WriteLine(p.ToString());
                p = p.next; // переход к следующему элементу
            }
        }

        public static PointBiList AddPoint(PointBiList beg, int number)
        {
            Animals a = new Animals();
            a = a.CreateObjectAnimalsRandom();
            Console.WriteLine("\nЭлемент {0} добавляется ...", a.ToString());
            // создаем новый элемент
            PointBiList NewPoint = MakePoint((Animals)a.Clone());
            if (beg == null) // список пустой
            {
                beg = MakePoint((Animals)a.Clone());
                return beg;
            }
            if (number == 1) //добавление в начало списка
            {
                beg.pred = NewPoint;
                NewPoint.next = beg;
                beg = NewPoint;
                return beg;
            }
            // вспом. переменная для прохода по списку
            PointBiList p = beg;
            // идем по списку до нужного элемента
            for (int i = 1; i < number - 1 && p != null; i++)
                p = p.next;
            // добавляем новый элемент
            NewPoint.pred = p;
            NewPoint.next = p.next;
            p.next = NewPoint;
            return beg;
        }

        public static PointBiList DelElement(PointBiList beg, int number)
        {
            if (number == 1) // удаляем первый элемент
            {
                beg = beg.next;
                if (beg != null) beg.pred = null;
                return beg;
            }
            PointBiList p = beg;
            // ищем элемент для удаления и встаем на предыдущий
            for (int i = 1; i < number - 1 && p != null; i++)
                p = p.next;
            // исключаем элемент из списка
            p.next = p.next.next;
            p.next.pred = p;
            return beg;
        }

        public static PointBiList AddOddObjects(PointBiList beg)
        {
            int size = GetCount(beg) * 2;
            for (int i = 0; i <= size; i += 2)
            {
                beg = AddPoint(beg, i + 1);
            }
            return beg;
        }

        public static int GetCount(PointBiList beg)
        {
            int i = 0;
            PointBiList p = beg;
            while (p != null)
            {
                i++;
                p = p.next; // переход к следующему элементу
            }
            return i;
        }
    }
}
