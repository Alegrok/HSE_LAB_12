//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using HSE_LAB_12;

//namespace UnitTestProjectLab12
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod01()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList();
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod02()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod03()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            pointUniList = PointUniList.MakeList(3);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 3);
//        }

//        [TestMethod]
//        public void TestMethod04()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            PointUniList.ShowList(pointUniList);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod05()
//        {
//            PointUniList pointUniList = null;
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod06()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 2);
//        }

//        [TestMethod]
//        public void TestMethod07()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 4);
//        }

//        [TestMethod]
//        public void TestMethod08()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.DelElement(pointUniList, 1);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 3);
//        }

//        [TestMethod]
//        public void TestMethod09()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.AddPoint(pointUniList, 1);
//            pointUniList = PointUniList.AddPoint(pointUniList, 3);
//            pointUniList = PointUniList.DelElement(pointUniList, 3);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 3);
//        }

//        [TestMethod]
//        public void TestMethod10()
//        {
//            PointUniList pointUniList = null;
//            pointUniList = PointUniList.DelEvenObjects(pointUniList);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 0);
//        }

//        [TestMethod]
//        public void TestMethod11()
//        {
//            PointUniList pointUniList = new HSE_LAB_12.PointUniList(new Animals());
//            pointUniList = PointUniList.DelEvenObjects(pointUniList);
//            int number = PointUniList.GetCount(pointUniList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod12()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList();
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod13()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod14()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            int number = PointBiList.GetCount(pointBiList);
//            pointBiList = PointBiList.MakeList(3);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod15()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            int number = PointBiList.GetCount(pointBiList);
//            PointBiList.ShowList(pointBiList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod16()
//        {
//            PointBiList pointBiList = null;
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 1);
//        }

//        [TestMethod]
//        public void TestMethod17()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 2);
//        }

//        [TestMethod]
//        public void TestMethod18()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 4);
//        }

//        [TestMethod]
//        public void TestMethod19()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.DelElement(pointBiList, 1);
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 3);
//        }

//        [TestMethod]
//        public void TestMethod20()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.DelElement(pointBiList, 3);
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 3);
//        }

//        [TestMethod]
//        public void TestMethod21()
//        {
//            PointBiList pointBiList = new HSE_LAB_12.PointBiList(new Animals());
//            pointBiList = PointBiList.AddPoint(pointBiList, 1);
//            pointBiList = PointBiList.AddOddObjects(pointBiList);
//            int number = PointBiList.GetCount(pointBiList);
//            Assert.AreEqual(number, 5);
//        }

//        [TestMethod]
//        public void TestMethod22()
//        {
//            PointTree pointTree = new HSE_LAB_12.PointTree();
//            bool create = pointTree != null ? true : false;
//            Assert.AreEqual(true, create);
//        }

//        [TestMethod]
//        public void TestMethod23()
//        {
//            PointTree pointTree = new HSE_LAB_12.PointTree(new Animals());
//            bool create = pointTree != null ? true : false;
//            Assert.AreEqual(true, create);
//        }

//        [TestMethod]
//        public void TestMethod24()
//        {
//            PointTree pointTree = new HSE_LAB_12.PointTree(new Animals());
//            pointTree = PointTree.Add(pointTree, new Animals());
//            bool create = pointTree != null ? true : false;
//            Assert.AreEqual(true, create);
//        }

//        [TestMethod]
//        public void TestMethod25()
//        {
//            PointTree pointTree = new HSE_LAB_12.PointTree(new Animals());
//            PointTree.FindMaxElement(pointTree); 
//            bool create = pointTree != null ? true : false;
//            Assert.AreEqual(true, create);
//        }

//        [TestMethod]
//        public void TestMethod26()
//        {
//            PointTree pointTree = new HSE_LAB_12.PointTree(new Animals());
//            PointTree.IdealTree(3, pointTree);
//            bool create = pointTree != null ? true : false;
//            Assert.AreEqual(true, create);
//        }
//    }
//}
