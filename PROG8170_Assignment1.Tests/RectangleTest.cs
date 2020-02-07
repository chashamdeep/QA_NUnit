using NUnit.Framework;

namespace PROG8170_Assignment1.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        int actualOutput;
        [SetUp]
        public void Setup()
        {
            Rectangle rec = new Rectangle();
        }

        //Test Cases for GetLength()
        [Test]
        public void GetLength_ActualInput6_ExpectedOutput6()
        {
            Rectangle rec = new Rectangle(6, 8);
            actualOutput = rec.GetLength();
            Assert.AreEqual(6, actualOutput);
        }
        [Test]
        public void GetLength_ActualInput0_ExpectedOutput0()
        {
            Rectangle rec = new Rectangle(0, 8);
            actualOutput = rec.GetLength();
            Assert.AreEqual(0, actualOutput);
        }
        [Test]
        public void GetLength_ActualInput6_ExpectedOutput7()
        {
            var rec = new Rectangle(6, 7);
            actualOutput = rec.GetLength();
            Assert.AreEqual(7, actualOutput, "Failed Intentioanlly");
        }

        //Test Cases for SetLength()
        [Test]
        public void SetLength_SetLengthTo5_ExpectedOutput5()
        {
            Rectangle rec = new Rectangle(3, 8);
            actualOutput = rec.SetLength(5);
            Assert.AreEqual(5, actualOutput);
        }
        [Test]
        public void SetLength_SetLengthTo9_ExpectedOutput9()
        {
            var rec = new Rectangle(9, 5);
            actualOutput = rec.SetLength(9);
            Assert.AreEqual(9, actualOutput);
        }
        [Test]
        public void SetLength_SetLengthTo8_ExpectedOutput5()
        {
            var rec = new Rectangle(1, 5);
            actualOutput = rec.SetLength(8);
            Assert.AreEqual(5, actualOutput, "Failed Intentioanlly");
        }
        //Test Cases for GetWidth()
        [Test]
        public void GetWidth_ActualInput6_ExpectedOutput6()
        {
            Rectangle rec = new Rectangle(8, 6);
            actualOutput = rec.GetWidth();
            Assert.AreEqual(6, actualOutput);
        }
        [Test]
        public void GetWidth_ActualInput0_ExpectedOutput0()
        {
            Rectangle rec = new Rectangle(8, 0);
            actualOutput = rec.GetWidth();
            Assert.AreEqual(0, actualOutput);
        }
        [Test]
        public void GetWidth_ActualInput6_ExpectedOutput7()
        {
            var rec = new Rectangle(7, 6);
            actualOutput = rec.GetWidth();
            Assert.AreEqual(7, actualOutput, "Failed Intentioanlly");
        }
        //Test Cases for SetWidth()
        [Test]
        public void SetWidth_SetWidthTo5_ExpectedOutput5()
        {
            Rectangle rec = new Rectangle(3, 8);
            actualOutput = rec.SetWidth(5);
            Assert.AreEqual(5, actualOutput);
        }
        [Test]
        public void SetWidth_SetWidthTo9_ExpectedOutput9()
        {
            var rec = new Rectangle(9, 5);
            actualOutput = rec.SetWidth(9);
            Assert.AreEqual(9, actualOutput);
        }
        [Test]
        public void SetWidth_SetWidthTo8_ExpectedOutput5()
        {
            var rec = new Rectangle(1, 5);
            actualOutput = rec.SetWidth(8);
            Assert.AreEqual(5, actualOutput, "Failed Intentioanlly");
        }
        //Test Cases for GetArea()
        [Test]
        public void GetArea_ActutalInputs2_5_ExpectedOutput10()
        {
            var rec = new Rectangle(2, 5);
            actualOutput = rec.GetArea();
            Assert.AreEqual(10, actualOutput);
        }
        [Test]
        public void GetArea_ActutalInputs5_5_ExpectedOutput25()
        {
            var rec = new Rectangle(5, 5);
            actualOutput = rec.GetArea();
            Assert.AreEqual(25, actualOutput);
        }
        [Test]
        public void GetArea_ActutalInputs3_5_ExpectedOutput15()
        {
            var rec = new Rectangle(3, 5);
            actualOutput = rec.GetArea();
            Assert.AreEqual(20, actualOutput, "Failed Intentioanlly");
        }
        //Test Cases for GetPerimeter()
        [Test]
        public void GetPereimeter_ActualInputs8_5_ExpectedOutput26()
        {
            var rec = new Rectangle(8, 5);
            actualOutput = rec.GetPerimeter();
            Assert.AreEqual(26, actualOutput);
        }
        [Test]
        public void GetPereimeter_ActualInputs2_3_ExpectedOutput10()
        {
            var rec = new Rectangle(2, 3);
            actualOutput = rec.GetPerimeter();
            Assert.AreEqual(10, actualOutput);
        }
        [Test]
        public void GetPereimeter_ActualInputs4_4_ExpectedOutput16()
        {
            var rec = new Rectangle(4, 4);
            actualOutput = rec.GetPerimeter();
            Assert.AreEqual(20, actualOutput, "Failed Intentioanlly");
        }

    }
}