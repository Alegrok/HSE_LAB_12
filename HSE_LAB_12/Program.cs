using System;

namespace HSE_LAB_12
{
    class Program
    {
        static void Main(string[] args)
        {
            PointUniList uniListBeg = null;
            PointBiList biListBeg = null;
            PointTree pointTree = null;
            Tree<Animals> tree = null;

            Console.WriteLine("Добро пожаловать в приложение по работе с коллекциями!");

            while (true)
            {
                int pointsMainMenu = 4;

                Console.WriteLine("\nМеню приложения:");
                Console.WriteLine("1 - Меню работы с однонаправленным списком");
                Console.WriteLine("2 - Меню работы с двунаправленным списком");
                Console.WriteLine("3 - Меню работы с идеально сбалансированным деревом");
                Console.WriteLine("4 - Меню работы с обобщенной коллекцией");
                Console.WriteLine("0 - Выйти из приложения");

                int choiceMainMenu = InputInt(0, pointsMainMenu);

                if (choiceMainMenu == 0)
                {
                    Console.WriteLine("\n0 - Выход из приложения");
                    break;
                }

                switch (choiceMainMenu)
                {
                    case 1:
                        UniCaseMenu(ref uniListBeg);
                        break;
                    case 2:
                        BiCaseMenu(ref biListBeg);
                        break;
                    case 3:
                        TreeCaseMenu(ref pointTree);
                        break;
                    case 4:
                        PointTreeCaseMenu(ref tree);
                        break;
                }
            }
        }

        private static void UniCaseMenu(ref PointUniList beg)
        {
            while (true)
            {
                int pointsCaseMenu = 7;

                Console.WriteLine("\nМеню работы с однонаправленным списком:");
                Console.WriteLine("1 - Формирование однонаправленного списка");
                Console.WriteLine("2 - Добавление элемента в список");
                Console.WriteLine("3 - Удаление элемента из списка");
                Console.WriteLine("4 - Печать списка");
                Console.WriteLine("5 - Удаление из списка всех элементов с четными информационными полями");
                Console.WriteLine("6 - Удаление списка из памяти");
                Console.WriteLine("7 - Очистка истории");
                Console.WriteLine("0 - Выход из меню");

                int choiceCaseMenu = InputInt(0, pointsCaseMenu);

                if (choiceCaseMenu == 0)
                {
                    Console.WriteLine("\n0 - Выход из меню");
                    break;
                }

                switch (choiceCaseMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1 - Формирование однонаправленного списка");
                            Console.WriteLine("Введите количество объектов для формирования списка:");
                            int number = InputInt(1, PointUniList.maxCount);
                            Console.WriteLine("Список:");
                            beg = PointUniList.MakeList(number);
                            Console.WriteLine("Формирование однонаправленного списка завершено");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\n2 - Добавление элемента в список");
                            if (PointUniList.GetCount(beg) >= PointUniList.maxCount)
                            {
                                Console.WriteLine("Ошибка! Список имеет не меньше 100 элементов");
                                Console.WriteLine("Добавление элемента в список не завершено");
                                break;
                            } 
                            Console.WriteLine("Введите номер добавления элемента в список:");
                            int number = InputInt(1, PointUniList.GetCount(beg) + 1);
                            beg = PointUniList.AddPoint(beg, number);
                            Console.WriteLine("Добавление элемента в список завершено");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\n3 - Удаление элемента из списка");
                            if (beg == null) // пустой список
                            {
                                Console.WriteLine("Ошибка! Список пустой");
                                Console.WriteLine("Удаление элемента в список не завершено");
                                break;
                            }
                            Console.WriteLine("Введите номер удаления элемента в список:");
                            int number = InputInt(1, PointUniList.GetCount(beg));
                            beg = PointUniList.DelElement(beg, number);
                            Console.WriteLine("Удаление элемента из списка завершено");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\n4 - Печать списка");
                            PointUniList.ShowList(beg);
                            Console.WriteLine("Печать списка завершена");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\n5 - Удаление из списка всех элементов с четными информационными полями");
                            if (beg == null)
                            {
                                Console.WriteLine("Ошибка! Список пустой");
                                Console.WriteLine("Удаление из списка всех элементов с четными информационными полями не завершено");
                                break;
                            }
                            beg = PointUniList.DelEvenObjects(beg);
                            Console.WriteLine("Удаление из списка всех элементов с четными информационными полями завершено");
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("\n6 - Удаление списка из памяти");
                            beg = null;
                            Console.WriteLine("Удаление списка из памяти завершено");
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("История была очищена");
                        }
                        break;
                }
            }
        }

        private static void BiCaseMenu(ref PointBiList beg)
        {
            while (true)
            {
                int pointsCaseMenu = 7;

                Console.WriteLine("\nМеню работы с двунаправленным списком");
                Console.WriteLine("1 - Формирование двунаправленного списка");
                Console.WriteLine("2 - Добавление элемента в список");
                Console.WriteLine("3 - Удаление элемента из списка");
                Console.WriteLine("4 - Печать списка");
                Console.WriteLine("5 - Добавление в список элементов с номерами 1, 3, 5 и т.д.");
                Console.WriteLine("6 - Удаление списка из памяти");
                Console.WriteLine("7 - Очистка истории");
                Console.WriteLine("0 - Выход из меню");

                int choiceCaseMenu = InputInt(0, pointsCaseMenu);

                if (choiceCaseMenu == 0)
                {
                    Console.WriteLine("\n0 - Выход из меню");
                    break;
                }

                switch (choiceCaseMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1 - Формирование двунаправленного списка");
                            Console.WriteLine("Введите количество объектов для формирования списка:");
                            int number = InputInt(1, PointBiList.maxCount);
                            Console.WriteLine("Список:");
                            beg = PointBiList.MakeList(number);
                            Console.WriteLine("Формирование двунаправленного списка завершено");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\n2 - Добавление элемента в список");
                            if (PointBiList.GetCount(beg) >= PointBiList.maxCount)
                            {
                                Console.WriteLine("Ошибка! Список имеет не меньше 100 элементов");
                                Console.WriteLine("Добавление элемента в список не завершено");
                                break;
                            }
                            Console.WriteLine("Введите номер добавления объекта в список:");
                            int number = InputInt(1, PointBiList.GetCount(beg) + 1);
                            beg = PointBiList.AddPoint(beg, number);
                            Console.WriteLine("Добавление элемента в список завершено");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\n3 - Удаление элемента из списка");
                            if (beg == null) // пустой список
                            {
                                Console.WriteLine("Ошибка! Список пустой");
                                Console.WriteLine("Удаление элемента из списка не завершено");
                                break;
                            }
                            Console.WriteLine("Введите номер удаления элемента из списка:");
                            int number = InputInt(1, PointBiList.GetCount(beg));
                            beg = PointBiList.DelElement(beg, number);
                            Console.WriteLine("Удаление элемента из списка завершено");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\n4 - Печать списка");
                            PointBiList.ShowList(beg);
                            Console.WriteLine("Печать списка завершена");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\n5 - Добавление в список элементов с номерами 1, 3, 5 и т.д.");
                            if (PointBiList.GetCount(beg) >= PointBiList.maxCount)
                            {
                                Console.WriteLine("Ошибка! Список имеет не меньше 100 элементов");
                                Console.WriteLine("Добавление в список элементов с номерами 1, 3, 5 и т.д. не завершено");
                                break;
                            }
                            beg = PointBiList.AddOddObjects(beg);
                            Console.WriteLine("Добавление в список элементов с номерами 1, 3, 5 и т.д. завершено");
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("\n6 - Удаление списка из памяти");
                            beg = null;
                            Console.WriteLine("Удаление списка из памяти завершено");
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("История была очищена");
                        }
                        break;
                }
            }
        }

        private static void TreeCaseMenu(ref PointTree pointTree)
        {
            while (true)
            {
                int pointsCaseMenu = 7;

                Console.WriteLine("\nМеню работы с идеально сбалансированным деревом:");
                Console.WriteLine("1 - Формирование дерева");
                Console.WriteLine("2 - Добавление элемента в дерево");
                Console.WriteLine("3 - Печать дерева");
                Console.WriteLine("4 - Поиск максимального элемента в дереве");
                Console.WriteLine("5 - Удаление дерева из памяти");
                Console.WriteLine("6 - Создание дерева поиска");
                Console.WriteLine("7 - Очистка истории");
                Console.WriteLine("0 - Выход из меню");

                int choiceCaseMenu = InputInt(0, pointsCaseMenu);

                if (choiceCaseMenu == 0)
                {
                    Console.WriteLine("\n0 - Выход из меню");
                    break;
                }

                switch (choiceCaseMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1 - Формирование дерева");
                            Console.WriteLine("Для формирования дерева создается корень:");
                            Animals a = new Animals();
                            pointTree = new PointTree(a.CreateObjectAnimalsRandom());
                            Console.WriteLine("Формирование дерева завершено");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\n2 - Добавление элемента в дерево");
                            pointTree.Add(new Animals().CreateObjectAnimalsRandom());
                            Console.WriteLine("Добавление элемента в дерево завершено");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\n3 - Печать дерева");
                            if (pointTree == null)
                            {
                                Console.WriteLine("Дерево пустое");
                            }
                            else
                            {
                                Console.WriteLine("Дерево:");
                                pointTree.ShowTree(pointTree.Root, 0);
                            }
                            Console.WriteLine("\nПечать дерева завершено");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\n4 - Поиск максимального элемента в дереве");
                            Animals a = pointTree.FindMax();
                            if (a.Weight == 1)
                            {
                                Console.WriteLine("Ошибка! В дереве нет объектов, следовательно нет максимального элемента");
                                Console.WriteLine("Поиск максимального элемента в дереве не завершено");
                                break;
                            }
                            Console.WriteLine("Максимальный объект в дереве равен " + a.Weight);
                            Console.WriteLine("Поиск максимального элемента в дереве завершено");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\n5 - Удаление дерева из памяти");
                            pointTree = new PointTree();
                            Console.WriteLine("Удаление дерева из памяти завершено");
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("\n6 - Создание дерева поиска");
                            if (pointTree.Root == null)
                            {
                                Console.WriteLine("Ошибка! Дерево не имеет начала");
                                Console.WriteLine("Создание дерева поиска не завершено");
                                break;
                            }
                            pointTree.CreateFindTree();
                            Console.WriteLine("Дерево: ");
                            pointTree.ShowTree(pointTree.Root, 0);
                            Console.WriteLine("Создание дерева завершено");
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("История была очищена");
                        }
                        break;
                }
            }
        }

        private static void PointTreeCaseMenu(ref Tree<Animals> tree)
        {
            while (true)
            {
                int pointsCaseMenu = 9;

                Console.WriteLine("\nМеню работы с обобщенной коллекцией:");
                Console.WriteLine("1 - Формирование дерева");
                Console.WriteLine("2 - Добавление элемента в дерево");
                Console.WriteLine("3 - Добавление элементов в дерево");
                Console.WriteLine("4 - Печать дерева");
                Console.WriteLine("5 - Поиск элемента по значению в дереве");
                Console.WriteLine("6 - Поверхностное клонирование дерева");
                Console.WriteLine("7 - Идеальное клонирование дерева");
                Console.WriteLine("8 - Удаление дерева из памяти");
                Console.WriteLine("9 - Очистка истории");
                Console.WriteLine("0 - Выход из меню");

                int choiceCaseMenu = InputInt(0, pointsCaseMenu);

                if (choiceCaseMenu == 0)
                {
                    Console.WriteLine("\n0 - Выход из меню");
                    break;
                }

                switch (choiceCaseMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1 - Формирование дерева");
                            Console.WriteLine("Для формирования дерева введите количество элементов в предполагаемом дереве:");
                            Animals[] animals = new Animals[InputInt(1, 100)];
                            for (int i = 0; i < animals.Length; i++)
                            {
                                animals[i] = new Animals();
                                animals[i] = animals[i].CreateObjectAnimalsRandom();
                            }
                            tree = new Tree<Animals>(animals);
                            Console.WriteLine("Формирование дерева завершено");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\n2 - Добавление элемента в дерево");
                            if (tree == null)
                            {
                                Console.WriteLine("Ошибка! Дерево не создано");
                                Console.WriteLine("Добавление элемента в дерево не завершено");
                                break;
                            }
                            tree.Add(new Animals().CreateObjectAnimalsRandom());
                            Console.WriteLine("Добавление элемента в дерево завершено");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\n3 - Добавление элементов в дерево");
                            if (tree == null)
                            {
                                Console.WriteLine("Ошибка! Дерево не создано");
                                Console.WriteLine("Добавление элементов в дерево не завершено");
                                break;
                            }
                            Console.WriteLine("Введите количество элементов для добавления в дерево: ");
                            Animals[] animals = new Animals[InputInt(1, 10)];
                            for (int i = 0; i < animals.Length; i++)
                            {
                                animals[i] = new Animals();
                                animals[i] = animals[i].CreateObjectAnimalsRandom();
                            }
                            tree.Add(animals);
                            Console.WriteLine("Добавление элементов в дерево завершено");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\n4 - Печать дерева");
                            if (tree == null)
                            {
                                Console.WriteLine("Дерево пустое");
                            }
                            else
                            {
                                Console.WriteLine("Дерево:");
                                Tree<Animals>.ShowTree(tree.root, 0);
                                Console.WriteLine("foreach:");
                                foreach (var item in tree)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }
                            Console.WriteLine("Печать дерева завершена");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\n5 - Поиск элемента по значению в дереве");
                            Console.WriteLine("Введите имя, вид и вес элемента для его поиска в дереве");
                            Animals animal = new Animals(InputString(), InputString(), InputInt(1, 10000));
                            if (!tree.Find(animal)) Console.WriteLine("В дереве нет искомого элемента");
                            else Console.WriteLine("В дереве найден искомый элемент");
                            Console.WriteLine("Поиск элемента по значению в дереве завершен");
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("\n6 - Поверхностное клонирование дерева");
                            Point<Animals> shallowCopyTree = (Point<Animals>)tree.ShallowCopy();
                            Console.WriteLine("Поверхностное клонирование дерева завершено");
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("\n7 - Идеальное клонирование дерева");
                            Point<Animals> copyTree = (Point<Animals>)tree.Clone();
                            Console.WriteLine("Идеальное клонирование дерева завершено");
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("\n8 - Удаление дерева из памяти");
                            tree.Clear();
                            Console.WriteLine("Удаление дерева из памяти завершено");
                        }
                        break;
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("История была очищена");
                        }
                        break;
                }
            }
        }

        private static string InputString()
        {
            string input;
            bool inputCheck;
            do
            {
                Console.Write("Ввод: ");
                input = Console.ReadLine();
                inputCheck = input.Trim().Length > 0;
                if (!inputCheck) Console.WriteLine("Ошибка ввода! Введите не пустые данные");
            } while (!inputCheck);
            return input;
        }

        private static int InputInt(int min, int max)
        {
            int number;
            bool inputCheck;
            do
            {
                Console.Write("Ввод: ");
                inputCheck = int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;
                if (!inputCheck) Console.WriteLine("Ошибка ввода! Введите целое число в пределах от {0} до {1} (включительно)", min, max);
            } while (!inputCheck);
            return number;
        }
    }
}