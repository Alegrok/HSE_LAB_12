using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSE_LAB_12;

namespace UnitTestProjectLab10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            // Arrange
            Animals animals1 = new Animals();
            // Act
            Animals animals2 = new Animals("Неизвестный", "Неизвестный", 1);
            // Assert
            Assert.AreEqual(animals1, animals2);
        }

        [TestMethod]
        public void TestMethod02()
        {
            // Arrange
            Animals animals1 = new Animals();
            // Act
            Animals animals2 = new Animals("  ", "  ", 12000);
            // Assert
            Assert.AreEqual(animals1, animals2);
        }

        [TestMethod]
        public void TestMethod03()
        {
            // Arrange
            Animals animals1 = new Animals();
            // Act
            Animals animals2 = new Animals("  ", "  ", -5);
            // Assert
            Assert.AreEqual(animals1, animals2);
        }

        [TestMethod]
        public void TestMethod04()
        {
            // Arrange
            Animals animals1 = new Animals();
            // Act
            Animals animals2 = (Animals)animals1.Clone();
            // Assert
            Assert.AreEqual(animals1, animals2);
        }


        [TestMethod]
        public void TestMethod05()
        {
            // Arrange
            Animals animals1 = new Animals();
            // Act
            Animals animals2 = animals1.ShallowCopy();
            // Assert
            Assert.AreEqual(animals1, animals2);
        }

        [TestMethod]
        public void TestMethod06()
        {
            // Arrange
            Animals animals1 = new Animals();
            // Act
            Animals animals2 = animals1.ShallowCopy();
            // Assert
            Assert.AreEqual(animals1, animals2);
        }

        [TestMethod]
        public void TestMethod07()
        {
            // Arrange
            Artiodactyls artiodactyls1 = new Artiodactyls();
            // Act
            Artiodactyls artiodactyls2 = new Artiodactyls("Неизвестный", "Неизвестный", 1, 1, 1);
            // Assert
            Assert.AreEqual(artiodactyls1, artiodactyls2);
        }

        [TestMethod]
        public void TestMethod08()
        {
            // Arrange
            Artiodactyls artiodactyls1 = new Artiodactyls();
            // Act
            Artiodactyls artiodactyls2 = new Artiodactyls("Неизвестный", "Неизвестный", 1, 1, 1);
            // Assert
            Assert.AreEqual(artiodactyls1, artiodactyls2);
        }

        [TestMethod]
        public void TestMethod09()
        {
            // Arrange
            Artiodactyls artiodactyls1 = new Artiodactyls();
            // Act
            Artiodactyls artiodactyls2 = new Artiodactyls("Неизвестный", "Неизвестный", 1, 1, -1);
            // Assert
            Assert.AreEqual(artiodactyls1, artiodactyls2);
        }

        [TestMethod]
        public void TestMethod10()
        {
            // Arrange
            Artiodactyls artiodactyls1 = new Artiodactyls();
            // Act
            Artiodactyls artiodactyls2 = new Artiodactyls("Неизвестный", "Неизвестный", 1, 1, 100);
            // Assert
            Assert.AreEqual(artiodactyls1, artiodactyls2);
        }

        [TestMethod]
        public void TestMethod11()
        {
            // Arrange
            Birds birds1 = new Birds();
            // Act
            Birds birds2 = new Birds("Неизвестный", "Неизвестный", 1, 1);
            // Assert
            Assert.AreEqual(birds1, birds2);
        }

        [TestMethod]
        public void TestMethod12()
        {
            // Arrange
            Birds birds1 = new Birds();
            // Act
            Birds birds2 = new Birds("Неизвестный", "Неизвестный", 1, -1);
            // Assert
            Assert.AreEqual(birds1, birds2);
        }

        [TestMethod]
        public void TestMethod13()
        {
            // Arrange
            Birds birds1 = new Birds();
            // Act
            Birds birds2 = new Birds("Неизвестный", "Неизвестный", 1, 100);
            // Assert
            Assert.AreEqual(birds1, birds2);
        }

        [TestMethod]
        public void TestMethod14()
        {
            // Arrange
            Mammals mammals1 = new Mammals();
            // Act
            Mammals mammals2 = new Mammals("Неизвестный", "Неизвестный", 1, 1);
            // Assert
            Assert.AreEqual(mammals1, mammals2);
        }

        [TestMethod]
        public void TestMethod15()
        {
            // Arrange
            Mammals mammals1 = new Mammals();
            // Act
            Mammals mammals2 = new Mammals("Неизвестный", "Неизвестный", 1, -1);
            // Assert
            Assert.AreEqual(mammals1, mammals2);
        }

        [TestMethod]
        public void TestMethod16()
        {
            // Arrange
            Mammals mammals1 = new Mammals();
            // Act
            Mammals mammals2 = new Mammals("Неизвестный", "Неизвестный", 1, 1000);
            // Assert
            Assert.AreEqual(mammals1, mammals2);
        }
    }
}
