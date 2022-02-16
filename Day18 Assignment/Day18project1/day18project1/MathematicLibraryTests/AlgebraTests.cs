using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_input()
        {
            //Arrange
            int n = 0;
            int expected = 1;
            //Act
            int actual=Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_One_To_Seven_Input()
        {
            //Arrange
            int n = 5;
            int expected = 120;
            //Act
            int actual = Algebra.Factorial(n);  
            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void FactorialTest_greater_than_Seven_Input()
        {
            //Arrange
            int n = 9;
            int expected = -999 ;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual (expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negitive_Input()
        {
            //Arrange
            int n = -3;
            int expected =-9999  ;
            //Act
            int actual=Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected , actual);
        }
        [TestMethod()]
        public void Test_palidrom_or_Not()
        {
            
        }

        }
}