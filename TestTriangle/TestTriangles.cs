﻿
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

            int side1 = 4;
            int side2 = 4;
            int side3 = 4;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act

            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert

            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void AnalyzeTriangle_Input5and5and8_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;
            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]

        public void AnalyzeTriangle_Input5and5and3_OutputIsoscelesTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 3;
            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void AnalyzeTriangle_Input8and5and8_OutputIsoscelesTriangle()
        {
            // Arrange
            int side1 = 8;
            int side2 = 5;
            int side3 = 8;
            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

      
        public void AnalyzeTriangle_Input3and4and5_OutputValidScaleneTriangle()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input7and9and11_OutputValidScaleneTriangle()
        {
            // Arrange
            int side1 = 7;
            int side2 = 9;
            int side3 = 11;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void AnalyzeTriangle_Input12and16and20_OutputValidScaleneTriangle()
        {
            // Arrange
            int side1 = 12;
            int side2 = 16;
            int side3 = 20;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input9and13and15_OutputValidScaleneTriangle()
        {
            // Arrange
            int side1 = 9;
            int side2 = 13;
            int side3 = 15;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input5and12and13_OutputValidScaleneTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 12;
            int side3 = 13;
            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthFirstSide_ReturnsErrorMessage()
        {
            // Arrange
            int side1 = 0;
            int side2 = 2;
            int side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSecondSide_ReturnsErrorMessage()
        {
            // Arrange
            int side1 = 1;
            int side2 = 0;
            int side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthThirdSide_ReturnsErrorMessage()
        {
            // Arrange
            int side1 = 2;
            int side2 = 3;
            int side3 = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse_WhenSumOfTwoSidesIsEqualToThirdSide()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse_WhenSumOfTwoSidesIsLessThanThirdSide()
        {
            // Arrange
            int side1 = 5;
            int side2 = 10;
            int side3 = 25;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse_WhenOneSideIsGreaterThanSumOfOtherTwoSides()
        {
            // Arrange
            int side1 = 10;
            int side2 = 15;
            int side3 = 30;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }
    }
}