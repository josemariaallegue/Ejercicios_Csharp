using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SumaMetodo()
        {
            BasicMaths b = new BasicMaths();
            double resultado = b.suma(10, 10);
            Assert.AreEqual(20, resultado);
        }
        [TestMethod]
        public void Test_RestaMetodo()
        {
            BasicMaths b = new BasicMaths();
            double resultado = b.resta(10, 10);
            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void Test_DivisionMetodo()
        {
            BasicMaths b = new BasicMaths();
            double resultado = b.division(10, 10);
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void Test_MultiplicacionMetodo()
        {
            BasicMaths b = new BasicMaths();
            double resultado = b.multiplicacion(10, 10);
            Assert.AreEqual(100, resultado);
        }
    }        
}
