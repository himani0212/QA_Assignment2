
using TriangleSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestTriangle
{
    [TestFixture]
    public class TestTriangles
    {
        [Test]

        public void AnalyzeTriangle_Input4and4and4_OutputEquiTriangle()
        {
            //Arrange

            int a = 4;
            int b = 4;
            int c = 4;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act

            string actual = Triangle.AnalyzeTriangle(a, b, c);

            //Assert

            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void AnalyzeTriangle_Input5and5and8_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int c = 8;
            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]

        public void AnalyzeTriangle_Input5and5and3_OutputIsoscelesTriangle()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int c = 3;
            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void AnalyzeTriangle_Input8and5and8_OutputIsoscelesTriangle()
        {
            // Arrange
            int a = 8;
            int b = 5;
            int c = 8;
            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

      
        public void AnalyzeTriangle_Input3and4and5_OutputValidScaleneTriangle()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input7and9and11_OutputValidScaleneTriangle()
        {
            // Arrange
            int a = 7;
            int b = 9;
            int c = 11;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void AnalyzeTriangle_Input12and16and20_OutputValidScaleneTriangle()
        {
            // Arrange
            int a = 12;
            int b = 16;
            int c = 20;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input9and13and15_OutputValidScaleneTriangle()
        {
            // Arrange
            int a = 9;
            int b = 13;
            int c = 15;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input5and12and13_OutputValidScaleneTriangle()
        {
            // Arrange
            int a = 5;
            int b = 12;
            int c = 13;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthFirstSide_ReturnsErrorMessage()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 2;
            int thirdSide = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSecondSide_ReturnsErrorMessage()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 0;
            int thirdSide = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthThirdSide_ReturnsErrorMessage()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse_WhenSumOfTwoSidesIsEqualToThirdSide()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse_WhenSumOfTwoSidesIsLessThanThirdSide()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 10;
            int thirdSide = 25;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse_WhenOneSideIsGreaterThanSumOfOtherTwoSides()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 15;
            int thirdSide = 30;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }
    }
}