using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogiCal;

namespace UnitTests
{
    [TestClass]
    public class TestParsing
    {
        [TestMethod]
        [ExpectedException(typeof(MissingBracketException))]
        public void TestParsing1()
        {
            //Arrange
            Parser p = new Parser();
            Node n = p.ParseExpression(">(>(|(P,Q),R),|(>(P,R),>(Q,R))");

            //Act

            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidCharacterException))]
        public void TestParsing2()
        {
            //Arrange
            Parser p = new Parser();
            Node n = p.ParseExpression(">(>(|(*,Q),R),|(>(P,R),>(Q,R))");

            //Act

            //Assert
        }
        [TestMethod]
        public void TestParsing3()
        {
            //Arrange
            Parser p = new Parser();
            string input = ">(@x.(P(x)),>(%(>(|(!x.(Y(x)),Q),R),R),|(>(P,R),>(Q,R))))";
            Node n = p.ParseExpression(input);

            //Act
            string result = n.ToPrefixString();

            //Assert
            Assert.AreEqual(input, result);
        }
        [TestMethod]
        public void TestCopy()
        {
            //Arrange
            Parser p = new Parser();
            string input = ">(@x.(P(x)),>(%(>(|(!x.(Y(x)),Q),R),R),|(>(P,R),>(Q,R))))";
            Node n = p.ParseExpression(input).Copy();

            //Act
            string result = n.ToPrefixString();

            //Assert
            Assert.AreEqual(input, result);
        }
        [TestMethod]
        public void TestNandify()
        {
            //Arrange
            Parser p = new Parser();
            string input = ">(>(|(P,Q),R),|(>(P,R),>(Q,R)))";
            Node n = p.ParseExpression(input);

            //Act
            string result = n.Nandify().ToPrefixString();

            //Assert
            Assert.AreEqual("%(%(%(%(P,P),%(Q,Q)),%(R,R)),%(%(%(%(P,%(R,R)),%(P,%(R,R))),%(%(Q,%(R,R)),%(Q,%(R,R)))),%(%(%(P,%(R,R)),%(P,%(R,R))),%(%(Q,%(R,R)),%(Q,%(R,R))))))", result);
        }
        [TestMethod]
        public void TestHexHash()
        {
            //Arrange
            Parser p = new Parser();
            string input = ">(A,|(&(D,A),C))";
            Node n = p.ParseExpression(input);
            TruthTable truthTable = new TruthTable(new char[]{ 'A', 'C', 'D' }, n);

            //Act
            string result = truthTable.HexHashValue;

            //Assert
            Assert.AreEqual("EF", result);
        }
        [TestMethod]
        public void TestBinHash()
        {
            //Arrange
            Parser p = new Parser();
            string input = ">(A,|(&(D,A),C))";
            Node n = p.ParseExpression(input);
            TruthTable truthTable = new TruthTable(new char[] { 'A', 'C', 'D' }, n);

            //Act
            string result = truthTable.BinHashValue;

            //Assert
            Assert.AreEqual("11101111", result);
        }
    }
}
