using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSE_LAB_12;

namespace UnitTestProjectLab12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            PointUniList pointUniList = new PointUniList();
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod02()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod03()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            pointUniList = PointUniList.MakeList(3);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 3);
        }

        [TestMethod]
        public void TestMethod04()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            PointUniList.ShowList(pointUniList);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod05()
        {
            PointUniList pointUniList = null;
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod06()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 2);
        }

        [TestMethod]
        public void TestMethod07()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 4);
        }

        [TestMethod]
        public void TestMethod08()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.DelElement(pointUniList, 1);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 3);
        }

        [TestMethod]
        public void TestMethod09()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.AddPoint(pointUniList, 1);
            pointUniList = PointUniList.AddPoint(pointUniList, 3);
            pointUniList = PointUniList.DelElement(pointUniList, 3);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 3);
        }

        [TestMethod]
        public void TestMethod10()
        {
            PointUniList pointUniList = null;
            pointUniList = PointUniList.DelEvenObjects(pointUniList);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 0);
        }

        [TestMethod]
        public void TestMethod11()
        {
            PointUniList pointUniList = new PointUniList(new Animals());
            pointUniList = PointUniList.DelEvenObjects(pointUniList);
            int number = PointUniList.GetCount(pointUniList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod12()
        {
            PointBiList pointBiList = new PointBiList();
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod13()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod14()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            int number = PointBiList.GetCount(pointBiList);
            pointBiList = PointBiList.MakeList(3);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod15()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            int number = PointBiList.GetCount(pointBiList);
            PointBiList.ShowList(pointBiList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod16()
        {
            PointBiList pointBiList = null;
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 1);
        }

        [TestMethod]
        public void TestMethod17()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 2);
        }

        [TestMethod]
        public void TestMethod18()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 4);
        }

        [TestMethod]
        public void TestMethod19()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.DelElement(pointBiList, 1);
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 3);
        }

        [TestMethod]
        public void TestMethod20()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.DelElement(pointBiList, 3);
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 3);
        }

        [TestMethod]
        public void TestMethod21()
        {
            PointBiList pointBiList = new PointBiList(new Animals());
            pointBiList = PointBiList.AddPoint(pointBiList, 1);
            pointBiList = PointBiList.AddOddObjects(pointBiList);
            int number = PointBiList.GetCount(pointBiList);
            Assert.AreEqual(number, 5);
        }

        [TestMethod]
        public void TestMethod22()
        {
            PointTree pointTree = new PointTree();
            int number = pointTree.Count;
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void TestMethod23()
        {
            PointTree pointTree = new PointTree(new Animals("", "", 1));
            int number = pointTree.Count;
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void TestMethod24()
        {
            PointTree pointTree = new PointTree(new Animals("", "", 1));
            pointTree.Add(new Animals());
            int number = pointTree.Count;
            Assert.AreEqual(2, number);
        }

        [TestMethod]
        public void TestMethod25()
        {
            PointTree pointTree = new PointTree(new Animals("A", "A", 10000));
            pointTree.Add(new Animals("A", "B", 300));
            pointTree.Add(new Animals("A", "C", 3600));
            pointTree.Add(new Animals("B", "B", 4300));
            Animals a = pointTree.FindMax();
            Assert.AreEqual(a, new Animals("A", "A", 10000));
        }

        [TestMethod]
        public void TestMethod26()
        {
            Animals a = new Animals();
            PointTree pointTree = new PointTree(new Animals());
            pointTree.Add((Animals)a.CreateObjectAnimalsRandom().Clone());
            pointTree.Add((Animals)a.CreateObjectAnimalsRandom().Clone());
            pointTree.Add((Animals)a.CreateObjectAnimalsRandom().Clone());
            pointTree.CreateFindTree();
            int number = pointTree.Count;
            Assert.AreEqual(4, number);
        }

        [TestMethod]
        public void TestMethod27()
        {
            Tree<Animals> tree = new Tree<Animals>();
            int number = tree.Count;
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void TestMethod28()
        {
            Animals[] animals = new Animals[3];
            Tree<Animals> tree = new Tree<Animals>(animals);
            int number = tree.Count;
            Assert.AreEqual(3, number);
        }

        [TestMethod]
        public void TestMethod29()
        {
            Animals[] animals = new Animals[3];
            Tree<Animals> tree = new Tree<Animals>(animals);
            tree.Add(new Animals());
            int number = tree.Count;
            Assert.AreEqual(4, number);
        }

        [TestMethod]
        public void TestMethod30()
        {
            Animals[] animals = new Animals[3];
            Animals[] animals2 = new Animals[2];
            Tree<Animals> tree = new Tree<Animals>(animals);
            tree.Add(animals2);
            int number = tree.Count;
            Assert.AreEqual(5, number);
        }

        [TestMethod]
        public void TestMethod31()
        {
            Tree<Animals> tree = new Tree<Animals>(new Animals());
            tree.Add(new Animals("A", "A", 10));
            bool find = tree.Find(new Animals("A", "A", 10));
            Assert.AreEqual(true, find);
        }
    }
}
